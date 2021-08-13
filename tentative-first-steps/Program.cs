using System;

namespace tentative_first_steps
{
    class Program
    {
        public static Player currentPlayer = new Player(); // creates a new Player object which is an instance of the Player class

        static void Main(string[] args)
        {
            Program.Start();
        }

        static void Start ()
        {
            Console.WriteLine("Tentative First Steps...");
            Console.Write("Player Name: ");
            currentPlayer.name = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("A cold sensation wakes you. Your eyes are shut and your ears are ringing.");
            Console.WriteLine("You can't remember where you are, or how you got here...");

            if (currentPlayer.name == "")
                Console.WriteLine("You can't even remember your own name...");
            else
                Console.WriteLine($"You only remember that your name is {currentPlayer.name}");

            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("You blink your eyes open and are greeted by darkness.");
            Console.WriteLine("You are lying on a cold stone floor.");
            Console.WriteLine("You pull yourself upright and begin to feel your surroundings");
            Console.WriteLine("After a few minutes you find a sturdy wooden door and push it open");
        }
    }
}
