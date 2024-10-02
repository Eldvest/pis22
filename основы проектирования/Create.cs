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
            switch (words[0])
            {
                case "VideoFile":
                    return new VideoFile(words[0], words[1],ParseDate(words[2]),ParseInt(words[3]), ParseTime(words[4]));
                case "TextFile":
                    return new TextFile(words[0], words[1], ParseDate(words[2]), ParseInt(words[3]),words[4]);
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
        public static DateTime ParseDate(string dateString)
        {
            if (DateTime.TryParse(dateString, out DateTime date)) { return date; }
            else { throw new ArgumentException("Неверный формат даты"); }
        }
        public static int ParseInt(string sizeString)
        {
            if (int.TryParse(sizeString, out int size)) { return size; }
            else throw new ArgumentException("Неверный размер");
        }
        public static TimeSpan ParseTime(string timeString)
        {
            if (TimeSpan.TryParse(timeString, out TimeSpan duration)){ 
                return duration; 
            }
            else throw new ArgumentException("Неверный формат времени");
        }
    }
}
