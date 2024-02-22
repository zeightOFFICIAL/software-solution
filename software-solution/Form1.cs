using System;
using System.Windows.Forms;
using System.Collections.Generic;
using NLog;

using software_solution.logger;

namespace software_solution
{
    partial class Form1 : Form
    {
        private static readonly Logger loggerMain = new LoggerType().GetLogger();
        private static Dictionary<string, int> itemsToLoad;
        private static Dictionary<string, int> itemsToUnload;

        public Form1()
        {
            InitializeComponent(); 
            
            loggerMain.Info("Form object constructed -> OKAY");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            itemsToLoad = new Dictionary<string, int>();
            itemsToUnload = new Dictionary<string, int>();
            var csvFilename = Properties.Settings.Default.DefaultCSVFileName;

            loggerMain.Info("Csv file location" + csvFilename);
            loggerMain.Info("Form loaded -> OKAY");
        }

        private void UpdateGridView()
        {
            UpdateLoadGridView();
            UpdateUnloadGridView();

            loggerMain.Info("Grids updated -> OKAY");
        }

        private void UpdateUnloadGridView()
        {
            unloadGridview.Rows.Clear();

            foreach (string item in itemsToUnload.Keys) 
            {
                if (itemsToUnload[item] <= 0) 
                {
                    loggerMain.Info($"Item [{item}] skipped since its value is [{itemsToUnload[item]}]");
                    continue;
                }                
                unloadGridview.Rows.Add(item, itemsToUnload[item]);
                loggerMain.Info($"Item [{item}] added with value of [{itemsToUnload[item]}] -> OKAY");
            }
        }

        private void UpdateLoadGridView()
        {
            loadGridview.Rows.Clear();

            foreach (string item in itemsToLoad.Keys) 
            {
                if (itemsToLoad[item] <= 0) 
                {
                    loggerMain.Info($"Item {item} skipped since its value is [{itemsToLoad[item]}]");
                    continue;
                }
                loadGridview.Rows.Add(item, itemsToLoad[item]);
                loggerMain.Info($"Item [{item}] added with value of [{itemsToLoad[item]}] -> OKAY");
            }
        }

    }
}
