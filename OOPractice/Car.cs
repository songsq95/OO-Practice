using System;

namespace OOPractice
{
    public class Car : Vehicle
    {
        //private Engine engine;
        public Car(string name, Engine engine) : base(name, engine.Speed)
        {
        }
    }

    public class Car1 : Vehicle
    {
        //private Engine engine;
        public Car1(string name, GasolineEngine engine) : base(name, engine.GetSpeed())
        {
        }
    }

    public class Engine
    {
        private int speed;
        private string type;
        public Engine(string type)
        {
            this.type = type;
            if (type.Equals("Gasoline"))
            {
                this.speed = 30;
            }

            if (type.Equals("Electric"))
            {
                this.speed = 25;
            }
        }

        public int Speed { get => speed; set => speed = value; }
    }

    public class GasolineEngine : IEngine
    {
        public int GetSpeed()
        {
            return 30;
        }
    }

    public class ElectricEngine : IEngine
    {
        public int GetSpeed()
        {
            return 25;
        }
    }

}
