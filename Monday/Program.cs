using System;
using System.IO;

namespace Monday
{
    class Program
    {
        private static object directory;

        static void Main(string[] args)
        {
            string rootpath = @"C:\Users\opilane\samples";
            Getdirectories(rootpath);
            Getfiles(rootpath);
        }
        public static void Getdirectories(string path)
        {
            string[] alldirectories = Directory.GetDirectories(path, "*.*", SearchOption.AllDirectories);
            string filepath = @"C:\Users\opilane\Monday\directoriesdata.txt";
            File.WriteAllLines(filepath, alldirectories);

        }
        public static void Getfiles(string path)
        {
            string[] allfiles = Directory.GetFiles(path, "*.*", SearchOption.AllDirectories);
            string filepath = @"C:\Users\opilane\Monday\Filedata.txt";
            File.WriteAllLines(filepath, allfiles);
        }
    }
}
