using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LAB7
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
                Console.WriteLine("1) Exercises 1");
                Console.WriteLine("2) Exercises 2");
                Console.WriteLine("3) Exercises 3");
                Console.WriteLine("4) Exercises 4");
                Console.WriteLine("5) Exercises 5");
                Console.WriteLine("6) Exercises 6");
                Console.WriteLine("7) Exercises 7");
                Console.WriteLine("8) EXIT");
                Console.WriteLine();
                Console.Write("Your choice:");
                int choice = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                switch (choice)
                {
                    case 1: // Exercises 1
                        int[,] a = new int[,] {{4, 4, 7, 2, 9, 12},
                                   {0, 5, 7, 16, 3, 5},
                                   {2, 3, 6, 3, 2, 10}};

                        int max = int.MinValue;

                        for (int i = 0; i < a.GetLength(0); i++)
                        {
                            for (int j = 0; j < a.GetLength(1); j++)
                            {
                                if (a[i, j] > max)
                                    max = a[i, j];
                            }
                        }

                        Console.Write(max);
                        break;

                    case 2: // Exercises 2
                        string[,] myarray = new string[,] {{"M001","Ali Taş","Izmir", "40"},
                             {"M002","Ebru Kaya","Ankara", "25"},
                             {"M003","Ayşe Saray", "Bursa", "15"},
                             {"M004","Ece Nazar","Istanbul", "60"},
                             {"M005","Ege Tarak","Izmir ", "45"}, 
                             {"M006","Can Ak","Antalya", "85"},
                             {"M007","Sibel Tan","Istanbul ", "19"}};

                        for (int i = 0; i < myarray.GetLength(0); i++)
                        {
                            if (myarray[i, 2].Trim() == "Izmir")
                                myarray[i, 2] = "Istanbul";
                            else if (myarray[i, 2].Trim() == "Istanbul")
                                myarray[i, 2] = "Izmir";
                        }

                        for (int i = 0; i < myarray.GetLength(0); i++)
                        {
                            for (int j = 0; j < myarray.GetLength(1); j++)
                            {
                                Console.Write(myarray[i, j] + "\t");
                            }
                            Console.WriteLine();
                        }
                        break;

                    case 3: // Exercises 3
                        a = new int[,] {{1, 0, 0, 1, 0},
                                {0, 0, 0, 9, 0},
                                {0, 0, 1, 1, 0}, 
                                {0, 0, 0, 0, 1}, 
                                {0, 0, 1, 0, 0}};

                        bool flag = true;
                        for (int i = 0; i < a.GetLength(0) && flag; i++)
                        {
                            for (int j = 0; j < a.GetLength(1) && flag; j++)
                            {
                                if (a[i, j] != 0 && a[i, j] != 1)
                                {
                                    flag = false;
                                    break;
                                }
                            }
                        }

                        Console.WriteLine(flag);
                        break;
                    case 4: // Exercises 4
                       a = new int[,] {{1, 7, 9, 1, 1},
                       {0, 8, 7, 1, 2},
                       {0, 0, 1, 9, 3}, 
                       {1, 0, 0, 2, 1}, 
                       {0, 0, 0, 0, 5}};

                        flag = true;
                        for (int i = 1; i < a.GetLength(0) && flag; i++)
                        {
                            for (int j = 0; j < i && flag; j++)
                            {
                                if (i > j && a[i, j] != 0)
                                {
                                    flag = false;
                                    break;
                                }
                            }
                        }

                        Console.WriteLine(flag);
                        break;
                    case 5: // Exercises 5
                        char[,] q_array = {{'*','*','*','Q','*'},
                        {'*','Q','*','*','*'},
                        {'*','*','*','*','Q'},
                        {'*','*','Q','*','*'},
                        {'Q','*','*','*','*'}};

                        flag = true;
                        for (int i = 0; i < q_array.GetLength(0) && flag; i++)
                        {
                            int counter = 0;
                            int counter2 = 0;
                            for (int j = 0; j < q_array.GetLength(1) && flag; j++)
                            {
                                if (q_array[i, j] == 'Q') counter++;
                                if (q_array[j, i] == 'Q') counter2++;
                            }
                            if (counter > 1 || counter2 > 1)
                            {
                                flag = false;
                                break;
                            }
                        }
                        Console.WriteLine(flag);
                        break;
                    case 6: // Exercises 6
                        Console.Write("Enter n: ");
                        int n = Convert.ToInt32(Console.ReadLine());

                        bool[,,] boolArray = new bool[n, n, n];
                        for (int i = 0; i < boolArray.GetLength(0); i++)
                        {
                            for (int j = 0; j < boolArray.GetLength(1); j++)
                            {
                                for (int k = 0; k < boolArray.GetLength(2); k++)
                                {
                                    bool prime_i = true;
                                    bool prime_j = true;
                                    bool prime_k = true;
                                    for (int p = 2; p < i; p++)
                                    {
                                        if (i % p == 0) prime_i = false;
                                    }
                                    for (int p = 2; p < j; p++)
                                    {
                                        if (j % p == 0) prime_j = false;
                                    }
                                    for (int p = 2; p < k; p++)
                                    {
                                        if (k % p == 0) prime_k = false;
                                    }
                                    if (i < 2) prime_i = false;
                                    if (j < 2) prime_j = false;
                                    if (k < 2) prime_k = false;

                                    if (prime_i && prime_j && prime_k)
                                        boolArray[i, j, k] = true;

                                    if (boolArray[i, j, k] == true)
                                        Console.Write("T ");
                                    else Console.Write("F ");
                                }

                                Console.WriteLine();
                            }
                            Console.WriteLine();
                            Console.WriteLine();
                        }
                        break;
                    case 7: // Exercises 7
                        int[,] mArray = new int[,] {{1, 5, 4},
                       {3, 8, 2},
                       {-2, 6, 3}, 
                       {4, -2, 8}, 
                       {6, -3, 6}};

                        double totalx = 0;
                        double totaly = 0;
                        double totalm = 0;

                        for (int i = 0; i < mArray.GetLength(0); i++)
                        {
                            totalx += mArray[i, 0] * mArray[i, 2];
                            totaly += mArray[i, 1] * mArray[i, 2];
                            totalm += mArray[i, 2];
                        }

                        Console.Write("cendroid({0}, {1}, {2})", Math.Round(totalx / totalm, 2), Math.Round(totaly / totalm, 2), totalm);
                        break;
                    default:
                        exit = true;
                        break;
                }
                Console.ReadLine();
            }
        }
    }
}
