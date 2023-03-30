using System;
using System.Globalization;

namespace FirstProgram 
{
    internal class Program {
        static void Main(string[] args) {
            double salario = 10.35784;
            int anos = 27;
            string z = "Patricia";
            char genero = 'F';

            Console.Write("Olá mundo!");
            Console.WriteLine("Bom dia!");
            Console.WriteLine("Até mais.");

            Console.WriteLine();
            Console.WriteLine(salario);
            Console.WriteLine(salario.ToString("F2"));
            Console.WriteLine(salario.ToString("F4"));
            Console.WriteLine(salario.ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine();
            Console.WriteLine("RESULTADO = " + salario);
            Console.WriteLine("O valor é de " + salario + " reais");
            Console.WriteLine("O valor é de " + salario.ToString("F2") + " reais");

            Console.WriteLine();
            Console.WriteLine("A paciente " + z + " tem " + anos + " anos e seu sexo é: " + genero);

            Console.ReadLine();
        }
    }
}