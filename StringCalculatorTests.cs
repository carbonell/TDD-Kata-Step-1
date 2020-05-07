using System;
using Xunit;

namespace kata_1
{
    public class StringCalculatorTests
    {
        // Suma retorna 0 en String vacío
        [Fact]
        public void Sum_Returns_0_On_Empty_String()
        {
            // Arrange - Organizar
            var calculator = new StringCalculator();
            // Act - Actuar
            int result = calculator.Sum(numbers: "");
            // Assert - Comprobar
            Assert.Equal(0, result);
        }

        [Fact]
        // Suma retorna un número
        public void Sum_Returns_Single_Number()
        {
            // Arrange - Organizar
            var calculator = new StringCalculator();
            // Act - Actuar
            int result = calculator.Sum(numbers: "8");
            // Assert - Comprobar
            Assert.Equal(8, result);
        }


        [Fact]
        // Suma retorna un número
        public void Sum_Returns_SumOfTwoNumbers()
        {
            // Arrange - Organizar
            var calculator = new StringCalculator();
            // Act - Actuar
            int result = calculator.Sum(numbers: "2,2");
            // Assert - Comprobar
            Assert.Equal(4, result);
        }

    }
}
