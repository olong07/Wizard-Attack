using System;

namespace Wizard_Attack
{
    partial class GameplayScreen
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
            this.btn_attack = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblRoundInfo = new System.Windows.Forms.Label();
            this.lblCpuWins = new System.Windows.Forms.Label();
            this.lblPlayerWins = new System.Windows.Forms.Label();
            this.lbl_wisdom = new System.Windows.Forms.Label();
            this.lbl_dexterity = new System.Windows.Forms.Label();
            this.lbl_maxhealth = new System.Windows.Forms.Label();
            this.lbl_health = new System.Windows.Forms.Label();
            this.lbl_cpuwisdom = new System.Windows.Forms.Label();
            this.lbl_cpudexterity = new System.Windows.Forms.Label();
            this.lbl_cpuhealth = new System.Windows.Forms.Label();
            this.lbl_cpumaxhealth = new System.Windows.Forms.Label();
            this.lbl_playerElement = new System.Windows.Forms.Label();
            this.lbl_cpuElement = new System.Windows.Forms.Label();
            this.picbox_player = new System.Windows.Forms.PictureBox();
            this.picbox_cpu = new System.Windows.Forms.PictureBox();
            this.lblcpuResult = new System.Windows.Forms.Label();
            this.lblplayerResult = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_cpu)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_attack
            // 
            this.btn_attack.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_attack.BackColor = System.Drawing.Color.Black;
            this.btn_attack.FlatAppearance.BorderSize = 2;
            this.btn_attack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_attack.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_attack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_attack.Location = new System.Drawing.Point(328, 347);
            this.btn_attack.MaximumSize = new System.Drawing.Size(120, 41);
            this.btn_attack.Name = "btn_attack";
            this.btn_attack.Size = new System.Drawing.Size(120, 41);
            this.btn_attack.TabIndex = 4;
            this.btn_attack.Text = "ATTACK";
            this.btn_attack.UseVisualStyleBackColor = false;
            this.btn_attack.Click += new System.EventHandler(this.btn_attack_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoEllipsis = true;
            this.lblResult.ForeColor = System.Drawing.Color.White;
            this.lblResult.Location = new System.Drawing.Point(328, 388);
            this.lblResult.MinimumSize = new System.Drawing.Size(120, 41);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(120, 41);
            this.lblResult.TabIndex = 5;
            this.lblResult.Click += new System.EventHandler(this.lblResult_Click);
            // 
            // lblRoundInfo
            // 
            this.lblRoundInfo.AutoSize = true;
            this.lblRoundInfo.BackColor = System.Drawing.Color.Transparent;
            this.lblRoundInfo.ForeColor = System.Drawing.Color.Black;
            this.lblRoundInfo.Location = new System.Drawing.Point(328, 9);
            this.lblRoundInfo.MinimumSize = new System.Drawing.Size(120, 41);
            this.lblRoundInfo.Name = "lblRoundInfo";
            this.lblRoundInfo.Size = new System.Drawing.Size(120, 41);
            this.lblRoundInfo.TabIndex = 6;
            // 
            // lblCpuWins
            // 
            this.lblCpuWins.AutoSize = true;
            this.lblCpuWins.BackColor = System.Drawing.Color.Transparent;
            this.lblCpuWins.ForeColor = System.Drawing.Color.Black;
            this.lblCpuWins.Location = new System.Drawing.Point(592, 9);
            this.lblCpuWins.MinimumSize = new System.Drawing.Size(120, 41);
            this.lblCpuWins.Name = "lblCpuWins";
            this.lblCpuWins.Size = new System.Drawing.Size(120, 41);
            this.lblCpuWins.TabIndex = 7;
            // 
            // lblPlayerWins
            // 
            this.lblPlayerWins.AutoSize = true;
            this.lblPlayerWins.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayerWins.ForeColor = System.Drawing.Color.Black;
            this.lblPlayerWins.Location = new System.Drawing.Point(50, 9);
            this.lblPlayerWins.MinimumSize = new System.Drawing.Size(120, 41);
            this.lblPlayerWins.Name = "lblPlayerWins";
            this.lblPlayerWins.Size = new System.Drawing.Size(120, 41);
            this.lblPlayerWins.TabIndex = 8;
            // 
            // lbl_wisdom
            // 
            this.lbl_wisdom.AutoSize = true;
            this.lbl_wisdom.BackColor = System.Drawing.Color.Transparent;
            this.lbl_wisdom.ForeColor = System.Drawing.Color.Black;
            this.lbl_wisdom.Location = new System.Drawing.Point(100, 401);
            this.lbl_wisdom.MinimumSize = new System.Drawing.Size(50, 0);
            this.lbl_wisdom.Name = "lbl_wisdom";
            this.lbl_wisdom.Size = new System.Drawing.Size(50, 13);
            this.lbl_wisdom.TabIndex = 16;
            // 
            // lbl_dexterity
            // 
            this.lbl_dexterity.AutoSize = true;
            this.lbl_dexterity.BackColor = System.Drawing.Color.Transparent;
            this.lbl_dexterity.ForeColor = System.Drawing.Color.Black;
            this.lbl_dexterity.Location = new System.Drawing.Point(100, 388);
            this.lbl_dexterity.MinimumSize = new System.Drawing.Size(50, 0);
            this.lbl_dexterity.Name = "lbl_dexterity";
            this.lbl_dexterity.Size = new System.Drawing.Size(50, 13);
            this.lbl_dexterity.TabIndex = 15;
            // 
            // lbl_maxhealth
            // 
            this.lbl_maxhealth.AutoSize = true;
            this.lbl_maxhealth.BackColor = System.Drawing.Color.Transparent;
            this.lbl_maxhealth.ForeColor = System.Drawing.Color.Black;
            this.lbl_maxhealth.Location = new System.Drawing.Point(100, 375);
            this.lbl_maxhealth.MinimumSize = new System.Drawing.Size(50, 0);
            this.lbl_maxhealth.Name = "lbl_maxhealth";
            this.lbl_maxhealth.Size = new System.Drawing.Size(50, 13);
            this.lbl_maxhealth.TabIndex = 14;
            // 
            // lbl_health
            // 
            this.lbl_health.AutoSize = true;
            this.lbl_health.BackColor = System.Drawing.Color.Transparent;
            this.lbl_health.ForeColor = System.Drawing.Color.Black;
            this.lbl_health.Location = new System.Drawing.Point(100, 362);
            this.lbl_health.MinimumSize = new System.Drawing.Size(50, 0);
            this.lbl_health.Name = "lbl_health";
            this.lbl_health.Size = new System.Drawing.Size(50, 13);
            this.lbl_health.TabIndex = 13;
            // 
            // lbl_cpuwisdom
            // 
            this.lbl_cpuwisdom.AutoSize = true;
            this.lbl_cpuwisdom.BackColor = System.Drawing.Color.Transparent;
            this.lbl_cpuwisdom.ForeColor = System.Drawing.Color.Black;
            this.lbl_cpuwisdom.Location = new System.Drawing.Point(619, 401);
            this.lbl_cpuwisdom.MinimumSize = new System.Drawing.Size(50, 0);
            this.lbl_cpuwisdom.Name = "lbl_cpuwisdom";
            this.lbl_cpuwisdom.Size = new System.Drawing.Size(50, 13);
            this.lbl_cpuwisdom.TabIndex = 20;
            // 
            // lbl_cpudexterity
            // 
            this.lbl_cpudexterity.AutoSize = true;
            this.lbl_cpudexterity.BackColor = System.Drawing.Color.Transparent;
            this.lbl_cpudexterity.ForeColor = System.Drawing.Color.Black;
            this.lbl_cpudexterity.Location = new System.Drawing.Point(619, 388);
            this.lbl_cpudexterity.MinimumSize = new System.Drawing.Size(50, 0);
            this.lbl_cpudexterity.Name = "lbl_cpudexterity";
            this.lbl_cpudexterity.Size = new System.Drawing.Size(50, 13);
            this.lbl_cpudexterity.TabIndex = 19;
            // 
            // lbl_cpuhealth
            // 
            this.lbl_cpuhealth.AutoSize = true;
            this.lbl_cpuhealth.BackColor = System.Drawing.Color.Transparent;
            this.lbl_cpuhealth.ForeColor = System.Drawing.Color.Black;
            this.lbl_cpuhealth.Location = new System.Drawing.Point(619, 362);
            this.lbl_cpuhealth.MinimumSize = new System.Drawing.Size(50, 0);
            this.lbl_cpuhealth.Name = "lbl_cpuhealth";
            this.lbl_cpuhealth.Size = new System.Drawing.Size(50, 13);
            this.lbl_cpuhealth.TabIndex = 18;
            // 
            // lbl_cpumaxhealth
            // 
            this.lbl_cpumaxhealth.AutoSize = true;
            this.lbl_cpumaxhealth.BackColor = System.Drawing.Color.Transparent;
            this.lbl_cpumaxhealth.ForeColor = System.Drawing.Color.Black;
            this.lbl_cpumaxhealth.Location = new System.Drawing.Point(619, 375);
            this.lbl_cpumaxhealth.MinimumSize = new System.Drawing.Size(50, 0);
            this.lbl_cpumaxhealth.Name = "lbl_cpumaxhealth";
            this.lbl_cpumaxhealth.Size = new System.Drawing.Size(50, 13);
            this.lbl_cpumaxhealth.TabIndex = 17;
            // 
            // lbl_playerElement
            // 
            this.lbl_playerElement.AutoSize = true;
            this.lbl_playerElement.BackColor = System.Drawing.Color.Transparent;
            this.lbl_playerElement.ForeColor = System.Drawing.Color.Black;
            this.lbl_playerElement.Location = new System.Drawing.Point(50, 50);
            this.lbl_playerElement.MinimumSize = new System.Drawing.Size(120, 41);
            this.lbl_playerElement.Name = "lbl_playerElement";
            this.lbl_playerElement.Size = new System.Drawing.Size(120, 41);
            this.lbl_playerElement.TabIndex = 21;
            // 
            // lbl_cpuElement
            // 
            this.lbl_cpuElement.AutoSize = true;
            this.lbl_cpuElement.BackColor = System.Drawing.Color.Transparent;
            this.lbl_cpuElement.ForeColor = System.Drawing.Color.Black;
            this.lbl_cpuElement.Location = new System.Drawing.Point(592, 50);
            this.lbl_cpuElement.MinimumSize = new System.Drawing.Size(120, 41);
            this.lbl_cpuElement.Name = "lbl_cpuElement";
            this.lbl_cpuElement.Size = new System.Drawing.Size(120, 41);
            this.lbl_cpuElement.TabIndex = 22;
            // 
            // picbox_player
            // 
            this.picbox_player.BackColor = System.Drawing.Color.Transparent;
            this.picbox_player.Location = new System.Drawing.Point(53, 123);
            this.picbox_player.Name = "picbox_player";
            this.picbox_player.Size = new System.Drawing.Size(155, 214);
            this.picbox_player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picbox_player.TabIndex = 23;
            this.picbox_player.TabStop = false;
            // 
            // picbox_cpu
            // 
            this.picbox_cpu.BackColor = System.Drawing.Color.Transparent;
            this.picbox_cpu.Location = new System.Drawing.Point(557, 123);
            this.picbox_cpu.Name = "picbox_cpu";
            this.picbox_cpu.Size = new System.Drawing.Size(155, 214);
            this.picbox_cpu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picbox_cpu.TabIndex = 24;
            this.picbox_cpu.TabStop = false;
            // 
            // lblcpuResult
            // 
            this.lblcpuResult.AutoEllipsis = true;
            this.lblcpuResult.ForeColor = System.Drawing.Color.White;
            this.lblcpuResult.Location = new System.Drawing.Point(212, 388);
            this.lblcpuResult.MinimumSize = new System.Drawing.Size(120, 41);
            this.lblcpuResult.Name = "lblcpuResult";
            this.lblcpuResult.Size = new System.Drawing.Size(120, 41);
            this.lblcpuResult.TabIndex = 25;
            // 
            // lblplayerResult
            // 
            this.lblplayerResult.AutoEllipsis = true;
            this.lblplayerResult.ForeColor = System.Drawing.Color.White;
            this.lblplayerResult.Location = new System.Drawing.Point(445, 388);
            this.lblplayerResult.MinimumSize = new System.Drawing.Size(120, 41);
            this.lblplayerResult.Name = "lblplayerResult";
            this.lblplayerResult.Size = new System.Drawing.Size(120, 41);
            this.lblplayerResult.TabIndex = 26;
            // 
            // GameplayScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::Wizard_Attack.Properties.Resources.Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblplayerResult);
            this.Controls.Add(this.lblcpuResult);
            this.Controls.Add(this.picbox_cpu);
            this.Controls.Add(this.picbox_player);
            this.Controls.Add(this.lbl_cpuElement);
            this.Controls.Add(this.lbl_playerElement);
            this.Controls.Add(this.lbl_cpuwisdom);
            this.Controls.Add(this.lbl_cpudexterity);
            this.Controls.Add(this.lbl_cpuhealth);
            this.Controls.Add(this.lbl_cpumaxhealth);
            this.Controls.Add(this.lbl_wisdom);
            this.Controls.Add(this.lbl_dexterity);
            this.Controls.Add(this.lbl_maxhealth);
            this.Controls.Add(this.lbl_health);
            this.Controls.Add(this.lblPlayerWins);
            this.Controls.Add(this.lblCpuWins);
            this.Controls.Add(this.lblRoundInfo);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btn_attack);
            this.DoubleBuffered = true;
            this.Name = "GameplayScreen";
            this.Text = "001";
            this.Load += new System.EventHandler(this.GameplayScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picbox_player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_cpu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void lblResult_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Button btn_attack;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblRoundInfo;
        private System.Windows.Forms.Label lblCpuWins;
        private System.Windows.Forms.Label lblPlayerWins;
        private System.Windows.Forms.Label lbl_wisdom;
        private System.Windows.Forms.Label lbl_dexterity;
        private System.Windows.Forms.Label lbl_maxhealth;
        private System.Windows.Forms.Label lbl_health;
        private System.Windows.Forms.Label lbl_cpuwisdom;
        private System.Windows.Forms.Label lbl_cpudexterity;
        private System.Windows.Forms.Label lbl_cpuhealth;
        private System.Windows.Forms.Label lbl_cpumaxhealth;
        private System.Windows.Forms.Label lbl_playerElement;
        private System.Windows.Forms.Label lbl_cpuElement;
        private System.Windows.Forms.PictureBox picbox_player;
        private System.Windows.Forms.PictureBox picbox_cpu;
        private System.Windows.Forms.Label lblcpuResult;
        private System.Windows.Forms.Label lblplayerResult;
    }
}