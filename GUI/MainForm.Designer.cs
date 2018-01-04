namespace GUI
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.StrengthInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ParryRatingInput = new System.Windows.Forms.TextBox();
            this.ParryChanceNoDR = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ParryChanceDR = new System.Windows.Forms.TextBox();
            this.ParryTab = new System.Windows.Forms.TabControl();
            this.ParryChanceTab = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.RotFCCheckBox = new System.Windows.Forms.CheckBox();
            this.MotWCheckBox = new System.Windows.Forms.CheckBox();
            this.DamageReductionTab = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.TotalResilRating = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.BaseLineLable = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ResilienceDeltaPvP = new System.Windows.Forms.TextBox();
            this.ResiliencePercentage = new System.Windows.Forms.TextBox();
            this.MetaGemChoice = new System.Windows.Forms.ComboBox();
            this.MetaGemLabel = new System.Windows.Forms.Label();
            this.ResilienceRatingLabel = new System.Windows.Forms.Label();
            this.ResilRatingAmount = new System.Windows.Forms.TextBox();
            this.BaseResilChoice = new System.Windows.Forms.ComboBox();
            this.BaseResiliencePercentage = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TotalDR = new System.Windows.Forms.TextBox();
            this.HealingTab = new System.Windows.Forms.TabPage();
            this.EffectiveHealthTextBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.HealthTabResilience = new System.Windows.Forms.TextBox();
            this.Stamina = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.ParryTab.SuspendLayout();
            this.ParryChanceTab.SuspendLayout();
            this.DamageReductionTab.SuspendLayout();
            this.HealingTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // StrengthInput
            // 
            this.StrengthInput.Location = new System.Drawing.Point(112, 75);
            this.StrengthInput.Name = "StrengthInput";
            this.StrengthInput.Size = new System.Drawing.Size(100, 20);
            this.StrengthInput.TabIndex = 1;
            this.StrengthInput.TextChanged += new System.EventHandler(this.StrengthInput_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Strength";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Parry Rating";
            // 
            // ParryRatingInput
            // 
            this.ParryRatingInput.Location = new System.Drawing.Point(112, 33);
            this.ParryRatingInput.Name = "ParryRatingInput";
            this.ParryRatingInput.Size = new System.Drawing.Size(100, 20);
            this.ParryRatingInput.TabIndex = 4;
            this.ParryRatingInput.TextChanged += new System.EventHandler(this.ParryRatingInput_TextChanged);
            // 
            // ParryChanceNoDR
            // 
            this.ParryChanceNoDR.Location = new System.Drawing.Point(418, 33);
            this.ParryChanceNoDR.Name = "ParryChanceNoDR";
            this.ParryChanceNoDR.ReadOnly = true;
            this.ParryChanceNoDR.Size = new System.Drawing.Size(100, 20);
            this.ParryChanceNoDR.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(221, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Parry Chance (before DR)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(221, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Parry Chance (applied DR)";
            // 
            // ParryChanceDR
            // 
            this.ParryChanceDR.Location = new System.Drawing.Point(418, 77);
            this.ParryChanceDR.Name = "ParryChanceDR";
            this.ParryChanceDR.ReadOnly = true;
            this.ParryChanceDR.Size = new System.Drawing.Size(100, 20);
            this.ParryChanceDR.TabIndex = 8;
            this.ParryChanceDR.TextChanged += new System.EventHandler(this.ParryChance_StatsChanged);
            // 
            // ParryTab
            // 
            this.ParryTab.Controls.Add(this.ParryChanceTab);
            this.ParryTab.Controls.Add(this.DamageReductionTab);
            this.ParryTab.Controls.Add(this.HealingTab);
            this.ParryTab.Location = new System.Drawing.Point(-1, 0);
            this.ParryTab.Name = "ParryTab";
            this.ParryTab.SelectedIndex = 0;
            this.ParryTab.Size = new System.Drawing.Size(629, 326);
            this.ParryTab.TabIndex = 9;
            // 
            // ParryChanceTab
            // 
            this.ParryChanceTab.Controls.Add(this.label11);
            this.ParryChanceTab.Controls.Add(this.RotFCCheckBox);
            this.ParryChanceTab.Controls.Add(this.MotWCheckBox);
            this.ParryChanceTab.Controls.Add(this.StrengthInput);
            this.ParryChanceTab.Controls.Add(this.label4);
            this.ParryChanceTab.Controls.Add(this.ParryChanceDR);
            this.ParryChanceTab.Controls.Add(this.ParryRatingInput);
            this.ParryChanceTab.Controls.Add(this.label1);
            this.ParryChanceTab.Controls.Add(this.label2);
            this.ParryChanceTab.Controls.Add(this.ParryChanceNoDR);
            this.ParryChanceTab.Controls.Add(this.label3);
            this.ParryChanceTab.Location = new System.Drawing.Point(4, 22);
            this.ParryChanceTab.Name = "ParryChanceTab";
            this.ParryChanceTab.Padding = new System.Windows.Forms.Padding(3);
            this.ParryChanceTab.Size = new System.Drawing.Size(621, 300);
            this.ParryChanceTab.TabIndex = 0;
            this.ParryChanceTab.Text = "Parry Chance";
            this.ParryChanceTab.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(19, 105);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(123, 17);
            this.label11.TabIndex = 13;
            this.label11.Text = "Strength Modifiers";
            // 
            // RotFCCheckBox
            // 
            this.RotFCCheckBox.AutoSize = true;
            this.RotFCCheckBox.Location = new System.Drawing.Point(148, 125);
            this.RotFCCheckBox.Name = "RotFCCheckBox";
            this.RotFCCheckBox.Size = new System.Drawing.Size(158, 17);
            this.RotFCCheckBox.TabIndex = 11;
            this.RotFCCheckBox.Text = "Rune of the Fallen Crusader\r\n";
            this.RotFCCheckBox.UseVisualStyleBackColor = true;
            this.RotFCCheckBox.CheckedChanged += new System.EventHandler(this.RotFC_CheckedChanged);
            // 
            // MotWCheckBox
            // 
            this.MotWCheckBox.AutoSize = true;
            this.MotWCheckBox.Location = new System.Drawing.Point(38, 125);
            this.MotWCheckBox.Name = "MotWCheckBox";
            this.MotWCheckBox.Size = new System.Drawing.Size(104, 17);
            this.MotWCheckBox.TabIndex = 9;
            this.MotWCheckBox.Text = "Mark of the Wild";
            this.MotWCheckBox.UseVisualStyleBackColor = true;
            this.MotWCheckBox.CheckedChanged += new System.EventHandler(this.MotW_CheckedChanged);
            // 
            // DamageReductionTab
            // 
            this.DamageReductionTab.Controls.Add(this.label8);
            this.DamageReductionTab.Controls.Add(this.TotalResilRating);
            this.DamageReductionTab.Controls.Add(this.label7);
            this.DamageReductionTab.Controls.Add(this.BaseLineLable);
            this.DamageReductionTab.Controls.Add(this.label6);
            this.DamageReductionTab.Controls.Add(this.ResilienceDeltaPvP);
            this.DamageReductionTab.Controls.Add(this.ResiliencePercentage);
            this.DamageReductionTab.Controls.Add(this.MetaGemChoice);
            this.DamageReductionTab.Controls.Add(this.MetaGemLabel);
            this.DamageReductionTab.Controls.Add(this.ResilienceRatingLabel);
            this.DamageReductionTab.Controls.Add(this.ResilRatingAmount);
            this.DamageReductionTab.Controls.Add(this.BaseResilChoice);
            this.DamageReductionTab.Controls.Add(this.BaseResiliencePercentage);
            this.DamageReductionTab.Controls.Add(this.label5);
            this.DamageReductionTab.Controls.Add(this.TotalDR);
            this.DamageReductionTab.Location = new System.Drawing.Point(4, 22);
            this.DamageReductionTab.Name = "DamageReductionTab";
            this.DamageReductionTab.Padding = new System.Windows.Forms.Padding(3);
            this.DamageReductionTab.Size = new System.Drawing.Size(621, 300);
            this.DamageReductionTab.TabIndex = 1;
            this.DamageReductionTab.Text = "Damage Reduction";
            this.DamageReductionTab.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(305, 140);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Total Resilience Rating";
            // 
            // TotalResilRating
            // 
            this.TotalResilRating.Location = new System.Drawing.Point(428, 137);
            this.TotalResilRating.Name = "TotalResilRating";
            this.TotalResilRating.ReadOnly = true;
            this.TotalResilRating.Size = new System.Drawing.Size(100, 20);
            this.TotalResilRating.TabIndex = 13;
            this.TotalResilRating.TextChanged += new System.EventHandler(this.textBox1_TextChanged_2);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(52, 191);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 26);
            this.label7.TabIndex = 12;
            this.label7.Text = "With PvP Trinket \r\nSet Bonus";
            // 
            // BaseLineLable
            // 
            this.BaseLineLable.AutoSize = true;
            this.BaseLineLable.Location = new System.Drawing.Point(47, 140);
            this.BaseLineLable.Name = "BaseLineLable";
            this.BaseLineLable.Size = new System.Drawing.Size(96, 13);
            this.BaseLineLable.TabIndex = 11;
            this.BaseLineLable.Text = "Over Baseline (0%)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 249);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Total PvP Resilience";
            // 
            // ResilienceDeltaPvP
            // 
            this.ResilienceDeltaPvP.Location = new System.Drawing.Point(180, 188);
            this.ResilienceDeltaPvP.Name = "ResilienceDeltaPvP";
            this.ResilienceDeltaPvP.ReadOnly = true;
            this.ResilienceDeltaPvP.Size = new System.Drawing.Size(100, 20);
            this.ResilienceDeltaPvP.TabIndex = 9;
            this.ResilienceDeltaPvP.TextChanged += new System.EventHandler(this.Resilience_TextChanged);
            // 
            // ResiliencePercentage
            // 
            this.ResiliencePercentage.Location = new System.Drawing.Point(180, 246);
            this.ResiliencePercentage.Name = "ResiliencePercentage";
            this.ResiliencePercentage.ReadOnly = true;
            this.ResiliencePercentage.Size = new System.Drawing.Size(100, 20);
            this.ResiliencePercentage.TabIndex = 8;
            this.ResiliencePercentage.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // MetaGemChoice
            // 
            this.MetaGemChoice.FormattingEnabled = true;
            this.MetaGemChoice.Items.AddRange(new object[] {
            "none",
            "pvp",
            "effulgent"});
            this.MetaGemChoice.Location = new System.Drawing.Point(428, 26);
            this.MetaGemChoice.Name = "MetaGemChoice";
            this.MetaGemChoice.Size = new System.Drawing.Size(121, 21);
            this.MetaGemChoice.TabIndex = 7;
            this.MetaGemChoice.SelectedIndexChanged += new System.EventHandler(this.MetaGemChoice_SelectedIndexChanged);
            // 
            // MetaGemLabel
            // 
            this.MetaGemLabel.AutoSize = true;
            this.MetaGemLabel.Location = new System.Drawing.Point(341, 29);
            this.MetaGemLabel.Name = "MetaGemLabel";
            this.MetaGemLabel.Size = new System.Drawing.Size(56, 13);
            this.MetaGemLabel.TabIndex = 6;
            this.MetaGemLabel.Text = "Meta Gem";
            // 
            // ResilienceRatingLabel
            // 
            this.ResilienceRatingLabel.AutoSize = true;
            this.ResilienceRatingLabel.Location = new System.Drawing.Point(47, 65);
            this.ResilienceRatingLabel.Name = "ResilienceRatingLabel";
            this.ResilienceRatingLabel.Size = new System.Drawing.Size(90, 13);
            this.ResilienceRatingLabel.TabIndex = 5;
            this.ResilienceRatingLabel.Text = "Resilience Rating";
            // 
            // ResilRatingAmount
            // 
            this.ResilRatingAmount.Location = new System.Drawing.Point(180, 65);
            this.ResilRatingAmount.Name = "ResilRatingAmount";
            this.ResilRatingAmount.Size = new System.Drawing.Size(100, 20);
            this.ResilRatingAmount.TabIndex = 4;
            this.ResilRatingAmount.Text = "0";
            this.ResilRatingAmount.TextChanged += new System.EventHandler(this.ResilRating_TextChanged);
            // 
            // BaseResilChoice
            // 
            this.BaseResilChoice.FormattingEnabled = true;
            this.BaseResilChoice.Items.AddRange(new object[] {
            "0.77",
            "0.8"});
            this.BaseResilChoice.Location = new System.Drawing.Point(180, 26);
            this.BaseResilChoice.Name = "BaseResilChoice";
            this.BaseResilChoice.Size = new System.Drawing.Size(121, 21);
            this.BaseResilChoice.TabIndex = 3;
            this.BaseResilChoice.SelectedIndexChanged += new System.EventHandler(this.BaseResil_SelectedIndexChanged);
            // 
            // BaseResiliencePercentage
            // 
            this.BaseResiliencePercentage.AutoSize = true;
            this.BaseResiliencePercentage.Location = new System.Drawing.Point(37, 29);
            this.BaseResiliencePercentage.Name = "BaseResiliencePercentage";
            this.BaseResiliencePercentage.Size = new System.Drawing.Size(100, 13);
            this.BaseResiliencePercentage.TabIndex = 2;
            this.BaseResiliencePercentage.Text = "Resilience (Base %)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(37, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Damage Reduction ";
            // 
            // TotalDR
            // 
            this.TotalDR.Location = new System.Drawing.Point(180, 137);
            this.TotalDR.Name = "TotalDR";
            this.TotalDR.ReadOnly = true;
            this.TotalDR.Size = new System.Drawing.Size(100, 20);
            this.TotalDR.TabIndex = 0;
            this.TotalDR.TextChanged += new System.EventHandler(this.InputStatsChanged);
            // 
            // HealingTab
            // 
            this.HealingTab.Controls.Add(this.EffectiveHealthTextBox);
            this.HealingTab.Controls.Add(this.label12);
            this.HealingTab.Controls.Add(this.label10);
            this.HealingTab.Controls.Add(this.label9);
            this.HealingTab.Controls.Add(this.HealthTabResilience);
            this.HealingTab.Controls.Add(this.Stamina);
            this.HealingTab.Location = new System.Drawing.Point(4, 22);
            this.HealingTab.Name = "HealingTab";
            this.HealingTab.Size = new System.Drawing.Size(621, 300);
            this.HealingTab.TabIndex = 2;
            this.HealingTab.Text = "Healing / Health";
            this.HealingTab.UseVisualStyleBackColor = true;
            // 
            // EffectiveHealthTextBox
            // 
            this.EffectiveHealthTextBox.Location = new System.Drawing.Point(343, 68);
            this.EffectiveHealthTextBox.Name = "EffectiveHealthTextBox";
            this.EffectiveHealthTextBox.ReadOnly = true;
            this.EffectiveHealthTextBox.Size = new System.Drawing.Size(100, 20);
            this.EffectiveHealthTextBox.TabIndex = 5;
            this.EffectiveHealthTextBox.TextChanged += new System.EventHandler(this.EffectiveHealth_StatsChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(241, 71);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(83, 13);
            this.label12.TabIndex = 4;
            this.label12.Text = "Effective Health";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(241, 35);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "Resilience";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(31, 35);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Stamina";
            // 
            // HealthTabResilience
            // 
            this.HealthTabResilience.Location = new System.Drawing.Point(343, 32);
            this.HealthTabResilience.Name = "HealthTabResilience";
            this.HealthTabResilience.ReadOnly = true;
            this.HealthTabResilience.Size = new System.Drawing.Size(100, 20);
            this.HealthTabResilience.TabIndex = 1;
            // 
            // Stamina
            // 
            this.Stamina.Location = new System.Drawing.Point(100, 32);
            this.Stamina.Name = "Stamina";
            this.Stamina.Size = new System.Drawing.Size(100, 20);
            this.Stamina.TabIndex = 0;
            this.Stamina.TextChanged += new System.EventHandler(this.Stamina_InputChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 327);
            this.Controls.Add(this.ParryTab);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ParryTab.ResumeLayout(false);
            this.ParryChanceTab.ResumeLayout(false);
            this.ParryChanceTab.PerformLayout();
            this.DamageReductionTab.ResumeLayout(false);
            this.DamageReductionTab.PerformLayout();
            this.HealingTab.ResumeLayout(false);
            this.HealingTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox StrengthInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ParryRatingInput;
        private System.Windows.Forms.TextBox ParryChanceNoDR;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ParryChanceDR;
        private System.Windows.Forms.TabControl ParryTab;
        private System.Windows.Forms.TabPage ParryChanceTab;
        private System.Windows.Forms.TabPage DamageReductionTab;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TotalDR;
        private System.Windows.Forms.ComboBox BaseResilChoice;
        private System.Windows.Forms.Label BaseResiliencePercentage;
        private System.Windows.Forms.Label ResilienceRatingLabel;
        private System.Windows.Forms.TextBox ResilRatingAmount;
        private System.Windows.Forms.Label MetaGemLabel;
        private System.Windows.Forms.ComboBox MetaGemChoice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ResilienceDeltaPvP;
        private System.Windows.Forms.TextBox ResiliencePercentage;
        protected System.Windows.Forms.Label BaseLineLable;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TotalResilRating;
        private System.Windows.Forms.CheckBox RotFCCheckBox;
        private System.Windows.Forms.CheckBox MotWCheckBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TabPage HealingTab;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox HealthTabResilience;
        private System.Windows.Forms.TextBox Stamina;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox EffectiveHealthTextBox;
        private System.Windows.Forms.Label label12;
    }
}

