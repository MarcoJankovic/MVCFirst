namespace MVCFirst.Models
{
    public class Guess
    {
        public int Number { get; set; }

        public void RandomNum()
        {
            Random random = new Random();
            Number = random.Next(1, 101);
        }
        public void RandomNum(int guess)

        {
            Random random = new Random();
            Number = random.Next(1, 101);
        }

    }
}