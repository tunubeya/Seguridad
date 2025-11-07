using Security.Models;
using Security.Models.DTOS;

namespace Security.Services
{
    public interface IHospitalService
    {
        Task<IEnumerable<Hospital>> GetAll();
        Task<Hospital> GetOne(Guid id);
        Task<Hospital> CreateHospital(CreateHospitalDto dto);
        Task<Hospital> UpdateHospital(UpdateHospitalDto dto, Guid id);
        Task DeleteHospital(Guid id);
    }
}
