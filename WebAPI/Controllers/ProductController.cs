using LabNet.TP_EF.Entities;
using LabNet.TP_EF.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

using ProductsView = WebAPI.Models.ProductsView;

namespace WebAPI.Controllers
{
    public class ProductController : Controller
    {

        ProductsLogic logic = new ProductsLogic();
        // GET: Products
        [HttpGet]
        [Route("/Product")]
      
        public ActionResult Index()
        {
            var Logic = new ProductsLogic();
            List<LabNet.TP_EF.Entities.Products> products = logic.GetAll();


            List<ProductsView> productsView = products.Select(p => new ProductsView
            {
                Id = p.ProductID,
                ProductName = p.ProductName
                
            }).ToList();
            return View(productsView);
        }


        public ActionResult Insert()
        {
            return View();
        }

        [Route("Product/Insert")]
        [HttpPost]
      
        public ActionResult Insert (ProductsView productsView)
        {
            try
            {
                Products productEntity = new Products
                {
                    ProductName = productsView.ProductName

                };

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