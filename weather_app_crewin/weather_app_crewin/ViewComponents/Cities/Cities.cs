using Microsoft.AspNetCore.Mvc;
using System.Linq;
using weather_app_crewin.Models;

namespace weather_app_crewin.ViewComponents.Cities
{
    public class Cities:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            Context c = new Context();
            var citiess = c.weather_infos.ToList();
            return View(citiess);

        }
    }
}
