using ProyectoMVC.Models;
using System.Data;
using System.Data.SqlClient;

namespace ProyectoMVC.Dato
{
    public class ClienteSqlDataAccessLayer
    {
        //Realizar la conexion haci ala BDD 
        //string connectionString = "Data Source=DESKTOP-BGGG8TN\\SQLEXPRESS Initial Ctalogo=dbroductos; user ID=sa; Password=sa;";
        string connectionString = "Data Source=DESKTOP-BGGG8TN\\SQLEXPRESS; Initial Catalog=dbProductos; User ID=sa; Password=sa;";

        public IEnumerable<ClienteSql> GetAllClientes()
        {
            List<ClienteSql> lst = new List<ClienteSql>();
            // Conexion de la capa de datos al modelo
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                // Se debe tener una transaccion en sqlserver
                SqlCommand cmd = new SqlCommand("cliente_SelectAll", con);
                cmd.CommandType = CommandType.StoredProcedure;

                con.Open();

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read()) {
                    ClienteSql cliente = new ClienteSql();
                    cliente.Codigo = Convert.ToInt32(reader["Codigo"]);
                    cliente.Cedula = reader["Cedula"].ToString();
                    cliente.Apellidos = reader["Apellidos"].ToString();
                    cliente.Nombres = reader["Nombres"].ToString();
                    cliente.FechaNacimiento = Convert.ToDateTime(reader["FechaNacimiento"]);
                    cliente.Mail = reader["Mail"].ToString();
                    cliente.Telefono = reader["Telefono"].ToString();
                    cliente.Direccion = reader["Direccion"].ToString();
                    cliente.Saldo = Convert.ToSingle(reader["Saldo"]);
                    lst.Add(cliente);
                }
                con.Close();
            }
            return lst;
        }


        // Método para insertar un nuevo cliente
        public void InsertCliente(ClienteSql cliente)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("cliente_Insert", con);
                cmd.CommandType = CommandType.StoredProcedure;

                // Pasando los parámetros al procedimiento almacenado
                cmd.Parameters.AddWithValue("@Cedula", cliente.Cedula);
                cmd.Parameters.AddWithValue("@Apellidos", cliente.Apellidos);
                cmd.Parameters.AddWithValue("@Nombres", cliente.Nombres);
                cmd.Parameters.AddWithValue("@FechaNacimiento", cliente.FechaNacimiento);
                cmd.Parameters.AddWithValue("@Mail", cliente.Mail);
                cmd.Parameters.AddWithValue("@Telefono", cliente.Telefono);
                cmd.Parameters.AddWithValue("@Direccion", cliente.Direccion);
                cmd.Parameters.AddWithValue("@Estado", cliente.Estado);
                cmd.Parameters.AddWithValue("@Saldo", cliente.Saldo);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }


        public void UpdateCliente(ClienteSql cliente)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("cliente_Update", con);
                cmd.CommandType = CommandType.StoredProcedure;

                // Parámetros del procedimiento almacenado
                cmd.Parameters.AddWithValue("@Codigo", cliente.Codigo);
                cmd.Parameters.AddWithValue("@Cedula", cliente.Cedula);
                cmd.Parameters.AddWithValue("@Apellidos", cliente.Apellidos);
                cmd.Parameters.AddWithValue("@Nombres", cliente.Nombres);
                cmd.Parameters.AddWithValue("@FechaNacimiento", cliente.FechaNacimiento);
                cmd.Parameters.AddWithValue("@Mail", cliente.Mail);
                cmd.Parameters.AddWithValue("@Telefono", cliente.Telefono);
                cmd.Parameters.AddWithValue("@Direccion", cliente.Direccion);
                cmd.Parameters.AddWithValue("@Estado", cliente.Estado);
                cmd.Parameters.AddWithValue("@Saldo", cliente.Saldo);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        public void DeleteCliente(int codigo)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("cliente_Delete", con);
                cmd.CommandType = CommandType.StoredProcedure;

                // Parámetro del procedimiento almacenado
                cmd.Parameters.AddWithValue("@Codigo", codigo);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }


        // Método para obtener un cliente por su cédula
        public ClienteSql GetClienteByCedula(string cedula)
        {
            ClienteSql cliente = null;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("cliente_SelectByCedula", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Cedula", cedula);

                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    cliente = new ClienteSql
                    {
                        Codigo = Convert.ToInt32(reader["Codigo"]),
                        Cedula = reader["Cedula"].ToString(),
                        Apellidos = reader["Apellidos"].ToString(),
                        Nombres = reader["Nombres"].ToString(),
                        FechaNacimiento = Convert.ToDateTime(reader["FechaNacimiento"]),
                        Mail = reader["Mail"].ToString(),
                        Telefono = reader["Telefono"].ToString(),
                        Direccion = reader["Direccion"].ToString(),
                        Estado = Convert.ToBoolean(reader["Estado"]),
                        Saldo = Convert.ToSingle(reader["Saldo"])
                    };
                }
                con.Close();
            }
            return cliente;
        }


    }
}
