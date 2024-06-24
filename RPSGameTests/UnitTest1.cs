using Rock_Paper_Scissors;
using Xunit;

namespace RPSGameTests
{
    public class UnitTest1
    {
        [Fact]
        public void PlayRound_PlayerWins()
        {
            // Arrange
            var player = new Player("Player");
            var ai = new Player("AI");
            var game = new RPSGame(player, ai);
            Console.SetIn(new System.IO.StringReader("rock"));

            // Act
            game.PlayRound();

            // Assert
            Assert.Equal(1, player.Score); 
            Assert.Equal(0, ai.Score);
        }

        [Fact]
        public void PlayRound_AIWins()
        {
            // Arrange
            var player = new Player("Player");
            var ai = new Player("AI");
            var game = new RPSGame(player, ai);
            Console.SetIn(new System.IO.StringReader("scissors"));

            // Act
            game.PlayRound();

            // Assert
            Assert.Equal(0, player.Score); 
            Assert.Equal(1, ai.Score);
        }

        [Fact]
        public void PlayRound_Tie()
        {
            // Arrange
            var player = new Player("Player");
            var ai = new Player("AI");
            var game = new RPSGame(player, ai);
            Console.SetIn(new System.IO.StringReader("paper"));

            // Act
            game.PlayRound();

            // Assert
            Assert.Equal(0, player.Score); 
            Assert.Equal(0, ai.Score);
        }

        [Fact]
        public void PlayGame_PlayerWins()
        {
            // Arrange
            var player = new Player("Player");
            var ai = new Player("AI");
            var game = new RPSGame(player, ai);

            Console.SetIn(new System.IO.StringReader("rock\nrock\nrock"));

            // Act
            game.PlayGame();

            // Assert
            Assert.Equal(3, player.Score); 
            Assert.Equal(0, ai.Score);
        }

        [Fact]
        public void PlayGame_AIWins()
        {
            // Arrange
            var player = new Player("Player");
            var ai = new Player("AI");
            var game = new RPSGame(player, ai);
            Console.SetIn(new System.IO.StringReader("rock\nrock\nscissors\npaper\nscissors"));

            // Act
            game.PlayGame();

            // Assert
            Assert.Equal(0, player.Score); 
            Assert.Equal(3, ai.Score);
        }
    }
}
