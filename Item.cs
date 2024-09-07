using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24._2Taller2DSabadoTienda
{
    internal class Item
    {
        private string name;
        private int amount;
        private float price;

        public Item(string name, int amount, float price)
        {
            this.name = name;
            this.amount = amount;
            this.price = price;
        }

        public string GetData()
        {
            return $"Nombre: {name}, Cantidad: {amount}, Precio: {price}";
        }

    }
}
