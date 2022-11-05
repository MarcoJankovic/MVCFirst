namespace MVCFirst.Models
{
    public class Guess
    {
        public static string RandomNum(int guess, bool go)
        {
            Random random = new Random();

            int rnd = random.Next(1, 101);
            int count = 0;

            do
            {
                if (guess < rnd)
                {
                    count++;
                    return "Your guess " + guess + " was to low\n " + " Current Guesses: " + count + " Random nr: " + rnd;
                }
                else if (guess > rnd)
                {
                    count++;
                    return "Your guess " + guess + " was to high\n " + " Current Guesses: " + count;
                }
                else if (guess == rnd)
                {
                   
                    return "Your guess was correct! " + guess + " Your guess was same as random number! " + rnd + " Amount of guesses: " + count;
                }

            }
            while (!go);
            return "-";
        }
    }
}