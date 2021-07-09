using AutoMapper;

using LibraryManagerWeb.DataAccess;
using LibraryManagerWeb.Extensions;
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
			var stephen = await _context.Authors.FirstAsync(a => a.Name == "Stephen" && a.LastName == "King");
			_context.Authors.Remove(stephen);
			await _context.SaveChangesAsync();

			var guijarro = await _context.Books.SingleAsync(b => b.Title == "Un guijarro en el cielo");
			guijarro.BookImage = null;
			await _context.SaveChangesAsync();

				return View();
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
