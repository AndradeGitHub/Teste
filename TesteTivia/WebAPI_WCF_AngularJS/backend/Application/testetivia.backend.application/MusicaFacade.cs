using System;
using System.Collections.Generic;

using testetivia.backend.domain;
using testetivia.backend.domain.model;
using testetivia.backend.domain.repository;
using testetivia.backend.infrastructure.persistence;
using testetivia.backend.infrastructure.persistence.interfaces;

namespace testetivia.backend.application
{
    public class MusicaFacade 
    {
        private static IUnitOfWork _unitOfWork;
        
        private static dynamic _repositoryFactory;

        public MusicaFacade()
        {
            _unitOfWork = new UnitOfWork();
            
            _repositoryFactory = RepositoryFactory.CreateRepository<Musica, MusicaRepository>(_unitOfWork);
        }

        public IEnumerable<Musica> GetMusica(string nome)
        {
            try
            {
                Musica musicaDomain = new Musica();
                musicaDomain.Nome = nome;

                var result = _repositoryFactory.Get(musicaDomain);

                return result != null ? FormatMusica(result) : null;                
            }
            catch (Exception ex)
            {
                throw (ex.InnerException);
            }
        }

        private List<Musica> FormatMusica(List<Musica> lstMusica)
        {
            List<Musica> lstMusicaRet = new List<Musica>();
            foreach (Musica musica in lstMusica)
            {
                Musica musicaRet = new Musica();
                musicaRet.Id = musica.Id;
                musicaRet.Nome = musica.Nome;
                musicaRet.Genero = musica.Genero;
                musicaRet.Duracao = musica.Duracao;                              

                List<Cd> lstCd = new List<Cd>();
                foreach (Cd cd in musica.Cds)
                {
                    Cd cdInt = new Cd();
                    cdInt.Id = cd.Id;
                    cdInt.Titulo = cd.Titulo;
                    cdInt.Artista = cd.Artista;

                    var cdMusicas = new List<Musica>(cd.Musicas);
                    cdMusicas.ForEach(x => cdInt.TotalDuracao += x.Duracao);

                    lstCd.Add(cdInt);
                }

                musicaRet.Cds = lstCd;

                lstMusicaRet.Add(musicaRet);
            }

            return lstMusicaRet;
        }
    }
}