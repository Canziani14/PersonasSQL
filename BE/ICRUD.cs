using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public interface ICRUD<T>
    {
        bool agregar(T objagregar);

        List<T> listar ();

        bool actualizar(T objActualizar);

        bool eliminar (T objEliminar);
    }
}
