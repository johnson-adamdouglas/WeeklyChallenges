using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            return vals.Contains(false);
            //throw new NotImplementedException();
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            return numbers == null ? false : numbers.Where(x => x % 2 != 0).Sum() % 2 != 0;
            //throw new NotImplementedException();
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            int digitCounter = 0;
            int upperCounter = 0;
            int lowerCounter = 0;
            foreach (var c in password)
            {
                if (char.IsUpper(c))
                {
                    upperCounter++;
                }
                if (char.IsLower(c))
                {
                    lowerCounter++;
                }
                if (char.IsDigit(c))
                {
                    digitCounter++;
                }
            }
            return upperCounter > 0 && lowerCounter > 0 && digitCounter > 0;
            //throw new NotImplementedException();
        }

        public char GetFirstLetterOfString(string val) => val[0];

        //return val[0];
        //throw new NotImplementedException();


        public char GetLastLetterOfString(string val) => val[val.Length - 1];

        //throw new NotImplementedException();


        public decimal Divide(decimal dividend, decimal divisor)
        {
            return divisor == 0 ? 0 : dividend / divisor;
            //if (divisor == 0)
            //{
            //    return 0;
            //}
            //return dividend / divisor;
            //throw new NotImplementedException();
        }

        public int LastMinusFirst(int[] nums)
        {
            return nums[nums.Length - 1] - nums[0];
            //throw new NotImplementedException();
        }

        public int[] GetOddsBelow100() 
        {
            int[] odds = new int[50];
            for (int i = 0; i <= 100; i++)
            {
                if (i % 2 != 0)
                {
                    odds[i] = i;
                }
            }
            return odds;
            //throw new NotImplementedException();
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            foreach (string word in words)
            {
                return string.ToUpper(word);
            }
            
            //throw new NotImplementedException();
        }
    }
}
