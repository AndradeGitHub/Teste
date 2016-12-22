using System.Data.Entity.ModelConfiguration;

using testetivia.backend.domain.model;

namespace testetivia.backend.infrastructure.persistence.mappers
{
    public class CdMap : EntityTypeConfiguration<Cd>
    {
        public CdMap()
        {
            ToTable("Cd");

            HasKey(p => p.Id);
            Property(p => p.Titulo).IsRequired();
            Property(p => p.Artista).IsRequired();            
        }
    }
}