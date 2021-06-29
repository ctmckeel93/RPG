using System;
using System.Collections.Generic;

namespace RPG.Models.Characters
{
    public class Warrior : Character
    {
        public int InitialAC {get;set;}
        public int InitialStrength {get;set;}
        public int BerserkAC {get;set;}
        public int BerserkStrength {get;set;}
        public Warrior(string name, char gender, string race, int str, int dex, int con, int wis, int intel, int cha) : base(name, gender, race, str+=2, dex, con+=2, wis, intel-=1, cha)
        {
            InitialStrength = str;
            InitialAC = Dexterity+10; 
            BerserkAC = AC - 2*Level;
            BerserkStrength = Strength+Level;
        }

        public void Berserk()
        {
            AC = BerserkAC;
            Strength = BerserkStrength;
        }

        public void Calm()
        {
            AC = InitialAC;
            Strength = InitialStrength;
        }

        public void Inspire(List<Character> party)
        {
            foreach (Character member in party)
            {
                member.Strength += 2;
                member.Dexterity +=2;
                member.AC += 2;
            }
        }
    }
}