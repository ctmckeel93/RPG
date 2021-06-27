namespace RPG.Models
{
    public class Rapier : Weapon
    {
        public Rapier(string name, int mod, string rarity ) : base(name, mod, rarity) 
        {
            Name = name;
            Modifier = mod;  
            Rarity = rarity;

            AttackStat = "Dexterity";
            Range = 1.5;

            SellingPrice = CalculatePrice();  
        }
    }
}