using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace CapaDato
{
   public class DIngreso
    {
        private int idingreso;

        public int IDINGRESO
        {
            get { return idingreso; }
            set { idingreso = value; }
        }
        private int idtrabajador;

        public int IDTRABAJADOR
        {
            get { return idtrabajador; }
            set { idtrabajador = value; }
        }
        private int idproveedor;

        public int IDPROVEEDOR
        {
            get { return idproveedor; }
            set { idproveedor = value; }
        }
        private DateTime fecha;

        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }
        private string tipo_comprobante;

        public string Tipo_comprobante
        {
            get { return tipo_comprobante; }
            set { tipo_comprobante = value; }
        }
 

     
        private string estado;

        public string Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        public string Insertar_ingreso(DIngreso ingreso,List<DDetalle_Ingreso> detalle)
        {
            string rpt = " ";
            
            SqlConnection sqlcon = new SqlConnection();

            try
            {
                sqlcon.ConnectionString = CConexion.Cn;
                sqlcon.Open();

                SqlTransaction sqlt = sqlcon.BeginTransaction();

                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.Connection = sqlcon;
                sqlcmd.Transaction = sqlt;

                sqlcmd.CommandText = "spinsertar_ingreso";
                sqlcmd.CommandType = CommandType.StoredProcedure;

                SqlParameter paridingreso = new SqlParameter();
                paridingreso.ParameterName = "@Idcompra";
                paridingreso.SqlDbType = SqlDbType.Int;
                paridingreso.Direction = ParameterDirection.Output;
                sqlcmd.Parameters.Add(paridingreso);

                SqlParameter paridtrabajador= new SqlParameter();
                paridtrabajador.ParameterName = "@Idempleado";
                paridtrabajador.SqlDbType = SqlDbType.Int;
                paridtrabajador.Value = ingreso.IDTRABAJADOR;
                sqlcmd.Parameters.Add(paridtrabajador);

                SqlParameter paridproveedor = new SqlParameter();
                paridproveedor.ParameterName = "@Idproveedor";
                paridproveedor.SqlDbType = SqlDbType.Int;
                paridproveedor.Value = ingreso.IDPROVEEDOR;
                sqlcmd.Parameters.Add(paridproveedor);

                SqlParameter parfecha = new SqlParameter();
                parfecha.ParameterName = "@Fecha";
                parfecha.SqlDbType = SqlDbType.Date;
                parfecha.Value = ingreso.Fecha;
                sqlcmd.Parameters.Add(parfecha);

                SqlParameter partipo_comprobante = new SqlParameter();
                partipo_comprobante.ParameterName = "@TipoComprobante";
                partipo_comprobante.SqlDbType = SqlDbType.VarChar;
                partipo_comprobante.Value = ingreso.Tipo_comprobante;
                sqlcmd.Parameters.Add(partipo_comprobante);


                SqlParameter parestado = new SqlParameter();
                parestado.ParameterName = "@estado";
                parestado.SqlDbType = SqlDbType.VarChar;
                parestado.Value = ingreso.Estado;
                sqlcmd.Parameters.Add(parestado);

                rpt = sqlcmd.ExecuteNonQuery() == 1 ? "OK" : "No se ingreso el registro";
                

                if (rpt.Equals("OK"))
                {
                    this.IDINGRESO = Convert.ToInt16(sqlcmd.Parameters["@Idcompra"].Value);//revisando

                    foreach (DDetalle_Ingreso det in detalle)
                    {
                        det.IDINGRESODETE = this.IDINGRESO;//AQUI PUEDE ESTAR EL PROBLEMA

                        rpt = det.Insertar_detalleingreso(det, ref sqlcon, ref sqlt);

                        if (!rpt.Equals("OK"))
                            break;
                    }

                }
                sqlcmd.Parameters.Clear();
                if (rpt.Equals("OK"))
                {
                    sqlt.Commit();//confirmar la transaccion
                }
                else
                {
                    sqlt.Rollback();//Denegar la transaccion
                }

                sqlcmd.Parameters.Clear();
            }


            catch (Exception ex)
            {
                rpt = ex.Message + "error en el ingreso";
            }
            finally
            {
                if (sqlcon.State == ConnectionState.Open)
                    sqlcon.Close();
            }
            
            return rpt;


        }//Fin metodo

        public string Anular_ingreso(DIngreso ingreso)
        {

            string rpt = " ";
            SqlConnection sqlcon = new SqlConnection();

            try
            {

                sqlcon.ConnectionString = CConexion.Cn;
                sqlcon.Open();


                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.Connection = sqlcon;
                sqlcmd.CommandText = "spanular_ingreso";
                sqlcmd.CommandType = CommandType.StoredProcedure;

                SqlParameter paridingreso = new SqlParameter();
                paridingreso.ParameterName = "@Idcompra";
                paridingreso.SqlDbType = SqlDbType.Int;
                paridingreso.Value = ingreso.IDINGRESO;
                sqlcmd.Parameters.Add(paridingreso);

                rpt = sqlcmd.ExecuteNonQuery() == 1 ? "Ok" : "No se modifico el registro";
                sqlcmd.Parameters.Clear();
            }


            catch (Exception ex)
            {
                rpt = ex.Message;
            }
            finally
            {
                if (sqlcon.State == ConnectionState.Open)
                    sqlcon.Close();
            }


            return rpt;


        }//Fin metodo


        public DataTable Mostrar()
        {

            DataTable t_resultado = new DataTable("ingreso");
            SqlConnection sqlcon = new SqlConnection();

            try
            {
                sqlcon.ConnectionString = CConexion.Cn;

                SqlCommand sqlcmd = new SqlCommand();

                sqlcmd.Connection = sqlcon;
                sqlcmd.CommandText = "spmostrar_ingreso";
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
        public DataTable Buscarxfecha_ingreso(string f01,string f02)
        {

            DataTable t_resultado = new DataTable("ingreso");
            SqlConnection sqlcon = new SqlConnection();

            try
            {
                sqlcon.ConnectionString = CConexion.Cn;

                SqlCommand sqlcmd = new SqlCommand();

                sqlcmd.Connection = sqlcon;
                sqlcmd.CommandText = "buscar_ingresoxfecha";
                sqlcmd.CommandType = CommandType.StoredProcedure;

                SqlParameter parnombre_buscar1 = new SqlParameter();
                parnombre_buscar1.ParameterName = "@txtbuscar";
                parnombre_buscar1.SqlDbType = SqlDbType.VarChar;
                parnombre_buscar1.Size = 20;
                parnombre_buscar1.Value = f01;
                sqlcmd.Parameters.Add(parnombre_buscar1);

                SqlParameter parnombre_buscar2 = new SqlParameter();
                parnombre_buscar2.ParameterName = "@txtbuscar02";
                parnombre_buscar2.SqlDbType = SqlDbType.VarChar;
                parnombre_buscar2.Size = 20;
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


        public DataTable Mostrar_detalleingreso(int idbuscar)
        {

            DataTable t_resultado = new DataTable("ingreso");
            SqlConnection sqlcon = new SqlConnection();

            try
            {
                sqlcon.ConnectionString = CConexion.Cn;

                SqlCommand sqlcmd = new SqlCommand();

                sqlcmd.Connection = sqlcon;
                sqlcmd.CommandText = "spmostrar_detalleingreso";
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




    }//fin class

}//fin namespace
