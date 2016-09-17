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

namespace PoGoMap_GUI_installer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string DPath = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);

        private void Form1_Shown(object sender, EventArgs e)
        {
            if (Directory.Exists(@"C:\Program Files\Git"))
            {
                label1.Text = "Installing PoGoMap-GUI";
                System.Diagnostics.Process process = new System.Diagnostics.Process();
                System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
                startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                startInfo.FileName = "cmd.exe";
                startInfo.Arguments = @"/C git clone https://github.com/engle2192/PoGoMap-GUI.git";
                process.StartInfo = startInfo;
                process.Start();
                process.WaitForExit();
                label1.Text = "Done! You can now close this window...";

            }
            else
            {
                progressBar.Visible = true;
                label1.Text = "Downloading Git";
                WebClient client = new WebClient();
                client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(client_DownloadProgressChanged);
                client.DownloadFileCompleted += new AsyncCompletedEventHandler(client_DownloadFileCompleted);
                // Starts the download
                client.DownloadFileAsync(new Uri("http://github.com/git-for-windows/git/releases/download/v2.10.0.windows.1/Git-2.10.0-64-bit.exe"), DPath + @"\github.exe");
            }
        }


        void client_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            double bytesIn = double.Parse(e.BytesReceived.ToString());
            double totalBytes = double.Parse(e.TotalBytesToReceive.ToString());
            double percentage = bytesIn / totalBytes * 100;
            progressBar.Value = int.Parse(Math.Truncate(percentage).ToString());
        }
        void client_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            progressBar.Visible = false;
            //MessageBox.Show("Download Completed");
            label1.Text = "Installing Git";
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.FileName = "github.exe";
            startInfo.Arguments = "/verysilent";
            process.StartInfo = startInfo;
            process.Start();
            process.WaitForExit();

            label1.Text = "Waiting a Sec";
            System.Diagnostics.Process process2 = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo2 = new System.Diagnostics.ProcessStartInfo();
            startInfo2.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo2.FileName = "cmd.exe";
            startInfo2.Arguments = "/C ping 127.0.0.1";
            process2.StartInfo = startInfo2;
            process2.Start();
            process2.WaitForExit();


            label1.Text = "Installing PoGoMap-GUI";
            System.Diagnostics.Process process1 = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo1 = new System.Diagnostics.ProcessStartInfo();
            startInfo1.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo1.FileName = "cmd.exe";
            startInfo1.Arguments = @"/C git clone https://github.com/engle2192/PoGoMap-GUI.git";
            process1.StartInfo = startInfo1;
            process1.Start();
            process1.WaitForExit();
            label1.Text = "Done! You can now close this window...";
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //System.Diagnostics.Process.Start(@".\PoGoMap-GUI\PokemonGo-Map_Launcher");
        }
    }
}
