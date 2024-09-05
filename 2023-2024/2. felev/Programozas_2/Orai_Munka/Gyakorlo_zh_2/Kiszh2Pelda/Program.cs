#region MegoldottFeladatok
#define PART1 // IAttacker interfesz (1 pont)
#define PART2 // Unit osztaly (1 pont)
#define PART2A // Unit.Attack() (1 pont)
#define PART3  // Building osztaly (2 pont)
#define PART3A // Building.AddArmor() es DamageArmor() (1 pont)
//#define PART4  // Building.Heal() es TakeDamage() (2 pont)
//#define PART5  // DefenseTower osztaly (2 pont)
#endregion

using System;
using System.Reflection;
using System.Runtime.ConstrainedExecution;

namespace Kiszh2Pelda
{
    class ObjectTest : GameObject
    {
        public ObjectTest(double x, double y) :
          base(new Position3D(x, y, 0), 1000)
        { }
    }
#if PART1
    class InterfaceTest : IAttacker
    {
        public void Attack(GameObject target)
        {
            Console.WriteLine("Attack happened");
        }
    }
#endif
    internal class Program
    {
        static void Main(string[] args)
        {
#if PART1
            using (TestGuard tg = new TestGuard("PART1"))
            {
                if (typeof(IAttacker).IsInterface == false)
                {
                    Console.WriteLine("!!! IAttacker is not an inferface !!!");
                }
                else
                {
                    IAttacker test = new InterfaceTest();
                    test.Attack(new ObjectTest(0, 0));
                }
            } //
#endif
#if PART2
            using (TestGuard tg = new TestGuard("PART2"))
            {
                GameObject g1 = new Unit(new Position3D(4.5, 123.6, 3.5), 130, 40);
                GameObject g2 = new Unit(new Position3D(12.5, 111.5, 7.6), 110, 35);
                Console.WriteLine($"Pos: {g1.Position}, Health: {g1.CurrentHealth}/{g1.MaxHealth}");
                Console.WriteLine($"Pos: {g2.Position}, Health: {g2.CurrentHealth}/{g2.MaxHealth}");
            }
#endif
#if PART2A
      using(TestGuard tg = new TestGuard("PART2A")) {
        Unit unit1 = new Unit(new Position3D(4.5, 123.6, 3.5), 130, 40);
        Unit unit2 = new Unit(new Position3D(12.5, 111.5, 7.6), 110, 35);
        GameObject g1 = unit1;
        GameObject g2 = unit2;
        IAttacker a1 = unit1;
        IAttacker a2 = unit2;
        Console.WriteLine($"Pos: {g1.Position}, Health: {g1.CurrentHealth}/{g1.MaxHealth}");
        Console.WriteLine($"Pos: {g2.Position}, Health: {g2.CurrentHealth}/{g2.MaxHealth}");
        Console.WriteLine("--Attack--");
        a1.Attack(unit2);
        a2.Attack(unit1);
        Console.WriteLine($"Pos: {g1.Position}, Health: {g1.CurrentHealth}/{g1.MaxHealth}");
        Console.WriteLine($"Pos: {g2.Position}, Health: {g2.CurrentHealth}/{g2.MaxHealth}");
        Console.WriteLine("--Attack--");
        a1.Attack(g2);
        a2.Attack(g1);
        Console.WriteLine($"Pos: {g1.Position}, Health: {g1.CurrentHealth}/{g1.MaxHealth}");
        Console.WriteLine($"Pos: {g2.Position}, Health: {g2.CurrentHealth}/{g2.MaxHealth}");
        Console.WriteLine("--Attack--");
        a1.Attack(g2);
        a2.Attack(g1);
        Console.WriteLine($"Pos: {g1.Position}, Health: {g1.CurrentHealth}/{g1.MaxHealth}");
        Console.WriteLine($"Pos: {g2.Position}, Health: {g2.CurrentHealth}/{g2.MaxHealth}");
      }
#endif
#if PART3
      using(TestGuard tg = new TestGuard("PART3")) {
        Building building1 = new Building(new Position3D(123.4, 122.7, 1.4), 560, 130);
        Building building2 = new Building(new Position3D(223.4, -22.7, 1.8), 350, 240);
        Console.WriteLine($"Pos: {building1.Position}, Health: {building1.CurrentHealth}/{building1.MaxHealth}, Armor: {building1.CurrentArmor}/{building1.MaxArmor}");
        Console.WriteLine($"Pos: {building2.Position}, Health: {building2.CurrentHealth}/{building2.MaxHealth}, Armor: {building2.CurrentArmor}/{building2.MaxArmor}");
      } //
#endif
#if PART3A
      using(TestGuard tg = new TestGuard("PART3A")) {
        Building building1 = new Building(new Position3D(123.4, 122.7, 1.4), 560, 130);
        Building building2 = new Building(new Position3D(223.4, -22.7, 1.8), 350, 240);
        Console.WriteLine($"Pos: {building1.Position}, Health: {building1.CurrentHealth}/{building1.MaxHealth}, Armor: {building1.CurrentArmor}/{building1.MaxArmor}");
        Console.WriteLine($"Pos: {building2.Position}, Health: {building2.CurrentHealth}/{building2.MaxHealth}, Armor: {building2.CurrentArmor}/{building2.MaxArmor}");
        Console.WriteLine("Armor -100");
        building1.DamageArmor(100);
        building2.DamageArmor(100);
        Console.WriteLine($"Pos: {building1.Position}, Health: {building1.CurrentHealth}/{building1.MaxHealth}, Armor: {building1.CurrentArmor}/{building1.MaxArmor}");
        Console.WriteLine($"Pos: {building2.Position}, Health: {building2.CurrentHealth}/{building2.MaxHealth}, Armor: {building2.CurrentArmor}/{building2.MaxArmor}");
        Console.WriteLine("Armor -50");
        building1.DamageArmor(50);
        building2.DamageArmor(50);
        Console.WriteLine($"Pos: {building1.Position}, Health: {building1.CurrentHealth}/{building1.MaxHealth}, Armor: {building1.CurrentArmor}/{building1.MaxArmor}");
        Console.WriteLine($"Pos: {building2.Position}, Health: {building2.CurrentHealth}/{building2.MaxHealth}, Armor: {building2.CurrentArmor}/{building2.MaxArmor}");
        Console.WriteLine("Armor -120");
        building1.DamageArmor(120);
        building2.DamageArmor(120);
        Console.WriteLine($"Pos: {building1.Position}, Health: {building1.CurrentHealth}/{building1.MaxHealth}, Armor: {building1.CurrentArmor}/{building1.MaxArmor}");
        Console.WriteLine($"Pos: {building2.Position}, Health: {building2.CurrentHealth}/{building2.MaxHealth}, Armor: {building2.CurrentArmor}/{building2.MaxArmor}");
        Console.WriteLine("Armor +120");
        building1.AddArmor(120);
        building2.AddArmor(120);
        Console.WriteLine($"Pos: {building1.Position}, Health: {building1.CurrentHealth}/{building1.MaxHealth}, Armor: {building1.CurrentArmor}/{building1.MaxArmor}");
        Console.WriteLine($"Pos: {building2.Position}, Health: {building2.CurrentHealth}/{building2.MaxHealth}, Armor: {building2.CurrentArmor}/{building2.MaxArmor}");
        Console.WriteLine("Armor +60");
        building1.AddArmor(60);
        building2.AddArmor(60);
        Console.WriteLine($"Pos: {building1.Position}, Health: {building1.CurrentHealth}/{building1.MaxHealth}, Armor: {building1.CurrentArmor}/{building1.MaxArmor}");
        Console.WriteLine($"Pos: {building2.Position}, Health: {building2.CurrentHealth}/{building2.MaxHealth}, Armor: {building2.CurrentArmor}/{building2.MaxArmor}");
        Console.WriteLine("Armor +90");
        building1.AddArmor(90);
        building2.AddArmor(90);
        Console.WriteLine($"Pos: {building1.Position}, Health: {building1.CurrentHealth}/{building1.MaxHealth}, Armor: {building1.CurrentArmor}/{building1.MaxArmor}");
        Console.WriteLine($"Pos: {building2.Position}, Health: {building2.CurrentHealth}/{building2.MaxHealth}, Armor: {building2.CurrentArmor}/{building2.MaxArmor}");

      } //
#endif
#if PART4
      using(TestGuard tg = new TestGuard("PART4")) {
        Building building1 = new Building(new Position3D(123.4, 122.7, 1.4), 560, 130);
        Building building2 = new Building(new Position3D(223.4, -22.7, 1.8), 350, 240);
        GameObject g1 = building1;
        GameObject g2 = building2;
        Console.WriteLine("Armor -100");
        building1.DamageArmor(100);
        building2.DamageArmor(100);
        Console.WriteLine($"Pos: {building1.Position}, Health: {building1.CurrentHealth}/{building1.MaxHealth}, Armor: {building1.CurrentArmor}/{building1.MaxArmor}");
        Console.WriteLine($"Pos: {building2.Position}, Health: {building2.CurrentHealth}/{building2.MaxHealth}, Armor: {building2.CurrentArmor}/{building2.MaxArmor}");
        Console.WriteLine("Damage 50");
        g1.TakeDamage(50);
        g2.TakeDamage(50);
        Console.WriteLine($"Pos: {building1.Position}, Health: {building1.CurrentHealth}/{building1.MaxHealth}, Armor: {building1.CurrentArmor}/{building1.MaxArmor}");
        Console.WriteLine($"Pos: {building2.Position}, Health: {building2.CurrentHealth}/{building2.MaxHealth}, Armor: {building2.CurrentArmor}/{building2.MaxArmor}");
        Console.WriteLine("Damage 150");
        g1.TakeDamage(150);
        g2.TakeDamage(150);
        Console.WriteLine($"Pos: {building1.Position}, Health: {building1.CurrentHealth}/{building1.MaxHealth}, Armor: {building1.CurrentArmor}/{building1.MaxArmor}");
        Console.WriteLine($"Pos: {building2.Position}, Health: {building2.CurrentHealth}/{building2.MaxHealth}, Armor: {building2.CurrentArmor}/{building2.MaxArmor}");
        Console.WriteLine("Armor +50");
        building1.AddArmor(50);
        building2.AddArmor(50);
        Console.WriteLine($"Pos: {building1.Position}, Health: {building1.CurrentHealth}/{building1.MaxHealth}, Armor: {building1.CurrentArmor}/{building1.MaxArmor}");
        Console.WriteLine($"Pos: {building2.Position}, Health: {building2.CurrentHealth}/{building2.MaxHealth}, Armor: {building2.CurrentArmor}/{building2.MaxArmor}");
        Console.WriteLine("Damage 250");
        building1.TakeDamage(250);
        building2.TakeDamage(250);
        Console.WriteLine($"Pos: {building1.Position}, Health: {building1.CurrentHealth}/{building1.MaxHealth}, Armor: {building1.CurrentArmor}/{building1.MaxArmor}");
        Console.WriteLine($"Pos: {building2.Position}, Health: {building2.CurrentHealth}/{building2.MaxHealth}, Armor: {building2.CurrentArmor}/{building2.MaxArmor}");
        Console.WriteLine("Damage 250");
        building1.TakeDamage(250);
        building2.TakeDamage(250);
        Console.WriteLine($"Pos: {building1.Position}, Health: {building1.CurrentHealth}/{building1.MaxHealth}, Armor: {building1.CurrentArmor}/{building1.MaxArmor}");
        Console.WriteLine($"Pos: {building2.Position}, Health: {building2.CurrentHealth}/{building2.MaxHealth}, Armor: {building2.CurrentArmor}/{building2.MaxArmor}");
        Console.WriteLine("Armor +100");
        building1.AddArmor(100);
        building2.AddArmor(100);
        Console.WriteLine($"Pos: {building1.Position}, Health: {building1.CurrentHealth}/{building1.MaxHealth}, Armor: {building1.CurrentArmor}/{building1.MaxArmor}");
        Console.WriteLine($"Pos: {building2.Position}, Health: {building2.CurrentHealth}/{building2.MaxHealth}, Armor: {building2.CurrentArmor}/{building2.MaxArmor}");
        Console.WriteLine("Heal 100");
        building1.Heal(100);
        building2.Heal(100);
        Console.WriteLine($"Pos: {building1.Position}, Health: {building1.CurrentHealth}/{building1.MaxHealth}, Armor: {building1.CurrentArmor}/{building1.MaxArmor}");
        Console.WriteLine($"Pos: {building2.Position}, Health: {building2.CurrentHealth}/{building2.MaxHealth}, Armor: {building2.CurrentArmor}/{building2.MaxArmor}");
        Console.WriteLine("Heal 200");
        building1.Heal(200);
        building2.Heal(200);
        Console.WriteLine($"Pos: {building1.Position}, Health: {building1.CurrentHealth}/{building1.MaxHealth}, Armor: {building1.CurrentArmor}/{building1.MaxArmor}");
        Console.WriteLine($"Pos: {building2.Position}, Health: {building2.CurrentHealth}/{building2.MaxHealth}, Armor: {building2.CurrentArmor}/{building2.MaxArmor}");
        Console.WriteLine("Heal 80");
        building1.Heal(80);
        building2.Heal(80);
        Console.WriteLine($"Pos: {building1.Position}, Health: {building1.CurrentHealth}/{building1.MaxHealth}, Armor: {building1.CurrentArmor}/{building1.MaxArmor}");
        Console.WriteLine($"Pos: {building2.Position}, Health: {building2.CurrentHealth}/{building2.MaxHealth}, Armor: {building2.CurrentArmor}/{building2.MaxArmor}");
        Console.WriteLine("Heal 200");
        building1.Heal(200);
        building2.Heal(200);
        Console.WriteLine($"Pos: {building1.Position}, Health: {building1.CurrentHealth}/{building1.MaxHealth}, Armor: {building1.CurrentArmor}/{building1.MaxArmor}");
        Console.WriteLine($"Pos: {building2.Position}, Health: {building2.CurrentHealth}/{building2.MaxHealth}, Armor: {building2.CurrentArmor}/{building2.MaxArmor}");
        Console.WriteLine("Heal 50");
        building1.Heal(50);
        building2.Heal(50);
        Console.WriteLine($"Pos: {building1.Position}, Health: {building1.CurrentHealth}/{building1.MaxHealth}, Armor: {building1.CurrentArmor}/{building1.MaxArmor}");
        Console.WriteLine($"Pos: {building2.Position}, Health: {building2.CurrentHealth}/{building2.MaxHealth}, Armor: {building2.CurrentArmor}/{building2.MaxArmor}");
      } //
#endif
#if PART5
      using(TestGuard tg = new TestGuard("PART5")) {
        DefenseTower tower1 = new DefenseTower(new Position3D(28.7, 36.9, 1.2), 560, 130, 50);
        DefenseTower tower2 = new DefenseTower(new Position3D(32.8, 42.8, 2.4), 350, 240, 70);
        Building b1 = tower1;
        Building b2 = tower2;
        Console.WriteLine($"Pos: {b1.Position}, Health: {b1.CurrentHealth}/{b1.MaxHealth}, Armor: {b1.CurrentArmor}/{b1.MaxArmor}");
        Console.WriteLine($"Pos: {b2.Position}, Health: {b2.CurrentHealth}/{b2.MaxHealth}, Armor: {b2.CurrentArmor}/{b2.MaxArmor}");
        GameObject g1 = new ObjectTest(70, 70);
        GameObject g2 = new ObjectTest(0, 0);
        IAttacker a1 = tower1;
        IAttacker a2 = tower2;
        Console.WriteLine("--Attack--");
        a1.Attack(g1);
        a2.Attack(g2);
        Console.WriteLine($"Health: {g1.CurrentHealth}/{g1.MaxHealth}");
        Console.WriteLine($"Health: {g2.CurrentHealth}/{g2.MaxHealth}");
        Console.WriteLine("--Attack--");
        a1.Attack(g2);
        a2.Attack(g1);
        Console.WriteLine($"Health: {g1.CurrentHealth}/{g1.MaxHealth}");
        Console.WriteLine($"Health: {g2.CurrentHealth}/{g2.MaxHealth}");
      } //
#endif
        }
    }
    public class TestGuard : IDisposable
    {
        string _name;
        public TestGuard(string name)
        {
            _name = name;
            Console.WriteLine($"\n\n----START OF {_name}----");
        }
        public void Dispose()
        {
            Console.WriteLine($"----END OF {_name}----");
            GC.SuppressFinalize(this);
        }
    }
}