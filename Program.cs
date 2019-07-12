using System;
using System.Collections.Generic;

namespace StudentExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create 4, or more, exercises.
            Exercise exercise1 = new Exercise();
            exercise1.name = "Learn HTML";
            exercise1.language = "HTML";

            Exercise exercise2 = new Exercise();
            exercise2.name = "Learn CSS";
            exercise2.language = "CSS";

            Exercise exercise3 = new Exercise();
            exercise3.name = "Learn JS";
            exercise3.language = "JavaScript";

            Exercise exercise4 = new Exercise();
            exercise4.name = "Learn React";
            exercise4.language = "React";

            // Create 3, or more, cohorts.
            Cohort cohortA = new Cohort();
            cohortA.name = "Day 32";

            Cohort cohortB = new Cohort();
            cohortB.name = "Day 33";

            Cohort cohortC = new Cohort();
            cohortB.name = "Day 34";

            Cohort cohortD = new Cohort();
            cohortD.name = "Evening 9";

            // Create 4, or more, students 
            Student student1 = new Student();
            student1.firstName = "Josh";
            student1.lastName = "Webb";
            student1.slackHandle = "@Josh";

            Student student2 = new Student();
            student2.firstName = "Joe";
            student2.lastName = "Smith";
            student2.slackHandle = "@Joe";

            Student student3 = new Student();
            student3.firstName = "Jane";
            student3.lastName = "Smith";
            student3.slackHandle = "@Jane";

            Student student4 = new Student();
            student4.firstName = "Sally";
            student4.lastName = "Jones";
            student4.slackHandle = "@Sally";

            // and assign students to one of the cohorts.
            cohortA.studentsInCohort.Add(student1);
            cohortB.studentsInCohort.Add(student2);
            cohortC.studentsInCohort.Add(student3);
            cohortD.studentsInCohort.Add(student4);

            // Create 3, or more, instructors 
            Instructor instructor1 = new Instructor();
            instructor1.firstName = "Adam";
            instructor1.lastName = "Schaeffer";
            instructor1.slackHandle = "@Adam";

            Instructor instructor2 = new Instructor();
            instructor2.firstName = "Jisie";
            instructor2.lastName = "David";
            instructor2.slackHandle = "@Jisie";

            Instructor instructor3 = new Instructor();
            instructor3.firstName = "Brenda";
            instructor3.lastName = "Long";
            instructor3.slackHandle = "@Brenda";

            // assign instructor to one of the cohorts.
            cohortA.instructorsInCohort.Add(instructor1);
            cohortB.instructorsInCohort.Add(instructor2);
            cohortC.instructorsInCohort.Add(instructor3);

            // Have each instructor assign 2 exercises to each of the students.
            instructor1.assignExercise(student1, exercise1);
            instructor1.assignExercise(student1, exercise2);

            instructor2.assignExercise(student2, exercise3);
            instructor2.assignExercise(student2, exercise4);

            instructor3.assignExercise(student3, exercise1);
            instructor3.assignExercise(student3, exercise4);

            // Create a list of students. Add all of the student instances to it.
            List<Student> students = new List<Student>();
            students.Add(student1);
            students.Add(student2);
            students.Add(student3);
            students.Add(student4);


            // Create a list of exercises. Add all of the exercise instances to it.
            List<Exercise> exercises = new List<Exercise>();
            exercises.Add(exercise1);
            exercises.Add(exercise2);
            exercises.Add(exercise3);
            exercises.Add(exercise4);

            // Generate a report that displays which students are working on which exercises.

            foreach (Student student in students)
            {

                foreach (Exercise exercise in student.currentExercises)
                {
                    Console.WriteLine($"{student.firstName} is working on {exercise.name}");
                }
            }

        }
    }
}
