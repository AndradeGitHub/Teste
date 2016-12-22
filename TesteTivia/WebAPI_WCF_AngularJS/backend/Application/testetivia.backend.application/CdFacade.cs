using System;
using System.Collections.Generic;

using AutoMapper;

using testetivia.backend.domain;
using testetivia.backend.domain.model;
using testetivia.backend.domain.repository;
using testetivia.backend.infrastructure.persistence;
using testetivia.backend.infrastructure.persistence.interfaces;

namespace testetivia.backend.application
{
    public class CdFacade
    {
        private static IUnitOfWork _unitOfWork;
        
        private static dynamic _repositoryFactory;

        public CdFacade()
        {
            _unitOfWork = new UnitOfWork();
            
            _repositoryFactory = RepositoryFactory.CreateRepository<Cd, CdRepository>(_unitOfWork);
        }

        public bool AddCd(Cd cd)
        {
            try
            {              
                _repositoryFactory.Add(cd);

                return true;
            }
            catch (Exception ex)
            {
                throw (ex.InnerException);
            }
        }

        public List<Cd> GetCd(string titulo, string artista, string generoMusica, string nomeMusica)
        {
            try
            {
                Cd cdDomain = new Cd();
                cdDomain.Titulo = titulo;
                cdDomain.Artista = artista;

                var musica = new Musica();
                musica.Genero = string.IsNullOrEmpty(generoMusica) ? string.Empty : generoMusica;
                musica.Nome = string.IsNullOrEmpty(nomeMusica) ? string.Empty : nomeMusica; ;

                cdDomain.Musicas.Add(musica);

                var result = _repositoryFactory.Get(cdDomain);
     
                return result != null ? FormatCd(result) : null; 
            }
            catch (Exception ex)
            {                
                throw (ex.InnerException);
            }
        }

        private List<Cd> FormatCd(List<Cd> lstCd)
        {
            List<Cd> lstCdRet = new List<Cd>();
            foreach (Cd cd in lstCd)
            {
                Cd cdRet = new Cd();
                cdRet.Id = cd.Id;
                cdRet.Titulo = cd.Titulo;
                cdRet.Artista = cd.Artista;

                List<Musica> lstMusica = new List<Musica>();
                foreach (Musica musica in cd.Musicas)
                {
                    Musica musicaInt = new Musica();
                    musicaInt.Id = musica.Id;
                    musicaInt.Nome = musica.Nome;
                    musicaInt.Genero = musica.Genero;
                    musicaInt.Duracao = musica.Duracao;

                    cdRet.TotalDuracao += musica.Duracao;                    

                    lstMusica.Add(musicaInt);
                }

                cdRet.Musicas = lstMusica;

                lstCdRet.Add(cdRet);
            }

            return lstCdRet;
        }
    }
}