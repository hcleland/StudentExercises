using System;
using System.Collections.Generic;

namespace StudentExercises
{
    public class Student
    {
        // ----------- Private Properties ------------

        // -------- Public Properties ----------------
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string slackHandle { get; set; }
        public string studentCohort { get; set; }
        public List<Exercise> currentExercises { get; set; } = new List<Exercise>();

        // -------- Constructor ----------------------

        // ------- METHODS --------------------------- 
    }
}