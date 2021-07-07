using ClassLibrary1Excercise;
using System;
using Xunit;

namespace MyClassLibrary1.Tests {
    public class FibonaciCalcTest {


        private FibonacciCalculator CreateDefaultSUT() {
            //sut = system under test
            var sut = new FibonacciCalculator();
            return sut;
        }



        [Theory]
        [InlineData(0,0)]
        [InlineData(1, 1)]
        [InlineData(4, 3)]
        public void CalculateFibboIS0(int n,int expected) {

            //Arrange
            var sut = CreateDefaultSUT();
            

            //Act
            var actual = sut.FibonacciSerier(n);

            //Assert
            Assert.Equal(expected, actual);

        }

        [Fact]
        public void CalculateFibbo_IS_NEGATIVE() {
            //Arrange
            var sut = CreateDefaultSUT();
            var n = -3;
            

            //Act & Assert
            Assert.Throws<ArgumentException>(() => {
                var actual = sut.FibonacciSerier(n);
            });
        }


        [Fact]
        public void CalculateFibbo_IS_Bigger_Than_90() {
            //Arrange
            var sut = CreateDefaultSUT();
            var n = 100;
           

            //Act & Assert
            Assert.Throws<ArgumentException>(() => {
                var actual = sut.FibonacciSerier(n);
            });
        }




    }




}
