using HyllieBollCenter.Interfaces;
using HyllieBollCenter.Models;
using HyllieBollCenter.Repository;
using Microsoft.AspNetCore.Mvc;

namespace HyllieBollCenter.Controllers
{
	public class BadmintonController : Controller
	{
        private readonly IBadmintonRepository _badmintonRepository;
        private readonly IHttpContextAccessor _httpcontextAccessor;
        public BadmintonController(IBadmintonRepository badmintonRepository, IHttpContextAccessor httpcontextAccessor)
        {
            _badmintonRepository = badmintonRepository;
            _httpcontextAccessor = httpcontextAccessor;
        }
        public async Task<IActionResult> Index()
		{
            IEnumerable<Badminton> badminton = await _badmintonRepository.GetAll();

            return View(badminton);
        }
        public async Task<IActionResult> MyBookings()
        {
            IEnumerable<Badminton> badminton = await _badmintonRepository.GetAll();
            string curUserId = _httpcontextAccessor.HttpContext.User.GetUserId();
            foreach (Badminton item in badminton)
            {
                item.AppUserId = curUserId;
            }
            return View(badminton);
        }
    //Remove bookings
        public async Task<IActionResult> RemoveBooking9To11(int Id)
        {
            Badminton myBooking = await _badmintonRepository.GetByIdAsync(Id);
            myBooking.NineToElevenId = null;
            _badmintonRepository.Update(myBooking);
            _badmintonRepository.Save();
            return RedirectToAction("MyBookings");
        }
        public async Task<IActionResult> RemoveBooking11To13(int Id)
        {
            Badminton myBooking = await _badmintonRepository.GetByIdAsync(Id);
            myBooking.ElevenToThirteenId = null;
            _badmintonRepository.Update(myBooking);
            _badmintonRepository.Save();
            return RedirectToAction("MyBookings");
        }
        public async Task<IActionResult> RemoveBooking13To15(int Id)
        {
            Badminton myBooking = await _badmintonRepository.GetByIdAsync(Id);
            myBooking.ThirteenToFifteenId = null;
            _badmintonRepository.Update(myBooking);
            _badmintonRepository.Save();
            return RedirectToAction("MyBookings");
        }
        public async Task<IActionResult> RemoveBooking15To17(int Id)
        {
            Badminton myBooking = await _badmintonRepository.GetByIdAsync(Id);
            myBooking.FifteenToSeventeenId = null;
            _badmintonRepository.Update(myBooking);
            _badmintonRepository.Save();
            return RedirectToAction("MyBookings");
        }
        public async Task<IActionResult> RemoveBooking17To19(int Id)
        {
            Badminton myBooking = await _badmintonRepository.GetByIdAsync(Id);
            myBooking.SeventeenToNineteenId = null;
            _badmintonRepository.Update(myBooking);
            _badmintonRepository.Save();
            return RedirectToAction("MyBookings");
        }
    //Make bookings
        public async Task<IActionResult> MakeBooking9To11(int Id)
        {
            var curUserId = _httpcontextAccessor.HttpContext.User.GetUserId();
            Badminton booking = await _badmintonRepository.GetByIdAsync(Id);
            booking.NineToElevenId = curUserId;
            _badmintonRepository.Update(booking);
            _badmintonRepository.Save();
            List<Badminton> badminton = (List<Badminton>)await _badmintonRepository.GetAll();
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> MakeBooking11To13(int Id)
        {
            var curUserId = _httpcontextAccessor.HttpContext.User.GetUserId();
            Badminton booking = await _badmintonRepository.GetByIdAsync(Id);
            booking.ElevenToThirteenId = curUserId;
            _badmintonRepository.Update(booking);
            _badmintonRepository.Save();
            List<Badminton> badminton = (List<Badminton>)await _badmintonRepository.GetAll();
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> MakeBooking13To15(int Id)
        {
            var curUserId = _httpcontextAccessor.HttpContext.User.GetUserId();
            Badminton booking = await _badmintonRepository.GetByIdAsync(Id);
            booking.ThirteenToFifteenId = curUserId;
            _badmintonRepository.Update(booking);
            _badmintonRepository.Save();
            List<Badminton> badminton = (List<Badminton>)await _badmintonRepository.GetAll();
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> MakeBooking15To17(int Id)
        {
            var curUserId = _httpcontextAccessor.HttpContext.User.GetUserId();
            Badminton booking = await _badmintonRepository.GetByIdAsync(Id);
            booking.FifteenToSeventeenId = curUserId;
            _badmintonRepository.Update(booking);
            _badmintonRepository.Save();
            List<Badminton> badminton = (List<Badminton>)await _badmintonRepository.GetAll();
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> MakeBooking17To19(int Id)
        {
            var curUserId = _httpcontextAccessor.HttpContext.User.GetUserId();
            Badminton booking = await _badmintonRepository.GetByIdAsync(Id);
            booking.SeventeenToNineteenId = curUserId;
            _badmintonRepository.Update(booking);
            _badmintonRepository.Save();
            List<Badminton> badminton = (List<Badminton>)await _badmintonRepository.GetAll();
            return RedirectToAction("Index");
        }
    }
}
