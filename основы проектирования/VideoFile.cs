using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace основы_проектирования
{

    public class VideoFile : Objectt
    {
        public TimeSpan Duration { get; set; }
        public VideoFile(string type, string name, DateTime date, int size, TimeSpan duration) : base(type, name, date, size)
        {

            Duration = duration;
        }
        public override string PrintInf()
        {
            return $"\nОбъект: {Type}\nНазвание файла - {Name}\nДата создания - {Date.ToString("yyyy.MM.dd")}\nРазмер - {Size} байт\nДлительность - {Duration/*.ToString(@"hh\:mm")*/}";
        }
    }
}
