using System;
using RPG.Interfaces;

namespace RPG.Models
{
    public abstract class ArmorClass : IEquippable
    {
        public string Name { get; set; }
        public int Modifier { get; set; }

        public string Resistance { get; set; }

        public ArmorClass(string name, int mod, string resistance=null)
        {
            Name = name; 
            Modifier = mod;
            Resistance = resistance;
        }
        public virtual void Equip(Character character, string hand=null )
        {
            if (hand == null)
            {
                character.Armor = this;
                character.AC += Modifier;
            }
            else if (hand == "Offhand")
            {
                character.Offhand = this;
            }
            else
            {
                Console.WriteLine("Your character can only equip this as Armor or Offhand.");
            }
        }
    }
}