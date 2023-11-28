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
    public partial class frmVenta : Form
    {
        private bool IsNuevo = false;
        public static frmVenta _instancia;
        public DataTable dt_detalles;

        public int idtrabajador=-1;
        public decimal totalpagado = 0;

        public static frmVenta get_instancia()
        {
            if (_instancia== null)
            {
                _instancia = new frmVenta();
            }
            return _instancia;
        }
        public  void obtener_cliente(int id, string nombre)
        {
            this.tb_idcliente.Text = id.ToString();
            this.tb_cliente.Text = nombre;
        }
        public void obtener_articulo(int iddetalle_ingreso,string nombre,decimal precio_compra,decimal precio_venta,
            int stock_actual, DateTime fechavenci)
        {
            this.tb_idarticulo_dingreso.Text = iddetalle_ingreso.ToString();
            this.tb_articulo.Text = nombre;
            this.tb_stockactual.Text = stock_actual.ToString();
            this.tb_preciocompra.Text = precio_compra.ToString();
            this.tb_precioventa.Text = precio_venta.ToString();
            this.dt_vencimiento.Value = fechavenci;
        }

        private void Mostrar()
        {
            this.datos_venta.DataSource = NVenta.Mostrar();
            this.lbl_total_filas.Text = this.datos_venta.Rows.Count.ToString();

        }
        private void Buscarxfechas()
        {
            this.datos_venta.DataSource = NVenta.Buscarxfecha_laventa(this.dt_busqueda1.Value.ToString("yyyy/MM/dd"),
                this.dt_busqueda2.Value.ToString("yyyy/MM/dd"));
        }
        private void Buscar_detalleventa()//Apoyado con el evento doble click de la grid
        {
            this.data_detalle.DataSource = NVenta.Mostrar_eldetalle(Convert.ToInt16(this.tb_idventa.Text));
        }
        private void Limpiar_venta()
        {
            this.tb_idventa.Clear();
            this.tb_idcliente.Clear();
            this.tb_cliente.Clear();
            this.cb_comprobante.Text = string.Empty;
            this.lbl_pago.Text = "C$0.00";
            this.dt_fechamadre.Value = DateTime.Now;
            this.Crear_tabla();
               }

        private void Limpiar_detalle()
        {
            this.tb_idarticulo_dingreso.Clear();
            this.tb_articulo.Clear();
            this.tb_stockactual.Clear();
            this.tb_cantidad.Clear();
            this.tb_preciocompra.Clear();
            this.tb_precioventa.Clear();
            this.tb_descuento.Text="00.00";

        }


        private void Crear_tabla()
        {
            this.dt_detalles = new DataTable("Detalles");
            this.dt_detalles.Columns.Add("IdDetalleCompra", System.Type.GetType("System.Int16"));
            this.dt_detalles.Columns.Add("Producto", System.Type.GetType("System.String"));
            this.dt_detalles.Columns.Add("Cantidad", System.Type.GetType("System.Int16"));
            this.dt_detalles.Columns.Add("PrecioVenta", System.Type.GetType("System.Decimal"));
            this.dt_detalles.Columns.Add("Descuento%", System.Type.GetType("System.Decimal"));
            this.dt_detalles.Columns.Add("Subtotal", System.Type.GetType("System.Decimal"));

            this.data_detalle.DataSource = this.dt_detalles;
        }


        public frmVenta()
        {
            InitializeComponent();
            this.tb_idcliente.ReadOnly = true;
            this.tb_cliente.ReadOnly = true;
            this.dt_vencimiento.Enabled = false;
            this.tb_idarticulo_dingreso.ReadOnly = true;
            this.tb_articulo.ReadOnly = true;
            this.tb_stockactual.ReadOnly = true;
            this.tb_preciocompra.ReadOnly = true;
            this.tb_precioventa.ReadOnly = true;
            this.tb_idventa.ReadOnly = true;
            this.MensajeAyuda.SetToolTip(this.tb_descuento, "Ingresa un numero decimal " +
                "|-Sugerencia: 00.00 -|");
        }

        private void frmVenta_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            
            Mostrar();
            this.OcultarColumnas();

            this.Habilitar(false);
            this.Botones();


            Crear_tabla();
        }

        private void frmVenta_FormClosing(object sender, FormClosingEventArgs e)
        {
            _instancia = null;
        }

        private void btn_buscarcliente_Click(object sender, EventArgs e)
        {
            frmVistaCliente_venta f = new frmVistaCliente_venta();
            f.ShowDialog();
        }

        private void btn_buscararticulo_Click(object sender, EventArgs e)
        {
            frmVistaArticulo_venta f = new frmVistaArticulo_venta();
            f.ShowDialog();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            this.Buscarxfechas();
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            DialogResult opcion;
            opcion = MessageBox.Show("Deseas eliminar el registro?", "Sistema de Ventas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            string codigo = "";
            string rpt = "";

            if (opcion == DialogResult.OK)
            {
                foreach (DataGridViewRow row in this.datos_venta.Rows)
                {
                    if (Convert.ToBoolean(row.Cells[0].Value))
                    {
                        codigo = Convert.ToString(row.Cells[1].Value);
                        rpt = NVenta.Eliminar_venta(Convert.ToInt16(codigo));
                    }
                }


            }

            if (rpt.Equals("Ok"))
            {
                MessageBox.Show(rpt, "Sistema Venta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(rpt, "Sistema Venta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            Limpiar_venta();
            Limpiar_detalle();
            Mostrar();
        }

        private void checkBox_eliminar_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBox_eliminar.Checked)
            {
                this.datos_venta.Columns[0].Visible = true;
            }
            else
            {
                this.datos_venta.Columns[0].Visible = false;
            }
        }

        private void datos_venta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == this.datos_venta.Columns["Eliminar"].Index)
            {
                DataGridViewCheckBoxCell chkeliminar = (DataGridViewCheckBoxCell)datos_venta.Rows[e.RowIndex].Cells["Eliminar"];
                chkeliminar.Value = !Convert.ToBoolean(chkeliminar.Value);
                this.btn_eliminar.Enabled = true;
                if (Convert.ToBoolean(chkeliminar.Value) == false)
                {
                    this.btn_eliminar.Enabled = false;
                }
            }
            
        }

        private void datos_venta_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.tb_idventa.Text = this.datos_venta.CurrentRow.Cells["Idventa"].Value.ToString();
            this.tb_cliente.Text = this.datos_venta.CurrentRow.Cells["Cliente"].Value.ToString();
            this.dt_fechamadre.Value = Convert.ToDateTime(this.datos_venta.CurrentRow.Cells["Fecha"].Value);
            this.cb_comprobante.Text = this.datos_venta.CurrentRow.Cells["TipoComprobante"].Value.ToString();
            this.lbl_pago.Text= this.datos_venta.CurrentRow.Cells["Total"].Value.ToString();
            this.tabControl_principal.SelectedIndex = 1;
            this.Buscar_detalleventa();

        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (this.tb_idcliente.Text == string.Empty || this.cb_comprobante.Text==string.Empty || this.idtrabajador==-1)//agregar el id trabajador
            {

                MessageBox.Show("Faltan algunos datos", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.errorProvider1.SetError(this.tb_idcliente,"Buscar un cliente");
                this.errorProvider1.SetError(this.cb_comprobante, "Seleccione una opcion");
                this.errorProvider1.SetError(this.dt_fechamadre, "Ingrese la fecha");

            }
            else
            {
                if (this.IsNuevo)
                {
                    MessageBox.Show(NVenta.Insertar(Convert.ToInt16(this.tb_idcliente.Text),this.idtrabajador,
             this.dt_fechamadre.Value, this.cb_comprobante.Text, this.dt_detalles)//Despues cambiar el ID
             , "Sistema venta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
               

            Mostrar();
            this.IsNuevo = false;
            this.Botones();
            this.Limpiar_venta();
            this.Limpiar_detalle();

         


        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            int canti_prod=00;
            decimal campo_decuento = 0;
            try
            {
                if (this.tb_idarticulo_dingreso.Text == string.Empty || this.tb_cantidad.Text == string.Empty
                    || this.tb_descuento.Text == string.Empty || this.tb_precioventa.Text == string.Empty)
                {
                    MessageBox.Show("Falta ingresar algunos datos, serán remarcados", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.errorProvider1.SetError(tb_idarticulo_dingreso, "Buscar un producto");
                    this.errorProvider1.SetError(tb_cantidad, "Ingrese un Valor");
                    this.errorProvider1.SetError(tb_descuento, "Ingrese un valor decimal:" +
                        "Sugerencia 00.00");
                    this.errorProvider1.SetError(tb_precioventa, "Ingrese un Valor");
                }
                else
                {
                    this.errorProvider1.Clear();
                    bool registrar = true;
                    bool validar_cantidad = true;
                    foreach (DataRow row in dt_detalles.Rows)
                    {
                        if (Convert.ToInt32(row["IdDetalleCompra"]) == Convert.ToInt32(this.tb_idarticulo_dingreso.Text))
                        {
                            registrar = false;
                            MessageBox.Show("Ya se encuentra el artículo en el detalle", "Inventario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    //validando campo cantidad
                    try
                    {
                        canti_prod = Convert.ToInt16(this.tb_cantidad.Text);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ingrese un valor entero", "Sugerencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.tb_cantidad.Clear();
                        validar_cantidad = false;
                    }

                    if (registrar && canti_prod <= Convert.ToInt32(tb_stockactual.Text) && validar_cantidad)
                    {
                        bool aplicar_descuento = true;
                        //validando campo descuento
                        try
                        {
                            campo_decuento = Convert.ToDecimal(this.tb_descuento.Text);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Ingrese un valor decimal", "Sugerencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.tb_descuento.Text="00.00";
                            aplicar_descuento = false;
                        }



                        int n = this.tb_descuento.Text.Length;
                        string cadena = this.tb_descuento.Text;

                        for (int i = 0; i <= n-1; i++)
                        {
                            if (cadena[i].Equals(','))
                            {
                               
                                i = n + 1;
                                this.tb_descuento.Text = "00.00";
                                aplicar_descuento = false;
                                MessageBox.Show("Favor ingrese el punto decimal (.)", "Sugerencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }

                        }

                        if (aplicar_descuento)
                        {
                            decimal calculo_sub = canti_prod * Convert.ToDecimal(this.tb_precioventa.Text.ToString());
                            decimal decuento = calculo_sub * (campo_decuento/ 100);
                            decimal subtotal = calculo_sub - decuento;
                            this.totalpagado += subtotal;
                            this.lbl_pago.Text = totalpagado.ToString("#0.00#");
                            DataRow row = this.dt_detalles.NewRow();

                            row["idDetalleCompra"] = Convert.ToInt16(this.tb_idarticulo_dingreso.Text);
                            row["Producto"] = this.tb_articulo.Text;
                            row["Cantidad"] = Convert.ToInt16(this.tb_cantidad.Text);
                            row["PrecioVenta"] = Convert.ToDecimal(this.tb_precioventa.Text);
                            row["Descuento%"] = Convert.ToDecimal(this.tb_descuento.Text);
                            //row["Fecha_vencimiento"] = this.dt_vencimiento.Value;
                            row["Subtotal"] = subtotal;
                            this.dt_detalles.Rows.Add(row);
                            this.Limpiar_detalle();
                        }
                        else
                        {
                            this.errorProvider1.SetError(tb_descuento, "!");
                         
                        }

                      
                    }
                    else
                    {
                        this.errorProvider1.SetError(this.tb_cantidad, "Digitar un valor valido");
                        //MessageBox.Show("Producto Insuficiente", "Invetario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }

        }//fin metodo

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.errorProvider1.Clear();
            try
            {
                int indicefila = this.data_detalle.CurrentCell.RowIndex;
                DataRow r = this.dt_detalles.Rows[indicefila];
                this.totalpagado -= Convert.ToDecimal(r["subtotal"].ToString());
                this.lbl_pago.Text += totalpagado.ToString("#0.00#");
                this.dt_detalles.Rows.Remove(r);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Sistema de Venta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_comprobante_Click(object sender, EventArgs e)
        {
            FrmFactura factura = new FrmFactura();
            factura.idventa = Convert.ToInt16(this.datos_venta.CurrentRow.Cells[1].Value.ToString());
            factura.ShowDialog();
        }

        private void Habilitar(bool valor)
        {
            this.tb_idventa.ReadOnly = true;
            this.dt_fechamadre.Enabled = valor;
            this.cb_comprobante.Enabled = valor;
            this.tb_cantidad.ReadOnly = !valor;
            this.tb_preciocompra.ReadOnly = !valor;
            this.tb_precioventa.ReadOnly = !valor;
            this.tb_stockactual.ReadOnly = true;
            this.tb_descuento.ReadOnly = !valor;
            this.dt_vencimiento.Enabled = false;
            this.tb_articulo.ReadOnly = true;

            this.btn_buscararticulo.Enabled = valor;
            this.btn_buscarcliente.Enabled = valor;
            this.btn_agregar.Enabled = valor;
            this.btn_cancelar.Enabled = valor;
            this.btn_cancelar2.Enabled = valor;
        }

        private void Botones()
        {
            if (this.IsNuevo) //Alt + 124
            {
                this.Habilitar(true);
                this.btn_nuevo.Enabled = false;
                this.btn_guardar.Enabled = true;
                this.btn_cancelar2.Enabled = true;
            }
            else
            {
                this.Habilitar(false);
                this.btn_nuevo.Enabled = true;
                this.btn_guardar.Enabled = false;
                this.btn_cancelar2.Enabled = false;
            }

        }

        private void OcultarColumnas()
        {
            this.datos_venta.Columns[0].Visible = false;
            this.datos_venta.Columns[1].Visible = false;

        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            this.IsNuevo = true;
            this.Botones();
            this.Limpiar_venta();
            this.Limpiar_detalle();
            this.Habilitar(true);

            this.errorProvider1.Clear();

        }

        private void btn_cancelar2_Click(object sender, EventArgs e)
        {
            this.errorProvider1.Clear();
            this.IsNuevo = false;
            this.Botones();
            this.Limpiar_venta();
            this.Limpiar_detalle();
            this.Habilitar(false);
        }

        private void btn_refrescar_Click(object sender, EventArgs e)
        {
           
            this.Mostrar();
        }
    }//fin class

}//fin namespace
