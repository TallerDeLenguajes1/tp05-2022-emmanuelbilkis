using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class NewBaseType
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escriba el numero de cifras del numero : \n");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] numeroInvertido = new int [n];
            Console.WriteLine("Escriba el nuemero que desea invertir\n");
            int num = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                numeroInvertido[i] = num%10;
                num = num / 10;
            }

            Console.WriteLine("Numero invertido: \n");

            for (int i = 0; i < n; i++)
            {
                Console.Write(numeroInvertido[i]);
            }
        }
    }

}


