using System.Data.Entity;

using testetivia.backend.domain.model;
using testetivia.backend.infrastructure.persistence.interfaces;
using testetivia.backend.infrastructure.persistence.mappers;

namespace testetivia.backend.infrastructure.persistence
{
    public class UnitOfWork : DbContext, IUnitOfWork
    {
        public virtual IDbSet<Cd> Cd { get; set; }
        public virtual IDbSet<Musica> Musica { get; set; }

        public UnitOfWork() : base("TiviaContext")
        {
        }

        public void Commit()
        {
            SaveChanges();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new CdMap());
            modelBuilder.Configurations.Add(new MusicaMap());

            modelBuilder.Entity<Musica>()                       
                        .HasMany<Cd>(s => s.Cds)                        
                        .WithMany(c => c.Musicas)                        
                        .Map(cs =>
                        {                            
                            cs.MapLeftKey("Musica_Id");
                            cs.MapRightKey("Cd_Id");
                            cs.ToTable("MusicaCds");
                        });
        }
    }
}
