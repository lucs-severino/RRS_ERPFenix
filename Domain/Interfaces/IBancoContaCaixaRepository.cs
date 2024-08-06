using Domain.Entities;

namespace Domain.Interfaces
{
    public interface IBancoContaCaixaRepository : IRepository<BancoContaCaixa>
    {
        Task<BancoContaCaixa> GetBancoContaCaixaBancoAgenciaBancoAsync(int? id);
    }
}