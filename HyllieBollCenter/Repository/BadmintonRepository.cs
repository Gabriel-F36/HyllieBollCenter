using HyllieBollCenter.Data;
using HyllieBollCenter.Interfaces;
using HyllieBollCenter.Models;
using Microsoft.EntityFrameworkCore;

namespace HyllieBollCenter.Repository
{
    public class BadmintonRepository : IBadmintonRepository
    {
        private readonly AppDbContext _context;

        public BadmintonRepository(AppDbContext context)
        {
            _context = context;
        }
        public bool Add(Badminton badminton)
        {
            _context.Add(badminton);
            return Save();
        }

        public bool Delete(Badminton badminton)
        {
            _context.Remove(badminton);
            return Save();
        }

        public async Task<IEnumerable<Badminton>> GetAll()
        {
            return await _context.Badmintons.ToListAsync();
        }

        public async Task<Badminton> GetByIdAsync(int? id)
        {
            return await _context.Badmintons.FirstOrDefaultAsync(x => x.Id == id);
        }

        public bool Save()
        {
            var saved = _context.SaveChanges();
            return saved > 0 ? true : false;
        }

        public bool Update(Badminton badminton)
        {
            _context.Update(badminton);
            return Save();
        }
    }
}
