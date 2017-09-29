using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dlogger.Viewer
{
    class JV : IConfigurationGetter
    {
        public JV()
        {
            GetTopButton = "Up";
            GetBottomButton = "Down";
            OtherSide = "SouthSide";
            LoggerPointofView = "JV";
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
