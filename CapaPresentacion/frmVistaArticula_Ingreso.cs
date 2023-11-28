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
    public partial class frmVistaArticula_Ingreso : Form
    {
        private void Mostrar()
        {
            datos_articulos.DataSource = NArticulo.Mostrar_Datos();
            this.lbl_total.Text = this.datos_articulos.Rows.Count.ToString();

        }
        private void Buscar_Nombre()
        {
            datos_articulos.DataSource = NArticulo.Buscar_nombre(this.textBox_buscar.Text);
            this.lbl_total.Text = datos_articulos.Rows.Count.ToString();
        }

        public frmVistaArticula_Ingreso()
        {
            InitializeComponent();
        }

        private void frmVistaArticula_Ingreso_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;

          
            this.Mostrar();

        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            this.Buscar_Nombre();
        }

        private void Evento2click(object sender, DataGridViewCellEventArgs e)
        {
            frmIngreso f = frmIngreso.Obtener_instancia();
            string txt_no, id;

            txt_no = datos_articulos.CurrentRow.Cells["Producto"].Value.ToString();
            id = datos_articulos.CurrentRow.Cells["ID"].Value.ToString();

            f.SetArticulo(txt_no,id);

            this.Hide();
        }


    }//fin class

}//fin namespace
