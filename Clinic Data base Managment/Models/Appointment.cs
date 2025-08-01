using Clinic_Data_base_Managment.ViewModel;

namespace Clinic_Data_base_Managment.Models
{
    public class Appointment
    {
        public int id { get; set; }
        public string patientName { get; set; }
        public string doctorName { get; set; }
        public DateTime appointmentDate { get; set; }

        public AppointmentVM ToAppointmentVM()
        {
            return new AppointmentVM
            {
                id = this.id,
                appointmentDate = this.appointmentDate,
                doctorName = this.doctorName,
                patientName = this.patientName
            };
        }
    }
}
