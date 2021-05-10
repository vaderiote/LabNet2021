﻿using System.ComponentModel.DataAnnotations;

namespace LabNet.TP_EF.API.Models
{

    public class SwView
    {

         public string name { get; set; }
            public string height { get; set; }
            public string mass { get; set; }
            public string hair_color { get; set; }
            public string skin_color { get; set; }
            public string eye_color { get; set; }
            public string birth_year { get; set; }
            public string gender { get; set; }
            public string homeworld { get; set; }
            public string[] films { get; set; }
            public string[] species { get; set; }
            public object[] vehicles { get; set; }
            public object[] starships { get; set; }
            //public DateTime created { get; set; }
            //public DateTime edited { get; set; }
            public string url { get; set; }
        

    }

}