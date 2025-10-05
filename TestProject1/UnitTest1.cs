using System;
using Xunit;                  
using Обобщенные_классы;      

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Area_CorrectValue_ReturnsExpectedResult()
        {
            // Arrange
            var circle = new Circle<double>(3);
            double expected = Math.PI * 9; // π * r^2 = 3.14159 * 9

            // Act
            double actual = circle.Area();

            // Assert
            Assert.Equal(expected, actual, 3);
            // третий параметр = точность (3 знака после запятой)
        }
    }
}
