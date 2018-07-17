using System;

namespace ExemploSobrecargaIn
{
    class Program
    {
        private static void TesteSobrecarga(int valor)
        {
            Console.WriteLine($"Sem o modificador in: {valor}");
        }

        // in = readonly variable
        private static void TesteSobrecarga(in int valor)
        {
            Console.WriteLine($"Com o modificador in: {valor}");
        }

        static void Main(string[] args)
        {
            TesteSobrecarga(5);

            int valorTeste = 10;
            TesteSobrecarga(in valorTeste);

            Console.ReadKey();
        }
    }
}
