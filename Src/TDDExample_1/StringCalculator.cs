using System.Linq;

namespace TDDExample_1
{
    public class StringCalculator
    {
        public int Add(string input = null, char delimiter = ',')
        {

            var sum = 0;

            if (string.IsNullOrEmpty(input) == false)
            {

                sum = input.Split(delimiter)
                    .Where(i => string.IsNullOrEmpty(i) == false)
                    .Sum(n => int.Parse(n));

                // Just keeping this snippent for original approach

                //foreach (var number in numbers)
                //{
                //    if (string.IsNullOrEmpty(number) == false)
                //    {
                //        sum += int.Parse(number);
                //    }
                //}
            }

            return sum;
        }
    }
}
