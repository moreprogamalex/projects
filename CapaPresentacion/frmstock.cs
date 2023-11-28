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
    public partial class frmstock : Form
    {
        public frmstock()
        {
            InitializeComponent();
        }

        private void frmstock_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = NArticulo.Mostrar_stock();
        }

        private void frmstock_FormClosed(object sender, FormClosedEventArgs e)
        {
           
        }

        private void textBox_buscar_TextChanged(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = NArticulo.Buscar_nombreStock(this.textBox_buscar.Text);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = NArticulo.Buscar_nombreStock(this.textBox_buscar.Text);
        }
    }//fin class

}//fin namespace
