using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VlaknovaBezpecnost
{
    internal class Hrac
    {
        private string jmeno;
        private int health;
        private bool isAlive;

        public Hrac(string jmeno, int health, bool isAlive)
        {
            Jmeno = jmeno;
            Health = health;
            IsAlive = isAlive;
        }

        public string Jmeno { get => jmeno; set => jmeno = value; }
        public int Health { get => health; set => health = value; }
        public bool IsAlive { get => isAlive; set => isAlive = value; }

        public void Damage()
        {
            lock (this)
            {
                if (IsAlive)
                {
                    Health--;
                }
                return;
            }
        }

        public void Heal()
        {
            lock (this)
            {
                if (IsAlive)
                {
                    health++;
                }
                return;
            }
        }

        public override string ToString()
        {
            return "Health: " + health + "\nIs Alive? " + isAlive;
        }
    }
}
