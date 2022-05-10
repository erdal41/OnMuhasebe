using Muhasebe.Data.MuhasebeMigration;
using Muhasebe.Model.Entities;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Muhasebe.Data.Contexts
{
    public class MuhasebeContext : BaseDbContext<MuhasebeContext, Configuration>
    {
        public MuhasebeContext()
        {
            Configuration.LazyLoadingEnabled = false;            
        }

        public MuhasebeContext(string connectionString) : base(connectionString)
        {
            Configuration.LazyLoadingEnabled = false;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.Entity<Ulke>()
                        .HasMany(x => x.Il)
                        .WithRequired()
                        .WillCascadeOnDelete(true);
            modelBuilder.Entity<Il>()
                        .HasMany(x => x.Ilce)
                        .WithRequired()
                        .WillCascadeOnDelete(true);
            modelBuilder.Entity<StokBilgileri>()
                        .HasRequired(x => x.Fatura)
                        .WithMany(x => x.StokBilgileri)
                        .HasForeignKey(x => x.FaturaId)
                        .WillCascadeOnDelete(true);
            modelBuilder.Entity<CariHareketleri>()
                        .HasRequired(x => x.Fatura)
                        .WithMany(x => x.CariHareketleri)
                        .HasForeignKey(x => x.FaturaId)
                        .WillCascadeOnDelete(true);
        }

        public DbSet<Birim> Birim { get; set; }
        public DbSet<Cari> Cari { get; set; }
        public DbSet<CariHareketleri> CariHareketleri { get; set; }
        public DbSet<Fatura> Fatura { get; set; }
        public DbSet<Il> Il { get; set; }
        public DbSet<Ilce> Ilce { get; set; }
        public DbSet<Kullanici> Kullanici { get; set; }
        public DbSet<KullaniciParametre> KullaniciParametre { get; set; }
        public DbSet<OzelKod> OzelKod { get; set; }
        public DbSet<Stok> Stok { get; set; }
        public DbSet<StokBilgileri> StokBilgileri { get; set; }
        public DbSet<Ulke> Ulke { get; set; }
        public DbSet<MailParametre> MailParametre { get; set; }
        public DbSet<Filtre> Filtre { get; set; }
    }
}