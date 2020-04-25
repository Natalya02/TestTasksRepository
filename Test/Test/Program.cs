using System;
using System.Runtime.Remoting.Metadata;

public class Product
{
    public string Name { get; set; }
    public int Price { get; set; }

    public Product (string name, int price)
    {
        Name = name;
        Price = price;
    }
    public Product()
    {
        Name = "";
        Price = 0;
    }
}



public class Program
{

    static Product[] products = new Product[100];
    static int length = 0;
    static public void CreateProduct(string name, int price)
    {
        products[length] = new Product(name, price);
        length++;
    }

    static public void ShowProducts()
    {
        for(int i=0; i<length; i++)
        {
            Console.WriteLine(products[i].Name, products[i].Price);
        }
    }
    static public Product GetMostExpansive()
    {
        Product Max = products[0];
       
        for (int i = 0; i < length; i++)
        {
            if (products[i].Price > Max.Price)
            {
                Max = products[i];
            }
            
        }

        return Max;
    }
    static public Product GetMostCheap()
    {
        Product Min = products[0];

        for (int i = 0; i < length; i++)
        {
            if (products[i].Price < Min.Price)
            {
                Min = products[i];
            }

        }

        return Min;
    }

    static public void FromTwo(Product a, Product b)
    {
        if (a.Price > b.Price)
        {
            Console.WriteLine(a.Name + " is more expensive than " + b.Name);
        }
        if (a.Price < b.Price)
        {
            Console.WriteLine(b.Name + " is more expensive than " + a.Name);
        }
        else Console.WriteLine(a.Name + " and " + b.Name + " have the same price");

    }

    static void Main()
    {
        Program.CreateProduct("apple", 12);
        Program.CreateProduct("pear", 14);
        Program.CreateProduct("meat", 150);
        Program.CreateProduct("cake", 100);

        Product MinPrice = Program.GetMostCheap();
        Product MaxPrice = Program.GetMostExpansive();

        Program.ShowProducts();
        Console.WriteLine("The most expansive product is: "+MaxPrice.Name+". Its price is: " + MaxPrice.Price);
        Console.WriteLine("The most cheap product is: " + MinPrice.Name + ". Its price is: " + MinPrice.Price);
        Console.ReadLine();

    }
}
    