using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Maasin.WEB.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RestSharp;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Maasin.WEB.Controllers
{
    public class HomeController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            var client = new RestClient("http://localhost:17146/api/homepage");
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            IRestResponse response = client.Execute(request);
            if (response.IsSuccessful)
            {
                var result = JsonConvert.DeserializeObject<ApiResponse>(response.Content);
                if (result != null)
                {
                    var branches = JsonConvert.DeserializeObject<List<Branch>>(result.Set.ToString());
                    //todo: Burada gelen branchleri sayfada bir ul listesi (ya da select) içerisinde gösterin. 
                }
                
            }
            return View();
        }
    }
}
