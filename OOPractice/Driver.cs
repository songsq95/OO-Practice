namespace OOPractice
{
    public class Driver
    {
        private Vehicle vehicle;
        public Driver(Vehicle vehicle)
        {
            this.vehicle = vehicle;
        }

        public string Drive()
        {
            return this.vehicle.SpeedUp();
        }
    }
}