using System;
using System.Globalization;

namespace PrimeiroProjeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string produto1 = "computador";
            string produto2 = "mesa de escritório";
            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';
            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.234567;



            Console.WriteLine("produtos: ");
            Console.WriteLine($"{produto1}, cujo o preço é ${preco1:F2}");
            Console.WriteLine($"{produto2}, cujo o preço é ${preco2:F2}");
            Console.WriteLine("registro: ");
            Console.WriteLine($"{idade} anos de idade codigo {codigo} e genero: M");
            Console.WriteLine($"medida com oito casa decimais: {medida}");
            Console.WriteLine($"medida com oito casa decimais: {medida:F3}");
            Console.WriteLine($"medida com oito casa decimais: {medida.ToString("F3", CultureInfo.InvariantCulture)}"); 


        }
    }
}
