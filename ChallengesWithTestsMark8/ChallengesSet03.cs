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
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            if(numbers == null)
            {
            
            }

            var odds = new List<int>();

            foreach(var num in numbers)
            {
             if(num % 2 != 0)
             {
             odds.Add(num);
             }
            }

            var sumOdds = odds.Sum();
            return (sumOdds % 2 != 0);    
        
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            return (password.Any(char.IsLower) && password.Any(char.IsUpper) && password.Any(char.IsNumber));
        }

        public char GetFirstLetterOfString(string val)
        {
            return val.First(); 
        }

        public char GetLastLetterOfString(string val)
        {
            return val[^1];
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            return (divisor == 0) ? 0 : dividend / divisor;
        }

        public int LastMinusFirst(int[] nums)
        {
            return nums[nums.Length - 1] - nums[0];
     
        }

        public int[] GetOddsBelow100()
        {
            return Enumerable.Range(0, 100).Where(x => x % 2 != 0).ToArray();
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            for (var i = 0; i < words.Length; i++)
            {
                words[i] = words[i].ToUpper();
            }
        }
    }
}
