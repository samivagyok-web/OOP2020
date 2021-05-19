using _06_Assignment_Agenda.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace _06_Assignment_Agenda.Client.Services.PersonData
{
    public class PersonDataService : IPersonDataService
    {
        private readonly HttpClient _httpClient;

        public PersonDataService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<Person> AddPerson(Person person)
        {
            var personJson =
                new StringContent(JsonSerializer.Serialize(person), Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync("api/person", personJson);

            if (response.IsSuccessStatusCode)
                return await JsonSerializer.DeserializeAsync<Person>(await response.Content.ReadAsStreamAsync());

            return null;
        }

        public async Task DeletePerson(Guid id)
        {
            await _httpClient.DeleteAsync($"api/person/{id}");
        }

        public async Task<IEnumerable<Person>> GetEveryPerson()
        {
            return await JsonSerializer.DeserializeAsync<IEnumerable<Person>>
                (await _httpClient.GetStreamAsync($"api/person"), new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        }

        public async Task<Person> GetPersonByID(Guid id)
        {
            return await JsonSerializer.DeserializeAsync<Person>
                (await _httpClient.GetStreamAsync($"api/person/{id}"), new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        }

        public async Task UpdatePerson(Person person)
        {
            var personJson =
                new StringContent(JsonSerializer.Serialize(person), Encoding.UTF8, "application/json");

            await _httpClient.PutAsync("api/person", personJson);
        }
    }
}
