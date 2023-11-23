using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShapeAreaLib;

namespace ConAppRealAlgebra
{
    internal class Program
    {
         static void Main(string[] args)
        {
            Console.WriteLine("Choose the appropiate options for desired result 1.Reactangle 2.Square 3.Circle 4.Triangle");
            int choice = int.Parse(Console.ReadLine());
          
            
            switch (choice)
            {
                case 1:
                    {
                        Console.WriteLine("Enter Lenght of rectangle");
                        int length = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter Breadth of reactangle");
                        int breadth = int.Parse(Console.ReadLine());
                        int result = ShapeAreaLib.Rectangle.Area(length, breadth);
                        Console.WriteLine(result);
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Enter length of any sides");
                        int length = int.Parse(Console.ReadLine());
                       
                        int result = ShapeAreaLib.Square.Area(length);
                        Console.WriteLine(result);
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Enter radius  of circle");
                        int radius = int.Parse(Console.ReadLine());

                        double result = ShapeAreaLib.Circle.Area(radius);
                        Console.WriteLine(result);

                        break;
                    }
                case 4:
                    {

                        Console.WriteLine("Enter base of traingle");
                        int basee= int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter the height traingle");
                        int height = int.Parse(Console.ReadLine());

                        int result = ShapeAreaLib.Triangle.Area(basee,height);
                        Console.WriteLine(result);
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Choose wrong options");
                        break;
                    }
            }
            Console.ReadKey();
        }
    }
}
