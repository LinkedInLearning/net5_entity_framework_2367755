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
			var firstBook = await _context.Books.FirstOrDefaultAsync();
			var newAuditEntry = new AuditEntry
			{
				Book = firstBook,
				Date = DateTime.UtcNow,
				CountryId = 1,
				ExtendedDescription = "Prueba de entrada de auditoría",
				OPeration = "Reseñar un libro",
				IpAddress = "83.22.121.44",
				UserName = "JuanjoMontiel"
			};
			await _context.AuditEntries.AddAsync(newAuditEntry);
			_context.Entry(newAuditEntry).Property("ResearchTicketId").CurrentValue = "abcdefghijklmnopqrst";
			await _context.SaveChangesAsync();
			var entry = await _context.AuditEntries.SingleOrDefaultAsync(e => EF.Property<string>(e, "ResearchTicketId") == "abcdefghijklmnopqrst");

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
