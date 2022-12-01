namespace Temp
{
    internal class Program
    {

        class Friend
        {
            public string FirstName { get; set; }
            
            public override string ToString()
            {
                return $"Hello {FirstName}";
            }
            
        }
        static void Main(string[] args)
        {
            Friend f = new Friend { FirstName = "Kalle" };
            Console.WriteLine(f.ToString());

            List<object> list = new List<object>();
            list.Add(f);
            list.Add(new Friend { FirstName = "Mary" });
            list.Add(4);
            list.Add(true);

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

        }
    }
}