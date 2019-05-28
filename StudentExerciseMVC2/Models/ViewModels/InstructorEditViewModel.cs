using Microsoft.AspNetCore.Mvc.Rendering;
using StudentExercisesMVC2.Models;
using StudentExercisesMVC2.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentExercisesMVC2.Models.ViewModels
{
    public class InstructorEditViewModel
    {
        // A single student
        public Instructor Instructor { get; set; }

        // All cohorts
        public List<SelectListItem> Cohorts;

        public InstructorEditViewModel() { }
        public InstructorEditViewModel(int id)
        {
            Instructor = InstructorRepository.GetInstructor(id);
            BuildCohortOptions();
        }

        public void BuildCohortOptions()
        {
            Cohorts = CohortRepository.GetCohorts()
                .Select(li => new SelectListItem
                {
                    Text = li.Name,
                    Value = li.Id.ToString()
                }).ToList();

            Cohorts.Insert(0, new SelectListItem
            {
                Text = "Choose cohort...",
                Value = "0"
            });

        }
    }
}