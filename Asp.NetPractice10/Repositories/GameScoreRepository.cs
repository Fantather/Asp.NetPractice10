using Asp.NetPractice10.Models;

namespace Asp.NetPractice10.Repositories
{
    public class GameScoreRepository
    {
        private readonly List<GameScore> _leaderboard = new List<GameScore>();

        public GameScoreRepository()
        {
            _leaderboard = new List<GameScore>
            {
                new GameScore("PlayerOne", 2500),
                new GameScore("ShadowNinja", 1850),
                new GameScore("CyberSamurai", 3200),
                new GameScore("PixelHunter", 150),
                new GameScore("NeonRider", 940)
            };
        }

        public IEnumerable<GameScore> GetLeaderboard()
        {
            return _leaderboard;
        }
    }
}
