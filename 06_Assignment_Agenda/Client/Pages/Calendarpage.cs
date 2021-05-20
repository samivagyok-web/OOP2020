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

        public IEnumerable<Person> People { get; set; }

        public IEnumerable<Activity> Activities { get; set; }

        public Calendar Calendar { get; set; }

        public bool TimeFrameShow { get; set; }

        public TimeInterval Time { get; set; }

        private void TimeFrameToggle()
        {
            
            TimeFrameShow = !TimeFrameShow;
        }

        protected async override Task OnInitializedAsync()
        {
            Time = new();
            Calendar = await CalendarDataService.GetCalendarByID(Guid.Parse(CalendarID));
            Activities = (await ActivityDataService.GetEveryActivity()).Where(p => p.CreatorID == Calendar.PersonID);
            Activities.OrderBy(p => p.StartTime);
            People = (await PersonDataService.GetEveryPerson());
        }

        private string GetHostName(Guid ID)
        {
            var host = People.Single(p => p.PersonID == ID);

            return host.FirstName + " " + host.LastName;
        }

        private async Task SearchByInterval()
        {
            Activities = (await ActivityDataService.GetEveryActivity()).Where(p => p.StartTime >= Time.IntervalStart 
                                    && p.FinishTime <= Time.IntervalFinish).
                                            OrderBy(p => p.StartTime);
            StateHasChanged();
        }

        private async Task SearchActivity(ChangeEventArgs eventArgs)
        {
            string searchTerm = eventArgs.Value.ToString();

            Activities = (await ActivityDataService.GetEveryActivity()).
                Where(p => p.Name.StartsWith(searchTerm, StringComparison.OrdinalIgnoreCase)).
                OrderBy(p => p.StartTime);            
            StateHasChanged();
        }

        public class TimeInterval
        {
            public DateTime IntervalStart { get; set; }

            public DateTime IntervalFinish { get; set; }
        }
    }
}
