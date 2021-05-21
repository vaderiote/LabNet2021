using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    public class ApiController : Controller
    {

        //GET: Api
        //    public ActionResult Index()
        //{
        //    return View();
        //}

        [Route("/api/")]
        [HttpGet]
        public async Task<ActionResult> Index()
            {
                var httpClient = new HttpClient();
                var json = await httpClient.GetStringAsync("https://digimon-api.vercel.app/api/digimon");
                List<ApiView> api = JsonConvert.DeserializeObject<List<ApiView>>(json);




            return View(api);


        }


    }
}