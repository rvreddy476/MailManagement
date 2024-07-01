using Mail.Repository.Entities;
using Microsoft.EntityFrameworkCore;

namespace Mail.Repository.DBContext
{
    public class EmailDbContext : DbContext
    {
        public EmailDbContext(DbContextOptions<EmailDbContext> options)
      : base(options)
        { }
        public DbSet<EmailTemplate> EmailTemplates { get; set; }
        public DbSet<OutboundEmail> OutboundEmails { get; set; }
        public DbSet<IncomingEmail> IncomingEmails { get; set; }
        public DbSet<EmailFailure> EmailFailures { get; set; }
        public DbSet<EmailTrail> EmailTrails { get; set; }

      
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EmailTemplate>()
                .HasKey(t => t.TemplateID);

            modelBuilder.Entity<OutboundEmail>()
                .HasKey(e => e.ID);
                   
            modelBuilder.Entity<OutboundEmail>()
                .HasOne(e => e.Template)
                .WithMany()
                .HasForeignKey(e => e.TemplateID);

            modelBuilder.Entity<IncomingEmail>()
                .HasKey(e => e.ID);
            modelBuilder.Entity<IncomingEmail>()
                .HasOne(e => e.OutboundEmail)
                .WithMany()
                .HasForeignKey(e => e.OutboundEmailID);
            modelBuilder.Entity<IncomingEmail>()
                .HasOne(e => e.OutboundEmail)
                .WithMany()
                .HasForeignKey(e => e.OutboundEmailID);

            modelBuilder.Entity<EmailFailure>()
                .HasKey(e => e.ID);
            modelBuilder.Entity<EmailFailure>()
                .HasOne(e => e.OutboundEmail)
                .WithMany()
                .HasForeignKey(e => e.OutboundEmailID);

            modelBuilder.Entity<EmailTrail>()
                .HasKey(e => e.EmailTrailID);
            modelBuilder.Entity<EmailTrail>()
                .HasOne<OutboundEmail>()
                .WithMany()
                .HasForeignKey(e => e.OutboundEmailID);
        }
    }

}

