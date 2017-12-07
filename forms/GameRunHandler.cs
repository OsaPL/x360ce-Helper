using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace forms
{
    public class GameRunHandler
    {
        GameTemplate Game;
        MainForm MainForm;
        List<string> FilesNeeded;

        public GameRunHandler(GameTemplate Game, MainForm MainForm)
        {
            this.Game = Game;
            this.MainForm = MainForm;

            FilesNeeded = new List<string>();
            if (this.Game.x86)
            {
                FilesNeeded.Add(@"\x360ce\x86\x360ce.exe");
                FilesNeeded.Add(@"\x360ce\x86\dinput_x86.dll");
                FilesNeeded.Add(@"\x360ce\x86\xinput1_1.dll");
                FilesNeeded.Add(@"\x360ce\x86\xinput1_2.dll");
                FilesNeeded.Add(@"\x360ce\x86\xinput1_3.dll");
                FilesNeeded.Add(@"\x360ce\x86\xinput1_4.dll");
                FilesNeeded.Add(@"\x360ce\x86\xinput9_1_0.dll");
            }
            else
            {
                FilesNeeded.Add(@"\x360ce\x64\x360ce_x64.exe");
                FilesNeeded.Add(@"\x360ce\x64\dinput_x64.dll");
                FilesNeeded.Add(@"\x360ce\x64\xinput1_1.dll");
                FilesNeeded.Add(@"\x360ce\x64\xinput1_2.dll");
                FilesNeeded.Add(@"\x360ce\x64\xinput1_3.dll");
                FilesNeeded.Add(@"\x360ce\x64\xinput1_4.dll");
                FilesNeeded.Add(@"\x360ce\x64\xinput9_1_0.dll");
            }
            FilesNeeded.Add(@"\x360ce\x360ce.ini");
        }
        public void Clean(bool keepCfg)
        {
            if (keepCfg)
            {
                FilesNeeded.Remove(FilesNeeded.Last());
            }
            foreach (string file in FilesNeeded)
            {
                File.Delete(Game.GetOnlyPath() + file.Substring(file.LastIndexOf(@"\")));
            }
        }
        public void StartExe(string filedirectory)
        {
            ProcessStartInfo info = new ProcessStartInfo(filedirectory);
            info.CreateNoWindow = false;
            info.UseShellExecute = false;
            info.RedirectStandardError = true;
            info.RedirectStandardOutput = true;
            Process p = new Process();
            p.StartInfo = info;

            AutoResetEvent wait = new AutoResetEvent(false);

            p.Exited += (s, e) =>
            {
                wait.Set();
            };
            p.Start();
            wait.WaitOne();
        }
        public void Start()
        {
            //We get our %CD%
            string path = System.Reflection.Assembly.GetExecutingAssembly().Location;
            var directory = System.IO.Path.GetDirectoryName(path);

            //We do some magic things here...
            //1. hide mainform(do not close it!)
            //2. copy all needed files over, if any of them are already there, do a backup
            //3. if user wants, run x360ce to configure
            //4. if x360ce is not opened, run game      //a timer based listener, check if process by the name exists???
            //5. after game exit, remove all files
            //6. show main form again

            MainForm.Hide();

            foreach (string file in FilesNeeded)
            {
                try
                {
                    File.Copy(directory + file, Game.GetOnlyPath() + file.Substring(file.LastIndexOf(@"\")), false);
                }
                catch (Exception ex)
                {

                }

            }

            var confirmResult = MessageBox.Show("Do you want to open x360ce before starting the game?\nIt will edit the game specific configuration.",
                                     "Open configuration",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                if (Game.x86)
                {
                    ProcessStartInfo startinfo = new ProcessStartInfo();
                    startinfo.WorkingDirectory = Game.GetOnlyPath();
                    startinfo.FileName = @"x360ce.exe";

                    var x360ce = Process.Start(startinfo);
                    x360ce.WaitForExit();
                }
                else
                {
                    ProcessStartInfo startinfo = new ProcessStartInfo();
                    startinfo.WorkingDirectory = Game.GetOnlyPath();
                    startinfo.FileName = @"x360ce_64.exe";

                    var x360ce = Process.Start(startinfo);
                    x360ce.WaitForExit();
                }
            }
            DeleteExe();

            var gamexec = Process.Start(Game.Directory);
            gamexec.WaitForExit();

            MainForm.Show();

            if (!Game.Keepfiles)
            {
                this.Clean(true);
            }

        }

        private void DeleteExe()
        {
            try
            {
                if (Game.x86)
                {
                    File.Delete(Game.GetOnlyPath() + @"\" + "x360ce.exe");
                }
                else
                {
                    File.Delete(Game.GetOnlyPath() + @"\" + "x360ce_64.exe");
                }
            }
            catch (Exception e)
            {

            }

        }
    }
}
