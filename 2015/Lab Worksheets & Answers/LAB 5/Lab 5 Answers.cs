using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB5
{
    class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;

            while(!exit)
            {
                Console.Clear();
                Console.WriteLine("**** MENU ****");
                Console.WriteLine("1) Question 1");
                Console.WriteLine("2) Question 2");
                Console.WriteLine("3) Question 3");
                Console.WriteLine("4) Question 4");
                Console.WriteLine("5) Question 5");
                Console.WriteLine("6) Question 6");
                Console.WriteLine("7) Question 7");
                Console.WriteLine("8) Question 8");
                Console.WriteLine("9) Question 9");
                Console.WriteLine("10) Question 10");
                Console.WriteLine("11) Exit");
                Console.WriteLine();
                Console.Write("Your choice:");
                int choice = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                switch (choice)
                {
                    case 1: // Exercises 1

                        for(int i=8; i<=12;i+=2)
                        {
                           for(int j=2;j<=6;j++)
                           {
                               Console.WriteLine(i + " x " + j + " = " + i * j);
                           }
                        }
                        Console.ReadLine();
                        break;

                    case 2: // Exercises 2

                        for(int i=1;i<=8;i++)
                        {
                           Console.WriteLine(i + " men went to mow, went to mow a meadow,");
                           for(int j = i; j >= 1; j--)
                           {
                               if(j != 1)
                               {
                                   Console.WriteLine("   " + j + " men,");          
                               }
                               else
                               {
                                   Console.WriteLine("   1 man and his dog, went to mow a meadow.");
                               }
                           }
                        }
                        Console.ReadLine();
                        break;

                    case 3: // Exercises 3

                        Console.WriteLine("Enter a number :");
                        int num = Convert.ToInt32(Console.ReadLine());
                        for (int i = 1; i <= num; i++) 
                        {
                           if(i % 2 == 0)
                           {
                               Console.Write(" ");
                           }
                           for (int j = 1; j <= num; j++)
                           {  
                                Console.Write("*");
                           }
                           Console.WriteLine();
                        }
                        Console.ReadLine();
                        break;

                    case 4: // Exercises 4

                        int harf_sayisi = 65; 
                        int bosluk_sayisi = 4; 
                        
                        for (int i = 1; i <= 5; i++)
                        {
                          for (int j = 1; j <=bosluk_sayisi; j++)
                          { 
                              Console.Write(" ");
                          }
                          
                          for (int j = 65; j <= harf_sayisi; j++)
                          {
                               Console.Write(Convert.ToChar(chr));
                               chr++;
                          }
                          bosluk_sayisi = bosluk_sayisi - 1;
                          harf_sayisi = harf_sayisi + 1;
                          Console.WriteLine();
                        }
                        Console.ReadLine();
                        break;

                    case 5: // Exercises 5

                        Console.WriteLine("Enter x number :");
                        double x = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Enter the number of terms :");
                        double term = Convert.ToInt32(Console.ReadLine());


                        double sum = x;
                        for(double i=1; i<=term; i++)
                        {
                           double dividend = 1;
                           double denominator = 1;
   
                           for(double d=1;d<=i*2-1;d+=2)
                           {
                               dividend *= d;
                           }

                           for(double d=2;d<=i*2;d+=2)
                           {
                               denominator *= d;
                           }

                           sum += (dividend / denominator)*((Math.Pow(x,i*2+1)) / i*2 + 1);
                        }

                        Console.WriteLine("Result = " + sum);
                        Console.ReadLine();
                        break;

                    case 6: // Exercises 6

                        int num = 5;
                        int exp = 0;

                        for(int i=1;i<=5;i++)
                        {

                            for(int j=1;j<=num;j++)
                            {
                                Console.Write(j);
                            }
                            for(int j=1;j<=exp;j++)
                            {
                                Console.Write("-");
                            }
                            for(int j=num;j>=1;j--)
                            {
                                Console.Write(j);
                            }
                            num--;
                            exp+=2;
                        }

                        Console.ReadLine();
                        break;

                    case 7: // Exercises 7

                        for(int i=1;i<=6;i++)
                        {
                           for(int j=1;j<=6;j++)
                           {
  
                              for(int k=1;k<=6;k++)
                              {
                                 if(i+j+k == 5)
                                 {
                                     Console.WriteLine("(" + i + "," + j + "," + k + ")");
                                 }
                              }
                           }
                        }
                        Console.ReadLine();
                        break;

                    case 8: // Exercises 8

                    int bosluk_sayisi1 = 0;
                    int bosluk_sayisi2 = 28;

                    for (int i = 1; i <= 8; i++)
                    {

                        for (int j = 1; j <= bosluk_sayisi1; j++)
                        {
                            Console.Write(" ");
                        }
                        Console.Write("***");
                        for (int j = 1; j <= bosluk_sayisi2; j++)
                        {
                            Console.Write(" ");
                        }
                        Console.WriteLine("***");
                        bosluk_sayisi1 += 2;
                        bosluk_sayisi2 -= 4;
                        }
                        Console.ReadLine();
                        break;

                    case 9: // Exercises 9

                       int bosluk_sayisi = 18;
                   int was_number = 0;
                   int say_number = 1;

                   for (int i = 1; i <= 10; i++)
                   {
                       for (int j = 1; j <= bosluk_sayisi; j++)
                       {
                           Console.Write(" ");
                       }
                       for (int j = 1; j <= was_number; j++)
                       {
                           Console.Write("Was ");
                       }
                       for (int j = 1; j <= say_number; j++)
                       {
                           Console.Write("Say ");
                       }

                       was_number++;
                       say_number++;
                       bosluk_sayisi -= 2;
                       Console.WriteLine();
                   }

                   bosluk_sayisi = 2;
                   int too_number = 9;
                   int zoo_number = 8;

                   for (int i = 1; i <= 10; i++)
                   {
                       for (int j = 1; j <= bosluk_sayisi; j++)
                       {
                           Console.Write(" ");
                       }
                       for (int j = 1; j <= too_number; j++)
                       {
                           Console.Write("Too ");
                       }
                       for (int j = 1; j <= zoo_number; j++)
                       {
                           Console.Write("Zoo ");
                       }

                       too_number--;
                       zoo_number--;
                       bosluk_sayisi += 2;
                       Console.WriteLine();
                       }                                  
                        Console.ReadLine();
                        break;

                    case 10: // Exercises 10
                        int bosluk_sayisi = 8;


                        for (int i = 1; i <= 9; i++)
                        {

                            for (int j = 1; j <= bosluk_sayisi; j++)
                            {
                                Console.Write(" ");
                            }
                            for (int j = 1; j <= i; j++)
                            {
                                Console.Write(j);
                            }
                            Console.Write(" x 8 + " + i + " = ");
                            for (int j = 9; j > 9-i; j--)
                            {
                                Console.Write(j);
                            }

                            bosluk_sayisi--;
                            Console.WriteLine();
                        }
                        
                        Console.ReadLine();
                        break;
                        case 11: 
                        exit = true;
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
