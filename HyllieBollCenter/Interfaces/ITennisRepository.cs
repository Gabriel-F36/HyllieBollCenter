using HyllieBollCenter.Models;

namespace HyllieBollCenter.Interfaces
{
    public interface ITennisRepository
    {
        Task<IEnumerable<Tennis>> GetAll();
        Task<Tennis> GetByIdAsync(int? id);
        bool Add(Tennis tennis);
        bool Update(Tennis tennis);
        bool Delete(Tennis tennis);
        bool Save();
    }
}
