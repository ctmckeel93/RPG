using RPG.Models;

namespace RPG.Interfaces
{
    public interface IEquippable
    {
        string Name { get; set; }
        int Modifier { get; set; }

        void Equip(Character target, string hand); 
    }
}