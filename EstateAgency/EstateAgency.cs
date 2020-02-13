namespace EstateAgency
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class EstateAgency : DbContext
    {
        public EstateAgency()
            : base("name=EstateAgency")
        {
        }

        public virtual DbSet<Clients> Clients { get; set; }
        public virtual DbSet<Districts> Districts { get; set; }
        public virtual DbSet<EstateObjects> EstateObjects { get; set; }
        public virtual DbSet<Managers> Managers { get; set; }
        public virtual DbSet<Owners> Owners { get; set; }
        public virtual DbSet<PaymentTypes> PaymentTypes { get; set; }
        public virtual DbSet<PaymnetInstruments> PaymnetInstruments { get; set; }
        public virtual DbSet<Pictures> Pictures { get; set; }
        public virtual DbSet<RealtyTypes> RealtyTypes { get; set; }
        public virtual DbSet<Statuses> Statuses { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Trades> Trades { get; set; }
        public virtual DbSet<TradeTypes> TradeTypes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Clients>()
                .Property(e => e.Phone)
                .IsUnicode(false);

            modelBuilder.Entity<Clients>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Clients>()
                .HasMany(e => e.Trades)
                .WithRequired(e => e.Clients)
                .HasForeignKey(e => e.ClientId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Districts>()
                .HasMany(e => e.EstateObjects)
                .WithRequired(e => e.Districts)
                .HasForeignKey(e => e.DistrictId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EstateObjects>()
                .Property(e => e.Price)
                .HasPrecision(19, 4);

            modelBuilder.Entity<EstateObjects>()
                .HasMany(e => e.Trades)
                .WithRequired(e => e.EstateObjects)
                .HasForeignKey(e => e.ItemId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EstateObjects>()
                .HasMany(e => e.Pictures)
                .WithMany(e => e.EstateObjects)
                .Map(m => m.ToTable("PictureObjectLinks").MapLeftKey("IdObject").MapRightKey("IdPicture"));

            modelBuilder.Entity<Managers>()
                .Property(e => e.Phone)
                .IsUnicode(false);

            modelBuilder.Entity<Managers>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Managers>()
                .Property(e => e.Password)
                .IsFixedLength();

            modelBuilder.Entity<Managers>()
                .HasMany(e => e.Trades)
                .WithRequired(e => e.Managers)
                .HasForeignKey(e => e.ManagerId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Owners>()
                .Property(e => e.Pnone)
                .IsUnicode(false);

            modelBuilder.Entity<Owners>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Owners>()
                .HasMany(e => e.EstateObjects)
                .WithRequired(e => e.Owners)
                .HasForeignKey(e => e.OwnerId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PaymentTypes>()
                .HasMany(e => e.Trades)
                .WithRequired(e => e.PaymentTypes)
                .HasForeignKey(e => e.PaymentTypeId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PaymnetInstruments>()
                .HasMany(e => e.Trades)
                .WithRequired(e => e.PaymnetInstruments)
                .HasForeignKey(e => e.PaymentInstrumentId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RealtyTypes>()
                .HasMany(e => e.EstateObjects)
                .WithRequired(e => e.RealtyTypes)
                .HasForeignKey(e => e.RealtyTypeId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Statuses>()
                .HasMany(e => e.EstateObjects)
                .WithRequired(e => e.Statuses)
                .HasForeignKey(e => e.StatusId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TradeTypes>()
                .HasMany(e => e.EstateObjects)
                .WithRequired(e => e.TradeTypes)
                .HasForeignKey(e => e.TradeTypeId)
                .WillCascadeOnDelete(false);
        }
    }
}
