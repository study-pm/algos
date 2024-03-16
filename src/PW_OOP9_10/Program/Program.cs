namespace Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Class instance declaration and default constructor call
            Person pers1 = new Person();
            Console.WriteLine("Class instance with fields filled with default values");
            Console.WriteLine(pers1.ToString());
            Console.WriteLine(pers1.ToShortString());

            // Class instance declaration
            Person pers2;
            Console.WriteLine();
            Console.WriteLine("Enter first name, last name and date of birth, press Enter after each value");

            // Constructor call reading user input
            try
            {
                pers2 = new Person(
                    Console.ReadLine(),                 // Reading first name
                    Console.ReadLine(),                 // Reading last name
                    DateTime.Parse(Console.ReadLine())  // Reading birth date
                );
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error while reading your data: {0}", ex.Message);
                pers2 = new Person();
            }
            Console.WriteLine("\nFilling result: \n{0}", pers2.ToString());

            // Changing name, surname and birthdate fields using properties
            pers2.Name = "Полиграф";
            pers2.Surname = "Шариков";
            pers2.Year = 1925;
            Console.WriteLine("\nProperties of pers2 object changed:");
            Console.WriteLine(pers2.ToString());
        }
    }
}
