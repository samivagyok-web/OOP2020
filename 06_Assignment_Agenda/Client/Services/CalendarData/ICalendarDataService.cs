using _06_Assignment_Agenda.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _06_Assignment_Agenda.Client.Services.CalendarData
{
    public interface ICalendarDataService
    {
        Task<IEnumerable<Calendar>> GetEveryCalendar();
        Task<Calendar> GetCalendarByID(Guid id);
        Task<Calendar> CreateCalendar(Calendar calendar);
        Task UpdateCalendar(Calendar calendar);
        Task DeleteCalendar(Guid id);
    }
}
