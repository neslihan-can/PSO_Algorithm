using System;
using System.Collections.Generic;
using System.Linq;

public class PSOAlgorithm
{
    private int particleCount;
    private int dimension;
    private int maxIterations;
    private double lowerBound;
    private double upperBound;
    private double c1, c2;

    private Random rand;
    private List<Particle> particles;
    private double[] globalBestPosition;
    private double globalBestFitness;

    public List<double> bestFitnessPerIteration;

    public PSOAlgorithm(int particleCount, int dimension, int maxIterations,
                        double lowerBound, double upperBound, double c1, double c2)
    {
        this.particleCount = particleCount;
        this.dimension = dimension;
        this.maxIterations = maxIterations;
        this.lowerBound = lowerBound;
        this.upperBound = upperBound;
        this.c1 = c1;
        this.c2 = c2;

        rand = new Random();
        particles = new List<Particle>();
        globalBestPosition = new double[dimension];
        globalBestFitness = double.MaxValue;
        bestFitnessPerIteration = new List<double>();
    }

    public void Initialize()
    {
        particles.Clear();
        for (int i = 0; i < particleCount; i++)
        {
            Particle p = new Particle(dimension);
            for (int d = 0; d < dimension; d++)
            {
                p.Position[d] = lowerBound + rand.NextDouble() * (upperBound - lowerBound);
                p.Velocity[d] = (rand.NextDouble() * 2 - 1) * (upperBound - lowerBound) * 0.1;
                p.BestPosition[d] = p.Position[d];
            }

            p.Fitness = ObjectiveFunction.Calculate(p.Position);
            p.BestFitness = p.Fitness;

            if (p.Fitness < globalBestFitness)
            {
                globalBestFitness = p.Fitness;
                Array.Copy(p.Position, globalBestPosition, dimension);
            }

            particles.Add(p);
        }
    }

    private void UpdateVelocityAndPosition(Particle p)
    {
        for (int d = 0; d < dimension; d++)
        {
            double r1 = rand.NextDouble();
            double r2 = rand.NextDouble();

            // Velocity update
            p.Velocity[d] = p.Velocity[d]
                          + c1 * r1 * (p.BestPosition[d] - p.Position[d])
                          + c2 * r2 * (globalBestPosition[d] - p.Position[d]);

            // Position update
            p.Position[d] += p.Velocity[d];

            // Bound check
            p.Position[d] = Math.Max(lowerBound, Math.Min(upperBound, p.Position[d]));
        }
    }

    public void Run()
    {
        Initialize();

        for (int iter = 0; iter < maxIterations; iter++)
        {
            foreach (var p in particles)
            {
                UpdateVelocityAndPosition(p);

                p.Fitness = ObjectiveFunction.Calculate(p.Position);

                if (p.Fitness < p.BestFitness)
                {
                    p.BestFitness = p.Fitness;
                    Array.Copy(p.Position, p.BestPosition, dimension);
                }

                if (p.Fitness < globalBestFitness)
                {
                    globalBestFitness = p.Fitness;
                    Array.Copy(p.Position, globalBestPosition, dimension);
                }
            }

            bestFitnessPerIteration.Add(globalBestFitness);
        }
    }

    public double[] GetBestPosition() => globalBestPosition;
    public double GetBestFitness() => globalBestFitness;
}
