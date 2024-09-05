using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Kiszh2Pelda   
{
    internal class Unit : GameObject, IAttacker
    {
        public int Damage { get; set; }

        public Unit(Position3D position, int maxHealth, int damage) : base(position, maxHealth)
        {
            this.Damage = damage;
        }

        public void Attack(GameObject target)
        {
            target.TakeDamage(this.Damage);
        }
    }
}
