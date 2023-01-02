using NUnit.Framework;

namespace Task16_7.Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        /// <summary>
        /// Тестирование медота сложения калькулятора
        /// </summary>
        [Test]
        public void AdditionalAlwaysReturnsExpectedValue()
        {
            Calculator calculator = new Calculator();

            Assert.That(calculator.Additional(10, 35) == 45);
            Assert.That(calculator.Additional(-10, 35) == 25);
            Assert.That(calculator.Additional(0, 0) == 0);
            Assert.That(calculator.Additional(int.MaxValue, 10) == -2147483639);
        }

        /// <summary>
        /// Тестирование метода вычитания калькулятора
        /// </summary>
        [Test]
        public void SubtractionAlwaysReturnsExpectedValue()
        {
            Calculator calculator = new Calculator();

            Assert.That(calculator.Subtraction(10, 35) == -25);
            Assert.That(calculator.Subtraction(-10, 35) == -45);
            Assert.That(calculator.Subtraction(0, 0) == 0);
            Assert.That(calculator.Subtraction(30, 10) == 20);
            Assert.That(calculator.Subtraction(int.MinValue, 10) == 2147483638);
        }

        /// <summary>
        /// Тестирование метода умножение калькулятора
        /// </summary>
        [Test]
        public void MiltiplicationAlwaysReturnsExpectedValue()
        {
            Calculator calculator = new Calculator();

            Assert.That(calculator.Miltiplication(10, 35) == 350);
            Assert.That(calculator.Miltiplication(-10, 35) == -350);
            Assert.That(calculator.Miltiplication(0, 0) == 0);
            Assert.That(calculator.Miltiplication(30, 10) == 300);
            Assert.That(calculator.Miltiplication(int.MaxValue, 10) == -10);
        }

        /// <summary>
        /// Тестирование метода деления калькулятора
        /// </summary>
        [Test]
        public void DivisionAlwaysReturnsExpectedValue()
        {
            Calculator calculator = new Calculator();

            Assert.That(calculator.Division(10, 2) == 5);
            Assert.That(calculator.Division(3, 2) == 1);
            Assert.That(calculator.Division(30, 10) == 3);
        }

        /// <summary>
        /// Тестирование получения исключения при делении на ноль
        /// </summary>
        [Test]
        public void DivisionMustThrowException()
        {
            Calculator calculator = new Calculator();

            Assert.Throws<DivideByZeroException>(() => calculator.Division(10, 0));
        }
    }
}
