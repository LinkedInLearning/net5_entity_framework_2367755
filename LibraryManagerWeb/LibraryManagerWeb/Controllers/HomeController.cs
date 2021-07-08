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
			var authorWithRelated = new Author
			{
				Name = "Dan",
				LastName = "Simmons",
				AuthorUrl = "dan-simmons",
				Books = new List<Book>
				{
					new Book
					{
						Title = "Los cantos de Hyperion",
						BookFiles = new List<BookFile>
						{
							new BookFile
							{
								Format = new BookFormat
								{
									Name = "Daisy"
								},
								InternalFilePath = "los-cantos-de-hyperion.zip"
							}
						},
						BookImage = new BookImage
						{
							Caption = "Portada de Los cantos de Hyperion",
							Alt = "En la portada aparece un dibujo muy bonito.",

							ImageFilePath = "los-cantos-de-hyperion.jpg"
						},
						Publisher = new Publisher
						{
							Name = "The best Scifi"
						},
						Ratings = new List<BookRating>
						{
							new BookRating
							{
								Stars = 5,
								Username = "Juanjo"
							}
						},
						Sinopsis = "Es la sinopsis de Los cantos de Hyperion.",
						Tags = new List<Tag>
						{
							new Tag
							{
								Value = "cienci ficción" },
							new Tag
							{
								Value = "futurista"
							},
							new Tag
							{
								Value = "espacio"
							},
							new Tag
							{
								Value = "inteligencia artificial"
							}
						}
					}
				}
			};
			
			await _context.Authors.AddAsync(authorWithRelated);
			try
			{
				await _context.SaveChangesAsync();
			}
			catch (Exception ex)
			{
			}



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
