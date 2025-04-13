using System;
using Microsoft.EntityFrameworkCore;
using System.Configuration;
using System.Net.Sockets;

namespace DAL
{
    public class MainDbContext : DbContext
    {
        public DbSet<Customer> Customer { get; set; }
        public DbSet<TicketVendorMachine> TicketVendorMachine { get; set; }
        public DbSet<Route> Route { get; set; }
        public DbSet<PublicTransportation> PublicTransportation { get; set; }
        public DbSet<Destination> Destination { get; set; }
        public DbSet<Ticket> Ticket { get; set; }
        public DbSet<LogTicket> LogTicket { get; set; }
        public DbSet<PaymentMethod> PaymentMethod { get; set; }
        public DbSet<QRCode> QRCode { get; set; }
        public DbSet<CreditCard> CreditCard { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["GoPublicDBConnectionString"]?.ConnectionString;

            if (string.IsNullOrEmpty(connectionString))
            {
                throw new Exception("Connection string 'GoPublicDBConnectionString' is missing or empty. Check App.config!");
            }

            optionsBuilder.UseSqlServer(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Define primary keys
            modelBuilder.Entity<Customer>().HasKey(c => c.CustomerId);
            modelBuilder.Entity<TicketVendorMachine>().HasKey(m => m.MachineId);
            modelBuilder.Entity<Route>().HasKey(r => r.RouteId);
            modelBuilder.Entity<PublicTransportation>().HasKey(p => p.VehicleId);
            modelBuilder.Entity<Destination>().HasKey(d => d.DestinationId);
            modelBuilder.Entity<Ticket>().HasKey(t => t.TicketId);
            modelBuilder.Entity<LogTicket>().HasKey(l => l.LogTicketId);
            modelBuilder.Entity<PaymentMethod>().HasKey(p => p.PaymentId);
            modelBuilder.Entity<QRCode>().HasKey(q => q.QRCodeId);
            modelBuilder.Entity<CreditCard>().HasKey(c => c.CreditCardId);

            // Define relationships
            modelBuilder.Entity<Destination>()
                .HasOne<PublicTransportation>()
                .WithMany()
                .HasForeignKey(d => d.VehicleId);

            modelBuilder.Entity<Destination>()
                .HasOne<Route>()
                .WithMany()
                .HasForeignKey(d => d.RouteId);

            modelBuilder.Entity<Ticket>()
                .HasOne<Customer>()
                .WithMany()
                .HasForeignKey(t => t.CustomerId);

            modelBuilder.Entity<Ticket>()
                .HasOne<TicketVendorMachine>()
                .WithMany()
                .HasForeignKey(t => t.MachineId);

            modelBuilder.Entity<LogTicket>()
                .HasOne<TicketVendorMachine>()
                .WithMany()
                .HasForeignKey(l => l.MachineId);

            modelBuilder.Entity<LogTicket>()
                .HasOne<Customer>()
                .WithMany()
                .HasForeignKey(l => l.CustomerId);

            modelBuilder.Entity<LogTicket>()
                .HasOne<Ticket>()
                .WithMany()
                .HasForeignKey(l => l.TicketId);
        }
    }
}
