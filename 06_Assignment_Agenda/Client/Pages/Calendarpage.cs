using _06_Assignment_Agenda.Client.Services.ActivityData;
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
    public partial class Calendarpage
    {
        [Parameter]
        public string CalendarID { get; set; }

        [Inject]
        public ICalendarDataService CalendarDataService { get; set; }

        [Inject]
        public IActivityDataService ActivityDataService { get; set; }

        [Inject]
        public IPersonDataService PersonDataService { get; set; }

        public Calendar Calendar { get; set; }

        protected async override Task OnInitializedAsync()
        {
            Calendar = await CalendarDataService.GetCalendarByID(Guid.Parse(CalendarID));
            Calendar.Activities.OrderBy(p => p.StartTime);
        }

        private async Task<string> GetHostName(Guid ID)
        {
            Person host = (await PersonDataService.GetPersonByID(ID));

            return host.FirstName + " " + host.LastName;
        }
    }
}
