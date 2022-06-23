using ConsumeAPI.ResponseModels;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ConsumeAPI.Controllers
{
    public class HomeController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public HomeController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("http://localhost:40619/api/books");
            if(responseMessage.StatusCode == System.Net.HttpStatusCode.OK)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var result = JsonConvert.DeserializeObject<List<BookResponseModel>>(jsonData);
                ViewBag.ResponseMessage = "Success";
                return View(result);
            }
            else
            {
                return View(null);
            }
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(BookResponseModel model)
        {
            var client = _httpClientFactory.CreateClient();
            var jsonData=JsonConvert.SerializeObject(model);
            StringContent content = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage= await client.PostAsync("http://localhost:40619/api/books",content);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            else
            {
                TempData["errorMessage"] = $"There is an error. Error code: {(int)responseMessage.StatusCode}";
                return View(model);
            }

        }

       
    }
}
