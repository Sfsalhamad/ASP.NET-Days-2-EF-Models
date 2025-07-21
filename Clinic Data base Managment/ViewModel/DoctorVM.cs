namespace Clinic_Data_base_Managment.ViewModel
{
    public class DoctorVM
    {
        public int id { get; set; }
        public string name { get; set; }
        public string specilaty { get; set; }
        public string description { get; set; }
        public static List<DoctorVM> Doctors = new List<DoctorVM>
                {
                    new DoctorVM
                    {
                        id = 0,
                        name = "Dr. John Doe",
                        specilaty = "General Medicine",
                        description = "Experienced general practitioner with over 10 years in the field."
                    },
                    new DoctorVM
                    {
                        id = 1,
                        name = "Dr. Jane Smith",
                        specilaty = "Pediatrics",
                        description = "Specialist in child health and development."
                    },
                    new DoctorVM
                    {
                        id = 2,
                        name = "Dr. Emily Brown",
                        specilaty = "Cardiology",
                        description = "Expert in heart diseases and cardiovascular care."
                    },
                    new DoctorVM
                    {
                        id = 3,
                        name = "Dr. Michael Green",
                        specilaty = "Dermatology",
                        description = "Experienced in treating skin conditions and allergies."
                    },
                    new DoctorVM
                    {
                        id = 4,
                        name = "Dr. Sarah Lee",
                        specilaty = "Orthopedics",
                        description = "Specialist in bone and joint disorders."
                    }
                };
    }
}
