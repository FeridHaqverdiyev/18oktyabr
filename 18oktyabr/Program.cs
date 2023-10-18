using _18oktyabr.Models;

namespace _18oktyabr
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ListInt list = new ListInt();
            list.Add(45);
            list.AddRanger(16, 50, 43);
           
            Console.WriteLine(list.Sum());
            Console.WriteLine(list.Contains(0));
            string result =list.ToString();
            Console.WriteLine(result);
        }
    }
}