public class Particle
{
    public double[] Position { get; set; }
    public double[] Velocity { get; set; }
    public double[] BestPosition { get; set; }
    public double Fitness { get; set; }
    public double BestFitness { get; set; }

    public Particle(int dimension)
    {
        Position = new double[dimension];
        Velocity = new double[dimension];
        BestPosition = new double[dimension];
    }
}
