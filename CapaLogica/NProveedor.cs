using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDato;
using System.Data;

namespace CapaLogica
{
    public class NProveedor
    {
        static public string Insertar(string sector_comercial,
            string direccion, string telefono, string empresaa, string sitiowebb)
        {
            DProveedor obj = new DProveedor();

            obj.Sector_comercial = sector_comercial;
            obj.Direccion = direccion;
            obj.Telefono = telefono;
            obj.Empresa = empresaa;
            obj.Sitioweb= sitiowebb;

            return obj.spInsertar(obj);

        }//fin metodo


        static public string Editar(int idproveedor,string sector_comercial,
            string direccion, string telefono, string empresa, string url)
        {
            DProveedor obj = new DProveedor();

            obj.IDPROVEEDOR = idproveedor;
            obj.Sector_comercial = sector_comercial;
            obj.Direccion = direccion;
            obj.Telefono = telefono;
            obj.Empresa = empresa;
            obj.Sitioweb = url;

            return obj.spEditar(obj);

        }//fin metodo

        static public string Eliminar(int idproveedor)
        {
            DProveedor obj = new DProveedor();

            obj.IDPROVEEDOR = idproveedor;

            return obj.Eliminar(obj);
        }//fin metodo

        static public DataTable Mostrar()
        {
          return new DProveedor().Mostrar();

         
        }

        static public DataTable Buscar_sectorcomercial(string texto)
        {
            DProveedor obj = new DProveedor();
            obj.Sector_comercial= texto;

            return obj.spBuscar_sectorcomercial(obj);
        }

        static public DataTable Buscar_porempresa(string texto)
        {
            DProveedor obj = new DProveedor();
            obj.Empresa= texto;

            return obj.spBuscar_nomempresa(obj);
        }

    }//fin clase

}//fin nombre de espacio
