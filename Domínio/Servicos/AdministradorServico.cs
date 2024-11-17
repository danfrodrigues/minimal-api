using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using minimal_api.Domínio.Entidades;
using minimal_api.Infraestrutura.Interfaces;
using MinimalApi.DTOs;
using MinimalApi.Infraestrutura.Db;

namespace minimal_api.Domínio.Servicos
{
    public class AdministradorServico : IAdministradorServico
    {
        private readonly DbContexto _contexto;
        public AdministradorServico(DbContexto contexto)
        {
            _contexto = contexto;
        }

        public Administrador? Login (LoginDTO loginDTO)
        {
            var adm = _contexto.Administradores.Where(a => a.Email == loginDTO.Email && a.Senha == loginDTO.Senha).FirstOrDefault();

            return adm;
        }

        public Administrador Incluir (Administrador administrador)
        {
            _contexto.Administradores.Add(administrador);
            _contexto.SaveChanges();
            
            return administrador;
        }
        
        List<Administrador> Todos(int? pagina)
        {
            var query = _contexto.Administradores.AsQueryable();

            int itensPorPagina = 10;
            
            if(pagina !=null){
            query = query.Skip(((int)pagina -1)* itensPorPagina).Take(itensPorPagina);
            }


            return query.ToList();

        }
        public Administrador? BuscaPorId(int id)
        {
            return _contexto.Administradores.Where(v => v.Id == id).FirstOrDefault();           
        }

        List<Administrador> IAdministradorServico.Todos(int? pagina)
        {
            throw new NotImplementedException();
        }

        public Administrador BuscaPorID(int id)
        {
            throw new NotImplementedException();
        }
    }
}