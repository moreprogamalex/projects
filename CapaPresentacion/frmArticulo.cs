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
    public partial class frmArticulo : Form
    {
        private static frmArticulo _instancia;

       public static frmArticulo getinstancia()//Para establecer comunicacion con otra  ventana
        {
            if (_instancia == null)
            {
                _instancia = new frmArticulo();
            }
            return _instancia;
        }

       public void RellenarCategoria(int idcategoria, string nombre)
       {
           this.textBox_idcategoria.Text = idcategoria.ToString();
           this.textBox_categoria.Text = nombre;
       }

        public frmArticulo()
        {
            InitializeComponent();
        }

        private void Mostrar()
        {
            datos_articulos.DataSource = NArticulo.Mostrar_Datos();
            this.datos_articulos.Columns[4].Visible = false;
            this.datos_articulos.Columns[1].Visible = false;
            this.lbl_total.Text = this.datos_articulos.Rows.Count.ToString();

        }
        private void Buscar_Nombre()
        {
            datos_articulos.DataSource = NArticulo.Buscar_nombre(this.textBox_buscar.Text);
            this.lbl_total.Text = datos_articulos.Rows.Count.ToString();
        }

        private void Limpiar_cajastexto()
        {
            this.textBox_idarticulo.Clear();
            this.textBox_nombrearti.Clear();
            this.textBox_idcategoria.Clear();
            this.textBox_categoria.Clear();
        }

        private void frmArticulo_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;

           
            this.Mostrar();
            this.datos_articulos.Columns[0].Visible = false;
            this.textBox_idarticulo.ReadOnly = true;
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            this.Buscar_Nombre();
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            DialogResult opcion;
            opcion = MessageBox.Show("Deseas eliminar el registro?", "Sistema de Ventas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            string codigo = "";
            string rpt = "";

            if (opcion == DialogResult.OK)
            {
                foreach (DataGridViewRow row in datos_articulos.Rows)
                {
                    if (Convert.ToBoolean(row.Cells[0].Value))
                    {
                        codigo = Convert.ToString(row.Cells[1].Value);
                        rpt = NArticulo.Eliminar(Convert.ToInt16(codigo));
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
                this.datos_articulos.Columns[0].Visible = true;
            }
            else
            {
                this.datos_articulos.Columns[0].Visible = false;
            }
        }

        private void datos_articulos_CellClick(object sender, DataGridViewCellEventArgs e)//Mostras el registro en las cajas de texto incompleto
        {
            this.textBox_idarticulo.Text = this.datos_articulos.CurrentRow.Cells["ID"].Value.ToString();
            this.textBox_idarticulo.ReadOnly = true;
            this.textBox_idcategoria.ReadOnly = true;

            this.textBox_nombrearti.Text = this.datos_articulos.CurrentRow.Cells["Producto"].Value.ToString();
            //this.textBox_descriparti.Text = this.datos_articulos.CurrentRow.Cells["descripcion"].Value.ToString();
            //this.textBox_codigoventa.Text = this.datos_articulos.CurrentRow.Cells["codigo"].Value.ToString();

            //byte[] imagenbuffer = (byte[])this.datos_articulos.CurrentRow.Cells["imagen"].Value;
            //System.IO.MemoryStream ms = new System.IO.MemoryStream(imagenbuffer);

            //this.px_imagen.Image = Image.FromStream(ms);
            //this.px_imagen.SizeMode = PictureBoxSizeMode.StretchImage;

            this.textBox_idcategoria.Text = this.datos_articulos.CurrentRow.Cells["IDCategoria"].Value.ToString();
            this.textBox_categoria.Text = this.datos_articulos.CurrentRow.Cells["Categoria"].Value.ToString();
            

            //this.comboBox_presentacion.SelectedValue = this.datos_articulos.CurrentRow.Cells["idpresentacion"].Value.ToString();


            this.tabControl_principal.SelectedIndex = 1;

        }

        private void datos_articulos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == this.datos_articulos.Columns["Eliminar"].Index)
            {
                DataGridViewCheckBoxCell chkeliminar = (DataGridViewCheckBoxCell)datos_articulos.Rows[e.RowIndex].Cells["Eliminar"];
                chkeliminar.Value = !Convert.ToBoolean(chkeliminar.Value);
            }

        }

        //private void Llenarcombobox()
        //{
        //    this.comboBox_presentacion.DataSource = NPresentacion.Mostrar();
        //    this.comboBox_presentacion.ValueMember = "idpresentacion";
        //    this.comboBox_presentacion.DisplayMember = "nombre";
        //}

        //private void btn_cargarimagen_Click(object sender, EventArgs e)
        //{
        //    OpenFileDialog dialogo = new OpenFileDialog();
        //    DialogResult resultado = dialogo.ShowDialog();

        //    if (resultado == DialogResult.OK)
        //    {
        //        this.px_imagen.SizeMode = PictureBoxSizeMode.StretchImage;
        //        this.px_imagen.Image = Image.FromFile(dialogo.FileName);
        //    }
        //}

        //private void btn_limpiar_Click(object sender, EventArgs e)
        //{
        //    this.px_imagen.SizeMode = PictureBoxSizeMode.StretchImage;
        //    this.px_imagen.Image = global::CapaPresentacion.Properties.Resources.AQUI;
        //}

        private void textBox_buscar_TextChanged(object sender, EventArgs e)
        {
            this.Buscar_Nombre();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            this.textBox_idarticulo.ReadOnly = true;

            //System.IO.MemoryStream ms = new System.IO.MemoryStream();
            //this.px_imagen.Image.Save(ms,System.Drawing.Imaging.ImageFormat.Png);

            //byte[] imagen = ms.GetBuffer();

            MessageBox.Show( NArticulo.Insertar(this.textBox_nombrearti.Text,
                Convert.ToInt16(this.textBox_idcategoria.Text))
                ,"Sistema venta", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Limpiar_cajastexto();
            Mostrar();
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            this.textBox_idarticulo.ReadOnly = false;

            //System.IO.MemoryStream ms = new System.IO.MemoryStream();
            //this.px_imagen.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);

            //byte[] imagen = ms.GetBuffer();

            MessageBox.Show(NArticulo.Editar(Convert.ToInt16(this.textBox_idarticulo.Text), this.textBox_nombrearti.Text, 
                Convert.ToInt16(this.textBox_idcategoria.Text)), "Sistema venta", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Limpiar_cajastexto();
            Mostrar();
        }

        private void btn_buscarcategoria_Click(object sender, EventArgs e)
        {
            frmVistaCategoria_Articulo form = new frmVistaCategoria_Articulo();
            form.ShowDialog();
            this.textBox_idcategoria.ReadOnly = true;
            
            
        }

      
    }//Fin clase


}//Fin namespace
