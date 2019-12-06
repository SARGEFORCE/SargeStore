using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SargeStoreDomain.Entities.Identity;

namespace SargeStore.Areas.Admin.Controllers
{
    [Area("Admin"), Authorize(Roles = Role.Administrator)]
    public class HomeController : Controller
    {
        public IActionResult Index() => View();
    }
}