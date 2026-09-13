using System.Data.Odbc;

namespace CapaModelo_PaqueteCRUD.Repositorios
{
    public abstract class RepositorioBase
    {
        public readonly string cadenaConexion;

        public RepositorioBase()
        {
            cadenaConexion = "Dsn=MVC";
        }

        protected OdbcConnection AbrirConexion()
        {
            return new OdbcConnection(cadenaConexion);
        }
    }
}
