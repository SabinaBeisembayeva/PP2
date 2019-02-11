using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task3
{
    class Program
    {
        public static void PrintSpaces(int a)
        {
            for(int i=0;i<a; i++)
            {
                Console.Write(" ");
            }
        
        }
        public static void Directory(DirectoryInfo direct, int n)
        {
            FileInfo[] files = direct.GetFiles();
            DirectoryInfo[] directories = direct.GetDirectories();

            foreach(FileInfo file in files)
            {
                PrintSpaces(n);
                Console.WriteLine(file.Name);
            }

            foreach(DirectoryInfo dir in directories)
            {
                PrintSpaces(n);
                Console.WriteLine(dir.Name);
                Directory(dir, n + 1);
            }
        }

        static void Main(string[] args)
        {
            DirectoryInfo dir = new DirectoryInfo(@"C:\Users\Sabina\pp2\PP2");
            Directory(dir, 1);
            Console.ReadKey();

        }
    }
}
