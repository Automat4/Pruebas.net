using System;

namespace Pruebas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var result = Prueba(8);
            Console.WriteLine(result);
        }

        public static int Prueba(int num)
        {
            if (num > 1)
                return 2;
            else return 0;
        }
    }

}
