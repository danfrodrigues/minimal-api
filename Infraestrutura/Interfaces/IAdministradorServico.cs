using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using minimal_api.Domínio.Entidades;
using MinimalApi.DTOs;

namespace minimal_api.Infraestrutura.Interfaces
{
    public interface IAdministradorServico
    {
#pragma warning disable CS8632 // The annotation for nullable reference types should only be used in code within a '#nullable' annotations context.
        Administrador? Login(LoginDTO loginDTO);
#pragma warning restore CS8632 // The annotation for nullable reference types should only be used in code within a '#nullable' annotations context.
    }
}