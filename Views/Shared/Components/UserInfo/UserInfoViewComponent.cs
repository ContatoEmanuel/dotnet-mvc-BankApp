using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;

namespace BankApp.Views.Shared.Components.UserInfo
{
    public class UserInfoViewComponent : ViewComponent
    {
        private readonly UserManager<IdentityUser> _userManager;

        public UserInfoViewComponent(UserManager<IdentityUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var user = await _userManager.GetUserAsync(UserClaimsPrincipal);
            return View(user);
        }
    }
}
