using Xunit;
using TollCalculator;
using Vehicles;
using System;
using System.Collections; //Needed for IEnumerable
using System.Collections.Generic;  //Needed for... also IEnumerable

namespace TollCalculator.UnitTests {
    public class TollCalculator_Tests {
        private readonly TollCalculator _tollcalculator;
        public TollCalculator_Tests() {
            _tollcalculator = new TollCalculator();
        }
        [Theory]
        [MemberData(nameof(TollFeeData))]
        public void CheckTollFeeCanBeGot(DateTime date, Vehicle vehicle, int expected) {
            var fee = _tollcalculator.GetTollFee(date, vehicle);
            Assert.Equal(expected, fee);
        }
        public static IEnumerable<object[]> TollFeeData => new List<object[]> {
            new object[] { new DateTime(2019, 4, 18,  6, 15, 0), new Car(), 8},
            new object[] { new DateTime(2019, 4, 18,  6, 45, 0), new Car(), 13},
            new object[] { new DateTime(2019, 4, 18,  7, 30, 0), new Car(), 18},
            new object[] { new DateTime(2019, 4, 18,  8, 15, 0), new Car(), 13},
            new object[] { new DateTime(2019, 4, 18, 10, 15, 0), new Car(), 0},
            new object[] { new DateTime(2019, 4, 18, 10, 45, 0), new Car(), 8},
            new object[] { new DateTime(2019, 4, 18, 15, 45, 0), new Car(), 18},
            new object[] { new DateTime(2019, 4, 18, 17, 30, 0), new Car(), 13},
            new object[] { new DateTime(2019, 4, 18, 18, 15, 0), new Car(), 8},
            new object[] { new DateTime(2019, 4, 18, 18, 45, 0), new Car(), 0},
            //Tollfree dates & vehicle types
            new object[] { new DateTime(2019, 4, 18,  6, 15, 0), new Motorbike(), 0},
            new object[] { new DateTime(2019, 4, 20,  6, 15, 0), new Car(), 0},
            new object[] { new DateTime(2013, 1,  1,  6, 15, 0), new Car(), 0}

        };
    }
}