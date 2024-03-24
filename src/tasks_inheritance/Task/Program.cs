namespace Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person;
            try
            {
                Console.Write("Enter person's first name, last name and date of birth separated by spaces: ");
                string[] input = Console.ReadLine().Split();
                if (input.Length != 3) throw new Exception("Incomplete input - invalid format, some data is missing.");
                person = new Person(input[0], input[1], DateTime.Parse(input[2]));
            }
            catch(Exception e)
            {
                Console.WriteLine($"Invalid input: {e.Message}");
                Console.WriteLine("Default person object will be crated.");
                person = new Person();
            }
            Console.WriteLine("New person item is created.");
            Console.WriteLine(person.ToString());
        }
    }
}
