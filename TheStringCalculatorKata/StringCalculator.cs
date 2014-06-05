using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheStringCalculatorKata
{
    public class StringCalculator
    {
        public int Add(string numbers)
        {
            if (!numbers.Any())
                return 0;

            var listOfNumbers = numbers.Split(',').Select(n => Convert.ToInt32(n)).ToList();

            return listOfNumbers.Sum();
        }
    }
}
