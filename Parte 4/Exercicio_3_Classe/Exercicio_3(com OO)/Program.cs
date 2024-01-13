using Exercicio_3_com_OO_;
using System;
using System.Globalization;

namespace Exercicio_3 {
    public class Program {
        static void Main(string[] args) {

            Triangulo x, y;
            x = new Triangulo();
            y = new Triangulo();

            Console.WriteLine("Digite o valor dos lados do tringulo X: ");
            x.A= (double)double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = (double)double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = (double)double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Digite o valor dos lados do tringulo Y: ");
            y.A = (double)double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = (double)double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = (double)double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double areaX = x.Area();

            double areaY = y.Area();

            Console.WriteLine($"Área de X = {areaX:F4}");
            Console.WriteLine($"Área de Y = {areaY:F4}");

            if (areaX > areaY) {
                Console.WriteLine("Maior área: X");
            }
            else if (areaX < areaY) {
                Console.WriteLine("Maior área: Y");
            }
            else {
                Console.WriteLine("As áreas são iguais.");
            }
        }
    }

}