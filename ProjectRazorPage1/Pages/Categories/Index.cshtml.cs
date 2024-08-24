using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProjectRazorPage1.Data;
using ProjectRazorPage1.Models;

namespace ProjectRazorPage1.Pages.Categories
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _db;
        public List<Category> CategoryList { get; set; }
        public IndexModel(ApplicationDbContext db) {  _db = db; }
        public void OnGet()
        {
            CategoryList = _db.Categories.ToList();
        }
    }
}
