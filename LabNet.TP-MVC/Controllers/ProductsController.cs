using LabNet.TP_EF.Entities;
using LabNet.TP_EF.Logic;
using LabNet.TP_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LabNet.TP_MVC.Controllers

{


    public class ProductsController : Controller
    {

        ProductsLogic logic = new ProductsLogic();
        // GET: Products
        public ActionResult Index()
        {
            var Logic = new ProductsLogic();
            List<TP_EF.Entities.Products> products = logic.GetAll();


            List<ProductsView> productsView = products.Select(p => new ProductsView
            {
                Id = p.ProductID,
                Description = p.ProductName,
            }).ToList();


            return View(productsView);
        }



        public ActionResult Insert()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Insert(ProductsView productsView)
        {
            try
            {
                Products productEntity = new Products { ProductName = productsView.Description };

                logic.Add(productEntity);

                return RedirectToAction("Index");

            }
            catch (Exception ex)
            {

                return RedirectToAction("View", "Error");

            }
        }

      
        public ActionResult Delete(int id)
        {
            try
            {
                logic.Delete(id);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {

                return RedirectToAction("Index", "Error"); ;
            }
            
        }
    }
    
}