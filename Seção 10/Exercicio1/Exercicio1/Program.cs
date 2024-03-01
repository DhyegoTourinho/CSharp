using System;
using System.Globalization;
using System.Transactions;
using Exercicio1.Entities;
using Exercicio1.Entities.Enums;

namespace Exercicio1
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Shape> Shapes = new List<Shape>();
            Console.Write("Enter the number of shapes: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Shape #{i} data: ");
                Console.Write("Rectangle or Circle (r/c)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Color (Black/Blue/Red): ");
                Color color = Enum.Parse<Color> (Console.ReadLine());
                
                if (ch == 'r')
                {
                    Console.Write("Width: ");
                    double width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Height: ");
                    double height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Shapes.Add(new Rectangle(width, height, color));
                }
                else
                {
                    Console.Write("Radius: ");
                    double radius = double.Parse (Console.ReadLine(), CultureInfo.InvariantCulture);
                    Shapes.Add(new Circle (radius, color));
                }
            }

            Console.WriteLine();
            Console.WriteLine("SHAPE AREAS: ");
            foreach(Shape x in Shapes)
            {
                Console.WriteLine(x.Area().ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}