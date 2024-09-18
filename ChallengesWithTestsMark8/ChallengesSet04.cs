using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            int result = numbers.Sum(x => x % 2 == 0 ? x : -x);

            return result;
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            string[] strings = new string[] {str1, str2, str3, str4 };

            int shortest = strings.Min(s => s.Length);

            return shortest;
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            int[] intArray = new int[] { number1, number2, number3, number4 };

            int smallestNumber = intArray.Min(x => x);

            return smallestNumber;
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            return (sideLength1 + sideLength2 > sideLength3) &&
           (sideLength2 + sideLength3 > sideLength1) &&
           (sideLength1 + sideLength3 > sideLength2);
        }

        public bool IsStringANumber(string input)
        {
            return double.TryParse(input, out _);
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            int nullCount = objs.Count(o => o == null);

            return nullCount > objs.Length / 2;
        }

        public double AverageEvens(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                return 0;
            }
            var evens = numbers.Where(nums => nums %  2 == 0);
            if (evens.Any())
            {
                return evens.Average();
            }
            return 0;
        }

        public int Factorial(int number)
        {
            if (number < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(number), "Factorial is not defined for negative numbers.");
            }

            int result = 1;
            for (int i = 1; i <= number; i++)
            {
                result *= i;
            }

            return result;
        }
    }
}
