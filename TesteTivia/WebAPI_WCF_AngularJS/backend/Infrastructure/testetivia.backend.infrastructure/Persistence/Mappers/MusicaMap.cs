using System.Data.Entity.ModelConfiguration;

using testetivia.backend.domain.model;

namespace testetivia.backend.infrastructure.persistence.mappers
{
    public class MusicaMap : EntityTypeConfiguration<Musica>
    {
        public MusicaMap()
        {
            ToTable("Musica");

            HasKey(p => p.Id);
            Property(p => p.Nome).IsRequired();
            Property(p => p.Genero).IsOptional();
            Property(p => p.Duracao).IsRequired();            
        }
    }
}