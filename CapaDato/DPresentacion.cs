using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;


namespace CapaDato
{
  public  class DPresentacion
    {
        private int idpresentacion;
        private string nombre;
        private string descripcion;

        private string texto_buscar;

        public int IDPRESENTACION
        {
            get { return idpresentacion; }
            set { idpresentacion = value; }
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        public string Texto_buscar
        {
            get { return texto_buscar; }
            set { texto_buscar = value; }
        }

        public DPresentacion()
        {
            
        }
        public DPresentacion(int _idpresentacion, string _nombre, string _descripcion)
        {
            IDPRESENTACION = _idpresentacion;
            Nombre = _nombre;
            Descripcion = _descripcion;
        }


        public string Insertar(DPresentacion presentacion)
        {
            string rpt = "";
            SqlConnection cadena_conexion = new SqlConnection();
            

            try
            {
                cadena_conexion.ConnectionString = CConexion.Cn;
                cadena_conexion.Open();

                SqlCommand comando = new SqlCommand();
                comando.Connection = cadena_conexion;

                comando.CommandText = "spinsertar_presentacion";
                comando.CommandType = CommandType.StoredProcedure;

                SqlParameter paridpresentacion = new SqlParameter();
                paridpresentacion.ParameterName = "@idpresentacion";
                paridpresentacion.SqlDbType = SqlDbType.Int;
                paridpresentacion.Direction = ParameterDirection.Output;
                comando.Parameters.Add(paridpresentacion);

                SqlParameter parnombre = new SqlParameter();
                parnombre.ParameterName = "@nombre";
                parnombre.SqlDbType = SqlDbType.VarChar;
                parnombre.Size = 100;
                parnombre.Value = presentacion.Nombre;
                comando.Parameters.Add(parnombre);

                SqlParameter pardescripcion = new SqlParameter();
                pardescripcion.ParameterName = "@descripcion";
                pardescripcion.SqlDbType = SqlDbType.VarChar;
                pardescripcion.Size = 256;
                pardescripcion.Value = presentacion.Descripcion;
                comando.Parameters.Add(pardescripcion);

                rpt = comando.ExecuteNonQuery() == 1 ? "Ok" : "Registro no insertado";
                comando.Parameters.Clear();

            }
            catch (Exception ex)
            {
                rpt = ex.ToString();
            }

            if (cadena_conexion.State == ConnectionState.Open)
                cadena_conexion.Close();

            return rpt;

        }//fin mentodo

        public string Editar(DPresentacion presentacion)
        {
            string rpt = "";
            SqlConnection cadena_conexion = new SqlConnection();


            try
            {
                cadena_conexion.ConnectionString = CConexion.Cn;
                cadena_conexion.Open();

                SqlCommand comando = new SqlCommand();
                comando.Connection = cadena_conexion;

                comando.CommandText = "speditar_presentacion";
                comando.CommandType = CommandType.StoredProcedure;

                SqlParameter paridpresentacion = new SqlParameter();
                paridpresentacion.ParameterName = "@idpresentacion";
                paridpresentacion.SqlDbType = SqlDbType.Int;
                paridpresentacion.Value = presentacion.IDPRESENTACION;
                comando.Parameters.Add(paridpresentacion);

                SqlParameter parnombre = new SqlParameter();
                parnombre.ParameterName = "@nombre";
                parnombre.SqlDbType = SqlDbType.VarChar;
                parnombre.Size = 100;
                parnombre.Value = presentacion.Nombre;
                comando.Parameters.Add(parnombre);

                SqlParameter pardescripcion = new SqlParameter();
                pardescripcion.ParameterName = "@descripcion";
                pardescripcion.SqlDbType = SqlDbType.VarChar;
                pardescripcion.Size = 256;
                pardescripcion.Value = presentacion.Descripcion;
                comando.Parameters.Add(pardescripcion);

                rpt = comando.ExecuteNonQuery() == 1 ? "Ok" : "Registro no actualizado";
                comando.Parameters.Clear();

            }
            catch (Exception ex)
            {
                rpt = ex.ToString();
            }

            if (cadena_conexion.State == ConnectionState.Open)
                cadena_conexion.Close();

            return rpt;

        }//Fin metodo

        public string Eliminar(DPresentacion presentacion)
        {
            SqlConnection cadena_conexion = new SqlConnection();
            string rpt = "";

            try
            {
                cadena_conexion.ConnectionString = CConexion.Cn;
                cadena_conexion.Open();

                SqlCommand comando = new SqlCommand();
                comando.Connection = cadena_conexion;

                comando.CommandText = "speliminar_presentacion";
                comando.CommandType = CommandType.StoredProcedure;

                SqlParameter paridpresentacion = new SqlParameter();
                paridpresentacion.ParameterName = "@idpresentacion";
                paridpresentacion.SqlDbType = SqlDbType.Int;
                paridpresentacion.Value = presentacion.IDPRESENTACION;
                comando.Parameters.Add(paridpresentacion);

                rpt = comando.ExecuteNonQuery() == 1 ? "Ok" : "Resgistro no eliminado";
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

                comando.CommandText = "spmostrar_presentacion";
                comando.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter adaptador = new SqlDataAdapter(comando);

                adaptador.Fill(tabla_resultado);

            }
            catch (Exception ex) { tabla_resultado = null; }

            return tabla_resultado;
        

        }//Fin metodo

        public DataTable Buscar_nombre(DPresentacion presentacion)
        {

            DataTable tabla_resultado = new DataTable();
            SqlConnection cadena_conexion = new SqlConnection();


            try
            {
                cadena_conexion.ConnectionString = CConexion.Cn;
                SqlCommand comando = new SqlCommand();
                comando.Connection = cadena_conexion;

                comando.CommandText = "spbuscar_presentacion";
                comando.CommandType = CommandType.StoredProcedure;

                SqlParameter parnombre = new SqlParameter();
                parnombre.ParameterName = "@nombre_buscar";
                parnombre.SqlDbType = SqlDbType.VarChar;
                parnombre.Size = 100;
                parnombre.Value = presentacion.Texto_buscar;
                comando.Parameters.Add(parnombre);

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








    }//Fin Clase


}//Fin namespace
