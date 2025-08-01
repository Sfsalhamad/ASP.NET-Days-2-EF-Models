using Clinic_Data_base_Managment.Models;

namespace Clinic_Data_base_Managment.ViewModel
{
    public class UpdateVM
    {
        public int id { get; set; }
        public string name { get; set; }
        public string specilaty { get; set; }
        public string description { get; set; }
        public void UpdateDoctorVM(Doctor doctor)
        {
            doctor.id = id;
            doctor.name = name;
            doctor.specilaty = specilaty;
            doctor.description = description;


        }

    }

   



    }

