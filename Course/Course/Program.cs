using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            bool completo = false;
            
            char letra = 'a';
            byte n1 = 255;
            int n2 = 12312;
            int n3 = 12356778;
            int n4 = 1231;
            float n5 = 2.3f;
            double n6 = 4.6;
            SByte x = 100;

            char genero = 'M';
            int idade = 28;
            double saldo = 10.3578;
            string nome = "Diego";

            Console.WriteLine(genero);
            Console.WriteLine(idade);
            Console.WriteLine(saldo);
            Console.WriteLine(nome);

            Console.WriteLine("------------------------");

            Console.WriteLine(saldo.ToString("F2"));
            Console.WriteLine(saldo.ToString("F4"));
            Console.WriteLine(saldo.ToString("F4", CultureInfo.InvariantCulture)); //Formatação para ponto

            Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2:F2} reais", nome, idade, saldo);
            Console.WriteLine($"{nome} tem {idade} anos e tem saldo igual a {saldo:F2} reais");
            Console.WriteLine(nome + " tem " + idade + " anos e tem saldo igual a " + saldo .ToString("F2", CultureInfo.InvariantCulture)  + " reais");


            Console.WriteLine("------------------------");

            Console.WriteLine(completo);            
            Console.WriteLine(letra);
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);
            Console.WriteLine(n5);
            Console.WriteLine(n6);
            Console.WriteLine(x);
           
        }
    }
}
