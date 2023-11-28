using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using CapaDato;

namespace CapaLogica
{
    public class NTrabajador
    {

        static public string Insertar(string nombre, string apellidos, string sexo,
         string direccion, string telefono,string acceso,string usuario,string password,string cedula,int edad)
        {
            DTrabajador obj = new DTrabajador();

            obj.Nombre = nombre;
            obj.Apellidos = apellidos;
            obj.Sexo = sexo;
            obj.Direccion = direccion;
            obj.Telefono = telefono;
            obj.Acceso = acceso;
            obj.Usuario = usuario;
            obj.Password = password;
            obj.Cedula = cedula;
            obj.Edad = edad;

            return obj.spInsertar(obj);

        }//fin metodo

        static public string Editar(int idtrabajador, string nombre, string apellidos, string sexo,
         string direccion, string telefono, string acceso, string usuario, string password, string cedula, int edad)
        {
            DTrabajador obj = new DTrabajador();

            obj.IDTrabajador = idtrabajador;
            obj.Nombre = nombre;
            obj.Apellidos = apellidos;
            obj.Sexo = sexo;
            obj.Direccion = direccion;
            obj.Telefono = telefono;
            obj.Acceso = acceso;
            obj.Usuario = usuario;
            obj.Password = password;
            obj.Cedula = cedula;
            obj.Edad = edad;

            return obj.spEditar(obj);

        }//fin metodo


        static public string Eliminar(int idtrabajador)
        {
            DTrabajador obj = new DTrabajador();

            obj.IDTrabajador= idtrabajador;

            return obj.Eliminar(obj);
        }//fin metodo

        static public DataTable Mostrar()
        {
            return new DTrabajador().Mostrar();

        }

        static public DataTable Buscar_empleado(string nombrecompleto)
        {
            DTrabajador obj = new DTrabajador();
            obj.Txtbuscar= nombrecompleto;
            return obj.spBuscar_trabajador(obj);
        }

    


        static public DataTable Login(string usuario,string password)
        {
            DTrabajador obj = new DTrabajador();
            obj.Usuario = usuario;
            obj.Password = password;

            return obj.spLogin(obj);
        }

    }//fin class

}//fin namespace
