using System;
using System.Windows.Forms;
using NLog;
using NLog.Config;
using NLog.Targets;

using software_solution.models;
using software_solution.controller;
using software_solution.logger;

namespace software_solution
{
    partial class Form1 : Form
    {
        Logger lgr;
        public Form1()
        {
            InitializeComponent();
            var LocalLoggerType = new LoggerType();
            lgr = LocalLoggerType.GetLogger();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lgr.Info("Form1 loaded");
        }
    }
}
