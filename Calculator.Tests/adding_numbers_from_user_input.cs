using System;
using Xunit;

namespace Calculator.Tests
{
    public class adding_numbers_from_user_input
    {
        [Fact]
        public void adding_2_and_2_should_be_4()
        {
            //Arrange -- Context              -- Given
            var calculator = new CalculationEngine();
            var input = "2+2";
            var expectedResult = 4;

            //Act     -- Do the thing         -- When
            var actualResult = calculator.DoMath(input);

            //Assert  -- checking the result  -- Then
            Assert.Equal(expectedResult,actualResult);
        }

        [Fact]
        public void adding_2_and_5_should_be_7()
        {
            //Arrange -- Context              -- Given
            var calculator = new CalculationEngine();
            var input = "2+5";
            var expectedResult = 7;

            //Act     -- Do the thing         -- When
            var actualResult = calculator.DoMath(input);

            //Assert  -- checking the result  -- Then
            Assert.Equal(expectedResult,actualResult);
        }

        [Fact]
        public void addition_with_only_one_number_throws_an_invalid_input_exception()
        {
            //Arrange
            var calculator = new CalculationEngine();
            var input = "2+";
            
            //Assert
            Assert.Throws<InvalidInputException>(() => /*act*/ calculator.DoMath(input));
        }

        [Fact]
        public void adding_3_numbers_they_should_be_added_successfully()
        {
            //Arrange -- Context              -- Given
            var calculator = new CalculationEngine();
            var input = "2+5+10";
            var expectedResult = 17;

            //Act     -- Do the thing         -- When
            var actualResult = calculator.DoMath(input);

            //Assert  -- checking the result  -- Then
            Assert.Equal(expectedResult, actualResult);
        }

    }
}
