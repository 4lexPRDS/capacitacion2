using System.Collections.Generic;

namespace CapaModelo_PaqueteCRUD.Contratos
{
    public interface IRepositorioCRUD<TEntidad> where TEntidad : class
    {
        int Agregar(TEntidad entidad);
        int Editar(TEntidad entidad);
        int Eliminar(TEntidad entidad);
        IEnumerable<TEntidad> ObtenerTodos();
    }
}
