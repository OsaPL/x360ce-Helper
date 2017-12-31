using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            GameForm dialog = new GameForm();
            dialog.ShowDialog(this);
            gamesListBox.Items.Add(dialog.Game);
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            if (gamesListBox.SelectedItems.Count > 0)
            {
                gamesListBox.Items.RemoveAt(gamesListBox.SelectedIndex);
            }
        }

        private void gamesListBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (gamesListBox.SelectedItems.Count > 0)
            {
                GameTemplate game = gamesListBox.SelectedItem as GameTemplate;
                GameRunHandler Handler = new GameRunHandler(game, this);
                Handler.Start();
            }
        }

        private void runButton_Click(object sender, EventArgs e)
        {
            if (gamesListBox.SelectedItems.Count > 0)
            {
                GameTemplate game = gamesListBox.SelectedItem as GameTemplate;
                GameForm dialog = new GameForm(game);
                dialog.ShowDialog(this);
                gamesListBox.Items[gamesListBox.SelectedIndex] = dialog.Game;
            }
        }

        private void editGlobalCfgButton_Click(object sender, EventArgs e)
        {
            string path = System.Reflection.Assembly.GetExecutingAssembly().Location;
            var directory = System.IO.Path.GetDirectoryName(path);
            try
            {
                File.Copy(directory + @"\x360ce\x86\x360ce.exe", directory + @"\x360ce\x360ce.exe");
                File.Copy(directory + @"\x360ce\x86\xinput1_3.dll", directory + @"\x360ce\xinput1_3.dll");
            }
            catch (Exception ex)
            {

            }


            ProcessStartInfo startinfo = new ProcessStartInfo();
            startinfo.WorkingDirectory = directory+@"\x360ce\";
            startinfo.FileName = @"x360ce.exe";

            var x360ce = Process.Start(startinfo);
            x360ce.WaitForExit();

            try
            {
                File.Delete(directory + @"\x360ce\x360ce.exe");
                File.Delete(directory + @"\x360ce\xinput1_3.dll");
            }
            catch (Exception ex)
            {

            }

        }

        private void cleanButton_Click(object sender, EventArgs e)
        {
            if (gamesListBox.SelectedItems.Count > 0)
            {
                GameTemplate game = gamesListBox.SelectedItem as GameTemplate;
                GameRunHandler Handler = new GameRunHandler(game, this);
                Handler.Clean(false);
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            string path = System.Reflection.Assembly.GetExecutingAssembly().Location;
            var directory = System.IO.Path.GetDirectoryName(path);

            try
            {
                string[] read = File.ReadAllLines(directory + @"\Games.cfg");

                int n = read.Length/4;

                for(int i = 0; i < n; i++)
                {
                    GameTemplate game = new GameTemplate();
                    game.Name = read[i * 4];
                    game.Directory = read[(i * 4)+1];
                    game.x86 = Convert.ToBoolean(read[(i * 4) +2]);
                    game.Keepfiles = Convert.ToBoolean(read[(i * 4)+3]);
                    gamesListBox.Items.Add(game);
                }
            }
            catch(Exception ex)
            {
                //TODO:Logging!!!!
            }

        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            string path = System.Reflection.Assembly.GetExecutingAssembly().Location;
            var directory = System.IO.Path.GetDirectoryName(path);

            try
            {
                File.Delete(directory + @"\Games.cfg");
            }
            catch(Exception ex)
            {
                //TODO:Logging
            }

            foreach (GameTemplate game in gamesListBox.Items)
            {
                string[] lines = {
                    game.Name,
                    game.Directory,
                    game.x86.ToString(),
                    game.Keepfiles.ToString()};
                System.IO.File.AppendAllLines(directory + @"\Games.cfg", lines);
            }
        }

        private void cleanGlobalButton_Click(object sender, EventArgs e)
        {
            string path = System.Reflection.Assembly.GetExecutingAssembly().Location;
            var directory = System.IO.Path.GetDirectoryName(path);
            try
            {
                File.Delete(directory + @"\x360ce\x360ce.ini");
            }
            catch (Exception ex)
            {
                //TODO:Logging
            }

        }
    }
}
