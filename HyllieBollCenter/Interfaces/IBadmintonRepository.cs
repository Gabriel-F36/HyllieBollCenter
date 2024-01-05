using HyllieBollCenter.Models;

namespace HyllieBollCenter.Interfaces
{
    public interface IBadmintonRepository
    {
        Task<IEnumerable<Badminton>> GetAll();
        Task<Badminton> GetByIdAsync(int? id);
        bool Add(Badminton badminton);
        bool Update(Badminton badminton);
        bool Delete(Badminton badminton);
        bool Save();
    }
}
