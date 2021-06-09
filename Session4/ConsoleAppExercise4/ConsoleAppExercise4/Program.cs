using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppExercise4 {
    class Program {
        static void Main(string[] args) {




            //string guid = Guid.NewGuid().ToString();

            var newPerson = new Person(Guid.Empty, "Giannis ", 20);

            Console.WriteLine(newPerson.Name);
            Console.ReadLine();




            //Question 1
            //        int num;
            //        DectobinClass var1 = new DectobinClass();
            //        Console.WriteLine("Convert a decimal number to binary :");

            //        Console.Write(" Input number : ");
            //        num = int.Parse(Console.ReadLine());
            //        Console.Write(" The binary of {0} is : ", num);
            //        var1.deciToBinary(num);
            //        Console.ReadLine();

            //    }
            //}
            //public class DectobinClass {
            //    public int deciToBinary(int num) {
            //        int bin;
            //        if (num != 0) {
            //            bin = (num % 2) + 10 * deciToBinary(num / 2);
            //            Console.Write(bin);
            //            return 0;
            //        }
            //        else {
            //            return 0;
            //        }





        }
    }
}
