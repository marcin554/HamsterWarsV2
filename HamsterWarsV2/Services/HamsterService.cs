
using Domain.Entities.Models;
using HamsterWarsV2.Services.Contracts;
using System.Net.Http.Json;
using System.Text.Json;

namespace HamsterWarsV2.Services
{
    public class HamsterService : IHamsterService
    {
        private readonly HttpClient httpClient;


        public HamsterService(HttpClient httpClient){
            this.httpClient = httpClient;
        }

        public async Task<Hamster> GetHamsterById(int id)
        {
            try
            {
                var response = await this.httpClient.GetAsync($"Domain/Api/Hamster/{id}");

                if (response.IsSuccessStatusCode) { 
                    if(response.StatusCode == System.Net.HttpStatusCode.NoContent)
                    {
                        return default(Hamster);
                    }
                    return await response.Content.ReadFromJsonAsync<Hamster>();
                }

                else
                {
                    var message = await response.Content.ReadAsStringAsync();
                    throw new Exception(message);
                }
         
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<IEnumerable<Hamster>> GetHamsters()
        {
            try
            {
                var hamsters = await this.httpClient.GetFromJsonAsync<IEnumerable<Hamster>>("Domain/Api/Hamster");
                return hamsters;
            }
            catch (Exception)
            {

                throw;
            }
        }



        public async Task<IEnumerable<Hamster>> GetTwoRandomHamsters()
        {
            try
            {
                IEnumerable<Hamster> hamsters = await this.httpClient.GetFromJsonAsync<IEnumerable<Hamster>>("Domain/Api/Hamster/Random");
                return hamsters;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task DeleteHamster(int id)
        {
            try
            {
                
                await this.httpClient.DeleteAsync($"Domain/Api/Hamster?Id={id}");
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task InsertHamster(Hamster hamster)
        {
            try
            {
                Hamster hamster1 = new Hamster();
                hamster1 = hamster;

                await this.httpClient.PostAsJsonAsync($"Domain/Api/Hamster", hamster1);
            }
            catch (Exception)
            {

                throw;
            }
        }
        public async Task UpdateHamsters(int id, bool winOrLoss)
        {
            try
            {
                HttpResponseMessage response =
                await this.httpClient.PutAsJsonAsync($"Domain/Api/Hamster?hamsterId={id}&winOrLose={winOrLoss}", winOrLoss);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
