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
    public partial class frmTrabajador : Form
    {
        public frmTrabajador()
        {
            InitializeComponent();
        }
        private void Mostrar()
        {
            datos_trabajador.Columns[0].Visible = false;
            datos_trabajador.DataSource = NTrabajador.Mostrar();
            this.lbl_totalregistros.Text = datos_trabajador.Rows.Count.ToString();
        }
        private void Limpiar_cajastexto()
        {
            this.textBox_id.Clear();
            this.textBox_nombre.Clear();
            this.textBox_apellidos.Clear();
            this.textBox_edad.Clear();
            this.textBox_direccion.Clear();
            this.textBox_telf.Clear();
            this.textBox_sexo.Clear();
            this.textBox_usuario.Clear();
            this.textBox_password.Clear();
            this.textBox_edad.Clear();
            this.txtbox_cedula.Clear();
        }

        private void frmTrabajador_Load(object sender, EventArgs e)
        {
            StartPosition = FormStartPosition.CenterParent;
            Mostrar();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
     

                this.datos_trabajador.DataSource = NTrabajador.Buscar_empleado(this.textBox_buscar.Text);
                lbl_totalregistros.Text = this.datos_trabajador.Rows.Count.ToString();
            
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            DialogResult opcion;
            opcion = MessageBox.Show("Deseas eliminar el registro?", "Sistema de Ventas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            string codigo = "";
            string rpt = "";

            if (opcion == DialogResult.OK)
            {
                foreach (DataGridViewRow row in this.datos_trabajador.Rows)
                {
                    if (Convert.ToBoolean(row.Cells[0].Value))
                    {
                        codigo = Convert.ToString(row.Cells[1].Value);
                        rpt = NTrabajador.Eliminar(Convert.ToInt16(codigo));
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
                this.datos_trabajador.Columns[0].Visible = true;
            }
            else
            {
                this.datos_trabajador.Columns[0].Visible = false;
            }
        }

        private void datos_trabajador_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.textBox_id.ReadOnly = true;
            this.textBox_id.Text = this.datos_trabajador.CurrentRow.Cells["IdEmpleado"].Value.ToString();
            this.textBox_nombre.Text = this.datos_trabajador.CurrentRow.Cells["Nombres"].Value.ToString();
            this.textBox_apellidos.Text = this.datos_trabajador.CurrentRow.Cells["Apellidos"].Value.ToString();
            this.textBox_sexo.Text = this.datos_trabajador.CurrentRow.Cells["Sexo"].Value.ToString();
            this.textBox_direccion.Text = this.datos_trabajador.CurrentRow.Cells["Direccion"].Value.ToString();
            this.textBox_telf.Text = this.datos_trabajador.CurrentRow.Cells["Telefono"].Value.ToString();
            this.textBox_edad.Text = this.datos_trabajador.CurrentRow.Cells["Edad"].Value.ToString();
            this.textBox_usuario.Text = this.datos_trabajador.CurrentRow.Cells["Usuario"].Value.ToString();
            this.textBox_password.Text = this.datos_trabajador.CurrentRow.Cells["Contraseña"].Value.ToString();
            this.txtbox_cedula.Text = this.datos_trabajador.CurrentRow.Cells["NoCedula"].Value.ToString();
            this.tabControl_principal.SelectedIndex = 1;
        }

        private void datos_trabajador_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == this.datos_trabajador.Columns["Eliminar"].Index)
            {
                DataGridViewCheckBoxCell chkeliminar = (DataGridViewCheckBoxCell)datos_trabajador.Rows[e.RowIndex].Cells["Eliminar"];
                chkeliminar.Value = !Convert.ToBoolean(chkeliminar.Value);
            }
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(NTrabajador.Insertar(this.textBox_nombre.Text, this.textBox_apellidos.Text, this.textBox_sexo.Text,
                this.textBox_direccion.Text, this.textBox_telf.Text
              ,this.comboBox_acceso.Text,this.textBox_usuario.Text
             ,this.textBox_password.Text, this.txtbox_cedula.Text,Convert.ToInt16(this.textBox_edad.Text)), "Sistema venta", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Limpiar_cajastexto();
            Mostrar();
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(NTrabajador.Editar(Convert.ToInt16(this.textBox_id.Text), this.textBox_nombre.Text, this.textBox_apellidos.Text, this.textBox_sexo.Text,
                this.textBox_direccion.Text, this.textBox_telf.Text
              , this.comboBox_acceso.Text, this.textBox_usuario.Text
             , this.textBox_password.Text, this.txtbox_cedula.Text, Convert.ToInt16(this.textBox_edad.Text)), "Sistema venta", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Limpiar_cajastexto();
            Mostrar();
        }

        private void textBox_buscar_TextChanged(object sender, EventArgs e)
        {
            this.datos_trabajador.DataSource= this.datos_trabajador.DataSource = NTrabajador.Buscar_empleado(this.textBox_buscar.Text);
            lbl_totalregistros.Text = this.datos_trabajador.Rows.Count.ToString();
        }

        private void btn_refrescar_Click(object sender, EventArgs e)
        {
            this.Mostrar();
        }
    }//fin calss

}//fina namespace
