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
            this.Calculate = new System.Windows.Forms.Button();
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
            this.ParryTab.SuspendLayout();
            this.ParryChanceTab.SuspendLayout();
            this.DamageReductionTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // Calculate
            // 
            this.Calculate.Location = new System.Drawing.Point(115, 117);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(75, 23);
            this.Calculate.TabIndex = 0;
            this.Calculate.Text = "Calculate";
            this.Calculate.UseVisualStyleBackColor = true;
            this.Calculate.Click += new System.EventHandler(this.ParryChanceCalculation);
            // 
            // StrengthInput
            // 
            this.StrengthInput.Location = new System.Drawing.Point(90, 27);
            this.StrengthInput.Name = "StrengthInput";
            this.StrengthInput.Size = new System.Drawing.Size(100, 20);
            this.StrengthInput.TabIndex = 1;
            this.StrengthInput.TextChanged += new System.EventHandler(this.StrengthInput_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Strength";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Parry Rating";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // ParryRatingInput
            // 
            this.ParryRatingInput.Location = new System.Drawing.Point(90, 71);
            this.ParryRatingInput.Name = "ParryRatingInput";
            this.ParryRatingInput.Size = new System.Drawing.Size(100, 20);
            this.ParryRatingInput.TabIndex = 4;
            this.ParryRatingInput.TextChanged += new System.EventHandler(this.ParryRatingInput_TextChanged);
            // 
            // ParryChanceNoDR
            // 
            this.ParryChanceNoDR.Location = new System.Drawing.Point(379, 27);
            this.ParryChanceNoDR.Name = "ParryChanceNoDR";
            this.ParryChanceNoDR.ReadOnly = true;
            this.ParryChanceNoDR.Size = new System.Drawing.Size(100, 20);
            this.ParryChanceNoDR.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(221, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Parry Chance (before DR)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(221, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Parry Chance (applied DR)";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // ParryChanceDR
            // 
            this.ParryChanceDR.Location = new System.Drawing.Point(379, 71);
            this.ParryChanceDR.Name = "ParryChanceDR";
            this.ParryChanceDR.ReadOnly = true;
            this.ParryChanceDR.Size = new System.Drawing.Size(100, 20);
            this.ParryChanceDR.TabIndex = 8;
            // 
            // ParryTab
            // 
            this.ParryTab.Controls.Add(this.ParryChanceTab);
            this.ParryTab.Controls.Add(this.DamageReductionTab);
            this.ParryTab.Location = new System.Drawing.Point(-1, 0);
            this.ParryTab.Name = "ParryTab";
            this.ParryTab.SelectedIndex = 0;
            this.ParryTab.Size = new System.Drawing.Size(629, 326);
            this.ParryTab.TabIndex = 9;
            // 
            // ParryChanceTab
            // 
            this.ParryChanceTab.Controls.Add(this.StrengthInput);
            this.ParryChanceTab.Controls.Add(this.Calculate);
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
            this.label7.Click += new System.EventHandler(this.label7_Click_1);
            // 
            // BaseLineLable
            // 
            this.BaseLineLable.AutoSize = true;
            this.BaseLineLable.Location = new System.Drawing.Point(47, 140);
            this.BaseLineLable.Name = "BaseLineLable";
            this.BaseLineLable.Size = new System.Drawing.Size(96, 13);
            this.BaseLineLable.TabIndex = 11;
            this.BaseLineLable.Text = "Over Baseline (0%)";
            this.BaseLineLable.TextChanged += new System.EventHandler(this.BaseLineLabelChange);
            this.BaseLineLable.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 249);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Total PvP Resilience";
            this.label6.Click += new System.EventHandler(this.label6_Click_1);
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
            this.MetaGemLabel.Click += new System.EventHandler(this.label6_Click);
            // 
            // ResilienceRatingLabel
            // 
            this.ResilienceRatingLabel.AutoSize = true;
            this.ResilienceRatingLabel.Location = new System.Drawing.Point(47, 65);
            this.ResilienceRatingLabel.Name = "ResilienceRatingLabel";
            this.ResilienceRatingLabel.Size = new System.Drawing.Size(90, 13);
            this.ResilienceRatingLabel.TabIndex = 5;
            this.ResilienceRatingLabel.Text = "Resilience Rating";
            this.ResilienceRatingLabel.Click += new System.EventHandler(this.Resilience_Click);
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
            this.BaseResiliencePercentage.Click += new System.EventHandler(this.BaseResiliencePercentage_Click);
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
            this.label5.Click += new System.EventHandler(this.label5_Click);
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Calculate;
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
    }
}

