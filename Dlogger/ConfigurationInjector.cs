using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dlogger
{
    class ConfigurationInjector
    {
        public ConfigurationInjector(IConfigurationGetter _ICG)
        {
            ICG = _ICG;
        }

        private IConfigurationGetter ICG;

        public string GetValue(string Input)
        {
            string valuetouse = string.Empty;
            switch (Input.ToLower())
            {
                case "top":
                    valuetouse = ICG.GetTopButton;
                    break;
                case "bottom":
                    valuetouse = ICG.GetBottomButton;
                    break;
                case "other":
                    valuetouse = ICG.OtherSide;
                    break;

                case "viewangle":
                    valuetouse = ICG.LoggerPointofView;
                    break;
                default: break;
            }
            return valuetouse;
        }
    }
}
