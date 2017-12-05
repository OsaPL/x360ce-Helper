using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace forms
{
    public partial class GameForm : Form
    {
        public GameForm()
        {
            InitializeComponent();
            Game = new GameTemplate();
        }

        public GameTemplate Game;

        public GameForm(GameTemplate game)
        {
            InitializeComponent();
            nameTextBox.Text = game.Name;
            directoryTextBox.Text = game.Directory;
            if (game.x86)
            {
                x86RadioButton.Checked = true;
            }
            else
            {
                x64RadioButton.Checked = true;
            }
            cleanCheckBox.Checked = !game.Keepfiles;
            this.Game = game;
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "EXE|*.exe";
            DialogResult result = dialog.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                directoryTextBox.Text = dialog.FileName;
                nameTextBox.Text = dialog.SafeFileName.Substring(0, dialog.SafeFileName.Length - 4);
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            Game.Name = nameTextBox.Text;
            Game.Directory = directoryTextBox.Text;
            if (x86RadioButton.Checked)
            {
                Game.x86 = true;
            }
            else
            {
                Game.x86 = false;
            }
            Game.Keepfiles = !cleanCheckBox.Checked;
            //this.DialogResult = DialogResult.OK;
            this.Hide();
        }
    }
    public class GameTemplate
    {
        public string Name;
        public string Directory;
        public bool x86;
        public bool Keepfiles;
        public string GetOnlyPath()
        {
            //add checking if it is a valid directory!
            return Directory.Substring(0,Directory.LastIndexOf(@"\"));
        }
        public string GetOnlyFile()
        {
            //add checking if it is a valid file!
            return Directory.Substring(Directory.LastIndexOf(@"\"));
        }
        public GameTemplate()
        {
            Name = "None";
            Directory = "";
            x86 = true;
            Keepfiles = false;
        }
        public override string ToString()
        {
            string tostring = "Game name: " + Name;

            if (x86)
            {
                tostring += "[x86]";
            }
            else
            {
                tostring += "[x64]";

            }
            tostring += " (" + Directory + ")";

            return tostring;
        }
    }
}
