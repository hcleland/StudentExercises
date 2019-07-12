using System;
using System.Collections.Generic;

namespace StudentExercises
{
    public class Instructor
    {
        // ----------- Private Properties ------------

        // -------- Public Properties ----------------
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string slackHandle { get; set; }
        public string cohortTeaching { get; set; }
        public string speciality { get; set; }

        // -------- Constructor ----------------------

        // ------- METHODS --------------------------- 
        public void assignExercise(Student student, Exercise exercise)
        {
            student.currentExercises.Add(exercise);
        }
    }
}