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
using System.Runtime.InteropServices;
using System.Threading;
using System.Net;
using System.Net.Sockets;
using System.Net.NetworkInformation;
using QRCoder;
using MetroFramework.Forms;
using MetroFramework;

namespace PokemonGo_Map_Launcher
{
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            InitializeComponent();
            this.StyleManager = metroStyleManager1;
        }
        public string DPath = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
        public string currentVersion = "3.2.5";

        public static bool CheckForInternetConnection()
        {
            try
            {
                using (var client = new WebClient())
                {
                    using (var stream = client.OpenRead("http://www.google.com"))
                    {
                        return true;
                    }
                }
            }
            catch
            {
                return false;
            }
        }


        #region FormLoad
        private void Form1_Load(object sender, EventArgs e)
        {
            if (metroButton10.Text == "Dark Theme")
            {
                metroStyleManager1.Theme = MetroThemeStyle.Light;
                metroButton10.Text = "Dark Theme";
                Properties.Settings.Default.StyleTheme = metroButton10.Text;
                Properties.Settings.Default.Save();
            }
            else
            {
                metroStyleManager1.Theme = MetroThemeStyle.Dark;
                metroButton10.Text = "Light Theme";
                Properties.Settings.Default.StyleTheme = metroButton10.Text;
                Properties.Settings.Default.Save();
            }
            comboBox2.Text = "13";
            label2.Text = " -nk";
            label3.Text = " -ng";
            label4.Text = "";
            label5.Text = "";
            label11.Text = "";
            label13.Text = " --webhook-updates-only";
            ivcheck.Text = " -enc";
            NewsLabel.Text = "";
            linkLabel1.Text = "PoGo-GUI v" + currentVersion;
            foreach (TabPage tp in metroTabControl1.TabPages)
            {
                metroTabPage1.Show();
                metroTabPage2.Show();
                metroTabPage3.Show();
                metroTabPage1.Show();
            }

            if (CheckForInternetConnection() == true)
            {
                WebClient client = new WebClient();
                client.DownloadFileCompleted += new AsyncCompletedEventHandler(client_DownloadFileCompleted);
                client.DownloadFileAsync(new Uri("http://go2engle.com/pogomap/version.txt"), DPath + @"\version.txt");

            }
            else { }

            if (CheckForInternetConnection() == true)
            {

                WebClient client = new WebClient();
                client.DownloadFileCompleted += new AsyncCompletedEventHandler(client_DownloadFileCompleted2);
                client.DownloadFileAsync(new Uri("http://go2engle.com/pogomap/news.txt"), DPath + @"\news.txt");
            }
            else { }

        }

        #endregion


        void client_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            string readVersion = File.ReadAllText(@".\version.txt");
            if(currentVersion==readVersion)
            {

            }
            else
            {
                DialogResult dialogResult = MetroMessageBox.Show(this, "There is a new update, Would you like to download version " + readVersion + " and update now?", "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    System.Diagnostics.Process.Start("PoGoMap-GUI_updater.exe");
                }
                else if (dialogResult == DialogResult.No)
                {

                }
            }
        }
        void client_DownloadFileCompleted2(object sender, AsyncCompletedEventArgs e)
        {
            string news = File.ReadAllText(@".\news.txt");
            NewsLabel.Text = news;
        }


        [DllImport("user32.dll")]
        static extern IntPtr SetParent(IntPtr hWndChild, IntPtr hWndNewParent);
        [DllImport("user32.dll", SetLastError = true)]
        internal static extern bool MoveWindow(IntPtr hwnd, int X, int Y, int nWidth, int nHeight, bool bRepaint);

        public static string GetLocalIPAddress()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            throw new Exception("Local IP Address Not Found!");
        }
        public static string getBetween(string strSource, string strStart, string strEnd)
        {
            int Start, End;
            if (strSource.Contains(strStart) && strSource.Contains(strEnd))
            {
                Start = strSource.IndexOf(strStart, 0) + strStart.Length;
                End = strSource.IndexOf(strEnd, Start);
                return strSource.Substring(Start, End - Start);
            }
            else
            {
                return "";
            }
        }


        #region Buttons

        private void test_Click(object sender, EventArgs e)
        {
            Process p1 = Process.Start("cmd.exe");
            Thread.Sleep(150); // Allow the process to open it's window
            SetParent(p1.MainWindowHandle, panel1.Handle);
            MoveWindow(p1.MainWindowHandle, 0, 0, panel1.Width, panel1.Height, true);

            Process p = Process.Start("cmd.exe");
            Thread.Sleep(150); // Allow the process to open it's window
            SetParent(p.MainWindowHandle, panel2.Handle);
            MoveWindow(p.MainWindowHandle, 0, 0, panel2.Width, panel2.Height, true);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string GAPI = Properties.Settings.Default.gmapsAPI;
            Process p = Process.Start("cmd.exe", @"/c cd PokemonGo-Map & python runserver.py -ac usernames.csv -l " + textBox2.Text + " -st " + comboBox2.Text + " -k " + GAPI + label2.Text + label3.Text + label4.Text + label13.Text + label5.Text + label11.Text + " -H 0.0.0.0 -P " + textBox4.Text + " -wh http://" + GetLocalIPAddress() + ":" + textBox5.Text + ivcheck.Text + "& pause");
            Thread.Sleep(150); // Allow the process to open it's window
            SetParent(p.MainWindowHandle, panel2.Handle);
            MoveWindow(p.MainWindowHandle, 0, 0, panel2.Width, panel2.Height, true);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            //Run Updates
            DialogResult result = MessageBox.Show("Are you sure you want to update?", "Confirm", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
            {
                Process p = Process.Start("cmd.exe", @"/C cd PokemonGo-Map & git pull & pip install -r requirements.txt --upgrade & npm install & npm run build & echo Finish Updating & pause");
                Thread.Sleep(150); // Allow the process to open it's window
                SetParent(p.MainWindowHandle, panel1.Handle);
                MoveWindow(p.MainWindowHandle, 0, 0, panel1.Width, panel1.Height, true);
            }
            else if (result == DialogResult.No)
            {

            }
        }


        private void button4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = @"/C .\PokemonGo-Map\config\config.ini";
            process.StartInfo = startInfo;
            process.Start();
        }
        private void button10_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = @"/C start .";
            process.StartInfo = startInfo;
            process.Start();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //Account Creation
            if (string.IsNullOrWhiteSpace(textBox3.Text))
            {
                Process p = Process.Start("cmd.exe", @"/C cd PokemonGo-Map & pikaptcha -p " + textBox1.Text + " -c " + comboBox1.Text + @" & powershell -executionpolicy unrestricted .\usernamescsv.ps1 & python banned.py -f usernames.txt & powershell -executionpolicy unrestricted .\usernamescsv.ps1 & pause");
                Thread.Sleep(150); // Allow the process to open it's window
                SetParent(p.MainWindowHandle, panel2.Handle);
                MoveWindow(p.MainWindowHandle, 0, 0, panel2.Width, panel2.Height, true);
            }
            else
            {
                Process p = Process.Start("cmd.exe", @"/C cd PokemonGo-Map & pikaptcha -r " + textBox3.Text + " -p " + textBox1.Text + " -c " + comboBox1.Text + @" & powershell -executionpolicy unrestricted .\usernamescsv.ps1 & python banned.py -f usernames.txt & powershell -executionpolicy unrestricted .\usernamescsv.ps1 & pause");
                Thread.Sleep(150); // Allow the process to open it's window
                SetParent(p.MainWindowHandle, panel2.Handle);
                MoveWindow(p.MainWindowHandle, 0, 0, panel2.Width, panel2.Height, true);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //RunNotifications
            Process p = Process.Start("cmd.exe", @"/C cd PokeAlarm & python runwebhook.py -H 0.0.0.0 -P " + textBox5.Text + " & pause");
            Thread.Sleep(150); // Allow the process to open it's window
            SetParent(p.MainWindowHandle, panel1.Handle);
            MoveWindow(p.MainWindowHandle, 0, 0, panel1.Width, panel1.Height, true);
        }
      
        private void button9_Click(object sender, EventArgs e)
        {
            Process p = Process.Start("cmd.exe", @"/c cd PokemonGo-Map & powershell -executionpolicy unrestricted .\usernamescsv.ps1 & python banned.py -f usernames.txt & powershell -executionpolicy unrestricted .\usernamescsv.ps1 & Pause");
            Thread.Sleep(150); // Allow the process to open it's window
            SetParent(p.MainWindowHandle, panel2.Handle);
            MoveWindow(p.MainWindowHandle, 0, 0, panel2.Width, panel2.Height, true);
        }
        private void button7_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.ShowDialog();
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://localhost:" + textBox4.Text);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Update PoGoMap-GUI?", "Update?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                System.Diagnostics.Process.Start("PoGoMap-GUI_updater.exe");
            }
            else if (dialogResult == DialogResult.No)
            {
                
            }
            
        }
        private void button3_Click_1(object sender, EventArgs e)
        {
            if (MobileAccess.Text == "Enable Mobile Access")
            {
                System.Diagnostics.Process process = new System.Diagnostics.Process();
                System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
                startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                startInfo.FileName = "cmd.exe";
                startInfo.Arguments = @"/C .\bin\ngrok.exe http " + textBox4.Text;
                process.StartInfo = startInfo;
                process.Start();

                int milliseconds = 2000;
                Thread.Sleep(milliseconds);

                System.Diagnostics.Process process1 = new System.Diagnostics.Process();
                System.Diagnostics.ProcessStartInfo startInfo1 = new System.Diagnostics.ProcessStartInfo();
                startInfo1.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                startInfo1.FileName = "cmd.exe";
                startInfo1.Arguments = @"/C .\bin\curl.exe http://localhost:4040/api/tunnels > .\bin\tunnels.txt";
                process1.StartInfo = startInfo1;
                process1.Start();
                Thread.Sleep(milliseconds);
                string text = System.IO.File.ReadAllText(@".\bin\tunnels.txt");
                string url = getBetween(text, "http://", ".ngrok.io");
                linkLabel4.Text = "http://" + url + ".ngrok.io";

                QRCodeGenerator qrGenerator = new QRCodeGenerator();
                QRCodeData qrCodeData = qrGenerator.CreateQrCode("http://" + url + ".ngrok.io", QRCodeGenerator.ECCLevel.Q);
                QRCode qrCode = new QRCode(qrCodeData);
                Bitmap qrCodeImage = qrCode.GetGraphic(5);
                pictureBox1.Image = qrCodeImage;

                MobileAccess.Text = "Disable Mobile Access";
            }
            else
            {
                foreach (var process in Process.GetProcessesByName("ngrok"))
                {
                    process.Kill();
                }

                MobileAccess.Text = "Enable Mobile Access";
            }
        }

        private void GMapsAPI_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.gmapsAPI = textBox6.Text;
            Properties.Settings.Default.Save();
            MetroMessageBox.Show(this, "API Key has been updated");
        }

        private void PoGoConfig_Click(object sender, EventArgs e)
        {
            //MetroMessageBox.Show(this, "This may take some time to run", "Warning", MessageBoxIcon.Stop);
            MetroMessageBox.Show(this, "This may take some time to run", "Warning",MessageBoxButtons.OK,MessageBoxIcon.Stop);
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Normal;
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = @"/C cd PokemonGo-Map & pip install -r requirements.txt & npm install & pause";
            process.StartInfo = startInfo;
            process.Start();
            Thread.Sleep(150);
            SetParent(process.MainWindowHandle, panel2.Handle);
            MoveWindow(process.MainWindowHandle, 0, 0, panel2.Width, panel2.Height, true);
        }
        private void PokeAlarmConfig_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Normal;
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = @"/C cd PokeAlarm & pip install -r requirements.txt";
            process.StartInfo = startInfo;
            process.Start();
            Thread.Sleep(150); // Allow the process to open it's window
            SetParent(process.MainWindowHandle, panel1.Handle);
            MoveWindow(process.MainWindowHandle, 0, 0, panel1.Width, panel1.Height, true);
        }
        private void metroButton10_Click(object sender, EventArgs e)
        {
            if (metroButton10.Text == "Light Theme")
            {
                metroStyleManager1.Theme = MetroThemeStyle.Light;
                metroButton10.Text = "Dark Theme";
                Properties.Settings.Default.StyleTheme = metroButton10.Text;
                Properties.Settings.Default.Save();
            }
            else
            {
                metroStyleManager1.Theme = MetroThemeStyle.Dark;
                metroButton10.Text = "Light Theme";
                Properties.Settings.Default.StyleTheme = metroButton10.Text;
                Properties.Settings.Default.Save();
            }
        }
        private void metroButton14_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Normal;
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = @"/C pip install git+https://github.com/sriyegna/pikaptcha & pip install git+https://github.com/keyphact/pgoapi.git & echo Restart GUI for changes to take affect & pause";
            process.StartInfo = startInfo;
            process.Start();
            Thread.Sleep(150); // Allow the process to open it's window
            SetParent(process.MainWindowHandle, panel1.Handle);
            MoveWindow(process.MainWindowHandle, 0, 0, panel1.Width, panel1.Height, true);
        }
        #endregion

        #region CheckBoxes

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                label2.Text = "";
            }
            else
            {
                label2.Text = " -nk";
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                label3.Text = "";
            }
            else
            {
                label3.Text = " -ng";
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                label4.Text = " -fl";
            }
            else
            {
                label4.Text = "";
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                label5.Text = " -nsc";
            }
            else
            {
                label5.Text = "";
            }
        }
        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked)
            {
                label11.Text = " -ss";
            }
            else
            {
                label11.Text = "";
            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked)
            {
                label13.Text = "";
            }
            else
            {
                label13.Text = " --webhook-updates-only";
            }
        }
        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox7.Checked)
            {
                ivcheck.Text = "";
            }
            else
            {
                ivcheck.Text = " -enc";
            }
        }


        #endregion

        #region LinkLabels
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/engle2192/PoGoMap-GUI/releases");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://go2engle.com/");
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form4 f4 = new Form4();
            f4.ShowDialog();
        }
        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            if (File.Exists(@".\bin\tunnels.txt"))
            {
                string text = System.IO.File.ReadAllText(@".\bin\tunnels.txt");
                string url = getBetween(text, "http://", ".ngrok.io");
                Clipboard.SetText("http://" + url + ".ngrok.io");
            }
            else { }
        }
        #endregion

        #region FormClosing
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.CaptchaKEY = textBox3.Text;
            Properties.Settings.Default.StartLOC = textBox2.Text;
            Properties.Settings.Default.Password = textBox1.Text;
            Properties.Settings.Default.MapPort = textBox4.Text;
            Properties.Settings.Default.StyleTheme = metroButton10.Text;
            Properties.Settings.Default.NotificationsPort = textBox5.Text;
            Properties.Settings.Default.Save();
            foreach (var process in Process.GetProcessesByName("ngrok"))
            {
                process.Kill();
            }
            if (MetroMessageBox.Show(this,"Are all your command windows closed?", "IMPORTANT", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) == DialogResult.No)
            {
                e.Cancel = true;
            }

        }









        #endregion


    }
}
