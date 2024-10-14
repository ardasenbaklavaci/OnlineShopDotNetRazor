using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using OnlineShop.Models;

namespace OnlineShop.Pages.Managament.Products
{
    public class AddModel : PageModel
    {
        private readonly OnlineShopContext _context;
        [BindProperty]
        public Product product { get; set; }

        public AddModel(OnlineShopContext context)
        {
            _context = context;
        }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Products.Add(product);
            _context.SaveChanges();

            return RedirectToPage("/Managament/Products/Index"); // Redirect to the product list page or wherever you need
        }
        
    }

}
