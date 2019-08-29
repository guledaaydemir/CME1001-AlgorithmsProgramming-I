using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab8
{
    class Program
    {
        static void Main(string[] args)
        {
            /*1
            string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            int[] matches = { 5, 7, 4, 6, 5, 4, 6, 5, 2, 3, 5, 3, 6, 6, 6, 5, 6, 6, 5, 4, 5, 4, 6, 4, 4, 5 };

            Console.Write("Enter a string: ");
            string str = Console.ReadLine();
            int sum = 0;
            for (int i = 0; i < str.Length; i++)
            {
                int index = alphabet.IndexOf(str.Substring(i, 1));
                sum += matches[index];
            }
            Console.Write(sum);
            */
            /*2
            bool alliteration = true;
            string str = "Alice’s aunt ate apples and acorns around August";
            string[] parts = str.Split(' ');
            for (int i = 1; i < parts.Length; i++)
            {
                if (parts[0].Substring(0, 1).ToLower() != parts[i].Substring(0, 1).ToLower())
                {
                    alliteration = false;
                    break;
                }
            }
            Console.Write(alliteration);
            */

            /*3
            string str = "Watch out for that red car, Henry";
            string[] parts = str.Split(" ,!.?;".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            bool isHeard = true;
            for (int i = 0; i < parts.Length; i++)
            {
                if (parts[i].Length > 5)
                {
                    isHeard = false;
                    break;
                }
            }
            Console.Write(isHeard);
             * */

            /*4
            string str = "He's very intelligent - just like his daddy, isn’t he?";
            str = str.Replace("he", "she");
            str = str.Replace("He", "She");
            str = str.Replace("his", "her");
            str = str.Replace("His", "Her");
            Console.Write(str);
            */
            /*5
            string str = "Madame in Eden, i'm Adam!";
            str = str.Replace(" ", "");
            str = str.Replace(".", "");
            str = str.Replace(",", "");
            str = str.Replace("'", "");
            str = str.Replace("!", "");
            str = str.Replace("?", "");

            bool isPalindrome = true;


            for (int i = 0; i < str.Length; i++)
            {
                isPalindrome = true;

                string temp_str = str.Remove(i, 1);
                for (int j = 0; j < temp_str.Length / 2; j++)
                {
                    if (temp_str.Substring(j, 1).ToLower() != temp_str.Substring(temp_str.Length - 1 - j, 1).ToLower())
                    {
                        isPalindrome = false;
                        break;
                    }
                }

                if (isPalindrome)
                {
                    Console.WriteLine(str.Substring(i, 1));
                    Console.WriteLine(temp_str);
                    break;
                }
            }
            */
            /*6
            string str = "This program is supposed to automate the translation Input to the program will be several English sentences";
            string[] parts = str.Split(' ');
            string output = "";
            for (int i = 0; i < parts.Length; i++)
            {
                if ("aeiouAEIOU".IndexOf(parts[i].Substring(0, 1)) >= 0)
                {
                    output += parts[i] + " ";
                }
                else
                {
                    output += parts[i].Substring(1) + "-" + parts[i].Substring(0, 1) + "ay ";
                }
            }
            Console.WriteLine(output);
            */

            /*
            int number = 28546;
            string output = "";

            while (number > 7)
            {
                output = number % 7 + output;
                number /= 7;
            }
            output = number + output;
            Console.WriteLine(output);
             */

            string s1 = "7854698889623741342999";
            string s2 = "2200056662547832225001";

            if (s1.Length < s2.Length)
            {
                int diff = s2.Length - s1.Length;
                for (int i = 0; i < diff; i++)
                {
                    s1 = "0" + s1;
                }
            }

            if (s2.Length < s1.Length)
            {
                int diff = s1.Length - s2.Length;
                for (int i = 0; i < diff; i++)
                {
                    s2 = "0" + s2;
                }
            }

            string output = "";
            bool remainder = false;
            for (int i = s1.Length - 1; i >=0; i--)
            {
                int sum = Convert.ToInt32(s1.Substring(i, 1)) + Convert.ToInt32(s2.Substring(i, 1));
                if (remainder)
                {
                    sum++;
                    remainder = false;
                }

                if (sum >= 10)
                {
                    output = (sum % 10) + output;
                    remainder = true;
                }
                else output = sum + output;

            }

            if (remainder) output = "1" + output;
            Console.WriteLine(output);

            Console.ReadLine();
        }
    }
}