using Xunit;
using Vehicles;

namespace Vehicles.UnitTests {
    public class Motorbike_Tests {
        private readonly Motorbike _motorbike;
        public Motorbike_Tests() {
            _motorbike = new Motorbike();
        }
        [Fact]
        public void CheckVehicleTypeIsValid(){
            var vehicletype = _motorbike.GetVehicleType();
            var result = vehicletype is string;
            Assert.True(result);
        }
    }
}