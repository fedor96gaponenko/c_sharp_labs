namespace lab7
{
    public class Tram : PublicTransport
    {
        public Tram(int capacity)
        {
            this.capacity = capacity;
            this.distance = 0;
        }

        public override void Move(double distance)
        {
            this.distance += distance;
        }
    }
}