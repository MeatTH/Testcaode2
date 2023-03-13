using System;

namespace challenges{
    class Program{
        static void Main(string[] args)
        {
            double x1 =double.Parse(Console.ReadLine()); 
            double y1 = double.Parse(Console.ReadLine());
            double w1 = double.Parse(Console.ReadLine());
            double h1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double w2 = double.Parse(Console.ReadLine());
            double h2 = double.Parse(Console.ReadLine());
            double i = Math.Abs(x1-x2);
            double j = Math.Abs(y1-y2);
            double k = w1+w2;
            double h = h1+h2;

            if ( k > i)
            {
                double a = k - i;  
                if ( h > j)
                {
                    double b = h - j;
                    double c = a * b;
                    if ( c > 8){
                        Console.WriteLine("Too Much Overlapping");
                    }
                    else{Console.WriteLine("Not Much Overlapping");}
                }
                else{Console.WriteLine("Not Much Overlapping");}
            }
            else {
                Console.WriteLine("No Overlapping");
            }

        }
    }
}    