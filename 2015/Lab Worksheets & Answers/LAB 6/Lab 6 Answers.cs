using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LAB6
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
                Console.WriteLine();
                Console.Write("Your choice:");
                int choice = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                switch (choice)
                {
                    case 1: // Exercises 1
                        int[] numbers = { 7, 4, 15, 16, 12, 55, 4, 80, 12, 72, 17, 3, 60, 11 };

                        for (int i = 0; i < numbers.Length; i++)
                        {
                            if (numbers[i] % 5 == 0)
                            {
                                Console.Write(numbers[i] + " ");
                            }
                        }
                        break;

                    case 2:
                        string[] Names = { "banana", "orange", "apple", "melon", "banana", "melon", "grape", "banana", "pear", "orange", "kiwi" };
                        Console.Write("Enter a fruit:");
                        string fruit = Console.ReadLine();
                        int counter = 0;

                        for (int i = 0; i < Names.Length; i++)
                        {
                            if (Names[i].ToLower() == fruit.ToLower())
                            {
                                counter++;
                            }
                        }
                        Console.Write(counter);
                        break;

                    case 3:
                        string[] names = { "ali", "ayşe", "ayşe", "sibel", "zeynep" };
                        string[] surnames = { "kaya", "duman", "ak", "yılmaz", "tok" };
                        string[] tel_numbers = { "4234411", "2216688", "3348845", "2225543", "2243321" };

                        Console.Write("Enter name:");
                        string name = Console.ReadLine();
                        Console.Write("Enter surname:");
                        string surname = Console.ReadLine();
                        bool found = false;

                        for (int i = 0; i < names.Length; i++)
                        {
                            if (names[i].ToLower() == name.ToLower() &&
                               surnames[i].ToLower() == surname.ToLower())
                            {
                                Console.Write(tel_numbers[i]);
                                found = true;
                            }
                        }

                        if (!found)
                            Console.Write("Not found!!");
                        break;

                    case 4:
                        string[] myarray = new string[] { "Ankara", "Izmir", "Izmir", "Antalya", "Izmir", "Trabzon", "Istanbul", "Bursa", "Aydın", "Istanbul" };
                        for (int i = 0; i < myarray.Length; i++)
                        {
                            if (myarray[i] == "Izmir")
                                myarray[i] = "Istanbul";
                            else if (myarray[i] == "Istanbul")
                                myarray[i] = "Izmir";

                            Console.Write(myarray[i] + " ");
                        }
                        break;

                    case 5:
                        int[] nums = { 1, 2, 2, 1, 5, 1, 1, 7, 7, 7, 7, 1, 1, 1, 1, 1, 2 };
                        int max_number = nums[0]; // to keep the number in currently longest sequence
                        int max_length = 1; // to keep the length of currently longest sequence
                        int max_starting_position = 0; // to keep the starting position of currently longest sequence

                        int number = nums[0];// to keep the number in current sequence
                        int length = 1;// to keep the length of current sequence
                        int starting_position = 0;// to keep the starting position of current sequence

                        for (int i = 1; i < nums.Length; i++)
                        {
                            if (nums[i] == nums[i - 1])
                            {
                                length++;
                            }
                            else //end of a sequence
                            {
                                if (max_length < length)
                                {
                                    max_number = number;
                                    max_length = length;
                                    max_starting_position = starting_position;
                                }

                                number = nums[i];
                                length = 1;
                                starting_position = i;
                            }
                        }

                        if (max_length < length) // to control last sequence
                        {
                            max_number = number;
                            max_length = length;
                            max_starting_position = starting_position;
                        }

                        Console.WriteLine("number = " + max_number);
                        Console.WriteLine("length = " + max_length);
                        Console.WriteLine("starting position = " + (max_starting_position + 1));

                        break;

                    case 6:
                        int[] a = { 1, 12, 3, 4, 6, 20 };
                        int[] b = { 10, 2, 1, 22, 4, 8, 16, 9 };

                        for (int i = 0; i < a.Length; i++)
                        {
                            for (int j = 0; j < b.Length; j++)
                            {
                                if (a[i] == b[j])
                                {
                                    Console.Write(a[i] + " ");
                                    break;
                                }
                            }
                        }
                        break;
                }//switch
                Console.ReadLine();
            }//while
        }
    }
}