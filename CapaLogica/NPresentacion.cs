using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDato;
using System.Data;

namespace CapaLogica
{
    public class NPresentacion
    {
        public static string Insertar(string nombre, string descripcion)
        {
            DPresentacion obj = new DPresentacion();

            obj.Nombre = nombre;
            obj.Descripcion = descripcion;

            return obj.Insertar(obj);

        }//Fin clase
        public static string Editar(int idpresentacion, string nombre, string descripcion)
        {
            DPresentacion obj = new DPresentacion();

            obj.IDPRESENTACION = idpresentacion;
            obj.Nombre = nombre;
            obj.Descripcion = descripcion;

            return obj.Editar(obj);

        }//Fin metodo

        public static string Eliminar(int idpresentacion){
            DPresentacion obj = new DPresentacion();
            obj.IDPRESENTACION = idpresentacion;

            return obj.Eliminar(obj);
        }//fin metodo

        public static DataTable Mostrar() { return new DPresentacion().Mostrar(); }
        public static DataTable Buscar_nombre(string nombre_buscar){

            DPresentacion obj = new DPresentacion();

            obj.Texto_buscar = nombre_buscar;

            return obj.Buscar_nombre(obj);

        }//fin metodo


    }//fin clase


}//Fin namespace 
