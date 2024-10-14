using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using OnlineShop.Models;

namespace OnlineShop.Pages.Managament.Products
{
    public class IndexModel : PageModel
    {
        public void OnGet()
        {
            Response.Redirect("/Managament/Products/ProductList");
        }

       
    }



}
