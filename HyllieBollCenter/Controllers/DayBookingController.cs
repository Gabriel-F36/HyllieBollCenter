using HyllieBollCenter.Data;
using HyllieBollCenter.Models;
using Microsoft.AspNetCore.Mvc;

namespace HyllieBollCenter.Controllers
{
    public class DayBookingController : Controller
    {
        private readonly AppDbContext _context;

        public DayBookingController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<DayBooking> dayBooking = _context.DayBookings.ToList();
            return View(dayBooking);
        }
    }
}
