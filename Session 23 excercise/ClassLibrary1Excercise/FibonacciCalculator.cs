using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1Excercise {
    public class FibonacciCalculator : IFibonacciClaculator {
       
        
        
        public long FibonacciSerier(long n) {
           
            if (n == 0) {

                return 0;

            }
            if (n == 1) {
                return 1;
            }
            if (90 > n && n > 1) {
                return FibonacciSerier(n - 1) + FibonacciSerier(n - 2);
            }
            if (n < 0) {
                throw new ArgumentException("Error ");
            }
            else {
                
                throw new ArgumentException("Too big ");
            }
        }
    }
}
