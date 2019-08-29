using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DersCsharp1
{
    class Program
    {
        static void Main(string[] args)
         {

            ///soru 1
            
               int a, x, b;
               Console.WriteLine("PLEASE ENTER A VALUE FOR 'a':"); /// a için değer girer kullanıcı
               a = Convert.ToInt32(Console.ReadLine());   /// a okunur
               Console.WriteLine("PLEASE ENTER A VALUE FOR 'b' ");/// b için değer girer kullanıcı
               b = Convert.ToInt32(Console.ReadLine());  /// b okunur
               Console.WriteLine("PLEASE ENTER A VALUE FOR 'x'");/// x için değer girer kullanıcı
               x = Convert.ToInt32(Console.ReadLine()); /// x okunur

               double result = 2*(3 * Math.Pow(a,2)* Math.Pow(x,2) - 4 * a * b * x + 8 * Math.Pow(b,2)) * Math.Sqrt(a * x + b) / (15 * Math.Pow(a, 3));

               Console.WriteLine("RESULT : " + result);
               Console.ReadLine();
               
               

            ///soru2
          
            double surroundofsquare;
            Console.WriteLine("PLEASE ENTER LENGTH OF THE SQUARE FOR CULCULATING THE AREA OF THE BLACK SHAPE:"); ///karenin çevresi istenir
            surroundofsquare = Convert.ToInt32(Console.ReadLine());///karenin çevresi okunur
            double OneEdgeOfSquare = surroundofsquare / 4; ///kareninkenarıbulunur
            double QuadrantArea; 
            double TriangleAreaInQuadrant;
            QuadrantArea = (Math.PI / 4) * Math.Pow(OneEdgeOfSquare/2,2);///çeyrek daire dilim alanı hesaplanır
            TriangleAreaInQuadrant = ((OneEdgeOfSquare / 2) * (OneEdgeOfSquare / 2)) / 2;////ÇEYREKdaire dilimi içindeki üçgenin alanı hesaplanır

            double HalfAreaOfForOneLeaf = QuadrantArea - TriangleAreaInQuadrant;////çeyrekdaire diliminn alanından yola çıkılarak , bu daire dilim içindeki alan(üçgen) çıkartılır ve şekilde görülen """" siyah yapraklardan birinin alanının yarısı-->elde edilir """"
            double AllOfAreaBlackshape = HalfAreaOfForOneLeaf * 8; ///yukarıda elde edilen siyahyapraklardanbirininalanınınyarısı 8 ile çarpılırsa (4 yaprak var) tüm siyah alana ulaşırız

            Console.WriteLine("ALL OF AREA FOR BLACKSHAPE = "+AllOfAreaBlackshape);
          // Console.WriteLine(8*Math.PI-16);
            Console.ReadLine();
           
            
           
            ///soru 3 
            double distance;
            double decimalformat;
            int degree,second;
            Console.WriteLine("please enter geographical latitude information in decimal format : ");
            decimalformat = Convert.ToDouble(Console.ReadLine());

            degree = Convert.ToInt32(decimalformat*1); /// dereceyi yazarken virgülden kurtuluyoruz ve ona göre, mod ve bölme işlemlerini yapcaz  
             double  newdegree = degree / 100;     //// """DERECEMİZİN DEĞERİ : """ ELDE EDİLİR
            Console.WriteLine("degree= " + newdegree); 

         double  minute = degree % 100;///Dereceden kalanı mod kullanara   minute ulaşmak için bir değer elde edeceğiz
            double newminute = (minute * 6) / 10; /// minute üzerinde yapılan işlem
            double realminute = newminute; // newminute değeri realminute saklanıyor sonradan kullanmak için
            newminute = newminute * 10; /// virgüllü ifadeden kurtuluyoruz 
            
          int yenimunite = Convert.ToInt32(newminute); //newssecond336
          double bolummunite = yenimunite / 10;   ////YAZDIRILACAK OLAN """MINUTE DEĞERİ : """
            double kalanmunite = realminute - bolummunite; ///önceden tuttuğumuz realminuteden bolumminute çıkarılarak seconda ulaşmak için kullanacağımız sayı elde edilir
           second= Convert.ToInt32(kalanmunite * 60); /// second'u double yaptığımzda örn:36.00000001 gibi bi sayıdan kurtulup bu sayının 36 olarak sade bir şekilde verilmesini sağlıyoruz
         //  double kalansecond = newsecond % 10; ///6

            
            Console.WriteLine("minute = "  + bolummunite);
            Console.WriteLine("seconde = " + second);


            distance =Math.Round((newdegree * 111.32 )+ ( (bolummunite * 11.132) / 6 )+ ((second * 1.1132) / 36)); ////'math.Round' kütüphanesi yardımıyla sayı distance yuvarlanır
            Console.WriteLine("DISTANCE = " +  distance);
            Console.ReadLine();

            
           
            


            

           
            
            ///soru4 
        
            double ValueGreen, ValueRed, ValueBlue;
            Console.WriteLine("please enter a value for GREEN : ");
            ValueGreen = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("please enter a value for RED:  ");
            ValueRed = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("please enter a value for BLUE:");
            ValueBlue = Convert.ToDouble(Console.ReadLine());
            double Y, U, V;
            
            Y = (0.299*ValueRed) + (0.587 * ValueGreen) + (0.114 * ValueBlue);
            U = (0.492)*(ValueBlue - Y);
            V = (0.877)*(ValueRed - Y);
            Console.WriteLine("Y: " +  Y  + " U: " +  U  + " V: " + V );
            Console.ReadLine();

                     
           
           
          
            ////SORU 5 
            double valueofmeter;
            Console.WriteLine("FOR CONVERTING A VALUE IN METER : ");
            valueofmeter = Convert.ToDouble(Console.ReadLine());
            //1 meter 0.198838782 rods       //  1 meter =  236.220472 PİCA   // 1 meter =39370.0787 thou


            double rods = 1, pica = 1, thou = 1;
            double meter = 1; 
            meter = rods * 0.198838782;
            meter = pica* 236.220472;
            meter = thou  * (39370.0787 );

            Console.WriteLine("RODS : "+ valueofmeter* 0.198838782);
            Console.WriteLine("PICA : " + valueofmeter* 236.220472);
            Console.WriteLine("THOU : " + valueofmeter*39370.0787);
          
 
   

            ////SORU6
         
           
            int i = 65,k=75,n=78;

            Console.Write("{1}", k, (char)k); Console.Write("   "); Console.Write("{1}", k, (char)k); Console.Write(" "); Console.Write("             "); Console.Write("{1}", i, (char)i); Console.Write("  "); Console.Write("  "); Console.Write("        "); Console.Write("               "); Console.Write("{1}", i, (char)i); Console.Write("         "); Console.Write("   "); Console.Write("   ");  Console.Write("{1}", n, (char)n); Console.Write("       "); Console.Write("{1}", n, (char)n);
            Console.WriteLine();
            Console.Write("{1}", k, (char)k); Console.Write("  ");Console.Write("{1}", k, (char)k); Console.Write("  ");   Console.Write("          ");              Console.Write(" {1}", i, (char)i);     Console.Write("  ");    Console.Write(" {1}", i, (char)i);          Console.Write("   ");      Console.Write("                  ");              Console.Write(" {1}", i, (char)i);    Console.Write("   ");    Console.Write(" {1}", i, (char)i); Console.Write("             "); Console.Write("{1}", n, (char)n); Console.Write(" "); Console.Write("{1}", n, (char)n); Console.Write("     "); Console.Write("{1}", n, (char)n);
            Console.WriteLine();  
            Console.Write("{1}", k, (char)k); Console.Write(" "); Console.Write("{1}", k, (char)k); Console.Write("  ");     Console.Write("         ");        Console.Write(" {1}", i, (char)i);     Console.Write("  ");        Console.Write(" {1}", i, (char)i);     Console.Write("   ");   Console.Write(" {1}", i, (char)i);      Console.Write("         ");            Console.Write("      ");        Console.Write(" {1}", i, (char)i); Console.Write("    "); Console.Write(" {1}", i, (char)i); Console.Write("   ");     Console.Write(" {1}", i, (char)i); Console.Write("          "); Console.Write("{1}", n, (char)n); Console.Write("  "); Console.Write("{1}", n, (char)n); Console.Write("    "); Console.Write("{1}", n, (char)n); Console.Write("   "); 
            Console.WriteLine();
            Console.Write("{1}", k, (char)k); Console.Write(""); Console.Write("{1}", k, (char)k); Console.Write("    "); Console.Write("     ");             Console.Write(" {1}", i, (char)i);    Console.Write("  ");    Console.Write(" {1}", i, (char)i);    Console.Write("    ");    Console.Write(" {1}", i, (char)i);    Console.Write("   ");   Console.Write(" {1}", i, (char)i);   Console.Write("         ");     Console.Write(" {1}", i, (char)i);    Console.Write("    ");    Console.Write(" {1}", i, (char)i);    Console.Write("  ");    Console.Write(" {1}", i, (char)i);    Console.Write("    ");   Console.Write(" {1}", i, (char)i); Console.Write("        "); Console.Write("{1}", n, (char)n); Console.Write("   "); Console.Write("{1}", n, (char)n); Console.Write(" "); Console.Write("  "); Console.Write("{1}", n, (char)n);
            Console.WriteLine();   
            Console.Write("{1}", k, (char)k); Console.Write(" "); Console.Write("{1}", k, (char)k); Console.Write("   ");  Console.Write("  ");            Console.Write(" {1}", i, (char)i);     Console.Write("   "); Console.Write(" {1}", i, (char)i); Console.Write("  "); Console.Write(" {1}", i, (char)i);  Console.Write("  "); Console.Write(" {1}", i, (char)i); Console.Write("     ");  Console.Write(" {1}", i, (char)i); Console.Write("     "); Console.Write(" {1}", i, (char)i); Console.Write("  "); Console.Write(" {1}", i, (char)i); Console.Write("    "); Console.Write(" {1}", i, (char)i); Console.Write("   "); Console.Write(" {1}", i, (char)i); Console.Write("    "); Console.Write("{1}", i, (char)i); Console.Write("      "); Console.Write("{1}", n, (char)n); Console.Write("     "); Console.Write("{1}", n, (char)n); Console.Write(" "); Console.Write("{1}", n, (char)n);
            Console.WriteLine();
            Console.Write("{1}", k, (char)k); Console.Write("  "); Console.Write("{1}", k, (char)k); Console.Write("   "); Console.Write(""); Console.Write("{1}", i, (char)i); Console.Write("   "); Console.Write("{1}", i, (char)i); Console.Write("     "); Console.Write("{1}", i, (char)i); Console.Write("   "); Console.Write("{1}", i, (char)i); Console.Write("   "); Console.Write("{1}", i, (char)i); Console.Write("    "); Console.Write("{1}", i, (char)i); Console.Write(" "); Console.Write(" {1}", i, (char)i); Console.Write("    "); Console.Write(" {1}", i, (char)i); Console.Write("   "); Console.Write(" {1}", i, (char)i); Console.Write("    "); Console.Write("{1}", i, (char)i); Console.Write("    "); Console.Write("{1}", i, (char)i); Console.Write("    "); Console.Write("{1}", i, (char)i); Console.Write("   "); Console.Write("{1}", n, (char)n); Console.Write("       "); Console.Write("{1}", n, (char)n);
            Console.WriteLine();

   
           
    


            Console.ReadLine();

    
        }
    }
}
