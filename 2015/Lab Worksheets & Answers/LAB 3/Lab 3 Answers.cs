using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LAB3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*			
			//1
            string month;

            Console.Write("Enter season: ");
            month = Console.ReadLine();

            if (month.ToLower() == "winter")
            {
                Console.Write("December, January, February");
            }
            else if (month.ToLower() == "spring")
            {
                Console.Write("March, April, May");
            }
            else if (month.ToLower() == "summer")
            {
                Console.Write("June, July, August");
            }
            else if (month.ToLower() == "autumn")
            {
                Console.Write("September, October, November");
            }
            else
            {
                Console.Write("Wrong Entry!!");
            }
            */
			
			/*
            //2
            bool flag = false;
            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number % 7 == 0)
            {
                flag = true;
            }
            else
            {
                flag = false;
            }

            Console.Write(flag);
            */
			
			/*
            //3
            Console.Write("Enter first number: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter third number: ");
            int c = Convert.ToInt32(Console.ReadLine());

            if ((a > b && b > c) || (c > b && b > a))
            {
                Console.Write("True");
            }
            else
            {
                Console.Write("False");
            }
            */
			
			/*
            //4
            Console.Write("Enter your weight: ");
            int weight = Convert.ToInt32(Console.ReadLine());

            if (weight <= 63)
            {
                Console.Write("Lightweight");
            }
            else if (weight <= 70)
            {
                Console.Write("Middleweight");
            }
            else if (weight <= 100)
            {
                Console.Write("Heavyweight");
            }
            else
            {
                Console.Write("Super Heavyweight");
            }
            */
			
			/*
            //5
            Console.Write("Enter hour: ");
            int hour = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter minute: ");
            int minute = Convert.ToInt32(Console.ReadLine());

            if (hour < 12)
            {
                Console.Write(hour + ":" + minute + " AM");
            }
            else
            {
                Console.Write(hour - 12 + ":" + minute + " PM");
            }
            */
			
			/*
            //6
            Console.Write("Enter city: ");
            string city = Console.ReadLine();

            if (city.ToLower() == "izmir")
            {
                Console.Write("35");
            }
            else if (city.ToLower() == "istanbul")
            {
                Console.Write(34);
            } 
            else if (city.ToLower() == "içel")
            {
                Console.Write("33");
            }
            */
			
			/*
            //7
            Console.Write("Enter first number: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter third number: ");
            int c = Convert.ToInt32(Console.ReadLine());

            if ((c < a + b) && (c > Math.Abs(a - b)) &&
                (b < a + c) && (b > Math.Abs(a - c)) &&
                (a < b + c) && (a > Math.Abs(b - c)))
            {
                Console.Write("It is a triangle");
            }
            else
            {
                Console.Write("It is not a triangle");
            }
			*/
            Console.ReadLine();
        }
    }
}