using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using CapaDato;


namespace CapaLogica
{
    public class NCliente
    {
        static public string Insertar(string nombre, string apellidos, string sexo,
           string direccion)
        {
            DCliente obj = new DCliente();

            obj.Nombre = nombre;
            obj.Apellidos = apellidos;
            obj.Sexo = sexo;
            obj.Direccion = direccion;

            return obj.spInsertar(obj);

        }//fin metodo

        static public string Editar(int idcliente,string nombre, string apellidos, string sexo,
                  string direccion)
        {
            DCliente obj = new DCliente();

            obj.IDCLIENTE = idcliente;
            obj.Nombre = nombre;
            obj.Apellidos = apellidos;
            obj.Sexo = sexo;
            obj.Direccion = direccion;


            return obj.spEditar(obj);

        }//fin metodo


        static public string Eliminar(int idcliente)
        {
            DCliente obj = new DCliente();

            obj.IDCLIENTE = idcliente;

            return obj.Eliminar(obj);
        }//fin metodo

        static public DataTable Mostrar()
        {
            return new DCliente().Mostrar();


        }

        static public DataTable Buscar_xapellido(string nombre_full)
        {
            DCliente obj = new DCliente();
            obj.Txtbuscador_nombrefull = nombre_full;
            return obj.spBuscar_apellido(obj);
        }

  

    }//Fin clase


}//fin namespace
