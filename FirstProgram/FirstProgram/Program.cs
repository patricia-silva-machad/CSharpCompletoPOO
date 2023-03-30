using System;
using System.Globalization;

namespace FirstProgram 
{
    internal class Program {
        static void Main(string[] args) {

            //int idade = 27;
            //double saldo = 10.35467;
            //string nome = "Patricia";
            //tecnica do placeholder
            //Console.WriteLine("{0} tem {1} anos e recebe {2:F3} por mês!", nome, idade, saldo);

            //tecnica da interpolação
            //Console.WriteLine($"{nome} tem {idade} anos e recebe {saldo:F3} por mês!!");

            //tecnica de concatenação 
            //Console.WriteLine(nome + "tem " + idade + " anos e recebe " + saldo.ToString("F3") + " por mês!!");

            double saldo = 10.35784;
            int idade = 27;
            string z = "Patricia";
            char genero = 'F';

            Console.Write("Olá mundo!");
            Console.WriteLine("Bom dia!");
            Console.WriteLine("Até mais.");

            Console.WriteLine();
            Console.WriteLine(saldo);
            Console.WriteLine(saldo.ToString("F2"));
            Console.WriteLine(saldo.ToString("F4"));
            Console.WriteLine(saldo.ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine();
            Console.WriteLine("RESULTADO = " + saldo);
            Console.WriteLine("O valor é de " + saldo + " reais");
            Console.WriteLine("O valor é de " + saldo.ToString("F2") + " reais");

            Console.WriteLine();
            Console.WriteLine( z + " tem " + idade + " anos e seu sexo é: " + genero);

            Console.ReadLine();
        }
    }
}