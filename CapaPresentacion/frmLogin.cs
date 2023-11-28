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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            lbl_hora.Text = DateTime.Now.ToString();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_hora.Text = DateTime.Now.ToString();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_ingresar_Click(object sender, EventArgs e)
        {
           // DataTable datos = NTrabajador.Login(this.textBox_usuario.Text,this.textBox2_password.Text);
            DataTable datos = NTrabajador.Login(this.textBox_usuario.Text,this.textBox2_password.Text);

            if (datos.Rows.Count == 0)
            {
                MessageBox.Show("Usuario no registrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.textBox_usuario.Clear();
                this.textBox2_password.Clear();
            }
            else
            {
                frmPrincipal frm = new frmPrincipal();
                frm.idtrabajador = datos.Rows[0][0].ToString();
                frm.nombre = datos.Rows[0][1].ToString();
                frm.apellidos = datos.Rows[0][2].ToString();
                frm.acceso = datos.Rows[0][3].ToString();

                frm.Show();
                this.Hide();
            }


        }//fin clase

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }//Fin class

}//Fin namespace
