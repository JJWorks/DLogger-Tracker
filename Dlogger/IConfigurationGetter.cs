using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dlogger
{
    interface IConfigurationGetter
    {
        string GetTopButton
        {
            get; set;
        }
        string GetBottomButton
        {
            get; set;
        }

        string OtherSide
        {
            get; set;
        }

        string LoggerPointofView
        {
            get; set;
        }

    }
}
