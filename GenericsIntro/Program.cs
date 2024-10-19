namespace GenericsIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyList<string> myList = new MyList<string>();
            myList.Add("Ayse");
            Console.WriteLine(myList.Length);
            myList.Add("Ayse");
            Console.WriteLine(myList.Length);

            foreach (var item in myList.Items)
            {
                Console.WriteLine(item);
            }

        }
    }
}
