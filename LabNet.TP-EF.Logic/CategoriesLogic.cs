using LabNet.TP_EF.Entities;
using LabNet.TP_EF.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNet.TP_EF.Logic
{
    public class CategoriesLogic : BaseLogic, IABMLogic<Category>
    {
        public void Add(Category newCategory)
        {
            context.Categories.Add(newCategory);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            var categoryAEliminar = context.Categories.Find(id);
            context.Categories.Remove(categoryAEliminar);
            context.SaveChanges();

        }
     

        
        public List<Category> GetAll()
        {
            return context.Categories.ToList();
        }

        public void Update(Category category)
        {
            var categoryUpdate = context.Categories.Find(category.CategoryID);
            categoryUpdate.Description = category.Description;
            context.SaveChanges();
        }
    }
}
