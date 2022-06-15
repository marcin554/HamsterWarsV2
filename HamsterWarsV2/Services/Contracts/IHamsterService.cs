

using Domain.Entities.Models;

namespace HamsterWarsV2.Services.Contracts
{
    public interface IHamsterService
    {
        Task<IEnumerable<Hamster>> GetHamsters();

        Task<Hamster> GetHamsterById(int id);

        Task<IEnumerable<Hamster>> GetTwoRandomHamsters();

        Task UpdateHamsters(int id, bool winOrLoss);

        Task DeleteHamster(int id);

        Task InsertHamster(Hamster hamster);
    }
}
