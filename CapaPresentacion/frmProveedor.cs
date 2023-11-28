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
    public partial class frmProveedor : Form
    {
        public frmProveedor()
        {
            InitializeComponent();
        }

        private void Mostrar()
        {
             datos_proveedor.DataSource= NProveedor.Mostrar();
            datos_proveedor.Columns[0].Visible = false;
            datos_proveedor.Columns[1].Visible = false;
            this.lbl_totalregistros.Text = datos_proveedor.Rows.Count.ToString();
        }
        private void Limpiar_cajastexto()
        {
        
            this.textBox_sitioweb.Clear();
            this.textBox_empresa.Clear();
            this.textBox_direccion.Clear();
            this.textBox_telf.Clear();
            this.textBox_idproveedor.Clear();
        }


        private void frmProveedor_Load(object sender, EventArgs e)
        {
            StartPosition = FormStartPosition.CenterScreen;
            Mostrar();
        }

        private void textBox_buscar_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void checkBox_eliminar_CheckedChanged(object sender, EventArgs e)
        {
            if(this.checkBox_eliminar.Checked)
            {
                this.datos_proveedor.Columns[0].Visible = true;
            }
            else
            {
                this.datos_proveedor.Columns[0].Visible = false;
            }
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            DialogResult opcion;
            opcion = MessageBox.Show("Deseas eliminar el registro?", "Sistema de Ventas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            string codigo = "";
            string rpt = "";

            if (opcion == DialogResult.OK)
            {
                foreach (DataGridViewRow row in this.datos_proveedor.Rows)
                {
                    if (Convert.ToBoolean(row.Cells[0].Value))
                    {
                        codigo = Convert.ToString(row.Cells[1].Value);
                        rpt = NProveedor.Eliminar(Convert.ToInt16(codigo));
                    }
                }


            }

            if (rpt.Equals("Registro Eliminado"))
            {
                MessageBox.Show(rpt, "Sistema Venta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(rpt, "Sistema Venta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            Limpiar_cajastexto();
            Mostrar();
        }

        private void datos_proveedor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == this.datos_proveedor.Columns["Eliminar"].Index)
            {
                DataGridViewCheckBoxCell chkeliminar = (DataGridViewCheckBoxCell)datos_proveedor.Rows[e.RowIndex].Cells["Eliminar"];
                chkeliminar.Value = !Convert.ToBoolean(chkeliminar.Value);
            }
        }

        private void datos_proveedor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.textBox_idproveedor.ReadOnly = true;
            this.textBox_idproveedor.Text = this.datos_proveedor.CurrentRow.Cells["Idproveedor"].Value.ToString();
            this.textBox_sitioweb.Text = this.datos_proveedor.CurrentRow.Cells["SitioWeb"].Value.ToString();
            this.textBox_empresa.Text = this.datos_proveedor.CurrentRow.Cells["Empresa"].Value.ToString();
            this.textBox_direccion.Text = this.datos_proveedor.CurrentRow.Cells["Direccion"].Value.ToString();
            this.textBox_telf.Text = this.datos_proveedor.CurrentRow.Cells["Telefono"].Value.ToString();
            this.comboBox_sectorcomercial.Text = this.datos_proveedor.CurrentRow.Cells["SectorComercial"].Value.ToString();


            this.tabControl_principal.SelectedIndex = 1;
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {

            MessageBox.Show(NProveedor.Insertar(this.comboBox_sectorcomercial.Text,
                this.textBox_direccion.Text,this.textBox_telf.Text,this.textBox_empresa.Text,this.textBox_sitioweb.Text)
                , "Sistema venta", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Limpiar_cajastexto();
            Mostrar();
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            this.textBox_idproveedor.ReadOnly = true;

            MessageBox.Show(NProveedor.Editar(Convert.ToInt16(this.textBox_idproveedor.Text),this.comboBox_sectorcomercial.Text,
                this.textBox_direccion.Text, this.textBox_telf.Text,
               this.textBox_empresa.Text, this.textBox_sitioweb.Text), "Sistema venta", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Limpiar_cajastexto();
            Mostrar();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            if (this.textBox_opc.Text.ToLower()=="sector comercial")
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

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            this.Limpiar_cajastexto();
        }

        private void btn_refrescar_Click(object sender, EventArgs e)
        {
            this.Mostrar();
            this.textBox_buscar.Clear();
            this.textBox_opc.Clear();
        }
    }//fin clases


}//fin namespace
