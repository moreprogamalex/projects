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
    public partial class frmVistaCliente_venta : Form
    {
        private void Mostrar()
        {
            datos_clientes.DataSource = NCliente.Mostrar();
           
        }
        public frmVistaCliente_venta()
        {
            InitializeComponent();
        }

        private void frmVistaCliente_venta_Load(object sender, EventArgs e)
        {
            Mostrar();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
           

                this.datos_clientes.DataSource = NCliente.Buscar_xapellido(this.textBox_buscar.Text);

            
        }

        private void datos_clientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmVenta f = frmVenta.get_instancia();
            int id = 0;
            string nombre = string.Empty;

            id = Convert.ToInt16(this.datos_clientes.CurrentRow.Cells["idcliente"].Value);
            nombre = this.datos_clientes.CurrentRow.Cells["Nombres"].Value.ToString()+ this.datos_clientes.CurrentRow.Cells["Apellidos"].Value.ToString();

            f.obtener_cliente(id, nombre);

            this.Hide();
        }

        private void textBox_buscar_TextChanged(object sender, EventArgs e)
        {
            this.btn_buscar_Click(sender, e);
        }

    }
}
