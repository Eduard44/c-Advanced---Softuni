using System;
using System.Collections.Generic;
using System.Text;

namespace FightingArena
{
    public class Gladiator
    {
        public Gladiator(string name, Stat stat, Weapon weapon)
        {
            Name = name;
            Stat = stat;
            Weapon = weapon;
        }

        public string Name { get; set; }

        public Stat Stat { get; set; }

        public Weapon Weapon { get; set; }

        public int GetTotalPower()
        {
            int totalPower = GetStatPower() + GetWeaponPower();
            return totalPower;
        }

        public int GetStatPower()
        {
            int statSum = Stat.Strength
                + Stat.Flexibility
                + Stat.Agility
                + Stat.Skills
                + Stat.Intelligence;
            if (statSum<=0)
            {
                return 0;
            }
            return statSum;
        }

        public int GetWeaponPower()
        {
            int weaponSum = Weapon.Size
                + Weapon.Solidity
                + Weapon.Sharpness;
            if (weaponSum <= 0)
            {
                return 0;
            }
            return weaponSum;
        }

        public override string ToString()
        {
            string result = $"{Name} - {GetTotalPower()}" +
                Environment.NewLine +
                $"  Weapon Power: {GetWeaponPower()}" +
                Environment.NewLine +
                $"  Stat Power: {GetStatPower()}";
            return result;
        }
    }
}
