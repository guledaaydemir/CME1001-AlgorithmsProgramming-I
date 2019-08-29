using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB4
{
    class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;

            while (exit == false) // or while(!exit)
            {
                Console.Clear();
                Console.WriteLine("**** MENU ****");
                Console.WriteLine("1) Type of digit");
                Console.WriteLine("2) For Loop 6 to 76");
                Console.WriteLine("3) Lower upper limit");
                Console.WriteLine("4) Mathematical formula");
                Console.WriteLine("5) Metric Conversion Chart");
                Console.WriteLine("6) Repeated 7 numbers");
                Console.WriteLine("8) Three sided dices");
                Console.WriteLine("9) Interest on a bank");
                Console.WriteLine("10) Second largest of 8 numbers");
                Console.WriteLine("11) The 24 hour clock");
                Console.WriteLine("12) Depleted bank account");
                Console.WriteLine("13) Exit");
                Console.WriteLine();
                Console.Write("Your choice:");
                int choice = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                switch (choice)
                {
                    case 1: // Exercises 1

                        Console.Write("Enter a digit:");
                        int digit = Convert.ToInt32(Console.ReadLine());

                        switch (digit)
                        {
                            case 1:
                            case 4:
                            case 9:
                                Console.WriteLine("Perfect Square");
                                break;
                            case 2:
                            case 6:
                            case 8:
                                Console.WriteLine("Even Number");
                                break;
                            case 3:
                            case 5:
                            case 7:
                                Console.WriteLine("Prime Number");
                                break;
                            default:
                                Console.WriteLine("Undefined Digit!!");
                                break;
                        } //switch 
                        Console.ReadLine();
                        break;

                    case 2: // Exercises 2

                        for (int i = 6; i <= 76; i += 5)
                        {
                            Console.Write(i + " ");
                        }
                        Console.ReadLine();
                        break;

                    case 3: // Exercises 3

                        int sum = 0;
                        Console.Write("Enter lower limit:");
                        int lower = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter upper limit:");
                        int upper = Convert.ToInt32(Console.ReadLine());

                        for (int i = lower; i <= upper; i++)
                        {
                            sum = sum + i * i;
                        }
                        Console.Write(sum);
                        Console.ReadLine();
                        break;

                    case 4: // Exercises 4

                        int up = 1;
                        int down = 1;
                        Console.Write("Enter m:");
                        int m = Convert.ToInt32(Console.ReadLine());

                        for (int i = 2; i <= 2 * m; i += 2)
                        {
                            up = up * i;
                        }

                        for (int i = 1; i <= 2 * m + 1; i += 2)
                        {
                            down = down * i;
                        }

                        double result = (double)up / (double)down;
                        Console.Write(result);
                        Console.ReadLine();
                        break;

                    case 5: // Exercises 5

                        double inch, mm;
                        for (double i = 1; i <= 22; i++)
                        {
                            inch = i / 64;
                            mm = inch * 25.4;
                            Console.WriteLine(i + "/64 " + Math.Round(inch, 3) + " " + Math.Round(mm, 3));
                        }
                        Console.ReadLine();
                        break;

                    case 6: // Exercises 6

                        Console.Write("Enter 1. number:");
                        int first_number = Convert.ToInt32(Console.ReadLine());
                        int counter = 0;
						string positions = "";

                        for (int i = 2; i < 8; i++)
                        {
                            Console.Write("Enter " + i + ". number:");
                            int number = Convert.ToInt32(Console.ReadLine());
                            if (first_number == number)
                            {
                                counter++;
                                positions = positions + " " + i;
                            }
                        }

                        Console.WriteLine(counter + " times");
						Console.WriteLine("Positions" + positions);
                        Console.ReadLine();
                        break;

                    case 7: // Exercises 7

                        int zero_crossing = 0;
                        double current_number = 0;
                        double previous_number = 0;

                        for (int i = 1; i <= 8; i++)
                        {
                            previous_number = current_number;
                            do
                            {
                                Console.Write("Enter the " + i + ". non-zero number between -1 and 1: ");
                                current_number = Convert.ToDouble(Console.ReadLine());
                            }
                            while (current_number == 0 || current_number < -1 || current_number > 1);

                            if ((previous_number > 0 && current_number < 0) || (previous_number < 0 && current_number > 0))
                                zero_crossing++;
                        }

                        Console.Write(zero_crossing + " times");
                        Console.ReadLine();
                        break;

                    case 8: // Exercises 8

                        Random rnd = new Random();
                        int dice1 = 0, dice2 = 0, dice3 = 0;
                        int count = 0;

                        while (dice1 != 1 || dice2 != 1 || dice3 != 1)
                        {
                            dice1 = rnd.Next(1, 4);
                            dice2 = rnd.Next(1, 4);
                            dice3 = rnd.Next(1, 4);
                            count++;

                            Console.Write(count + ". try ");
                            switch (dice1)
                            {
                                case 1:
                                    Console.Write(2);
                                    break;
                                case 2:
                                    Console.Write(6);
                                    break;
                                case 3:
                                    Console.Write(7);
                                    break;
                            }
                            Console.Write(" ");
                            switch (dice2)
                            {
                                case 1:
                                    Console.Write(1);
                                    break;
                                case 2:
                                    Console.Write(5);
                                    break;
                                case 3:
                                    Console.Write(9);
                                    break;
                            }
                            Console.Write(" ");
                            switch (dice3)
                            {
                                case 1:
                                    Console.Write(3);
                                    break;
                                case 2:
                                    Console.Write(4);
                                    break;
                                case 3:
                                    Console.Write(8);
                                    break;
                            }

                            Console.WriteLine();
                        }

                        Console.WriteLine("after " + count + " times");
                        Console.ReadLine();
                        break;

                    case 9: // Exercises 9

                        // montly interest = (balance * rate * number of months) / 1200             
                        Console.Write("Enter the balance: ");
                        double balance = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Enter the interest rate: ");
                        double iRate = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Enter the number of months: ");
                        int nOfMonths = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Month\tInterest\tPrincipal");

                        for (int i = 1; i <= nOfMonths; i++)
                        {
                            double interest = Math.Round((balance * iRate * 1) / 1200, 2);
                            balance = balance + interest;
                            Console.WriteLine(i + "\t" + interest + "\t\t" + balance);
                        }
                        Console.ReadLine();
                        break;

                    case 10: // Exercises 10

                        // Firstly initilize the variables to minimum number to change with the possible max values later.
                        int largest = int.MinValue;
                        int second_largest = int.MinValue;

                        for (int i = 1; i <= 8; i++)
                        {
                            Console.Write("Enter the " + i + ". number: ");
                            int number = Convert.ToInt32(Console.ReadLine());
                            if (number > largest)
                            {
                                second_largest = largest;
                                largest = number;
                            }
                            else if (number > second_largest)
                            {
                                second_largest = number;
                            }
                        }

                        Console.WriteLine("Second largest is " + second_largest);
                        Console.ReadLine();
                        break;

                    case 11: // Exercises 11

                        for (int i = 0; i < 24; i++)
                        {
                            if (i == 0)
                            {
                                Console.WriteLine("12 midnight");
                            }
                            else if (i <= 11)
                            {
                                Console.WriteLine(i + " am");
                            }
                            else if (i == 12)
                            {
                                Console.WriteLine(i + " noon");
                            }
                            else
                            {
                                Console.WriteLine(i % 12 + " pm");
                            }
                        }
                        Console.ReadLine();
                        break;

                    case 12: // Exercises 12

                        // montly interest = (balance * rate * number of months) / 1200 
                        balance = 10000;
                        iRate = 6;
                        nOfMonths = 0;

                        do
                        {
                            double interest = Math.Round((balance * iRate * 1) / 1200, 2);
                            balance = balance - 500 + interest;
                            nOfMonths++;
                            Console.WriteLine("After " + nOfMonths + " months the balance is " + balance);
                        }
                        while (balance > 0);

                        Console.WriteLine();
                        Console.WriteLine("After " + nOfMonths + " months the balance is depleted");
                        Console.ReadLine();
                        break;

                    case 13: // exit
                        exit = true; //to break main while loop
                        break;

                    default:
                        Console.WriteLine("Wrong entry!!!");
                        Console.ReadLine();
                        break;

                }//menu switch                
            } // main while loop
        }
    }
}
