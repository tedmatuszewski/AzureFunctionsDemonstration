using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Linq;
using System.Threading.Tasks;
using Test.Domain.Services;

namespace Test.MVC.Controllers
{
    public class BaseController : Controller
    {
        protected ITestService _service;

        public BaseController(ITestService service)
        {
            this._service = service;
        }

        protected IActionResult RedirectToError(string message, bool layout = true)
        {
            return RedirectToAction("Index", "Error", new { message = message, area = "", layout = layout });
        }

        public override void OnActionExecuting(ActionExecutingContext context)
        {
            base.OnActionExecuting(context);
        }
    }
}