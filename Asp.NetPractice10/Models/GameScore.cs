namespace Asp.NetPractice10.Models
{
    public class GameScore
    {
        public string UserName { get; set; }
        public int Score { get; set; }

        public GameScore(string userName, int score = 0)
        {
            UserName = userName;
            Score = score;
        }

    }
}
