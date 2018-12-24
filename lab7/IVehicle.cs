namespace lab7
{
    public interface IVehicle
    {
        double distance { get; }
        void Move(double distance);
    }
}