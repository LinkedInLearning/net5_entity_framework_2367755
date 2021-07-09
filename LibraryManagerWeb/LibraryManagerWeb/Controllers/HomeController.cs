﻿using AutoMapper;

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
			var newAuthor = new Author { Name = "Dan", LastName = "Simmons", AuthorUrl = "dan-simmons" };
			await _context.Authors.AddAsync(newAuthor);
			await _context.SaveChangesAsync();

			var book = await _context.Books.FirstOrDefaultAsync(b => b.Title == "Los ojos del dragón");
			book.Sinopsis = "Cambio de la sinopsis.";
			await _context.SaveChangesAsync();

			var otherBook = _context.Books.FirstOrDefault(b => b.Title.Contains("oscura"));
			_context.Books.Remove(otherBook);
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
