using System;

namespace ExemploOut
{
    public class ClassePai
    {
        public int Valor1 { get; set; }

        public ClassePai(int v1, out int v2)
        {
            Valor1 = v1;
            v2 = v1 * 2;
        }
    }

    public class ClasseFilha : ClassePai
    {
        public ClasseFilha(int v1) : base(v1, out _)
        {
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var teste = new ClasseFilha(10);
            Console.WriteLine($"Valor1 = {teste.Valor1}");


            var teste1 = new ClassePai(10, out var valorOut);
            Console.WriteLine($"Valor Out = {valorOut}");


            Console.ReadKey();
        }
    }
}
