using System.Data;
using Biblio.Core;
using Dapper;

namespace Biblio.AdoDapp.Repos;

public class RepoTitulo: Repo
{
    private const string _queryTitulos =
    @"SELECT * FROM Titulos";

    public RepoTitulo(UnidadDapper unidad)
    : base(unidad) {}
    public void Alta(Titulo titulo)
    {
        var parametros = new DynamicParameters();
        parametros.Add("@idTitulo", direction: ParameterDirection.Output);
        parametros.Add("@unNombre", titulo.Nombre);
        parametros.Add("@anioPrimero", titulo.Anio_primero);

        Conexion.Execute("altaTitulos", parametros, Transaccion, commandType: CommandType.StoredProcedure);

            Conexion.Execute("altaTitulos", parametros, Transaccion, CommandType.StoredProcedure);

            //Objeto el valor parametro de tipo de salida 
            titulo.idTitulo = parametros.Get<ushort>("@unIdTitulo");
        }
        public List<Titulo> Obtener()
        => Conexion.
            Query<Curso>(_queryTitulo, transaction: Transaccion).
            ToList();
        
    }
}