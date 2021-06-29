using RPG.Models.Characters;

namespace RPG.Models.Miscellaneous
{
    public class Spell
    {
        public string Name {get;set;}
        public int DanmageRoll {get;set;}
        public int DC {get;set;}
        public string Affinity {get;set;}

        public Spell(string name, int dmgRoll, int dc, string aff)
        {
            Name = name;
            DanmageRoll = dmgRoll;
            DC = dc;
            Affinity = aff;

        }

        public void AddToSpells(Mage mage)
        {
            mage.Spells.Add(this);
        }
    }
}