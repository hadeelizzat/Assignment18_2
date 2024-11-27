using System.Collections.Generic;
using UnityEngine;
namespace Assignment18_2
{
    public class Inventory
    {
        private List<string> list = new List<string>();
        public void AddItem(string item)
        {
            list.Add(item);
        }
        public void ShowItems()
        {
            foreach (string item in list)
            {
                Debug.Log(item);
            }

        }
        public static Inventory operator +(Inventory a, Inventory b)
        {
            Inventory inventory3 = new Inventory();
            foreach (var item in a.list)

                inventory3.AddItem(item);

            foreach (var item in b.list)

                inventory3.AddItem(item);

            return inventory3;
        }




    }
}