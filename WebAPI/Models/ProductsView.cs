using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebAPI.Controllers;

namespace WebAPI.Models
{
    public class ProductsView : ProductController
    {
        public string CategoryName { get; set; }
        
        public string ProductName { get; set; }
        
        public int SupplierID { get; set; }
        
        public int QuantityPerUnit { get; set; }
        
        public short UnitPrice { get; set; }
        
        public int UnitsInStock { get; set; }
        
        public int UnitsOnOrder { get; set; }

        public int Id { get; internal set; }
    }
}