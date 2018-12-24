namespace lab7
{
    public abstract class PublicTransport : IVehicle
    {
        public double distance{get; internal set;}
        public int capacity{get; internal set;}
        public abstract void Move(double distance);
    }
}