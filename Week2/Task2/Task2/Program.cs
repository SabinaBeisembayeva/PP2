using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task2
{
    class Program
    {
        public static bool IsPrime(int n) //creating a function to check the prime 
        {
            if (n == 1) return false; // if the number is 1, it is not a prime
            if (n == 0) return false; // similarly with 0

            
            for(int i=2; i<n; i++) // entering a cycle , starting from the smallest prime number = 2
            {
                if (n % i == 0) return false; 
            }
            return true; 


        }

       

     static void Main(string[] args) // main func
        {
            StreamReader sr = new StreamReader(@"C:\Users\Sabina\pp2\PP2\Week2\Task2\Task2\input.txt"); // streamreader reads text from txt files
            string[] s = sr.ReadToEnd().Split(); // creating the string and read all elements in the txt to the end and split them into substrings
            StreamWriter sw = new StreamWriter(@"C:\Users\Sabina\pp2\PP2\Week2\Task2\Task2\output.txt"); // streamwriter writes elements into a text files
            for(int i=0; i<s.Length; i++)
            {
                if (IsPrime(int.Parse(s[i])))
                {
                    sw.Write(s[i] + " "); // if the numbers are prime, vyvodym them in output txt file 
                }
                
            }
            sw.Close(); // closes StreamReader 



        }

        
    }
}
