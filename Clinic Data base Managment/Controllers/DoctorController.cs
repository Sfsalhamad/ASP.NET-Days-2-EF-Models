using Clinic_Data_base_Managment.Models;
using Clinic_Data_base_Managment.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace Clinic_Data_base_Managment.Controllers
{
    public class DoctorController : Controller
    {
        public IActionResult Index()
        {
            var doctors = Doctor.Doctors.Select(d => new DoctorVM
            {
                id = d.id,
                name = d.name,
                specilaty = d.specilaty,
                description = d.description
            }).ToList();
            return View(doctors);
        }

        public IActionResult Details(int id)
        {
            var doctor = Doctor.Doctors.FirstOrDefault(d => d.id == id);
            if (doctor == null)
            {
                return NotFound();
            }

            var doctorVM = new DoctorVM
            {
                id = doctor.id,
                name = doctor.name,
                specilaty = doctor.specilaty,
                description = doctor.description
            };
            return View(doctorVM);
        }

        public IActionResult Create()
        {
            return View(new DoctorVM());
        }

        [HttpPost]
        public IActionResult Create(DoctorVM doctorVM)
        {
            if (!ModelState.IsValid)
            {
                return View(doctorVM);
            }

            var doctor = new Doctor
            {
                id = doctorVM.id,
                name = doctorVM.name,
                specilaty = doctorVM.specilaty,
                description = doctorVM.description
            };

            Doctor.Doctors.Add(doctor);
            return RedirectToAction(nameof(Index));
        }
    }
}

