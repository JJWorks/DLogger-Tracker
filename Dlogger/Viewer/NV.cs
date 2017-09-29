using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dlogger.Viewer
{
    class NV : IConfigurationGetter
    {
        public NV()
        {
            GetTopButton = "<--";
            GetBottomButton = "-->";
            OtherSide = "SouthSide";
            LoggerPointofView = "NV";
        }
        public string GetBottomButton
        {
            get;set;
        }

        public string GetTopButton
        {
            get; set;
        }

        public string LoggerPointofView
        {
            get; set;
        }

        public string OtherSide
        {
            get; set;
        }
    }
}
