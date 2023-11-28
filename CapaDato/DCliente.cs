using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;


namespace CapaDato
{
   public class DCliente
    {

        private int idcliente;

        public int IDCLIENTE
        {
            get { return idcliente; }
            set { idcliente = value; }
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

        public string Txtbuscador_nombrefull { get => txtbuscador_nombrefull; set => txtbuscador_nombrefull = value; }

        private string txtbuscador_nombrefull;




        public DCliente()
        {
         
            this.Nombre = string.Empty;
            this.Apellidos = string.Empty;
            this.Sexo = string.Empty;
            this.Direccion = string.Empty;
            this.Telefono = string.Empty;
            this.IDCLIENTE = -1;
            this.Txtbuscador_nombrefull = "VACIO";

        }

        public string spInsertar(DCliente cliente)
        {
            SqlConnection cadena_conexion = new SqlConnection();
            string rpt = "";

            try
            {
                cadena_conexion.ConnectionString = CConexion.Cn;
                cadena_conexion.Open();

                SqlCommand comando = new SqlCommand();
                comando.Connection = cadena_conexion;

                comando.CommandText = "spinsertar_cliente";
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@_idcliente", cliente.IDCLIENTE);
                comando.Parameters.AddWithValue("@nombres", cliente.Nombre);
                comando.Parameters.AddWithValue("@apellido", cliente.Apellidos);
                comando.Parameters.AddWithValue("@sexo", cliente.Sexo);
               comando.Parameters.AddWithValue("@direccion", cliente.Direccion);

               
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

        public string spEditar(DCliente cliente)
        {
            SqlConnection cadena_conexion = new SqlConnection();
            string rpt = "";

            try
            {
                cadena_conexion.ConnectionString = CConexion.Cn;
                cadena_conexion.Open();

                SqlCommand comando = new SqlCommand();
                comando.Connection = cadena_conexion;

                comando.CommandText = "speditar_cliente";
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@_idcliente", cliente.IDCLIENTE);
                comando.Parameters.AddWithValue("@nombres", cliente.Nombre);
                comando.Parameters.AddWithValue("@apellido", cliente.Apellidos);
                comando.Parameters.AddWithValue("@sexo", cliente.Sexo);
                comando.Parameters.AddWithValue("@direccion", cliente.Direccion);

                
                rpt = comando.ExecuteNonQuery() == 1 ? "Registro Actualizado" : "Registro no Actualizado";
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

        public string Eliminar(DCliente cliente)
        {
            SqlConnection cadena_conexion = new SqlConnection();
            string rpt = "";

            try
            {
                cadena_conexion.ConnectionString = CConexion.Cn;
                cadena_conexion.Open();

                SqlCommand comando = new SqlCommand();
                comando.Connection = cadena_conexion;

                comando.CommandText = "speliminar_cliente";
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@_idcliente", cliente.IDCLIENTE);

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

                comando.CommandText = "spmostrar_cliente";
                comando.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter adaptador = new SqlDataAdapter(comando);

                adaptador.Fill(tabla_resultado);

            }
            catch (Exception ex) { tabla_resultado = null; }

            return tabla_resultado;


        }//Fin metodo

        public DataTable spBuscar_apellido(DCliente cliente)
        {
            DataTable tabla_resultado = new DataTable();
            SqlConnection cadena_conexion = new SqlConnection();


            try
            {
                cadena_conexion.ConnectionString = CConexion.Cn;
                SqlCommand comando = new SqlCommand();
                comando.Connection = cadena_conexion;

                comando.CommandText = "spbuscar_clientexnombreapellido";
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@txtbuscar", cliente.Txtbuscador_nombrefull);

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


}//Fin namespace
