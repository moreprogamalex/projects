using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace CapaDato
{
    public class DProveedor
    {
        private int idproveedor;
        private string sector_comercial;
        private string empresa;
        private string sitioweb;
        private string telefono;
        private string direccion;
        private string txtbuscarxempresa;

        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }
        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }
   

        public int IDPROVEEDOR
        {
            get { return idproveedor; }
            set { idproveedor = value; }
        }

        public string Sector_comercial
        {
            get { return sector_comercial; }
            set { sector_comercial = value; }
        }

        public string Empresa { get => empresa; set => empresa = value; }
        public string Sitioweb { get => sitioweb; set => sitioweb = value; }
        public string Txtbuscarxempresa { get => txtbuscarxempresa; set => txtbuscarxempresa = value; }

        public DProveedor()
        {


        }

        public string spInsertar(DProveedor proveedor)
        {
            SqlConnection cadena_conexion = new SqlConnection();
            string rpt = "";

            try
            {
                cadena_conexion.ConnectionString = CConexion.Cn;
                cadena_conexion.Open();

                SqlCommand comando = new SqlCommand();
                comando.Connection = cadena_conexion;

                comando.CommandText = "spinsertar_proveedor";
                comando.CommandType = CommandType.StoredProcedure;
                


                SqlParameter paridproveedor = new SqlParameter();
                paridproveedor.ParameterName = "@Idproveedor";
                paridproveedor.SqlDbType = SqlDbType.Int;
                paridproveedor.Direction = ParameterDirection.Output;
                comando.Parameters.Add(paridproveedor);

                SqlParameter parsector_comercial = new SqlParameter();
                parsector_comercial.ParameterName = "@sectorcomercial";
                parsector_comercial.SqlDbType = SqlDbType.VarChar;
                parsector_comercial.Size = 150;
                parsector_comercial.Value = proveedor.Sector_comercial;
                comando.Parameters.Add(parsector_comercial);


                SqlParameter pardireccion= new SqlParameter();
                pardireccion.ParameterName = "@direccion";
                pardireccion.SqlDbType = SqlDbType.VarChar;
                pardireccion.Size = 100;
                pardireccion.Value = proveedor.Direccion;
                comando.Parameters.Add(pardireccion);


                SqlParameter partelefono = new SqlParameter();
                partelefono.ParameterName = "@telefono";
                partelefono.SqlDbType = SqlDbType.VarChar;
                partelefono.Size = 20;
                partelefono.Value = proveedor.Telefono;
                comando.Parameters.Add(partelefono);

                SqlParameter parsitoweb = new SqlParameter();
                parsitoweb.ParameterName = "@sitioweb";
                parsitoweb.SqlDbType = SqlDbType.VarChar;
                parsitoweb.Size = 300;
                parsitoweb.Value = proveedor.Sitioweb;
                comando.Parameters.Add(parsitoweb);

                SqlParameter parempresa = new SqlParameter();
                parempresa.ParameterName = "@empresa";
                parempresa.SqlDbType = SqlDbType.VarChar;
                parempresa.Size = 300;
                parempresa.Value = proveedor.Empresa;
                comando.Parameters.Add(parempresa);




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

        public string spEditar(DProveedor proveedor)
        {
            SqlConnection cadena_conexion = new SqlConnection();
            string rpt = "";

            try
            {
                cadena_conexion.ConnectionString = CConexion.Cn;
                cadena_conexion.Open();

                SqlCommand comando = new SqlCommand();
                comando.Connection = cadena_conexion;

                comando.CommandText = "speeditar_proveedor";
                comando.CommandType = CommandType.StoredProcedure;

                SqlParameter paridproveedor = new SqlParameter();
                paridproveedor.ParameterName = "@_idproveedor";
                paridproveedor.SqlDbType = SqlDbType.Int;
                paridproveedor.Value = proveedor.IDPROVEEDOR;
                comando.Parameters.Add(paridproveedor);

                SqlParameter parsector_comercial = new SqlParameter();
                parsector_comercial.ParameterName = "@sectorcomercial";
                parsector_comercial.SqlDbType = SqlDbType.VarChar;
                parsector_comercial.Size = 150;
                parsector_comercial.Value = proveedor.Sector_comercial;
                comando.Parameters.Add(parsector_comercial);


                SqlParameter pardireccion = new SqlParameter();
                pardireccion.ParameterName = "@direccion";
                pardireccion.SqlDbType = SqlDbType.VarChar;
                pardireccion.Size = 100;
                pardireccion.Value = proveedor.Direccion;
                comando.Parameters.Add(pardireccion);


                SqlParameter partelefono = new SqlParameter();
                partelefono.ParameterName = "@telefono";
                partelefono.SqlDbType = SqlDbType.VarChar;
                partelefono.Size = 20;
                partelefono.Value = proveedor.Telefono;
                comando.Parameters.Add(partelefono);

                SqlParameter parsitoweb = new SqlParameter();
                parsitoweb.ParameterName = "@sitioweb";
                parsitoweb.SqlDbType = SqlDbType.VarChar;
                parsitoweb.Size = 300;
                parsitoweb.Value = proveedor.Sitioweb;
                comando.Parameters.Add(parsitoweb);

                SqlParameter parempresa = new SqlParameter();
                parempresa.ParameterName = "@empresa";
                parempresa.SqlDbType = SqlDbType.VarChar;
                parempresa.Size = 300;
                parempresa.Value = proveedor.Empresa;
                comando.Parameters.Add(parempresa);


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

        public string Eliminar(DProveedor proveedor)
        {
            SqlConnection cadena_conexion = new SqlConnection();
            string rpt = "";

            try
            {
                cadena_conexion.ConnectionString = CConexion.Cn;
                cadena_conexion.Open();

                SqlCommand comando = new SqlCommand();
                comando.Connection = cadena_conexion;

                comando.CommandText = "speliminar_proveedor";
                comando.CommandType = CommandType.StoredProcedure;

                SqlParameter paridproveedor = new SqlParameter();
                paridproveedor.ParameterName = "@_idproveedor";
                paridproveedor.SqlDbType = SqlDbType.Int;
                paridproveedor.Value = proveedor.IDPROVEEDOR;
                comando.Parameters.Add(paridproveedor);

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

                comando.CommandText = "spmostrar_proveedor";
                comando.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter adaptador = new SqlDataAdapter(comando);

                adaptador.Fill(tabla_resultado);

            }
            catch (Exception ex) { tabla_resultado = null; }

            return tabla_resultado;


        }//Fin metodo

        public DataTable spBuscar_sectorcomercial(DProveedor proveedor)
        {
            DataTable tabla_resultado = new DataTable();
            SqlConnection cadena_conexion = new SqlConnection();


            try
            {
                cadena_conexion.ConnectionString = CConexion.Cn;
                SqlCommand comando = new SqlCommand();
                comando.Connection = cadena_conexion;

                comando.CommandText = "spBuscar_proveedorxsectorcomercial";
                comando.CommandType = CommandType.StoredProcedure;

                SqlParameter parnombre = new SqlParameter();
                parnombre.ParameterName = "@sectorcomercial";
                parnombre.SqlDbType = SqlDbType.VarChar;
                parnombre.Size = 150;
                parnombre.Value = proveedor.Sector_comercial;
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

        public DataTable spBuscar_nomempresa(DProveedor proveedor)
        {
            DataTable tabla_resultado = new DataTable();
            SqlConnection cadena_conexion = new SqlConnection();


            try
            {
                cadena_conexion.ConnectionString = CConexion.Cn;
                SqlCommand comando = new SqlCommand();
                comando.Connection = cadena_conexion;

                comando.CommandText = "spBuscar_proveedorxnombreempresa";
                comando.CommandType = CommandType.StoredProcedure;

                SqlParameter parnombre = new SqlParameter();
                parnombre.ParameterName = "@nombreempresa";
                parnombre.SqlDbType = SqlDbType.VarChar;
                parnombre.Size = 300;
                parnombre.Value = proveedor.Empresa;
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


    }//Fin calse



}//Fin namespace
