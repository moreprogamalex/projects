using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace CapaDato
{
   public class DTrabajador
    {
           private int idtrabajador;

        public int IDTrabajador
        {
            get { return idtrabajador; }
            set { idtrabajador = value; }
        }
        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        private string apellidos;

        public string Apellidos
        {
            get { return apellidos; }
            set { apellidos = value; }
        }
        private string sexo;

        public string Sexo
        {
            get { return sexo; }
            set { sexo = value; }
        }
        private string direccion;

        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }
        private string telefono;

        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }


        private string acceso;

        public string Acceso
        {
            get { return acceso; }
            set { acceso = value; }
        }
        private string usuario;

        public string Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }
        private string password;

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public int Edad { get => edad; set => edad = value; }
        public string Cedula { get => cedula; set => cedula = value; }
        public string Txtbuscar { get => txtbuscar; set => txtbuscar = value; }

        private int edad;
        private string cedula;
        private string txtbuscar;

        public DTrabajador()
        {
            this.Nombre = string.Empty;
            this.Apellidos = string.Empty;
            this.Sexo = string.Empty;
            this.Direccion = string.Empty;
            this.Telefono = string.Empty;
            this.Acceso = string.Empty;
            this.Usuario = string.Empty;
            this.Password = string.Empty;
            this.Edad = -1;
            this.Cedula = string.Empty;
        }

        public string spInsertar(DTrabajador trabajador)
        {
            SqlConnection cadena_conexion = new SqlConnection();
            string rpt = "";

            try
            {
                cadena_conexion.ConnectionString = CConexion.Cn;
                cadena_conexion.Open();

                SqlCommand comando = new SqlCommand();
                comando.Connection = cadena_conexion;

                comando.CommandText = "spinsertar_empleado";
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@idEmpleado", trabajador.IDTrabajador);
                comando.Parameters.AddWithValue("@Nombres", trabajador.Nombre);
                comando.Parameters.AddWithValue("@Apellidos", trabajador.Apellidos);
                comando.Parameters.AddWithValue("@sexo", trabajador.Sexo);
                comando.Parameters.AddWithValue("@Direccion", trabajador.Direccion);
                comando.Parameters.AddWithValue("@Telefono", trabajador.Telefono);
                comando.Parameters.AddWithValue("@Acceso", trabajador.Acceso);
                comando.Parameters.AddWithValue("@Usuario", trabajador.Usuario);
                comando.Parameters.AddWithValue("@Edad", trabajador.Edad);
                comando.Parameters.AddWithValue("@NoCedula", trabajador.Cedula);
                comando.Parameters.AddWithValue("@Contraseña", trabajador.Password);


                rpt = comando.ExecuteNonQuery() == 1 ? "Registro Insertado" : "Registro no insertado";
                comando.Parameters.Clear();

            }
            catch (Exception ex)
            {
                rpt = ex.Message;
            }

            finally
            {
                if (cadena_conexion.State == ConnectionState.Open)
                    cadena_conexion.Close();
            }

            return rpt;

        }//Fin metodo

        public string spEditar(DTrabajador trabajador)
        {
            SqlConnection cadena_conexion = new SqlConnection();
            string rpt = "";

            try
            {
                cadena_conexion.ConnectionString = CConexion.Cn;
                cadena_conexion.Open();

                SqlCommand comando = new SqlCommand();
                comando.Connection = cadena_conexion;

                comando.CommandText = "speditar_trabajador";
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@idEmpleado", trabajador.IDTrabajador);
                comando.Parameters.AddWithValue("@nombres", trabajador.Nombre);
                comando.Parameters.AddWithValue("@apellidos", trabajador.Apellidos);
                comando.Parameters.AddWithValue("@sexo", trabajador.Sexo);
                comando.Parameters.AddWithValue("@direccion", trabajador.Direccion);
                comando.Parameters.AddWithValue("@telefono", trabajador.Telefono);
                comando.Parameters.AddWithValue("@acceso", trabajador.Acceso);
                comando.Parameters.AddWithValue("@usuario", trabajador.Usuario);
                comando.Parameters.AddWithValue("@password", trabajador.Password);
                comando.Parameters.AddWithValue("@edad", trabajador.Edad);
                comando.Parameters.AddWithValue("@cedula", trabajador.Cedula);


                rpt = comando.ExecuteNonQuery() == 1 ? "Registro Actualizado" : "Registro no actualizado";
                comando.Parameters.Clear();
            }
            catch (Exception ex)
            {
                rpt = ex.Message;
            }

            finally
            {
                if (cadena_conexion.State == ConnectionState.Open)
                    cadena_conexion.Close();
            }

            return rpt;

        }//Fin metodo

        public string Eliminar(DTrabajador trabajador)
        {
            SqlConnection cadena_conexion = new SqlConnection();
            string rpt = "";

            try
            {
                cadena_conexion.ConnectionString = CConexion.Cn;
                cadena_conexion.Open();

                SqlCommand comando = new SqlCommand();
                comando.Connection = cadena_conexion;

                comando.CommandText = "speliminar_trabajador";
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@idtrabajador", trabajador.IDTrabajador);


                rpt = comando.ExecuteNonQuery() == 1 ? "Registro Eliminado" : "Resgistro no Eliminado";
                comando.Parameters.Clear();
            }
            catch (Exception ex)
            {
                rpt = ex.ToString();
            }

            if (cadena_conexion.State == ConnectionState.Open)
                cadena_conexion.Close();


            return rpt;

        }//Fin Metodo

        public DataTable Mostrar()
        {
            SqlConnection cadena_conexion = new SqlConnection();
            DataTable tabla_resultado = new DataTable();

            try
            {
                SqlCommand comando = new SqlCommand();
                cadena_conexion.ConnectionString = CConexion.Cn;
                comando.Connection = cadena_conexion;

                comando.CommandText = "spmostrar_trabajador";
                comando.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter adaptador = new SqlDataAdapter(comando);

                adaptador.Fill(tabla_resultado);

            }
            catch (Exception ex) { tabla_resultado = null; }

            return tabla_resultado;


        }//Fin metodo

        public DataTable spBuscar_trabajador(DTrabajador trabajador)
        {
            DataTable tabla_resultado = new DataTable();
            SqlConnection cadena_conexion = new SqlConnection();


            try
            {
                cadena_conexion.ConnectionString = CConexion.Cn;
                SqlCommand comando = new SqlCommand();
                comando.Connection = cadena_conexion;

                comando.CommandText = "spbuscar_trabajador";
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@textobuscar", trabajador.Txtbuscar);

                SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                adaptador.Fill(tabla_resultado);
                comando.Parameters.Clear();
            }
            catch (Exception ex)
            {
                tabla_resultado = null;
            }


            return tabla_resultado;

        }//fin metodo

  
        public DataTable spLogin(DTrabajador trabajador)
        {
            DataTable tabla_resultado = new DataTable();
            SqlConnection cadena_conexion = new SqlConnection();


            try
            {
                cadena_conexion.ConnectionString = CConexion.Cn;
                SqlCommand comando = new SqlCommand();
                comando.Connection = cadena_conexion;

                comando.CommandText = "splogin";
                comando.CommandType = CommandType.StoredProcedure;


                comando.Parameters.AddWithValue("@usuario", trabajador.Usuario);
                comando.Parameters.AddWithValue("@passwor", trabajador.Password);
    

                SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                adaptador.Fill(tabla_resultado);
                comando.Parameters.Clear();
            }
            catch (Exception ex)
            {
                tabla_resultado = null;
            }


            return tabla_resultado;

        }//fin metodo



    }//Fin clase

}//fin namespace
