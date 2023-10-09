using ClienteRazor.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace ClienteRazor.Controllers
{
    public class EnviosController : Controller
    {
        //Endpoints - extraemos url de SolServicioWebApi
        string strURL = "https://localhost:44310/api/Shippers";
        //Creamos instancia de la clase HttpClient
        HttpClient cliente = new HttpClient();
        public async Task<IActionResult> Index()
        {
            var listaShippers = JsonConvert.DeserializeObject<List<Shipper>>
                (await cliente.GetStringAsync(strURL)).ToList();
            return View(listaShippers);
        }
        [HttpGet]

        public IActionResult Agregar()
        {
            return View();
        }

        [HttpPost]

        public async Task<IActionResult> Agregar(Shipper shipper)
        {
            // llamamos al servicio de Api Rest
            await cliente.PostAsJsonAsync(strURL, shipper);
            return RedirectToAction("Index");
        }
    }
}
