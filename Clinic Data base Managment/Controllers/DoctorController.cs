using Clinic_Data_base_Managment.Models;
using Clinic_Data_base_Managment.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;



namespace Clinic_Data_base_Managment.Controllers
{
    [Authorize]
    public class DoctorController : Controller
    {
        // Assuming you have a DbContext or similar to interact with your data source
        public ClintContext Context;
        public DoctorServices DoctorServices;
        public AnotherService AnotherService;
        public DoctorController(ClintContext context, DoctorServices doctorServices, AnotherService anotherService)
        {
            Context = context;
            DoctorServices = doctorServices;
            AnotherService = anotherService;
        }
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
            var doctor = Context.Doctors.Include(p => p.Appointments).FirstOrDefault(p => p.id == id);
            if (doctor == null)
            {
                return NotFound();
            }

            var vm = doctor.ToDoctorVM();
            return View(vm);
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
        public IActionResult Update(int id)
        {
            var doctor = Doctor.Doctors.FirstOrDefault(p => p.id == id);
            if (doctor == null)
            {
                return NotFound();
            }
            var updateVM = doctor.ToUpdateVM();
            return View(updateVM);


        }




        [HttpPost]
        public IActionResult Update(int id, UpdateVM updatevm)
        {
            if (!ModelState.IsValid)
            {
                return View(updatevm);
            }

            var doctor = Doctor.Doctors.FirstOrDefault(p => p.id == id);
            if (doctor == null)
            {
                return NotFound();
            }

            // Update the doctor's properties
            doctor.name = updatevm.name;
            doctor.specilaty = updatevm.specilaty;
            doctor.description = updatevm.description;

            // Redirect to Index after successful update
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Delete(int id)
        {
            var doctor = Doctor.Doctors.FirstOrDefault(p => p.id == id);
            if (doctor == null)
            {
                return NotFound();
            }
            return View(doctor);
        }
    }
}

