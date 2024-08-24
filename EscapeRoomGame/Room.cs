namespace EscapeRoomGame;

public class Room
{
    public static void Yours()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("You are inside your room.");
            Creep.Scare();
            Thread.Sleep(1000);
            Console.WriteLine("[1] Check bed.\n[2] Check closet.\n[3] Check desk.\n[4] Leave.");
            switch (Player.InputParse4())
            {
                case 1:
                    Console.WriteLine("You investigated the bed.");
                    Thread.Sleep(2000);
                    Console.WriteLine("There was nothing worthwhile.");
                    Console.ReadLine();
                    break;
                case 2:
                    Console.WriteLine("You investigated the closet.");
                    Thread.Sleep(2000);
                    Console.WriteLine("It is locked.");
                    Console.ReadLine();
                    break;
                case 3:
                    Console.WriteLine("You investigated the desk.\n");
                    Thread.Sleep(2000);
                    if (!Player.Inventory.Contains("batteries"))
                    {
                        Console.WriteLine("You picked up some batteries.");
                        Player.Inventory.Add("batteries");
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("There is nothing of interest anymore.");
                        Console.ReadLine();
                    }
                    break;
                case 4:
                    Console.WriteLine("You opened your door and left.");
                    Console.ReadLine();
                    Hospital.Intersection();
                    break;
            }
        }
    }
}