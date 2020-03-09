using System;
using Xunit;

namespace TDDExample_1.UnitTests
{
    public class StringCalculatorUnitTests
    {
        [Fact]
        public void Add_OneValue_RightSum()
        {
            // Arrange 
            var sc = new StringCalculator();

            // Act 
            int actual = sc.Add("1");

            // Assert
            Assert.Equal(1, actual);
        }

        [Fact]
        public void Add_MultipleValueWithDelimiter_RightSum()
        {
            // Arrange 
            var sc = new StringCalculator();

            // Act 
            int actual = sc.Add("0,1,2");

            // Assert
            Assert.Equal(0 + 1 + 2, actual);
        }

        [Fact]
        public void Add_IfEmptyInput_ReturnZero()
        {
            // Arrange 
            var sc = new StringCalculator();

            // Act 
            int actual = sc.Add("");

            // Assert
            Assert.Equal(0, actual);
        }

        [Fact]
        public void Add_IfNullInput_ReturnZero()
        {
            // Arrange 
            var sc = new StringCalculator();

            // Act 
            int actual = sc.Add();

            // Assert
            Assert.Equal(0, actual);
        }

        [Fact]
        public void Add_DifferentDelimiter_RightSum()
        {
            // Arrange 
            var sc = new StringCalculator();

            // Act 
            int actual = sc.Add("17;22;36;96", ';');

            // Assert
            Assert.Equal(17 + 22 + 36 + 96, actual);
        }

        [Fact]
        public void Add_NewLineDelimiter_RightSum()
        {
            // Arrange 
            var sc = new StringCalculator();

            // Act 
            int actual = sc.Add("17\n22\n36\n96", '\n');

            // Assert
            Assert.Equal(17 + 22 + 36 + 96, actual);
        }

        [Fact]
        public void Add_EmptyEntries_RightSum()
        {
            // Arrange 
            var sc = new StringCalculator();

            // Act 
            int actual = sc.Add("17..36.96", '.');

            // Assert
            Assert.Equal(17 + 36 + 96, actual);
        }

        [Fact]
        public void Add_IfNonNumericValue_ExceptionIsThrown()
        {
            // Arrange 
            var sc = new StringCalculator();

            // Assert
            Assert.Throws<FormatException>(() => sc.Add("1,X"));
        }

        [Fact]
        public void Add_StringDelimiter_RightSum()
        {
            // Arrange 
            var sc = new StringCalculator();

            // Act 
            int actual = sc.Add("8.2.13", Convert.ToChar("."));

            // Assert
            Assert.Equal(8 + 2 + 13, actual);
        }
    }
}
