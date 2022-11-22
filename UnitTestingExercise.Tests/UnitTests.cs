using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(1,2,3, 6)]
		[InlineData(-1, -2, -3, -6)]
		[InlineData(10, 15, 75, 100)]

		public void Add(int num1, int num2, int num3, int expected)
        {
            //Arrange
            var unitTestMethods = new UnitTestMethods();
            //Act
            int actual = unitTestMethods.Add(num1, num2, num3);

            //Assert
            Assert.Equal(actual, expected);
		}

        [Theory]
        [InlineData(10,5,5)]
		[InlineData(5, 10, -5)]
		public void Subtract(int minuend, int subtrhend, int expected)
        {
			//Arrange
			var unitTestMethods = new UnitTestMethods();

			//Act
			int actual = unitTestMethods.Subtract(minuend, subtrhend);
			//Assert
			Assert.Equal(actual, expected);
		}

        [Theory]
        [InlineData(2,2,4)]
        public void Multiply(int num1, int num2, int expected)
        {
			//Arrange
			var unitTestMethods = new UnitTestMethods();
			//Act
			int actual = unitTestMethods.Multiply(num1, num2);
			//Assert
			Assert.Equal(actual, expected);
		}

        [Theory]
        [InlineData(10,5,2)]
		[InlineData(60, 10, 6)]
		public void Divide(int num1, int num2, int expected)
        {
			//Arrange
			var unitTestMethods = new UnitTestMethods();
			//Act
			float actual = unitTestMethods.Divide(num1, num2);

			//Assert
			Assert.Equal(actual, expected);
		}

        [Fact]
        public void GetHey()
        {
			//Arrange
			var unitTestMethods = new UnitTestMethods();
			//Act
			var actual = unitTestMethods.GetHey();
			//Assert
			Assert.Equal("Hey",actual);
		}

        [Fact]
        public void MysteryMethod()
        {
			//Arrange
			var unitTestMethods = new UnitTestMethods();
			var actual = unitTestMethods.MysteryMethod();
			//Assert
			Assert.Equal("I'm mysterious", actual);
		}
    }
}
