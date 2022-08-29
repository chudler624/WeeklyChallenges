using System;
using System.Collections.Generic;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {

        int even = 0;
        int odd = 0;
        public int AddEvenSubtractOdd(int[] numbers)
        {
            

            foreach (var number in numbers)
            {
                if (number %2 == 0)
                even += number;

                else
                    odd +=number;
            }

            return even - odd;

        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
           List<int> sLength = new List<int>();

            int strlen1 = str1.Length; 
            int strlen2 = str2.Length;
            int strlen3 = str3.Length;
            int strlen4 = str4.Length;

            sLength.Add(strlen1);
            sLength.Add(strlen2);
            sLength.Add(strlen3);
            sLength.Add(strlen4);

            sLength.

       
            
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            throw new NotImplementedException();
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            throw new NotImplementedException();
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            throw new NotImplementedException();
        }

        public bool IsStringANumber(string input)
        {
            throw new NotImplementedException();
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            throw new NotImplementedException();
        }

        public double AverageEvens(int[] numbers)
        {
            throw new NotImplementedException();
        }

        public int Factorial(int number)
        {
            throw new NotImplementedException();
        }
    }
}
