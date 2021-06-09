using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppExercise4 {
    public class Course {

        public Guid Id { get; }

        public string Code { get; set; }

        public string Subject { get; set; }


        public Course(Guid id, string code, string subject) {

            this.Id = id;
            this.Code = code;
            this.Subject = subject;



        }

    }
}
