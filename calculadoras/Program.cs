using System ;

namespace calculadora
{
    class Program
    {
        static void Main(string[] args )
        {
            
            Console.WriteLine("Ingrese dos numeros");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Seleccione la operacipn (1:suma, 2:resta, 3:producto,4:cociente)");
            int operacion = Convert.ToInt32(Console.ReadLine());
            double resultado = Convert.ToDouble(0);

                switch (operacion)
                {
                    case 1: resultado = num1 + num2;
                        break;
                    case 2: resultado = num1 - num2;
                        break;
                    case 3: resultado = num1 * num2;
                        break;
                    case 4: resultado = num1 / num2;
                        break;
                }
            Console.WriteLine("El resultado de la operacion es: " + resultado);
            Console.WriteLine("*************Resolucion de la segunda parte**************");
            Console.WriteLine("Ingrese un numero");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("El numero ingresado es: " + x);
            Console.WriteLine("Valor absoluto: " + Math.Abs(x));
            Console.WriteLine("Cuadrado: " + Math.Pow(x,2));
            Console.WriteLine("Raiz cuadrada: " + Math.Sqrt(x));
            Console.WriteLine("seno: " + Math.Sin(x));
            Console.WriteLine("coseno: " + Math.Cos(x));
            Console.WriteLine("Parte entera: " + Math.Ceiling(x));

            Console.WriteLine("insgrese un numero");
            double y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("El numero ingresado es: " + y);

            Console.WriteLine("El maximo entre:"+ x + "y" + y + "es:" + Math.Max(x,y));
            Console.WriteLine("El minimo entre:"+ x + "y" + y + "es:" + Math.Min(x,y));

            Console.ReadKey();
            
        }
    }
}