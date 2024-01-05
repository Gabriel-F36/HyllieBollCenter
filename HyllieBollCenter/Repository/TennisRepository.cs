using HyllieBollCenter.Data;
using HyllieBollCenter.Interfaces;
using HyllieBollCenter.Models;
using Microsoft.EntityFrameworkCore;

namespace HyllieBollCenter.Repository
{
    public class TennisRepository : ITennisRepository
    {
        private readonly AppDbContext _context;

        public TennisRepository(AppDbContext context)
        {
            _context = context;
        }
        public bool Add(Tennis tennis)
        {
            _context.Add(tennis);
            return Save();
        }

        public bool Delete(Tennis tennis)
        {
            _context.Remove(tennis);
            return Save();
        }

        public async Task<IEnumerable<Tennis>> GetAll()
        {
            return await _context.Tenniss.ToListAsync();

        }

        public async Task<Tennis> GetByIdAsync(int? id)
        {
            return await _context.Tenniss.FirstOrDefaultAsync(x => x.Id == id);
        }

        public bool Save()
        {
            var saved = _context.SaveChanges();
            return saved > 0 ? true : false;
        }

        public bool Update(Tennis tennis)
        {
            _context.Update(tennis);
            return Save();
        }
    }
}
