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
    public partial class frmCliente : Form
    {
        public frmCliente()
        {
            InitializeComponent();
        }

        private void Mostrar()
        {
            datos_clientes.DataSource = NCliente.Mostrar();
            datos_clientes.Columns[0].Visible = false;
            datos_clientes.Columns[1].Visible = false;
            this.lbl_totalregistros.Text = datos_clientes.Rows.Count.ToString();
        }
        private void Limpiar_cajastexto()
        {
            this.textBox_id.Clear();
            this.textBox_nombre.Clear();
            this.textBox_apellidos.Clear();
            this.textBox_direccion.Clear();
            this.textBox_sexo.Clear();

        }

        private void frmCliente_Load(object sender, EventArgs e)
        {
            StartPosition = FormStartPosition.CenterScreen;
            Mostrar();
        }

        private void textBox_buscar_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
        
                this.datos_clientes.DataSource = NCliente.Buscar_xapellido(this.textBox_buscar.Text);
                lbl_totalregistros.Text = this.datos_clientes.Rows.Count.ToString();
            
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            DialogResult opcion;
            opcion = MessageBox.Show("Deseas eliminar el registro?", "Sistema de Ventas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            string codigo = "";
            string rpt = "";

            if (opcion == DialogResult.OK)
            {
                foreach (DataGridViewRow row in this.datos_clientes.Rows)
                {
                    if (Convert.ToBoolean(row.Cells[0].Value))
                    {
                        codigo = Convert.ToString(row.Cells[1].Value);
                        rpt = NCliente.Eliminar(Convert.ToInt16(codigo));
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

        private void checkBox_eliminar_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBox_eliminar.Checked)
            {
                this.datos_clientes.Columns[0].Visible = true;
            }
            else
            {
                this.datos_clientes.Columns[0].Visible = false;
            }
        }

        private void datos_clientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.textBox_id.ReadOnly = true;
            this.textBox_id.Text = this.datos_clientes.CurrentRow.Cells["Idcliente"].Value.ToString();
            this.textBox_nombre.Text = this.datos_clientes.CurrentRow.Cells["Nombres"].Value.ToString();
            this.textBox_apellidos.Text = this.datos_clientes.CurrentRow.Cells["Apellidos"].Value.ToString();
            this.textBox_sexo.Text = this.datos_clientes.CurrentRow.Cells["Sexo"].Value.ToString();
            this.textBox_direccion.Text = this.datos_clientes.CurrentRow.Cells["Direccion"].Value.ToString();

            this.tabControl_principal.SelectedIndex = 1;
        }

        private void datos_clientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == this.datos_clientes.Columns["Eliminar"].Index)
            {
                DataGridViewCheckBoxCell chkeliminar = (DataGridViewCheckBoxCell)datos_clientes.Rows[e.RowIndex].Cells["Eliminar"];
                chkeliminar.Value = !Convert.ToBoolean(chkeliminar.Value);
            }
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(NCliente.Insertar(this.textBox_nombre.Text, this.textBox_apellidos.Text, this.textBox_sexo.Text,
                 this.textBox_direccion.Text
               ), "Sistema venta", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Limpiar_cajastexto();
            Mostrar();
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            this.textBox_id.ReadOnly = true;

            MessageBox.Show(NCliente.Editar(Convert.ToInt16(this.textBox_id.Text), this.textBox_nombre.Text, this.textBox_apellidos.Text, this.textBox_sexo.Text,
              this.textBox_direccion.Text
            ), "Sistema venta", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Limpiar_cajastexto();
            Mostrar();
        }

        private void textBox_buscar_TextChanged_1(object sender, EventArgs e)
        {
            this.datos_clientes.DataSource = NCliente.Buscar_xapellido(this.textBox_buscar.Text);
            lbl_totalregistros.Text = this.datos_clientes.Rows.Count.ToString();
        }

        private void btn_refrescar_Click(object sender, EventArgs e)
        {
            this.Mostrar();
        }
    }//Fin class


}//Fin namespace
