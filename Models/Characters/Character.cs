using System;
using System.Collections.Generic;
using System.Reflection;
using RPG.Interfaces;

namespace RPG.Models
{
    public abstract class Character
    {
        protected int Health;

        public int HealthProp { get{return this.Health;}}


        public string Name {get;set;}
        public char Gender {get;set;}
        public string Race {get;set;}
        public int Strength {get;set;}
        public int Dexterity {get;set;}
        public int Constitution {get;set;}
        public int Wisdom {get;set;}
        public int Intelligence {get;set;}
        public int Charisma {get;set;}
        public int AC {get;set;}
        public Weapon Main {get;set;}
        public IEquippable Offhand {get;set;}
        public IEquippable Armor {get;set;}  
        
        public int Proficiency {get;set;}
        public int Level {get;set;}
        public int Currency {get;set;}

        public bool IsAlive {get;set;}
        public bool IsPoisoned {get;set;}
        public bool IsBurned {get;set;}
        public bool IsBlind {get;set;}
        public bool IsDazed {get;set;}
        public bool IsBleeding {get;set;}

        public double DefenseMultiplier {get;set;}
        public double AttackMultiplier {get;set;}

        private List<ICarriable> Inventory {get;set;}

        Random roll = new Random();

        public Character(string name, char gender, string race, int str, int dex, int con, int wis, int intel, int cha)
        {
            Level = 1;
            Proficiency = 1;
            Currency = 0;
            Name = name;
            Gender = gender;
            Race = race; 
            Strength = str;
            Dexterity = dex;
            Constitution = con;
            Wisdom = wis;
            Intelligence = intel;
            Charisma = cha;
            AC = 10+Dexterity;

            Main = null;
            Offhand = null;
            Armor = null;
            Health = (roll.Next(1,11) * Level) + (con/2 - 5);

            IsAlive = true;
            IsPoisoned = false;
            IsBurned = false;
            IsBurned = false;
            IsDazed = false;
            IsBleeding = false;

            DefenseMultiplier = 1;
            AttackMultiplier = 1;
        }

        public int RollD20(string stat)
        {
            Random rng = new Random();
            PropertyInfo statProp = typeof(Character).GetProperty(stat);
            
            int mod = (int)statProp.GetValue(statProp)/2 - 5;
            int result = rng.Next(1,21) + mod;

            return result;
        }

        public void takeDamage(int dmg)
        {
            Health -= dmg;
        }
    }
}