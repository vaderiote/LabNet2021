using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1POO
{
   class Program
    {
        static void Main(string[] args)
        {
            List<Transporte> transportes = new List<Transporte>();

            Random rnd = new Random();

            for (int i = 1; i < 6; i++)
            {
                transportes.Add(new Avion(rnd.Next(1, 100), $"Avion{i}"));
                transportes.Add(new Auto(rnd.Next(1, 5), $"Autos{i}"));
            }
          

            foreach (var item in transportes)
            {
                Console.WriteLine(item.Avanzar());
                
                Console.WriteLine(item.Detenerse());

                Console.ReadLine();


            }
            
            
        }
    }
}
