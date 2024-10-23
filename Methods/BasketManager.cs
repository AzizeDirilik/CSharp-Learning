namespace methods
{
    internal class BasketManager
    {
        public void Add(Product product)
        {
            Console.WriteLine("Sepete eklendi : " + product.Name, product.Stock);


        }


    }
}
