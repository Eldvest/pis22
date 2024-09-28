
using System.Text.RegularExpressions;
using основы_проектирования;

    string str ="Файлы: \'ghbdtn vbh\' ; 2024.02.02; 23;"; 
    Console.Write(str);
    //str = str.Replace(" ", "");
    str = str.Replace(":", ";");
    string[] words = str.Split(';', StringSplitOptions.RemoveEmptyEntries);

try
{
    DateTime parsedDate = DateTime.Parse(words[2]);
    if ((words.Length == 4 && words[1].Trim().StartsWith("\'") && words[1].Trim().EndsWith("\'")) && ((int.TryParse(words[3], out int value))))
    {
        Objectt obj = new Objectt(words[0], words[1], parsedDate, Convert.ToInt32(words[3]));
        Console.WriteLine(obj.PrintInf());
    }
    else { Console.WriteLine("Некорректные данные"); }
}
catch (System.FormatException) { Console.WriteLine("Неверный ввод даты"); }
    
