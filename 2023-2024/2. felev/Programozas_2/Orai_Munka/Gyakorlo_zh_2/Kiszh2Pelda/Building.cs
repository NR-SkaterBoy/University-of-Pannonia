using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Kiszh2Pelda
{
    internal class Building : GameObject
    {
        public int MaxArmor { get; set; }
        public int currentArmor;

        public Building(Position3D position, int maxHealth, int maxArmor) : base(position, maxHealth)
        {
            this.MaxArmor = maxArmor;
            this.currentArmor = maxArmor;
        }

        public int CurrentArmor => this.currentArmor;

        public void AddArmor(int armor)
        {
            currentArmor = Math.Min(MaxArmor, currentArmor + armor);
        }

        public void DamageArmor(int armor)
        {
            currentArmor = Math.Max(0, currentArmor - armor);
        }

        public override void Heal(int amount)
        {
            if (Health < MaxHealth)
            {
                int healthDifference = MaxHealth - Health;
                if (amount <= healthDifference)
                {
                    Health += amount;
                    return;
                }
                else
                {
                    Health = MaxHealth;
                    amount -= healthDifference;
                }
            }

            if (currentArmor < MaxArmor)
            {
                currentArmor += amount;
                if (currentArmor > MaxArmor)
                {
                    currentArmor = MaxArmor;
                }
            }
        }

        public override void TakeDamage(int amount)
        {
            if (currentArmor > 0)
            {
                if (amount < currentArmor)
                {
                    currentArmor -= amount;
                    return;
                }
                else
                {
                    amount -= currentArmor;
                    currentArmor = 0;
                }
            }

            Health -= amount;
            if (Health < 0)
            {
                Health = 0;
            }
        }
    }
}
