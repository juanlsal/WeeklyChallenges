using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {

            return char.IsLetter(c);

        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            return (vals.Length % 2 == 0);
        }

        public bool IsNumberEven(int number)
        {
            return number % 2 == 0;
        }

        public bool IsNumberOdd(int num)
        {
            return num % 2 != 0;
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            if (numbers == null)
            {
                return 0;
            }

            double min = 0;
            double max = 0;

            foreach (var num in numbers)
            {
               if (num > max)
               {
                   max = num;
               }

               if (num < min)
               {
                   min = num;
               }

               if (numbers.Count() <= 1)
               {
               min = num;
             }
            }

            return min + max;
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            return (str1.Length < str2.Length) ? str1.Length : str2.Length;
        }

        public int Sum(int[] numbers)
        {
            if (numbers == null)
               {
               return 0;
             }
            var sum = 0;

            for(var i = 0; i < numbers.Length; i++)
            {
             sum += numbers[i];
            }

            return sum;   
        }

        public int SumEvens(int[] numbers)
        {
            return numbers?.Where(x => x % 2 == 0).Sum() ?? 0;
        }

        public bool IsSumOdd(List<int> numbers)
        {
            return (numbers == null) ? false : (numbers.Sum() % 2 != 0);
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            if (number <= 0)
                return 0;
            else
                return number / 2;

            return (number <= 0) ? 0 : number / 2;
        }
    }
}
