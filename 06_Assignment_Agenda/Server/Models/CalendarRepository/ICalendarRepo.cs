using _06_Assignment_Agenda.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _06_Assignment_Agenda.Server.Models.CalendarRepository
{
    public interface ICalendarRepo
    {
        Calendar GetCalendarByID(Guid id);
        IEnumerable<Calendar> GetEveryCalendar();
        Calendar CreateCalendar(Calendar calendar);
        Calendar UpdateCalendar(Calendar calendar);
        void DeleteCalendar(Guid id);
    }
}
