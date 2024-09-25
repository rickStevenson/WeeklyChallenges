using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            if (startNumber % n == 0)
            {
                startNumber++;
            }
            while (startNumber % n != 0)
            {
                startNumber++;
            }
            return startNumber;
        }

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
            foreach (Business bus in businesses)
            {
                if(bus.TotalRevenue == 0)
                {
                    bus.Name = "CLOSED";
                }
            }
            
        }

        public bool IsAscendingOrder(int[] numbers)
        {
            if(numbers == null || numbers.Length == 0)
            {
                return false;
            }
            for(int i = 0; i < numbers.Length - 1; i++)
            {
                if(numbers[i] > numbers[i + 1])
                {
                    return false;
                }
            }
            return true;
        }

        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            if (numbers == null || numbers.Length < 2)
            {
                return 0;
            }

            int sum = 0;

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i - 1] % 2 == 0)
                {
                    sum += numbers[i];
                }
            }

            return sum;
        }

        public string TurnWordsIntoSentence(string[] words)
        {
            if (words == null || words.Length == 0)
            {
                return string.Empty;
            }

            StringBuilder sentence = new StringBuilder();

            foreach (string word in words)
            {
                string trimmedWord = word.Trim();

                if (!string.IsNullOrWhiteSpace(trimmedWord))
                {
                    if (sentence.Length > 0)
                    {
                        sentence.Append(" "); // Add a space before appending the word if the sentence already has content
                    }
                    sentence.Append(trimmedWord); // Append the trimmed word
                }
            }
            
            if (sentence.Length > 0)
            {
                sentence.Append(".");
            }

            return sentence.ToString();
        }

        public double[] GetEveryFourthElement(List<double> elements)
        {
            if(elements == null || elements.Count < 4)
            {
                return new double[0];
            }

            List<double> result = new List<double>();

            if (elements.Count >= 4)
            {
                for (int i = 3; i < elements.Count; i+=4)
                {
                    result.Add(elements[i]);
                }
            }

            return result.ToArray();
        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            if(nums == null || nums.Length == 0) { return false; }

            for (int i = 0; i < nums.Length; i++)
            {
                for(int j = i + 1; j < nums.Length; j++)
                {
                    if(nums[i] + nums[j] == targetNumber)
                    {
                        return true;
                    }
                }
            }

            return false;
        }
    }
}
