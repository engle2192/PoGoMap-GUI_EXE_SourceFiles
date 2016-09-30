using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Diagnostics;
using System.IO;
using Microsoft.Win32;

namespace PoGoMap_GUI_installer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       
        private void Form1_Shown(object sender, EventArgs e)
        {
            if(STATUS.Text == "Step:2")
            {
                button1.Enabled = false;
                button2.Enabled = false;
                pictureBox6.Enabled = true;
                pictureBox7.Enabled = true;
                pictureBox8.Enabled = true;
                label6.Enabled = true;
                label7.Enabled = true;
                pictureBox7.Image = Properties.Resources.rolling;
                PoGoConfigWorker.RunWorkerAsync();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            label1.Enabled = true;
            label2.Enabled = true;
            label3.Enabled = true;
            label4.Enabled = true;
            label5.Enabled = true;
            //label6.Enabled = true;
            //label7.Enabled = true;
            Git.Enabled = true;
            pictureBox1.Enabled = true;
            pictureBox2.Enabled = true;
            pictureBox3.Enabled = true;
            pictureBox4.Enabled = true;
            pictureBox5.Enabled = true;
            pictureBox6.Enabled = true;
            pictureBox9.Enabled = true;
            label9.Enabled = true;
            //pictureBox7.Enabled = true;
            //pictureBox8.Enabled = true;
            pictureBox1.Image = Properties.Resources.rolling;
            GitWorker.RunWorkerAsync();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            pictureBox6.Enabled = true;
            pictureBox7.Enabled = true;
            pictureBox8.Enabled = true;
            label6.Enabled = true;
            label7.Enabled = true;
            pictureBox7.Image = Properties.Resources.rolling;
            PoGoConfigWorker.RunWorkerAsync();
        }


        private void GitWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }

        private void GitWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            pictureBox1.Image = Properties.Resources.Tick_Mark_Circle_30;
            pictureBox2.Image = Properties.Resources.rolling;
            PythonWorker.RunWorkerAsync();
        }

        private void PythonWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            Form3 f3 = new Form3();
            f3.ShowDialog();
        }

        private void PythonWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            pictureBox2.Image = Properties.Resources.Tick_Mark_Circle_30;
            pictureBox3.Image = Properties.Resources.rolling;
            PythonCPPWorker.RunWorkerAsync();
        }

        private void PythonCPPWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            Form4 f4 = new Form4();
            f4.ShowDialog();
        }

        private void PythonCPPWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            pictureBox3.Image = Properties.Resources.Tick_Mark_Circle_30;
            pictureBox4.Image = Properties.Resources.rolling;
            NpmWorker.RunWorkerAsync();
        }

        private void NpmWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            Form5 f5 = new Form5();
            f5.ShowDialog();
        }

        private void NpmWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            pictureBox4.Image = Properties.Resources.Tick_Mark_Circle_30;
            pictureBox9.Image = Properties.Resources.rolling;
            NetWorker.RunWorkerAsync();
            
        }

        private void NetWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = @"/C NET35.exe";
            process.StartInfo = startInfo;
            process.Start();
            process.WaitForExit();
        }

        private void NetWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            pictureBox9.Image = Properties.Resources.Tick_Mark_Circle_30;
            pictureBox5.Image = Properties.Resources.rolling;
            chromephantomWorker.RunWorkerAsync();
        }

        private void chromephantomWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            Form6 f6 = new Form6();
            f6.ShowDialog();
        }

        private void chromephantomWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            
            pictureBox5.Image = Properties.Resources.Tick_Mark_Circle_30;
            pictureBox6.Image = Properties.Resources.rolling;
            CloneWorker.RunWorkerAsync();

        }

        private void CloneWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            Form7 f7 = new Form7();
            f7.ShowDialog();
        }

        private void CloneWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            string username = Environment.UserName;
            if (Directory.Exists(@"C:\users\" + username + @"\desktop\PoGoMap-GUI"))
            {
                pictureBox6.Image = Properties.Resources.Tick_Mark_Circle_30;

                DialogResult dialogResult = MessageBox.Show("Step 1 Finished. Restart your computer and run Step 2. Would you like to reboot now?", "Restart Computer", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    //do something
                    STATUS.Text = "Step:2";
                    Properties.Settings.Default.STATUStext = STATUS.Text;
                    Properties.Settings.Default.Save();
                    RegistryKey registryKey = Registry.CurrentUser.OpenSubKey ("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
                    registryKey.SetValue("PoGoGUI_Installer", Application.ExecutablePath);
                    System.Diagnostics.Process.Start("shutdown.exe", "-r -t 0");
                }
                else if (dialogResult == DialogResult.No)
                {
                    STATUS.Text = "Step:2";
                    Properties.Settings.Default.STATUStext = STATUS.Text;
                    Properties.Settings.Default.Save();
                    RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
                    registryKey.SetValue("PoGoGUI_Installer", Application.ExecutablePath);
                    this.Close();
                }
                //MessageBox.Show("Step 1 Finished. Restart your computer and run Step 2");
                //this.Close();
                //pictureBox7.Image = Properties.Resources.rolling;
                //PoGoConfigWorker.RunWorkerAsync();
            }
            else
            {
                MessageBox.Show("Woops...Cloning to desktop failed. Please close and re-open the installer and run again. Sorry :(");
                this.Close();
            }
        }

        private void PoGoConfigWorker_DoWork(object sender, DoWorkEventArgs e)
        {

            string username = Environment.UserName;
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Normal;
            startInfo.Verb = "runas";
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = @"/C cd C:\users\" + username + @"\desktop\PoGoMap-GUI\PokemonGo-Map & pip install -r requirements.txt & npm install & cd .. & cd pokealarm & pip install -r requirements.txt & cd .. & cd PokemonGo-Map & npm install";
            process.StartInfo = startInfo;
            process.Start();
            process.WaitForExit();
        }

        private void PoGoConfigWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            pictureBox7.Image = Properties.Resources.Tick_Mark_Circle_30;
            pictureBox8.Image = Properties.Resources.rolling;
            AccountCreatorWorker.RunWorkerAsync();
        }

        private void AccountCreatorWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            //String command = @"/C pip install git+https://github.com/sriyegna/pikaptcha & pip install git+https://github.com/keyphact/pgoapi.git";
            //ProcessStartInfo cmdsi = new ProcessStartInfo("cmd.exe");
            //cmdsi.Arguments = command;
            //Process cmd = Process.Start(cmdsi);
            //cmd.WaitForExit();
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Normal;
            startInfo.Verb = "runas";
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = @"/C pip install git+https://github.com/sriyegna/pikaptcha & pip install git+https://github.com/keyphact/pgoapi.git";
            process.StartInfo = startInfo;
            process.Start();
            process.WaitForExit();
        }

        private void AccountCreatorWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            pictureBox8.Image = Properties.Resources.Tick_Mark_Circle_30;
            RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
            registryKey.DeleteValue("PoGoGUI_Installer");
            MessageBox.Show("Step 2 Finished! Open the GUI, Create some accounts, Edit notification settings, add your google maps API key, Then run your map!");
            this.Close();
        }


    }
}
