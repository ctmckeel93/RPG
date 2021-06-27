using System;
using RPG.Interfaces;

namespace RPG.Models
{
    public abstract class Character
    {
        private int Health;


        public string Name {get;set;}
        public char Gender {get;set;}
        public string Race {get;set;}
        public int Strength {get;set;}
        public int Dexterity {get;set;}
        public int Constitution {get;set;}
        public int Wisdom {get;set;}
        public int Intelligence {get;set;}
        public int Charisma {get;set;}
        public Weapon Main {get;set;}
        IEquippable Offhand {get;set;}
        IEquippable Armor {get;set;}  
        
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
    }
}