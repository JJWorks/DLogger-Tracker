using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using Dlogger.Viewer;
using Ninject;

namespace Dlogger
{
    public partial class Form1 : Form
    {
        private Logger TheLogger;
        private ConfigurationInjector CI;
        public Form1()
        {
            var kernel = new StandardKernel();
            kernel.Bind<IConfigurationGetter>().To<JV>();

            var Configure = kernel.Get<IConfigurationGetter>();


            CI = new ConfigurationInjector(Configure);
            InitializeComponent();
            TopButton.Text = CI.GetValue("top");
            ButtonButton.Text = CI.GetValue("bottom");
            OtherBUtton.Text = CI.GetValue("other");

            TheLogger = new Logger(ConfigurationManager.AppSettings["FileName"]);
        }

        private void TopButton_Click(object sender, EventArgs e)
        {
            StartLogging(DateTime.Now, "Going " + CI.GetValue("top"));
        }
        private void ButtonButton_Click(object sender, EventArgs e)
        {
            StartLogging(DateTime.Now, "Going " + CI.GetValue("bottom"));
        }
        private void OtherBUtton_Click(object sender, EventArgs e)
        {
            StartLogging(DateTime.Now, "Wandering " + CI.GetValue("other"));
        }

        private void StartLogging(DateTime dt, string Direction)
        {
            TheLogger.Log(dt, CI.GetValue("viewangle") + "  " + Direction);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(textBox1.Text))
            {
                StartLogging(DateTime.Now, "CommentStart: " + textBox1.Text + "..CommentEnd");
                textBox1.Text = "";
            }
        }
    }
}
