namespace Linq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>()
            {
                new Product{ProductId =1, CategoryId = 1, ProductName = "Masa", ProductDescription = "Ahsap", UnitPrice = 200, UnitStock= 20},
                new Product{ProductId =2, CategoryId = 1, ProductName = "Masa", ProductDescription = "Metal", UnitPrice = 500, UnitStock= 5},
                new Product{ProductId =3, CategoryId = 2, ProductName = "Tabak", ProductDescription = "Beyaz", UnitPrice = 200, UnitStock= 20},
                new Product{ProductId =4, CategoryId = 2, ProductName = "Bardak", ProductDescription = "Beyaz", UnitPrice = 100, UnitStock= 30}

            };

            List<Category> categories = new List<Category>() 
            {
                new Category{CategoryId = 1,CategoryName = "Mobilya"},
                new Category{CategoryId = 2,CategoryName = "Mutfak"},
            };

            foreach (var product in products) 
            {
                if (product.UnitPrice > 100 && product.UnitStock > 10)
                {
                    Console.WriteLine(product.ProductName);

                }
            }

            Console.WriteLine("*********LINQ*********");

            List<Product> result = products.Where(p=> p.UnitPrice>10 && p.UnitStock > 10).ToList();

            foreach (var product1 in result)
            {
                Console.WriteLine(product1.ProductName);
            }

        }
    }
}

class Product
{
    public int ProductId { get; set; }
    public int CategoryId { get; set; }
    public string ProductName { get; set; }
    public string ProductDescription { get; set; }
    public int UnitStock { get; set; }
    public decimal UnitPrice { get; set; }
}

class Category
{
    public int CategoryId { get; set; }
    public string CategoryName { get; set; }
}