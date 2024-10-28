using System.Linq;

namespace Linq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>()
            {
                new Product{ProductId =1, CategoryId = 1, ProductName = "Sandalye", ProductDescription = "Ahsap", UnitPrice = 200, UnitStock= 20},
                new Product{ProductId =2, CategoryId = 1, ProductName = "Masa", ProductDescription = "Metal", UnitPrice = 500, UnitStock= 5},
                new Product{ProductId =3, CategoryId = 2, ProductName = "Tabak", ProductDescription = "Beyaz", UnitPrice = 200, UnitStock= 20},
                new Product{ProductId =4, CategoryId = 2, ProductName = "Bardak", ProductDescription = "Beyaz", UnitPrice = 100, UnitStock= 30}

            };

            List<Category> categories = new List<Category>()
            {
                new Category{CategoryId = 1,CategoryName = "Mobilya"},
                new Category{CategoryId = 2,CategoryName = "Mutfak"},
            };
            //GetProducts(products);

            //  Test(products);

            // AnyTest(products);

            // FindTest(products);

            // FindAllTest(products);

            // AscDescTest(products);

            // ClassicLinqTest(products);

            var result = from p in products
                         join c in categories
                         on p.CategoryId equals c.CategoryId
                         select new ProductDto { ProductId = p.ProductId, ProductName = p.ProductName, CategoryName = c.CategoryName, UnitPrice = p.UnitPrice };
            foreach (var productDto in result)
            {
                Console.WriteLine("{0} --- {1}",productDto.ProductName ,productDto.CategoryName);
            }

        }

        private static void ClassicLinqTest(List<Product> products)
        {
            var result = from p in products
                         where p.UnitStock > 5
                         orderby p.ProductName ascending, p.UnitPrice descending
                         select new ProductDto { ProductId = p.ProductId, UnitPrice = p.UnitPrice, ProductName = p.ProductName};

            foreach (var product in result)
            {
                Console.WriteLine(product.ProductName);
            }
        }

        private static void AscDescTest(List<Product> products)
        {
            var result = products.Where(p => p.ProductName.Contains("ak")).OrderByDescending(p => p.UnitPrice).ThenByDescending(p => p.ProductName);
            foreach (var product in result)
            {
                Console.WriteLine(product.ProductName);
            }
        }

        private static void FindAllTest(List<Product> products)
        {
            var result = products.FindAll(p => p.ProductName.Contains("bak"));
            Console.WriteLine(result);
        }

        private static void FindTest(List<Product> products)
        {
            var result = products.Find(p => p.ProductId == 3);
            Console.WriteLine(result.ProductName);
        }

        private static void AnyTest(List<Product> products)
        {
            var result = products.Any(p => p.ProductDescription == "Ahsap");
            Console.WriteLine(result);
        }

        private static void GetProducts(List<Product> products)
        {
            foreach (var product in products.Where(product => product.UnitPrice > 100 && product.UnitStock > 10))
            {
                Console.WriteLine(product.ProductName);
            }
        }

        private static void Test(List<Product> products)
        {
            Console.WriteLine("*********LINQ*********");

            List<Product> result = products.Where(p => p.UnitPrice > 10 && p.UnitStock > 10).ToList();

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

class ProductDto
{
    public int ProductId { get; set; }
    public string ProductName { get; set; }
    public decimal UnitPrice { get; set; }
    public string CategoryName { get; set; }
}