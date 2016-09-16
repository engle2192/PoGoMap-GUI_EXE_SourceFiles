using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace PoGoMap_GUI_updater
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Diagnostics.Process.Start("PokemonGo-Map_Launcher");
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            label1.Text = "Killing PoGoMap-GUI";
            foreach (var process1 in Process.GetProcessesByName("PokemonGo-Map_Launcher"))
            {
                process1.Kill();
            }
            label1.Text = "Updating from GitHub";
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = @"/C git pull origin master";
            process.StartInfo = startInfo;
            process.Start();
            process.WaitForExit();

            label1.Text = "Configuring PokemonGo-Map... Could take 5+ minutes";
            System.Diagnostics.Process process2 = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo2 = new System.Diagnostics.ProcessStartInfo();
            startInfo2.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo2.FileName = "cmd.exe";
            startInfo2.Arguments = @"/C cd PokemonGo-Map & pip install -r requirements.txt & npm install";
            process2.StartInfo = startInfo2;
            process2.Start();
            process2.WaitForExit();

            label1.Text = "Configuring PokeAlarm";
            System.Diagnostics.Process process3 = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo3 = new System.Diagnostics.ProcessStartInfo();
            startInfo3.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo3.FileName = "cmd.exe";
            startInfo3.Arguments = @"/C cd PokemonGo-Map & pip install -r requirements.txt & npm install";
            process3.StartInfo = startInfo3;
            process3.Start();
            process3.WaitForExit();
            label1.Text = "PoGoMap-GUI has been updated! Please close this window";
        }
    }
}
