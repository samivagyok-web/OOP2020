using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Assignment_Agenda.Shared
{
    public class Calendar
    {
        [Key]
        public Guid CalendarID { get; set; }
        public Guid PersonID { get; set; }
        public List<Activity> Activities { get; set; } = new();
    }
}