using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Usuario : BE.ICRUD<BE.Usuario>
    {

        //string conectionString = @"Data Source=DESKTOP-FJGOIBU\SQLEXPRESS;Initial Catalog=Personas;Integrated Security=True";

        #region Create
        public bool agregar(BE.Usuario objagregar)
        {
            return DAOs.Usuario.GetInstance().Add(objagregar.nombre, objagregar.apellido, objagregar.domicilio, objagregar.edad);
            
            //string conectionString = @"Data Source=DESKTOP-NOJ7B2G\SQLEXPRESS;Initial Catalog=Personas;Integrated Security=True";
            //bool returnValue = false;

            //string insertQuery = $"INSERT INTO Persona(Nombre, Apellido, Direccion, Edad) VALUES('{objagregar.nombre}','{objagregar.apellido}', '{objagregar.domicilio}', {objagregar.edad});";

            //SqlConnection connection = new SqlConnection(conectionString);
            //SqlCommand command = new SqlCommand();
            //command.Connection = connection;
            //command.CommandType = System.Data.CommandType.Text;
            //command.CommandText = insertQuery;

            //connection.Open();

            //if (command.ExecuteNonQuery() > 0)
            //{
            //    returnValue = true;

            //}

            //connection.Close();

            //return returnValue;
        }
        #endregion

        #region Listar
        public List<BE.Usuario> listar()
        {
            return DAOs.Usuario.GetInstance().GetAll();
         /*   string selectQuery = "SELECT * FROM Persona";

            List<BE.Usuario> usuarios = new List<BE.Usuario>();
            SqlDataReader reader;
            SqlConnection connection = new SqlConnection(conectionString);
            SqlCommand command = new SqlCommand();
            DataTable table = new DataTable();

            command.Connection = connection;
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = selectQuery;

            connection.Open();

            reader=command.ExecuteReader();

            table.Load(reader);

            connection.Close();

            foreach (DataRow item in table.Rows)
            {
                usuarios.Add(new BE.Usuario()
                {
                    ID= item.Field<int>("id"),
                    nombre = item.Field<string>("Nombre"),
                    apellido = item.Field<string>("Apellido"),
                    domicilio = item.Field<string>("Direccion"),
                    edad = item.Field<int>("Edad")
                });
            }

            return usuarios;
         */
        }

        #endregion

        #region Update
        public bool actualizar(BE.Usuario objActualizar)
        {
            return DAOs.Usuario.GetInstance().Update(objActualizar.ID,objActualizar.nombre, objActualizar.apellido, objActualizar.domicilio, objActualizar.edad);
            /*
            bool returnValue = false;

            string updateQuery = $"update persona set Nombre = '{objActualizar.nombre}', Apellido='{objActualizar.apellido}', Direccion='{objActualizar.domicilio}', edad={objActualizar.edad} where id={objActualizar.ID}";

            SqlConnection connection = new SqlConnection(conectionString);
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.Text;
            command.CommandText = updateQuery;

            connection.Open();

            if (command.ExecuteNonQuery() > 0)
            {
                returnValue = true;
            }

            connection.Close();

            return returnValue;
            */
        }
        #endregion

        #region Delete
        public bool eliminar(BE.Usuario objEliminar)
        {
            return DAOs.Usuario.GetInstance().delete(objEliminar.ID);
            /*
            bool returnValue = false;

            string deleteQuery = $"Delete from Persona where id= {objEliminar.ID}";

            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = conectionString;
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.Text;
            command.CommandText = deleteQuery;

            connection.Open();

            if (command.ExecuteNonQuery() > 0)
            {
                returnValue = true;
            }

            connection.Close();

            return returnValue;
            */
        } 
        #endregion


    }
}
