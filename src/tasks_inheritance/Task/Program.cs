namespace Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string title1 = "Creating default player";
            Console.WriteLine(title1);
            Console.WriteLine(new string('*', title1.Length));
            Person player1 = new Player();
            Console.WriteLine("Listing default player properties");
            Console.WriteLine(player1.ToString());

            Console.WriteLine(Environment.NewLine);

            string title2 = "Creating player with user params input";
            Console.WriteLine(title2);
            Console.WriteLine(new string('*', title2.Length));
            Person player2;
            try
            {
                Console.WriteLine("Enter player's data, one property per line. Press <Enter> when done with each prop.");
                string[] props = { "First name", "Second name", "Birth date", "Position in team", "Team joining date" };
                dynamic[] input = new dynamic[5];
                for (int i = 0; i < props.Length; i++)
                {
                    Console.Write(props[i] + ": ");
                    input[i] = (i == 2 || i == 4) ? DateTime.Parse(Console.ReadLine()) : Console.ReadLine();
                }
                player2 = new Player(input[0], input[1], input[2], input[3], input[4]);
            }
            catch (Exception e)
            {
                Console.WriteLine($"Invalid input: {e.Message}");
                Console.WriteLine("Default player instance will be crated.");
                player2 = new Person();
            }

            Console.WriteLine("Listing user specified player properties");
            Console.WriteLine(player2.ToString());
        }
    }
}
