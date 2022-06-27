using System;
using System.IO;
using System.Text;

namespace WebApiTesting.Feature_Objects
{
    public class FileReadWrite
    {
        public string id;
        public void CreateFile()
        {
            string filepath = @"C:\Users\mindtreefeb86\source\repos\WebApiTesting\WebApiTesting\file.txt";
            if (File.Exists(filepath))
                File.Delete(filepath);

            using (FileStream fs = File.Create(filepath))
            {
                Byte[] title = new UTF8Encoding(true).GetBytes("New Text File");
                fs.Write(title, 0, title.Length);
                Byte[] author = new UTF8Encoding(true).GetBytes("Automation");
                fs.Write(author, 0, author.Length);
            }
            using (StreamWriter sw = File.CreateText(filepath))
            {
                sw.WriteLine(id);
            }

        }

        public void ReadFile()
        {
            string filepath = @"C:\Users\mindtreefeb86\source\repos\WebApiTesting\WebApiTesting\file.txt";
            using (StreamReader sr = File.OpenText(filepath))
            {
                string s = "";
                while ((s = sr.ReadLine()) != null)
                    id = s;
            }
        }
    }
}
