using System.Security.Cryptography;

namespace numberGuessing
{
    class guessNumber
    {


        public static void Main(String[] args)
        {
            Random random = new Random();
            int target = random.Next(0, 1000);
            Console.WriteLine("Guess a number between 1 and 1000");

            while (true)
            {
                int guessedNumber = int.Parse(Console.ReadLine());
                if(guessNumber.checkTarget(guessedNumber, target))
                {
                    Console.WriteLine("You guessed correctly");
                    return;
                }
            }
        }

        public static Boolean checkTarget(int guessedNumber, int target)
        {
            if (target > guessedNumber)
            {
                Console.WriteLine("Too low, try again");
                return false;
            }
            if (target < guessedNumber)
            {
                Console.WriteLine("Too high, try again");
                return false;
            }
            return true;
        }
    }
}