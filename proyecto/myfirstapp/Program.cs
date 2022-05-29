using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class NewBaseType
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escriba el numero de cifras del numero : \n");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Escriba el nuemero que desea invertir\n");
            int num = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(num % 10);
                num = num / 10;
            }
        }
    }

}


