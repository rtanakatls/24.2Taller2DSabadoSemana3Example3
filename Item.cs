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

        public string Name { get { return name; } }
        public int Amount { get { return amount; } }
        public float Price { get { return price; } }

        public Item(string name, int amount, float price)
        {
            this.name = name;
            this.amount = amount;
            this.price = price;
        }

        public bool CheckStock(int amount)
        {
            if(this.amount >= amount)
            {
                return true;
            }
            return false;
        }

        public bool CheckTotalPrice(float money,int amount)
        {
            if(money>= price * amount)
            {
                return true;
            }
            return false;
        }

        public void ReduceStock(int amount)
        {
            this.amount -= amount;
        }

        public string GetData()
        {
            return $"Nombre: {name}, Cantidad: {amount}, Precio: {price}";
        }

    }
}
