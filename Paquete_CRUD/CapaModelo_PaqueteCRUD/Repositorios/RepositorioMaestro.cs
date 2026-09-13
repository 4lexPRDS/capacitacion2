using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;

namespace CapaModelo_PaqueteCRUD.Repositorios
{
    public abstract class RepositorioGenericoBase : RepositorioBase
    {
        public int EjecutarComando(string textoComando, List<OdbcParameter> parametros, CommandType tipoComando)
        {
            using (OdbcConnection cn = AbrirConexion())
            {
                cn.Open();
                using (OdbcCommand cmd = new OdbcCommand())
                {
                    cmd.Connection = cn;
                    cmd.CommandText = textoComando;
                    cmd.CommandType = tipoComando;
                    cmd.Parameters.AddRange(parametros.ToArray());
                    return cmd.ExecuteNonQuery();
                }
            }
        }

        public DataTable EjecutarConsulta(string textoComando, CommandType tipoComando)
        {
            DataTable resultado = new DataTable();
            using (OdbcConnection cn = AbrirConexion())
            {
                cn.Open();
                using (OdbcCommand cmd = new OdbcCommand())
                {
                    cmd.Connection = cn;
                    cmd.CommandText = textoComando;
                    cmd.CommandType = tipoComando;
                    using (OdbcDataReader lector = cmd.ExecuteReader())
                    {
                        resultado.Load(lector);
                    }
                }
            }
            return resultado;
        }
    }
}
