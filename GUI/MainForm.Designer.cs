﻿namespace GUI
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
            this.VictoryBox = new System.Windows.Forms.CheckBox();
            this.TimelessNutrient = new System.Windows.Forms.CheckBox();
            this.Yulon = new System.Windows.Forms.CheckBox();
            this.ExpertiseInput = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.DominanceBox = new System.Windows.Forms.CheckBox();
            this.ParryExpertise = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.StrengthBuffed = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.InsanityCrystal = new System.Windows.Forms.CheckBox();
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
            this.TimelessNutrient2 = new System.Windows.Forms.CheckBox();
            this.Yulon2 = new System.Windows.Forms.CheckBox();
            this.label20 = new System.Windows.Forms.Label();
            this.StaminaBuffed = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.InsanityCrystal2 = new System.Windows.Forms.CheckBox();
            this.FortitudeCheckBox = new System.Windows.Forms.CheckBox();
            this.DisplayHealth = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.ConversionHps = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.PvpPowerPercentage = new System.Windows.Forms.TextBox();
            this.BPCheckBox = new System.Windows.Forms.CheckBox();
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
            this.ParryChanceNoDR.Location = new System.Drawing.Point(446, 33);
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
            this.ParryChanceDR.Location = new System.Drawing.Point(446, 76);
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
            this.ParryChanceTab.Controls.Add(this.VictoryBox);
            this.ParryChanceTab.Controls.Add(this.TimelessNutrient);
            this.ParryChanceTab.Controls.Add(this.Yulon);
            this.ParryChanceTab.Controls.Add(this.ExpertiseInput);
            this.ParryChanceTab.Controls.Add(this.label18);
            this.ParryChanceTab.Controls.Add(this.DominanceBox);
            this.ParryChanceTab.Controls.Add(this.ParryExpertise);
            this.ParryChanceTab.Controls.Add(this.label17);
            this.ParryChanceTab.Controls.Add(this.StrengthBuffed);
            this.ParryChanceTab.Controls.Add(this.label16);
            this.ParryChanceTab.Controls.Add(this.InsanityCrystal);
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
            // VictoryBox
            // 
            this.VictoryBox.AutoSize = true;
            this.VictoryBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.VictoryBox.Location = new System.Drawing.Point(429, 229);
            this.VictoryBox.Name = "VictoryBox";
            this.VictoryBox.Size = new System.Drawing.Size(104, 17);
            this.VictoryBox.TabIndex = 26;
            this.VictoryBox.Text = "Badge of Victory";
            this.VictoryBox.UseVisualStyleBackColor = true;
            this.VictoryBox.CheckedChanged += new System.EventHandler(this.VictoryCheck_Changed);
            // 
            // TimelessNutrient
            // 
            this.TimelessNutrient.AutoSize = true;
            this.TimelessNutrient.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.TimelessNutrient.Location = new System.Drawing.Point(316, 252);
            this.TimelessNutrient.Name = "TimelessNutrient";
            this.TimelessNutrient.Size = new System.Drawing.Size(107, 17);
            this.TimelessNutrient.TabIndex = 25;
            this.TimelessNutrient.Text = "Timeless Nutrient";
            this.TimelessNutrient.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TimelessNutrient.UseVisualStyleBackColor = true;
            this.TimelessNutrient.CheckedChanged += new System.EventHandler(this.TimelessNutrient_Checked);
            // 
            // Yulon
            // 
            this.Yulon.AutoSize = true;
            this.Yulon.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Yulon.Location = new System.Drawing.Point(71, 252);
            this.Yulon.Name = "Yulon";
            this.Yulon.Size = new System.Drawing.Size(110, 17);
            this.Yulon.TabIndex = 24;
            this.Yulon.Text = "Strength of Yu\'lon";
            this.Yulon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Yulon.UseVisualStyleBackColor = true;
            this.Yulon.CheckedChanged += new System.EventHandler(this.Yulon_Checked);
            // 
            // ExpertiseInput
            // 
            this.ExpertiseInput.Location = new System.Drawing.Point(111, 167);
            this.ExpertiseInput.Name = "ExpertiseInput";
            this.ExpertiseInput.Size = new System.Drawing.Size(100, 20);
            this.ExpertiseInput.TabIndex = 23;
            this.ExpertiseInput.TextChanged += new System.EventHandler(this.Expertise_Changed);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(19, 170);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(92, 17);
            this.label18.TabIndex = 22;
            this.label18.Text = "Expertise (%)";
            // 
            // DominanceBox
            // 
            this.DominanceBox.AutoSize = true;
            this.DominanceBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.DominanceBox.Location = new System.Drawing.Point(297, 229);
            this.DominanceBox.Name = "DominanceBox";
            this.DominanceBox.Size = new System.Drawing.Size(126, 17);
            this.DominanceBox.TabIndex = 21;
            this.DominanceBox.Text = "Badge of Dominance";
            this.DominanceBox.UseVisualStyleBackColor = true;
            this.DominanceBox.CheckedChanged += new System.EventHandler(this.DominanceCheck_Changed);
            // 
            // ParryExpertise
            // 
            this.ParryExpertise.Location = new System.Drawing.Point(446, 120);
            this.ParryExpertise.Name = "ParryExpertise";
            this.ParryExpertise.ReadOnly = true;
            this.ParryExpertise.Size = new System.Drawing.Size(100, 20);
            this.ParryExpertise.TabIndex = 19;
            this.ParryExpertise.TextChanged += new System.EventHandler(this.ParryChanceExpertise);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(221, 119);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(216, 17);
            this.label17.TabIndex = 18;
            this.label17.Text = "Parry Chance (applied Expertise)";
            // 
            // StrengthBuffed
            // 
            this.StrengthBuffed.Location = new System.Drawing.Point(111, 124);
            this.StrengthBuffed.Name = "StrengthBuffed";
            this.StrengthBuffed.ReadOnly = true;
            this.StrengthBuffed.Size = new System.Drawing.Size(100, 20);
            this.StrengthBuffed.TabIndex = 17;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(20, 127);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(86, 13);
            this.label16.TabIndex = 16;
            this.label16.Text = "Strength (buffed)";
            // 
            // InsanityCrystal
            // 
            this.InsanityCrystal.AutoSize = true;
            this.InsanityCrystal.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.InsanityCrystal.Location = new System.Drawing.Point(187, 252);
            this.InsanityCrystal.Name = "InsanityCrystal";
            this.InsanityCrystal.Size = new System.Drawing.Size(108, 17);
            this.InsanityCrystal.TabIndex = 15;
            this.InsanityCrystal.Text = "Crystal of Insanity";
            this.InsanityCrystal.UseVisualStyleBackColor = true;
            this.InsanityCrystal.CheckedChanged += new System.EventHandler(this.CrystalChecked);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(19, 209);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(123, 17);
            this.label11.TabIndex = 13;
            this.label11.Text = "Strength Modifiers";
            // 
            // RotFCCheckBox
            // 
            this.RotFCCheckBox.AutoSize = true;
            this.RotFCCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.RotFCCheckBox.Location = new System.Drawing.Point(23, 229);
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
            this.MotWCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.MotWCheckBox.Location = new System.Drawing.Point(191, 229);
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
            // 
            // ResiliencePercentage
            // 
            this.ResiliencePercentage.Location = new System.Drawing.Point(180, 246);
            this.ResiliencePercentage.Name = "ResiliencePercentage";
            this.ResiliencePercentage.ReadOnly = true;
            this.ResiliencePercentage.Size = new System.Drawing.Size(100, 20);
            this.ResiliencePercentage.TabIndex = 8;
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
            this.HealingTab.Controls.Add(this.TimelessNutrient2);
            this.HealingTab.Controls.Add(this.Yulon2);
            this.HealingTab.Controls.Add(this.label20);
            this.HealingTab.Controls.Add(this.StaminaBuffed);
            this.HealingTab.Controls.Add(this.label19);
            this.HealingTab.Controls.Add(this.InsanityCrystal2);
            this.HealingTab.Controls.Add(this.FortitudeCheckBox);
            this.HealingTab.Controls.Add(this.DisplayHealth);
            this.HealingTab.Controls.Add(this.label15);
            this.HealingTab.Controls.Add(this.ConversionHps);
            this.HealingTab.Controls.Add(this.label14);
            this.HealingTab.Controls.Add(this.label13);
            this.HealingTab.Controls.Add(this.PvpPowerPercentage);
            this.HealingTab.Controls.Add(this.BPCheckBox);
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
            // TimelessNutrient2
            // 
            this.TimelessNutrient2.AutoSize = true;
            this.TimelessNutrient2.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.TimelessNutrient2.Location = new System.Drawing.Point(182, 209);
            this.TimelessNutrient2.Name = "TimelessNutrient2";
            this.TimelessNutrient2.Size = new System.Drawing.Size(107, 17);
            this.TimelessNutrient2.TabIndex = 26;
            this.TimelessNutrient2.Text = "Timeless Nutrient";
            this.TimelessNutrient2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TimelessNutrient2.UseVisualStyleBackColor = true;
            this.TimelessNutrient2.CheckedChanged += new System.EventHandler(this.TimelessNutrient2_Checked);
            // 
            // Yulon2
            // 
            this.Yulon2.AutoSize = true;
            this.Yulon2.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Yulon2.Location = new System.Drawing.Point(41, 209);
            this.Yulon2.Name = "Yulon2";
            this.Yulon2.Size = new System.Drawing.Size(110, 17);
            this.Yulon2.TabIndex = 25;
            this.Yulon2.Text = "Strength of Yu\'lon";
            this.Yulon2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Yulon2.UseVisualStyleBackColor = true;
            this.Yulon2.CheckedChanged += new System.EventHandler(this.Yulon2_Checked);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(31, 149);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(120, 17);
            this.label20.TabIndex = 17;
            this.label20.Text = "Stamina Modifiers";
            // 
            // StaminaBuffed
            // 
            this.StaminaBuffed.Location = new System.Drawing.Point(135, 70);
            this.StaminaBuffed.Name = "StaminaBuffed";
            this.StaminaBuffed.ReadOnly = true;
            this.StaminaBuffed.Size = new System.Drawing.Size(100, 20);
            this.StaminaBuffed.TabIndex = 16;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(31, 78);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(84, 13);
            this.label19.TabIndex = 15;
            this.label19.Text = "Stamina (buffed)";
            // 
            // InsanityCrystal2
            // 
            this.InsanityCrystal2.AutoSize = true;
            this.InsanityCrystal2.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.InsanityCrystal2.Location = new System.Drawing.Point(295, 186);
            this.InsanityCrystal2.Name = "InsanityCrystal2";
            this.InsanityCrystal2.Size = new System.Drawing.Size(108, 17);
            this.InsanityCrystal2.TabIndex = 14;
            this.InsanityCrystal2.Text = "Crystal of Insanity";
            this.InsanityCrystal2.UseVisualStyleBackColor = true;
            this.InsanityCrystal2.CheckedChanged += new System.EventHandler(this.CrystalChecked2);
            // 
            // FortitudeCheckBox
            // 
            this.FortitudeCheckBox.AutoSize = true;
            this.FortitudeCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.FortitudeCheckBox.Location = new System.Drawing.Point(157, 186);
            this.FortitudeCheckBox.Name = "FortitudeCheckBox";
            this.FortitudeCheckBox.Size = new System.Drawing.Size(132, 17);
            this.FortitudeCheckBox.TabIndex = 13;
            this.FortitudeCheckBox.Text = "Power Word: Fortitude";
            this.FortitudeCheckBox.UseVisualStyleBackColor = true;
            this.FortitudeCheckBox.CheckedChanged += new System.EventHandler(this.FortitudeChecked);
            // 
            // DisplayHealth
            // 
            this.DisplayHealth.Location = new System.Drawing.Point(362, 71);
            this.DisplayHealth.Name = "DisplayHealth";
            this.DisplayHealth.ReadOnly = true;
            this.DisplayHealth.Size = new System.Drawing.Size(100, 20);
            this.DisplayHealth.TabIndex = 12;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(241, 71);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(115, 17);
            this.label15.TabIndex = 11;
            this.label15.Text = "Displayed Health";
            // 
            // ConversionHps
            // 
            this.ConversionHps.Location = new System.Drawing.Point(362, 146);
            this.ConversionHps.Name = "ConversionHps";
            this.ConversionHps.ReadOnly = true;
            this.ConversionHps.Size = new System.Drawing.Size(100, 20);
            this.ConversionHps.TabIndex = 10;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(241, 147);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(79, 17);
            this.label14.TabIndex = 9;
            this.label14.Text = "Conversion";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(31, 113);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(76, 17);
            this.label13.TabIndex = 8;
            this.label13.Text = "PvP Power";
            // 
            // PvpPowerPercentage
            // 
            this.PvpPowerPercentage.Location = new System.Drawing.Point(135, 110);
            this.PvpPowerPercentage.Name = "PvpPowerPercentage";
            this.PvpPowerPercentage.Size = new System.Drawing.Size(100, 20);
            this.PvpPowerPercentage.TabIndex = 7;
            this.PvpPowerPercentage.TextChanged += new System.EventHandler(this.PvpPower_Changed);
            // 
            // BPCheckBox
            // 
            this.BPCheckBox.AutoSize = true;
            this.BPCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BPCheckBox.Location = new System.Drawing.Point(50, 186);
            this.BPCheckBox.Name = "BPCheckBox";
            this.BPCheckBox.Size = new System.Drawing.Size(101, 17);
            this.BPCheckBox.TabIndex = 6;
            this.BPCheckBox.Text = "Blood Presence";
            this.BPCheckBox.UseVisualStyleBackColor = true;
            this.BPCheckBox.CheckedChanged += new System.EventHandler(this.BloodPresenceChecked);
            // 
            // EffectiveHealthTextBox
            // 
            this.EffectiveHealthTextBox.Location = new System.Drawing.Point(362, 110);
            this.EffectiveHealthTextBox.Name = "EffectiveHealthTextBox";
            this.EffectiveHealthTextBox.ReadOnly = true;
            this.EffectiveHealthTextBox.Size = new System.Drawing.Size(100, 20);
            this.EffectiveHealthTextBox.TabIndex = 5;
            this.EffectiveHealthTextBox.TextChanged += new System.EventHandler(this.EffectiveHealth_StatsChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(241, 111);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(107, 17);
            this.label12.TabIndex = 4;
            this.label12.Text = "Effective Health";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(241, 35);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 17);
            this.label10.TabIndex = 3;
            this.label10.Text = "Resilience";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(31, 35);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 17);
            this.label9.TabIndex = 2;
            this.label9.Text = "Stamina";
            // 
            // HealthTabResilience
            // 
            this.HealthTabResilience.Location = new System.Drawing.Point(362, 32);
            this.HealthTabResilience.Name = "HealthTabResilience";
            this.HealthTabResilience.ReadOnly = true;
            this.HealthTabResilience.Size = new System.Drawing.Size(100, 20);
            this.HealthTabResilience.TabIndex = 1;
            // 
            // Stamina
            // 
            this.Stamina.Location = new System.Drawing.Point(135, 32);
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
        private System.Windows.Forms.CheckBox BPCheckBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox PvpPowerPercentage;
        private System.Windows.Forms.TextBox ConversionHps;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox DisplayHealth;
        private System.Windows.Forms.CheckBox FortitudeCheckBox;
        private System.Windows.Forms.CheckBox InsanityCrystal2;
        private System.Windows.Forms.CheckBox InsanityCrystal;
        private System.Windows.Forms.TextBox StrengthBuffed;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox ParryExpertise;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.CheckBox DominanceBox;
        private System.Windows.Forms.TextBox ExpertiseInput;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.CheckBox TimelessNutrient;
        private System.Windows.Forms.CheckBox Yulon;
        private System.Windows.Forms.CheckBox VictoryBox;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox StaminaBuffed;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.CheckBox TimelessNutrient2;
        private System.Windows.Forms.CheckBox Yulon2;
    }
}

