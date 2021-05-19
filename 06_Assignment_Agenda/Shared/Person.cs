using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Assignment_Agenda.Shared
{
    public class Person
    {
        [Key]
        public Guid PersonID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Birthday { get; set; }
        public string Email { get; set; }
        public Guid CalendarID { get; set; }
    }
}
