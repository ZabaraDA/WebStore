using Domain.Entity;
using Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers
{
    public class ApplicationTypeController : Controller
    {
        private ApplicationDbContext _context;
        public ApplicationTypeController(ApplicationDbContext context)
        {
            _context = context;   
        }
        public IActionResult Index()
        {
            IEnumerable<ApplicationType> applicationTypeList = _context.ApplicationType.ToList();
            return View(applicationTypeList);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(ApplicationType applicationType)
        {
            _context.ApplicationType.Add(applicationType);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
