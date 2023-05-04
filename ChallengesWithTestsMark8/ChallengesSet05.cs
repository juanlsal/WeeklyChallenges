using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
             startNumber++;

             while (startNumber % n != 0)
             {
                 startNumber++;
             }

             return startNumber;
        }

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
            for (var i = 0; i < businesses.Length; i++)
            {
             if (businesses [i].TotalRevenue == 0)
             {
                businesses[i].Name = "CLOSED";
             }
            }
        }

        public bool IsAscendingOrder(int[] numbers)
        {
            return numbers == null || numbers.Length == 0 ? false : !numbers.Skip(1).Select((item, index) => numbers[index] <= numbers[index + 1]).Any(x => x == false);
        }

        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
             {
                return 0;
             }
            int sum = 0;

            for (var i = 1; i < numbers.Length; i++)
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
            return (words == null || words.Length == 0 || (words.Aggregate((x, y) => x.Trim() + " " + y.Trim()) + ".").Count() == 2) ? "" : words.Aggregate((x, y) => x.Trim() + " " + y.Trim()) + ".";
        }

        public double[] GetEveryFourthElement(List<double> elements)
        {
            return elements == null ? new double[0] : elements.Where((item, index) => (index + 1) % 4 == 0).ToArray();
        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            for (var i = 0; i < nums.Length; i++)
            {
                for (var k = i + 1; k < nums.Length; k++)
                {
                    if (nums[i] + nums[k] == targetNumber)
                    {
                        return true;
                    }
                }

            }

            return false;
        }
    }
}
