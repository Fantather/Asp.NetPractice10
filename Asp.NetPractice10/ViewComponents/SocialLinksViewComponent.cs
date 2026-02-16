using Asp.NetPractice10.Models;
using Microsoft.AspNetCore.Mvc;

namespace Asp.NetPractice10.ViewComponents
{
    public class SocialLinksViewComponent : ViewComponent
    {
        List<SocialIcon> socialIcons = new List<SocialIcon>();
        public SocialLinksViewComponent()
        {
            socialIcons = SocialIcon.AppSocialIcons();
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var model = socialIcons;
            return await Task.FromResult((IViewComponentResult)View("SocialLinks", model));
        }
    }
}
