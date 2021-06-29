namespace RPG.Models.Armor
{
    public class Shield : ArmorClass
    {
        public Shield(string name, int mod, string resistance) : base(name, mod, resistance)
        {}

        public override void Equip(Character character, string hand)
        {
            character.Offhand = this;
            character.AC += Modifier;
            character.takeDamage(-20);
        }
    }
}