using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace lab_2.Models.Toons
{
    public partial class ToonsContext : DbContext
    {
        public ToonsContext()
        {
        }

        public ToonsContext(DbContextOptions<ToonsContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Actors> Actors { get; set; }
        public virtual DbSet<Athletes> Athletes { get; set; }
        public virtual DbSet<Cities> Cities { get; set; }
        public virtual DbSet<Competitions> Competitions { get; set; }
        public virtual DbSet<Continents> Continents { get; set; }
        public virtual DbSet<Countries> Countries { get; set; }
        public virtual DbSet<Courses> Courses { get; set; }
        public virtual DbSet<FoodCategories> FoodCategories { get; set; }
        public virtual DbSet<Foods> Foods { get; set; }
        public virtual DbSet<Hospitals> Hospitals { get; set; }
        public virtual DbSet<Instructors> Instructors { get; set; }
        public virtual DbSet<Medicines> Medicines { get; set; }
        public virtual DbSet<MenuItems> MenuItems { get; set; }
        public virtual DbSet<Movies> Movies { get; set; }
        public virtual DbSet<Organisms> Organisms { get; set; }
        public virtual DbSet<Patients> Patients { get; set; }
        public virtual DbSet<People> People { get; set; }
        public virtual DbSet<Players> Players { get; set; }
        public virtual DbSet<Provinces> Provinces { get; set; }
        public virtual DbSet<Restaurants> Restaurants { get; set; }
        public virtual DbSet<Sicknesses> Sicknesses { get; set; }
        public virtual DbSet<Species> Species { get; set; }
        public virtual DbSet<Students> Students { get; set; }
        public virtual DbSet<Teams> Teams { get; set; }
        public virtual DbSet<VehicleManufacturers> VehicleManufacturers { get; set; }
        public virtual DbSet<Vehicles> Vehicles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Actors>(entity =>
            {
                entity.HasKey(e => e.ActorId);

                entity.HasIndex(e => e.MovieId);

                entity.Property(e => e.FirstName).IsRequired();

                entity.Property(e => e.LastName).IsRequired();

                entity.HasOne(d => d.Movie)
                    .WithMany(p => p.Actors)
                    .HasForeignKey(d => d.MovieId);
            });

            modelBuilder.Entity<Athletes>(entity =>
            {
                entity.HasKey(e => e.AthleteId);

                entity.HasIndex(e => e.CompetitionId);

                entity.Property(e => e.Country).IsRequired();

                entity.Property(e => e.FirstName).IsRequired();

                entity.Property(e => e.LastName).IsRequired();

                entity.HasOne(d => d.Competition)
                    .WithMany(p => p.Athletes)
                    .HasForeignKey(d => d.CompetitionId);
            });

            modelBuilder.Entity<Cities>(entity =>
            {
                entity.HasKey(e => e.CityName);

                entity.HasIndex(e => e.ProvinceId);

                entity.HasOne(d => d.Province)
                    .WithMany(p => p.Cities)
                    .HasForeignKey(d => d.ProvinceId);
            });

            modelBuilder.Entity<Competitions>(entity =>
            {
                entity.HasKey(e => e.CompetitionId);

                entity.Property(e => e.EventName).IsRequired();
            });

            modelBuilder.Entity<Continents>(entity =>
            {
                entity.HasKey(e => e.ContinentName);
            });

            modelBuilder.Entity<Countries>(entity =>
            {
                entity.HasKey(e => e.CountryName);

                entity.HasIndex(e => e.ContinentName);

                entity.Property(e => e.CapitalCity).IsRequired();

                entity.Property(e => e.ContinentName).IsRequired();

                entity.HasOne(d => d.ContinentNameNavigation)
                    .WithMany(p => p.Countries)
                    .HasForeignKey(d => d.ContinentName);
            });

            modelBuilder.Entity<Courses>(entity =>
            {
                entity.HasKey(e => e.CourseId);

                entity.HasIndex(e => e.InstructorId);

                entity.Property(e => e.Name).IsRequired();

                entity.HasOne(d => d.Instructor)
                    .WithMany(p => p.Courses)
                    .HasForeignKey(d => d.InstructorId);
            });

            modelBuilder.Entity<FoodCategories>(entity =>
            {
                entity.HasKey(e => e.FoodCategoryId);

                entity.Property(e => e.Description).IsRequired();

                entity.Property(e => e.Name).IsRequired();
            });

            modelBuilder.Entity<Foods>(entity =>
            {
                entity.HasKey(e => e.FoodId);

                entity.HasIndex(e => e.FoodCategoryId);

                entity.Property(e => e.Name).IsRequired();

                entity.Property(e => e.Unit).IsRequired();

                entity.HasOne(d => d.FoodCategory)
                    .WithMany(p => p.Foods)
                    .HasForeignKey(d => d.FoodCategoryId);
            });

            modelBuilder.Entity<Hospitals>(entity =>
            {
                entity.HasKey(e => e.HospitalId);

                entity.Property(e => e.City).IsRequired();

                entity.Property(e => e.Country).IsRequired();

                entity.Property(e => e.Name).IsRequired();

                entity.Property(e => e.PostalCode).IsRequired();

                entity.Property(e => e.Province).IsRequired();

                entity.Property(e => e.Street).IsRequired();
            });

            modelBuilder.Entity<Instructors>(entity =>
            {
                entity.HasKey(e => e.InstructorId);

                entity.Property(e => e.Email).IsRequired();

                entity.Property(e => e.FirstName).IsRequired();

                entity.Property(e => e.LastName).IsRequired();
            });

            modelBuilder.Entity<Medicines>(entity =>
            {
                entity.HasKey(e => e.MedicineId);

                entity.HasIndex(e => e.SicknessId);

                entity.Property(e => e.DosageUnit).IsRequired();

                entity.Property(e => e.Name).IsRequired();

                entity.HasOne(d => d.Sickness)
                    .WithMany(p => p.Medicines)
                    .HasForeignKey(d => d.SicknessId);
            });

            modelBuilder.Entity<MenuItems>(entity =>
            {
                entity.HasKey(e => e.MenuId);

                entity.HasIndex(e => e.RestaurantId);

                entity.Property(e => e.Name).IsRequired();

                entity.Property(e => e.Size).IsRequired();

                entity.HasOne(d => d.Restaurant)
                    .WithMany(p => p.MenuItems)
                    .HasForeignKey(d => d.RestaurantId);
            });

            modelBuilder.Entity<Movies>(entity =>
            {
                entity.HasKey(e => e.MovieId);

                entity.Property(e => e.DirectorFirstName).IsRequired();

                entity.Property(e => e.DirectorLastName).IsRequired();

                entity.Property(e => e.Name).IsRequired();

                entity.Property(e => e.Rating).IsRequired();
            });

            modelBuilder.Entity<Organisms>(entity =>
            {
                entity.HasKey(e => e.OrganismId);

                entity.HasIndex(e => e.SpecieName);

                entity.Property(e => e.Name).IsRequired();

                entity.Property(e => e.SpecieName).IsRequired();

                entity.HasOne(d => d.SpecieNameNavigation)
                    .WithMany(p => p.Organisms)
                    .HasForeignKey(d => d.SpecieName);
            });

            modelBuilder.Entity<Patients>(entity =>
            {
                entity.HasKey(e => e.PatientId);

                entity.HasIndex(e => e.HospitalId);

                entity.Property(e => e.City).IsRequired();

                entity.Property(e => e.Country).IsRequired();

                entity.Property(e => e.FirstName).IsRequired();

                entity.Property(e => e.Gender)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.LastName).IsRequired();

                entity.Property(e => e.PostalCode).IsRequired();

                entity.Property(e => e.Province).IsRequired();

                entity.Property(e => e.RoomNumber).IsRequired();

                entity.Property(e => e.Street).IsRequired();

                entity.HasOne(d => d.Hospital)
                    .WithMany(p => p.Patients)
                    .HasForeignKey(d => d.HospitalId);
            });

            modelBuilder.Entity<People>(entity =>
            {
                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.Gender)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.Occupation)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.PictureUrl)
                    .HasColumnName("PictureURL")
                    .HasMaxLength(500);
            });

            modelBuilder.Entity<Players>(entity =>
            {
                entity.HasKey(e => e.PlayerId);

                entity.HasIndex(e => e.TeamName);

                entity.Property(e => e.FirstName).IsRequired();

                entity.Property(e => e.LastName).IsRequired();

                entity.Property(e => e.Position).IsRequired();

                entity.Property(e => e.TeamName).HasMaxLength(30);

                entity.HasOne(d => d.TeamNameNavigation)
                    .WithMany(p => p.Players)
                    .HasForeignKey(d => d.TeamName);
            });

            modelBuilder.Entity<Provinces>(entity =>
            {
                entity.HasKey(e => e.ProvinceId);

                entity.HasIndex(e => e.CountryName);

                entity.Property(e => e.CapitalCity).IsRequired();

                entity.Property(e => e.CountryName).IsRequired();

                entity.Property(e => e.Name).IsRequired();

                entity.HasOne(d => d.CountryNameNavigation)
                    .WithMany(p => p.Provinces)
                    .HasForeignKey(d => d.CountryName);
            });

            modelBuilder.Entity<Restaurants>(entity =>
            {
                entity.HasKey(e => e.RestaurantId);

                entity.Property(e => e.City).IsRequired();

                entity.Property(e => e.Country).IsRequired();

                entity.Property(e => e.FoodType).IsRequired();

                entity.Property(e => e.PostalCode).IsRequired();

                entity.Property(e => e.Province).IsRequired();

                entity.Property(e => e.RestaurantName).IsRequired();

                entity.Property(e => e.Street).IsRequired();
            });

            modelBuilder.Entity<Sicknesses>(entity =>
            {
                entity.HasKey(e => e.SicknessId);

                entity.HasIndex(e => e.PatientId);

                entity.Property(e => e.SicknessName).IsRequired();

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.Sicknesses)
                    .HasForeignKey(d => d.PatientId);
            });

            modelBuilder.Entity<Species>(entity =>
            {
                entity.HasKey(e => e.SpecieName);
            });

            modelBuilder.Entity<Students>(entity =>
            {
                entity.HasKey(e => e.StudentId);

                entity.Property(e => e.StudentId).HasMaxLength(20);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.School)
                    .IsRequired()
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<Teams>(entity =>
            {
                entity.HasKey(e => e.TeamName);

                entity.Property(e => e.TeamName).HasMaxLength(30);
            });

            modelBuilder.Entity<VehicleManufacturers>(entity =>
            {
                entity.HasKey(e => e.VehicleManufacturerName);

                entity.Property(e => e.Country).IsRequired();
            });

            modelBuilder.Entity<Vehicles>(entity =>
            {
                entity.HasKey(e => e.Model);

                entity.HasIndex(e => e.VehicleManufacturerName);

                entity.Property(e => e.Fuel).IsRequired();

                entity.Property(e => e.Type).IsRequired();

                entity.Property(e => e.VehicleManufacturerName).IsRequired();

                entity.HasOne(d => d.VehicleManufacturerNameNavigation)
                    .WithMany(p => p.Vehicles)
                    .HasForeignKey(d => d.VehicleManufacturerName);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
