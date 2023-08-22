using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketReservation.Domain.Entities;

namespace TicketReservation.Infrastructure.Database
{
    public class TicketReservationDbContext : DbContext
    {
        public TicketReservationDbContext(DbContextOptions<TicketReservationDbContext> options) : base(options)
        {

        }
        public DbSet<Domain.Entities.Actor> Actors { get; set; }
        public DbSet<Domain.Entities.ActorSpectacle> ActorSpectacles { get; set; }
        public DbSet<Domain.Entities.Order> Orders { get; set; }
        public DbSet<Domain.Entities.OrderItem> OrderItems { get; set; }
        public DbSet<Domain.Entities.Producer> Producers { get; set; }
        public DbSet<Domain.Entities.ShoppingCartItem> ShoppingCartItems { get; set; }
        public DbSet<Domain.Entities.Spectacle> Spectacles { get; set; }
        public DbSet<Domain.Entities.SpectacleCategory> SpectacleCategories { get; set; }
        public DbSet<Domain.Entities.Theater> Theaters { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ActorSpectacle>().HasKey(p => new
            {
                p.ActorId,
                p.SpectacleId
            });

            modelBuilder.Entity<ActorSpectacle>()
                .HasOne(p => p.Spectacle)
                .WithMany(p => p.ActorSpectacles)
                .HasForeignKey(p => p.SpectacleId);

            modelBuilder.Entity<ActorSpectacle>()
                .HasOne(p => p.Actor)
                .WithMany(p => p.ActorSpectacles)
                .HasForeignKey(p => p.ActorId);

            base.OnModelCreating(modelBuilder);
        }

    }
}
