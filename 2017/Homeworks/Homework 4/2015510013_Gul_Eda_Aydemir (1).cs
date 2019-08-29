using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Taking Inputs From User
            Console.WriteLine("Enter equation"); //Coming true, do not check
            String Input_Equation = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Enter x:"); //Coming true, do not check
            double x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter y:"); //Coming true, do not check
            double y = Convert.ToDouble(Console.ReadLine());

            //spliting the Input_Equation by '='

            string[] left_and_right_equation = null;
            left_and_right_equation = Input_Equation.Split('=');

            //assigning new strings for right and left
            String left_equation = left_and_right_equation[0];
            String right_equation = left_and_right_equation[1];

            //spliting the left_equation and right_equation by '+'
            string[] left_equation_without_plus = null;
            left_equation_without_plus = left_equation.Split('+');

            string[] right_equation_without_plus = null;
            right_equation_without_plus = right_equation.Split('+');

            //variables for sum
            double sum_left = 0;
            double sum_right = 0;
            
           // Console.WriteLine(int.Parse(Convert.ToString(left_equation_without_plus[0].ElementAt(0))));

            //Starting string left to int computation here
            for (int i = 0; i < left_equation_without_plus.Length; i++)
            {
                if (left_equation_without_plus[i].Length == 1)
                {
                    sum_left += x;
                }
                else if (left_equation_without_plus[i].Length == 2)
                {
                    if (Convert.ToString(left_equation_without_plus[i].ElementAt(0)).Equals("x")) //x4
                    {
                        sum_left +=  (Math.Pow(x, int.Parse(Convert.ToString(left_equation_without_plus[i].ElementAt(1)))));
                    }
                    else //4x
                    {
                        sum_left += (int.Parse(Convert.ToString(left_equation_without_plus[i].ElementAt(0))) * x);
                    }
                }
                else if (left_equation_without_plus[i].Length == 3) //4x2
                {
                    sum_left = sum_left + (int.Parse(Convert.ToString(left_equation_without_plus[i].ElementAt(0))) * (Math.Pow(x, int.Parse(Convert.ToString(left_equation_without_plus[i].ElementAt(2))))));
                }
            }

            //Starting string right to int computation here
            for (int j = 0; j < right_equation_without_plus.Length; j++)
            {
                if (right_equation_without_plus[j].Length == 1)
                {
                    sum_right += y;
                }
                else if (right_equation_without_plus[j].Length == 2)
                {
                    if (Convert.ToString(right_equation_without_plus[j].ElementAt(0)).Equals("y")) //y4
                    {
                        sum_right += (Math.Pow(y, int.Parse(Convert.ToString(right_equation_without_plus[j].ElementAt(1)))));
                    }
                    else //4y
                    {
                        sum_right += (int.Parse(Convert.ToString(right_equation_without_plus[j].ElementAt(0))) * y);
                    }
                }
                else if (right_equation_without_plus[j].Length == 3) //4y2
                {
                    sum_right = sum_right + (int.Parse(Convert.ToString(right_equation_without_plus[j].ElementAt(0))) * (Math.Pow(y, int.Parse(Convert.ToString(right_equation_without_plus[j].ElementAt(2))))));
                }
            }

            //OUTPUT
            bool flag = true;
            if (sum_left == sum_right)
            {
                Console.WriteLine(flag);
            }
            else
            {
                flag = false;
                Console.WriteLine(flag);
            }
            Console.ReadLine();
        }
    }
}



