using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppExercise4 {
    public class Schedule {

        public Guid Id { get; }

        public Guid CourseId { get; set; }

        public Guid ProfessorId { get; set; }

        public DateTime Callendar { get; set; }


        public Schedule(Guid id, Guid courseid, Guid professorid, DateTime callendar) {

            this.Id = id;
            this.CourseId = courseid;
            this.ProfessorId = professorid;
            this.Callendar = callendar;


        }

    }
}
