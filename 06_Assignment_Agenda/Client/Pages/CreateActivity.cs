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
    public partial class CreateActivity
    {
        [Inject]
        public IActivityDataService ActivityDataService { get; set; }

        [Inject]
        public IPersonDataService PersonDataService { get; set; }

        [Inject]
        public ICalendarDataService CalendarDataService { get; set; }

        public Activity Activity { get; set; } = new Activity { ActivityID = Guid.NewGuid(), StartTime = DateTime.Now, FinishTime = DateTime.Now };

        public List<Person> People { get; set; } = new List<Person>();

        public Person Person { get; set; }

        public Calendar Calendar { get; set; }

        public string PersonID { get; set; }

        protected async override Task OnInitializedAsync()
        {
            People = (await PersonDataService.GetEveryPerson()).ToList();
        }

        private async Task HandleValidSubmit()
        {
            Person = await PersonDataService.GetPersonByID(Guid.Parse(PersonID));
            
            Activity.CreatorID = Guid.Parse(PersonID);
            await ActivityDataService.CreateActivity(Activity);

         //  Activity.Participants.Add(Person);
         //  await ActivityDataService.UpdateActivity(Activity);

            Calendar = await CalendarDataService.GetCalendarByID(Person.CalendarID);
            Calendar.Activities.Add(Activity);
            await CalendarDataService.UpdateCalendar(Calendar);
        }
    }
}
