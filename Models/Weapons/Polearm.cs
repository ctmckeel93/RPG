namespace RPG.Models
{
    public class Polearm : Weapon
    {
        public Polearm(string name, int mod, string rarity ) : base(name, mod, rarity) 
        {
            Name = name;
            Modifier = mod;  
            Rarity = rarity;

            AttackStat = "Dexterity";
            Range = 2;
            SellingPrice = CalculatePrice();  
        }
    }
}