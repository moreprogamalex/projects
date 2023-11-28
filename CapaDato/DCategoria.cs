using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data; //Para trabajar con datos tipo sql server
using System.Data.SqlClient; //para trabajar con los comandos que permiten trabajar con la Base de Datos


namespace CapaDato
{
   public class DCategoria
    {
        private int _idcategoria;
        private string nombre;
        private string descripcion;


        private string textobuscar;

       //Inicio propiedades
       public int _Idcategoria
        {
           get{
               return _idcategoria;
           }
            set
            {
                _idcategoria = value;
            }
        }
       public string Nombre
       {
           get { return nombre; }
           set { nombre = value; }
       }
       public string Descripcion
       {
           get { return descripcion; }
           set { descripcion = value; }
       }
       public string Textobuscar
       {
           get { return textobuscar; }
           set { textobuscar = value; }
       }

       public DCategoria()//Constructor
       { }
       public DCategoria(int idcategoria, string nombre, string descripcion,string textobuscar)//constructor
       {
           this._Idcategoria = idcategoria;
           this.Nombre = nombre;
           this.Descripcion = descripcion;
           this.Textobuscar= textobuscar;
       }


       //Metodos que se conectan con los procedimientos almacenados de la bd

       public string Insertar(DCategoria categoria) {
           string rpt = " ";
           SqlConnection sqlcon = new SqlConnection();//Para establecer la conexion

           try {

               sqlcon.ConnectionString = CConexion.Cn;//Enviamos nuestras coordenadas o cadena de conexion
               sqlcon.Open();//Abrimos las bd

               //Establecer comandos
               SqlCommand sqlcmd = new SqlCommand();//Para trabajr con sql server desde comandos
               sqlcmd.Connection = sqlcon;
               sqlcmd.CommandText = "spinsetar_categoria";
               sqlcmd.CommandType = CommandType.StoredProcedure;

               SqlParameter paridcategoria = new SqlParameter();
               paridcategoria.ParameterName = "@idcategoria";
               paridcategoria.SqlDbType = SqlDbType.Int;
               paridcategoria.Direction = ParameterDirection.Output;
               sqlcmd.Parameters.Add(paridcategoria);

               SqlParameter parnombre = new SqlParameter();
               parnombre.ParameterName = "@nombre";
               parnombre.SqlDbType = SqlDbType.VarChar;
               parnombre.Size = 50;
               parnombre.Value = categoria.Nombre;
               sqlcmd.Parameters.Add(parnombre);

               SqlParameter pardescripcion = new SqlParameter();
               pardescripcion.ParameterName = "@descripcion";
               pardescripcion.SqlDbType = SqlDbType.VarChar;
               pardescripcion.Size = 250;
               pardescripcion.Value = categoria.Descripcion;
               sqlcmd.Parameters.Add(pardescripcion);


               //Ejecutamos nuestro comando sqlcmd

               rpt = sqlcmd.ExecuteNonQuery() == 1 ? "OK" : "No se ingreso el registro";


           
           }


           catch (Exception ex){
               rpt = ex.Message;
           }
           finally
           {
               if(sqlcon.State == ConnectionState.Open)
                   sqlcon.Close();
           }
          

           return rpt;


       }//Fin metodo
       public string Editar(DCategoria categoria) {

           string rpt = " ";
           SqlConnection sqlcon = new SqlConnection();

           try
           {

               sqlcon.ConnectionString = CConexion.Cn;
               sqlcon.Open();

             
               SqlCommand sqlcmd = new SqlCommand();
               sqlcmd.Connection = sqlcon;
               sqlcmd.CommandText = "speditar_categoria";
               sqlcmd.CommandType = CommandType.StoredProcedure;

               SqlParameter paridcategoria = new SqlParameter();
               paridcategoria.ParameterName = "@idcategoria";
               paridcategoria.SqlDbType = SqlDbType.Int;
               paridcategoria.Value = categoria._Idcategoria;
               sqlcmd.Parameters.Add(paridcategoria);

               SqlParameter parnombre = new SqlParameter();
               parnombre.ParameterName = "@nombre";
               parnombre.SqlDbType = SqlDbType.VarChar;
               parnombre.Size = 50;
               parnombre.Value = categoria.Nombre;
               sqlcmd.Parameters.Add(parnombre);

               SqlParameter pardescripcion = new SqlParameter();
               pardescripcion.ParameterName = "@descripcion";
               pardescripcion.SqlDbType = SqlDbType.VarChar;
               pardescripcion.Size = 250;
               pardescripcion.Value = categoria.Descripcion;
               sqlcmd.Parameters.Add(pardescripcion);


             

               rpt = sqlcmd.ExecuteNonQuery() == 1 ? "Ok" : "No se actualizo el registro";



           }


           catch (Exception ex)
           {
               rpt = ex.Message;
           }
           finally
           {
               if (sqlcon.State == ConnectionState.Open)
                   sqlcon.Close();
           }


           return rpt;


       }//Fin metodo
       public string Eliminar(DCategoria categoria) {

           string rpt = " ";
           SqlConnection sqlcon = new SqlConnection();

           try
           {

               sqlcon.ConnectionString = CConexion.Cn;
               sqlcon.Open();


               SqlCommand sqlcmd = new SqlCommand();
               sqlcmd.Connection = sqlcon;
               sqlcmd.CommandText = "speliminar_categoria";
               sqlcmd.CommandType = CommandType.StoredProcedure;

               SqlParameter paridcategoria = new SqlParameter();
               paridcategoria.ParameterName = "@idcategoria";
               paridcategoria.SqlDbType = SqlDbType.Int;
               paridcategoria.Value = categoria._Idcategoria;
               sqlcmd.Parameters.Add(paridcategoria);

               rpt = sqlcmd.ExecuteNonQuery() == 1 ? "Ok" : "No se elimino el registro";

           }


           catch (Exception ex)
           {
               rpt = ex.Message;
           }
           finally
           {
               if (sqlcon.State == ConnectionState.Open)
                   sqlcon.Close();
           }


           return rpt;
       
       
       }//Fin metodo
       public DataTable Mostrar() {

           DataTable t_resultado = new DataTable("categoria");
           SqlConnection sqlcon = new SqlConnection();

           try
           {
               sqlcon.ConnectionString = CConexion.Cn;

               SqlCommand sqlcmd = new SqlCommand();

               sqlcmd.Connection = sqlcon;
               sqlcmd.CommandText = "spmostrar_categoria";
               sqlcmd.CommandType = CommandType.StoredProcedure;


               SqlDataAdapter sqldat = new SqlDataAdapter(sqlcmd);
               sqldat.Fill(t_resultado);
           }
           catch (Exception ex)
           {

               t_resultado = null;

           }

           return t_resultado;

       }//Fin metodo

       public DataTable Buscar_nombre(DCategoria categoria) {

           DataTable t_resultado = new DataTable("categoria");
           SqlConnection sqlcon = new SqlConnection();

           try
           {
               sqlcon.ConnectionString = CConexion.Cn;

               SqlCommand sqlcmd = new SqlCommand();

               sqlcmd.Connection = sqlcon;
               sqlcmd.CommandText = "spbuscar_categoria";
               sqlcmd.CommandType = CommandType.StoredProcedure;

               SqlParameter parnombre_buscar = new SqlParameter();
               parnombre_buscar.ParameterName = "@txt_buscar";
               parnombre_buscar.SqlDbType = SqlDbType.VarChar;
               parnombre_buscar.Size = 100;
               parnombre_buscar.Value = categoria.Textobuscar;
               sqlcmd.Parameters.Add(parnombre_buscar);




               SqlDataAdapter sqldat = new SqlDataAdapter(sqlcmd);
               sqldat.Fill(t_resultado);
           }
           catch (Exception ex)
           {

               t_resultado = null;

           }

           return t_resultado;
       
       
      
       
       }//Fin metodo


    }//fin clases DCategoria


}
