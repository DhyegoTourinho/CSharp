using System;

    namespace MembrosEstaticos {
        public class Program { 
            static void Main(string[] args) {
            Console.Write("Largura: ");
            Retangulo.Largura = double.Parse(Console.ReadLine());
            Console.Write("Altura: ");
            Retangulo.Altura = double.Parse(Console.ReadLine());
            Console.WriteLine("AREA: " + Retangulo.Area());
            Console.WriteLine("PERIMETRO: " + Retangulo.Perimetro());
            Console.WriteLine("DIAGONAL: " + Retangulo.Diagonal());

        }
    }
}