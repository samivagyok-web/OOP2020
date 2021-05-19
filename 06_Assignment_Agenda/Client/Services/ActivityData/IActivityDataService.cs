using _06_Assignment_Agenda.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _06_Assignment_Agenda.Client.Services.ActivityData
{
    public interface IActivityDataService
    {
        Task<IEnumerable<Activity>> GetEveryActivity();
        Task<Activity> GetActivityByID(Guid id);
        Task<Activity> CreateActivity(Activity activity);
        Task UpdateActivity(Activity activity);
        Task DeleteActivity(Guid id);
    }
}
