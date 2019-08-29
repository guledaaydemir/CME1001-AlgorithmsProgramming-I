using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Finding Champion Team Program

            //Assume that there are 10 clubs in the football super league.
            string[,] teams = new string[,] {{"1","GS","Galatasaray"},
                                             {"2","FB","Fenerbahçe"},
                                             {"3","BJ","Beşiktaş"},
                                             {"4","SS","Sivasspor"},
                                             {"5","TS","Trabzonspor"},
                                             {"6","GT","Göztepe"},
                                             {"7","AS","Antalyaspor"},
                                             {"8","GA","Gaziantepspor"},
                                             {"9","GB","Gençlerbirliği"},
                                             {"10","BS","Bursaspor"}};

            //Each Team matches with all other teams
            //this array will go to the 3rd level to find champion
            int[,] matches = new int[,] {{0,0,0,0,2,1,1,0,0,0},
                                         {1,0,0,0,1,0,0,2,0,0},
                                         {2,0,0,0,0,0,0,2,1,3},
                                         {2,0,0,0,1,2,0,1,1,1},
                                         {0,1,0,2,0,0,0,0,1,1},
                                         {2,2,0,0,2,0,2,0,0,0},
                                         {0,1,0,0,1,0,0,0,0,1},
                                         {1,1,2,1,0,0,2,0,0,1},
                                         {0,0,0,0,1,0,2,1,0,0},
                                         {0,1,1,0,1,0,1,0,1,0}};

            // Rule 1: 3 points if team x defeats team y
            // Rule 2: 0 points if team x loses match against team y
            // Rule 3: 1 points if teams x and y tie

            //Finding Champion Team Starts here

            //Let's make an array for each team that keeps the total points, won times, tie times,lost times and number of goals

            int[,] totalArray = new int[,] { {0,0,0,0,0},
                                             {0,0,0,0,0},
                                             {0,0,0,0,0},
                                             {0,0,0,0,0},
                                             {0,0,0,0,0},
                                             {0,0,0,0,0},
                                             {0,0,0,0,0},
                                             {0,0,0,0,0},
                                             {0,0,0,0,0},
                                             {0,0,0,0,0}};

            //Let's make an array to find the order of the getting points 
            int[,] orderOfPoints = new int[,] {{0,0,0,0,0,0,0,0,0,0},
                                               {0,0,0,0,0,0,0,0,0,0},
                                               {0,0,0,0,0,0,0,0,0,0},
                                               {0,0,0,0,0,0,0,0,0,0},
                                               {0,0,0,0,0,0,0,0,0,0},
                                               {0,0,0,0,0,0,0,0,0,0},
                                               {0,0,0,0,0,0,0,0,0,0},
                                               {0,0,0,0,0,0,0,0,0,0},
                                               {0,0,0,0,0,0,0,0,0,0},
                                               {0,0,0,0,0,0,0,0,0,0}};

            //Calculating and filling the totalArray
            for (int i =0;i< matches.GetLength(0); i++) //looking for rows
            {
                for (int j = 0; j < matches.GetLength(1); j++) //looking for columns
                {
                    if (j > i) //looking upper triangle and make comparision to lower triangle
                    {
                        if (matches[i, j] > matches[j, i]) //i defeats j
                        {
                            //adding 3 points to i-th team
                            totalArray[i, 0] = totalArray[i, 0] + 3;
                           
                            //i-th team won 1 game
                            totalArray[i, 1] = totalArray[i, 1] + 1;
                            orderOfPoints[i, j] = 3;
                            //j-th team lost 1 game
                            totalArray[j, 3] = totalArray[j, 3] + 1;
                            orderOfPoints[j, i] = 0;
                        }
                        else if (matches[i, j] < matches[j, i]) //j defeats i
                        {
                            //adding 3 points to j-th team
                            totalArray[j, 0] = totalArray[j, 0] + 3;

                            //j-th team won 1 game
                            totalArray[j, 1] = totalArray[j, 1] + 1;
                            orderOfPoints[j, i] = 3;
                            //i-th team lost 1 game
                            totalArray[i, 3] = totalArray[i, 3] + 1;
                            orderOfPoints[i, j] = 0;
                        }
                        else if (matches[i, j] == matches[j, i]) //tie
                        {
                            //adding 1 point to i-th and j-th team
                            totalArray[i, 0] = totalArray[i, 0] + 1;
                            totalArray[j, 0] = totalArray[j, 0] + 1;

                            //i-th and j-th teams are tie
                            totalArray[i, 2] = totalArray[i, 2] + 1;
                            totalArray[j, 2] = totalArray[j, 2] + 1;
                            orderOfPoints[i, j] = 1;
                            orderOfPoints[j, i] = 1;
                        }
                    }
                }
            } //End of calculating and filling the totalArray

            //filling total number of goals to a totalArray
            for (int i = 0; i < matches.GetLength(0); i++) //looking for rows
            {
                for (int j = 0; j < matches.GetLength(1); j++) //looking for columns
                {
                    totalArray[i, 4] = totalArray[i, 4] + matches[i, j];
                }
            }

            //Finding the max champion point
            int max = 0;
            for (int i = 0; i < totalArray.GetLength(0); i++)
            {
                if (totalArray[i, 0] > max)
                {
                    max = totalArray[i, 0];
                }
            }

            //Finding the count of team that has the same max champ point
            int[] samePointTeams = new int[] {-1,-1,-1,-1,-1,-1,-1,-1,-1,-1}; // worst condition = all of them will be same

            //marking the samePointTeams Array that has the same point of champion point
            int count = 0;
            for (int i = 0; i < totalArray.GetLength(0); i++)
            {
                if (totalArray[i, 0] == max)
                {
                    count++; //counting how many of them are same
                    samePointTeams[i] = i; // add their Id's
                }
            }

            if (count == 1) //Level 1: there is only one champion team
            {
                //lets find this one's ID and print the output
                for (int i = 0; i < totalArray.GetLength(0); i++)
                {
                    if (totalArray[i, 0] == max)
                    {
                        Console.WriteLine("The Champion Team: " + teams[i, 2] + " with " + max + " points");
                        Console.WriteLine("Because:");
                        Console.WriteLine(teams[i, 1] + " won " + totalArray[i, 1] + " time, lost " + totalArray[i, 3] + " and tie " + totalArray[i, 2] + " time.");
                        Console.Write("(");
                        for (int k = 0; k < orderOfPoints.GetLength(1); k++)
                        {
                            if (k != i)
                            {
                                    Console.Write("+" + orderOfPoints[i, k]);
                            }
                        }
                        Console.Write(")=" + max);
                    }
                }
                //end output
            }
            else //more than one champ with same champ point
            {
                for (int i = 0; i < samePointTeams.GetLength(0); i++) //Level 2: if there is more than 1 champ, find the total goals
                {
                    if (samePointTeams[i] != (-1)) //get number of goals from their Id's
                    {
                        //comparing the number of goals
                        //writing the number of goals trough the samePointTeams_Id[i] to compare
                        samePointTeams[i] = totalArray[i, 4];
                    }
                }

                //Finding max number of goals
                int maxGoal = 0; 
                for (int j = 0; j < samePointTeams.GetLength(0); j++)
                {
                    if (samePointTeams[j] > maxGoal)
                    {
                        maxGoal = samePointTeams[j];
                    }
                }

                //finding how many team has the maxGoal
                count = 0;
                for (int j = 0; j < samePointTeams.GetLength(0); j++) // if its not equal to max turn it -1
                {
                    if (samePointTeams[j] != maxGoal)
                    {
                        samePointTeams[j] = (-1);
                    }
                    else count++; //not -1
                }

                if (count == 1) // only 1 team has the maxGoal
                {
                    //print for the champion output
                    for (int i = 0; i < samePointTeams.GetLength(0); i++)
                    {
                        if (samePointTeams[i] != -1) // if its not -1 then the id is i is the champ
                        {
                                //printing
                                Console.WriteLine("The Champion Team: " + teams[i, 2] + " with " + max + " points");
                                Console.WriteLine("Because:");
                                Console.WriteLine(teams[i, 1] + " won " + totalArray[i, 1] + " time, lost " + totalArray[i, 3] + " and tie " + totalArray[i, 2] + " time.");
                                Console.Write("(");
                                for (int k = 0; k < orderOfPoints.GetLength(1); k++)
                                {
                                    if (k != i)
                                    {
                                        Console.Write("+" + orderOfPoints[i, k]);
                                    }
                                }
                                Console.Write(")=" + max);
                            
                        }
                        
                    }
                }
                else // there is more than 1 champ with both points and scored goals are equal
                {
                    for (int i = 0; i < samePointTeams.GetLength(0); i++)  //Level 3: the goals that the team againts the other teams
                    {
                        if (samePointTeams[i] != (-1))
                        {
                            samePointTeams[i] = 0;
                            for (int j = 0; j < samePointTeams.GetLength(0); j++)
                            {
                                if (i != j && samePointTeams[j] != (-1))
                                {
                                    samePointTeams[i] = samePointTeams[i] + matches[i, j];
                                }
                            }
                        }

                    }

                    //finding which team has less goal
                    int min = 0;
                    for (int i = 0; i < samePointTeams.GetLength(0); i++)
                    {
                        if (samePointTeams[i] <= min && samePointTeams[i]!=-1)
                        {
                            min = samePointTeams[i];
                        }
                    }

                    //if its bigger than min marking with -1
                    for (int i = 0; i < samePointTeams.GetLength(0); i++)
                    {
                        if(samePointTeams[i] != min)
                        {
                            samePointTeams[i] = -1;
                        }
                    }

                    //We don't need to calculate count, if there is more than one champ, there will be a more than one champ to print
                    for (int i = 0; i < samePointTeams.GetLength(0); i++)
                    {
                        if (samePointTeams[i] != -1) // if its not -1 then the id is i is the champ
                        {
                            //printing
                            Console.WriteLine("The Champion Team: " + teams[i, 2] + " with " + max + " points");
                            Console.WriteLine("Because:");
                            Console.WriteLine(teams[i, 1] + " won " + totalArray[i, 1] + " time, lost " + totalArray[i, 3] + " and tie " + totalArray[i, 2] + " time.");
                            Console.Write("(");
                            for (int k = 0; k < orderOfPoints.GetLength(1); k++)
                            {
                                if (k != i)
                                {
                                    Console.Write("+" + orderOfPoints[i, k]);
                                }
                            }
                            Console.Write(")=" + max);
                            Console.WriteLine(); //enter

                        }
                    }
                } 
            }
            Console.ReadLine();
        }
    }
}
