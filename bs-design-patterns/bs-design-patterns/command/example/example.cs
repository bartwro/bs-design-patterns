using System;
using System.Collections.Generic;
using System.Text;

namespace bs_design_patterns.command.example
{
    static class ItemsStockRepository
    {
        static readonly Dictionary<string, int> itemIdToQuantity = new Dictionary<string, int>();
        private static readonly object syncObj;

        public static int AddToStock(string itemId, int quantity)
        {
            lock (syncObj)
            {
                var actual = itemIdToQuantity.ContainsKey(itemId) ? itemIdToQuantity[itemId] : 0;
                itemIdToQuantity[itemId] = actual + quantity;
                return itemIdToQuantity[itemId];
            }
        }
    }

    class ShoppingCartRepository
    {
        Dictionary<string, int> itemsInCart = new Dictionary<string, int>();
        public void AddItem(string id, int quantity)
        {
            this.itemsInCart[id] = (this.itemsInCart.ContainsKey(id) ? itemsInCart[id] : 0) + quantity;
        }
    }

    class Item
    {
        public Item(string id, double price, string name)
        {
            this.Id = id;
            this.Price = price;
            this.Name = name;
        }

        public string Id { get; }
        public double Price { get; }
        public string Name { get; }

    }
    class AddItemToShoppingCartCommand : ICommand
    {
        public bool CanExecute()
        {
            throw new NotImplementedException();
        }

        public void Execute()
        {
            throw new NotImplementedException();
        }

        public void Undo()
        {
            throw new NotImplementedException();
        }
    }
}
