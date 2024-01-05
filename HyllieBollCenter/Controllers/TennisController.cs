using HyllieBollCenter.Data;
using HyllieBollCenter.Interfaces;
using HyllieBollCenter.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.Intrinsics.X86;

namespace HyllieBollCenter.Controllers
{
	public class TennisController : Controller
	{
        private readonly ITennisRepository _tennisRepository;
        private readonly IHttpContextAccessor _httpcontextAccessor;
        //private string curUserId;

        public TennisController(ITennisRepository tennisRepository, IHttpContextAccessor httpcontextAccessor)
        {
            _tennisRepository = tennisRepository;
            _httpcontextAccessor = httpcontextAccessor;
            //curUserId = _httpcontextAccessor.HttpContext.User.GetUserId();
    }
        public async Task<IActionResult> Index()
		{
            IEnumerable<Tennis> tennis = await _tennisRepository.GetAll();
            
            return View(tennis);
		}
        public async Task<IActionResult> MyBookings()
        {
            IEnumerable<Tennis> tennis = await _tennisRepository.GetAll();
            string curUserId = _httpcontextAccessor.HttpContext.User.GetUserId();
            foreach (Tennis item in tennis)
            {
                item.AppUserId = curUserId;
            }
            return View(tennis);
        }
    //Remove bookings
        public async Task<IActionResult> RemoveBooking9To11(int Id)
        {
            Tennis myBooking = await _tennisRepository.GetByIdAsync(Id);
            myBooking.NineToElevenId = null;
            _tennisRepository.Update(myBooking);
            _tennisRepository.Save();
            return RedirectToAction("MyBookings");
        }
        public async Task<IActionResult> RemoveBooking11To13(int Id)
        {
            Tennis myBooking = await _tennisRepository.GetByIdAsync(Id);
            myBooking.ElevenToThirteenId = null;
            _tennisRepository.Update(myBooking);
            _tennisRepository.Save();
            return RedirectToAction("MyBookings");
        }
        public async Task<IActionResult> RemoveBooking13To15(int Id)
        {
            Tennis myBooking = await _tennisRepository.GetByIdAsync(Id);
            myBooking.ThirteenToFifteenId = null;
            _tennisRepository.Update(myBooking);
            _tennisRepository.Save();
            return RedirectToAction("MyBookings");
        }
        public async Task<IActionResult> RemoveBooking15To17(int Id)
        {
            Tennis myBooking = await _tennisRepository.GetByIdAsync(Id);
            myBooking.FifteenToSeventeenId = null;
            _tennisRepository.Update(myBooking);
            _tennisRepository.Save();
            return RedirectToAction("MyBookings");
        }
        public async Task<IActionResult> RemoveBooking17To19(int Id)
        {
            Tennis myBooking = await _tennisRepository.GetByIdAsync(Id);
            myBooking.SeventeenToNineteenId = null;
            _tennisRepository.Update(myBooking);
            _tennisRepository.Save();
            return RedirectToAction("MyBookings");
        }
    //Make bookings
        public async Task<IActionResult> MakeBooking9To11(int Id)
        {
            var curUserId = _httpcontextAccessor.HttpContext.User.GetUserId();
            Tennis booking = await _tennisRepository.GetByIdAsync(Id);
            booking.NineToElevenId = curUserId; 
            _tennisRepository.Update(booking);
            _tennisRepository.Save();
            List<Tennis> tennis = (List<Tennis>)await _tennisRepository.GetAll();
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> MakeBooking11To13(int Id)
        {
            var curUserId = _httpcontextAccessor.HttpContext.User.GetUserId();
            Tennis booking = await _tennisRepository.GetByIdAsync(Id);
            booking.ElevenToThirteenId = curUserId;
            _tennisRepository.Update(booking);
            _tennisRepository.Save();
            List<Tennis> tennis = (List<Tennis>)await _tennisRepository.GetAll();
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> MakeBooking13To15(int Id)
        {
            var curUserId = _httpcontextAccessor.HttpContext.User.GetUserId();
            Tennis booking = await _tennisRepository.GetByIdAsync(Id);
            booking.ThirteenToFifteenId = curUserId;
            _tennisRepository.Update(booking);
            _tennisRepository.Save();
            List<Tennis> tennis = (List<Tennis>)await _tennisRepository.GetAll();
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> MakeBooking15To17(int Id)
        {
            var curUserId = _httpcontextAccessor.HttpContext.User.GetUserId();
            Tennis booking = await _tennisRepository.GetByIdAsync(Id);
            booking.FifteenToSeventeenId = curUserId;
            _tennisRepository.Update(booking);
            _tennisRepository.Save();
            List<Tennis> tennis = (List<Tennis>)await _tennisRepository.GetAll();
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> MakeBooking17To19(int Id)
        {
            var curUserId = _httpcontextAccessor.HttpContext.User.GetUserId();
            Tennis booking = await _tennisRepository.GetByIdAsync(Id);
            booking.SeventeenToNineteenId = curUserId;
            _tennisRepository.Update(booking);
            _tennisRepository.Save();
            List<Tennis> tennis = (List<Tennis>)await _tennisRepository.GetAll();
            return RedirectToAction("Index");
        }
    }
}
//Context.Users.Update(user3);
