using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2Exceptions
{
    class Program
    {
        

        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenidos al TP2");

            //1. Metodo con la excepcion 'DivideByZeroException'
            Exceptions.DivisionNumeros(null, 1);

            //2. Metodo con las excepciones 
            try
            {
                Exceptions.IngresoNumeros(0, 0, 0);
            }
            catch (FormatException)
            {
                Console.WriteLine("Ingresaste una letra");
            }

            //3. - 4.Ejercicio 3 y 4 con sobrecarga de mensaje
            try
            {
                Exceptions.LogicEj3();
                
            }
            catch (LogicEj3 ex)
            {
               
                Console.WriteLine($"Esta es mi customizada:'{ex.Message}'");
            }

            Console.WriteLine("Gracias por utilizar nuestro Software!!");
        }
    }
}
