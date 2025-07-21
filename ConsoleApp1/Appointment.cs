using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Appointment
    {
        public int id { get; set; }
        public DateTime date { get; set; }
        public string time { get; set; }
        public int doctorId { get; set; }
        public Doctor doctor { get; set; } // Navigation property to Doctor
        public string patientName { get; set; }
        public string patientPhone { get; set; }
        public string patientEmail { get; set; }
        public string status { get; set; } // e.g., "Scheduled", "Completed", "Cancelled"
    }
}
