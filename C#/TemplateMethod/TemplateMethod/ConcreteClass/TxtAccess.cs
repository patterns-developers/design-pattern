using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethod
{
    public class TxtAccess : FileAccess
    {
        public override void Close()
        {
            Console.WriteLine("Close file Txt");
        }

        public override void Open()
        {
            Console.WriteLine("Open file Txt");
        }

        public override string Read()
        {
            return "Txt info...";
        }
    }
}
