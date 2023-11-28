using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;


namespace CapaDato
{
    public class DDetalle_Ingreso
    {

        private int iddetalleingreso;
        private int idingresodete;

        public int IDINGRESODETE
        {
            get { return idingresodete; }
            set { idingresodete = value; }
        }
        public int IDDETALLEINGRESO
        {
            get { return iddetalleingreso; }
            set { iddetalleingreso = value; }
        }
        private int idarticulo;

        public int IDARTICULO
        {
            get { return idarticulo; }
            set { idarticulo = value; }
        }
        private decimal precio_compra;

        public decimal Precio_compra
        {
            get { return precio_compra; }
            set { precio_compra = value; }
        }
        private decimal precio_venta;

        public decimal Precio_venta
        {
            get { return precio_venta; }
            set { precio_venta = value; }
        }
        private int stock_inicial;

        public int Stock_inicial
        {
            get { return stock_inicial; }
            set { stock_inicial = value; }
        }
        private int stock_actual;

        public int Stock_actual
        {
            get { return stock_actual; }
            set { stock_actual = value; }
        }
        private DateTime fecha_produccion;

        public DateTime Fecha_produccion
        {
            get { return fecha_produccion; }
            set { fecha_produccion = value; }
        }
        private DateTime fecha_vencimiento;

        public DateTime Fecha_vencimiento
        {
            get { return fecha_vencimiento; }
            set { fecha_vencimiento = value; }
        }

        public string Insertar_detalleingreso(DDetalle_Ingreso detalleingreso,ref SqlConnection sqlcon,ref SqlTransaction sqlt)
        {
            string rpt = " ";

            try
            {


                //Establecer comandos
                SqlCommand sqlcmd = new SqlCommand();//Para trabajr con sql server desde comandos
                sqlcmd.Connection = sqlcon;
                sqlcmd.Transaction = sqlt;
                sqlcmd.CommandText = "spinsertar_eldetalleingreso";
                sqlcmd.CommandType = CommandType.StoredProcedure;


                sqlcmd.Parameters.AddWithValue("@Iddetallecompra", ParameterDirection.Output);
                sqlcmd.Parameters.AddWithValue("@Idcompra",this.IDINGRESODETE);
                sqlcmd.Parameters.AddWithValue("@Idarticulo",this.IDARTICULO);
                sqlcmd.Parameters.AddWithValue("@PrecioCompra",this.Precio_compra);
                sqlcmd.Parameters.AddWithValue("@PrecioVenta", this.Precio_venta);
                sqlcmd.Parameters.AddWithValue("@StockInicial", this.Stock_inicial);
                sqlcmd.Parameters.AddWithValue("@StockActual", this.Stock_actual);
                sqlcmd.Parameters.AddWithValue("@FechaProduccion", this.Fecha_produccion);
                sqlcmd.Parameters.AddWithValue("@FechaVencimiento", this.Fecha_vencimiento);

                rpt = sqlcmd.ExecuteNonQuery() == 1 ? "OK" : "No se ingreso el registro";
                sqlcmd.Parameters.Clear();
            }


            catch (Exception ex)
            {
                rpt = ex.Message+"error en el detalle";
            }
            //finally
            //{
            //    if (sqlcon.State == ConnectionState.Open)
            //        sqlcon.Close();
            //}
            
            return rpt;


        }//Fin metodo



    }//Fin class

}//Fin namespace
