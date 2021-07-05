﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagerWeb.DataAccess
{
	public class AuditEntry
	{

		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int AuditEntryId { get; set; }

		public DateTime Date { get; set; }

		[Required]
		public string OPeration { get; set; }

		public decimal TimeSpent { get; set; }

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

		public Book Book { get; set; }
	}
}
