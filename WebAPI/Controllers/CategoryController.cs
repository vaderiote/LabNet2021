using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using LabNet.TP_EF.Data;
using LabNet.TP_EF.Entities;
using LabNet.TP_EF.Logic;
using LabNet.TP_MVC.Models;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    public class CategoryController : Controller
    {
        CategoriesLogic logic = new CategoriesLogic();
        // GET: Category
        [HttpGet]
        public ActionResult Index()
        {
            var Logic = new CategoriesLogic();
            List<LabNet.TP_EF.Entities.Category> category = Logic.GetAll();
            
            List<Categoriesview> categoriesView = category.Select(c => new Categoriesview
            {   
                
                name = c.CategoryName,
                Description = c.Description,
                Id = c.CategoryID
            }).ToList();
            return View(categoriesView);
        }

        public ActionResult Insert()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Insert(CategoriesView categoriesView)
        {
            try
            {
                Category categoryEntity = new Category { CategoryName = categoriesView.Description };

                logic.Add(categoryEntity);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {

                return RedirectToAction("Index", "Error");

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

                return RedirectToAction("Index", "Error");
            }

        }
    }
}