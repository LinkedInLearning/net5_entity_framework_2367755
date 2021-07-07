using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagerWeb.DataAccess.EntityConfig
{
	public class AuditEntryConfig : IEntityTypeConfiguration<AuditEntry>
	{
		public void Configure(EntityTypeBuilder<AuditEntry> auditEntryBuilder)
		{
			auditEntryBuilder.Property(p => p.TimeSpent)
				.HasPrecision(20);
			auditEntryBuilder.Property(p => p.IpAddress).IsRequired();
			auditEntryBuilder.Property<string>("ResearchTicketId")
				.HasMaxLength(20);
			auditEntryBuilder.HasIndex("ResearchTicketId")
				.IsUnique(true)
				.HasName("UX_AuditEntry_ResearchTicketId");
		}
	}
}
