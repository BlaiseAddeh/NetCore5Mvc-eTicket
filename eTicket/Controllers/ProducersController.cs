using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eTicket.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace eTicket.Controllers
{
    public class ProducersController : Controller
    {

        private readonly AppDbContext _context;

        public ProducersController(AppDbContext context)
        {
            _context = context;
        }

        // GET: /<controller>/
        public async Task<IActionResult> Index()
        {
            var allProducters = await _context.Producers.ToListAsync();
            return View(allProducters);
        }
    }
}
