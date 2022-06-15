using API.Repository.Contracts;
using Domain.API.Data;
using Domain.API.Models;
using Microsoft.EntityFrameworkCore;

namespace API.Repository
{
    public class HamsterRepository : IHamsterRepository
    {
        private DatabaseContext context;

        public HamsterRepository(DatabaseContext context)
        {
            this.context = context;
        }

        public async Task<Hamster> GetHamsterById(int hamsterId)
        {
            var hamster = await context.Hamsters.FindAsync(hamsterId);
            return hamster;
        }

        public async Task<IEnumerable<Hamster>> GetHamsters()
        {
            var hamsters = await this.context.Hamsters.ToListAsync();
            return hamsters;
        }

        public async Task<IEnumerable<Hamster>> GetRandomTwoHamsters()
        {
            List<Hamster> list = new List<Hamster>();
            var hamsters = await this.context.Hamsters.ToListAsync();

            var hamster = hamsters.Where(x => !list.Any(y => y.HamsterId == x.HamsterId)).OrderBy(x => Guid.NewGuid()).Take(2).ToList();
            return hamster;
        }




        public async Task InsertHamster(Hamster hamster)
        {
           await this.context.Hamsters.AddAsync(hamster);
            this.context.SaveChanges();
        }



        public async Task DeleteHamster(int hamsterId)
        {
            Hamster hamster =  await this.context.Hamsters.FindAsync(hamsterId);
            this.context.Hamsters.Remove(hamster);
            this.context.SaveChanges();
        }

        public async Task UpdateHamster(int hamsterId, bool winOrLose)
        {
            Hamster hamster = await this.context.Hamsters.FindAsync(hamsterId);

            if (winOrLose == false)
            {
                hamster.Losses++;
                hamster.Games++;
                this.context.SaveChanges();
            }
            else
            {
                hamster.Wins++;
                hamster.Games++;
                this.context.SaveChanges();
            }
            

        }

        public async void Save()
        {
            await this.context.SaveChangesAsync();
        }

 
    }
}
