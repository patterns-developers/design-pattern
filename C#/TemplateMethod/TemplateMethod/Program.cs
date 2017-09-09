using System;

namespace TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            FileAccess txt = new TxtAccess();
            Console.WriteLine(txt.Execute());

            FileAccess csv = new CsvAccess();
            Console.WriteLine(csv.Execute());

            Console.ReadKey();
        }
    }
}