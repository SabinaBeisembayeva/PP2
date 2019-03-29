using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;



namespace task1
{

    class Program
    {

        static int Factorial(int n)
        {
            int fac = 1;
            while (n > 0)
            {
                Console.WriteLine("Counting factorial");
                fac *= n;
                n--;
                

            }
            return fac; 
        }

        static int Sum(int n)
        {
            int sum = 0;
            for(int i=1; i<=n; i++)
            {
                Console.WriteLine("Counting the sum");
                sum += i;
                
            }
            return sum;


        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var taskFac = Task.Factory.StartNew<int>(() => Factorial(n));
            var taskSum = Task.Factory.StartNew<int>(() => Sum(n));


            Task.WaitAll(taskFac, taskSum);

            

            Console.WriteLine("Sum {0} is {1}", n, taskFac.Result); 

            Console.WriteLine("Factorial {0} is {1}", n, taskSum.Result);

            Console.ReadKey();





        }
    }
}
 