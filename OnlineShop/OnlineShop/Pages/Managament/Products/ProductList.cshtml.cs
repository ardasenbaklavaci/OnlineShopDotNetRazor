using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using OnlineShop.Models;

namespace OnlineShop.Pages.Managament.Products
{
    public class ProductListModel : PageModel
    {
        private readonly OnlineShopContext _context;

        public List<Product> productlist { get; set; }

        public ProductListModel(OnlineShopContext context)
        {
            _context = context;
        }

        public void OnGet()
        {
            productlist = _context.Products.ToList();
        }

        [IgnoreAntiforgeryToken]
        public IActionResult OnPostDeleteProduct(int productNo)
        {
            productlist = _context.Products.ToList();

            var product = _context.Products.FirstOrDefault(p => p.No == productNo);
            if (product == null)
            {
                return new JsonResult(new { success = false, message = "Product not found" });
            }

            _context.Products.Remove(product);
            _context.SaveChanges();

            //return RedirectToPage("/Managament/Products/ProductList");
            return new JsonResult(new { success = true });
        }
    }
}
