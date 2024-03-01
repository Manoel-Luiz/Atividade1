using System;

 
namespace atividade1
{
    class Program
    {
        static void Main(string[] args)
            
        {
            
            double resultado, resultado2, resultado3;

            Console.WriteLine("informe a largura do retangulo: ");
            double lado1 = double.Parse(Console.ReadLine());
            Console.WriteLine("informe a altura do retangulo: ");
            double lado2 = double.Parse(Console.ReadLine());

            resultado = calculaArea(lado1, lado2);
            resultado2 = calculaPerimetro(lado1, lado2);
            resultado3 = calculaDiagonal(lado1, lado2);
            Console.WriteLine($"a area do retangulo é: {resultado}");
            Console.WriteLine($"o valor do perimetro é: {resultado2}");
            Console.WriteLine($"o valor da diagonal é: {resultado3}");
            



        }
        public  static double calculaPerimetro( double lado1, double lado2)
        {
            double resultado = 2*(lado1 + lado2);
            return resultado;
        }
        public static double calculaDiagonal (double lado1, double lado2)
        {
            double resultado = Math.Sqrt(Math.Pow(lado1, 2)) + Math.Sqrt(Math.Pow(lado2, 2));
            return resultado;
        }
        public static double calculaArea(double lado1, double lado2)
        {
            double resultado = lado1 * lado2;
            return resultado;
        }
    }
}
