using Xunit;
using KnowledgeCheck1_Calculator;


namespace TestCalculator

{
    public class CalculatorTests
    {




        [Fact]
        public void Add_ShouldReturnCorrectSum()
        {
            // Arrange 

            var calculator = new Calculator();

            //Act
            int result = calculator.Add(5, 7);

            //Assert
            Assert.Equal(12, result);
        }
        [Fact]
        public void Subtract_ShouldReturnCorrectDifference()
        {
            // Arrange
            var calculator = new Calculator();

            // Act 
            int result = calculator.Subtract(10, 3);

            // Assert
            Assert.Equal(7, result);
        }
        [Fact]
        public void Multiply_ShouldReturnCorrectProduct()
        {
            //Arrange
            var calculator = new Calculator();

            // Act
            int result = calculator.Multiply(3, 4);

            // Assert
            Assert.Equal(12, result);
        }
        [Fact]
        public void Divide_ShouldReturnCorrectQuotient()
        {
            //Arrange
            var calculator = new Calculator();

            //Act
            double result = calculator.Divide(10, 2);

            // Assert
            Assert.Equal(5, result);
        }
        [Fact]
        public void Divide_ByZero_ShouldReturnInfinity()
        {
            //Arrange
            var calculator = new Calculator();

            // Act
            double result = calculator.Divide(10, 0);

            //Assert
            Assert.Equal(double.PositiveInfinity, result);
        }







    }
}