using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DAOs
{
    internal class Usuario
    {
        private Usuario() { }
        private static DAOs.Usuario instance;
        public static DAOs.Usuario GetInstance()
        {
            if (instance == null)
            {
                instance = new DAOs.Usuario();
            }
            return instance;
        }

        string conectionString = @"Data Source=DESKTOP-FJGOIBU\SQLEXPRESS;Initial Catalog=Personas;Integrated Security=True";

        string spAdd = "UsuarioAdd";
        string spDelete = "UsuarioDeleteByID";
        string spSelectAll = "GetAll";
        string spUpdate = "UsuarioUpdate";

        SqlConnection connection;
        #region create
        public bool Add(string nombre, string apellido, string domicilio, int edad)
        {
            bool returnValue = false;

            connection = new SqlConnection(conectionString);
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.CommandText = spAdd;

            command.Parameters.AddWithValue("@Nombre", nombre);
            command.Parameters.AddWithValue("@Apellido", apellido);
            command.Parameters.AddWithValue("@Direccion", domicilio);
            command.Parameters.AddWithValue("@Edad", edad);

            connection.Open();
          
            if (command.ExecuteNonQuery() > 0)
            {
                returnValue = true;
            }

            connection.Close();

            return returnValue;
        }
        #endregion

        #region listar
        public List<BE.Usuario> GetAll()
        {
            DataTable table = new DataTable();
            connection = new SqlConnection(conectionString);
            SqlCommand command = new SqlCommand();
            SqlDataReader reader;
            command.Connection = connection;
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.CommandText = spSelectAll;

            connection.Open ();

            reader = command.ExecuteReader();
            table.Load(reader);

            connection.Close();

            return Mappers.Usuario.GetInstance().Map(table);
        }


        #endregion

        #region update
        public bool Update(int id,string nombre, string apellido, string domicilio, int edad)
        {
            bool returnValue = false;

            connection = new SqlConnection(conectionString);
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.CommandText = spUpdate;

            command.Parameters.AddWithValue("@id", id);
            command.Parameters.AddWithValue("@Nombre", nombre);
            command.Parameters.AddWithValue("@Apellido", apellido);
            command.Parameters.AddWithValue("@Direccion", domicilio);
            command.Parameters.AddWithValue("@Edad", edad);

           
            connection.Open();
            command.ExecuteNonQuery();

            returnValue = true;
            

            connection.Close();

            return returnValue;
        }


        #endregion

        #region delete
        public bool delete(int id)
        {
            bool returnValue = false;

            connection = new SqlConnection(conectionString);
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.CommandText = spDelete;

            command.Parameters.AddWithValue("@id", id);
           

            connection.Open();
            command.ExecuteNonQuery();


            returnValue = true;
            

            connection.Close();

            return returnValue;
        }

        #endregion
    }
}
