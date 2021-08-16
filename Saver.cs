using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows;

namespace _1._2._05._01_Saver
{
    class Saver
    {
        private string FolderPath;
        private string FilePath;
        private string Path;

       public Saver(string folderPath, string filePath)
        {
            FolderPath = folderPath;
            FilePath = filePath;
            Path = FolderPath + FilePath;
        }



        public void Save(string text)
        {
            Checking(FolderPath, Path);
         
       
            StreamWriter sw = new StreamWriter(Path, true, Encoding.Default);
                sw.WriteLine("{"+text);
                sw.Close();
            
        }

        public string Read()
        {
            Checking(FolderPath, Path);
            StreamReader sw = new StreamReader(Path, Encoding.Default);

            string text = Convert.ToString(sw.ReadToEnd());            
            sw.Close();
            StreamWriter writer = new StreamWriter(Path, false);
            writer.Write("");
            writer.Close();
            return text;
        }

       







        public void Checking(string directory, string fileInfo)
        {
            DirectoryInfo dirInfo = new DirectoryInfo(directory);
            if (!File.Exists(fileInfo))
            {
                MessageBox.Show("Директорiя выдсутня! Створюю нову...");
                try
                {
                    dirInfo.Create();
                    StreamWriter sw = new StreamWriter(fileInfo);
                    sw.Write("");
                    sw.Close();

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }

            }
        }

        //this part you must read:
        public void AddFromFile(out List<Person> data)
        {
            data = new List<Person>();
            string text = Read();

            string[] arrey = text.Split('{');

            foreach (string person in arrey)
            {
                if (person == "") { continue; }

                string[] arrey1 = person.Split('|');
                Person person1 = new Person(arrey1[2], arrey1[3], int.Parse(arrey1[4]), arrey1[5], int.Parse(arrey1[1]));
                data.Add(person1);
            }
        }
    }
}

  
