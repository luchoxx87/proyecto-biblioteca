using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Biblio.Core.Persistencia.Repositorios
{
    public interface IRepoTitulo: IAlta<Titulo>, IListado<Titulo>
    {
        
    }
}