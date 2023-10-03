using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Mappers
{
    internal class Usuario
    {
        private Usuario() { }
        private static Usuario instance;
        public static Usuario GetInstance()
        {
            if (instance == null)
            {
                instance = new Usuario();
            }
            return instance;
        }

        public List<BE.Usuario> Map(DataTable table)
        {
            List<BE.Usuario> usuarios = new List<BE.Usuario>();

            foreach (DataRow item in table.Rows)
            {
                usuarios.Add(new BE.Usuario()
                {
                    ID = item.Field<int>("id"),
                    nombre = item.Field<string>("Nombre"),
                    apellido = item.Field<string>("Apellido"),
                    domicilio = item.Field<string>("Direccion"),
                    edad = item.Field<int>("Edad")
                });
            }
            return usuarios;
        }
    }
}
