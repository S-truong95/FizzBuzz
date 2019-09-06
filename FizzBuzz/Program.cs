using System;

namespace FizzBuzz
{
    public class FizzBuzz
    {
        public string Get(int num)
        {
            if (IsMultipleOf3and5(num))
            {
                return "FizzBuzz";
            }
            else if (IsMultipleOf3(num))
            {
                return "Fizz";
            }
            else if (IsMultipleOf5(num))
            {
                return "Buzz";
            }
            return num.ToString();
        }
        private bool IsMultipleOf3(int numberToCheck)
        {
            return numberToCheck % 3 == 0;
        }
        private bool IsMultipleOf5(int numberToCheck)
        {
            return numberToCheck % 5 == 0;
        }
        private bool IsMultipleOf3and5(int numberToCheck)
        {
            return numberToCheck % 3 == 0 && numberToCheck % 5 == 0;
        }


    }
}
    

