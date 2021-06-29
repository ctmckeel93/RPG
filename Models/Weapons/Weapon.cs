using System;
using RPG.Interfaces;

namespace RPG.Models
{
    public abstract class Weapon : IEquippable
    {
        public string Name { get; set;}
        public int Modifier { get; set;}

        public string Rarity {get;set;}

        public string AttackStat {get; set;}

        public bool IsHeavy {get;set;}

        public int? SellingPrice {get; set;}
        public double? Range { get; set;}

        public Weapon(string name, int mod, string rarity)
        { 
            Name = name;    
            Modifier = mod;
            Rarity = rarity;
            AttackStat = null;
            SellingPrice = null;  
            Range = null;
            IsHeavy = false;

        }

        protected int CalculatePrice() 
        { 
            int price = 0;

            switch(this.Rarity)
            {
                case "Common":
                    price = 100;
                    break;
                case "Uncommon":
                    price = 150;
                    break;
                case "Rare":
                    price = 300; 
                    break;
                case "Legend":
                    price = 500;
                    break;
                case "Mythic":
                    price = 1000; 
                    break;
            }

            return price;
        }

        public void Equip(Character target, string hand)
        { 
            if (hand == "Main")
            {
                target.Main = this;
            }
            if (hand == "Offhand")
            {
                if (IsHeavy == false)
                {
                    if (target.Main.IsHeavy == false)
                    {
                        target.Offhand = this;
                    }
                }
                else
                {
                    Console.WriteLine("This weapon cannot be equipped in this slot");
                }
            }
        }
    }
}