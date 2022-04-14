using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Text;
using System.Drawing;

namespace Gym
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Restart ();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            PrivateFontCollection pfc = new PrivateFontCollection();
            pfc.AddFontFile("Nunito-Bold.ttf");
        }

        private void logOutButton_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void memberButton_Click(object sender, EventArgs e)
        {
            var member = new Member();
        }
    }
}
