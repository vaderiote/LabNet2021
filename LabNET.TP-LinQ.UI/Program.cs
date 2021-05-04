using LabNET.TP_LinQ.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNET.TP_LinQ.UI
{
    class Program
    {
        private static object products;

        static void Main(string[] args)
        {

            var db = new Model1();

            db.Database.Log = Console.WriteLine;



            /*1. Query para devolver objeto customer. */

            var query = from customer in db.Customers

                        select customer;



            foreach (var item in query)
            {
                Console.WriteLine(item.ContactName);
            }

            Console.ReadLine();



            /*2. Query para devolver todos los productos sin stock. */

            var query2 = from product in db.Products
                         where product.UnitsInStock == 0
                         select product;

            foreach (var item in query2)
            {
                Console.WriteLine($"{item.ProductName} - STOCK = {item.UnitsInStock}");
            }

            Console.ReadLine();

            /*3. Query para devolver todos los 
              productos que tienen stock y 
              que cuestan más de 3 por unidad. */

            var query3 = from product in db.Products
                         where product.UnitPrice > 3 & product.UnitsInStock != 0
                         select product;

            foreach (var item in query3)
            {
                Console.WriteLine($"{item.ProductName} - {item.UnitPrice}");
            }

            Console.ReadLine();

            /*4. Query para devolver todos los customers de Washington*/

            var query4 = from customer in db.Customers
                         where customer.Region == "WA"
                         select customer;

            foreach (var item in query4)
            {
                Console.WriteLine($"{item.ContactName} - {item.Region}");
            }

            Console.ReadLine();

            /*5. Query para devolver el primer elemento 
            o nulo de una lista de productos donde el ID de
            producto sea igual a 789. */




            var query5 = (from product in db.Products
                          where product.ProductID == 789
                          select product).FirstOrDefault();

            List<Products> p = new List<Products>();
            Products prod = new Products();
            prod = query5;
            p.Add(prod);




            foreach (var item in p)
            {
                Console.WriteLine($"{prod.ProductName} - {prod.ProductID}");
            }



            Console.ReadLine();

            /*6. Query para devolver los nombres de los Customers. 
              Mostrarlos en Mayuscula y en Minuscula.*/

            var query6 = from customer in db.Customers
                         select customer;


            foreach (var item in query6)
            {
                string toformat = item.ContactName;
                string upper = toformat.ToUpper();
                string lower = toformat.ToLower();


                Console.WriteLine($"{upper} - {lower}");


            }
            Console.ReadLine();


            /*7. Query para devolver Join entre Customers y 
            Orders donde los customers sean de
            Washington y la fecha de orden sea mayor a 1/1/1997. */

            DateTime fecha = Convert.ToDateTime("01/01/1997");

            var query7 = from order in db.Orders
                         join customer in db.Customers
                         on order.CustomerID equals customer.CustomerID
                         where customer.Region == "WA"
                         && order.OrderDate > fecha
                         select order;

            foreach (var item in query7)
            {
                Console.WriteLine($"{item.OrderID} - {item.OrderDate} - {item.CustomerID}");
            }


            Console.ReadLine();
        }



    }
}

