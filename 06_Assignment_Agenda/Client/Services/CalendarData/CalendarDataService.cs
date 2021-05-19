using _06_Assignment_Agenda.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace _06_Assignment_Agenda.Client.Services.CalendarData
{
    public class CalendarDataService : ICalendarDataService
    {
        private readonly HttpClient _httpClient;

        public CalendarDataService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<Calendar> CreateCalendar(Calendar calendar)
        {
            var calendarJson =
                new StringContent(JsonSerializer.Serialize(calendar), Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync("api/calendar", calendarJson);

            if (response.IsSuccessStatusCode)
                return await JsonSerializer.DeserializeAsync<Calendar>(await response.Content.ReadAsStreamAsync());

            return null;
        }

        public async Task DeleteCalendar(Guid id)
        {
            await _httpClient.DeleteAsync($"api/calendar/{id}");
        }

        public async Task<Calendar> GetCalendarByID(Guid id)
        {
            return await JsonSerializer.DeserializeAsync<Calendar>
                (await _httpClient.GetStreamAsync($"api/calendar/{id}"), new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        }

        public async Task<IEnumerable<Calendar>> GetEveryCalendar()
        {
            return await JsonSerializer.DeserializeAsync<IEnumerable<Calendar>>
                (await _httpClient.GetStreamAsync($"api/calendar"), new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        }

        public async Task UpdateCalendar(Calendar calendar)
        {
            var calendarJson =
                new StringContent(JsonSerializer.Serialize(calendar), Encoding.UTF8, "application/json");

            await _httpClient.PutAsync($"api/calendar", calendarJson);
        }
    }
}
