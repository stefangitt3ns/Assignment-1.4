using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Assignment 1.4"; 

            Console.WriteLine("Enter your first point (P1), Press enter after each point");
            double xAxisOne = Convert.ToDouble(Console.ReadLine());
            double yAxisOne = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter your second point (P2), Press enter after each point"); 
            double xAxisTwo = Convert.ToDouble(Console.ReadLine());
            double yAxisTwo = Convert.ToDouble(Console.ReadLine());

            Point p1 = new Point(xAxisOne, yAxisOne);
            Point p2 = new Point(xAxisTwo, yAxisTwo); 

            if (p1 == p2 )
            {
                Console.WriteLine("They are on the same plane"); 
            }
            else if (p1.x > p2.x)
            {
                Console.WriteLine("P1 is to the right of P2"); 
            }
            else
            {
                Console.WriteLine("P1 is to the left of P2"); 
            }

            Console.ReadKey();
        }    
        
    }

    public class Point
    {
        public Point (double xCoord, double yCoord)
        {
            x = xCoord;
            y = yCoord; 
        }

        public Point()
        {
            x = 0;
            y = 0;
        }

        public double x;
        public double y;
    }


}
