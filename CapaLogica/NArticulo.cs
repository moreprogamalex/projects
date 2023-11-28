using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDato;
using System.Data;
using System.Data.SqlClient;

namespace CapaLogica
{
   public class NArticulo
    {
        public static string Insertar(string nombre, int idcategoria)
        {
            DArticulo obj = new DArticulo();

            obj.Nombre = nombre;
            obj.IDCATEGORIA = idcategoria;
            

            return obj.spInsertar(obj);

        }//Fin metodo
        public static string Editar(int idarticulo,string nombre,  int idcategoria)
        {
            DArticulo obj = new DArticulo();

            obj.IDARTICULO = idarticulo;
            obj.Nombre = nombre;
            
            obj.IDCATEGORIA = idcategoria;
            

            return obj.spEditar(obj);

        }//Fin metodo

        public static string Eliminar(int idarticulo)
        {
            DArticulo obj = new DArticulo();
            obj.IDARTICULO = idarticulo;

            return obj.Eliminar(obj);
        }//fin metodo

        public static DataTable Mostrar_Datos() { return new DArticulo().Mostrar(); }
        public static DataTable Buscar_nombre(string nombre_buscar)
        {

            DArticulo obj = new DArticulo();

            obj.CADENA_BUSQUEDA = nombre_buscar;

            return obj.spBuscar_Articulo(obj);

        }//fin metodo


        public static DataTable Mostrar_stock() { return new DArticulo().Stock_articulo(); }

        public static DataTable Buscar_nombreStock(string nombre_buscar)
        {

            DArticulo obj = new DArticulo();

            obj.CADENA_BUSQUEDA = nombre_buscar;

            return obj.spBuscar_ArticuloStock(obj);

        }//fin metodo

    }//Fin clase



}//Fin namespace
