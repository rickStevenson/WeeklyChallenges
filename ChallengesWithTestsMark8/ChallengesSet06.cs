using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            if(words == null || word == null) return false;

            foreach (string item in words)
            {
                if (ignoreCase)
                {
                    if (string.Equals(item, word, StringComparison.OrdinalIgnoreCase)) { return true; }
                }
                else
                {
                    if(string.Equals(item, word)) { return true; }
                }
            }
            return false;
        }

        public bool IsPrimeNumber(int num)
        {
            if (num <= 1) return false;

            int x = num - 1;

            while (x > 1)
            {
                if (num % x == 0) { return false; }
                x--;
            }

            return true;
        }

        public int IndexOfLastUniqueLetter(string str)
        {
            if (string.IsNullOrEmpty(str)) { return -1; }

            for (int i = str.Length - 1; i >= 0; i--)
            {
                char currentChar = str[i];

                if (str.IndexOf(currentChar) == str.LastIndexOf(currentChar))
                {
                    return i; 
                }
            }

            return -1;
        }

        public int MaxConsecutiveCount(int[] numbers)
        {
            if(numbers == null || numbers.Length == 0) return 0;

            int count = 1;
            int totalCount = 1;
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] == numbers[i - 1])
                {
                    count++;
                }
                else
                {
                    count = 1;
                }
                if(count > totalCount)
                {
                    totalCount = count;
                }
                
            }
            return totalCount;
        }

        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            if(elements == null || elements.Count == 0 || n <= 0) { return new double[0]; }

            var nthElement = new List<double>();

            for (int i = n-1; i < elements.Count; i += n)
                {
                    nthElement.Add(elements[i]);
                }

            return nthElement.ToArray();
        }
    }
}
