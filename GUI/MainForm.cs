using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class MainForm : Form
    {
        // pvp power 47.76%
        // increase healing 19.11%
        // dps classes benefit 40% towards healing from pvp power
        // 45% battle fatigue
        // Conversion:  1.65% (3% * 0.65)/sec
        // 30% pvp power -> 14.4% 1.65% HPS buff by 14.4% -> (1.65 * 1.144) == 1.89% /s
        double baseResilPercentage;
        double resilRating;
        string meta;

        public MainForm()
        {
            InitializeComponent();
        }

        private void ParryChanceCalculation(object sender, EventArgs e)
        {
            double strength = Double.Parse(StrengthInput.Text);
            double parryRating = Double.Parse(ParryRatingInput.Text);
            CalculateParry calculateParry = new CalculateParry(3, 305, strength, parryRating);
            double[] stats = calculateParry.DoCalculation();
            ParryChanceNoDR.Text = $"{Math.Round(stats[0], 2)}%";
            ParryChanceDR.Text = $"{Math.Round(stats[1], 2)}%";
        }

        private void InputStatsChanged(object sender, EventArgs e)
        {
            CalculateDamageReduction calculateDR = new CalculateDamageReduction(baseResilPercentage, resilRating, meta);
            double[] stats = calculateDR.CalculateResilRating();
            TotalDR.Text = $"{Math.Round(stats[0] * 100, 2) + "%"}";
            ResilienceDeltaPvP.Text = $"{Math.Round(stats[1] * 100, 2) + "%"}";
            ResiliencePercentage.Text = $"{Math.Round((stats[2] * 100), 2) + "%" }";
            TotalResilRating.Text = $"{stats[3]}";
        }

        private void BaseResiliencePercentage_Click(object sender, EventArgs e)
        {

        }

        private void BaseResil_SelectedIndexChanged(object sender, EventArgs e)
        {
            baseResilPercentage = Double.Parse(BaseResilChoice.Text);
            BaseLineLable.Text = $"{"Over Baseline (" + Math.Round((baseResilPercentage * 100), 2) + "%)" }";
            InputStatsChanged(sender, e);
        }

        private void ResilRating_TextChanged(object sender, EventArgs e)
        {
            //this should never be null 
            if (ResilRatingAmount.Text != "" && ResilRatingAmount.Text != null)
            {
                resilRating = Double.Parse(ResilRatingAmount.Text);
            }
            else
            {
                resilRating = 0;
            }
            InputStatsChanged(sender, e);
        }

        private void MetaGemChoice_SelectedIndexChanged(object sender, EventArgs e)
        {
            meta = MetaGemChoice.Text.ToLower();
            InputStatsChanged(sender, e);
        }

        private void BaseLineLabelChange(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void StrengthInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void ParryRatingInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Resilience_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click_1(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void Resilience_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click_1(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_2(object sender, EventArgs e)
        {

        }
    }
}
