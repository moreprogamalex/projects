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
    public partial class frmCategoria : Form
    {
        public frmCategoria()
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
            this.data_Listado.DataSource = NCategoria.Buscar_nombre(this.textBox_Buscar.Text);
            this.lbl_Total_Registro.Text = "Total de registro: " + Convert.ToString(data_Listado.Rows.Count);
        }
        private void Limpiar_TextBox_Presentacion()
        {
            this.textBox_ID.Clear();
            this.textBox_Nombrep.Clear();
            this.textBox_Descripp.Clear();
        }



        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void frmCategoria_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            this.textBox_ID.Enabled = false;
            this.Mostrar();

        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            this.BuscarNombre();
        }

        private void textBox_Buscar_TextChanged(object sender, EventArgs e)
        {
            this.BuscarNombre();
        }


        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(NCategoria.Insertar(textBox_Nombre.Text, textBox_Descripcion.Text),"Sistema Venta",MessageBoxButtons.OK,MessageBoxIcon.Information);
            Mostrar();
            this.textBox_Nombre.Clear();
            this.textBox_Descripcion.Clear();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void data_Listado_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.textBox_ID.Text = data_Listado.SelectedCells[0].Value.ToString();
            this.textBox_Nombrep.Text = data_Listado.SelectedCells[1].Value.ToString();
            this.textBox_Descripp.Text = data_Listado.SelectedCells[2].Value.ToString();
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(NCategoria.Eliminar(Convert.ToInt16(textBox_ID.Text)),"Sistema Venta",MessageBoxButtons.OK,MessageBoxIcon.Information);
            Mostrar();
            Limpiar_TextBox_Presentacion();
        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(NCategoria.Editar(Convert.ToInt16(textBox_ID.Text),textBox_Nombrep.Text,textBox_Descripp.Text), "Sistema Venta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Mostrar();
            Limpiar_TextBox_Presentacion();
        }



    }//Fin class

}//fin namespace
