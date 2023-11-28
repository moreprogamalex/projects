using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace CapaDato
{
    public class DVenta
    {
        private int _Idventa;
        private int _Idcliente;
        private int _Idtrabajador;
        private DateTime _Fecha;
        private string _Tipo_Comprobante;
        public int Idventa
        {
            get { return _Idventa; }
            set { _Idventa = value; }
        }

        public int Idcliente
        {
            get { return _Idcliente; }
            set { _Idcliente = value; }
        }

        public int Idtrabajador
        {
            get { return _Idtrabajador; }
            set { _Idtrabajador = value; }
        }

        public DateTime Fecha
        {
            get { return _Fecha; }
            set { _Fecha = value; }
        }

        public string Tipo_Comprobante
        {
            get { return _Tipo_Comprobante; }
            set { _Tipo_Comprobante = value; }
        }

        public string DisminuirStock(int iddetalle_ingreso, int cantidad)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //Código
                SqlCon.ConnectionString = CConexion.Cn;
                SqlCon.Open();
                //Establecer el Comando
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spdisminuir_stockactual";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIddetalle_Ingreso = new SqlParameter();
                ParIddetalle_Ingreso.ParameterName = "@iddetalle_ingreso";
                ParIddetalle_Ingreso.SqlDbType = SqlDbType.Int;
                ParIddetalle_Ingreso.Value = iddetalle_ingreso;
                SqlCmd.Parameters.Add(ParIddetalle_Ingreso);

                SqlParameter ParCantidad = new SqlParameter();
                ParCantidad.ParameterName = "@cantidad";
                ParCantidad.SqlDbType = SqlDbType.Int;
                ParCantidad.Value = cantidad;
                SqlCmd.Parameters.Add(ParCantidad);


                //Ejecutamos nuestro comando

                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "NO se Actualizó el stock";


            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return rpta;
        }

        public string Insertar(DVenta Venta, List<DDetalle_venta> Detalle)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //Código
                SqlCon.ConnectionString = CConexion.Cn;
                SqlCon.Open();
                //Establecer la trasacción
                SqlTransaction SqlTra = SqlCon.BeginTransaction();
                //Establecer el Comando
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.Transaction = SqlTra;
                SqlCmd.CommandText = "spinsertar_venta";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdventa = new SqlParameter();
                ParIdventa.ParameterName = "@idventa";
                ParIdventa.SqlDbType = SqlDbType.Int;
                ParIdventa.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParIdventa);

                SqlParameter ParIdCliente = new SqlParameter();
                ParIdCliente.ParameterName = "@idcliente";
                ParIdCliente.SqlDbType = SqlDbType.Int;
                ParIdCliente.Value = Venta.Idcliente;
                SqlCmd.Parameters.Add(ParIdCliente);

                SqlParameter ParIdtrabajador = new SqlParameter();
                ParIdtrabajador.ParameterName = "@idtrabajador";
                ParIdtrabajador.SqlDbType = SqlDbType.Int;
                ParIdtrabajador.Value = Venta.Idtrabajador;
                SqlCmd.Parameters.Add(ParIdtrabajador);

                SqlParameter ParFecha = new SqlParameter();
                ParFecha.ParameterName = "@fecha";
                ParFecha.SqlDbType = SqlDbType.Date;
                ParFecha.Value = Venta.Fecha;
                SqlCmd.Parameters.Add(ParFecha);

                SqlParameter ParTipo_Comprobante = new SqlParameter();
                ParTipo_Comprobante.ParameterName = "@tipo_comprobante";
                ParTipo_Comprobante.SqlDbType = SqlDbType.VarChar;
                ParTipo_Comprobante.Size = 20;
                ParTipo_Comprobante.Value = Venta.Tipo_Comprobante;
                SqlCmd.Parameters.Add(ParTipo_Comprobante);

                

                //Ejecutamos nuestro comando

                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "NO se Ingreso el Registro";

                if (rpta.Equals("OK"))
                {
                    //Obtener el código del ingreso generado
                    this.Idventa = Convert.ToInt32(SqlCmd.Parameters["@idventa"].Value);
                    foreach (DDetalle_venta det in Detalle)
                    {
                        det.Idventa = this.Idventa;
                        //Llamar al método insertar de la clase DDetalle_Ingreso
                        rpta = det.Insertar(det, ref SqlCon, ref SqlTra);
                        if (!rpta.Equals("OK"))
                        {
                            break;
                        }
                        else
                        {
                            //Actualizamos el stock
                            rpta = DisminuirStock(det.Iddetalle_ingreso, det.Cantidad);
                            if (!rpta.Equals("OK"))
                            {
                                break;
                            }
                        }
                    }

                }
                if (rpta.Equals("OK"))
                {
                    SqlTra.Commit();
                }
                else
                {
                    SqlTra.Rollback();
                }


            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return rpta;

        }


        public string Eliminar(DVenta Venta)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //Código
                SqlCon.ConnectionString = CConexion.Cn;
                SqlCon.Open();
                //Establecer el Comando
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "speliminar_venta";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdventa = new SqlParameter();
                ParIdventa.ParameterName = "@idventa";
                ParIdventa.SqlDbType = SqlDbType.Int;
                ParIdventa.Value = Venta.Idventa;
                SqlCmd.Parameters.Add(ParIdventa);


                //Ejecutamos nuestro comando

                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "OK";


            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return rpta;
        }


        public DataTable Mostrar_venta()
        {

            DataTable t_resultado = new DataTable("Venta");
            SqlConnection sqlcon = new SqlConnection();

            try
            {
                sqlcon.ConnectionString = CConexion.Cn;

                SqlCommand sqlcmd = new SqlCommand();

                sqlcmd.Connection = sqlcon;
                sqlcmd.CommandText = "spmostrar_venta";
                sqlcmd.CommandType = CommandType.StoredProcedure;


                SqlDataAdapter sqldat = new SqlDataAdapter(sqlcmd);
                sqldat.Fill(t_resultado);
            }
            catch (Exception ex)
            {

                t_resultado = null;

            }

            return t_resultado;

        }//Fin metodo
        public DataTable Buscarxfecha_venta(string f01, string f02)
        {

            DataTable t_resultado = new DataTable("venta");
            SqlConnection sqlcon = new SqlConnection();

            try
            {
                sqlcon.ConnectionString = CConexion.Cn;

                SqlCommand sqlcmd = new SqlCommand();

                sqlcmd.Connection = sqlcon;
                sqlcmd.CommandText = "spbuscarventa_xfecha";
                sqlcmd.CommandType = CommandType.StoredProcedure;

                SqlParameter parnombre_buscar1 = new SqlParameter();
                parnombre_buscar1.ParameterName = "@txt01";
                parnombre_buscar1.SqlDbType = SqlDbType.VarChar;
                parnombre_buscar1.Size = 50;
                parnombre_buscar1.Value = f01;
                sqlcmd.Parameters.Add(parnombre_buscar1);

                SqlParameter parnombre_buscar2 = new SqlParameter();
                parnombre_buscar2.ParameterName = "@txt02";
                parnombre_buscar2.SqlDbType = SqlDbType.VarChar;
                parnombre_buscar2.Size = 50;
                parnombre_buscar2.Value = f02;
                sqlcmd.Parameters.Add(parnombre_buscar2);


                SqlDataAdapter sqldat = new SqlDataAdapter(sqlcmd);
                sqldat.Fill(t_resultado);

                sqlcmd.Parameters.Clear();
            }
            catch (Exception ex)
            {

                t_resultado = null;

            }

            return t_resultado;




        }//Fin metodo
        public DataTable Mostrar_detalleventa(int idbuscar)
        {

            DataTable t_resultado = new DataTable("Detalle Venta");
            SqlConnection sqlcon = new SqlConnection();

            try
            {
                sqlcon.ConnectionString = CConexion.Cn;

                SqlCommand sqlcmd = new SqlCommand();

                sqlcmd.Connection = sqlcon;
                sqlcmd.CommandText = "spmostrar_detalleventa";
                sqlcmd.CommandType = CommandType.StoredProcedure;

                SqlParameter partxtbuscar = new SqlParameter();
                partxtbuscar.ParameterName = "@txtbuscar";
                partxtbuscar.SqlDbType = SqlDbType.Int;
                partxtbuscar.Value = idbuscar;
                sqlcmd.Parameters.Add(partxtbuscar);


                SqlDataAdapter sqldat = new SqlDataAdapter(sqlcmd);
                sqldat.Fill(t_resultado);

                sqlcmd.Parameters.Clear();
            }
            catch (Exception ex)
            {

                t_resultado = null;

            }

            return t_resultado;

        }//Fin metodo
        public DataTable Mostrar_articulo_ventaxnombre(string txt)
        {

            DataTable t_resultado = new DataTable("Venta Articulo");
            SqlConnection sqlcon = new SqlConnection();

            try
            {
                sqlcon.ConnectionString = CConexion.Cn;

                SqlCommand sqlcmd = new SqlCommand();

                sqlcmd.Connection = sqlcon;
                sqlcmd.CommandText = "spbuscararticulo_ventaxnombre";
                sqlcmd.CommandType = CommandType.StoredProcedure;

                SqlParameter partxtbuscar = new SqlParameter();
                partxtbuscar.ParameterName = "@txtarticulo";
                partxtbuscar.SqlDbType = SqlDbType.VarChar;
                partxtbuscar.Size = 200;
                partxtbuscar.Value = txt;
                sqlcmd.Parameters.Add(partxtbuscar);


                SqlDataAdapter sqldat = new SqlDataAdapter(sqlcmd);
                sqldat.Fill(t_resultado);

                sqlcmd.Parameters.Clear();
            }
            catch (Exception ex)
            {

                t_resultado = null;

            }

            return t_resultado;

        }//Fin metodo
        public DataTable Mostrar_articulo_vistaventa()
        {

            DataTable t_resultado = new DataTable("VistaArticulo_venta");
            SqlConnection sqlcon = new SqlConnection();

            try
            {
                sqlcon.ConnectionString = CConexion.Cn;

                SqlCommand sqlcmd = new SqlCommand();

                sqlcmd.Connection = sqlcon;
                sqlcmd.CommandText = "spMostrararticulo_vistaventa";
                sqlcmd.CommandType = CommandType.StoredProcedure;


                SqlDataAdapter sqldat = new SqlDataAdapter(sqlcmd);
                sqldat.Fill(t_resultado);

               
            }
            catch (Exception ex)
            {

                t_resultado = null;

            }

            return t_resultado;

        }//Fin metodo

    }//fin class

}//fin namespace
