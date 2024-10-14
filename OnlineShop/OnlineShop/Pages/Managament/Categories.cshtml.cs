using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using OnlineShop.Models;

namespace OnlineShop.Pages.Managament
{
    public class CategoriesModel : PageModel
    {
        private readonly OnlineShopContext _context;

        public List<Category> Categories { get; set; }

        public CategoriesModel(OnlineShopContext context)
        {
            _context = context;
        }

        // Fetching categories on page load
        public void OnGet()
        {
            Categories = _context.Categories.ToList();
        }

        // Add new category via AJAX
        [IgnoreAntiforgeryToken]
        public JsonResult OnPostAddCategory(string categoryName)
        {
            if (!string.IsNullOrEmpty(categoryName))
            {
                var newCategory = new Category { CategoryName = categoryName };
                _context.Categories.Add(newCategory);
                _context.SaveChanges();
                return new JsonResult(new { success = true });
            }
            return new JsonResult(new { success = false });
        }

        // Edit category via AJAX
        [IgnoreAntiforgeryToken]
        public JsonResult OnPostEditCategory(int categoryId, string categoryName)
        {
            var category = _context.Categories.FirstOrDefault(c => c.Id == categoryId);
            if (category != null && !string.IsNullOrEmpty(categoryName))
            {
                category.CategoryName = categoryName;
                _context.SaveChanges();
                return new JsonResult(new { success = true });
            }
            return new JsonResult(new { success = false });
        }

        // Delete category via AJAX
        [IgnoreAntiforgeryToken]
        public JsonResult OnPostDeleteCategory(int categoryId)
        {
            var category = _context.Categories.FirstOrDefault(c => c.Id == categoryId);
            if (category != null)
            {
                _context.Categories.Remove(category);
                _context.SaveChanges();
                return new JsonResult(new { success = true });
            }
            return new JsonResult(new { success = false });
        }
    }


}
