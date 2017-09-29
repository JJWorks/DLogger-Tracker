using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Dlogger
{
    class Logger
    {
        public Logger(string _filename)
        {
            FileName = _filename;
        }

        private string FileName;

        public bool Log(DateTime Occurance, string TexttoWrite)
        {
            bool success = false;
            string TextTo = Occurance.ToString("G") + ":  " + TexttoWrite;
            using (TextWriter tw = new StreamWriter(FileName, true))
            {
                tw.WriteLine(TextTo);
                success = true;
            }
            return success;
        }

    }

}
