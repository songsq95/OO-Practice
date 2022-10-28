namespace OOPractice
{
    public class Vehicle
    {
        private string name;
        private int speed;

        public Vehicle(string name, int speed)
        {
            this.name = name;
            this.speed = speed;
        }

        //public string Name { get => name; set => name = value; }
        //public int Speed { get => speed; set => speed = value; }
        
        public string SpeedUp()
        {
            return $"{name}: speed up {speed} km/h";
            //return this.name + ": speed up " + this.speed + " km/h";
        }
    }
}