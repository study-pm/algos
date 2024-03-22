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

            Console.WriteLine();

            // Filling in students
            Student student1 = new();
            Student student2 = new(pers1, "ул. Ленина, д. 40, г. Майкоп, Республика Адыгея, 385000", new DateTime(2022, 02, 23));
            Student student3 = new(pers2, "пр-т Калинина, д. 8, г. Барнаул, Алтайский край, 656002", new DateTime(2021, 03, 08));

            // Working with group
            Console.WriteLine("Working with a group");
            Console.WriteLine("********************");
            Group group = new Group();
            Console.WriteLine("Creating a new group");
            Console.WriteLine(group.ToShortString());

            Console.WriteLine();

            Console.WriteLine("Programmatically set the group's properties.");
            group.Name = "53-02в";
            group.Year = 2023;
            Console.WriteLine(group.ToString());

            Console.WriteLine();

            Console.WriteLine("Adding the students to the group");
            group.AddStudents(new Student[] { student1, student2, student3 });
            Console.WriteLine(group.ToString());
        }
    }
}
