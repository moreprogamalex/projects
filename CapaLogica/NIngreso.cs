using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using CapaDato;

namespace CapaLogica
{
    public class NIngreso
    {
        public static string Insertar(int idtrabajador,int idproveedor,DateTime fecha,string tipo_comprobante,
            string estado, DataTable dtdetalle)
        {
            DIngreso obj = new DIngreso();
            obj.IDTRABAJADOR = idtrabajador;
            obj.IDPROVEEDOR = idproveedor;
            obj.Fecha = fecha;
            obj.Tipo_comprobante = tipo_comprobante;
            obj.Estado = estado;

            List<DDetalle_Ingreso> detalle = new List<DDetalle_Ingreso>();

            foreach(DataRow r in dtdetalle.Rows)
            {
                DDetalle_Ingreso aux_detella = new DDetalle_Ingreso();
                aux_detella.IDARTICULO = Convert.ToInt16(r["Idproducto"].ToString());
                aux_detella.Precio_compra = Convert.ToDecimal(r["PrecioCompra"].ToString());
                aux_detella.Precio_venta = Convert.ToDecimal(r["PrecioVenta"].ToString());
                aux_detella.Stock_inicial = Convert.ToInt16(r["StockInicial"].ToString());
                aux_detella.Stock_actual = Convert.ToInt16(r["StockInicial"].ToString());
                aux_detella.Fecha_produccion = Convert.ToDateTime(r["FechaProduccion"].ToString());
                aux_detella.Fecha_vencimiento = Convert.ToDateTime(r["FechaVencimiento"].ToString());
                detalle.Add(aux_detella);
            }

            return obj.Insertar_ingreso(obj, detalle);
        }//fin metodo


        public static string Anular(int idingreso)
        {
            DIngreso obj = new DIngreso();

            obj.IDINGRESO= idingreso;

            return obj.Anular_ingreso(obj);

        }//Fin metodo

        public static DataTable Mostrar() { return new DIngreso().Mostrar(); }//fin metodo

        public static DataTable Buscarxfecha_elingreso(string txtf01, string txtf02)
        {
            return new DIngreso().Buscarxfecha_ingreso(txtf01, txtf02);

        }//fin metodo

        public static DataTable Mostrar_eldetalle(int txtf01)
        {
            return new DIngreso().Mostrar_detalleingreso(txtf01);

        }//fin metodo

    }//fin class

}//fin namespace
