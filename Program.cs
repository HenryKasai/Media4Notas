using System;

namespace Media4Notas
{
    class Program
    {
        static void Main(string[] args)
        {   
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Insira as 4 notas que serão avaliadas.");
            Console.Write("Nota 1: ");
            decimal  nota1 = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Nota 2: ");
            decimal  nota2 = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Nota 3: ");
            decimal  nota3 = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Nota 4: ");
            decimal  nota4 = Convert.ToDecimal(Console.ReadLine());
            Console.Clear();
            if(nota1 <= 10 && nota2 <= 10 && nota3 <= 10 && nota4 <= 10 && nota1 >= 0 && nota2 >= 0 && nota3 >= 0 && nota4 >= 0)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                decimal resultado = (nota1 + nota2 + nota3 + nota4) / 4;
                Console.WriteLine($"Nota 1: {nota1:N1}"); 
                Console.WriteLine($"Nota 2: {nota2:N1}");                  
                Console.WriteLine($"Nota 3: {nota3:N1}");                  
                Console.WriteLine($"Nota 4: {nota4:N1}");  

                if (resultado < 5)
                {                   
                    Console.WriteLine($"Você ficou com média {resultado:N1}. Reprovado.");
                }
                else if (resultado >= 5 && resultado <= 6)
                {
                    Console.WriteLine($"Você ficou com média {resultado:N1}. Em recuperação.");
                }
                else if (resultado > 6)
                {
                    Console.WriteLine($"Você ficou com média {resultado:N1}. Aprovado.");
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Digite somente notas entre 0 e 10.");
            }
            Console.ResetColor();








        }
    }
}
