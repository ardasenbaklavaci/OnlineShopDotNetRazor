using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using OnlineShop.Models;

namespace OnlineShop.Pages.Managament.Products
{
    public class EditModel : PageModel
    {
        OnlineShopContext context;

        [BindProperty] 
        public Product product { get; set; }
        public EditModel(OnlineShopContext _context)
        {
            this.context = _context;
        }

        public void OnGet(String id)
        {
            product = context.Products.FirstOrDefault(x => x.Id.Equals(id));
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            String productid = product.Id;

            Product existingProduct = context.Products.FirstOrDefault(x => x.Id.Equals(productid));
            if (existingProduct == null)
            {
                return NotFound();
            }

            // Update only the non-identity properties
            existingProduct.Id = product.Id;
            existingProduct.Name = product.Name;
            existingProduct.Brand = product.Brand;
            existingProduct.Summary = product.Summary;
            existingProduct.InfoHtml = product.InfoHtml;
            existingProduct.Price = product.Price;
            existingProduct.Models = product.Models;
            existingProduct.Tags = product.Tags;
            existingProduct.Active = product.Active;
            existingProduct.Selling = product.Selling;

            context.SaveChanges();

            return RedirectToPage("/Managament/Products/Index");
        }
    }
}
