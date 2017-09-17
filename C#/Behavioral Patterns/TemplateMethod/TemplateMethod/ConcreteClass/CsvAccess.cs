using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethod
{
    public class CsvAccess : FileAccess
    {
        public override void Close()
        {
            Console.WriteLine("Close file CSV");
        }

        public override void Open()
        {
            Console.WriteLine("Open file CSV");
        }

        public override string Read()
        {
            return "CSV info...";
        }
    }
}
