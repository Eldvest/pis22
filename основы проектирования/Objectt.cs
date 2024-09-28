using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace основы_проектирования
{
    public class Objectt
    {
        public string Type { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public int Size { get; set; }

        public Objectt(string type, string name, DateTime date, int size)
        {
            Type = type;
            Name = name;
            Date = date;
            Size = size;
        }
        public virtual string PrintInf()
        {
            return $"\nОбъект: {Type}\nНазвание файла - {Name}\nДата создания - {Date.ToString("yyyy.MM.dd")}\nРазмер - {Size} байт\n";
        }
    }
    
}
