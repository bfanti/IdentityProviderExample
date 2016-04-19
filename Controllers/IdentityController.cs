using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

namespace IdentityProvider.Controllers
{
    public class IdentityController
    {
    	public IdentityController() {}

		[HttpGet("")]
    	public IActionResult GetIdentities()
    	{
    		return new JsonResult(new { Name = "Bernardo"});
    	}
    }
}
