using Security.Models;

namespace Security.Repositories
{
    public interface IHospitalRepository
    {
        Task<IEnumerable<Hospital>> GetAll();
        Task<Hospital> GetOne(Guid id);
        Task Add(Hospital hospital);
        Task Update(Hospital hospital);
        Task Delete(Hospital hospital);
    }
}
