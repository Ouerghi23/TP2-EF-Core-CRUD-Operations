using Microsoft.AspNetCore.Mvc;
using TP2.Data;

namespace TP2.Controllers
{
    public class GenreController : Controller
    {
        private readonly ApplicationDbContext _db;
        public GenreController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            var genres = _db.Genres.ToList();
            return View(genres);
        }
    }
}
