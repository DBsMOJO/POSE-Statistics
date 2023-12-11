#nullable disable


namespace Uebung24
{
    public class Uebung24
    {
        static void Main()
        {
            string input;
            int sum = 0,
                max = Int32.MinValue,
                min = Int32.MaxValue,
                num,
                idx = 0;
            double average = 0;

            // Input
            Console.WriteLine("Zahlen-Statistik");
            Console.WriteLine("================");
            Console.WriteLine("Geben Sie positive Ganzzahlen ein [0..Ende].\n");

            do
            {
                Console.Write($"Zahl {++idx}: ");
                input = Console.ReadLine();
                num = Convert.ToInt32(input);
                if (num != 0)
                {
                    // Verarbeitung
                    sum += num;
                    if (num > max)
                    {
                        max = num;
                    }
                    if (num < min)
                    {
                        min = num;
                    }
                    average = sum / (double)idx;
                }
            } while (num != 0);

            // Ausgabe
            Console.WriteLine($"\nSie haben {idx - 1} Zahlen eingegeben.");
            if (idx > 1)
            {
                Console.WriteLine($"Die Summe der eingegebenen Zahlen ist {sum}");
                Console.WriteLine($"Die maximalle Zahl ist {max}");
                Console.WriteLine($"Die minimalle Zahl ist {min}");
                Console.WriteLine($"Der Durchschnitt ist {average:f}");
            }
        }
    }
}
