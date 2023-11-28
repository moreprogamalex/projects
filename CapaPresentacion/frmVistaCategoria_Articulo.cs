using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaLogica;

namespace CapaPresentacion
{
    public partial class frmVistaCategoria_Articulo : Form
    {
       
        public frmVistaCategoria_Articulo()
        {
            InitializeComponent();
        }
        private void Mostrar()
        {
            this.data_Listado.DataSource = NCategoria.Mostrar();
            this.lbl_Total_Registro.Text = "Total de registro: " + Convert.ToString(data_Listado.Rows.Count);
        }

        private void BuscarNombre()
        {
            this.data_Listado.DataSource = NCategoria.Buscar_nombre(this.textBox_buscar.Text);
            this.lbl_Total_Registro.Text = "Total de registro: " + Convert.ToString(data_Listado.Rows.Count);
        }

        private void frmVistaCategoria_Articulo_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            this.Mostrar();
            this.data_Listado.Columns[0].Visible = false;
        }

        private void textBox_buscar_TextChanged(object sender, EventArgs e)
        {
            this.BuscarNombre();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            this.BuscarNombre();
        }

        private void data_Listado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmArticulo form = frmArticulo.getinstancia();
            string id, txt_nombre;

            id = this.data_Listado.CurrentRow.Cells["Idcategoria"].Value.ToString();
            txt_nombre = this.data_Listado.CurrentRow.Cells["Nombre"].Value.ToString();

            form.RellenarCategoria(Convert.ToInt16(id), txt_nombre);
            this.Hide();
        }



    }//Fin clases

}//Fin namespace
