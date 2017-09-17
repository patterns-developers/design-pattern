using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethod
{
    public abstract class FileAccess
    {
        public abstract void Open();
        public abstract string Read();
        public abstract void Close();

        public string Execute()
        {
            Open();
            string msg = Read();
            Close();

            return msg;
        }
    }
}
