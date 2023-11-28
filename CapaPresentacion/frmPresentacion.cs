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
    public partial class frmPresentacion : Form
    {
        public frmPresentacion()
        {
            InitializeComponent();
        }

        private void Mostrar()
        {
            this.dataGridView_tabla_presentacion.DataSource = NPresentacion.Mostrar();
            this.lbl_total.Text = "Total de registro: " + Convert.ToString(this.dataGridView_tabla_presentacion.Rows.Count);
        }

        private void BuscarNombre()
        {
            this.dataGridView_tabla_presentacion.DataSource = NPresentacion.Buscar_nombre(this.textBox_buscar.Text);
            this.lbl_total.Text = "Total de registro: " + Convert.ToString(this.dataGridView_tabla_presentacion.Rows.Count);
        }
        private void Limpiar_CajasTexto()
        {
            this.textBox_idpre.Clear();
            this.textBox_nombrepre.Clear();
            this.textBox_decripcionpre.Clear();
        }

        private void frmPresentacion_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;

            this.dataGridView_tabla_presentacion.Columns[0].Visible = false;
            this.Mostrar();
        }

        private void dataGridView_tabla_presentacion_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.textBox_idpre.Text = dataGridView_tabla_presentacion.SelectedCells[1].Value.ToString();
            this.textBox_nombrepre.Text = dataGridView_tabla_presentacion.SelectedCells[2].Value.ToString();
            this.textBox_decripcionpre.Text = dataGridView_tabla_presentacion.SelectedCells[3].Value.ToString();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
           string rpt = NPresentacion.Insertar(this.textBox_nombrepre.Text, this.textBox_decripcionpre.Text);
           MessageBox.Show(rpt,"Sistema Venta",MessageBoxButtons.OK,MessageBoxIcon.Information);
           Limpiar_CajasTexto();
           Mostrar();
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            string rpt = NPresentacion.Editar(Convert.ToInt16(this.textBox_idpre.Text), this.textBox_nombrepre.Text, this.textBox_decripcionpre.Text);
            MessageBox.Show(rpt, "Sistema Venta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Limpiar_CajasTexto();
            Mostrar();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            BuscarNombre();
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            DialogResult opcion;
            opcion = MessageBox.Show("Deseas eliminar el registro?", "Sistema de Ventas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (opcion==DialogResult.OK)
            {
                string codigo = "";
                string rpt = "";

                foreach (DataGridViewRow row in dataGridView_tabla_presentacion.Rows)
                {
                    if (Convert.ToBoolean(row.Cells[0].Value))
                    {
                        codigo = Convert.ToString(row.Cells[1].Value);
                        rpt = NPresentacion.Eliminar(Convert.ToInt16(codigo));
                    }

                    if (rpt.Equals("Ok"))
                    {
                        MessageBox.Show("Se elimino correctamente", "Sistema Venta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No se elimino correctamente", "Sistema Venta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }




                }

                
            }
            Mostrar();

        }

        private void checkBox_eliminar_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBox_eliminar.Checked)
            {
                this.dataGridView_tabla_presentacion.Columns[0].Visible = true;
            }
            else
            {
                this.dataGridView_tabla_presentacion.Columns[0].Visible = false;
            }

        }

        private void dataGridView_tabla_presentacion_CellContentClick(object sender, DataGridViewCellEventArgs e)//Evento que permite habilitar el check box para cada fila a selcionar y posteriormente eliminarla
        {

            if (e.ColumnIndex == dataGridView_tabla_presentacion.Columns["Eliminar"].Index)
            {
                DataGridViewCheckBoxCell chkeliminar =  (DataGridViewCheckBoxCell)dataGridView_tabla_presentacion.Rows[e.RowIndex].Cells["Eliminar"];
                chkeliminar.Value = !Convert.ToBoolean(chkeliminar.Value);
            }


        }//fin metodo







    }//Fin calse
}
