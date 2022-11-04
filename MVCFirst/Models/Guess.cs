namespace MVCFirst.Models
{
    public class Guess
    {
        public static string deRandom()
        {
            Random random = new Random();

            for(int j = 0; j <4; j++)
            {
                var rnd = random.Next(1, 101);     
            }
            
            return "";
        }
    }
}
