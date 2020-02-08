using System;

namespace VerificaIdadeUsuario
{
    class Program
    {
        static void Main(string[] args)
        {
            int age;

            Console.Write("Informe sua idade: ");

            age = Convert.ToInt32(Console.ReadLine());

            if (age >= 18)
            {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.WriteLine("Acesso Permitido!");
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("Acesso Negado!");
            }
            Console.ReadKey();
        }
    }
}
