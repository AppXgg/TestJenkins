using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Formatters;
using System.Net.Mime;

namespace TestJenkins.Controllers
{
	[ApiController]
	[Route("api/[controller]")]
	public class HomeController : Controller
	{
		[HttpGet]
		public IActionResult Index()
		{
			string  str="22222222";
			return   Content(str);    
		}
	}
}
