using System;
using System.Collections.Generic;

namespace StudentExercises
{
    public class Cohort
    {
        // ----------- Private Properties ------------

        // -------- Public Properties ----------------
        public string name { get; set; }
        public List<Student> studentsInCohort { get; set; } = new List<Student>();
        public List<Instructor> instructorsInCohort { get; set; } = new List<Instructor>();

        // -------- Constructor ----------------------

        // ------- METHODS --------------------------- 
        // public void assignStudentToCohort(Cohort cohort, Student student)
        // {
        //     cohort.studentsInCohort.Add(student);
        // }
    }
}