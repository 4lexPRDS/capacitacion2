using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using CapaModelo_PaqueteCRUD.Contratos;
using CapaModelo_PaqueteCRUD.Entidades;

namespace CapaModelo_PaqueteCRUD.Repositorios
{
    public class PaqueteRepositorio : RepositorioGenericoBase, IPaqueteRepositorio
    {
        private readonly string sqlSelect;
        private readonly string sqlInsert;
        private readonly string sqlUpdate;
        private readonly string sqlDelete;

        public PaqueteRepositorio()
        {
            sqlSelect = "SELECT id_paquete, id_pedido, codigo_rastreo_paquete, peso_paquete, " +
                        "alto_paquete, ancho_paquete, largo_paquete, descripcion_paquete, " +
                        "fragil_paquete, valor_declarado_paquete, tipo_paquete, estado_paquete " +
                        "FROM paquete";

            sqlInsert = "INSERT INTO paquete (id_pedido, codigo_rastreo_paquete, peso_paquete, " +
                     "alto_paquete, ancho_paquete, largo_paquete, descripcion_paquete, " +
                     "fragil_paquete, valor_declarado_paquete, tipo_paquete, estado_paquete) " +
                     "VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)";

            sqlUpdate = "UPDATE paquete SET id_pedido = ?, codigo_rastreo_paquete = ?, peso_paquete = ?, " +
                     "alto_paquete = ?, ancho_paquete = ?, largo_paquete = ?, descripcion_paquete = ?, " +
                     "fragil_paquete = ?, valor_declarado_paquete = ?, tipo_paquete = ?, estado_paquete = ? " +
                     "WHERE id_paquete = ?";

            sqlDelete = "DELETE FROM paquete WHERE id_paquete = ?";
        }

        public int Agregar(Paquete e)
        {
            List<OdbcParameter> parametros = new List<OdbcParameter>
            {
                new OdbcParameter("p1", e.IdPedido),
                new OdbcParameter("p2", e.CodigoRastreoPaquete),
                new OdbcParameter("p3", e.PesoPaquete),
                new OdbcParameter("p4", e.AltoPaquete),
                new OdbcParameter("p5", e.AnchoPaquete),
                new OdbcParameter("p6", e.LargoPaquete),
                new OdbcParameter("p7", e.DescripcionPaquete),
                new OdbcParameter("p8", e.FragilPaquete),
                new OdbcParameter("p9", e.ValorDeclaradoPaquete),
                new OdbcParameter("p10", e.TipoPaquete),
                new OdbcParameter("p11", e.EstadoPaquete)
            };
            return EjecutarComando(sqlInsert, parametros, CommandType.Text);
        }

        public int Editar(Paquete e)
        {
            List<OdbcParameter> parametros = new List<OdbcParameter>
            {
                new OdbcParameter("p1", e.IdPedido),
                new OdbcParameter("p2", e.CodigoRastreoPaquete),
                new OdbcParameter("p3", e.PesoPaquete),
                new OdbcParameter("p4", e.AltoPaquete),
                new OdbcParameter("p5", e.AnchoPaquete),
                new OdbcParameter("p6", e.LargoPaquete),
                new OdbcParameter("p7", e.DescripcionPaquete),
                new OdbcParameter("p8", e.FragilPaquete),
                new OdbcParameter("p9", e.ValorDeclaradoPaquete),
                new OdbcParameter("p10", e.TipoPaquete),
                new OdbcParameter("p11", e.EstadoPaquete),
                new OdbcParameter("p12", e.IdPaquete)
            };
            return EjecutarComando(sqlUpdate, parametros, CommandType.Text);
        }

        public int Eliminar(Paquete e)
        {
            List<OdbcParameter> parametros = new List<OdbcParameter>
            {
                new OdbcParameter("p1", e.IdPaquete)
            };
            return EjecutarComando(sqlDelete, parametros, CommandType.Text);
        }

        public IEnumerable<Paquete> ObtenerTodos()
        {
            List<Paquete> lista = new List<Paquete>();
            DataTable tabla = EjecutarConsulta(sqlSelect, CommandType.Text);
            foreach (DataRow fila in tabla.Rows)
            {
                Paquete p = new Paquete();
                p.IdPaquete = Convert.ToInt32(fila["id_paquete"]);
                p.IdPedido = fila["id_pedido"] == DBNull.Value ? 0 : Convert.ToInt32(fila["id_pedido"]);
                p.CodigoRastreoPaquete = fila["codigo_rastreo_paquete"].ToString();
                p.PesoPaquete = Convert.ToDecimal(fila["peso_paquete"]);
                p.AltoPaquete = Convert.ToDecimal(fila["alto_paquete"]);
                p.AnchoPaquete = Convert.ToDecimal(fila["ancho_paquete"]);
                p.LargoPaquete = Convert.ToDecimal(fila["largo_paquete"]);
                p.DescripcionPaquete = fila["descripcion_paquete"].ToString();
                p.FragilPaquete = fila["fragil_paquete"].ToString();
                p.ValorDeclaradoPaquete = Convert.ToDecimal(fila["valor_declarado_paquete"]);
                p.TipoPaquete = fila["tipo_paquete"].ToString();
                p.EstadoPaquete = fila["estado_paquete"].ToString();
                lista.Add(p);
            }
            tabla.Clear();
            return lista;
        }
    }
}
