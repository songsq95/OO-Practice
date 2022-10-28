namespace OOPracticeTest
{
    using OOPractice;
    using Xunit;

    public class CarTest
    {
        [Fact]
        public void Should_return_message_when_speed_up_given_car_with_name_engine()
        {
            //given
            Engine engine = new Engine("Gasoline");
            Car car = new Car("Cool Car", engine);
            Car1 car1 = new Car1("Cool Car",new GasolineEngine());
            //when
            string message = car1.SpeedUp();
            //then
            Assert.Equal("Cool Car: speed up 30 km/h", message);
        }

        [Fact]
        public void Should_return_message_when_speed_up_given_truck_with_name_speed()
        {
            //given
            Truck truck = new Truck("Big Truck", 10);
            //when
            string message = truck.SpeedUp();
            //then
            Assert.Equal("Big Truck: speed up 10 km/h", message);
        }

        [Fact]
        public void Should_return_message_when_drive_truck_speed_up_given_driver_and_truck()
        {
            //given
            Truck truck = new Truck("Big Truck", 10);
            Driver driver = new Driver(truck);
            //when
            string message = driver.Drive();

            //then
            Assert.Equal("Big Truck: speed up 10 km/h", message);
        }

        [Fact]
        public void Should_return_message_when_drive_car_speed_up_given_driver_and_car()
        {
            //given
            Engine engine = new Engine("Gasoline");
            Car car = new Car("Cool Car", engine);
            Driver driver = new Driver(car);
            //when
            string message = driver.Drive();

            //then
            Assert.Equal("Cool Car: speed up 30 km/h", message);
        }
    }
}
