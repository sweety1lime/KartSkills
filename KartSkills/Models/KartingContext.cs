using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace KartSkills.Models
{
    public partial class KartingContext : DbContext
    {
        public KartingContext()
        {
        }

        public KartingContext(DbContextOptions<KartingContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Charity> Charities { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<Event> Events { get; set; }
        public virtual DbSet<EventType> EventTypes { get; set; }
        public virtual DbSet<Gender> Genders { get; set; }
        public virtual DbSet<Position> Positions { get; set; }
        public virtual DbSet<Race> Races { get; set; }
        public virtual DbSet<Racer> Racers { get; set; }
        public virtual DbSet<Registration> Registrations { get; set; }
        public virtual DbSet<RegistrationStatus> RegistrationStatuses { get; set; }
        public virtual DbSet<Result> Results { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<Sponsorship> Sponsorships { get; set; }
        public virtual DbSet<Timesheet> Timesheets { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Volunteer> Volunteers { get; set; }
        public virtual DbSet<staff> staff { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=LAPTOP-TAESVC8F\\ZXCLOWN;Initial Catalog=Karting;Persist Security Info=True;User ID=sa;Password=123456789");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Charity>(entity =>
            {
                entity.HasKey(e => e.IdСharity);

                entity.ToTable("Charity");

                entity.Property(e => e.IdСharity).HasColumnName("ID_Сharity");

                entity.Property(e => e.CharityDescription)
                    .HasMaxLength(3000)
                    .HasColumnName("Charity_Description");

                entity.Property(e => e.CharityLogo)
                    .HasMaxLength(50)
                    .HasColumnName("Charity_Logo");

                entity.Property(e => e.CharityName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("Charity_Name");
            });

            modelBuilder.Entity<Country>(entity =>
            {
                entity.HasKey(e => e.IdCountry)
                    .HasName("PK_contry");

                entity.ToTable("Country");

                entity.Property(e => e.IdCountry)
                    .HasMaxLength(3)
                    .HasColumnName("ID_Country")
                    .IsFixedLength(true);

                entity.Property(e => e.CountryFlag)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Country_Flag");

                entity.Property(e => e.CountryName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Country_Name");
            });

            modelBuilder.Entity<Event>(entity =>
            {
                entity.HasKey(e => e.IdEvent);

                entity.ToTable("Event");

                entity.Property(e => e.IdEvent).HasColumnName("ID_Event");

                entity.Property(e => e.Cost).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.EventName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Event_Name");

                entity.Property(e => e.IdEventType)
                    .IsRequired()
                    .HasMaxLength(5)
                    .HasColumnName("ID_EventType")
                    .IsFixedLength(true);

                entity.Property(e => e.IdRace).HasColumnName("ID_Race");

                entity.Property(e => e.StartDateTime).HasColumnType("datetime");

                entity.HasOne(d => d.IdEventTypeNavigation)
                    .WithMany(p => p.Events)
                    .HasForeignKey(d => d.IdEventType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Event_Event_Type1");

                entity.HasOne(d => d.IdRaceNavigation)
                    .WithMany(p => p.Events)
                    .HasForeignKey(d => d.IdRace)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Event_Race");
            });

            modelBuilder.Entity<EventType>(entity =>
            {
                entity.HasKey(e => e.IdEventType)
                    .HasName("PK_Event_Type_1");

                entity.ToTable("Event_Type");

                entity.Property(e => e.IdEventType)
                    .HasMaxLength(5)
                    .HasColumnName("ID_Event_type")
                    .IsFixedLength(true);

                entity.Property(e => e.EventTypeName)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("Event_Type_Name");
            });

            modelBuilder.Entity<Gender>(entity =>
            {
                entity.HasKey(e => e.IdGender);

                entity.ToTable("Gender");

                entity.Property(e => e.IdGender)
                    .HasMaxLength(1)
                    .HasColumnName("ID_Gender")
                    .IsFixedLength(true);

                entity.Property(e => e.GenderName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Gender_Name");
            });

            modelBuilder.Entity<Position>(entity =>
            {
                entity.ToTable("Position");

                entity.Property(e => e.PayPeriod)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PayRate).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.PositionDescription)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('-')");

                entity.Property(e => e.PositionName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Race>(entity =>
            {
                entity.HasKey(e => e.IdRace);

                entity.ToTable("Race");

                entity.Property(e => e.IdRace).HasColumnName("ID_Race");

                entity.Property(e => e.IdCountry)
                    .IsRequired()
                    .HasMaxLength(3)
                    .HasColumnName("ID_Country")
                    .IsFixedLength(true);

                entity.Property(e => e.RaceName)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("Race_Name");

                entity.Property(e => e.Sity)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.YearHeld).HasColumnName("Year_Held");

                entity.HasOne(d => d.IdCountryNavigation)
                    .WithMany(p => p.Races)
                    .HasForeignKey(d => d.IdCountry)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Race_Country");
            });

            modelBuilder.Entity<Racer>(entity =>
            {
                entity.HasKey(e => e.IdRacer);

                entity.ToTable("Racer");

                entity.Property(e => e.IdRacer).HasColumnName("ID_Racer");

                entity.Property(e => e.DateOfBirth).HasColumnType("date");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("First_Name");

                entity.Property(e => e.Gender)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsFixedLength(true);

                entity.Property(e => e.IdCountry)
                    .IsRequired()
                    .HasMaxLength(3)
                    .HasColumnName("ID_Country")
                    .IsFixedLength(true);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Last_Name");

                entity.HasOne(d => d.GenderNavigation)
                    .WithMany(p => p.Racers)
                    .HasForeignKey(d => d.Gender)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Racer_Gender");

                entity.HasOne(d => d.IdCountryNavigation)
                    .WithMany(p => p.Racers)
                    .HasForeignKey(d => d.IdCountry)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Racer_Country");
            });

            modelBuilder.Entity<Registration>(entity =>
            {
                entity.HasKey(e => e.IdRegistration);

                entity.ToTable("Registration");

                entity.Property(e => e.IdRegistration).HasColumnName("ID_Registration");

                entity.Property(e => e.Cost).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.IdCharity).HasColumnName("ID_Charity");

                entity.Property(e => e.IdRacer).HasColumnName("ID_Racer");

                entity.Property(e => e.IdRegistrationStatus).HasColumnName("ID_Registration_Status");

                entity.Property(e => e.RegistrationDate)
                    .HasColumnType("date")
                    .HasColumnName("Registration_Date");

                entity.Property(e => e.SponsorshipTarget).HasColumnType("decimal(10, 2)");

                entity.HasOne(d => d.IdCharityNavigation)
                    .WithMany(p => p.Registrations)
                    .HasForeignKey(d => d.IdCharity)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Registration_Charity");

                entity.HasOne(d => d.IdRacerNavigation)
                    .WithMany(p => p.Registrations)
                    .HasForeignKey(d => d.IdRacer)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Registration_Racer");
            });

            modelBuilder.Entity<RegistrationStatus>(entity =>
            {
                entity.HasKey(e => e.IdRegistrationStatus);

                entity.ToTable("Registration_Status");

                entity.Property(e => e.IdRegistrationStatus).HasColumnName("ID_Registration_Status");

                entity.Property(e => e.StatuName)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("Statu_Name");
            });

            modelBuilder.Entity<Result>(entity =>
            {
                entity.HasKey(e => e.IdResult)
                    .HasName("PK_RegistrationEvent");

                entity.ToTable("Result");

                entity.Property(e => e.IdResult).HasColumnName("ID_Result");

                entity.Property(e => e.IdEvent).HasColumnName("ID_Event");

                entity.Property(e => e.IdRegistration).HasColumnName("ID_Registration");

                entity.HasOne(d => d.IdEventNavigation)
                    .WithMany(p => p.Results)
                    .HasForeignKey(d => d.IdEvent)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Registration_Event_Event");

                entity.HasOne(d => d.IdRegistrationNavigation)
                    .WithMany(p => p.Results)
                    .HasForeignKey(d => d.IdRegistration)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Registration_Event_Registration");
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.HasKey(e => e.IdRole);

                entity.ToTable("Role");

                entity.Property(e => e.IdRole)
                    .HasMaxLength(1)
                    .HasColumnName("ID_Role")
                    .IsFixedLength(true);

                entity.Property(e => e.RoleName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Role_Name");
            });

            modelBuilder.Entity<Sponsorship>(entity =>
            {
                entity.HasKey(e => e.IdSponsorship);

                entity.ToTable("Sponsorship");

                entity.Property(e => e.IdSponsorship).HasColumnName("ID_Sponsorship");

                entity.Property(e => e.Amount).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.SponsorName)
                    .IsRequired()
                    .HasMaxLength(150);
            });

            modelBuilder.Entity<Timesheet>(entity =>
            {
                entity.ToTable("Timesheet");

                entity.Property(e => e.EndDateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('-')");

                entity.Property(e => e.PayAmount)
                    .HasColumnType("decimal(10, 2)")
                    .HasDefaultValueSql("('-')");

                entity.Property(e => e.StartDateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('-')");

                entity.HasOne(d => d.Staff)
                    .WithMany(p => p.Timesheets)
                    .HasForeignKey(d => d.Staffid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Staff_Timesheet");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("User");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.FirstName)
                    .HasMaxLength(30)
                    .HasColumnName("First_Name");

                entity.Property(e => e.IdRole)
                    .HasMaxLength(1)
                    .HasColumnName("ID_Role")
                    .IsFixedLength(true);

                entity.Property(e => e.LastName)
                    .HasMaxLength(30)
                    .HasColumnName("Last_Name");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.IdRoleNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdRole)
                    .HasConstraintName("FK_User_Role");
            });

            modelBuilder.Entity<Volunteer>(entity =>
            {
                entity.HasKey(e => e.IdVolunteer);

                entity.ToTable("Volunteer");

                entity.Property(e => e.IdVolunteer)
                    .HasMaxLength(3)
                    .HasColumnName("ID_Volunteer")
                    .IsFixedLength(true);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(80)
                    .HasColumnName("First_Name");

                entity.Property(e => e.GenderId)
                    .HasMaxLength(1)
                    .HasColumnName("Gender_ID")
                    .IsFixedLength(true);

                entity.Property(e => e.IdCountry)
                    .IsRequired()
                    .HasMaxLength(3)
                    .HasColumnName("ID_Country")
                    .IsFixedLength(true);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(80)
                    .HasColumnName("Last_Name");

                entity.HasOne(d => d.Gender)
                    .WithMany(p => p.Volunteers)
                    .HasForeignKey(d => d.GenderId)
                    .HasConstraintName("FK_Volunteer_Gender");

                entity.HasOne(d => d.IdCountryNavigation)
                    .WithMany(p => p.Volunteers)
                    .HasForeignKey(d => d.IdCountry)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Volunteer_Country");
            });

            modelBuilder.Entity<staff>(entity =>
            {
                entity.ToTable("Staff");

                entity.Property(e => e.Comments)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DateOfBirth).HasColumnType("datetime");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.Gender)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.HasOne(d => d.Position)
                    .WithMany(p => p.staff)
                    .HasForeignKey(d => d.Positionid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Position_Staff");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
