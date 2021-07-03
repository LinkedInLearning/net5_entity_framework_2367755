using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagerWeb.DataAccess
{
	[Table("AuditEntries")]
	[Comment("Tabla con las entradas de auditoría de la biblioteca.")]
	public class AuditEntry
	{

		public int AuditEntryId { get; set; }

		public DateTime Date { get; set; }

		public string OPeration { get; set; }

		public string ExtendedDescription { get; set; }
		
		public string UserName { get; set; }

		public string IpAddress { get; set; }

		public int CountryId { get; set; }

		public Country Country { get; set; }

		public string City { get; set; }

		public double Latitude { get; set; }

		public double Longitude { get; set; }

		public string ISP { get; set; }

		public string UserAgent { get; set; }

		public string OperatingSystem { get; set; }
	}
}
