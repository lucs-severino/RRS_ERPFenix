using Domain.Entities;

namespace Domain.Interfaces
{
    public interface IBancoAgenciaRepository : IRepository<BancoAgencia>
    {
        Task<BancoAgencia> GetBancoAgenciaBancoAsync(int? id);
    }
}