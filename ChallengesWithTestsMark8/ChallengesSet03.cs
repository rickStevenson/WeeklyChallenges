using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Reflection.Metadata.Ecma335;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            foreach (var val in vals)
            {
                if (val == false)
                {
                    return true;
                }
                else continue;
            }
            
            return false;
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            if (numbers == null)
            {
                return false;
            }

            int sum = 0;

            foreach (var val in numbers)
            {
                sum += val;
            }

            return (sum % 2 != 0);
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            
            if (string.IsNullOrEmpty(password))
            {
                return false;
            }

            bool hasUpper = false;
            bool hasLower = false;
            bool hasNumber = false;

            foreach (var val in password)
            {
                if(char.IsUpper(val))
                {
                    hasUpper = true;
                }
                else if (char.IsLower(val))
                {
                    hasLower = true;
                }
                else if (char.IsDigit(val))
                {
                    hasNumber = true;
                }

                if(hasUpper && hasLower && hasNumber)
                {
                    return true;
                }
            }
            return false;
        }

        public char GetFirstLetterOfString(string val)
        {
            char firstLetter;

            if (string.IsNullOrEmpty(val))
            {
                return '\0';
            }
            else
            {
                firstLetter = val.First();
            }

            

            return firstLetter;
        }

        public char GetLastLetterOfString(string val)
        {
            char lastLetter;

            if (string.IsNullOrEmpty(val))
            {
                return '\0';
            }
            else
            {
                lastLetter = val.Last();
            }

            return lastLetter;
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            if (divisor == 0)
            {
                return 0;
            }

            return (dividend / divisor);
        }

        public int LastMinusFirst(int[] nums)
        {
            int firstNumber = nums.First();
            int lastNumber = nums.Last();

            return lastNumber - firstNumber;
        }

        public int[] GetOddsBelow100()
        {
            int[] numbers = new int[50];
            int index = 0;

            for (int i = 0; i < 100; i++)
            {
                if (i % 2 != 0)
                {
                    numbers[index] = i;
                    index++;
                }
            }

            return numbers;
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            for (int i = 0;i < words.Length;i++)
            {
                words[i] = words[i].ToUpper();
            }
        }
    }
}
