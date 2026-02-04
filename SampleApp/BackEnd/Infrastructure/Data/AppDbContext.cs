using Microsoft.EntityFrameworkCore;
using BackEnd.Domain.Job;
using BackEnd.Domain.Client;
using BackEnd.Domain.Client.Site;
using BackEnd.Domain.Engineer;
using BackEnd.Domain.Invoice;
using BackEnd.Domain.Wage;





namespace BackEnd.Infrastructure.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) 
            : base(options)
        {
           
        }
        public DbSet<Job> Jobs { get; set; }
        public DbSet<JobCertificates> JobCertificates { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Site> Sites { get; set; }
        public DbSet<Engineer> Engineers { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<Wage> Wages { get; set; }

        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Job>( entity =>
            {
                entity.HasKey(e => e.ID);
                entity.Property(e => e.Desc).IsRequired().HasMaxLength(500);
                entity.HasOne<Client>()
                      .WithMany()
                      .HasForeignKey(e => e.ClientID);

                entity.HasOne<Engineer>()
                      .WithMany()
                      .HasForeignKey(e => e.EngineerID);

                entity.HasMany<JobCertificates>()
                      .WithOne()
                      .HasForeignKey(jc => jc.ID);
                      
                entity.Property(e => e.Status).IsRequired();
                entity.Property(e => e.ScheduledDate).IsRequired();

                
            });
            modelBuilder.Entity<Client>( entity =>
            {
                entity.HasKey(e => e.ID);
                entity.Property(e => e.Name).IsRequired().HasMaxLength(100);
                entity.Property(e => e.Email).IsRequired().HasMaxLength(100);
                entity.Property(e => e.Number).IsRequired();
                entity.HasMany<Site>()
                      .WithOne()
                      .HasForeignKey(s => s.ClientID)
                      .OnDelete(DeleteBehavior.Cascade);
                entity.HasMany<Job>()
                      .WithOne()
                      .HasForeignKey(j => j.ClientID)
                      .OnDelete(DeleteBehavior.Cascade);
                entity.HasMany<Invoice>()
                      .WithOne()
                      .HasForeignKey(i => i.ClientID)
                      .OnDelete(DeleteBehavior.Cascade); 
                });

            modelBuilder.Entity<Site>(entity =>
            {
                entity.HasKey(e => e.ID);
                entity.Property(e => e.Address).IsRequired().HasMaxLength(200);
                entity.HasOne<Client>()
                      .WithMany()
                      .HasForeignKey(s => s.ClientID)
                      .OnDelete(DeleteBehavior.Cascade);

            });
                modelBuilder.Entity<Engineer>(entity =>
            {
                entity.HasKey(e => e.ID);
                entity.Property(e => e.Name).IsRequired().HasMaxLength(100);
                entity.Property(e => e.Email).IsRequired().HasMaxLength(100);
                entity.Property(e => e.Type).IsRequired();
                entity.Property(e => e.Number).IsRequired();
                entity.HasMany<Wage>()
                      .WithOne()
                      .HasForeignKey(w => w.EngineerID)
                      .OnDelete(DeleteBehavior.Cascade);
            });
                modelBuilder.Entity<Invoice>(entity =>
            {
                entity.HasKey(e => e.ID);
                entity.Property(e => e.Amount).IsRequired();
                entity.Property(e => e.DateCreated).IsRequired();
                entity.HasOne<Client>()
                      .WithMany()
                      .HasForeignKey(i => i.ClientID)
                      .OnDelete(DeleteBehavior.Cascade);
            });
                modelBuilder.Entity<Wage>(entity =>
            {
                entity.HasKey(e => e.ID);
                entity.Property(e => e.Amount).IsRequired();
                entity.Property(e => e.HourlyRate).IsRequired();
                entity.HasOne<Engineer>()
                      .WithMany()
                      .HasForeignKey(w => w.EngineerID)
                      .OnDelete(DeleteBehavior.Cascade);


            });

            }
    }
}
