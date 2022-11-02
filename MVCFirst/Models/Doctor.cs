namespace MVCFirst.Models
{
    public class Doctor
    {
        public static string Diagnose(double temp)
        {
            bool temperature = false;
            while (!temperature)
            {
                if (temp == 37)
                {
                    return "You have perfectly well, go home!";
                    temperature = true;
                }
                else if (temp > 36 && temp < 38)
                {
                    return "You should get some rest!";
                }
                else if (temp < 36)
                {
                    return "close to hypothermia";
                }
                else if (temp > 38 && temp < 40)
                {
                    return "Crazy high fever!";
                }
                else if (temp > 40)
                {
                    return "Rest in Peace ";
                }

            }
            return "Temp outside";
            //return (temp > 37) ? "Almost healty...have a cookie" : "No fever..Do not take a cookie!";

        }
    }
}
