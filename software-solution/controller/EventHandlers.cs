using System;
using System.Windows.Forms;

using software_solution.controller;

namespace software_solution
{
    partial class Form1 : Form
    {
        #pragma warning disable IDE1006 // Naming Styles
        private void loadTextbox_DoubleClick(object sender, EventArgs e)
        {
            loadTextbox.Clear();
        }

        private void loadPositionButton_Click(object sender, EventArgs e)
        {
            string plainText = loadTextbox.Text;
            loadTextbox.Clear();

            loggerMain.Info($"Sent: [{plainText}] to parser");
            var positionsList = Parser.Parse(plainText);
            loggerMain.Info($"Parser returned: [{string.Join(",", positionsList)}]");

            foreach (string solePosition in positionsList)
            {
                if (itemsToUnload.ContainsKey(solePosition) && itemsToUnload[solePosition] > 0)
                {
                    // if unload already contains this HEX, decrease its value
                    itemsToUnload[solePosition] = itemsToUnload[solePosition] - 1;
                }
                else
                {
                    // else create new HEX - position, and inform user ?, or just log

                    //MessageBox.Show("Создана новая позиция");
                    loggerMain.Info($"New position created: [{solePosition}]");
                }

                if (itemsToLoad.ContainsKey(solePosition))
                {
                    itemsToLoad[solePosition] = itemsToLoad[solePosition] + 1;
                    loggerMain.Info($"Found [{solePosition}] increase amount to [{itemsToLoad[solePosition]}]");
                }
                else
                {
                    itemsToLoad.Add(solePosition, 1);
                    loggerMain.Info($"Not found [{solePosition}] create new, and increase amount to [{itemsToLoad[solePosition]}]");
                }
            }
            UpdateGridView();
        }

        private void loadTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                loadPositionButton_Click(sender, null);
            }
        }

        private void unloadTextbox_DoubleClick(object sender, EventArgs e)
        {
            unloadTextbox.Clear();
        }

        private void unloadPositionButton_Click(object sender, EventArgs e)
        {
            string plainText = unloadTextbox.Text;
            unloadTextbox.Clear();

            loggerMain.Info($"Sent: [{plainText}] to parser");
            var positionsList = Parser.Parse(plainText);
            loggerMain.Info($"Parser returned: [{string.Join(",", positionsList)}]");

            foreach (string solePosition in positionsList)
            {
                // check whether load table contains at least one position, so we are able to unload it.
                if (itemsToLoad.ContainsKey(solePosition) && itemsToLoad[solePosition] > 0)
                {
                    itemsToLoad[solePosition] = itemsToLoad[solePosition] - 1;
                }
                else
                {
                    MessageBox.Show("Такой позиции нет в приеме!");
                    loggerMain.Info($"Position is not listed in load: [{solePosition}] -> CONTINUE");
                    continue;
                }

                if (itemsToUnload.ContainsKey(solePosition))
                {
                    itemsToUnload[solePosition] = itemsToUnload[solePosition] + 1;
                    loggerMain.Info($"Found [{solePosition}] increase amount to [{itemsToUnload[solePosition]}]");
                }
                else
                {
                    itemsToUnload.Add(solePosition, 1);
                    loggerMain.Info($"Not found [{solePosition}] create new and increase to [{itemsToUnload[solePosition]}]");
                }
            }
            UpdateGridView();
        }

        private void unloadTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                unloadPositionButton_Click(sender, null);
            }
        }
        
        private void clearDataButton_Click(object sender, EventArgs e)
        {
            loadGridview.Rows.Clear();
            unloadGridview.Rows.Clear();
            itemsToLoad.Clear();
            itemsToUnload.Clear();
        }
        
        private void saveListsButton_Click(object sender, EventArgs e)
        {
            var filename = Properties.Settings.Default.DefaultCSVFileName;
            FileWorks.WriteCSV(itemsToLoad, itemsToUnload, filename);
        }

        private void loadDataButton_Click(object sender, EventArgs e)
        {
            clearDataButton_Click(sender, e);
            var filename = Properties.Settings.Default.DefaultCSVFileName;
            FileWorks.ReadCSV(ref itemsToLoad, ref itemsToUnload, filename);
            UpdateGridView();
        }
    }
}
