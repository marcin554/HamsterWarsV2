using Domain.API.Models;

namespace API.Repository.Contracts
{
    public interface IHamsterRepository
    {

        Task<IEnumerable<Hamster>> GetHamsters();

        Task<Hamster> GetHamsterById(int hamsterId);

        Task<IEnumerable<Hamster>> GetRandomTwoHamsters();

        Task InsertHamster(Hamster hamster);

        Task DeleteHamster(int hamsterId);

        Task UpdateHamster(int hamsterId, bool winOrLose);

        void Save();
    }
}
