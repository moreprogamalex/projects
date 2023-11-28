using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using CapaDato;

namespace CapaLogica
{
    public class NVenta
    {

        public static string Insertar(int idcliente,int idtrabajador, DateTime fecha, string tipo_comprobante,
 DataTable dtdetalle)
        {
            DVenta obj = new DVenta();
            obj.Idtrabajador = idtrabajador;
            obj.Fecha = fecha;
            obj.Idcliente = idcliente;
            obj.Tipo_Comprobante = tipo_comprobante;

            List<DDetalle_venta> detalle = new List<DDetalle_venta>();

            foreach (DataRow r in dtdetalle.Rows)
            {
                DDetalle_venta aux_detella = new DDetalle_venta();
                //aux_detella.Iddetalle_venta = Convert.ToInt16(r["iddetalle_venta"].ToString());
                aux_detella.Iddetalle_ingreso = Convert.ToInt16(r["IdDetalleCompra"].ToString());
                aux_detella.Cantidad = Convert.ToInt16(r["Cantidad"].ToString());
                aux_detella.Precio_Venta = Convert.ToDecimal(r["PrecioVenta"].ToString());
                aux_detella.Descuento = Convert.ToDecimal(r["Descuento%"].ToString());
                //aux_detella.Idventa = Convert.ToInt16(r["idventa"].ToString());
                detalle.Add(aux_detella);
            }

            return obj.Insertar(obj, detalle);
        }//fin metodo


        public static string Eliminar_venta(int idventa)
        {
            DVenta obj = new DVenta();

            obj.Idventa= idventa;

            return obj.Eliminar(obj);

        }//Fin metodo

        public static DataTable Mostrar() { return new DVenta().Mostrar_venta(); }//fin metodo

        public static DataTable Buscarxfecha_laventa(string txtf01, string txtf02)
        {
            return new DVenta().Buscarxfecha_venta(txtf01, txtf02);

        }//fin metodo

        public static DataTable Mostrar_eldetalle(int txtf01)
        {
            return new DVenta().Mostrar_detalleventa(txtf01);

        }//fin metodo

        public static DataTable Mostrar_articuloventaNom(string txtf01)
        {
            return new DVenta().Mostrar_articulo_ventaxnombre(txtf01);

        }//fin metodo

        public static DataTable Mostrar_VistaArticuloVenta()
        {
            return new DVenta().Mostrar_articulo_vistaventa();
        }

    }//fin class

}//fin namespace
