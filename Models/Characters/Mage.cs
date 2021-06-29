using System;
using System.Collections.Generic;
using RPG.Models.Miscellaneous;

namespace RPG.Models.Characters
{
    public class Mage : Character
    {
        public List<Spell> Spells { get; set; }
        public Mage(string name, char gender, string race, int str, int dex, int con, int wis, int intel, int cha) : base(name, gender, race, str-=1, dex, con, wis+=2, intel+=1, cha)
        {
            Spells = new List<Spell>();
        }

        public void Cast(Spell spell){
            Console.WriteLine("Casted a spell");
        }

        public void Heal(Character target=null)
        {
            if (target == null)
            {
                this.Health += 10*Level;
                Console.WriteLine("You healed yourself!");
            }
            else
            {
                // target.takeDamage(-(10*Level));
                Console.WriteLine($"You healed {target.Name}");
            }
        }



    }
}