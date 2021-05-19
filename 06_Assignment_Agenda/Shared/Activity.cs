using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Assignment_Agenda.Shared
{
    public class Activity
    {
        [Key]
        public Guid ActivityID { get; set; }
        public Guid CreatorID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime FinishTime { get; set; }
     //   public List<Person> Participants { get; set; } = new List<Person>();
    }
}
