using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace IdentityProvider.Controllers
{
    public class IdentityController : Controller
    {
    	public IdentityController() {}

    	// GET: /<controller>/
    	public IActionResult Index()
    	{
    		return new JsonResult(new {});
    	}
    }
}
