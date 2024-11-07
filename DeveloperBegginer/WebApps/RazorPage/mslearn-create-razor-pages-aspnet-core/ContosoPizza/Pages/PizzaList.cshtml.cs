using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ContosoPizza.Models;
using ContosoPizza.Services;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace ContosoPizza.Pages
{
    public class PizzaListModel : PageModel
    {
        [BindProperty]
        public Pizza newPizza { get; set; } = default!;

        private readonly PizzaService _service;
        public PizzaListModel(PizzaService service)
        {
            _service = service;
        }
        public IList<Pizza> PizzaList { get; set; } = default!;


        public void OnGet()
        {
            PizzaList = _service.GetPizzas();
        }

        public IActionResult OnPost()
        {
            if (PizzaList == null || !ModelState.IsValid)
                return Page();
            _service.AddPizza(newPizza);
            return RedirectToAction("Get");
        }

        public IActionResult OnPostDelete(int id)
        {
            _service.DeletePizza(id);

            return RedirectToAction("Get");
        }

    }
}
