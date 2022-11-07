using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            return Char.IsLetter(c);
            //throw new NotImplementedException();
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            return vals.Length % 2 == 0;
            //throw new NotImplementedException();
        }

        public bool IsNumberEven(int number)
        {
            return number % 2 == 0;
            //throw new NotImplementedException();
        }

        public bool IsNumberOdd(int num)
        {
            return num % 2 != 0;
            //throw new NotImplementedException();
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            if (numbers == null || numbers.Count() == 0)
            {
                return 0;
            }
            return numbers.Min() + numbers.Max();
            //throw new NotImplementedException();
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            return str1.Length < str2.Length ? str1.Length : str2.Length;
            //throw new NotImplementedException();
        }

        public int Sum(int[] numbers)
        {
            if (numbers == null)
            {
                return 0;
            }
            int sum = 0;
            foreach(var number in numbers)
            {
                sum += number;
            }
            return sum;
            //throw new NotImplementedException();
        }

        public int SumEvens(int[] numbers)
        {
            if (numbers == null)
            {
                return 0;
            }
            int sum = 0;
            foreach (int number in numbers)
            {
                if (number % 2 == 0)
                {
                    sum += number;
                }
            }
            return sum;
            //throw new NotImplementedException();
        }

        public bool IsSumOdd(List<int> numbers)
        {
            if (numbers == null) 
            { 
                return false; 
            }
            int sum = 0;
            foreach (int num in numbers)
            {
                sum += num;
            }
            return sum % 2 != 0;
            //throw new NotImplementedException();
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            long sum = 0;
            if ( number < 1)
            {
                return 0;
            }
            else if (number % 2 == 0)
            {
                return number / 2;
            }
            else
            {
                return (number - 1) / 2;
            }
            //throw new NotImplementedException();
        }
    }
}
