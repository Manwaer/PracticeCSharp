class Program
{
    static void Main()
    {
        int[,] train = new int[18, 36];
        Random rnd = new Random();

        for (int i = 0; i < 18; i++)
        {
            for (int j = 0; j < 36; j++)
            {
                train[i, j] = rnd.Next(0, 2);
            }
        }

        for (int i = 0; i < 18; i++)
        {
            bool hasFreeSeats = false;
            for (int j = 0; j < 36; j++)
            {
                if (train[i, j] == 0)
                {
                    hasFreeSeats = true;
                    break;
                }
            }

            if (hasFreeSeats)
            {
                Console.WriteLine($"В вагоне {i + 1} есть свободные места");
            }
            else
            {
                Console.WriteLine($"В вагоне {i + 1} свободных мест нет");
            }
        }
    }
}
