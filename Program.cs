// Product Inventory Project
// By lawrenceav

using System;

namespace main
{
    class Product {
    public int price;
    public string id;
    public static int quantity;

}

    class Inventory : Product {
    public string name;
    static Inventory[] products = new Inventory[] {
        new Inventory { name = "Apple", price = 10, id = "1" },
        new Inventory { name = "Carrot", price = 12, id = "2" },
        new Inventory { name = "Cabbage", price = 15, id = "3" }
    };

    public static void GetSum() {
        Product.quantity += products.Length;
        int a = Product.quantity;
        Console.WriteLine($"Quantity: {a}");
    }

    public static void Print() {
        foreach (Inventory inventory in products) {
            Console.WriteLine($"Name: {inventory.name}\nPrice: {inventory.price}\nID: {inventory.id}");
        }
    }
}
    class Program
    {
        static void Main(string[] args)
        {
            Inventory.Print();
            Inventory.GetSum();
        }
    }
}
