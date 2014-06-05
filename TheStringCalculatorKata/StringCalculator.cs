using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheStringCalculatorKata
{
    public class StringCalculator
    {
        private readonly char[] delimeters = { ',', '\n' };

        public int Add(string numbers)
        {
            if (!numbers.Any())
                return 0;

            numbers = CheckForDifferentDelimeter(numbers);

            var listOfNumbers = numbers.Split(delimeters).Select(n => Convert.ToInt32(n)).ToList();

            return listOfNumbers.Sum();
        }

        private string CheckForDifferentDelimeter(string numbers)
        {
            if (numbers.Count() > 1 && numbers.Substring(0, 2) == "//")
            {
                delimeters[0] = numbers[2];
                numbers = numbers.Substring(4);
            }
            return numbers;
        }
    }
}
