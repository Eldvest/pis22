using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace основы_проектирования
{
    public class Create
    {
        static public Objectt CreateObject(string str)
        {


            string[] words = str.Split(';', StringSplitOptions.RemoveEmptyEntries);
            string type = words[0].Trim();
            string name = words[1].Trim();
            if (!DateTime.TryParse(words[2], out DateTime date))
            {
                return null;
            }
            if (!int.TryParse(words[3], out int size))
            {
                return null;
            }

            switch (type)
            {

                case "VideoFile":
                    if (!TimeSpan.TryParse(words[4], out TimeSpan duration)) { return null; }
                    return new VideoFile(type, name, date, size, duration);

                case "TextFile":
                    return new TextFile(type, name, date, size, words[4].Trim());
                default:
                    return null;
            }
        }


        static public List<Objectt> ParseFile(string filePath)
        {

            List<Objectt> files = new List<Objectt>();
            if (File.Exists(filePath))
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line = reader.ReadLine();
                    while (line != null)
                    {
                        Objectt obj = CreateObject(line);
                        if (obj != null)
                        {
                            files.Add(obj);
                        }
                        line = reader.ReadLine();
                    }
                }
            }
            else
            {
                Console.WriteLine($"Файл не найден по пути: {filePath}");
            }

            return files;
        }


        static public List<Objectt> ParseString(string str)
        {

            List<Objectt> objects = new List<Objectt>();
            string[] lines = str.Split('\n');
            foreach (string line in lines)
            {
                Objectt obj = CreateObject(line);
                if (obj != null)
                {
                    objects.Add(obj);
                }

            }
            return objects;
        }
    }
}
