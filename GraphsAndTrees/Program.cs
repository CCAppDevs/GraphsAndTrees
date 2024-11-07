using System.ComponentModel;

namespace GraphsAndTrees
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Node<Person> node = new Node<Person>(new Person { FirstName = "Jesse", LastName = "Harlan",  Birthdate = DateTime.Now });
            var random = new Random();

            for (int i = 0; i < 10000000; i++)
            {
                node.Add(random.Next(1, 999999));
            }

            Console.WriteLine("Adding numbers is completed... Try to find next");
            Console.ReadLine();

            if (node.HasValue(1000000))
            {
                Console.WriteLine("It exists");
            }
            else
            {
                Console.WriteLine("It does not exist");
            }

            Console.WriteLine($"The tree was searched { Node<int>.CheckCount } times");
        }
    }
}
