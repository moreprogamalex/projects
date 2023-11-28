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
    public class NCategoria
    {

        public static string Insertar(string nombre, string descripcion)
        {
            DCategoria obj = new DCategoria();

            obj.Nombre = nombre;
            obj.Descripcion = descripcion;

            return obj.Insertar(obj);

        }//Fin metodo

        public static string Editar(int idcategoria,string nombre, string descripcion)
        {
            DCategoria obj = new DCategoria();

            obj._Idcategoria = idcategoria;
            obj.Nombre = nombre;
            obj.Descripcion = descripcion;

            return obj.Editar(obj);

        }//Fin metodo


        public static string Eliminar(int idcategoria)
        {
            DCategoria obj = new DCategoria();

            obj._Idcategoria = idcategoria;

            return obj.Eliminar(obj);

        }//Fin metodo

        public static DataTable Mostrar() { return new DCategoria().Mostrar(); }//fin metodo

        public static DataTable Buscar_nombre(string nombre_buscar) {

            DCategoria obj = new DCategoria();
            obj.Textobuscar = nombre_buscar;

            return obj.Buscar_nombre(obj);
        
        }//fin metodo

    }//Fin class


}
