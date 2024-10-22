using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace minimal_api.Domínio.ModelViews
{
    public struct Home
    {
        public string Mensagem { get => "Bem vindo a API de veículos!";}
        public string Documentacao { get => "/swagger";}
    }
}