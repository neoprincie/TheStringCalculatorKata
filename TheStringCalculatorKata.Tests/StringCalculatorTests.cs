using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheStringCalculatorKata.Tests
{
    [TestFixture]
    public class StringCalculatorTests
    {
        private StringCalculator calculator;

        [SetUp]
        public void SetUp()
        {
            calculator = new StringCalculator();
        }

        [Test]
        public void AddShouldBeTakeStringOfNumbersAndReturnInt()
        {
            Assert.That(calculator.Add(String.Empty), Is.InstanceOf<Int32>());
        }

        [Test]
        public void EmptyStringShouldReturnZero()
        {
            Assert.That(calculator.Add(String.Empty), Is.EqualTo(0));
        }

        [TestCase("1", 1)]
        [TestCase("12", 12)]
        [TestCase("121", 121)]
        [TestCase("1337", 1337)]
        [TestCase("9001", 9001)]
        public void OneNumberShouldReturnJustThatNumber(string numbers, int expected)
        {
            Assert.That(calculator.Add(numbers), Is.EqualTo(expected));
        }

        [TestCase("1,2", 3)]
        [TestCase("11,22", 33)]
        [TestCase("121,212", 333)]
        [TestCase("1337,223", 1560)]
        [TestCase("9000,1", 9001)]
        public void TwoNumbersShouldReturnSumOfThoseNumbers(string numbers, int expected)
        {
            Assert.That(calculator.Add(numbers), Is.EqualTo(expected));
        }

        [TestCase("1,2,3,4,5,6,7,8,9", 45)]
        [TestCase("11,22,33", 66)]
        [TestCase("121,212,111,1", 445)]
        [TestCase("1337,223,200", 1760)]
        [TestCase("9000,1,50", 9051)]
        public void UnknownNumberOfNumbersShouldReturnSumOfThoseNumbers(string numbers, int expected)
        {
            Assert.That(calculator.Add(numbers), Is.EqualTo(expected));
        }
    }
}
