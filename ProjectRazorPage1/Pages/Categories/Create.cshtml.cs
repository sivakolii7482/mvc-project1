using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProjectRazorPage1.Data;
using ProjectRazorPage1.Models;

namespace ProjectRazorPage1.Pages.Categories
{
    [BindProperties]
    public class CreateModel : PageModel
    {
        private readonly ApplicationDbContext _db;
        public Category Category { get; set; }
        public CreateModel(ApplicationDbContext db) { _db = db; }
        public void OnGet()
        {
        }
        public IActionResult OnPost() { 
            _db.Categories.Add(Category);
            _db.SaveChanges();
            TempData["success"] = "Category Created successfully";
            return RedirectToPage("index");
        }
    }
}
