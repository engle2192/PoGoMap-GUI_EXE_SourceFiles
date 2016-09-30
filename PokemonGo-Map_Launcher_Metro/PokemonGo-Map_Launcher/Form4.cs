using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using MetroFramework;

namespace PokemonGo_Map_Launcher
{
    public partial class Form4 : MetroForm
    {
        public Form4()
        {
            InitializeComponent();
            this.StyleManager = metroStyleManager1;
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            //if (Properties.Settings.Default.StyleTheme == "Dark Theme")
            //{
            //    metroStyleManager1.Theme = MetroThemeStyle.Light;
            //}
            //else
            //{
            //    metroStyleManager1.Theme = MetroThemeStyle.Dark;
            //}
        }
    }
}
