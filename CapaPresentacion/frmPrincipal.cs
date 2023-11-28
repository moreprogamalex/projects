using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frmPrincipal : Form
    {
        private int childFormNumber = 0;
        public string idtrabajador = string.Empty;
        public string nombre = string.Empty;
        public string apellidos = string.Empty; 
        public string acceso = string.Empty;
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Ventana " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            this.Getion_usuario();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void presentacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPresentacion frm = new frmPresentacion();
            frm.MdiParent = this;
            frm.Show();
        }

        private void articulosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmArticulo frm = frmArticulo.getinstancia();
            frm.MdiParent = this;
            frm.Show();
        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProveedor frm = new frmProveedor();
            frm.MdiParent = this;
            frm.Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCliente frm = new frmCliente();
            frm.MdiParent = this;
            frm.Show();
        }

        private void trabajadoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTrabajador frm = new frmTrabajador();
            frm.MdiParent = this;
            frm.Show();
        }

        private void Getion_usuario()
        {
            if (acceso.ToLower() == "administrador")
            {
                this.menu_almacen.Enabled = true;
                this.menu_compras.Enabled = true;
                //this.menu_consultas.Enabled = true;
                this.menu_herramienta.Enabled = true;
                this.menu_trabajadores.Enabled = true;
                this.menu_ventas.Enabled = true;
            }




            else if (acceso.ToLower() == "vendedor")
            {
                this.menu_almacen.Enabled = true;
                this.menu_compras.Enabled = true;
                //this.menu_consultas.Enabled = true;
                this.menu_herramienta.Enabled = false;
                this.menu_trabajadores.Enabled = false;
                this.menu_ventas.Enabled = true;
            }
            else if (acceso.ToLower() == "bodegero")
            {
                this.menu_almacen.Enabled =true;
                this.menu_compras.Enabled = true;
                //this.menu_consultas.Enabled = true;
                this.menu_herramienta.Enabled = false;
                this.menu_trabajadores.Enabled = false;
                this.menu_ventas.Enabled = false;
            }

            else
            {
                this.menu_almacen.Enabled = false;
                this.menu_compras.Enabled = false;
                //this.menu_consultas.Enabled = false;
                this.menu_herramienta.Enabled = false;
                this.menu_trabajadores.Enabled = false;
                this.menu_ventas.Enabled = false;
            }



        }

        private void ingresosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmIngreso f = frmIngreso.Obtener_instancia();

            f.MdiParent = this;
            f.idtrabajador = Convert.ToInt16(this.idtrabajador);
            f.Show();

        }

        private void ventasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmVenta f = frmVenta.get_instancia();
            f.MdiParent = this;
            f.idtrabajador = Convert.ToInt16(this.idtrabajador);
            f.Show();
        }

        private void menu_ventas_Click(object sender, EventArgs e)
        {

        }

        private void ventasPorFechasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void comprasPorFechasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void stockArticulosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCategoria categoria = new frmCategoria();
            categoria.ShowDialog();
        }

        private void stockProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmstock stock = new frmstock();
            //stock.MdiParent = this;
            stock.ShowDialog();
        }

        private void menu_mantenimiento_Click(object sender, EventArgs e)
        {
            frmTrabajador t = new frmTrabajador();
            t.Show();
           
           
        }
    }//fin clases

}//fin namespace
