using _06_Assignment_Agenda.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _06_Assignment_Agenda.Server.Models.ActivityRepository
{
    public interface IActivityRepo
    {
        Activity GetActivityByID(Guid id);
        IEnumerable<Activity> GetEveryActivity();
        Activity CreateActivity(Activity activity);
        Activity UpdateActivity(Activity activity);
        void DeleteActivity(Guid id);
    }
}
