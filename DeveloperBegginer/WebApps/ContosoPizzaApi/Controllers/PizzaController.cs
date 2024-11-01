using System.Security.Cryptography.X509Certificates;
using ContosoPizzaApi.Models;
 using ContosoPizzaApi.Services;
 using Microsoft.AspNetCore.Mvc;


 namespace ContosoPizzaApi.Controllers {
    [ApiController]
    [Route("[controller]")]
    public class PizzaController : ControllerBase {
        public PizzaController() {
        }
            // GET all action
            [HttpGet]
            public ActionResult<List<Pizza>> GetAll() => PizzaService.GetAll();

            // GET by Id action
            [HttpGet("{id}")]
            public ActionResult<Pizza> Get(int id) {
                var pizza = PizzaService.Get(id);

                if (pizza == null) return NotFound();
                return pizza;
            } 

            // POST action
            // PUT action
            // DELETE action
    }
 }