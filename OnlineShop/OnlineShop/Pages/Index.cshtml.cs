using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using OnlineShop.Models;

namespace OnlineShop.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        OnlineShopContext context;

        public List<Product> products;

        public IndexModel(ILogger<IndexModel> logger, OnlineShopContext _context )
        {
            _logger = logger;
            this.context = _context;
        }

        public void OnGet()
        {
            products = context.Products.ToList();

        }
    }
}
