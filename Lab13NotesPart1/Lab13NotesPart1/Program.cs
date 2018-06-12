using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab13NotesPart1
{
    class Program
    {
        static void Main(string[] args)
        
            class Program
        
            static void Main(string[] args)
            {
                //CreateFile();
                List<Person> people = ReadFile("names.txt");

                foreach (Person p in people)
                {
                    Console.WriteLine(p);
                }
            }

            private static List<Person> ReadFile(string filename)
            {
                List<Person> people = new List<Person>();

                StreamReader sr = null;
                try
                {
                    sr = new StreamReader(filename);

                    while (!sr.EndOfStream)
                    {
                        String line = sr.ReadLine();

                        Person p = new Person(line, "", "", 0);
                        people.Add(p);

                        /*
                        if (line == null)
                        {
                            Console.WriteLine("End of file");
                            return;
                        }
                        */

                        Console.WriteLine("read: " + line);
                    }
                    Console.WriteLine("End of file");
                }
                catch (Exception)
                {
                    Console.WriteLine("Error reading file");
                }
                finally
                {
                    if (sr != null)
                    {
                        sr.Close();
                    }
                }

                return people;
            }

            private static void CreateFile()
            {
                string[] names = {"Kamel", "David", "Antonella",
                "Adam", "Tommy", "Peter", "Jacob"};

                StreamWriter sw = null;
            try
            {
                sw = new StreamWriter("names.txt");

                foreach (string name in names)
                {
                    Console.WriteLine(name);
                    sw.WriteLine(name);
                }
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("File access denied");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Please convey this error to IT. Exiting...");
                throw;
            }
            finally
            {
                if (sw != null)
                {
                    sw.Close();

                }
            }
        }
    }
}
