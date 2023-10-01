namespace NumbersGame_1
{
        internal class Program
        {
            static void Main(string[] args)
            {

                Console.WriteLine("Välkommen! Jag tänker på ett nummer. " +
                    "Kan du gissa vilket? Du får fem försök.");

                Random random = new Random();
                int number = random.Next(1, 21);
                int attempts = 0;
                int guess = 0;
                bool correctGuess = false;

                while (attempts < 5)
                {
                    guess = Int32.Parse(Console.ReadLine());
                    attempts++;

                    if (CheckGuess(guess, number))
                    {
                        correctGuess = true;
                        break;
                    }

                }
                if (!correctGuess)
                {
                    Console.WriteLine("Tyvärr, du lyckades inte gissa talet på fem försök!");
                }
            }
            static bool CheckGuess(int guess, int number)
            {
                if (guess == number)
                {
                    Console.WriteLine("Wohoo! Du klarade det!");
                    return true;
                }
                else if (guess < number)
                {
                    Console.WriteLine("Tyvärr, du gissade för lågt!");
                }
                else
                {
                    Console.WriteLine("Tyvärr, du gissade för högt!");
                }
                return false;
            }
        }
    }
