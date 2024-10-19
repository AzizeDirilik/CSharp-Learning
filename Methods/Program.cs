using methods;

Product product1 = new Product();
product1.Name = "Elma";
product1.Description = "Amasya Elmasi";
product1.Price = 10;
product1.Stock = 2;

Product product2 = new Product();
product2.Name = "Karpuz";
product2.Description = "Sulu";
product2.Price = 5;
product2.Stock = 3;

Product[] products = new Product[] { product1, product2 };

foreach (Product product in products)
{
    Console.WriteLine(product.Name);
    Console.WriteLine(product.Description);
    Console.WriteLine(product.Price);
    Console.WriteLine("**********");

}

Console.WriteLine("-------------");

BasketManager basketManager = new BasketManager();
basketManager.Add(product1);
basketManager.Add(product2);
