using System;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;

namespace testetivia.backend.infrastructure.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<testetivia.backend.infrastructure.persistence.UnitOfWork>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(testetivia.backend.infrastructure.persistence.UnitOfWork context)
        {
        }
    }
}
