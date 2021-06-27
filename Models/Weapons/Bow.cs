namespace RPG.Models
{
    public class Bow : Weapon
    {
        public Bow(string name, int mod, string rarity ) : base(name, mod, rarity) 
        {
            Name = name;
            Modifier = mod;  
            Rarity = rarity;

            AttackStat = "Dexterity";
            Range = 3;

            SellingPrice = CalculatePrice();  
        }
    }
}