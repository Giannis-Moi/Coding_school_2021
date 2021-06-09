using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppExercise4 {
    public class Institute {

        public Guid Id { get; }

        public string Name { get; set; }

        public int YearsInService { get; }



        public Institute(Guid id, string name, int yearsactive) {

            this.Id = id;
            this.Name = name;
            this.YearsInService = yearsactive;

        }

        public string getName() {
            return Name;
        }


        public void setName(string name) {
            Name = name;

        }

    }
}
