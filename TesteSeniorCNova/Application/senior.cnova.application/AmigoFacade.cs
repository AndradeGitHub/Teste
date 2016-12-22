using System;
using System.Linq;
using System.Collections.Generic;

using senior.cnova.domain;
using senior.cnova.domain.model;
using senior.cnova.domain.repository;
using senior.cnova.infrastructure.persistence;
using senior.cnova.infrastructure.persistence.interfaces;

namespace senior.cnova.application
{
    public class AmigoFacade
    {
        private static IUnitOfWork _unitOfWork;

        private static dynamic _domainFactory;
        private static dynamic _repositoryFactory;

        public AmigoFacade()
        {
            _unitOfWork = new UnitOfWork();

            _domainFactory = DomainFactory.CreateDomain<Proximidade>(_unitOfWork);
            _repositoryFactory = RepositoryFactory.CreateRepository<Amigo, AmigoRepository>(_unitOfWork);
        }     

        public IList<Amigo> RetornaAmigoProximos(double latitudeAtual, double longitudeAtual)
        {
            try
            {
                List<Amigo> lstAmigo = _repositoryFactory.GetAll();
                
                for (int i=0; i < lstAmigo.Count; i++)                
                    lstAmigo[i].Distancia = _domainFactory.CalcularDistancia(latitudeAtual, longitudeAtual, lstAmigo[i].Latitude, lstAmigo[i].Longitude);                

                return lstAmigo.OrderBy(c => c.Distancia).Take(3).ToList<Amigo>(); 
            }
            catch (Exception ex)
            {                
                throw (ex);
            }
        }
    }
}