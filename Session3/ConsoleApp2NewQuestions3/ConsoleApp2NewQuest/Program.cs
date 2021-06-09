using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2NewQuest {
    class Program {
        static void Main(string[] args) {

            //  Question 1

            //string line = "lorem ipsum dolor sit amet consectetur adipiscing elit";
            //string[] words = line.Split(new[] { " " }, StringSplitOptions.None);
            //string word = "";
            //int ctr2 = 0;

            //foreach (String str1 in words) {
            //    if (str1.Length > ctr2) {
            //        word = str1;
            //        ctr2 = str1.Length;

            //    }

            //}

            //Console.WriteLine(word.ToUpper());
            //Console.ReadLine();



            //Question 2

            //string str = "lorem ipsum dolor sit amet consectetur adipiscing elit";
            //string reverse = "";
            //int length = str.Length - 1;

            //while (length >= 0) {
            //    reverse += str[length];
            //    length--;
            //}

            //Console.WriteLine(reverse);
            //Console.ReadLine();


            //     Question 3

            //Console.WriteLine("Input a value n");
            //string number = Console.ReadLine();
            //int n = Convert.ToInt32(number);

            //Console.WriteLine("calculate factorial or sum? ");
            //Console.WriteLine("Enter F or S. ");
            //string choose = Console.ReadLine();

            //int result = 1;

            //if (choose == "f" || choose == "F") {
            //    result = 1;
            //    for (int i = n; i >= 1; i--)
            //        result *= i;
            //}
            //else if (choose == "s" || choose == "S") {
            //    result = 0;
            //    for (int i = n; i >= 1; i--)
            //        result += i;
            //}

            //Console.WriteLine(result);
            

            //Console.ReadLine();




            //   Question 4

            //int n, i, p, k;

            //Console.Write("Enter a number:");
            //n = Convert.ToInt32(Console.ReadLine());

            //for (i = 2; i <= n; i++) {
            //    k = 2;
            //    p = 1;
            //    while (k < i) {
            //        if (i % k == 0) {
            //            p = 0;
            //            break;
            //        }
            //        k++;
            //    }
            //    if (p == 1) {
            //        Console.WriteLine("Number is prime:" + i);
            //        Console.ReadLine();

            //    }


            //}

            //          Question 5

            //int[] firstArray = { 2, 4, 9, 12 };
            //int[] secondArray = { 1, 3, 7, 10 };

            //int[] thirdArray = new int[firstArray.Length * secondArray.Length];
            //for (int i = 0; i < firstArray.Length; i++)
            //    for (int j = 0; j < secondArray.Length; j++) {
            //        thirdArray[i * firstArray.Length + j] = firstArray[i] * secondArray[j];
            //        Console.WriteLine(thirdArray[i * firstArray.Length + j]);
            //        Console.ReadLine();
            //    }






            //                       Question 6

            //    int[] array1 = new int[] { 0, -2, 1, 20, -31, 50, -4, 17, 89, 100};

            //        Array.Sort(array1);

            //        foreach (int value in array1) {
            //        Console.Write(value + " ");
            //        Console.ReadLine();

            //    }
            //}



        }
    }
}