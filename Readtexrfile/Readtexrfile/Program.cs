using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data;

    internal class Program
    {
        static void Main(string[] args)
        {
            string filepath = @"C:\ReadWriteFile\Readwrite.txt";
            string file = File.ReadAllText(filepath);
            Console.WriteLine(file);

            //Read all the charecter from the text file

           int count = File.ReadAllText(filepath).Length;
           Console.WriteLine("Total words :"+count);
           // Console.WriteLine(file);
           //Name and extention of text file

            FileInfo f=new FileInfo(filepath);
            string f1 = f.Name;
            string f2 = f.Extension;
            Console.WriteLine("file name: "+f1);
            Console.WriteLine("extension"+f2);
            //count of wordtextfile

            int wordcount = 0;
            for(int i = 0; i < file.Length - 1; i++)
            {
                if (file[i]==' '&& char.IsLetter(file[i + 1]) && (i > 0))
                    {
                    wordcount++;
                }
            }
            Console.WriteLine("the total of wordcount: "+wordcount);

            Console.ReadLine();
           // File.Delete(@"C:\ReadWriteFile\Readwrite.txt");

          // copy text file from another folder where you copied
           string file1= @"C:\ReadWriteFile\Readwrite.txt";
           string destination = "C:Filename1";
            File.Copy(file1,destination,true);
        
    }
}
