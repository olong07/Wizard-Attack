using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wizard_Attack
{
    public partial class StartScreen : Form
    {
        public StartScreen()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.Black;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_play_Click(object sender, EventArgs e)
        {
            var StartScreen = new StatScreen();
            StartScreen.Show();
            this.Hide();
        }
    }
}
