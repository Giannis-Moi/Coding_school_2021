using System;

namespace ConsoleAppExercise4 {


    public class Person {


        public Guid Id { get; }

        public string Name { get; set; }

        public int Age { get; }


        public Person(Guid id, string name, int age) {

            this.Id = id;
            this.Name = name;
            this.Age = age;
        }



        public virtual string getName() {
            return Name;
        }


        public void setName(string name) {
            Name = name;

        }









    }



}





