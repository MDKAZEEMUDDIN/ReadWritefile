using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Textfileread
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filepath = @"..\..\text.txt";
            string file = File.ReadAllText(filepath);
            Console.WriteLine(file);
            //Read all the charecter from the text file
            int count = File.ReadAllText(filepath).Length;
            Console.WriteLine("Total characters are  :" + count);
            
            //It will give the information of file
            FileInfo f = new FileInfo(filepath);
            // Console.WriteLine(file);
            //Name and extention of text file
            string f1 = f.Name;
            string f2 = f.Extension;
            Console.WriteLine("file name: " + f1);
            Console.WriteLine("extension" + f2);
            //It will just split the sentence
            string[] a = file.Split(' ');
            //count of wordtextfile
            int wordCount = 0;
             foreach (string str in a)
            {
                if (str != string.Empty)
                {
                    wordCount = wordCount + 1;
                }
            }
            Console.WriteLine("\n Word Count is : " + wordCount);
            Console.ReadLine();
           // File.Delete(@"..\..\text.txt");
            // copy text file from another folder where you copied
            string file1 = @"..\..\text.txt";
            string destination = @"..\..\textcopy.txt";
            File.Copy(file1, destination, true);
         }
    }
}
