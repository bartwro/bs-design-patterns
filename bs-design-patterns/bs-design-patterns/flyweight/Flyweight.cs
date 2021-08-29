using System;
using System.Collections.Generic;
using System.Text;

namespace bs_design_patterns.flyweight
{
    class Product
    {
        public Guid Id { get; set; }

        public string Name { get; set; }
        public byte[] Image { get; set; }
    }

    class Warehouse
    {
        // shared btwn all Warehosue instances
        static Dictionary<Guid, Product> Products = new Dictionary<Guid, Product>();

        // specific for any instance
        Dictionary<Guid, int> State = new Dictionary<Guid, int>();

        public void StoreProduct(Product product, int quantity)
        {
            if (!Products.ContainsKey(product.Id))
            {
                Products[product.Id] = product;
            }

            if(this.State.ContainsKey(product.Id))
            {
                this.State[product.Id] = this.State[product.Id] + quantity;
            }
            else
            {
                this.State[product.Id] = quantity;
            }
        }

        public void CollectProduct(Guid productId, int quantity)
        {
            if (this.State.ContainsKey(productId))
            {
                this.State[productId] = this.State[productId] - quantity;
            }
            else
            {
                throw new InvalidOperationException("no product in warehouse");
            }
        }

        public (Product product, int quantity) GetProductQuantity(Guid id)
        {
            if(Products.ContainsKey(id))
            {
                return (Products[id], this.State.ContainsKey(id) ? this.State[id] : 0);
            }
            throw new InvalidOperationException("wrong product key");
        }
    }

    class Example
    {
        public static void Run()
        {
            var w1 = new Warehouse();
            var w2 = new Warehouse();
            Guid id1 = Guid.NewGuid();
            w1.StoreProduct(new Product { Id = id1, Name = "p1" }, 1000);
            (Product p, int quantity) = w2.GetProductQuantity(id1);
            Console.WriteLine($"Product: {p.Name}, quantity: {quantity}");
        }
    }

}
