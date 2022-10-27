namespace OOPracticeTest
{
    using OOPractice;
    using Xunit;

    public class CarTest
    {
        [Fact]
        public void Should_return_message_when_speed_up_given_car_with_name_speed()
        {
            //given
            Car car = new Car("Cool Car", 30);
            //when
            string message = car.SpeedUp();
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
            Driver driver = new Driver();
            Truck truck = new Truck("Big Truck", 10);
            //when
            string message = driver.Drive(truck);

            //then
            Assert.Equal("Big Truck: speed up 10 km/h", message);
        }

        [Fact]
        public void Should_return_message_when_drive_car_speed_up_given_driver_and_car()
        {
            //given
            Driver driver = new Driver();
            Car car = new Car("Cool Car", 30);
            //when
            string message = driver.Drive(car);

            //then
            Assert.Equal("Cool Car: speed up 30 km/h", message);
        }
    }
}
