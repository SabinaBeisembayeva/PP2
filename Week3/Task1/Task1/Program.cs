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

        public static void far(DirectoryInfo dir, int pos)
        {
            Console.Clear();
            DirectoryInfo[] directories = dir.GetDirectories();
            FileInfo[] files = dir.GetFiles();
            for (int i = 0; i < directories.Length; i++)
            {
                if (i == pos)
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

            ConsoleKeyInfo consoleKey = Console.ReadKey();
            if(consoleKey.Key == ConsoleKey.UpArrow)
            {
                if(pos == 0)
                {
                    far(dir, 0);
                }
                else 
                {
                    far(dir, pos-1);
                }
                
                
            }

            if(consoleKey.Key == ConsoleKey.DownArrow)
            {
                if(pos == directories.Length - 1)
                {
                    far(dir, directories.Length - 1); 
                }
                else
                {
                    far(dir, pos + 1);
                }
                 

            }

        }
        

        static void Main(string[] args)
        {
            DirectoryInfo dir = new DirectoryInfo(@"C:\Users\Sabina\Desktop\PP2");
            far(dir, 3);
            Console.ReadKey();



        }
    }
}
