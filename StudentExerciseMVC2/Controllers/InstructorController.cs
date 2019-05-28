using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using StudentExercisesMVC2.Models;
using StudentExercisesMVC2.Models.ViewModels;
using StudentExercisesMVC2.Repositories;

namespace StudentExerciseMVC2.Controllers
{
    public class InstructorController : Controller
    {

        private readonly IConfiguration _config;

        public InstructorController(IConfiguration config)
        {
            _config = config;
        }

        public SqlConnection Connection
        {
            get
            {
                return new SqlConnection(_config.GetConnectionString("DefaultConnection"));
            }
        }

        // GET: Instructor
        public ActionResult Index()
        {
            var instructors = InstructorRepository.GetInstructors();
            return View(instructors);
        }

        // GET: Instructor/Details/5
        public ActionResult Details(int id)
        {
            Instructor instructor = InstructorRepository.GetInstructor(id);
                    return View(instructor);
              
        }

        public ActionResult Create()
        {
            InstructorCreateViewModel model = new InstructorCreateViewModel(Connection);
            return View(model);
        }

     
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([FromForm] InstructorCreateViewModel model)
        {
            var instructor = InstructorRepository.CreateInstructor(model.Instructor);
            return RedirectToAction(nameof(Index));
        }


        public ActionResult Edit(int id)
        {
            var model = new InstructorEditViewModel(id);
            return View(model);
        }

        // POST: Students/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, InstructorEditViewModel model)
        {
            try
            {
                model.Instructor.Id = id;
                InstructorRepository.UpdateInstructor(model.Instructor);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception)
            {
                return View(model);
            }
        }

        public ActionResult DeleteConfirm(int id)
        {
            var instructor = InstructorRepository.GetInstructor(id);
            return View(instructor);
        }

        // POST: Students/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete([FromForm] int id)
        {
            if (InstructorRepository.DeleteInstructor(id))
            {
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return RedirectToAction(nameof(Details), new { id = id });
            }
        }
    }
}