namespace MyDictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string> myDictionary = new MyDictionary<string>();
            myDictionary.Add("a");
            myDictionary.Add("a");
            myDictionary.Add("a");

            Console.WriteLine(myDictionary.Count);
        }
    }
}
