﻿// <auto-generated />
using System;
using LibraryManagerWeb.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LibraryManagerWeb.Migrations
{
    [DbContext(typeof(LibraryContext))]
    [Migration("20210707183120_AddedManyToManyRelationship")]
    partial class AddedManyToManyRelationship
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.7")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BookTag", b =>
                {
                    b.Property<int>("BooksBookId")
                        .HasColumnType("int");

                    b.Property<int>("TagsTagId")
                        .HasColumnType("int");

                    b.HasKey("BooksBookId", "TagsTagId");

                    b.HasIndex("TagsTagId");

                    b.ToTable("BookTag");
                });

            modelBuilder.Entity("LibraryManagerWeb.DataAccess.AuditEntry", b =>
                {
                    b.Property<int>("AuditEntryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("BookId")
                        .HasColumnType("int");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CountryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("ExtendedDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ISP")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IpAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Latitude")
                        .HasColumnType("float");

                    b.Property<double>("Longitude")
                        .HasColumnType("float");

                    b.Property<string>("OPeration")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OperatingSystem")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ResearchTicketId")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<decimal>("TimeSpent")
                        .HasPrecision(20)
                        .HasColumnType("decimal(20,2)");

                    b.Property<string>("UserAgent")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AuditEntryId");

                    b.HasIndex("BookId");

                    b.HasIndex("CountryId");

                    b.HasIndex("ResearchTicketId")
                        .IsUnique()
                        .HasDatabaseName("UX_AuditEntry_ResearchTicketId")
                        .HasFilter("[ResearchTicketId] IS NOT NULL");

                    b.ToTable("AuditEntries");
                });

            modelBuilder.Entity("LibraryManagerWeb.DataAccess.Author", b =>
                {
                    b.Property<int>("AuthorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AuthorUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("DisplayName")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("nvarchar(max)")
                        .HasComputedColumnSql("Name + ' ' + LastName", true);

                    b.Property<string>("LastName")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Name")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("AuthorId");

                    b.HasIndex("Name", "LastName");

                    b.ToTable("Authors");

                    b
                        .HasComment("Tabla para almacenar los autores que tienen libros en la biblioteca.");

                    b.HasData(
                        new
                        {
                            AuthorId = 1,
                            AuthorUrl = "stephenking",
                            LastName = "King",
                            Name = "Stephen"
                        },
                        new
                        {
                            AuthorId = 2,
                            AuthorUrl = "asimov",
                            LastName = "Asimov",
                            Name = "Isaac"
                        });
                });

            modelBuilder.Entity("LibraryManagerWeb.DataAccess.Book", b =>
                {
                    b.Property<int>("BookId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AuthorUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("CreationDateUtc")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("getutcdate()");

                    b.Property<int>("PublisherId")
                        .HasColumnType("int");

                    b.Property<string>("Sinopsis")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)")
                        .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                    b.HasKey("BookId");

                    b.HasIndex("AuthorUrl");

                    b.HasIndex("PublisherId");

                    b.ToTable("Books");

                    b
                        .HasComment("Tabla para almacenar los libros existentes en esta biblioteca.");

                    b.HasData(
                        new
                        {
                            BookId = 1,
                            AuthorUrl = "stephenking",
                            CreationDateUtc = new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PublisherId = 1,
                            Sinopsis = "El libro \"Los ojos del dragón\".",
                            Title = "Los ojos del dragón"
                        },
                        new
                        {
                            BookId = 2,
                            AuthorUrl = "stephenking",
                            CreationDateUtc = new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PublisherId = 1,
                            Sinopsis = "Es el libro \"La torre oscura I\".",
                            Title = "La torre oscura I"
                        },
                        new
                        {
                            BookId = 3,
                            AuthorUrl = "asimov",
                            CreationDateUtc = new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PublisherId = 1,
                            Sinopsis = "Es el libro \"Yo, robot\".\".",
                            Title = "Yo, robot"
                        });
                });

            modelBuilder.Entity("LibraryManagerWeb.DataAccess.BookFile", b =>
                {
                    b.Property<int>("BookFileId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BookFormatId")
                        .HasColumnType("int");

                    b.Property<int>("BookId")
                        .HasColumnType("int");

                    b.Property<string>("InternalFilePath")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("FilePath");

                    b.HasKey("BookFileId");

                    b.HasIndex("BookFormatId");

                    b.HasIndex("BookId");

                    b.ToTable("BookFiles");
                });

            modelBuilder.Entity("LibraryManagerWeb.DataAccess.BookFormat", b =>
                {
                    b.Property<int>("BookformatId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BookformatId");

                    b.ToTable("BookFormats");
                });

            modelBuilder.Entity("LibraryManagerWeb.DataAccess.BookImage", b =>
                {
                    b.Property<int>("BookImageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Alt")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<int>("BookId")
                        .HasColumnType("int");

                    b.Property<string>("Caption")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("ImageFilePath")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BookImageId");

                    b.HasIndex("BookId")
                        .IsUnique();

                    b.ToTable("BookImages");

                    b.HasData(
                        new
                        {
                            BookImageId = 1,
                            Alt = "Una imagen del libro",
                            BookId = 1,
                            Caption = "text",
                            ImageFilePath = "img.jpg"
                        });
                });

            modelBuilder.Entity("LibraryManagerWeb.DataAccess.BookRating", b =>
                {
                    b.Property<int>("BookRatingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BookId")
                        .HasColumnType("int");

                    b.Property<int>("Stars")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(3);

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BookRatingId");

                    b.HasIndex("BookId");

                    b.ToTable("BookRatings");

                    b.HasData(
                        new
                        {
                            BookRatingId = 1,
                            BookId = 1,
                            Stars = 5,
                            Username = "juanjo"
                        },
                        new
                        {
                            BookRatingId = 2,
                            BookId = 1,
                            Stars = 3,
                            Username = "Lola"
                        },
                        new
                        {
                            BookRatingId = 3,
                            BookId = 1,
                            Stars = 4,
                            Username = "Silvia"
                        },
                        new
                        {
                            BookRatingId = 4,
                            BookId = 1,
                            Stars = 2,
                            Username = "Diego"
                        },
                        new
                        {
                            BookRatingId = 5,
                            BookId = 2,
                            Stars = 4,
                            Username = "juanjo"
                        },
                        new
                        {
                            BookRatingId = 6,
                            BookId = 2,
                            Stars = 2,
                            Username = "Lola"
                        },
                        new
                        {
                            BookRatingId = 7,
                            BookId = 2,
                            Stars = 5,
                            Username = "Silvia"
                        },
                        new
                        {
                            BookRatingId = 8,
                            BookId = 2,
                            Stars = 5,
                            Username = "Diego"
                        });
                });

            modelBuilder.Entity("LibraryManagerWeb.DataAccess.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Level")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("ParentCategoryId")
                        .HasColumnType("int");

                    b.HasKey("CategoryId");

                    b.HasIndex("ParentCategoryId");

                    b.ToTable("Category");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            Level = 1,
                            Name = "Disciplinas"
                        },
                        new
                        {
                            CategoryId = 2,
                            Level = 2,
                            Name = "Animales, hogar y plantas",
                            ParentCategoryId = 1
                        },
                        new
                        {
                            CategoryId = 3,
                            Level = 2,
                            Name = "Antropología",
                            ParentCategoryId = 1
                        },
                        new
                        {
                            CategoryId = 4,
                            Level = 2,
                            Name = "Arte",
                            ParentCategoryId = 1
                        },
                        new
                        {
                            CategoryId = 5,
                            Level = 2,
                            Name = "Ciencias naturales y biología",
                            ParentCategoryId = 1
                        },
                        new
                        {
                            CategoryId = 6,
                            Level = 1,
                            Name = "Ensayos"
                        },
                        new
                        {
                            CategoryId = 7,
                            Level = 2,
                            Name = "Autoayuda y desarrollo personal",
                            ParentCategoryId = 6
                        },
                        new
                        {
                            CategoryId = 8,
                            Level = 2,
                            Name = "Ciencias",
                            ParentCategoryId = 6
                        },
                        new
                        {
                            CategoryId = 9,
                            Level = 2,
                            Name = "Historia y ciencias sociales",
                            ParentCategoryId = 6
                        },
                        new
                        {
                            CategoryId = 10,
                            Level = 2,
                            Name = "Filosofía y religión",
                            ParentCategoryId = 6
                        },
                        new
                        {
                            CategoryId = 11,
                            Level = 1,
                            Name = "Literatura"
                        },
                        new
                        {
                            CategoryId = 12,
                            Level = 2,
                            Name = "Biografías, viajes y testimonios",
                            ParentCategoryId = 11
                        },
                        new
                        {
                            CategoryId = 13,
                            Level = 2,
                            Name = "Ciencia ficción y fantasía",
                            ParentCategoryId = 11
                        },
                        new
                        {
                            CategoryId = 14,
                            Level = 2,
                            Name = "Cuentos y relatos",
                            ParentCategoryId = 11
                        },
                        new
                        {
                            CategoryId = 15,
                            Level = 2,
                            Name = "Fábulas y leyendas",
                            ParentCategoryId = 11
                        });
                });

            modelBuilder.Entity("LibraryManagerWeb.DataAccess.Country", b =>
                {
                    b.Property<int>("CountryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasComment("Clave primaria de la tabla de países.")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("EnglishName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NativeName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CountryId");

                    b.ToTable("Countries");

                    b
                        .HasComment("Tabla para guardar los países");

                    b.HasData(
                        new
                        {
                            CountryId = 1,
                            EnglishName = "Spain",
                            NativeName = "España"
                        });
                });

            modelBuilder.Entity("LibraryManagerWeb.DataAccess.ProlificAuthor", b =>
                {
                    b.Property<int>("BookCount")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.ToTable("no-table", t => t.ExcludeFromMigrations());

                    b.ToFunction("MostProlificAuthors");
                });

            modelBuilder.Entity("LibraryManagerWeb.DataAccess.Publisher", b =>
                {
                    b.Property<int>("PublisherId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("PublisherName")
                        .HasComment("El nombre de la editorial");

                    b.HasKey("PublisherId");

                    b.ToTable("Publishers");

                    b
                        .HasComment("Editoriales");

                    b.HasData(
                        new
                        {
                            PublisherId = 1,
                            Name = "Entre letras"
                        });
                });

            modelBuilder.Entity("LibraryManagerWeb.DataAccess.RatedBook", b =>
                {
                    b.Property<int>("BookId")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Stars")
                        .HasColumnType("float");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.ToView("MostHighlyRatedBooks", "dbo");
                });

            modelBuilder.Entity("LibraryManagerWeb.DataAccess.Tag", b =>
                {
                    b.Property<int>("TagId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("TagId");

                    b.ToTable("Tags");
                });

            modelBuilder.Entity("BookTag", b =>
                {
                    b.HasOne("LibraryManagerWeb.DataAccess.Book", null)
                        .WithMany()
                        .HasForeignKey("BooksBookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LibraryManagerWeb.DataAccess.Tag", null)
                        .WithMany()
                        .HasForeignKey("TagsTagId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("LibraryManagerWeb.DataAccess.AuditEntry", b =>
                {
                    b.HasOne("LibraryManagerWeb.DataAccess.Book", "Book")
                        .WithMany()
                        .HasForeignKey("BookId");

                    b.HasOne("LibraryManagerWeb.DataAccess.Country", "Country")
                        .WithMany()
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Book");

                    b.Navigation("Country");
                });

            modelBuilder.Entity("LibraryManagerWeb.DataAccess.Book", b =>
                {
                    b.HasOne("LibraryManagerWeb.DataAccess.Author", "Author")
                        .WithMany()
                        .HasForeignKey("AuthorUrl")
                        .HasPrincipalKey("AuthorUrl")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LibraryManagerWeb.DataAccess.Publisher", "Publisher")
                        .WithMany("Books")
                        .HasForeignKey("PublisherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Author");

                    b.Navigation("Publisher");
                });

            modelBuilder.Entity("LibraryManagerWeb.DataAccess.BookFile", b =>
                {
                    b.HasOne("LibraryManagerWeb.DataAccess.BookFormat", "Format")
                        .WithMany()
                        .HasForeignKey("BookFormatId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LibraryManagerWeb.DataAccess.Book", "Book")
                        .WithMany("BookFiles")
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Book");

                    b.Navigation("Format");
                });

            modelBuilder.Entity("LibraryManagerWeb.DataAccess.BookImage", b =>
                {
                    b.HasOne("LibraryManagerWeb.DataAccess.Book", "Book")
                        .WithOne("BookImage")
                        .HasForeignKey("LibraryManagerWeb.DataAccess.BookImage", "BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Book");
                });

            modelBuilder.Entity("LibraryManagerWeb.DataAccess.BookRating", b =>
                {
                    b.HasOne("LibraryManagerWeb.DataAccess.Book", "Book")
                        .WithMany("Ratings")
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Book");
                });

            modelBuilder.Entity("LibraryManagerWeb.DataAccess.Category", b =>
                {
                    b.HasOne("LibraryManagerWeb.DataAccess.Category", "Parent")
                        .WithMany("Children")
                        .HasForeignKey("ParentCategoryId");

                    b.Navigation("Parent");
                });

            modelBuilder.Entity("LibraryManagerWeb.DataAccess.Book", b =>
                {
                    b.Navigation("BookFiles");

                    b.Navigation("BookImage");

                    b.Navigation("Ratings");
                });

            modelBuilder.Entity("LibraryManagerWeb.DataAccess.Category", b =>
                {
                    b.Navigation("Children");
                });

            modelBuilder.Entity("LibraryManagerWeb.DataAccess.Publisher", b =>
                {
                    b.Navigation("Books");
                });
#pragma warning restore 612, 618
        }
    }
}
