/* Вычислить стоимость поездки на автомобиле на дачу (туда и обратно).
 * Исходными данными являются: расстояние до дачи (км);
 * количество бензина, которое потребляет автомобиль на 100 км пробега;
 * цена 1 литра бензина.
 */

namespace Console_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter distance in km: ");
                double distance = double.Parse(Console.ReadLine());
                Console.Write("Enter gas consumption in l/100km: ");
                double consumption = double.Parse(Console.ReadLine());
                Console.Write("Enter gas price for 1 liter in roubles: ");
                double price = double.Parse(Console.ReadLine());

                if (distance < 0 || consumption < 0 || price < 0) throw new Exception("Must be a non-negative number");

                double cost = distance * consumption / 100 * price * 2;

                Console.WriteLine("Trip cost (hin und zurück): {0:.##}", cost);
            }
            catch (Exception e)
            {
                Console.WriteLine("Invalid input: " + e.Message);
            }
        }
    }
}
