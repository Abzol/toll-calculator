using Xunit;
using Vehicles;

namespace Vehicles.UnitTests {
    public class Car_Tests {
        private readonly Car _car;
        public Car_Tests() {
            _car = new Car();
        }
        [Fact]
        public void CheckVehicleTypeIsValid(){
            var vehicletype = _car.GetVehicleType();
            var result = vehicletype is string;
            Assert.True(result);
        }
    }
}