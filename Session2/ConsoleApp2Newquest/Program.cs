using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2Newquest {
    class Program {
        public static object sum { get; private set; }
        public static int div { get; private set; }

        static void Main(string[] args) {
            #region Question 1
            Console.WriteLine("Hello, my name is Giannis");
            //Console.ReadLine();
            #endregion

            #region Question 2
            Console.WriteLine(8 + 4);
            Console.WriteLine(8 / 4);
            //Console.ReadLine();
            #endregion

            #region Question 3
            int Mynumb = -1 + 5 * 6;
            int Mynumb2 = 38 + 5 % 7;
            int Mynumb3 = 14 + (-3 * 6) / 7;
            double Mynumb4 = 2 + (13 / 6) * 6 + Math.Sqrt(7);
            double Mynumb5 = Math.Pow(6, 4) + Math.Pow(5, 7) / (9 % 4);
            string Mystring = "The result of the exprection is: ";
            
            Console.WriteLine(Mystring + Mynumb);
            Console.WriteLine(Mystring + Mynumb2);
            Console.WriteLine(Mystring + Mynumb3);
            Console.WriteLine(Mystring + Mynumb4);
            Console.WriteLine(Mystring + Mynumb5);
            //Console.ReadLine();
            #endregion

            #region Question 4
            int num1, num2, num3;

            Console.Write("Input the first number to multiply: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input the second number to multiply: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input the third number to multiply: ");
            num3 = Convert.ToInt32(Console.ReadLine());

            int result = num1 * num2 * num3;
            Console.WriteLine("Output: {0} x {1} x {2} = {3}",
                                num1, num2, num3, result);
            Console.ReadLine();
            #endregion

            #region Question 5
            double number1, number2, number3, number4, number5;

            Console.Write("Enter the First number: ");
            number1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the Second number: ");
            number2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the third number: ");
            number3 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the fourth number: ");
            number4 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the fifth number: ");
            number5 = Convert.ToDouble(Console.ReadLine());

            double result2 = (number1 + number2 + number3 + number4 + number5) / 5;
            Console.WriteLine("The average of {0}, {1}, {2}, {3}, {4} is: {5} ",
         number1, number2, number3, number4, result2);
            Console.ReadLine();
            #endregion


            #region Question 6
            string Mygender = "female";
            int Myage = 20;
            string mystring2 = "You are " + Mygender;
            string mystring3 = "and look younger than " + Myage;
            Console.WriteLine(mystring2 + mystring3);
            Console.ReadLine();
            #endregion



            #region Question 7
            int mins1, hours2, days3, years4;

            Console.Write("Input the first number to convert: ");
            mins1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(mins1 / 60);
            //Console.ReadLine();


            Console.Write("Input the second number to convert: ");
            hours2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(hours2 / 3600);
            //Console.ReadLine();

            Console.Write("Input the second number to convert: ");
            days3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(days3 / (24 * 3600));
            // Console.ReadLine();

            Console.Write("Input the second number to convert: ");
            years4 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(years4 / (12 * 24 * 3600));
            Console.ReadLine();
            #endregion

            #region Question 9

            Console.Write("Enter the amount of Celsius: ");
            int celsius = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Kelvin = {0}", celsius + 273);
            Console.WriteLine("Fahrenheit = {0}", celsius * 18 / 10 + 32);
            Console.ReadLine();
            #endregion

            #region Question 10
            string text1 = "Smart phone";
            Console.WriteLine(text1);

            Console.Write("Input text: ");
            string userinput = Console.ReadLine();
            string newText = userinput.Replace("a", "");

            Console.WriteLine(newText);
            Console.ReadLine();
            #endregion
        }
    }



}


