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
        double stamina;
        double strength;
        double parryRating;
        double baseResilPercentage;
        double resilRating;
        double resilience;
        double pvpPower;
        double expertise;
        string meta;
        HashSet<string> buffs = new HashSet<string>();

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
            ParryExpertise.Text = $"{Math.Round((stats[1] - expertise), 2)}%";
            StrengthBuffed.Text = $"{string.Format("{0:n0}", stats[2])}";
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
            EffectiveHealth_StatsChanged(sender, e);
        }

        private void EffectiveHealth_StatsChanged(object sender, EventArgs e)
        {
            CalculateHealing calculateHealing = new CalculateHealing(stamina, resilience, pvpPower, meta, buffs);
            double buffedStam = calculateHealing.GetBuffedStamina();
            double effectiveHealth = calculateHealing.EffectiveHealth();
            double conversionHPS = calculateHealing.ConversionHealing();
            double displayHealth = calculateHealing.GetHealth();
            StaminaBuffed.Text = $"{string.Format("{0:n0}", buffedStam)}";
            EffectiveHealthTextBox.Text = $"{Math.Round(effectiveHealth / 1000, 0) + "k"}";
            ConversionHps.Text = $"{Math.Round(conversionHPS, 0) + " / HPS"}";
            DisplayHealth.Text = $"{string.Format("{0:n0}", displayHealth)}"; 
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
        private void Expertise_Changed(object sender, EventArgs e)
        {
            var textbox = sender as TextBox;
            int value;
            if (int.TryParse(textbox.Text, out value))
            {
                if (value < 0)
                {
                    textbox.Text = "0";
                }
                expertise = Double.Parse(ExpertiseInput.Text);
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
            // Mark of the Wild
            if (MotWCheckBox.Checked)
            {
                buffs.Add("motw");
            }
            else
            {
                buffs.Remove("motw");
            }
            ParryChance_StatsChanged(sender, e);
        }

        private void RotFC_CheckedChanged(object sender, EventArgs e)
        {
            // Rune of the Fallen Crusader
            if (RotFCCheckBox.Checked)
            {
                buffs.Add("rotfc");
            }
            else
            {
                buffs.Remove("rotfc");
            }
            ParryChance_StatsChanged(sender, e);
        }

        private void DominanceCheck_Changed(object sender, EventArgs e)
        {
            if (DominanceBox.Checked)
            {
                strength = strength + 5280;
            }
            else
            {
                strength = strength - 5280;
            }
            ParryChance_StatsChanged(sender, e);
        }

        private void VictoryCheck_Changed(object sender, EventArgs e)
        {
            if (VictoryBox.Checked)
            {
                strength = strength + 2580;
            }
            else
            {
                strength = strength - 2580;
            }
            ParryChance_StatsChanged(sender, e);
        }

        private void Yulon_Checked(object sender, EventArgs e)
        {
            if (Yulon.Checked && !HasBuff("yulon"))
            {
                buffs.Add("yulon");
                Yulon2.Checked = Yulon.Checked;

                ParryChance_StatsChanged(sender, e);

            }
            else if (Yulon.Checked && HasBuff("yulon"))
            {
                ParryChance_StatsChanged(sender, e);
            }
            else
            {
                buffs.Remove("yulon");
                Yulon2.Checked = Yulon.Checked;
                ParryChance_StatsChanged(sender, e);
            }
        }

        private void TimelessNutrient_Checked(object sender, EventArgs e)
        {
            if (TimelessNutrient.Checked && !HasBuff("nutrient"))
            {
                buffs.Add("nutrient");
                TimelessNutrient2.Checked = TimelessNutrient.Checked;

                ParryChance_StatsChanged(sender, e);

            }
            else if (TimelessNutrient.Checked && HasBuff("nutrient"))
            {
                ParryChance_StatsChanged(sender, e);
            }
            else
            {
                buffs.Remove("nutrient");
                TimelessNutrient2.Checked = TimelessNutrient.Checked;
                ParryChance_StatsChanged(sender, e);
            }
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

        private void BloodPresenceChecked(object sender, EventArgs e)
        {
            if (BPCheckBox.Checked)
            {
                buffs.Add("bPresence");
            }
            else
            {
                buffs.Remove("bPresence");
            }
            EffectiveHealth_StatsChanged(sender, e);
        }

        private void FortitudeChecked(object sender, EventArgs e)
        {
            if (BPCheckBox.Checked)
            {
                buffs.Add("fortitude");
            }
            else
            {
                buffs.Remove("fortitude");
            }
            EffectiveHealth_StatsChanged(sender, e);

        }

        private void CrystalChecked(object sender, EventArgs e)      
        {
            if (InsanityCrystal.Checked && !HasBuff("crystal"))
            {
                buffs.Add("crystal");
                InsanityCrystal2.Checked = InsanityCrystal.Checked;

                ParryChance_StatsChanged(sender, e);

            }
            else if (InsanityCrystal.Checked && HasBuff("crystal"))
            {
                ParryChance_StatsChanged(sender, e);
            }
            else
            {
                buffs.Remove("crystal");
                InsanityCrystal2.Checked = InsanityCrystal.Checked;
                ParryChance_StatsChanged(sender, e);
            }
        }

        private void CrystalChecked2(object sender, EventArgs e)
        {
            if (InsanityCrystal2.Checked && !HasBuff("crystal"))
            {
                buffs.Add("crystal");
                InsanityCrystal.Checked = InsanityCrystal2.Checked;

                EffectiveHealth_StatsChanged(sender, e);

            }
            else if (InsanityCrystal2.Checked && HasBuff("crystal"))
            {
                EffectiveHealth_StatsChanged(sender, e);
            }
            else
            {
                buffs.Remove("crystal");
                InsanityCrystal.Checked = InsanityCrystal2.Checked;
                EffectiveHealth_StatsChanged(sender, e);
            }
        }

        private void Yulon2_Checked(object sender, EventArgs e)
        {
            if (Yulon2.Checked && !HasBuff("yulon"))
            {
                buffs.Add("yulon");
                Yulon.Checked = Yulon2.Checked;

                EffectiveHealth_StatsChanged(sender, e);

            }
            else if (Yulon2.Checked && HasBuff("yulon"))
            {
                EffectiveHealth_StatsChanged(sender, e);
            }
            else
            {
                buffs.Remove("yulon");
                Yulon.Checked = Yulon2.Checked;
                EffectiveHealth_StatsChanged(sender, e);
            }
        }

        private void TimelessNutrient2_Checked(object sender, EventArgs e)
        {
            if (TimelessNutrient2.Checked && !HasBuff("nutrient"))
            {
                buffs.Add("nutrient");
                TimelessNutrient.Checked = TimelessNutrient2.Checked;

                EffectiveHealth_StatsChanged(sender, e);

            }
            else if (TimelessNutrient2.Checked && HasBuff("nutrient"))
            {
                EffectiveHealth_StatsChanged(sender, e);
            }
            else
            {
                buffs.Remove("nutrient");
                TimelessNutrient.Checked = TimelessNutrient2.Checked;
                EffectiveHealth_StatsChanged(sender, e);
            }
        }

        private void PvpPower_Changed(object sender, EventArgs e)
        {
            var textbox = sender as TextBox;
            double value;
            if (double.TryParse(textbox.Text, out value))
            {
                if (value < 0)
                {
                    textbox.Text = "0";
                }
                else if (value >= 100.0)
                {
                    textbox.Text = "100";
                }
                pvpPower = Double.Parse(PvpPowerPercentage.Text);
            }
            EffectiveHealth_StatsChanged(sender, e);
        }

        private bool HasBuff(string buff)
        {
            return buffs.Contains(buff);
        }

        private void ParryChanceExpertise(object sender, EventArgs e)
        {

        }
    }
}
