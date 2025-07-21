using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Doctor
    {
        public int id { get; set; }
        public string name { get; set; }
        public string specilaty { get; set; } // Specialty of the doctor
        public List<Appointment> Appointments { get; set; } = new List<Appointment>(); // Navigation property for appointments
    }
}
