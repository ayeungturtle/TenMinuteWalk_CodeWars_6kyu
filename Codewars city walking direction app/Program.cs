public class Kata
{
    public static bool IsValidWalk(string[] walk)
    {
        int west_east_movement = 0;
        int south_north_movement = 0;
        if (walk.Length < 10 || walk.Length > 10)
            return (false);

        else
        {
            for (int i = 0; i < walk.Length; i++)
            {
                if (walk[i] == "n")
                {
                    south_north_movement += 1;
                }
                if (walk[i] == "s")
                {
                    south_north_movement -= 1;
                }
                if (walk[i] == "e")
                {
                    west_east_movement += 1;
                }
                if (walk[i] == "w")
                {
                    west_east_movement -= 1;
                }
            }

            if (west_east_movement == 0 && south_north_movement == 0)
            {
                return (true);
            }
            else
                return (false);

        }
    }
}