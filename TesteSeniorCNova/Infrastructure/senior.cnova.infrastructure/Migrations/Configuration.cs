using System;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;

namespace senior.cnova.infrastructure.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<senior.cnova.infrastructure.persistence.UnitOfWork>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(senior.cnova.infrastructure.persistence.UnitOfWork context)
        {
        }
    }
}
