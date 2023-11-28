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
    public partial class frmVistaArticulo_venta : Form
    {


        public frmVistaArticulo_venta()
        {
            InitializeComponent();
        }

        private void frmVistaArticulo_venta_Load(object sender, EventArgs e)
        {
            this.datos_articulos.DataSource = NVenta.Mostrar_VistaArticuloVenta();
            this.datos_articulos.Columns[0].Visible = false;
        }

        private void textBox_buscar_TextChanged(object sender, EventArgs e)
        {
            

                this.datos_articulos.DataSource = NVenta.Mostrar_articuloventaNom(this.textBox_buscar.Text);

        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
          

                this.datos_articulos.DataSource = NVenta.Mostrar_articuloventaNom(this.textBox_buscar.Text);



            
        }

        private void datos_articulos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmVenta f = frmVenta.get_instancia();
            int iddetalle_ingreso = 0;
            string nombre = string.Empty;
            decimal precio_c, precio_v;
            int stock_actual = 0;
            DateTime fecha_ven;

            iddetalle_ingreso = Convert.ToInt16(this.datos_articulos.CurrentRow.Cells["Iddetallecompra"].Value);
            nombre = this.datos_articulos.CurrentRow.Cells["Articulo"].Value.ToString();
            precio_c = Convert.ToDecimal(this.datos_articulos.CurrentRow.Cells["PrecioCompra"].Value);
            precio_v = Convert.ToDecimal(this.datos_articulos.CurrentRow.Cells["PrecioVenta"].Value);
            stock_actual = Convert.ToInt16(this.datos_articulos.CurrentRow.Cells["StockActual"].Value);
            fecha_ven = Convert.ToDateTime(this.datos_articulos.CurrentRow.Cells["FechaVencimiento"].Value);

            f.obtener_articulo(iddetalle_ingreso, nombre, precio_c, precio_v, stock_actual, fecha_ven);

            this.Hide();
        }


    }
}
