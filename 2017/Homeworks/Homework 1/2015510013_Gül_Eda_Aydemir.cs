using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Inputs 
            Console.WriteLine("Enter day=");
            int day = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter month=");
            int month = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter year (1800-2150)=");
            int year = Convert.ToInt16(Console.ReadLine());

            //variables
            string theDayOfTheWeek = ""; //day string mode
            string theMonth = ""; //month string mode

            int a, b, c, d; // for finding the day of the week 

            bool isValid = false; //for output

            //Finding the date is valid or not.

            if (day>0 && day < 32)
            {
                if(month<13 && month > 0)
                {
                    if(year<=2150 && year >= 1800)
                    {
                        if (month == 2)
                        {
                            if (year % 4 == 0)
                            {
                                if(day<30 && day > 0)
                                {
                                    isValid = true;
                                }else Console.WriteLine("not valid because of February Problem");

                            }
                            else 
                            {
                                if (day < 29 && day > 0)
                                {
                                    isValid = true;
                                }
                                else Console.WriteLine("not valid because of February Problem");
                            }
                        }
                        else if(month == 4 || month == 6 || month == 9 || month == 11)
                        {
                            if (day == 31)
                            {
                                Console.WriteLine("not valid because of end of the day of that month");
                            }
                            else isValid = true;
                        }
                        else isValid = true;
                    }
                    else Console.WriteLine("not valid because of year");

                }
                else Console.WriteLine("not valid because of month");

            }
            else Console.WriteLine("not valid because of day");



            //OUTPUT

            if (isValid)
            {

                // Output for the Season 
                if (month == 12 || month == 1 || month == 2)
                {
                    Console.WriteLine("The Season = Winter");
                }
                else if (month == 3 || month == 4 || month == 5)
                {
                    Console.WriteLine("The Season = Spring");
                }
                else if (month == 6 || month == 7 || month == 8)
                {
                    Console.WriteLine("The Season = Summer");
                }
                else
                {
                    Console.WriteLine("The Season = Autumn");
                }


                // Output for the day of the week 
                a = year - (14 - month) / 12;
                b = a + a / 4 - a / 100 + a / 400;
                c = month + 12 * ((14 - month) / 12) - 2;
                d = (day + b + (31 * c) / 12) % 7;

                if (d == 0)
                {
                    theDayOfTheWeek = "Sunday";
                }
                else if (d == 1)
                {
                    theDayOfTheWeek = "Monday";
                }
                else if (d == 2)
                {
                    theDayOfTheWeek = "Tuesday";
                }
                else if (d == 3)
                {
                    theDayOfTheWeek = "Wednesday";
                }
                else if (d == 4)
                {
                    theDayOfTheWeek = "Thursday";
                }
                else if (d == 5)
                {
                    theDayOfTheWeek = "Friday";
                }
                else if (d == 6)
                {
                    theDayOfTheWeek = "Saturday";
                }

                Console.WriteLine("The day of the Week = {0}", theDayOfTheWeek);

                // Output for the Next Date
                if (month == 2)
                {
                    if ((year % 4 == 0 && day == 29) || (year % 4 != 0 && day == 28)) // last day of the february
                    {
                        month++;
                        day = 1;
                    }
                    else
                    {
                        day++;
                    }
                }
                else if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12) // /end of the day is 31
                {
                    if (day == 31)
                    {
                        if (month == 12) // end of the year
                        {
                            day = 1;
                            month = 1;
                            year++;
                        }
                        else
                        {
                            day = 1;
                            month++;
                        }
                    }
                    else
                    {
                        day++;
                    }
                }
                else if (month == 4 || month == 6 || month == 9 || month == 11) //end of the day is 30 
                {
                    if (day == 30)
                    {
                        day = 1;
                        month++;
                    }
                    else
                    {
                        day++;
                    }
                }

                theMonth = (month == 1) ? "January" : (month == 2) ? "February" : (month == 3) ? "March" : (month == 4) ? "April" : (month == 5) ? "May" : (month == 6) ? "June"
                        : (month == 7) ? "July" : (month == 8) ? "August" : (month == 9) ? "September" : (month == 10) ? "October" : (month == 11) ? "November" : "December"; // the if else part will be so long so i did it in this way.

                Console.WriteLine("The next date = {0} {1} {2}", day, theMonth, year);
            }
            Console.ReadLine();
        }
    }
}
