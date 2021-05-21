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
    public class CategoriesController : Controller
    {
        CategoriesLogic logic = new CategoriesLogic();
        // GET: Categories
        public ActionResult Index()
        {
            var Logic = new CategoriesLogic();
            List<LabNet.TP_EF.Entities.Category> categories = logic.GetAll();

            List<CategoriesView> categoriesView = categories.Select(c => new CategoriesView
            {
                Id = c.CategoryID,
                Description = c.CategoryName
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



        public ActionResult Update()
        {
            return View();
        }
        
        [HttpPost]
        public ActionResult Update(CategoriesUpdateView categoriesUpdateView)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    Category categoryEntity = new Category
                    {

                        CategoryID = categoriesUpdateView.Id,
                        CategoryName = categoriesUpdateView.CategoryName,
                        Description = categoriesUpdateView.Description


                    };
                    logic.Update(categoryEntity);
                    return RedirectToAction("Index");
                }

            }

            catch (Exception)
            {
                return RedirectToAction("Index", "Error");

            }
            return RedirectToAction("Index");

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