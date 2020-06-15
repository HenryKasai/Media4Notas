using System;

namespace Media4Notas
{
    class Program
    {
        static void Main(string[] args)
        {   
            decimal nota1, nota2, nota3, nota4;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Insira as 4 notas que serão avaliadas.");
            Console.Write("Nota 1: ");
            bool nota1bool = Decimal.TryParse(Console.ReadLine(), out nota1);
            Console.Write("Nota 2: ");
            bool nota2bool = Decimal.TryParse(Console.ReadLine(), out nota2);
            Console.Write("Nota 3: ");
            bool nota3bool = Decimal.TryParse(Console.ReadLine(), out nota3);
            Console.Write("Nota 4: ");
            bool nota4bool = Decimal.TryParse(Console.ReadLine(), out nota4);
            Console.Clear();
            if (!(nota1bool && nota2bool && nota3bool && nota4bool) 
            || nota1 > 10 || nota2 > 10 || nota3 > 10 || nota4 > 10 
            || nota1 < 0 || nota2 < 0 || nota3 < 0 || nota4 < 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Valor inválido.");
                Console.ForegroundColor = ConsoleColor.Gray;    
                Environment.Exit(-1);    
            }
            else
            {
                decimal resultado = (nota1 + nota2 + nota3 + nota4) / 4;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Nota 1 = {nota1}");
                Console.WriteLine($"Nota 2 = {nota2}");
                Console.WriteLine($"Nota 3 = {nota3}");
                Console.WriteLine($"Nota 4 = {nota4}");
                if (resultado < 5)
                {
                    Console.WriteLine($"Você ficou com média {resultado}, reprovado.");
                }
                else if (resultado >= 5 && resultado <= 6)
                {
                    Console.WriteLine($"Você ficou com média {resultado}, em recuperação.");
                }
                else if (resultado > 6)
                {
                    Console.WriteLine($"Você ficou com média {resultado}, aprovado.");
                }
            }   
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.ReadKey();    
 
            










        }
    }
}
