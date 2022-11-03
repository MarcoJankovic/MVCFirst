namespace MVCFirst.Models
{
    public class Doctor
    {
        public static string Diagnose(double temp)
        {
                if (temp == 37)
                {
                    return "You have perfectly well, go home!";
                }
                else if (temp >= 36 && temp <= 38)
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
      
            return "Temp outside";

        }
    }
}
