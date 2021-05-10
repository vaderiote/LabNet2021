using LabNet.TP_EF.Data;
using LabNet.TP_EF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNet.TP_EF.Logic
{
    public class ProductsLogic : BaseLogic
    {

            public void Add(Products newProduct) 
            {
                context.Products.Add(newProduct);
                context.SaveChanges();
            }
            
             public void Delete (int id) 
            {
            var productoAEliminar = context.Products.Find(id);
                context.Products.Remove(productoAEliminar);
                context.SaveChanges();
            
            }

            public void Update (Products product) 
            {
                var productUpdate = context.Products.Find(product.ProductID);
                productUpdate.ProductName = product.ProductName;
                context.SaveChanges();
            }

            public List<Products> GetAll()
            {
                return context.Products.ToList();
            }
    }
}