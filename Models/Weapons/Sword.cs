namespace RPG.Models
{
    public class Sword : Weapon
    {
        public Sword(string name, int mod, string rarity ) : base(name, mod, rarity) 
        {
            Name = name;
            Modifier = mod;  
            Rarity = rarity;

            AttackStat = "Strength";
            Range = 1;

            SellingPrice = CalculatePrice();  
        }
    }
}