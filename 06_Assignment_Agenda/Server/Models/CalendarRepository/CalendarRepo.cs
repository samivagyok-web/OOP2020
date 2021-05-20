using _06_Assignment_Agenda.Server.Data;
using _06_Assignment_Agenda.Shared;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _06_Assignment_Agenda.Server.Models.CalendarRepository
{
    public class CalendarRepo : ICalendarRepo
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public CalendarRepo(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public Calendar CreateCalendar(Calendar calendar)
        {
            _applicationDbContext.Calendars.Add(calendar);
            _applicationDbContext.SaveChanges();

            return calendar;
        }

        public void DeleteCalendar(Guid id)
        {
            var calendarToDelete = _applicationDbContext.Calendars.FirstOrDefault(p => p.CalendarID == id);

            if (calendarToDelete == null) return;

            _applicationDbContext.Calendars.Remove(calendarToDelete);
            _applicationDbContext.SaveChanges();
        }

        public Calendar GetCalendarByID(Guid id)
        {
            return _applicationDbContext.Calendars.Include(x => x.Activities).FirstOrDefault(p => p.CalendarID == id);
        }

        public IEnumerable<Calendar> GetEveryCalendar()
        {
            return _applicationDbContext.Calendars.Include(x => x.Activities);
        }

        public Calendar UpdateCalendar(Calendar calendar)
        {
            var calendarToUpdate = _applicationDbContext.Calendars.FirstOrDefault(p => p.CalendarID == calendar.CalendarID);
            if (calendarToUpdate == null) return null;

            calendarToUpdate.CalendarID = calendar.CalendarID;
            calendarToUpdate.PersonID = calendar.PersonID;
            calendarToUpdate.Activities = calendar.Activities;

            _applicationDbContext.SaveChanges();
            return calendarToUpdate;
        }
    }
}
