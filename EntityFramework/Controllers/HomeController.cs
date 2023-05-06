using System.Diagnostics;
using EntityFramework.Data;
using EntityFramework.Models;
using EntityFramework.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace EntityFramework.Controllers;

public class HomeController : Controller
{
    private readonly AppDbContext _context;

    public HomeController(AppDbContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {

        HomeVM home = new()
        {
            sliders = _context.sliders.ToList(),
            features = _context.features.ToList(),
            services = _context.services.ToList()
        };
        return View(home);
    }

}

