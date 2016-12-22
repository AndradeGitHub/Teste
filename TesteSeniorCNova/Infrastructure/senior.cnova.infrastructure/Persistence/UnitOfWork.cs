using System.Data.Entity;

using senior.cnova.domain.model;
using senior.cnova.infrastructure.persistence.interfaces;
using senior.cnova.infrastructure.persistence.mappers;

namespace senior.cnova.infrastructure.persistence
{
    public class UnitOfWork : DbContext, IUnitOfWork
    {
        public virtual IDbSet<Amigo> Amigo { get; set; }        

        public UnitOfWork() : base("CNova")
        {
        }

        public void Commit()
        {
            SaveChanges();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AmigoMap());            
        }
    }
}