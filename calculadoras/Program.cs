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

            Console.ReadKey();
            
        }
    }
}