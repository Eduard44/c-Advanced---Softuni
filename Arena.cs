using System;
using System.Collections.Generic;
using System.Text;

namespace FightingArena
{
    public class Arena
    {
        private Dictionary<string, Gladiator> gladiators;

        public Arena(string name)
        {
            Name = name;

            gladiators = new Dictionary<string, Gladiator>();
        }

        public string Name { get; set; }

        public void Add(Gladiator gladiator)
        {
            if (!gladiators.ContainsKey(gladiator.Name))
            {
                bool isValid = true;
                if (gladiators.Count > 0)
                {
                    foreach (var item in gladiators)
                    {
                        int gladiatorStatPow = gladiator.GetStatPower();
                        int gladiatorWeaponPow = gladiator.GetWeaponPower();
                        int gladiatorTotalPow = gladiator.GetTotalPower();

                        int oponentStatPow = item.Value.GetStatPower();
                        int oponentWeaponPow = item.Value.GetWeaponPower();
                        int oponentTotalPow = item.Value.GetTotalPower();

                        if (gladiatorStatPow == oponentStatPow &&
                            gladiatorWeaponPow == oponentWeaponPow &&
                            gladiatorTotalPow == oponentTotalPow)
                        {
                            isValid = false;
                        }
                    }
                }
                if (isValid)
                {
                    gladiators.Add(gladiator.Name, gladiator);
                }
            }
        }

        public void Remove(string gladiator)
        {
            if (gladiators.ContainsKey(gladiator))
            {
                gladiators.Remove(gladiator);
            }
        }

        public Gladiator GetGladitorWithHighestStatPower()
        {
            if (Count > 0)
            {
                int highScore = 0;
                string champion = "";
                foreach (var item in gladiators)
                {
                    if (item.Value.GetStatPower() >= highScore)
                    {
                        highScore = item.Value.GetStatPower();
                        champion = item.Key;
                    }
                }
                return gladiators[champion];
            }
            return null;
        }

        public Gladiator GetGladitorWithHighestWeaponPower()
        {
            if (Count > 0)
            {
                int highScore = 0;
                string champion = "";
                foreach (var item in gladiators)
                {
                    if (item.Value.GetWeaponPower() >= highScore)
                    {
                        highScore = item.Value.GetWeaponPower();
                        champion = item.Key;
                    }
                }
                return gladiators[champion];
            }
            return null;
        }

        public Gladiator GetGladitorWithHighestTotalPower()
        {
            if (Count > 0)
            {
                int highScore = 0;
                string champion = "";
                foreach (var item in gladiators)
                {
                    if (item.Value.GetTotalPower() >= highScore)
                    {
                        highScore = item.Value.GetTotalPower();
                        champion = item.Key;
                    }
                }
                return gladiators[champion];
            }
            return null;
        }

        public int Count
        {
            get { return gladiators.Count; }
        }

        public override string ToString()
        {
            string result = $"{Name} - {Count}" +
                $" gladiators are participating.";
            return result;
        }
    }
}
