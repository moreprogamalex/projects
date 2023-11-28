using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;


namespace CapaDato
{
   public class DArticulo
    {
        private int idarticulo;
        private string nombre;
        private int idcategoria;
        private string cadena_busqueda;

        public int IDARTICULO
        {
            get { return idarticulo; }
            set { idarticulo = value; }
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public int IDCATEGORIA
        {
            get { return idcategoria; }
            set { idcategoria = value; }
        }
        public string CADENA_BUSQUEDA
        {
            get { return cadena_busqueda; }
            set { cadena_busqueda = value; }
        }

        public DArticulo()
        {

        }

        public DArticulo(int _idarticulo,string _nombre,int _idcategoria,string _cadena_busquesa)
        {
            IDARTICULO = _idarticulo;
            Nombre = _nombre;
            IDCATEGORIA = _idcategoria;
            CADENA_BUSQUEDA = _cadena_busquesa;
        }

        //Establecer la conexion con los procedimientos almacenados

        public string spInsertar(DArticulo articulo)
        {
            SqlConnection cadena_conexion = new SqlConnection();
            string rpt = "";

            try
            {
                cadena_conexion.ConnectionString = CConexion.Cn;
                cadena_conexion.Open();

                SqlCommand comando = new SqlCommand();
                comando.Connection = cadena_conexion;

                comando.CommandText = "spinsertar_articulo";
                comando.CommandType = CommandType.StoredProcedure;

                SqlParameter paridarticulo = new SqlParameter();
                paridarticulo.ParameterName = "@Idarticulo";
                paridarticulo.SqlDbType = SqlDbType.Int;
                paridarticulo.Direction = ParameterDirection.Output;
                comando.Parameters.Add(paridarticulo);

                SqlParameter parnombre = new SqlParameter();
                parnombre.ParameterName = "@Nombre";
                parnombre.SqlDbType = SqlDbType.VarChar;
                parnombre.Size = 100;
                parnombre.Value = articulo.Nombre;
                comando.Parameters.Add(parnombre);


                SqlParameter paridcategoria= new SqlParameter();
                paridcategoria.ParameterName = "@Idcategoria";
                paridcategoria.SqlDbType = SqlDbType.Int;
                paridcategoria.Value = articulo.IDCATEGORIA;
                comando.Parameters.Add(paridcategoria);


                rpt = comando.ExecuteNonQuery() == 1 ? "Registro Insertado" : "Registro no insertado";

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

        public string spEditar(DArticulo articulo)
        {
            SqlConnection cadena_conexion = new SqlConnection();
            string rpt = "";

            try
            {
                cadena_conexion.ConnectionString = CConexion.Cn;
                cadena_conexion.Open();

                SqlCommand comando = new SqlCommand();
                comando.Connection = cadena_conexion;

                comando.CommandText = "speditar_articulo";
                comando.CommandType = CommandType.StoredProcedure;

                SqlParameter paridarticulo = new SqlParameter();
                paridarticulo.ParameterName = "@_Idarticulo";
                paridarticulo.SqlDbType = SqlDbType.Int;
                paridarticulo.Value = articulo.IDARTICULO;
                comando.Parameters.Add(paridarticulo);

                SqlParameter parnombre = new SqlParameter();
                parnombre.ParameterName = "@Nombre";
                parnombre.SqlDbType = SqlDbType.VarChar;
                parnombre.Size = 100;
                parnombre.Value = articulo.Nombre;
                comando.Parameters.Add(parnombre);

                SqlParameter paridcategoria = new SqlParameter();
                paridcategoria.ParameterName = "@_Idcategoria";
                paridcategoria.SqlDbType = SqlDbType.Int;
                paridcategoria.Value = articulo.IDCATEGORIA;
                comando.Parameters.Add(paridcategoria);

                rpt = comando.ExecuteNonQuery() == 1 ? "Registro Actualizado" : "Registro no Actualizado";

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

        public string Eliminar(DArticulo articulo)
        {
            SqlConnection cadena_conexion = new SqlConnection();
            string rpt = "";

            try
            {
                cadena_conexion.ConnectionString = CConexion.Cn;
                cadena_conexion.Open();

                SqlCommand comando = new SqlCommand();
                comando.Connection = cadena_conexion;

                comando.CommandText = "speliminar_articulo";
                comando.CommandType = CommandType.StoredProcedure;

                SqlParameter paridarticulo = new SqlParameter();
                paridarticulo.ParameterName = "@_Idarticulo";
                paridarticulo.SqlDbType = SqlDbType.Int;
                paridarticulo.Value = articulo.IDARTICULO;
                comando.Parameters.Add(paridarticulo);

                rpt = comando.ExecuteNonQuery() == 1 ? "Registro Eliminado" : "Resgistro no Eliminado";

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

                comando.CommandText = "spmostrar_articulo";
                comando.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter adaptador = new SqlDataAdapter(comando);

                adaptador.Fill(tabla_resultado);

            }
            catch (Exception ex) { tabla_resultado = null; }

            return tabla_resultado;


        }//Fin metodo

        public DataTable spBuscar_Articulo(DArticulo articulo)
        {
            DataTable tabla_resultado = new DataTable();
            SqlConnection cadena_conexion = new SqlConnection();


            try
            {
                cadena_conexion.ConnectionString = CConexion.Cn;
                SqlCommand comando = new SqlCommand();
                comando.Connection = cadena_conexion;

                comando.CommandText = "spbuscar_articulo";
                comando.CommandType = CommandType.StoredProcedure;

                SqlParameter parnombre = new SqlParameter();
                parnombre.ParameterName = "@nombre_buscar";
                parnombre.SqlDbType = SqlDbType.VarChar;
                parnombre.Size = 450;
                parnombre.Value = articulo.CADENA_BUSQUEDA;
                comando.Parameters.Add(parnombre);

                SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                adaptador.Fill(tabla_resultado);

            }
            catch (Exception ex)
            {
                tabla_resultado = null;
            }


            return tabla_resultado;

        }//fin metodo


        public DataTable Stock_articulo()
        {
            SqlConnection cadena_conexion = new SqlConnection();
            DataTable tabla_resultado = new DataTable();



            try
            {
                SqlCommand comando = new SqlCommand();
                cadena_conexion.ConnectionString = CConexion.Cn;
                comando.Connection = cadena_conexion;

                comando.CommandText = "spmostrar_stockproduc";
                comando.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter adaptador = new SqlDataAdapter(comando);

                adaptador.Fill(tabla_resultado);

            }
            catch (Exception ex) { tabla_resultado = null; }

            return tabla_resultado;


        }//Fin metodo

        public DataTable spBuscar_ArticuloStock(DArticulo articulo)
        {
            DataTable tabla_resultado = new DataTable();
            SqlConnection cadena_conexion = new SqlConnection();


            try
            {
                cadena_conexion.ConnectionString = CConexion.Cn;
                SqlCommand comando = new SqlCommand();
                comando.Connection = cadena_conexion;

                comando.CommandText = "spbuscar_stockproduc";
                comando.CommandType = CommandType.StoredProcedure;

                SqlParameter parnombre = new SqlParameter();
                parnombre.ParameterName = "@nombre";
                parnombre.SqlDbType = SqlDbType.VarChar;
                parnombre.Size = 450;
                parnombre.Value = articulo.CADENA_BUSQUEDA;
                comando.Parameters.Add(parnombre);

                SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                adaptador.Fill(tabla_resultado);

            }
            catch (Exception ex)
            {
                tabla_resultado = null;
            }


            return tabla_resultado;

        }//fin metodo












    }//fin clase


}//fin namespace
