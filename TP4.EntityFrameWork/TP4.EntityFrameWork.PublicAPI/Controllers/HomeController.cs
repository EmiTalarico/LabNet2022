using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using TP4.EntityFrameWork.PublicAPI.Models;

namespace TP4.EntityFrameWork.PublicAPI.Controllers
{
    public class HomeController : Controller
    {
        public async Task<ActionResult> Index()
        {
            HPotterView hPotterView = new HPotterView();
            List<HPotterView> personajes = new List<HPotterView>();
            
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(hPotterView.UrlBase);
                client.DefaultRequestHeaders.Clear();
                
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage Res = await client.GetAsync(hPotterView.EndPoint);

                if (Res.IsSuccessStatusCode)
                {
                    var CharResponse = Res.Content.ReadAsStringAsync().Result;
                    personajes = JsonConvert.DeserializeObject<List<HPotterView>>(CharResponse);
                }
                return View(personajes);
            }
        }

    }
}
