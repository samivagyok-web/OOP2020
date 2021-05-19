using _06_Assignment_Agenda.Client.Services.PersonData;
using _06_Assignment_Agenda.Shared;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _06_Assignment_Agenda.Client.Pages
{
    public partial class CreatePerson
    {
        [Inject]
        public IPersonDataService PersonDataService { get; set; }

        [Inject]
        public NavigationManager NavigationManager { get; set; }

        public Person Person { get; set; } = new Person { PersonID = Guid.NewGuid(), CalendarID = default(Guid)};

        private async Task HandleValidSubmit()
        {
            await PersonDataService.AddPerson(Person);
            NavigationManager.NavigateTo("/peoplelist");
        }
    }
}
