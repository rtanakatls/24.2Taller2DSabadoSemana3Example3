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
            Shop();
        }

        private void CreateItems()
        {
            items = new List<Item>();
            items.Add(new Item("Leche", 10, 100));
            items.Add(new Item("Huevos", 5, 20));
            items.Add(new Item("Queso", 15, 50));
        }

        private void Shop()
        {
            bool continueFlag = true;
            AddMoney();
            while (continueFlag)
            {
                StartCart();
                Console.WriteLine("Desea seguir comprando? (s/n)");
                string response = Console.ReadLine();
                if (response == "n")
                {
                    continueFlag = false;
                }
            }
        }

        private void AddMoney()
        {
            Console.WriteLine("Introduce la cantidad de dinero que tienes: ");
            money = float.Parse(Console.ReadLine());
        }

        private void StartCart()
        {
            cart = new List<Item>();
            bool continueFlag = true;
            while(continueFlag)
            {
                Console.WriteLine("Introducir el número de la opción");
                ShowItems();
                Console.WriteLine("-1. Ver el carrito de compras");
                Console.WriteLine("-2. Terminar compra");
                int option = int.Parse(Console.ReadLine());
                switch(option)
                {
                    case -1:
                        ShowCart();
                        break;
                    case -2:
                        continueFlag = false;
                        break;
                    default:
                        AddToCart(option);
                        break;
                }
                
            }
        }

        private void ShowCart()
        {
            Console.WriteLine($"Tienes {money} de dinero ");
            for (int i = 0; i < cart.Count; i++)
            {
                Console.WriteLine($"{i}. {cart[i].GetData()}");
            }
        }

        private void ShowItems()
        {
            for(int i = 0; i < items.Count; i++)
            {
                Console.WriteLine($"{i}. {items[i].GetData()}");
            }
        }

        private void AddToCart(int option)
        {
            if (option < 0 || option > items.Count)
            {
                Console.WriteLine("Opción no válida");
            }
            else if (!items[option].CheckStock(1))
            {
                Console.WriteLine("No hay stock del producto");
            }
            else
            {
                Console.WriteLine("Introduce la cantidad de productos que deaseas:");
                int amount = int.Parse(Console.ReadLine());
                Item item = items[option];
                if (amount > 0)
                {
                    if (item.CheckStock(amount))
                    {
                        if (item.CheckTotalPrice(money, amount))
                        {
                            cart.Add(new Item(item.Name, amount, item.Price));
                            item.ReduceStock(amount);
                            money -= item.Price * amount;
                        }
                        else
                        {
                            Console.WriteLine("No tienes dinero suficiente");
                        }
                    }
                    else
                    {
                        Console.WriteLine("No hay stock suficiente");
                    }
                }
                else
                {
                    Console.WriteLine("Cantidad no válida");
                }
            }
        }
    }
}
