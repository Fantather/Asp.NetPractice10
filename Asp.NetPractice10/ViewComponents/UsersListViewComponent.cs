using Microsoft.AspNetCore.Mvc;

namespace Asp.NetPractice10.ViewComponents
{
    public class UsersListViewComponent : ViewComponent
    {
        List<string> users;
        public UsersListViewComponent()
        {
            users = new List<string>
        {
            "Tom", "Tim", "Bob", "Sam"
        };
        }
        public IViewComponentResult Invoke()
        {
            return View(users);
        }
    }
}
