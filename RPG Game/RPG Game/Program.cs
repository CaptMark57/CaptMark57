namespace RPG_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Output the text stating that we want the players name.
            Console.WriteLine("What is your name?");

            //Store the players name entered.
            string playersName = Console.ReadLine();

            //Let the player know his name.
            Console.WriteLine("Thank you for entering your name, " +playersName + ".");


            




        }
    }
}
