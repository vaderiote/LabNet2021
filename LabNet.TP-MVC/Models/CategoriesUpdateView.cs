using System.ComponentModel.DataAnnotations;

namespace LabNet.TP_MVC.Models
{
    public class CategoriesUpdateView
    {
        
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set;  }
        

    }
}