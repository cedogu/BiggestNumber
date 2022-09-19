using System;

namespace BiggestNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = 20;
            int number2 = 30;
            int number3 = 10;
            int result;

            result = number3;


            if (number3 > number1)
            {
                result = number3;
            }
            else if (number1 > number2)
            {
                result = number1;
            }
            else
            {
                result = number2;
            }

            // or we can do in this way as well;

            
            //if (number1 > number3)
            //{
            //    result = number1;
            //}

            //if (number2 > number3)
            //{
            //    result = number2;
            //}


            Console.WriteLine("The biggest number is: " + result);

            Console.Read();

        }
    }
}
