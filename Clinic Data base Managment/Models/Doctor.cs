
using Clinic_Data_base_Managment.ViewModel;

namespace Clinic_Data_base_Managment.Models
{
    public class Doctor
    {
        public int id { get; set; }
        public string name { get; set; }
        public string specilaty { get; set; }
        public string description { get; set; }
        public List<Appointment> Appointments { get; set; } = new();






        public static List<Doctor> Doctors = new List<Doctor>
                {
                    new Doctor
                    {
                        id = 0,
                        name = "Dr. John Doe",
                        specilaty = "General Medicine",
                        description = "Experienced general practitioner with over 10 years in the field."
                    },
                    new Doctor
                    {
                        id = 1,
                        name = "Dr. Jane Smith",
                        specilaty = "Pediatrics",
                        description = "Specialist in child health and development."
                    },
                    new Doctor
                    {
                        id = 2,
                        name = "Dr. Emily Brown",
                        specilaty = "Cardiology",
                        description = "Expert in heart diseases and cardiovascular care."
                    },
                    new Doctor
                    {
                        id = 3,
                        name = "Dr. Michael Green",
                        specilaty = "Dermatology",
                        description = "Experienced in treating skin conditions and allergies."
                    },
                    new Doctor
                    {
                        id = 4,
                        name = "Dr. Sarah Lee",
                        specilaty = "Orthopedics",
                        description = "Specialist in bone and joint disorders."
                    }
                };

        public UpdateVM ToUpdateVM()
        {
            return new UpdateVM
            {
                id = this.id,
                name = this.name,
                specilaty = this.specilaty,
                description = this.description
            };
        }
        public DoctorVM ToDoctorVM()
        {
            return new DoctorVM
            {
                id = this.id,
                name = this.name,
                specilaty = this.specilaty,
                description = this.description,
                Appointments = this.Appointments.Select(a => a.ToAppointmentVM()).ToList()
            };
        }
        // The code you provided is missing a closing brace for the namespace.
        // Add a closing brace at the end of the file to fix CS1513.

    }
}

