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
    public partial class FrmFactura : Form
    {
        public int idventa = 0;
     private float total = 0;
        private float efectivo = 0;
        private float cambio = 0;
        private string cadena_total = "";

        public FrmFactura()
        {
            InitializeComponent();
        }

        
private void MostrarFactura()
        {
            this.datos.DataSource =new NGenerarFactura().MostrarFactura(this.idventa);//despues cambiar el id
            this.lbl_valortrabajador.Text = this.datos.Rows[0].Cells["Trabajador"].Value.ToString();
            this.lbl_valorcliente.Text = this.datos.Rows[0].Cells["Cliente"].Value.ToString();
            this.lbl_valorfecha.Text = this.datos.Rows[0].Cells["Fecha"].Value.ToString();
            this.datos.Columns["Idventa"].Visible = false;


            this.datos.Columns["Trabajador"].Visible = false;
            this.datos.Columns["Cliente"].Visible = false;
            this.datos.Columns["Fecha"].Visible = false;
        }
        private void Calcular()
        {
             for(int i=0;i < this.datos.RowCount; ++i)
            {
                total += float.Parse(this.datos.Rows[i].Cells["Total"].Value.ToString());
            }
            cadena_total = total.ToString();
            this.tb_total.Text = cadena_total;

        }

        private void FrmFactura_Load(object sender, EventArgs e)
        {
            MostrarFactura();
            Calcular();
        }

        private void btn_imprimir_Click(object sender, EventArgs e)
        {

            CgenerarFactura.CreaTicket Ticket1 = new CgenerarFactura.CreaTicket();

            Ticket1.TextoCentro("Tienda de Conveniencia MERU"); //imprime una linea de descripcion
            Ticket1.TextoCentro("**********************************");

            Ticket1.TextoIzquierda("Dirc:km14carreteranorte3kmalsur,ResidencialValleVerdecasaD-49");
            Ticket1.TextoIzquierda("Tel:76127428 ");
            Ticket1.TextoCentro("Factura de Venta"); //imprime una linea de descripcion
            Ticket1.TextoIzquierda("No Fac:" + this.datos.CurrentRow.Cells[0].Value.ToString());
            Ticket1.TextoIzquierda("Fecha:" + DateTime.Now.ToShortDateString() + " Hora:" + DateTime.Now.ToShortTimeString());
            Ticket1.TextoIzquierda("Le Atendio: "+this.lbl_valortrabajador.Text);
            Ticket1.TextoIzquierda("");
            CgenerarFactura.CreaTicket.LineasGuion();

            CgenerarFactura.CreaTicket.EncabezadoVenta();
            CgenerarFactura.CreaTicket.LineasGuion();
            foreach (DataGridViewRow r in this.datos.Rows)
            {
                // PROD                     //PrECIO                                    CANT                         TOTAL
                Ticket1.AgregaArticulo(r.Cells[4].Value.ToString(), double.Parse(r.Cells[5].Value.ToString()), int.Parse(r.Cells[6].Value.ToString()), double.Parse(r.Cells[8].Value.ToString()),double.Parse(r.Cells[7].Value.ToString())); //imprime una linea de descripcion
            }


            CgenerarFactura.CreaTicket.LineasGuion();
           

            Ticket1.TextoIzquierda(" ");
            Ticket1.AgregaTotales("Total", float.Parse(cadena_total)); // imprime linea con total
            Ticket1.TextoIzquierda(" ");
            Ticket1.AgregaTotales("Efectivo Entregado:",efectivo);
            Ticket1.AgregaTotales("Efectivo Devuelto:", cambio);


            // Ticket1.LineasTotales(); // imprime linea 

            Ticket1.TextoIzquierda(" ");
            Ticket1.TextoCentro("**********************************");
            Ticket1.TextoCentro("*     Gracias por preferirnos    *");

            Ticket1.TextoCentro("**********************************");
            Ticket1.TextoIzquierda(" ");
            string impresora = "Microsoft XPS Document Writer";
            Ticket1.ImprimirTiket(impresora);


            this.errorProvider1.Clear();

        }//fin metodo imprimir

        private void tb_efectivo_TextChanged(object sender, EventArgs e)
        {

            try
            {

                if (this.tb_efectivo.Text!=string.Empty)
                {
                    efectivo = float.Parse(this.tb_efectivo.Text);
                    cambio = efectivo - total;

                    this.tb_cambio.Text = cambio.ToString();
                }
                else if (this.tb_efectivo.Text == string.Empty)
                {
                    this.tb_cambio.Text = string.Empty;
                }
                
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ingresa un valor decimal: 00.00", "Visor Factura", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.errorProvider1.SetError(this.tb_efectivo, "Error");
                this.tb_efectivo.Clear();
            }

            
        }
    }//fin namespace
}//fin namespace
