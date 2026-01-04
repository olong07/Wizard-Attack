using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Wizard_Attack.Properties;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;


namespace Wizard_Attack
{
    public partial class GameplayScreen : Form
    {
        private PlayerStats playerStats;
        private PlayerStats cpuStats;
        private string selectedPlayerElement;
        private string selectedCpuElement;

        private Dictionary<string, Dictionary<string, double>> elementalAdvantages = new Dictionary<string, Dictionary<string, double>>
        {
            { "Fire", new Dictionary<string, double> { { "Air", 0.5 }, { "Water", 1.5 }, { "Earth", 1.0 }, { "Fire", 1.0 } } },
            { "Water", new Dictionary<string, double> { { "Fire", 0.5 }, { "Earth", 1.5 }, { "Air", 1.0 }, { "Water", 1.0 } } },
            { "Earth", new Dictionary<string, double> { { "Water", 0.5 }, { "Air", 1.5 }, { "Fire", 1.0 }, { "Earth", 1.0 } } },
            { "Air", new Dictionary<string, double> { { "Earth", 0.5 }, { "Fire", 1.5 }, { "Water", 1.0 }, { "Air", 1.0 } } }
        };

        public GameplayScreen()
        {
            InitializeComponent();

        }

        private void GameplayScreen_Load(object sender, EventArgs e)
        {
            //Use this at the end of each round to change the opp element.
            //Random rnd = new Random();
            //int index = rnd.Next(0, 4);
            //StatScreen.selectedCpuElement = elementalAdvantages.Keys.ElementAt(index);


            lbl_cpuElement.Text = "CPU Element: " + StatScreen.selectedCpuElement;
            lbl_playerElement.Text = "Player Element: " + StatScreen.selectedPlayerElement;

            switch (StatScreen.selectedPlayerElement)
            {
                case "Fire":
                    picbox_player.Image = Properties.Resources.Wizard___R_Fire;
                    break;
                case "Water":
                    picbox_player.Image = Properties.Resources.Wizard___R_Water;
                    break;
                case "Earth":
                    picbox_player.Image = Properties.Resources.Wizard___R_Earth;
                    break;
                case "Air":
                    picbox_player.Image = Properties.Resources.Wizard___R_Air;
                    break;
            }

            switch (StatScreen.selectedCpuElement)
            {
                case "Fire":
                    picbox_cpu.Image = Properties.Resources.Wizard___L_Fire;
                    break;
                case "Water":
                    picbox_cpu.Image = Properties.Resources.Wizard___L_Water;
                    break;
                case "Earth":
                    picbox_cpu.Image = Properties.Resources.Wizard___L_Earth;
                    break;
                case "Air":
                    picbox_cpu.Image = Properties.Resources.Wizard___L_Air;
                    break;
            }
            lbl_wisdom.Text = $"Wisdom: {StatScreen.playerStats.Wisdom}";
            lbl_health.Text = $"Health: {StatScreen.playerStats.Health}";
            lbl_maxhealth.Text = $"Max Health: {StatScreen.playerStats.MaxHealth}";
            lbl_dexterity.Text = $"Dexterity: {StatScreen.playerStats.Dexterity}";

            lbl_cpuwisdom.Text = $"Wisdom: {StatScreen.cpuStats.Wisdom}";
            lbl_cpuhealth.Text = $"Health: {StatScreen.cpuStats.Health}";
            lbl_cpumaxhealth.Text = $"Max Health: {StatScreen.cpuStats.MaxHealth}";
            lbl_cpudexterity.Text = $"Dexterity: {StatScreen.cpuStats.Dexterity}";



        }

        private void btn_attack_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();

            bool playerAttacksFirst = StatScreen.playerStats.Dexterity >= StatScreen.cpuStats.Dexterity;

            double playerDamage = StatScreen.playerStats.Wisdom * elementalAdvantages[StatScreen.selectedPlayerElement][StatScreen.selectedCpuElement];
            double cpuDamage = StatScreen.cpuStats.Wisdom * elementalAdvantages[StatScreen.selectedCpuElement][StatScreen.selectedPlayerElement];

            if (StatScreen.playerStats.Health > 0 && StatScreen.cpuStats.Health > 0)
            {
                if (playerAttacksFirst)
                {
                    // Player attacks first
                    StatScreen.cpuStats.Health -= (int)playerDamage;
                    lbl_cpuhealth.Text = $"Health: {StatScreen.cpuStats.Health}";
                    lblcpuResult.Text = $"Player has done {playerDamage} damage!";

                    if (StatScreen.cpuStats.Health > 0)
                    {
                        if (rnd.Next(0, 101) <= 30)
                        {
                            playerDamage = 0;
                            lblcpuResult.Text += " Player blocked the attack!";

                        }
                        else
                        {
                            StatScreen.playerStats.Health -= (int)cpuDamage;
                            lbl_health.Text = $"Health: {StatScreen.playerStats.Health}";
                        }
                        lblplayerResult.Text = $"CPU has done {cpuDamage} damage!";
                    }
                    else
                    {
                        lblResult.Text = "A victor has been decided!";
                        MessageBox.Show("A victor has been decided!");
                        this.Close();
                    }
                }
                else
                {
                    // CPU attacks first
                    if (rnd.Next(0, 101) <= 30)
                    {
                        cpuDamage = 0;
                        lblResult.Text += " CPU blocked the attack!";

                    }
                    else
                    {
                        StatScreen.playerStats.Health -= (int)cpuDamage;
                        lbl_health.Text = $"Health: {StatScreen.playerStats.Health}";
                    }

                    StatScreen.cpuStats.Health -= (int)playerDamage;
                    lbl_cpuhealth.Text = $"Health: {StatScreen.cpuStats.Health}";

                    if (StatScreen.playerStats.Health > 0)
                    {
                        lblplayerResult.Text = $"Player has done {playerDamage} damage!";
                        lblcpuResult.Text = $"CPU has done {cpuDamage} damage!";
                    }
                    if (StatScreen.playerStats.Health <= 0 || StatScreen.cpuStats.Health <= 0)
                    {
                        lblResult.Text = "A victor has been decided!";
                        MessageBox.Show("A victor has been decided!");
                        this.Close();
                    }
                }
            }
        }
    }
}



