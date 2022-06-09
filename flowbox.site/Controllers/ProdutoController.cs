using flowbox.shared.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace flowbox.site.Controllers
{
    public class ProdutoController : Controller
    {
        public async Task<IActionResult> Index()
        {
            HttpResponseMessage httpResponseMessage = new HttpResponseMessage();
            string produtos;

            using(var httpclient = new HttpClient())
            {
                httpResponseMessage = await httpclient.GetAsync("https://localhost:44317/api/produto");
                produtos = await httpResponseMessage.Content.ReadAsStringAsync();
            }


            return View(JsonConvert.DeserializeObject<List<Produto>>(produtos));
        }
        public async Task<IActionResult> Post()
        {
            return View(new Produto());
        }
        public async Task<IActionResult> PostEditar(Produto produto)
        {
            using (var httpclient = new HttpClient())
            {
                var json = JsonConvert.SerializeObject(produto);
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                var httpResponseMessage = await httpclient.PostAsync("https://localhost:44317/api/produto", content);
            }

            return RedirectToAction("Index", "Produto");
        }
    }
}
