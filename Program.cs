using System;
using System.Collections.Generic;
using System.IO;
namespace _1._2._05._01_Saver
{
    class Program
    {
        static string FolderPath = @"B:\Sarmat\1.2_some_projecs\1.2.05.01_Saver\Data\";
        static string FilePath = "1.txt";
        public static List<Person> data = new List<Person>();

        public static void Start()
        {
            
             
             Saver saver = new Saver(FolderPath, FilePath);
            Program prog = new Program();
             saver.AddFromFile(out List<Person> newData);
             data.AddRange(newData);
            
           
            prog.Save();
            


        }

        public void Save()
        {
            Saver save = new Saver(FolderPath, "1.txt");

            foreach (Person person in data)
            {
                person.GetPerson(out string text);

                save.Save(text);
            }
        }

       



    }

  
    

    






}
