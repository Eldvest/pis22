using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace основы_проектирования
{

    public class TextFile : Objectt
    {
        public string Extension { get; set; }
        public TextFile(string type, string name, DateTime date, int size, string extention) : base(type, name, date, size)
        {
            Extension = extention;
        }
        public override string PrintInf()
        {
            return $"\nОбъект: {Type}\nНазвание файла - {Name}\nДата создания - {Date.ToString("yyyy.MM.dd")}\nРазмер - {Size} байт\nРасширение - {Extension}";
        }
    }
}
