using LabNet.TP_EF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebAPI.Controllers;

namespace WebAPI.Models
{
    public class Categoriesview : CategoryController

    {
        public string name { get; set; }
        public string Description { get; set; }
        public int Id { get; set; }
    }
}