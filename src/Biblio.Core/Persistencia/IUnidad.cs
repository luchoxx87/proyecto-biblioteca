using Biblio.Core.Persistencia.Repositorios;

namespace Biblio.Core.Persistencia;
public interface IUnidad
{
    IRepoAutor RepoAutor { get; }
    IRepoCurso RepoCurso{get; }
    IRepoTitulo RepoTitulo{get; }
    IRepoEditorial RepoEditorial{get;}
    IRepoEjemplar RepoEjemplar{get;}
    void Guardar();
}