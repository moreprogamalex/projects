using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;

using CapaLogica;

namespace CapaPresentacion
{
    public partial class frmIngreso : Form
    {
        private static frmIngreso instancia;
        private DataTable dt_detalles;//Importante Heramienta
        public int idtrabajador = 0;//Corregir valor por defecto
        private decimal totalpagos = 0;

        private bool IsNuevo=false;

        public static frmIngreso Obtener_instancia()
        {
            if (instancia == null)
            {
                instancia = new frmIngreso();
            }
            return instancia;
        }

        public void SetProveedor(string txt, string id)
        {
            this.textBox_idproveedor.Text = id;
            this.textBox_proveedor.Text = txt;
        }

        public void SetArticulo(string txt,string id)
        {
            this.tb_idarticulo.Text = id;
            this.tb_articulo.Text = txt;
        }

        private void Mostrar()
        {
            this.datos_ingresos.DataSource = NIngreso.Mostrar();
            this.lbl_total.Text = this.datos_ingresos.Rows.Count.ToString();

        }
        private void Buscarxfechas()
        {
            this.datos_ingresos.DataSource = NIngreso.Buscarxfecha_elingreso(this.dt_busqueda1.Value.ToString("yyyy/MM/dd"),
                this.dt_busqueda2.Value.ToString("yyyy/MM/dd"));
        }
        private void Buscar_eldetalleingreso()
        {
            this.data_detalle.DataSource = NIngreso.Mostrar_eldetalle(Convert.ToInt16(this.datos_ingresos.CurrentRow.Cells["Idcompra"].Value.ToString()));
            
        }

        private void Limpiar_ingreso()
        {
            this.textBox_idingreso.Clear();
            this.cb_comprobante.Text = "Opcion:";
            this.cb_estado.Text = "Opcion";
            this.textBox_idproveedor.Clear();
            this.textBox_proveedor.Clear();
            this.dt_fechamadre.Value = Convert.ToDateTime(DateTime.Now);
            this.lbl_pago.Text = "C$0.00";
            Crear_tabla();
        }

        private void Limpiar_detalle()
        {
            this.tb_idarticulo.Clear();
            this.tb_articulo.Clear();
            this.tb_stockinicial.Clear();
            this.tb_preciocompra.Text="00.00";
            this.tb_precioventa.Text="00.00";

        }
        

        private void Crear_tabla()
        {
            this.dt_detalles = new DataTable("Detalles");
            this.dt_detalles.Columns.Add("Idproducto", System.Type.GetType("System.Int16"));
            //this.dt_detalles.Columns.Add("Idcompra", System.Type.GetType("System.Int16"));
            this.dt_detalles.Columns.Add("Producto", System.Type.GetType("System.String"));
            this.dt_detalles.Columns.Add("PrecioCompra", System.Type.GetType("System.Decimal"));
            this.dt_detalles.Columns.Add("PrecioVenta", System.Type.GetType("System.Decimal"));
            this.dt_detalles.Columns.Add("StockInicial", System.Type.GetType("System.Int16"));
            this.dt_detalles.Columns.Add("StockActual", System.Type.GetType("System.Int16"));
            this.dt_detalles.Columns.Add("FechaProduccion", System.Type.GetType("System.DateTime"));
            this.dt_detalles.Columns.Add("FechaVencimiento", System.Type.GetType("System.DateTime"));
            this.dt_detalles.Columns.Add("Subtotal", System.Type.GetType("System.Decimal"));

            
            this.data_detalle.DataSource = this.dt_detalles;
            
        }



        public frmIngreso()
        {
            InitializeComponent();
        }

        private void frmIngreso_Load(object sender, EventArgs e)
        {

            Mostrar();
            Crear_tabla();
            this.OcultarColumnas();
            this.botones();

        }

        private void frmIngreso_FormClosing(object sender, FormClosingEventArgs e)
        {
            instancia = null;
        }

        private void btn_buscararticulo_Click(object sender, EventArgs e)
        {
            frmVistaArticula_Ingreso f = new frmVistaArticula_Ingreso();
            f.ShowDialog();
        }

        private void btn_buscarproveedor_Click(object sender, EventArgs e)
        {
            frmVistaProveedor f = new frmVistaProveedor();
            f.ShowDialog();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            this.Buscarxfechas();
        }

