using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;
using System.Threading.Tasks;
using LabNet.TP_EF.API.Models;

namespace LabNet.TP_EF.API.Controllers
{
    public class ApiController : Controller
    {



        //GET: Api
        //public ActionResult Index()
        //{
        //    return View();
        //}



        public async System.Threading.Tasks.Task<ActionResult> Index()
        {
            var httpClient = new HttpClient();
            var json = await httpClient.GetStringAsync("https://digimon-api.vercel.app/api/digimon");
            List<Root> rootList = JsonConvert.DeserializeObject<List<Root>>(json);


            return View(rootList);

                 
        }
       
        
    }
}
