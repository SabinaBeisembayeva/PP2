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
        public static bool IsPrime(int n)
        {
            if (n == 1) return false;
            if (n == 0) return false;

            
            for(int i=2; i<n; i++)
            {
                if (n % i == 0) return false;
            }
            return true; 


        }

       

     static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(@"C:\Users\Sabina\pp2\PP2\Week2\Task2\Task2\input.txt");
            string[] s = sr.ReadToEnd().Split();
            StreamWriter sw = new StreamWriter(@"C:\Users\Sabina\pp2\PP2\Week2\Task2\Task2\output.txt");
            for(int i=0; i<s.Length; i++)
            {
                if (IsPrime(int.Parse(s[i])))
                {
                    sw.Write(s[i] + " ");
                }
                
            }
            sw.Close();



        }

        
    }
}
