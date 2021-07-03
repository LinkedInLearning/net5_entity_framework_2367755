using AutoMapper;

using LibraryManagerWeb.DataAccess;
using LibraryManagerWeb.Models;

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagerWeb.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;

		private readonly LibraryContext _context;

		private readonly IMapper _mapper;

		public HomeController(ILogger<HomeController> logger, LibraryContext context, IMapper mapper)
		{
			_context = context;
			_logger = logger;
			_mapper = mapper;
		}

		public async Task<IActionResult> Index()
		{
			var phisicalLibraries = await _context.PhisicalLibraries.OrderBy(l => l.Name).ToListAsync();
			return View(phisicalLibraries.Select(lib => _mapper.Map<PhisicalLibraryViewModel>(lib)).ToList());
		}

		public IActionResult Privacy()
		{
			return View();
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}
