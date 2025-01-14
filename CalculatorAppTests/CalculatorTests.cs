using CalculatorApp;

namespace CalculatorAppTests
{
    public class CalculatorTests
    {
        [Fact]
        public void Add_ReturnsCorrectSum()
        {
            int result = Calculator.Add(2, 3);
            Assert.Equal(5, result);
        }

        [Fact]
        public void Add_ReturnsZero_WhenAddingZeroes()
        {
            int result = Calculator.Add(0, 0);
            Assert.Equal(0, result);
        }
    }
}
