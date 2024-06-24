namespace Rock_Paper_Scissors
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Welcome to Rock, Paper, Scissors!\n Please enter your Name:");
            //string name = Console.ReadLine();
            Player player = new Player("Player");
            Player ai = new Player("AI");

            RPSGame game = new RPSGame(player, ai);
            game.PlayGame();
        }
    }
}
