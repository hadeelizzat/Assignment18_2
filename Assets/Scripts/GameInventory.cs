using System.Collections.Generic;
using UnityEngine;
namespace Assignment18_2
{

    public class GameInventory : MonoBehaviour
    {
        Inventory potions = new Inventory();
        Inventory elixirs = new Inventory();
        void Start()
        {
            //Create an inventory for potions and add "Healing Potion" and "Strength Potion".
            potions.AddItem("Healing Potion");
            potions.AddItem("Strength Potion");
            //Create another inventory for elixirs and add "Elixir" and "Dark Elixir".
            elixirs.AddItem("Elixir");
            elixirs.AddItem("Dark Elixir");
            (potions + elixirs).ShowItems();
        }


    }
}