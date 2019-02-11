 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; 

namespace Task1
{
    class Program
    {
        public static void Palindrome() //creating a function "Palindrome" in order to check whether it's palindrom or not (no matter word or number) 
        {
            StreamReader sr = new StreamReader(@"C:\Users\Sabina\pp2\PP2\Week2\input.txt"); // creating the streamreader that can read text from txt files 
            string s = sr.ReadLine();
            bool ch = true;
            for(int i=0; i<s.Length; i++) //cycle from 0 to the string's length ( in our ex it is 4) 
            {
                if(s[i] != s[s.Length - 1 - i]) //compares elements between each other, for ex. 0th element with 3rd etc.
                {
                    ch = false;

                }
            }
            if (ch) // if the func is true, the output will be yes, if no, the output will be no
            {
                Console.WriteLine("Yes");
            }
            else
                Console.WriteLine("No"); 

            sr.Close(); //closes the streamreader

        }
        
        static void Main(string[] args)
        {
            Palindrome();
            Console.ReadKey(); // holds terminal open , until we press any key to do so 

        }
    }
}