        private void btn_anular_Click(object sender, EventArgs e)
        {
            DialogResult opcion;
            opcion = MessageBox.Show("Deseas Anular el registro?", "Sistema de Ventas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            string codigo = "";
            string rpt = "";

            if (opcion == DialogResult.OK)
            {
                foreach (DataGridViewRow row in this.datos_ingresos.Rows)
                {
                    if (Convert.ToBoolean(row.Cells[0].Value))
                    {
                        codigo = Convert.ToString(row.Cells[1].Value);
                        rpt = NIngreso.Anular(Convert.ToInt16(codigo));
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

            //Limpiar_ingreso();
            Mostrar();
            this.btn_anular.Enabled = false;
        }

        private void checkBox_eliminar_CheckedChanged(object sender, EventArgs e)
        {
            
            if (this.checkBox_eliminar.Checked)
            {
                this.datos_ingresos.Columns[0].Visible = true;
            }
            else
            {
                this.datos_ingresos.Columns[0].Visible = false;
                this.btn_anular.Enabled = false;
            }
           
        }

        private void datos_ingresos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == this.datos_ingresos.Columns["Anular"].Index)
            {
                DataGridViewCheckBoxCell chkeliminar = (DataGridViewCheckBoxCell)datos_ingresos.Rows[e.RowIndex].Cells["Anular"];
                chkeliminar.Value = !Convert.ToBoolean(chkeliminar.Value);
                if (Convert.ToBoolean(chkeliminar.Value))
                {
                    this.btn_anular.Enabled = true;
                }
                else
                {
                    this.btn_anular.Enabled = false;
                }
            }
           
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {

            if (this.textBox_proveedor.Text == string.Empty || this.cb_comprobante.Text == "Opcion:" || this.cb_estado.Text=="Opcion:"
                || this.cb_comprobante.Text == string.Empty || this.cb_estado.Text == string.Empty)
            {
                MessageBox.Show("Faltan algunos datos", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.errorProvider1.SetError(this.textBox_proveedor, "Buscar un cliente");
                this.errorProvider1.SetError(this.cb_comprobante, "Seleccione una opcion");
                this.errorProvider1.SetError(this.cb_estado, "Ingrese la fecha");

            }
            else
            {

                if (this.IsNuevo)
                {

                    MessageBox.Show(NIngreso.Insertar(this.idtrabajador, Convert.ToInt16(this.textBox_idproveedor.Text), this.dt_fechamadre.Value,//cambiar el id trabajador despues
                    this.cb_comprobante.Text,
                    this.cb_estado.Text, this.dt_detalles), "Sistema venta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }//fin else

            Mostrar();
            this.IsNuevo = false;
            this.habilitar(false);
            Limpiar_ingreso();
            Limpiar_detalle();
            
            
            
        }//fin metodo

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            int stockinicial = 0;
            decimal preciocompra = 0;
            decimal precioventa = 0;
            try
            {
                if (this.tb_idarticulo.Text == string.Empty || this.tb_stockinicial.Text == string.Empty
                    || this.tb_preciocompra.Text == string.Empty || this.tb_precioventa.Text == string.Empty)
                {
                    MessageBox.Show("Falta ingresar algunos datos, serán remarcados", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.errorProvider1.SetError(tb_idarticulo, "Buscar un producto");
                    this.errorProvider1.SetError(this.tb_stockinicial, "Ingrese un Valor");
                    this.errorProvider1.SetError(this.tb_preciocompra, "Ingrese un valor decimal:" +
                        "Sugerencia 00,00");
                    this.errorProvider1.SetError(tb_precioventa, "Ingrese un valor decimal:" +
                        "Sugerencia 00,00");
                }
                else
                {
                    this.errorProvider1.Clear();
                    bool registrar = true;
                    bool validar_stock= true;
                    bool validar_preciocompra = true;
                    foreach (DataRow row in dt_detalles.Rows)
                    {
                        if (Convert.ToInt32(row["Idproducto"]) == Convert.ToInt32(this.tb_idarticulo.Text))
                        {
                            registrar = false;
                            MessageBox.Show("Ya se encuentra el artículo en el detalle", "Invetario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    //validando campo stock
                    try
                    {
                        stockinicial = Convert.ToInt16(this.tb_stockinicial.Text);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ingrese un valor entero", "Sugerencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        errorProvider1.SetError(this.tb_stockinicial, "Ingresa un valor entero");
                        this.tb_stockinicial.Clear();
                        validar_stock = false;
                    }
                    //validando campo preciocompra
                    try
                    {
                        preciocompra = Convert.ToDecimal(this.tb_preciocompra.Text);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ingrese un valor decimal", "Sugerencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.tb_preciocompra.Text = "00,00";
                        validar_preciocompra = false;
                    }
                    //validando campo precioventa
                    try
                    {
                        precioventa = Convert.ToDecimal(this.tb_precioventa.Text);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ingrese un valor decimal", "Sugerencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.tb_preciocompra.Text = "00,00";
                    }


                    if (registrar)
                    {
                        if (validar_stock && validar_preciocompra)
                        {
                            bool aplicar_total = true;
                            string cadena = this.tb_preciocompra.Text + this.tb_precioventa.Text;
                            int contador = 0;

                            
                            for (int i = 0; i <= cadena.Length - 1; i++)
                            {
                                if (cadena[i].Equals('.'))
                                {
                                    contador+=1;

                                }

                            }
                            if (contador<2)
                            {
                                this.tb_precioventa.Text = "00.00";
                                this.tb_preciocompra.Text = "00.00";
                                aplicar_total = false;
                                MessageBox.Show("Favor ingrese el punto decimal (.)", "Sugerencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            
                            if (aplicar_total)
                            {
                                decimal calculo_sub = stockinicial * preciocompra;
                                this.totalpagos += calculo_sub;
                                this.lbl_pago.Text = totalpagos.ToString();
                                DataRow row = this.dt_detalles.NewRow();

                                row["Idproducto"] = Convert.ToInt16(this.tb_idarticulo.Text);
                                row["PrecioCompra"] = preciocompra;
                                row["Producto"] = this.tb_articulo.Text;
                                row["StockInicial"] = Convert.ToInt16(this.tb_stockinicial.Text);
                                row["PrecioVenta"] = precioventa;
                                row["FechaVencimiento"] = this.dt_vencimiento.Value.ToString("yyyy/MM/dd");
                                row["FechaProduccion"] = this.dt_fechaproduc.Value.ToString("yyyy/MM/dd");
                                row["Subtotal"] = calculo_sub;
                                this.dt_detalles.Rows.Add(row);
                                this.Limpiar_detalle();
                            }
                            else
                            {
                                this.errorProvider1.SetError(this.tb_preciocompra, "!");
                                this.errorProvider1.SetError(this.tb_precioventa, "!");

                            }






                        }//fin if2
                       


                    }
                    else
                    {

                        MessageBox.Show("El producto ya se encuentra en el detalle", "Invetario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }//fin else


            }//fin try
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }


        }//fin metodo

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            try
            {
                int indice = this.data_detalle.CurrentCell.RowIndex;
                DataRow r = this.dt_detalles.Rows[indice];
                this.totalpagos -= Convert.ToDecimal(r["Subtotal"].ToString());
                this.lbl_pago.Text = totalpagos.ToString("#0.00#");
                this.dt_detalles.Rows.Remove(r);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Sistema de Venta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void datos_ingresos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.textBox_idingreso.Text = this.datos_ingresos.CurrentRow.Cells["Idcompra"].Value.ToString();
            this.textBox_proveedor.Text = this.datos_ingresos.CurrentRow.Cells["Proveedor"].Value.ToString();
            this.dt_fechamadre.Value = Convert.ToDateTime(this.datos_ingresos.CurrentRow.Cells["Fecha"].Value);
            this.cb_comprobante.Text = this.datos_ingresos.CurrentRow.Cells["TipoComprobante"].Value.ToString();
            this.cb_estado.Text = this.datos_ingresos.CurrentRow.Cells["Estado"].Value.ToString();
            this.tabControl_principal.SelectedIndex = 1;
           
            this.Buscar_eldetalleingreso();
        }

        private void refrescar_Click(object sender, EventArgs e)
        {
            this.Mostrar();
            
        }
        private void habilitar(bool evento)
        {
            this.textBox_idingreso.ReadOnly = true;
            this.cb_comprobante.Enabled = evento;
            this.cb_estado.Enabled = evento;
            this.textBox_idproveedor.ReadOnly= true;
            this.textBox_proveedor.ReadOnly= true;
            this.dt_fechamadre.Enabled = evento;
            this.tb_stockinicial.ReadOnly = !evento;
            this.tb_preciocompra.ReadOnly = !evento;
            this.tb_precioventa.ReadOnly= !evento;
            this.dt_fechaproduc.Enabled = evento;
            this.dt_vencimiento.Enabled = evento;
            this.tb_idarticulo.ReadOnly = true;
            this.tb_articulo.ReadOnly = true;

            this.btn_agregar.Enabled = evento;
            this.btn_quitar.Enabled = evento;
            this.btn_buscararticulo.Enabled = evento;
            this.btn_buscarproveedor.Enabled = evento;

            
        }
        private void botones()
        {
            if (this.IsNuevo)
            {
                habilitar(true);
                this.btn_nuevo.Enabled = false;
                this.btn_guardar.Enabled = true;
                this.btn_cancelar.Enabled = true;
            }
            else
            {
                habilitar(false);
                this.btn_nuevo.Enabled = true;
                this.btn_guardar.Enabled =false;
                this.btn_cancelar.Enabled = false;
            }
        }
        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            this.IsNuevo = true;

            this.botones();
            this.Limpiar_ingreso();
            this.Limpiar_detalle();
           
        }

        private void OcultarColumnas()
        {
            this.datos_ingresos.Columns[0].Visible = false;
            this.datos_ingresos.Columns[1].Visible = false;

        }

        private void btn_cancelar_Click_1(object sender, EventArgs e)
        {
            this.IsNuevo = false;
            this.botones();
            this.Limpiar_ingreso();
            this.Limpiar_detalle();
        }
    }//Fin class


}//Fin namespace
