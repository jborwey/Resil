﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI
{
    class CalculateHealing
    {
        private double _stamina { get; set; }
        private double _resilience { get; set; }
        private double _pvpPower { get; set; }
        private string _metaGem { get; set; }
        private double _flatMagicDR = 1;
        private double _conversionTick = 0.03; //3%
        private double _battleFatigue = 0.40; //60% battle fatigue
        private double _health;
        private double _fortitude = 1;
        private double _baseHealth = 146683;

        public CalculateHealing(double stamina, double resilience, double pvpPower, string meta, bool isBloodPresence, bool isFortitude)
        {
            _stamina = stamina;
            _resilience = resilience;
            _pvpPower = pvpPower;
            _metaGem = meta;

            if (_metaGem == "effulgent")
            {
                _stamina += 324;
                _flatMagicDR = 0.98;
            }
            if (isBloodPresence) { _stamina *= 1.25; }
            if (isFortitude) { _fortitude = 1.1; }
            SetHealth(_stamina, _fortitude);
        }

        public double EffectiveHealth()
        {
            return _health / (1 - _resilience) / _flatMagicDR;
        }

        public double ConversionHealing()
        {
            // pvp power 47.76%
            // increase healing 19.11%
            // dps classes benefit 40% towards healing from pvp power
            // Conversion:  1.65% (3% * 0.65)/sec
            // 30% pvp power -> 14.4% 1.65% HPS buff by 14.4% -> (1.65 * 1.144) == 1.89% /s
            double HPS = _conversionTick * _battleFatigue;
            double pvpHeal = (_pvpPower * 0.0040) + 1;
            return _health * HPS * pvpHeal;
        }

        public double GetHealth()
        {
            return _health;
        }

        private void SetHealth(double _stamina, double _fortitude)
        {
            _health = _baseHealth + _stamina * 14 * _fortitude;
        }
    }
}
