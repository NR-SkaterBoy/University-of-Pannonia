using System;


namespace Kiszh2Pelda
{
    internal abstract class GameObject
    {
        public Position3D Position { get; protected set; }
        public int MaxHealth { get; }
        public int CurrentHealth { get; private set; }
        public GameObject(Position3D position, int maxHealth)
        {
            Position = position;
            MaxHealth = maxHealth;
            CurrentHealth = maxHealth;
        }

        public virtual void TakeDamage(int amount)
        {
            CurrentHealth -= amount;
            if (CurrentHealth < 0) { CurrentHealth = 0; }
        }
        public virtual void Heal(int amount)
        {
            CurrentHealth += amount;
            if ( CurrentHealth > MaxHealth) { CurrentHealth = MaxHealth; }
        }
    }
}
