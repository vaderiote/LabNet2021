using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LabNet.TP_EF.Logic;
using LabNet.TP_EF.Entities;



namespace LabNet.TP_EF.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Consulta de entidad 'PRODUCTS' - (Nombre de producto y precio por unidad) */

            ProductsLogic productsLogic = new ProductsLogic();

            foreach (var product in productsLogic.GetAll())
            {
                Console.WriteLine($"{product.ProductName} - {product.UnitPrice}");
            }

            Console.ReadLine();

            Console.WriteLine();



            ///*Consulta de entidad 'TERRITORIES' - (Nombre de categoria y Descripcion)*/

            TerritoriesLogic territoriesLogic = new TerritoriesLogic();

            foreach (var territory in territoriesLogic.GetAll())
            {
                Console.WriteLine($"{territory.RegionID} - {territory.TerritoryDescription}");
            }

            Console.WriteLine();

            Console.ReadLine();


            /*Consulta de entidad 'CATEGORIES' - (Nombre de categoria e ID de categoria)*/

            CategoriesLogic categoriesLogic = new CategoriesLogic();

            foreach (var cat in categoriesLogic.GetAll())
            {
                Console.WriteLine($"{cat.CategoryID} - {cat.Description}");
            }

            Console.ReadLine();
            
            Console.WriteLine();

            /*INSERT - Entidad 'CATEGORIES'. */

            categoriesLogic.Add(new Category
            {
                //CategoryID = 10,
                Description = "COMIDA ASIATICA - RAMEN, SUSHI, Kebsang CHEYUK",
                CategoryName = "ASIATICA"

            });

            foreach (var cat in categoriesLogic.GetAll())
            {
                Console.WriteLine($"{cat.CategoryID} - {cat.Description}");
            }

            Console.ReadLine();

            Console.WriteLine();

            /*DELETE - Entidad 'CATEGORIES'. */

            categoriesLogic.Delete(9);

            foreach (var cat in categoriesLogic.GetAll())
            {
                Console.WriteLine($"{cat.CategoryID} - {cat.Description}");
            }

            Console.ReadLine();

            Console.WriteLine();

            ///*UPDATE - Entidad 'CATEGORIES'. */

            categoriesLogic.Update(new Category
            {
                CategoryID = 10,
                CategoryName = "COMIDA PERUANA",
                Description = "LOMO SALTEADO, SALCHIPAPA, TORTA TRES LECHES..."


            });

            foreach (var cat in categoriesLogic.GetAll())
            {
                Console.WriteLine($"{cat.CategoryID} - {cat.Description}");
            }

            Console.ReadLine();

            Console.WriteLine();


        }
    }
}
