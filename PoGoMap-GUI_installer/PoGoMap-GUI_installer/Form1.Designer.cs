namespace PoGoMap_GUI_installer
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.GitWorker = new System.ComponentModel.BackgroundWorker();
            this.PythonWorker = new System.ComponentModel.BackgroundWorker();
            this.PythonCPPWorker = new System.ComponentModel.BackgroundWorker();
            this.NpmWorker = new System.ComponentModel.BackgroundWorker();
            this.chromephantomWorker = new System.ComponentModel.BackgroundWorker();
            this.Git = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.CloneWorker = new System.ComponentModel.BackgroundWorker();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.PoGoConfigWorker = new System.ComponentModel.BackgroundWorker();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.AccountCreatorWorker = new System.ComponentModel.BackgroundWorker();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.NetWorker = new System.ComponentModel.BackgroundWorker();
            this.STATUS = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            this.SuspendLayout();
            // 
            // GitWorker
            // 
            this.GitWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.GitWorker_DoWork);
            this.GitWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.GitWorker_RunWorkerCompleted);
            // 
            // PythonWorker
            // 
            this.PythonWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.PythonWorker_DoWork);
            this.PythonWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.PythonWorker_RunWorkerCompleted);
            // 
            // PythonCPPWorker
            // 
            this.PythonCPPWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.PythonCPPWorker_DoWork);
            this.PythonCPPWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.PythonCPPWorker_RunWorkerCompleted);
            // 
            // NpmWorker
            // 
            this.NpmWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.NpmWorker_DoWork);
            this.NpmWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.NpmWorker_RunWorkerCompleted);
            // 
            // chromephantomWorker
            // 
            this.chromephantomWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.chromephantomWorker_DoWork);
            this.chromephantomWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.chromephantomWorker_RunWorkerCompleted);
            // 
            // Git
            // 
            this.Git.AutoSize = true;
            this.Git.Enabled = false;
            this.Git.Location = new System.Drawing.Point(90, 29);
            this.Git.Name = "Git";
            this.Git.Size = new System.Drawing.Size(20, 13);
            this.Git.TabIndex = 0;
            this.Git.Text = "Git";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Location = new System.Drawing.Point(90, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Python 2.7";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Location = new System.Drawing.Point(90, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "Microsoft Visual C++ Compiler \r\nfor Python 2.7";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Enabled = false;
            this.label3.Location = new System.Drawing.Point(90, 282);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Chrome Driver and PhantomJS Driver";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Enabled = false;
            this.label4.Location = new System.Drawing.Point(90, 332);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Clone PoGoMap-GUI to desktop";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Location = new System.Drawing.Point(43, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(41, 40);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Enabled = false;
            this.pictureBox2.Location = new System.Drawing.Point(43, 73);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(41, 40);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Enabled = false;
            this.pictureBox3.Location = new System.Drawing.Point(43, 125);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(41, 40);
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Enabled = false;
            this.pictureBox4.Location = new System.Drawing.Point(43, 177);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(41, 40);
            this.pictureBox4.TabIndex = 8;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Enabled = false;
            this.pictureBox5.Location = new System.Drawing.Point(43, 269);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(41, 40);
            this.pictureBox5.TabIndex = 9;
            this.pictureBox5.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Enabled = false;
            this.label5.Location = new System.Drawing.Point(90, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "NodeJS";
            // 
            // pictureBox6
            // 
            this.pictureBox6.Enabled = false;
            this.pictureBox6.Location = new System.Drawing.Point(43, 321);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(41, 40);
            this.pictureBox6.TabIndex = 11;
            this.pictureBox6.TabStop = false;
            // 
            // CloneWorker
            // 
            this.CloneWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.CloneWorker_DoWork);
            this.CloneWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.CloneWorker_RunWorkerCompleted);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 471);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(286, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Start Installation";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(166, 47);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(129, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "Step 2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // PoGoConfigWorker
            // 
            this.PoGoConfigWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.PoGoConfigWorker_DoWork);
            this.PoGoConfigWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.PoGoConfigWorker_RunWorkerCompleted);
            // 
            // pictureBox7
            // 
            this.pictureBox7.Enabled = false;
            this.pictureBox7.Location = new System.Drawing.Point(43, 375);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(41, 40);
            this.pictureBox7.TabIndex = 15;
            this.pictureBox7.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Enabled = false;
            this.label6.Location = new System.Drawing.Point(90, 386);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(213, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Configure PokemonGo-Map and PokeAlarm";
            // 
            // pictureBox8
            // 
            this.pictureBox8.Enabled = false;
            this.pictureBox8.Location = new System.Drawing.Point(43, 428);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(41, 40);
            this.pictureBox8.TabIndex = 17;
            this.pictureBox8.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Enabled = false;
            this.label7.Location = new System.Drawing.Point(90, 439);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Download/Install Pikaptcha";
            // 
            // AccountCreatorWorker
            // 
            this.AccountCreatorWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.AccountCreatorWorker_DoWork);
            this.AccountCreatorWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.AccountCreatorWorker_RunWorkerCompleted);
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 358);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(291, 14);
            this.label8.TabIndex = 18;
            this.label8.Text = "---------------- Restart Computer ----------------";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Enabled = false;
            this.label9.Location = new System.Drawing.Point(90, 238);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = ".Net 3.5";
            // 
            // pictureBox9
            // 
            this.pictureBox9.Enabled = false;
            this.pictureBox9.Location = new System.Drawing.Point(43, 223);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(41, 40);
            this.pictureBox9.TabIndex = 19;
            this.pictureBox9.TabStop = false;
            // 
            // NetWorker
            // 
            this.NetWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.NetWorker_DoWork);
            this.NetWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.NetWorker_RunWorkerCompleted);
            // 
            // STATUS
            // 
            this.STATUS.AutoSize = true;
            this.STATUS.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::PoGoMap_GUI_installer.Properties.Settings.Default, "STATUStext", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.STATUS.Location = new System.Drawing.Point(265, 9);
            this.STATUS.Name = "STATUS";
            this.STATUS.Size = new System.Drawing.Size(38, 13);
            this.STATUS.TabIndex = 21;
            this.STATUS.Text = global::PoGoMap_GUI_installer.Properties.Settings.Default.STATUStext;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(310, 500);
            this.Controls.Add(this.STATUS);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Git);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label8);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PoGoMap-GUI Installer";
            this.Shown += new System.EventHandler(this.Form1_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker GitWorker;
        private System.ComponentModel.BackgroundWorker PythonWorker;
        private System.ComponentModel.BackgroundWorker PythonCPPWorker;
        private System.ComponentModel.BackgroundWorker NpmWorker;
        private System.ComponentModel.BackgroundWorker chromephantomWorker;
        private System.Windows.Forms.Label Git;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.ComponentModel.BackgroundWorker CloneWorker;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.ComponentModel.BackgroundWorker PoGoConfigWorker;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Label label7;
        private System.ComponentModel.BackgroundWorker AccountCreatorWorker;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.ComponentModel.BackgroundWorker NetWorker;
        private System.Windows.Forms.Label STATUS;
    }
}

