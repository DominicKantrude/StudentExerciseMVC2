using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using StudentExercisesMVC2.Models;
using StudentExercisesMVC2.Models.ViewModels;
using StudentExercisesMVC2.Repositories;

namespace StudentExerciseMVC2.Controllers
{
    public class ExerciseController : Controller
    {

        private readonly IConfiguration _config;

        public ExerciseController(IConfiguration config)
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

        // GET: Student
        public ActionResult Index()
        {
            List<Exercise> exercises = ExerciseRepository.GetExercises();
            return View(exercises);
        }

        public ActionResult Details(int id)
        {
            Exercise exercise = ExerciseRepository.GetExercise(id);
            return View(exercise);
        }

        public ActionResult Create()
        {
            Exercise exerciseModel = new Exercise();
            return View(exerciseModel);
        }

        // POST: Students/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([FromForm] Exercise exerciseModel)
        {
            ExerciseRepository.CreateExercise(exerciseModel);
            return RedirectToAction(nameof(Index));
        }

        // GET: Student/Edit/5
        public ActionResult Edit(int id)
        {
                Exercise exercise = ExerciseRepository.GetExercise(id);
                return View(exercise);
            
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, [FromForm] Exercise exercise)
        {
        ExerciseRepository.UpdateExercise(id, exercise);
        return RedirectToAction(nameof(Index));
    }

        // GET: Students/Delete/5
        public ActionResult Delete(int id)
        {
            Exercise exercise = ExerciseRepository.GetExercise(id);
            return View(exercise);
        }

        // POST: Students/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
        ExerciseRepository.DeleteExercise(id);
        return RedirectToAction(nameof(Index));
    }
    }
}