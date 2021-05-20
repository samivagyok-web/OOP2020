using _06_Assignment_Agenda.Client.Services.ActivityData;
using _06_Assignment_Agenda.Client.Services.PersonData;
using _06_Assignment_Agenda.Shared;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _06_Assignment_Agenda.Client.Pages
{
    public partial class ActivityDetails
    {
        [Parameter]
        public string CalendarID { get; set; }

        [Parameter]
        public string ActivityID { get; set; }

        [Inject]
        public IActivityDataService ActivityDataService { get; set; }

        [Inject]
        public IPersonDataService PersonDataService { get; set; }

        [Inject]
        public NavigationManager NavigationManager { get; set; }

        public Activity Activity { get; set; }

        public string Host { get; set; }

        protected async override Task OnInitializedAsync()
        {
            Activity = (await ActivityDataService.GetActivityByID(Guid.Parse(ActivityID)));
            Person p = await PersonDataService.GetPersonByID(Activity.CreatorID);
            Host = p.FirstName + " " + p.LastName;
        }

        private async Task DeleteActivity()
        {
            await ActivityDataService.DeleteActivity(Guid.Parse(ActivityID));
            NavigationManager.NavigateTo($"/calendar/{CalendarID}");
        }
    }
}
