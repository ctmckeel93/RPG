namespace RPG.Models
{
    public class Staff : Weapon
    {
        public Staff(string name, int mod, string rarity ) : base(name, mod, rarity) 
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