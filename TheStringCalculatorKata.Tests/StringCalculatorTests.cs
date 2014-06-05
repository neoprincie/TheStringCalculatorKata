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
        [Test]
        public void AddShouldBeTakeStringOfNumbersAndReturnInt()
        {
            var calculator = new StringCalculator();
            Assert.That(calculator.Add(String.Empty), Is.InstanceOf<Int32>());
        }
    }
}
