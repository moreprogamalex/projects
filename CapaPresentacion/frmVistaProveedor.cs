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
    public partial class frmVistaProveedor : Form
    {
        public frmVistaProveedor()
        {
            InitializeComponent();
        }

        private void Mostrar()
        {
            datos_proveedor.DataSource = NProveedor.Mostrar();
            this.lbl_totalregistros.Text = datos_proveedor.Rows.Count.ToString();
        }

        private void frmVistaProveedor_Load(object sender, EventArgs e)
        {
            Mostrar();
      
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            if (this.textBox_opc.Text.ToLower() == "sector comercial")
            {

                this.datos_proveedor.DataSource = NProveedor.Buscar_sectorcomercial(this.textBox_buscar.Text);
                lbl_totalregistros.Text = this.datos_proveedor.Rows.Count.ToString();


            }
            else if (this.textBox_opc.Text.ToLower() == "nombre de empresa")
            {

                this.datos_proveedor.DataSource = NProveedor.Buscar_porempresa(this.textBox_buscar.Text);
                lbl_totalregistros.Text = this.datos_proveedor.Rows.Count.ToString();
            }
        }

        private void datos_proveedor_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmIngreso f = frmIngreso.Obtener_instancia();
            string txt_no, id;

            txt_no = this.datos_proveedor.CurrentRow.Cells["SectorComercial"].Value.ToString();
            id = this.datos_proveedor.CurrentRow.Cells["idproveedor"].Value.ToString();

            f.SetProveedor(txt_no, id);

            this.Hide();
        }







    }//fin class

}//fin namespace
