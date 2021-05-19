using _06_Assignment_Agenda.Client.Services.CalendarData;
using _06_Assignment_Agenda.Client.Services.PersonData;
using _06_Assignment_Agenda.Shared;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _06_Assignment_Agenda.Client.Pages
{
    public partial class PersonList
    {
        [Inject]
        public IPersonDataService PersonDataService { get; set; }

        [Inject]
        public ICalendarDataService CalendarDataService { get; set; }

        public IEnumerable<Person> People { get; set; }

        protected async override Task OnInitializedAsync()
        {
            People = (await PersonDataService.GetEveryPerson());
        }

        private async Task DeletePerson(Guid id)
        {
            if ((await PersonDataService.GetPersonByID(id)).CalendarID != Guid.Empty)
            {
                var calendarID = (await PersonDataService.GetPersonByID(id)).CalendarID;
                await CalendarDataService.DeleteCalendar(calendarID);
            }
            await PersonDataService.DeletePerson(id);            
            People = (await PersonDataService.GetEveryPerson());
        }
    }
}
