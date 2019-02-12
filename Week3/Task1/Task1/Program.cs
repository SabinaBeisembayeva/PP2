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
        

        static void Main(string[] args)
        {
            DirectoryInfo dir = new DirectoryInfo(@"C:\Users\Sabina\Desktop\PP2");
            DirectoryInfo[] directories = dir.GetDirectories();
            for (int i = 0; i < directories.Length; i ++)
            {
               
                if(i==0)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    
                }

                else
                {
                    Console.BackgroundColor = ConsoleColor.Green;
                }

                DirectoryInfo dir2 = directories[i];
                Console.WriteLine(dir2.Name);




            }

            Console.ReadKey();


        }
    }
}
