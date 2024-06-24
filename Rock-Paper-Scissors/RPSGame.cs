using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock_Paper_Scissors
{
    public class RPSGame
    {
        private Player _player;
        private Player _ai;
        private Random _random;

        public RPSGame(Player player, Player ai)
        {
            _player = player;
            _ai = ai;
            _random = new Random();
        }

        public void PlayRound()
        {
            string playerMove = _player.ChooseMove();
            string aiMove = GetRandomMove();
            Console.WriteLine($"AI chose: {aiMove}");

            if (playerMove == aiMove)
            {
                Console.WriteLine("It's a tie!");
            }
            else if ((playerMove == "rock" && aiMove == "scissors") ||
                     (playerMove == "paper" && aiMove == "rock") ||
                     (playerMove == "scissors" && aiMove == "paper"))
            {
                Console.WriteLine($"{_player.Name} wins the round!");
                _player.Score++;
            }
            else
            {
                Console.WriteLine("AI wins the round!");
                _ai.Score++;
            }
            DisplayScores();
        }

        public void DisplayScores()
        {
            Console.WriteLine($"Scores: {_player.Name} : {_player.Score}, AI : {_ai.Score}");
        }

        public void PlayGame()
        {
            while (_player.Score < 3 && _ai.Score < 3)
            {
                PlayRound();
            }
            if (_player.Score == 3)
            {
                Console.WriteLine($"{_player.Name} wins the game!");
            }
            else
            {
                Console.WriteLine("AI wins the game!");
            }
        }

        private string GetRandomMove()
        {
            string[] moves = { "rock", "paper", "scissors" };
            return moves[_random.Next(moves.Length)];
        }
    }
}
