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
        double stamina;
        double strength;
        double parryRating;
        double baseResilPercentage;
        double resilRating;
        double resilience;
        string meta;
        HashSet<double> buffs = new HashSet<double>();

        public MainForm()
        {
            InitializeComponent();
        }

        private void ParryChance_StatsChanged(object sender, EventArgs e)
        {
            CalculateParry calculateParry = new CalculateParry(3, 305, strength, parryRating, buffs);
            double[] stats = calculateParry.DoCalculation();
            ParryChanceNoDR.Text = $"{Math.Round(stats[0], 2)}%";
            ParryChanceDR.Text = $"{Math.Round(stats[1], 2)}%";
        }

        private void InputStatsChanged(object sender, EventArgs e)
        {
            CalculateDamageReduction calculateDR = new CalculateDamageReduction(baseResilPercentage, resilRating, meta);
            double[] stats = calculateDR.CalculateResilRating();
            resilience = stats[2];
            TotalDR.Text = $"{Math.Round(stats[0] * 100, 2) + "%"}";
            ResilienceDeltaPvP.Text = $"{Math.Round(stats[1] * 100, 2) + "%"}";
            ResiliencePercentage.Text = $"{Math.Round((resilience * 100), 2) + "%" }";
            TotalResilRating.Text = $"{stats[3]}";
            HealthTabResilience.Text = ResiliencePercentage.Text;
        }

        private void EffectiveHealth_StatsChanged(object sender, EventArgs e)
        {
            CalculateHealing calculateHealing = new CalculateHealing(stamina, resilience);
            double effectiveHealth = calculateHealing.EffectiveHealth();
            EffectiveHealthTextBox.Text = $"{Math.Round(effectiveHealth / 1000, 0) + "k"}";
        }

        private void StrengthInput_TextChanged(object sender, EventArgs e)
        {
            var textbox = sender as TextBox;
            int value;
            if (int.TryParse(textbox.Text, out value))
            {
                if (value < 0)
                {
                    textbox.Text = "0";
                }
                strength = Double.Parse(StrengthInput.Text);
            }
            ParryChance_StatsChanged(sender, e);
        }

        private void ParryRatingInput_TextChanged(object sender, EventArgs e)
        {
            var textbox = sender as TextBox;
            int value;
            if (int.TryParse(textbox.Text, out value))
            {
                if (value < 0)
                {
                    textbox.Text = "0";
                }
                parryRating = Double.Parse(ParryRatingInput.Text);
            }
            ParryChance_StatsChanged(sender, e);
        }

        private void BaseResil_SelectedIndexChanged(object sender, EventArgs e)
        {
            baseResilPercentage = Double.Parse(BaseResilChoice.Text);
            BaseLineLable.Text = $"{"Over Baseline (" + Math.Round((baseResilPercentage * 100), 2) + "%)" }";
            InputStatsChanged(sender, e);
        }

        private void ResilRating_TextChanged(object sender, EventArgs e)
        {
            var textbox = sender as TextBox;
            int value;
            if (int.TryParse(textbox.Text, out value))
            {
                if (value < 0)
                {
                    textbox.Text = "0";
                }
                resilRating = Double.Parse(ResilRatingAmount.Text);
            }
            InputStatsChanged(sender, e);
        }

        private void MetaGemChoice_SelectedIndexChanged(object sender, EventArgs e)
        {
            meta = MetaGemChoice.Text.ToLower();
            InputStatsChanged(sender, e);
        }

        private void MotW_CheckedChanged(object sender, EventArgs e)
        {
            if (MotWCheckBox.Checked)
            {
                buffs.Add(1.05);
            }
            else
            {
                buffs.Remove(1.05);
            }
            ParryChance_StatsChanged(sender, e);
        }

        private void RotFC_CheckedChanged(object sender, EventArgs e)
        {
            if (RotFCCheckBox.Checked)
            {
                buffs.Add(1.15);
            }
            else
            {
                buffs.Remove(1.15);
            }
            ParryChance_StatsChanged(sender, e);
        }

        private void Stamina_InputChanged(object sender, EventArgs e)
        {
            var textbox = sender as TextBox;
            int value;
            if (int.TryParse(textbox.Text, out value))
            {
                if (value < 0)
                {
                    textbox.Text = "0";
                }
                stamina = Double.Parse(Stamina.Text);
            }
            EffectiveHealth_StatsChanged(sender, e);
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void Resilience_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_2(object sender, EventArgs e)
        {

        }


    }
}
