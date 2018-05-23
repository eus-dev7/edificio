using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Propietario
    {
        private int id;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private string nombre;
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        private string a_paterno;
        public string Apaterno
        {
            get { return a_paterno; }
            set { a_paterno = value; }
        }
        private string a_materno;
        public string Amaterno
        {
            get { return a_materno; }
            set { a_materno = value; }
        }
        private string ci;
        public string Ci
        {
            get { return ci; }
            set { ci = value; }
        }
        private string genero;
        public string Genero
        {
            get { return genero; }
            set { genero = value; }
        }
        private string telefono;
        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }
        private DateTime fecha_nacimiento;
        public DateTime FechaNacimiento
        {
            get { return fecha_nacimiento; }
            set { fecha_nacimiento = value; }
        }

        private string imagen;
        public string Imagen
        {
            get { return imagen; }
            set { imagen = value; }
        }

        public Propietario()
        {

        }

        public static DataTable ListarPropietarios()
        {
            DataTable devolverDataTable = new DataTable();

            string connectionString = ConfigurationManager.ConnectionStrings["EdificioConString"].ConnectionString;
            string queryString = "SELECT id_propietario,nombre,A_paterno,A_materno,CI,fecha_nacimiento,Genero,telefono,Foto FROM Propietario";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                try
                {
                    /*
                    while (reader.Read())
                    {                            
                        Propietario p = new Propietario();
                            
                        p.Id = reader.GetInt32(0);
                        p.Nombre = reader.GetString(1);
                        p.Apaterno = reader.GetString(2);
                        p.Amaterno = reader.GetString(3);
                        p.Ci = reader.GetString(4);
                        p.FechaNacimiento = reader.GetDateTime(5);
                        p.Genero = reader.GetString(6);
                        p.Telefono = reader.GetString(7);
                        p.Imagen = reader.GetString(8);
                        p.Usuario = reader.GetString(9);
                        p.Password = reader.GetString(10);
                                
                    }
                    reader.NextResult();
                     * */
                    connection.Open();
                    command.ExecuteNonQuery();

                    SqlDataAdapter tableAdapter = new SqlDataAdapter(command);

                    tableAdapter.Fill(devolverDataTable);

                }
                catch (SqlException ex)
                {
                    throw ex;
                }
                catch (Exception ex)
                {
                    //throw ex;
                }
            }
            return devolverDataTable;
        }


        public static void nuevoPrpietario(Propietario p)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["EdificioConString"].ConnectionString;
            string campos="(nombre,A_paterno,A_materno,CI,fecha_nacimiento,Genero,telefono,Foto)";
            string values="('"+p.Nombre+"','"+p.Apaterno+"','"+p.Amaterno+"','"+p.Ci+"','"+p.FechaNacimiento+"','"+p.Genero+"','"+p.Telefono+"','')";
            string queryString = "INSERT INTO Propietario "+campos+" VALUES"+values;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    throw ex;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }


        public static Propietario buscarPropietario(string p)
        {
            Propietario propietario = new Propietario();

            string connectionString = ConfigurationManager.ConnectionStrings["EdificioConString"].ConnectionString;
            string queryString = "SELECT id_propietario,nombre,A_paterno,A_materno,CI,fecha_nacimiento,Genero,telefono,Foto FROM Propietario WHERE id_propietario="+p;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            propietario.Id = reader.GetInt32(0);
                            propietario.Nombre = reader.GetString(1);
                            propietario.Apaterno = reader.GetString(2);
                            propietario.Amaterno = reader.GetString(3);
                            propietario.Ci = reader.GetString(4);
                            propietario.FechaNacimiento = reader.GetDateTime(5);
                            propietario.Genero = reader.GetString(6);
                            propietario.Telefono = reader.GetString(7);
                            propietario.Imagen = reader.GetString(8);
                        }
                        reader.NextResult();
                    }
                    reader.Close();

                }
                catch (SqlException ex)
                {
                    throw ex;
                }
                catch (Exception ex)
                {
                    //throw ex;
                }
            }
            return propietario;
        }

        public static void actualizarPrpietario(Propietario p)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["EdificioConString"].ConnectionString;
            string sets = "nombre='"+p.Nombre+"',A_paterno='"+p.Apaterno+"',A_materno='"+p.Amaterno+"',CI='"+p.Ci+"',fecha_nacimiento='"+p.FechaNacimiento+"',Genero='"+p.Genero+"',telefono='"+p.Telefono+"',Foto=''";
            string queryString = "UPDATE Propietario SET " + sets+" WHERE id_propietario="+p.Id;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    throw ex;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public static void eliminarPropietario(string p)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["EdificioConString"].ConnectionString;
            string queryString = "DELETE FROM Propietario WHERE id_propietario=" + p;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    throw ex;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public static DataTable filtrarPropietarios(string p)
        {
            DataTable devolverDataTable = new DataTable();

            string connectionString = ConfigurationManager.ConnectionStrings["EdificioConString"].ConnectionString;
            string queryString = "SELECT id_propietario,nombre,A_paterno,A_materno,CI,fecha_nacimiento,Genero,telefono,Foto FROM Propietario WHERE nombre LIKE '%" + p + "%' OR A_paterno LIKE '%" + p + "%' OR A_materno LIKE '%" + p + "%'";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();

                    SqlDataAdapter tableAdapter = new SqlDataAdapter(command);

                    tableAdapter.Fill(devolverDataTable);

                }
                catch (SqlException ex)
                {
                    throw ex;
                }
                catch (Exception ex)
                {
                    //throw ex;
                }
            }
            return devolverDataTable;
        }
    }
}
