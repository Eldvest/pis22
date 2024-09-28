
using System.Text.RegularExpressions;
using основы_проектирования;

string fileString = "VideoFile; name1строка;20.02.02; 20; 02:30;\n" +
                   "TextFile; name2строка;20.04.02; 11; txt\n" +
                   "TextFile; name3строка;20.04.02; 11; txt";

List<Objectt> objects = Create.ParseString(fileString);
foreach (Objectt obj in objects) { Console.WriteLine(obj.PrintInf()); }


string filePath = "C:\\Users\\Настя\\source\\repos\\основы проектирования\\основы проектирования\\file.txt"; 
List<Objectt> objectsFromFile = Create.ParseFile(filePath);
foreach (Objectt obj in objectsFromFile) { Console.WriteLine(obj.PrintInf()); }



