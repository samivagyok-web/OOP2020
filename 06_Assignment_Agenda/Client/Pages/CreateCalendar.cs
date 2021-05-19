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
    public partial class CreateCalendar
    {
        [Inject]
        public ICalendarDataService CalendarDataService { get; set; }

        [Inject]
        public IPersonDataService PersonDataService { get; set; }

        [Inject]
        public NavigationManager NavigationManager { get; set; }

        public List<Person> People { get; set; } = new List<Person>();

        public Calendar Calendar { get; set; } = new Calendar { CalendarID = Guid.NewGuid() };

        public string PersonID { get; set; }

        public Person Pers { get; set; }

        protected async override Task OnInitializedAsync()
        {
            People = (await PersonDataService.GetEveryPerson()).ToList();
        }

        private async Task HandleValidSubmit()
        {
            Pers = await PersonDataService.GetPersonByID(Guid.Parse(PersonID));
            Pers.CalendarID = Calendar.CalendarID;
            await PersonDataService.UpdatePerson(Pers);
            Calendar.PersonID = Guid.Parse(PersonID);
            await CalendarDataService.CreateCalendar(Calendar);
            NavigationManager.NavigateTo("/peoplelist");
        }
    }
}
