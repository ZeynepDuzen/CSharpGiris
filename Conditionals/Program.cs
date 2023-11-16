using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var number = 30;

            /* if (number == 30)
             {
                 Console.WriteLine("Number is 30");
             }
             else if (number == 20)
             {
                 Console.WriteLine("Number is 20");
             }
             else
             {
                 Console.WriteLine("Number is not 30 or 20");
             } */



            //single line if

            /*var number2 = 22;

            Console.WriteLine(number2 == 11 ? "Number2 is 11" : "Number2 is not 11");

            var number3 = 33;
            Console.WriteLine(number3 == 33 ? "Number3 is 33" : "Number3 is not 33");

            var number4 = 55;
            Console.WriteLine(number4 == 78 ? "Number4 is 78" : "Number4 is not 78");

            var number5 = 11;
            Console.WriteLine(number5 == 11 ? "Number5 is 11" : "Number5 is not 11");*/

            //switch case

            /*
            switch (number)
            {
                case 10:
                    Console.WriteLine("Number is 10");
                    break;
                case 20:
                    Console.WriteLine("number is 20");
                    break;
                case 30:
                    Console.WriteLine("Number is 30");
                    break;
                case 40:
                    Console.WriteLine("Number is 40");
                    break;
                case 50:
                    Console.WriteLine("Number is 50");
                    break;
                default:
                    Console.WriteLine("Number is incorrect");
                    break;
            }
            */

            //multiple conditions

            /*if (number >= 0 && number <= 100)
            {
                Console.WriteLine("Number is between 0 - 100");
            }
            else if (number > 100 && number <= 200)
            {
                Console.WriteLine("Number is between 101 - 200");
            }
            else if (number > 200 || number < 0)
            {
                Console.WriteLine("Number is less than 0 or greater than 200");
            }*/

            //please find the biggest number from three numbers that the user entered

            int num1, num2, num3;

            Console.WriteLine("Please enter the first number :");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("please enter the second number :");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("please enter the third number");
            num3 = Convert.ToInt32(Console.ReadLine());

            if (num1 < num2)
            {
                if (num1 < num3)
                {
                    Console.WriteLine("the smallest number is number 1");
                }
                else
                {
                    Console.WriteLine("the smallest number is number 3");
                }
            }
            else if (num2 < num3)
            {
                Console.WriteLine("the smallest number is number 2");
            }
            else
            {
                Console.WriteLine("the smallest number is number 3");
            }
            

            

            Console.ReadLine();
        }
    }
}
