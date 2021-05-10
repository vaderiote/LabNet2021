using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;

namespace LabNet.TP_EF.API.Controllers
{
    public class ApiController : Controller
    {
        

        //GET: Api
        public ActionResult Index()
        {
            return View();
        }

        public async System.Threading.Tasks.Task<ActionResult> ApiviewAsync()
        {
            string html = "https://swapi.dev/api/people/3/";
            HttpClient cliente = new HttpClient();
            var webConstains = await cliente.GetStringAsync(html);
            var lista = JsonConvert.DeserializeObject<List<IView>>(webConstains);

            return View(lista);

                 
        }
       
        
    }
}
