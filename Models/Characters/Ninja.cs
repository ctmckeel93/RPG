using System;

namespace RPG.Models.Characters
{
    public class Ninja : Character
    {
        public Ninja(string name, char gender, string race, int str, int dex, int con, int wis, int intel, int cha) : base(name, gender, race, str, dex+=2, con-=1, wis, intel, cha+=1)
        {}

        public void Hide()
        {
            Random roll = new Random();

            int dexMod = Dexterity/2 -5;
            int chance = roll.Next(0,21) + dexMod;
            if (chance >= 15)
            {
                AC+=2*dexMod;
            }
            else
            {
                Console.WriteLine("You were spotted!");
            }
            
        }

        public void Poison(Character target)
        {
            Random roll = new Random();
            int dexMod = Dexterity/2 -5;
            int targetConMod = target.Constitution/2 - 5;

            int dexRoll = RollD20("Dexterity") + dexMod;
            int check = target.RollD20("Constitution") + targetConMod;

            if (dexRoll > check)
            {
                target.IsPoisoned = true;
            }
        }

        public void Assassinate(Character target)
        {
            Random rng = new Random();
            if (target.HealthProp < 20)
            {
                int chance = rng.Next(0,21);
                if (chance > 16)
                {
                    target.takeDamage(target.HealthProp);
                }
            }
        }
    }
}