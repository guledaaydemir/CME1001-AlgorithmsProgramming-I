using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab_9
{
    class AnswersOfLab9
    {
        static string complementDNA(string dna)
        {
            string output = "";
            for (int i = 0; i < dna.Length; i++)
            {
                if (dna[i] == 'A')
                {
                    output += "T";
                }
                else if (dna[i] == 'T')
                {
                    output += "A";
                }
                else if (dna[i] == 'G')
                {
                    output += "C";
                }
                else if (dna[i] == 'C')
                {
                    output += "G";
                }
            }

            return output;
        }
        static string writeUpper(string str)
        {
            string output = "";
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] > 96 && str[i] < 123)
                {
                    output += Convert.ToChar(str[i] - 32);
                }
                else
                {
                    output += str[i];
                }
            }

            return output;
        }

        static double calculateDigitSum(double number)
        {
            double totalDigit = 0;

            string str = number.ToString();

            for (int i = 0; i < str.Length; i++)
            {
                totalDigit += (str[i] - 48);
            }

            return totalDigit;
        }
        static bool isDeuNumber(double number)
        {
            bool retVal = true;

            while (number > 10)
            {
                double totalDigit = calculateDigitSum(number);

                if (number % totalDigit != 0)
                {
                    retVal = false;
                    break;
                }

                number = number / totalDigit;

            }
            return retVal;
        }

        static int calculateFibonacci(int n, int k)
        {
            int[] arr = new int[n + 1];

            for (int i = 0; i < k - 1; i++)
            {
                arr[i] = 0;
            }
            arr[k - 1] = 1;

            for (int i = k; i <= n; i++)
            {
                for (int j = i - 1; j > i - k - 1; j--)
                {
                    arr[i] += arr[j];
                }
            }

            return arr[n];
        }


        static double calculateFactorial(double num)
        {
            double retVal = 1;
            for (int i = 1; i <= num; i++)
            {
                retVal *= i;
            }
            return retVal;
        }

        static double calculateBinomialCoefficient(double n, double k)
        {
            double retVal = 0;

            retVal = calculateFactorial(n) / (calculateFactorial(k) * calculateFactorial(n - k));

            return retVal;
        }

        static double calculateCombination(double n)
        {
            double retVal = 0;

            for (int i = 1; i <= n + 1; i++)
            {
                retVal += i * calculateBinomialCoefficient(n, i - 1);
            }

            return retVal;
        }

        static void Main(string[] args)
        {
            int menu;
            do
            {
                Console.Clear();
                Console.WriteLine("1) EXERCISE - 1");
                Console.WriteLine("2) EXERCISE - 2");
                Console.WriteLine("3) EXERCISE - 3");
                Console.WriteLine("4) EXERCISE - 4");
                Console.WriteLine("5) EXERCISE - 5");
                
                Console.WriteLine("6) EXIT");
                Console.WriteLine();
                Console.Write("> your choice: ");
                menu = Convert.ToInt32(Console.ReadLine());
                switch (menu)
                {
                    case 1:
                        {
                            Console.Clear();
                            Console.Write("Enter a number (is it a deu number ?) :");
                            double num = Convert.ToDouble(Console.ReadLine());
                            bool flag = isDeuNumber(num);
                            Console.WriteLine(flag);
                            Console.ReadLine();
                            break;

                        }
                    case 2:
                        {
                            Console.Clear();
                            Console.Write("Enter a dna sequence :");
                            string str = Console.ReadLine();
                            string retVal = complementDNA(str);
                            Console.WriteLine(retVal);
                            Console.ReadLine();
                            break;
                        }
                    case 3:
                        {
                            Console.Clear();

                            Console.Write("Enter n number: ");
                            int n = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Enter k number: ");
                            int k = Convert.ToInt32(Console.ReadLine());

                            int retInt = calculateFibonacci(n, k);
                            Console.WriteLine(retInt);
                            Console.ReadLine();
                            break;



                        }
                    case 4:
                        {
                            Console.Clear();
                            Console.Write("Enter n number: ");
                            int n = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine(calculateCombination(n));

                            Console.ReadLine();
                            break;

                        }
                    case 5:
                        {
                            Console.Clear();

                            Console.Write("Enter a string: ");
                            string str = Console.ReadLine();
                            string retstr = writeUpper(str);
                            Console.WriteLine(retstr);
                            Console.ReadLine();
                            break;



                        }
                    case 6:
                        {
                            Environment.Exit(0);
                            break;
                        }
                    default:
                        {
                            break;
                        }

                }
            } while (true);
        }
    }
}