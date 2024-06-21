using Microsoft.AspNetCore.Mvc;
using sampleDataDummy.Data;
using sampleDataDummy.Models;

namespace sampleDataDummy.Controllers;

public class PersonsController : Controller
{
    private readonly AppDbContext _context;

    public PersonsController(AppDbContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public IActionResult SavePersons(List<Personal> persons)
    {
        if (persons != null && persons.Count > 0)
        {
            _context.Personals.AddRange(persons);
            _context.SaveChanges();
            return Json(new { success = true });
        }

        return Json(new { success = false, message = "No data to save" });
    }
}