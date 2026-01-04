using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Wizard_Attack.Properties;

namespace Wizard_Attack
{
    public partial class StatScreen : Form
    {
        private readonly Random random;
        private bool generateButtonClicked = false;
        public static PlayerStats playerStats;
        public static PlayerStats cpuStats;
        public static string selectedPlayerElement;
        public static string selectedCpuElement;


        public StatScreen()
        {
            InitializeComponent();
            random = new Random();
            btn_play.Enabled = false;
            btn_air.Enabled = false;
            btn_fire.Enabled = false;
            btn_water.Enabled = false;
            btn_earth.Enabled = false;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            picbox_player.Image = Resources.Wizard_Original_R;
            picbox_cpu.Image = Resources.Wizard_Original_L;

        }

        internal void btn_play_Click(object sender, EventArgs e)
        {
            
            string[] elements = { "Fire", "Air", "Earth", "Water" };
   

            int randomIndex = random.Next(0, elements.Length);

            selectedCpuElement =  elements[randomIndex];
            MessageBox.Show($"CPU have picked: {selectedCpuElement}");

            var myForm = new GameplayScreen();
            myForm.Show();
            this.Hide();

        }

        public static class ElementHelper
        {
            public static string[] Elements { get; } = { "Fire", "Air", "Earth", "Water" };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            selectedPlayerElement = "Fire";
            picbox_player.Image = Resources.Wizard___R_Fire;
            btn_play.Enabled = true;
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {

        }

        private void btn_air_Click(object sender, EventArgs e)
        {
            selectedPlayerElement = "Air";
            picbox_player.Image = Resources.Wizard___R_Air;
            btn_play.Enabled = true;
        }

        private void btn_Earth_Click(object sender, EventArgs e)
        {
            selectedPlayerElement = "Earth";
            picbox_player.Image = Resources.Wizard___R_Earth;
            btn_play.Enabled = true;
        }

        private void btn_water_Click(object sender, EventArgs e)
        {
            selectedPlayerElement = "Water";
            picbox_player.Image = Resources.Wizard___R_Water;
            btn_play.Enabled = true;
        }

        private void btn_firecpu_Click(object sender, EventArgs e)
        {
            selectedCpuElement = "Fire";
            picbox_cpu.Image = Resources.Wizard___L_Fire;
        }

        private void btn_aircpu_Click(object sender, EventArgs e)
        {
            selectedCpuElement = "Air";
            picbox_cpu.Image = Resources.Wizard___L_Air;
        }

        private void btn_eathcpu_Click(object sender, EventArgs e)
        {
            selectedCpuElement = "Earth";
            picbox_cpu.Image = Resources.Wizard___L_Earth;
        }

        private void btn_watercpu_Click(object sender, EventArgs e)
        {
            selectedCpuElement = "Water";
            picbox_cpu.Image = Resources.Wizard___L_Water;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btn_generate_Click(object sender, EventArgs e)
        {
            btn_generate.Enabled = false;
            btn_air.Enabled = true;
            btn_fire.Enabled = true;
            btn_water.Enabled = true;
            btn_earth.Enabled = true;
            int health = random.Next(100, 101);
            int maxHealth = random.Next(health, 101);
            int dexterity = random.Next(1, 101);
            int wisdom = random.Next(1, 101);


            lbl_health.Text = $"Health: {health}";
            lbl_maxhealth.Text = $"Maximum Health: {maxHealth}";
            lbl_dexterity.Text = $"Dexterity: {dexterity}";
            lbl_wisdom.Text = $"Wisdom: {wisdom}";

            playerStats = new PlayerStats
            {
                Health = health,
                MaxHealth = maxHealth,
                Dexterity = dexterity,
                Wisdom = wisdom
            };

            int cpuhealth = random.Next(100, 101);
            int cpumaxHealth = random.Next(health, 101);
            int cpudexterity = random.Next(1, 101);
            int cpuwisdom = random.Next(1, 101);

            cpuStats = new PlayerStats
            {
                Health = cpuhealth,
                MaxHealth = cpumaxHealth,
                Dexterity = cpudexterity,
                Wisdom = cpuwisdom
            };

            lbl_cpuhealth.Text = $"Health: {cpuhealth}";
            lbl_cpumaxhealth.Text = $"Maximum Health: {cpumaxHealth}";
            lbl_cpudexterity.Text = $"Dexterity: {cpudexterity}";
            lbl_cpuwisdom.Text = $"Wisdom: {cpuwisdom}";

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void lbl_cpuhealth_Click(object sender, EventArgs e)
        {

        }

        private void picbox_cpu_Click(object sender, EventArgs e)
        {
        }
    }

    public class PlayerStats
    {
        public int Health { get; set; }
        public int MaxHealth { get; set; }
        public int Dexterity { get; set; }
        public int Wisdom { get; set; }
    }
}


