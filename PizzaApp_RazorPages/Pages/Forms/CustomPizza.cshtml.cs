using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PizzaApp_RazorPages.Models;

namespace PizzaApp_RazorPages.Pages.Forms
{
    public class CustomPizzaModel : PageModel
    {
        [BindProperty]
        public PizzasModel  Pizza { get; set; }
        public void OnGet()
        {
        }
    }
}
