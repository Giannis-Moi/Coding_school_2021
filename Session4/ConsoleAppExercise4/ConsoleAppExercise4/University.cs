using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppExercise4 {
    public class University : Institute {

        public Student[] Students { get; set; }

        public Course[] Courses { get; set; }

        public Grade[] Grades { get; set; }

        public Schedule[] ScheduledCourse { get; set; }


        public University(Guid id, string name, int yearsactive, Student[] students,
            Course[] courses, Grade[] grades, Schedule[] scheduledCourse) : base(id, name, yearsactive) {

            this.Students = students;
            this.Courses = courses;
            this.Grades = grades;
            this.ScheduledCourse = scheduledCourse;

        }

        public void SetScheduledCourse(Course courseid, Person ProfessorId, DateTime datetime) {

        }





    }
}
