using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ödev2
{
    class Program
    {
        //for calculating  factorial 
        static public double factorial_WhileLoop(int number) 
        {
            double result = 1;
            while (number != 1 &&  number!=0) // 0!=1 
            {
                result = result * number;
                number = number - 1;
            }
            return result;
        }
        static void Main(string[] args)
        {

            bool trueInput = true; // does the inputs are correct

            //taking input x from user
            Console.WriteLine("Please enter integer x:");
            int x = Convert.ToInt16(Console.ReadLine());

            //checking that input y is between 11 and 18
            Console.WriteLine("Please enter y ( 11 <= y <=18) :");
            int y = 0;
            while (trueInput)
            {
                y = Convert.ToInt16(Console.ReadLine());
                if (y <= 18 && y >= 11)
                {
                    trueInput = false;
                }
                else Console.WriteLine("Please try again to enter y ( 11 <= y <=18) :");
            }

            //taking the operation
            Console.WriteLine("Please enter the operation ( + or * ): ");

            trueInput = true;
            char operation = 'x'; // meaningless assignment
            while (trueInput)
            {
                operation = Convert.ToChar(Console.ReadLine());
                if (operation == '+' || operation == '*')
                {
                    trueInput = false;
                }
                else Console.WriteLine("Please try again to enter the operation ( + or * ):");
            }

            //FORMULA CALCULATING STARTS
            double answer = (1 / factorial_WhileLoop(y)); 
            
            int shareNumber = 3; // calculating from the 3+5 or 3*5
            int getsTheSecondNumber = 0;

            // staring points for multiplication or adding
            double shareAnswer = 0;
           


            // CALCULATING THE FORMULA
            for (int a = 2; a < 13; a++)
            {
                // staring points for multiplication or adding
                if (operation == '*')
                    shareAnswer = 1;
                else if (operation == '+')
                    shareAnswer = 0;

                for (int i = 0; i < a; i++)
                {
                    if (operation == '*') 
                        shareAnswer = shareAnswer * shareNumber; // share Number is 3,5,7,9... Share number is each of the share's total.
                    else if (operation == '+')
                        shareAnswer = shareAnswer + shareNumber;

                    if (i == 1)
                        getsTheSecondNumber = shareNumber; //getting the second number of each share.

                    shareNumber = shareNumber + 2;
                }
                shareNumber = getsTheSecondNumber; //will start from the second number of the before one

                // between operations does it - or + ?
                if (a % 2 == 0) // + 
                {
                    answer = answer + (shareAnswer / factorial_WhileLoop(y - (a - 1)));
                }
                else if (a % 2 == 1) // -
                {
                    answer = answer - (shareAnswer / factorial_WhileLoop(y - (a - 1)));
                }


            }
            
            Console.WriteLine("the answer is: " + (answer+(1.0/ x)));
            Console.ReadLine();
        }

    }
}
