using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Usuario : BE.ICRUD<BE.Usuario>
    {



        DAL.Usuario DALUsuario = new DAL.Usuario();

        public bool agregar(BE.Usuario objagregar)
        {
            return DALUsuario.agregar(objagregar);
        }
     
        public bool actualizar(BE.Usuario objActualizar)
        {
            return DALUsuario.actualizar(objActualizar);
        }

        public bool eliminar(BE.Usuario objEliminar)
        {
            return DALUsuario.eliminar(objEliminar);
        }

        public List<BE.Usuario> listar()
        {
            return DALUsuario.listar();
        }
    }
}
