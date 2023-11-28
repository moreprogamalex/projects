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
   public class NGenerarFactura
    {
        public  DataTable MostrarFactura(int idventa)
        {
            DGenerarFactura obj = new DGenerarFactura();
            obj.Idventa = idventa;

            return obj.Factura(obj);
        }
    }//fin class
}
