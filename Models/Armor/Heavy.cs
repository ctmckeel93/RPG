namespace RPG.Models.Armor
{
    public class Heavy : ArmorClass
    {
        public Heavy(string name, int mod, string resistance) : base(name, mod, resistance)
        {}

        public override void Equip(Character character, string hand=null)
        {
            character.Armor = this;
            character.AC-= 2;
            character.takeDamage(10*Modifier);
        }
    }
}