using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebAPI.Models
{
    public class ApiView
    {
        public string name { get; set; }
    
        public string Img { get; set; }
        public string level { get; set; }
    }
}