using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24._2Taller2DSabadoTienda
{
    internal class Store
    {
        private List<Item> items;
        private List<Item> cart;
        private float money;

        public void Execute()
        {
            CreateItems();
        }

        private void CreateItems()
        {
            items = new List<Item>();
            items.Add(new Item("Leche", 10, 100));
            items.Add(new Item("Huevos", 5, 20));
            items.Add(new Item("Queso", 15, 50));
        }
    }
}
