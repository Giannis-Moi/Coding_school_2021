using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppExercise4 {
    public class Grade {

        public Guid Id { get; }

        public Guid StudentId { get; }

        public Guid courseId { get; }

        public int GradeValue { get; }


        public Grade(Guid id, Guid studentId, Guid courseId, int GradeValue) {

            this.Id = id;
            this.StudentId = studentId;
            this.courseId = courseId;

        }
    }
}
