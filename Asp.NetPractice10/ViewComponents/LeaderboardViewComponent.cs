using Asp.NetPractice10.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Asp.NetPractice10.ViewComponents
{
    public class LeaderboardViewComponent(GameScoreRepository repository) : ViewComponent
    {
        private readonly GameScoreRepository _repository = repository;

        public async Task<IViewComponentResult> InvokeAsync()
        {
            return await Task.FromResult((IViewComponentResult)View("Leaderboard", _repository.GetLeaderboard()));
        }
    }
}
