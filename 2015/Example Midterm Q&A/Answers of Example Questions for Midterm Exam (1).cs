using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vizeSorulari
{
    class Program
    {
        static void Main(string[] args)
        {

            bool exit = false;

            while (!exit)
            {
                Console.Clear();
                Console.WriteLine("**** MENU ****");
                Console.WriteLine("1) Example 1");
                Console.WriteLine("2) Example 2");
                Console.WriteLine("3) Example 3");
                Console.WriteLine("4) Example 4");
                Console.WriteLine("5) Example 5");
                Console.WriteLine("6) Example 6");
                Console.WriteLine("7) Example 7");
                Console.WriteLine("8) Example 8");
                Console.WriteLine("9) Example 9");
                Console.WriteLine("10) Example 10");
                Console.WriteLine("11) Example 11");
                Console.WriteLine("12) Example 12");
                Console.WriteLine("13) Example 13");
                Console.WriteLine("14) Example 14");
                Console.WriteLine("15) Example 15");
                Console.WriteLine("16) Example 16");
                Console.WriteLine("17) Example 17");
                Console.WriteLine("18) Example 18");
                Console.WriteLine("19) EXIT");
                Console.WriteLine();
                Console.Write("Your choice:");
                int choice = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                switch (choice)
                {
                    case 1:
                        Console.Write("Input: ");
                        int num = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Output:");
                        for (int i = 0; i <= num; i++)
                        {
                            Console.WriteLine("{0}+{1}={2}", i, num - i, num);
                        }

                        Console.ReadLine();
                        break;
                    case 2:
                        int blank1 = 3;
                        int blank2 = 7;
                        int diyez = 4;

                        for (int i = 0; i < 4; i++)
                        {
                            for (int j = 0; j < blank1; j++)
                            {
                                Console.Write(" ");
                            }
                            for (int j = 0; j < diyez; j++)
                            {
                                Console.Write("#");
                            }
                            for (int j = 0; j < blank2; j++)
                            {
                                Console.Write(" ");
                            }
                            for (int j = 0; j < diyez; j++)
                            {
                                Console.Write("#");
                            }

                            blank1--;
                            diyez = diyez + 2;
                            blank2 = blank2 - 2;
                            Console.WriteLine();
                        }

                        blank1 = 0;
                        diyez = 21;
                        for (int i = 0; i < 11; i++)
                        {
                            for (int j = 0; j < blank1; j++)
                            {
                                Console.Write(" ");
                            }
                            for (int j = 0; j < diyez; j++)
                            {
                                Console.Write("#");
                            }
                            blank1++;
                            diyez -= 2;
                            Console.WriteLine();
                        }
                        Console.ReadLine();
                        break;
                    case 3:
                        int[,] a = new int[,] {{0, 7, 8, 9, 2},
                       {2, 5, 0, 1, 0},
                       {7, 0, 6, 0, 0},
                       {2, 0, 0, 4, 0},
                       {7, 0, 0, 0, 1}};

                        bool isArrowHead = true;
                        if (a.GetLength(0) != a.GetLength(1))
                            isArrowHead = false;
                        else
                        {
                            for (int i = 0; i < a.GetLength(0) && isArrowHead; i++)
                            {
                                for (int j = 0; j < a.GetLength(1); j++)
                                {
                                    if ((i == 0 || j == 0 || i == j) && a[i, j] == 0)
                                    {
                                        isArrowHead = false;
                                        break;
                                    }
                                    else if (!(i == 0 || j == 0 || i == j) && a[i, j] != 0)
                                    {
                                        isArrowHead = false;
                                        break;
                                    }
                                }

                            }
                        }

                        Console.WriteLine(isArrowHead);
                        Console.ReadLine();
                        break;
                    case 4:
                        double result = 0.0;
                        for (double i = 1.0; i <= 5000.0; i++)
                        {
                            result += 1.0 / (i * (i + 1.0));
                        }
                        Console.WriteLine(result);
                        Console.ReadLine();

                        break;
                    case 5:
                        int bosluk = 8;
                        int arti = 1;
                        int yildiz = 37;

                        for (int i = 0; i < 9; i++)
                        {
                            Console.Write("    0   ");

                            for (int j = 0; j < bosluk; j++)
                            {
                                Console.Write(" ");
                            }
                            for (int j = 0; j < arti; j++)
                            {
                                Console.Write("+");
                            }
                            arti += 3;
                            bosluk--;
                            Console.WriteLine();
                        }
                        for (int i = 0; i < 6; i++)
                        {
                            for (int j = 0; j < i; j++)
                            {
                                Console.Write(" ");
                            }
                            for (int j = 0; j < yildiz; j++)
                            {
                                Console.Write("*");
                            }
                            yildiz -= 2;
                            Console.WriteLine();
                        }

                        Console.ReadLine();
                        break;
                    case 6:
                        a = new int[,] { { 0, 1, 1, -1, -1 }, 
                             { 1, 0, -1, 1, -1 }, 
                             { 1, -1, 0, 1, 1 },
                             { -1, 1, 1, 8, -1 }, 
                             { -1, 1, 1, -1, 0 } };

                        bool conference = true;

                        if (a.GetLength(0) == a.GetLength(1))
                        {
                            for (int i = 0; i < a.GetLength(0); i++)
                            {
                                for (int j = 0; j < a.GetLength(1); j++)
                                {
                                    if (i == j && a[i, j] != 0)
                                    {
                                        conference = false;
                                        break;
                                    }
                                    else if (i != j && a[i, j] != -1 && a[i, j] != 1)
                                    {
                                        conference = false;
                                        break;
                                    }
                                }

                                if (!conference)
                                    break;
                            }
                        }
                        else
                        {
                            conference = false;
                        }

                        Console.WriteLine(conference);
                        Console.ReadLine();
                        break;
                    case 7:
                        Console.Write("Inputs: ");
                        int input1 = Convert.ToInt32(Console.ReadLine());
                        int input2 = Convert.ToInt32(Console.ReadLine());

                        int biggest = input1 > input2 ? input1 : input2;

                        int okek = 1;
                        for (int i = 2; i <= biggest; i++)
                        {
                            if (input1 % i == 0 && input2 % i == 0)
                            {
                                okek *= i;
                                input1 /= i;
                                input2 /= i;
                            }
                            else if (input1 % i == 0)
                            {
                                okek *= i;
                                input1 /= i;
                            }
                            else if (input2 % i == 0)
                            {
                                okek *= i;
                                input2 /= i;
                            }
                        }

                        if (input1 == input2)
                        {
                            okek *= input1;
                        }
                        else
                        {
                            okek *= input1 * input2;
                        }
                        Console.Write(okek);
                        Console.ReadLine();
                        break;
                    case 8:
                        int w_num = 0;
                        int s_num = 1;
                        int t_num = 9;
                        int z_num = 8;

                        for (int i = 0; i < 10; i++)
                        {
                            for (int j = 1; j < 10 - i; j++)
                            {
                                Console.Write(" ");
                            }
                            for (int j = 0; j < w_num; j++)
                            {
                                Console.Write("W");
                            }
                            for (int j = 0; j < s_num; j++)
                            {
                                Console.Write("S");
                            }
                            w_num++;
                            s_num++;
                            Console.WriteLine();
                        }

                        for (int i = 0; i < 10; i++)
                        {
                            for (int j = 0; j <= i; j++)
                            {
                                Console.Write(" ");
                            }
                            for (int j = 0; j < t_num; j++)
                            {
                                Console.Write("T");
                            }
                            for (int j = 0; j < z_num; j++)
                            {
                                Console.Write("Z");
                            }
                            t_num--;
                            z_num--;
                            Console.WriteLine();
                        }

                        Console.ReadLine();
                        break;

                    case 9:
                        a = new int[,] {{1, 1, 1, 1},
                                   {1, 1, 0, 1},
                                   {1, 0, 1, 0},
                                   {1, 0, 0, 1}};

                        bool redheffer = true;

                        if (a.GetLength(0) == a.GetLength(1))
                        {
                            for (int i = 0; i < a.GetLength(0); i++)
                            {
                                for (int j = 0; j < a.GetLength(1); j++)
                                {
                                    if ((j == 0 || (j + 1) % (i + 1) == 0) && a[i, j] != 1)
                                    {
                                        redheffer = false;
                                        break;
                                    }
                                    else if (j != 0 && (j + 1) % (i + 1) != 0 && a[i, j] != 0)
                                    {
                                        redheffer = false;
                                        break;
                                    }

                                }

                                if (!redheffer)
                                    break;
                            }
                        }
                        else
                        {
                            redheffer = false;
                        }

                        Console.WriteLine(redheffer);
                        Console.ReadLine();
                        break;

                    case 10:
                        Console.Write("Enter a number :");
                        num = Convert.ToInt32(Console.ReadLine());

                        bool hexagonal = false;

                        for (int n = 1; n <= num; n++)
                        {
                            if (n * (2 * n - 1) == num)
                            {
                                hexagonal = true;
                                break;
                            }
                        }

                        Console.WriteLine(hexagonal);
                        Console.ReadLine();
                        break;

                    case 11:
                        num = 3;
                        for (int i = 0; i < 10; i++)
                        {
                            int temp = num;
                            for (int j = 0; j <= i; j++)
                            {
                                Console.Write(temp + " ");
                                temp++;
                            }
                            Console.WriteLine();
                            num += 2;
                        }

                        Console.ReadLine();
                        break;

                    case 12:
                        a = new int[,] {{1, 0, 0, 0},
                           {5, 4, 0, 0},
                           {0, 3, 3, 0},
                           {0, 0, 2, 3}};


                        bool bidiagonal = true;

                        bool aboveDiagonal = false;
                        bool belowDiagonal = false;

                        if (a.GetLength(0) == a.GetLength(1))
                        {
                            for (int i = 0; i < a.GetLength(0); i++)
                            {
                                for (int j = 0; j < a.GetLength(1); j++)
                                {
                                    if (i == j && a[i, j] == 0)
                                    {
                                        bidiagonal = false;
                                        break;
                                    }
                                    else if (j + 1 != i && i > j && a[i, j] != 0)
                                    {
                                        bidiagonal = false;
                                        break;
                                    }
                                    else if (i + 1 != j && j > i && a[i, j] != 0)
                                    {
                                        bidiagonal = false;
                                        break;
                                    }

                                    if (a[0, 1] != 0)
                                    {
                                        aboveDiagonal = true;
                                    }
                                    if (a[1, 0] != 0)
                                    {
                                        belowDiagonal = true;
                                    }
                                }

                                if (!bidiagonal)
                                    break;
                            }

                            if (!belowDiagonal && !aboveDiagonal)
                            {
                                bidiagonal = false;
                            }
                            else if (belowDiagonal && aboveDiagonal)
                            {
                                bidiagonal = false;
                            }
                            else if (bidiagonal && belowDiagonal)
                            {
                                int bdi = 1;
                                int bdj = 0;
                                do
                                {
                                    if (a[bdi, bdj] == 0)
                                    {
                                        bidiagonal = false;
                                        break;
                                    }
                                    bdi++;
                                    bdj++;
                                } while (bdi < a.GetLength(0) && bdj < a.GetLength(1));

                                if (bidiagonal)
                                {
                                    bdi = 0;
                                    bdj = 1;
                                    do
                                    {
                                        if (a[bdi, bdj] != 0)
                                        {
                                            bidiagonal = false;
                                            break;
                                        }
                                        bdi++;
                                        bdj++;
                                    } while (bdi < a.GetLength(0) && bdj < a.GetLength(1));
                                }


                            }
                            else if (bidiagonal && aboveDiagonal)
                            {
                                int bdi = 0;
                                int bdj = 1;
                                do
                                {
                                    if (a[bdi, bdj] == 0)
                                    {
                                        bidiagonal = false;
                                        break;
                                    }
                                    bdi++;
                                    bdj++;
                                } while (bdi < a.GetLength(0) && bdj < a.GetLength(1));

                                if (bidiagonal)
                                {
                                    bdi = 1;
                                    bdj = 0;
                                    do
                                    {
                                        if (a[bdi, bdj] != 0)
                                        {
                                            bidiagonal = false;
                                            break;
                                        }
                                        bdi++;
                                        bdj++;
                                    } while (bdi < a.GetLength(0) && bdj < a.GetLength(1));
                                }
                            }

                        }
                        else
                        {
                            bidiagonal = false;
                        }

                        Console.WriteLine(bidiagonal);
                        Console.ReadLine();
                        break;

                    case 13:
                        double maxH = 0;
                        for (int t = 0; t <= 45; t++)
                        {
                            double temp = 0.12 * t * t * t * t + 12 * t * t * t - 380 * t * t + 4100 * t + 220;
                            Console.WriteLine("Height {0}: {1}", t, temp);

                            if (temp > maxH)
                                maxH = temp;

                        }

                        Console.WriteLine("Max : " + maxH);
                        Console.ReadLine();
                        break;

                    case 14:

                        int xCount = 1;
                        int blank = 8;
                        for (int i = 0; i < 5; i++)
                        {
                            int tempXCount = xCount;
                            int tempBlank = blank;

                            for (int j = 0; j < 4; j++)
                            {
                                for (int k = 0; k < tempBlank; k++)
                                    Console.Write(" ");

                                for (int k = 0; k < tempXCount; k++)
                                    Console.Write("*");

                                tempXCount += 2;
                                tempBlank--;
                                Console.WriteLine();
                            }
                            xCount += 2;
                            blank--;
                        }

                        Console.ReadLine();
                        break;

                    case 15:
                        a = new int[,] {{0, 1, 2, 3},
                                       {-1, 0, 4, 5},
                                       {-2, -4, 0, 6},
                                       {-3, -5, -6, 0}};

                        bool isSkewSymmetric  = true;
                        if (a.GetLength(0) != a.GetLength(1))
                            isSkewSymmetric = false;
                        else
                        {
                            for (int i = 0; i < a.GetLength(0) && isSkewSymmetric; i++)
                            {
                                for (int j = 0; j < a.GetLength(1); j++)
                                {
                                    if (i == j && a[i, j] != 0)
                                    {
                                        isSkewSymmetric = false;
                                        break;
                                    }
                                    else if (i != j && a[i, j] + a[j, i] != 0)
                                    {
                                        isSkewSymmetric = false;
                                        break;
                                    }
                                }
                            }
                        }

                        Console.WriteLine(isSkewSymmetric);
                        Console.ReadLine();
                        break;

                    case 16:
                        //int n = 8;
                        //int sum = 0;
                        //for (int i = 0; i < 5; i++)
                        //{
                        //    sum -= n;
                        //}
                        //sum /= -1;
                        //Console.WriteLine(sum);

                        double numberToMultiply = 8;
                        double res = numberToMultiply / ((double)1 / 5);
                        Console.WriteLine(res);
                        Console.ReadLine();
                        break;

                    case 17:
                        blank1 = 1;
                        blank2 = 15;
                        int star1 = 7;
                        int star2 = 11;

                        Console.WriteLine("************************************");
                        for (int i = 0; i < 4; i++)
                        {
                            Console.Write("**");
                            for (int j = 0; j < blank1; j++)
                                Console.Write(" ");
                            for (int j = 0; j < star1; j++)
                                Console.Write("*");
                            for (int j = 0; j < blank2; j++)
                                Console.Write(" ");
                            for (int j = 0; j < star2; j++)
                                Console.Write("*");
                            Console.WriteLine();
                            blank1++;
                            star1 -= 2;
                            blank2 += 3;
                            star2 -= 2;
                        }

                        Console.WriteLine("**                               ***");

                        blank1 = 4;
                        blank2 = 24;
                        star1 = 1;
                        star2 = 5;

                        for (int i = 0; i < 4; i++)
                        {
                            Console.Write("**");
                            for (int j = 0; j < blank1; j++)
                                Console.Write(" ");
                            for (int j = 0; j < star1; j++)
                                Console.Write("*");
                            for (int j = 0; j < blank2; j++)
                                Console.Write(" ");
                            for (int j = 0; j < star2; j++)
                                Console.Write("*");
                            Console.WriteLine();
                            blank1--;
                            star1 += 2;
                            blank2 -= 3;
                            star2 += 2;
                        }
                        Console.WriteLine("************************************");
                        Console.ReadLine();
                        break;

                    case 18:
                        
                        a = new int[,] {{ 1,  0,  0,  2,  6,  -5 }, 
                                { 7, 11,  3,  0,  5,   4 },
                                { 0,  0,  8, -6,  4,   9 },
                                { 0,  0,  0,  1,  0,   0 }, 
                                { 5,  8,  0,  2,  0,   3 },
                                { 0,  1, 28,  3,  2,   0 }};
                        int x = 1;
                        int y = 5;
                        int temp_number = 0;

                        for (int i = 0; i < a.GetLength(0); i++)
                        {
                            temp_number = a[i, x];
                            a[i, x] = a[i, y];
                            a[i, y] = temp_number;
                        }

                        for (int i = 0; i < a.GetLength(0); i++)
                        {
                            for (int j = 0; j < a.GetLength(1); j++)
                            {
                                Console.Write(a[i, j] + "\t");
                            }
                            Console.WriteLine();
                        }
                        Console.ReadLine();
                        break;

                    case 19:
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
