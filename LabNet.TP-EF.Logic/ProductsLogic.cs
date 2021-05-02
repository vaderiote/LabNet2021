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
        
            public List<Products> GetAll()
            {
                return context.Products.ToList();
            }
        }
    }