using System;
using Microsoft.AspNetCore.Mvc;

namespace CrmUpSchool.UILayer.ViewComponents.Dashboard
{
    public class _FeautureDashboardPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
