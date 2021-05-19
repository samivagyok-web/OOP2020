using _06_Assignment_Agenda.Server.Data;
using _06_Assignment_Agenda.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _06_Assignment_Agenda.Server.Models.ActivityRepository
{
    public class ActivityRepo : IActivityRepo
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public ActivityRepo(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public Activity CreateActivity(Activity activity)
        {
            _applicationDbContext.Activities.Add(activity);
            _applicationDbContext.SaveChanges();

            return activity;
        }

        public void DeleteActivity(Guid id)
        {
            var activityToDelete = _applicationDbContext.Activities.FirstOrDefault(p => p.ActivityID == id);

            if (activityToDelete == null) return;

            _applicationDbContext.Activities.Remove(activityToDelete);
            _applicationDbContext.SaveChanges();
        }

        public Activity GetActivityByID(Guid id)
        {
            return _applicationDbContext.Activities.FirstOrDefault(p => p.ActivityID == id);
        }

        public IEnumerable<Activity> GetEveryActivity()
        {
            return _applicationDbContext.Activities;
        }

        public Activity UpdateActivity(Activity activity)
        {
            var activityToUpdate = _applicationDbContext.Activities.FirstOrDefault(p => p.ActivityID == activity.ActivityID);

            if (activityToUpdate == null) return null;

            activityToUpdate.ActivityID = activity.ActivityID;
            activityToUpdate.CreatorID = activity.CreatorID;
            activityToUpdate.Description = activity.Description;
            activityToUpdate.FinishTime = activity.FinishTime;
            activityToUpdate.Name = activity.Name;
         //   activityToUpdate.Participants = activity.Participants;
            activityToUpdate.StartTime = activity.StartTime;

            _applicationDbContext.SaveChanges();

            return activityToUpdate;
        }
    }
}
