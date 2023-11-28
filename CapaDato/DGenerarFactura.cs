using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CapaDato
{
    public class DGenerarFactura
    {
        private int idventa;
        private float total;

        public int Idventa { get => idventa; set => idventa = value; }
        public float Total { get => total; set => total = value; }

        public DataTable Factura(DGenerarFactura obj)
        {
            SqlConnection cadena_conexion = new SqlConnection();
            DataTable tabla_resultado = new DataTable("tabla");

            try
            {
                SqlCommand comando = new SqlCommand();
                cadena_conexion.ConnectionString = CConexion.Cn;
                comando.Connection = cadena_conexion;

                comando.CommandText = "spreporte_factura";
                comando.CommandType = CommandType.StoredProcedure;

                SqlParameter pariddeventa = new SqlParameter();
                pariddeventa.ParameterName = "@idventa";
                pariddeventa.SqlDbType = SqlDbType.Int;
                pariddeventa.Value = obj.Idventa;
                comando.Parameters.Add(pariddeventa);

                //SqlParameter partotal = new SqlParameter();
                //partotal.ParameterName = "total";
                //partotal.SqlDbType = SqlDbType.Decimal;
                //partotal.Value = obj.Total;
                //comando.Parameters.Add(partotal);



                SqlDataAdapter adaptador = new SqlDataAdapter(comando);

                adaptador.Fill(tabla_resultado);

            }
            catch (Exception ex) { tabla_resultado = null; }

            return tabla_resultado;
        }



    }//fin class

}//fin namespace
