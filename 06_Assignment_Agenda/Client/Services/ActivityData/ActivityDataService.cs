using _06_Assignment_Agenda.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace _06_Assignment_Agenda.Client.Services.ActivityData
{
    public class ActivityDataService : IActivityDataService
    {
        private readonly HttpClient _httpClient;

        public ActivityDataService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<Activity> CreateActivity(Activity activity)
        {
            var activityJson =
                new StringContent(JsonSerializer.Serialize(activity), Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync("api/activity", activityJson);

            if (response.IsSuccessStatusCode)
                return await JsonSerializer.DeserializeAsync<Activity>(await response.Content.ReadAsStreamAsync());

            return null;
        }

        public async Task DeleteActivity(Guid id)
        {
            await _httpClient.DeleteAsync($"api/activity/{id}");
        }

        public async Task<Activity> GetActivityByID(Guid id)
        {
            return await JsonSerializer.DeserializeAsync<Activity>
                (await _httpClient.GetStreamAsync($"api/activity/{id}"), new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        }

        public async Task<IEnumerable<Activity>> GetEveryActivity()
        {
            return await JsonSerializer.DeserializeAsync<IEnumerable<Activity>>
                (await _httpClient.GetStreamAsync($"api/activity"), new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        }

        public async Task UpdateActivity(Activity activity)
        {
            var activityJson =
                new StringContent(JsonSerializer.Serialize(activity), Encoding.UTF8, "application/json");

            await _httpClient.PutAsync("api/activity", activityJson);
        }
    }
}
