

namespace Fundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            var userInput = Console.ReadLine();
            bool result = int.TryParse(userInput, out int number);

            Console.WriteLine(number);
            switch (result)
            {
                case true:
                    Console.WriteLine('a');
                    break;
            }
        }

    }
}
