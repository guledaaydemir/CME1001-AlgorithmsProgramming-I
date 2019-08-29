using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication3
{
    class Program
    {
        struct RGB
        {
            public int R;
            public int G;
            public int B;
        }
        struct YUV
        {
            public double Y;
            public double U;
            public double V;
        }
        static YUV convert(RGB rgb)
        {
            YUV yuv;
            yuv.Y= 0.299 * rgb.R + 0.587 * rgb.G + 0.114 * rgb.B;
            yuv.U = -0.1687 * rgb.R - 0.3313* rgb.G + 0.5 * rgb.B + 128;
            yuv.V = 0.5 * rgb.R - 0.4187 * rgb.G - 0.0813 * rgb.B + 128;

            return yuv;
        }
        static void Main(string[] args)
        {
            int red = Convert.ToInt32(Console.ReadLine());
            int green = Convert.ToInt32(Console.ReadLine());
            int blue= Convert.ToInt32(Console.ReadLine());

            RGB renk;
            renk.R = red;
            renk.G = green;
            renk.B = blue;
            YUV renk_YUV=convert(renk);
            Console.WriteLine( renk_YUV.Y);
            Console.WriteLine( renk_YUV.U);
            Console.WriteLine( renk_YUV.V);
            Console.ReadLine();

        }
    }
}
