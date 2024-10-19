namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            list.Add("a");
            list.Add("a");


            Console.WriteLine(list.Count);

            MyList<string> myList = new MyList<string>();
            myList.Add("a");
            myList.Add("a");
            myList.Add("a");


            Console.WriteLine(myList.Count);



        }
    }
}
