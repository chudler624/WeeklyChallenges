using System;
using System.Collections.Generic;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
           if(CharacterIsALetter(c))
            {
                return true;
            }    
           else
            {
                return false;
            }
                   
            
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            throw new NotImplementedException();
        }

        public bool IsNumberEven(int number)
        {
           if (number %2 == 0)
                return true;
           else
                return false;
        }

        public bool IsNumberOdd(int num)
        {
            if ((num % 2) == 1)
                return true;
            else
                return false;
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            return double.MaxValue + double.MinValue;
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            if (str1.Length < str2.Length)
                return str1.Length;
            else
                return str2.Length;
        }

        
        public int Sum(int[] numbers)
            
        {
            int total = 0;
            for (int i=0; i<= numbers.Length; i++)
            {
                total += numbers[i];
                return total;
            }

        }
        
        public int SumEvens(int[] numbers)
        {
            int totalEvens = 0;
            for (int i = 0; i <= numbers.Length && i %2==0; i++)
            {
                totalEvens += numbers[i];
                return totalEvens;
            }
        }

        public bool IsSumOdd(List<int> numbers)
        {
            int sum = 0;
            sum = numbers.Sum();

            if (sum % 2 == 0)
                return false;
            else return true;
                
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            List <long> listThatFit = new List<long>();
           for (long i = 0; i < number && i > 0 && i %2==1; i++)
                listThatFit.Add(i);
           return listThatFit.Count;

        }
    }
}
