using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); // creating a variable of how much int an array will contain
            string s = Console.ReadLine(); 
            string[] arr = s.Split(); //making an array and break the string s into an elements of an array
            int cnt = 0; // making a new variable for counting prime numbers
            for (int i = 0; i < n; i++)
            {
                int c = int.Parse(arr[i]); //converting elements of an array to integers
                if (Prime(c) == true) // checking the number
                {
                    cnt++; // if true then the count is increasing 
                }

            }
            Console.WriteLine(cnt); //output the number that we have counted 

            for (int i = 0; i < n; i++)
            {
                int c = int.Parse(arr[i]);
                if (Prime(c) == true)
                {
                    Console.Write(c + " "); // here we output an elements of an array that are prime with backspaces 
                }
            }
            Console.ReadKey(); // for not to close immediatly after the start
        }


            public static bool Prime(int a) { // creating boolean function

              bool ch = true;
                if(a == 1) // prime numbers start with 2
                {
                    ch = false;
                }

                for (int i = 2; i < a; i++) //we checking it here
                {

                    if (a % i == 0)
                    {
                        ch = false;
                    }

                }

            return ch;    
                    
             }




        }
    }

