using System.Data.Entity.ModelConfiguration;

using senior.cnova.domain.model;

namespace senior.cnova.infrastructure.persistence.mappers
{
    public class AmigoMap : EntityTypeConfiguration<Amigo>
    {
        public AmigoMap()
        {
            ToTable("Amigo");

            HasKey(p => p.Id);
            Property(p => p.Nome).IsRequired();
            Property(p => p.Cidade).IsRequired();
            Property(p => p.Estado).IsRequired();
            Property(p => p.Latitude).IsRequired();
            Property(p => p.Longitude).IsRequired();
        }
    }
}