namespace KeyValue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "KeyValue";
            Dictionary<string, string> BookList=new Dictionary<string, string>();
            BookList.Add("Stuart Yarnold", "Arduino");
            BookList.Add("Nick Vandome", "Windows 10");
            BookList.Add("Mike McGrath", "Java");
            Console.WriteLine("Popular Titles...");

            foreach(KeyValuePair<string, string> book in BookList)
            {
                Console.WriteLine("Key:" + book.Key + "\tValue:" + book.Value + "In easy steps");
            }
            Console.ReadKey();
        }
    }
}