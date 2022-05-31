using System ;

namespace cadenas
{
    class Program
    {
        static void Main(string[] args )
        {
            /*
            Console.WriteLine("Ingrese una cadena de caracteres");
            string cadena = Console.ReadLine();
            Console.WriteLine("Ingrese una cadena de caracteres");
            string cadena2 = Console.ReadLine();
            Console.WriteLine("Caracteres del 1 al 3 : " + cadena.Substring(1, 3));
            Console.WriteLine("Longitud de la cadena"+ cadena + "es : " + cadena.Length);
            // otra forma 
            Console.WriteLine(string.Format("La frase {0} tiene {1} letras",
                              cadena, cadena.Length));

            Console.WriteLine(" Cadenas concatenadas :" + String.Concat(cadena,cadena2));
            Console.WriteLine(" subcadena extraida :" + cadena.Substring(2,5));


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
                       
            Console.WriteLine("El resultado de operar " + num1 + " y " + num2 + " es "+ Convert.ToString(resultado));        
            
            Console.WriteLine("Cadena leida con foreach");
             foreach(char letra in cadena){

                   Console.Write(letra);   
              }

              int cant = cadena.Count(f => f == 'e');
              Console.WriteLine("La ocurrencia de la letra e es: " + cant  );

              Console.WriteLine("En minusculas " + cadena.ToLower());
              Console.WriteLine("En mayusculas " + cadena.ToUpper());
              Console.WriteLine("Comparacion: " + String.Compare(cadena,cadena2));
                */


            Console.WriteLine("**************usando Split*****************");

            string cadS = "Esta cadena,es un ejemplo.Probando Split";
            string[] trozos = cadS.Split(' ',',','.');

            foreach (var a in trozos)
            {
                Console.WriteLine($"<{a}>");
            }
              
             

            Console.WriteLine("********** Ingrese suma sencilla ***********");
            string cad = Console.ReadLine();

              string[] numeros = cad.Split('+');

              Console.WriteLine("La suma de " + cad + "es:  " + (Convert.ToInt16(numeros[0]) + Convert.ToInt16(numeros[1])));
            
        }
    }
}