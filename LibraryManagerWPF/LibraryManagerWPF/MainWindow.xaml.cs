using Microsoft.EntityFrameworkCore;

using System.ComponentModel;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;

namespace LibraryManagerWPF
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		private readonly LibraryContext _context =
			new();

		private readonly CollectionViewSource authorViewSource;

		public MainWindow()
		{
			InitializeComponent();
			authorViewSource =
				(CollectionViewSource)FindResource(nameof(authorViewSource));
		}

		private async void Window_Loaded(object sender, RoutedEventArgs e)
		{
			// this is for demo purposes only, to make it easier
			// to get up and running
			_context.Database.EnsureCreated();
			if (!(await _context.Authors.AnyAsync()))
			{
				var authors = new Author[] {
				new Author { Name = "Stephen", LastName = "King" },
				new Author { Name = "Isaac", LastName = "Asimov" }
				};
				var books = new Book[] {
					new Book { Author = authors[0], Title = "Los ojos del dragón", Sinopsis = "Es el libro \"Los ojos del dragón\"." },
					new Book { Author = authors[0], Title = "La torre oscura I", Sinopsis = "Es el libro \"La torre oscura I\"." },
					new Book { Author = authors[0], Title = "La torre oscura II", Sinopsis = "Es el libro \"La torre oscura II\"." },
					new Book { Author = authors[0], Title = "La torre oscura III", Sinopsis = "Es el libro \"La torre oscura III\"." },
					new Book { Author = authors[0], Title = "La torre oscura IV", Sinopsis = "Es el libro \"La torre oscura IV\"." },
					new Book { Author = authors[0], Title = "La torre oscura V", Sinopsis = "Es el libro \"La torre oscura V\"." },
					new Book { Author = authors[0], Title = "La torre oscura VI", Sinopsis = "Es el libro \"La torre oscura VI\"." },
					new Book { Title = "Un guijarro en el cielo", Author = authors[1], Sinopsis = "La sinopsis de \"Un guijarro en el cielo\"." },
					new Book { Title = "El sol desnudo", Author = authors[1], Sinopsis = "Esta es la sinopsis de \"El sol desnudo\"." },
					new Book { Title = "Los límites de la Fundación", Author = authors[1], Sinopsis = "La sinopsis de \"Los límites de la Fundación\"." }
				};
				_context.Authors.AddRange(authors);
				_context.Books.AddRange(books);
				await _context.SaveChangesAsync();
			}

			// load the entities into EF Core
			await _context.Authors.LoadAsync();

			// bind to the source
			authorViewSource.Source =
				_context.Authors.Local.ToObservableCollection();
		}

		private void Button_Click(object sender, RoutedEventArgs e)
		{
			// all changes are automatically tracked, including
			// deletes!
			_context.SaveChanges();

			// this forces the grid to refresh to latest values
			authorDataGrid.Items.Refresh();
			booksDataGrid.Items.Refresh();
		}

		protected override void OnClosing(CancelEventArgs e)
		{
			// clean up database connections
			_context.Dispose();
			base.OnClosing(e);
		}
	}
}
