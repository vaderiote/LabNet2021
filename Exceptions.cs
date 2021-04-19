using System;

namespace TP2Exceptions
{
    public class Exceptions
    {
        


        public static void LogicEj3()
        {
            try
            {
                DateTime? fechaConValorNull = null;

                string fechaFormateada = fechaConValorNull.Value.ToString("MM/yy");
                Console.WriteLine("Esto esta mal");
            }

            catch(Exception ex)
            {
                throw new LogicEj3();
            }

        }

        public static void DivisionNumeros(int? i, int j)
        {
            try
            {

                int res = i.Value / j;
                Console.WriteLine($"El resultado es {res}" );

            }

            catch (DivideByZeroException)
            {
                Console.WriteLine("No se puede dividir por cero pa!");
            }

            catch (InvalidOperationException)
            {
                Console.WriteLine("El valor ingresado es nulo");
            }

            finally
            {
                Console.WriteLine("Termino la operacion");
            }

        }

        
        public static void IngresoNumeros(int a, int b, int resultado)
        {
            try
            {
               
                Console.WriteLine("Ingrese un numero (Dividendo)");

                a = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese otro numero (Divisor)");

                b = int.Parse(Console.ReadLine());

                
                resultado = a / b;

                Console.WriteLine($"El resultado es {resultado}" );

            }


            catch (DivideByZeroException)
            {
                Console.WriteLine("¡NO PASARAS!!!...con ese cero");
            
            }



        }

    }

}    

    




    

    
    



