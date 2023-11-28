namespace CapaPresentacion
{
    partial class frmCategoria
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_Titulo = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lbl_Descrippp = new System.Windows.Forms.Label();
            this.lbl_Nombrep = new System.Windows.Forms.Label();
            this.lbl_IDp = new System.Windows.Forms.Label();
            this.btn_Editar = new System.Windows.Forms.Button();
            this.textBox_Descripp = new System.Windows.Forms.TextBox();
            this.textBox_Nombrep = new System.Windows.Forms.TextBox();
            this.textBox_ID = new System.Windows.Forms.TextBox();
            this.data_Listado = new System.Windows.Forms.DataGridView();
            this.lbl_Total_Registro = new System.Windows.Forms.Label();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_Buscar = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.textBox_Descripcion = new System.Windows.Forms.TextBox();
            this.textBox_Nombre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_Listado)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_Titulo
            // 
            this.label_Titulo.AutoSize = true;
            this.label_Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Titulo.ForeColor = System.Drawing.Color.Maroon;
            this.label_Titulo.Location = new System.Drawing.Point(61, 32);
            this.label_Titulo.Name = "label_Titulo";
            this.label_Titulo.Size = new System.Drawing.Size(109, 24);
            this.label_Titulo.TabIndex = 0;
            this.label_Titulo.Text = "Categorias";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(74, 59);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(752, 367);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lbl_Descrippp);
            this.tabPage1.Controls.Add(this.lbl_Nombrep);
            this.tabPage1.Controls.Add(this.lbl_IDp);
            this.tabPage1.Controls.Add(this.btn_Editar);
            this.tabPage1.Controls.Add(this.textBox_Descripp);
            this.tabPage1.Controls.Add(this.textBox_Nombrep);
            this.tabPage1.Controls.Add(this.textBox_ID);
            this.tabPage1.Controls.Add(this.data_Listado);
            this.tabPage1.Controls.Add(this.lbl_Total_Registro);
            this.tabPage1.Controls.Add(this.btn_Eliminar);
            this.tabPage1.Controls.Add(this.btn_Buscar);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.textBox_Buscar);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(744, 341);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Listado";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lbl_Descrippp
            // 
            this.lbl_Descrippp.AutoSize = true;
            this.lbl_Descrippp.Location = new System.Drawing.Point(25, 210);
            this.lbl_Descrippp.Name = "lbl_Descrippp";
            this.lbl_Descrippp.Size = new System.Drawing.Size(66, 13);
            this.lbl_Descrippp.TabIndex = 14;
            this.lbl_Descrippp.Text = "Descripcion:";
            // 
            // lbl_Nombrep
            // 
            this.lbl_Nombrep.AutoSize = true;
            this.lbl_Nombrep.Location = new System.Drawing.Point(31, 151);
            this.lbl_Nombrep.Name = "lbl_Nombrep";
            this.lbl_Nombrep.Size = new System.Drawing.Size(47, 13);
            this.lbl_Nombrep.TabIndex = 13;
            this.lbl_Nombrep.Text = "Nombre:";
            // 
            // lbl_IDp
            // 
            this.lbl_IDp.AutoSize = true;
            this.lbl_IDp.Location = new System.Drawing.Point(31, 103);
            this.lbl_IDp.Name = "lbl_IDp";
            this.lbl_IDp.Size = new System.Drawing.Size(21, 13);
            this.lbl_IDp.TabIndex = 12;
            this.lbl_IDp.Text = "ID:";
            // 
            // btn_Editar
            // 
            this.btn_Editar.Location = new System.Drawing.Point(166, 285);
            this.btn_Editar.Name = "btn_Editar";
            this.btn_Editar.Size = new System.Drawing.Size(82, 20);
            this.btn_Editar.TabIndex = 11;
            this.btn_Editar.Text = "Editar";
            this.btn_Editar.UseVisualStyleBackColor = true;
            this.btn_Editar.Click += new System.EventHandler(this.btn_Editar_Click);
            // 
            // textBox_Descripp
            // 
            this.textBox_Descripp.Location = new System.Drawing.Point(97, 192);
            this.textBox_Descripp.Multiline = true;
            this.textBox_Descripp.Name = "textBox_Descripp";
            this.textBox_Descripp.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_Descripp.Size = new System.Drawing.Size(139, 49);
            this.textBox_Descripp.TabIndex = 10;
            this.textBox_Descripp.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBox_Nombrep
            // 
            this.textBox_Nombrep.Location = new System.Drawing.Point(97, 144);
            this.textBox_Nombrep.Name = "textBox_Nombrep";
            this.textBox_Nombrep.Size = new System.Drawing.Size(139, 20);
            this.textBox_Nombrep.TabIndex = 9;
            // 
            // textBox_ID
            // 
            this.textBox_ID.Location = new System.Drawing.Point(97, 100);
            this.textBox_ID.Name = "textBox_ID";
            this.textBox_ID.Size = new System.Drawing.Size(139, 20);
            this.textBox_ID.TabIndex = 8;
            // 
            // data_Listado
            // 
            this.data_Listado.AllowUserToAddRows = false;
            this.data_Listado.AllowUserToDeleteRows = false;
            this.data_Listado.AllowUserToOrderColumns = true;
            this.data_Listado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.data_Listado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_Listado.Location = new System.Drawing.Point(308, 109);
            this.data_Listado.MultiSelect = false;
            this.data_Listado.Name = "data_Listado";
            this.data_Listado.ReadOnly = true;
            this.data_Listado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.data_Listado.Size = new System.Drawing.Size(419, 132);
            this.data_Listado.TabIndex = 7;
            this.data_Listado.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_Listado_CellClick);
            // 
            // lbl_Total_Registro
            // 
            this.lbl_Total_Registro.AutoSize = true;
            this.lbl_Total_Registro.Location = new System.Drawing.Point(574, 58);
            this.lbl_Total_Registro.Name = "lbl_Total_Registro";
            this.lbl_Total_Registro.Size = new System.Drawing.Size(35, 13);
            this.lbl_Total_Registro.TabIndex = 6;
            this.lbl_Total_Registro.Text = "label3";
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.Location = new System.Drawing.Point(69, 285);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(61, 20);
            this.btn_Eliminar.TabIndex = 3;
            this.btn_Eliminar.Text = "&Eliminar";
            this.btn_Eliminar.UseVisualStyleBackColor = true;
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.Location = new System.Drawing.Point(283, 17);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(60, 19);
            this.btn_Buscar.TabIndex = 2;
            this.btn_Buscar.Text = "&Buscar";
            this.btn_Buscar.UseVisualStyleBackColor = true;
            this.btn_Buscar.Click += new System.EventHandler(this.btn_Buscar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre:";
            // 
            // textBox_Buscar
            // 
            this.textBox_Buscar.Location = new System.Drawing.Point(57, 17);
            this.textBox_Buscar.Name = "textBox_Buscar";
            this.textBox_Buscar.Size = new System.Drawing.Size(208, 20);
            this.textBox_Buscar.TabIndex = 0;
            this.textBox_Buscar.TextChanged += new System.EventHandler(this.textBox_Buscar_TextChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(744, 341);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Mantenimiento";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_Guardar);
            this.groupBox1.Controls.Add(this.textBox_Descripcion);
            this.groupBox1.Controls.Add(this.textBox_Nombre);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(54, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(641, 291);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Agregar Categoria";
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.Location = new System.Drawing.Point(156, 171);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(78, 23);
            this.btn_Guardar.TabIndex = 7;
            this.btn_Guardar.Text = "&Guardar";
            this.btn_Guardar.UseVisualStyleBackColor = true;
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // textBox_Descripcion
            // 
            this.textBox_Descripcion.Location = new System.Drawing.Point(113, 91);
            this.textBox_Descripcion.Multiline = true;
            this.textBox_Descripcion.Name = "textBox_Descripcion";
            this.textBox_Descripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_Descripcion.Size = new System.Drawing.Size(187, 45);
            this.textBox_Descripcion.TabIndex = 5;
            // 
            // textBox_Nombre
            // 
            this.textBox_Nombre.Location = new System.Drawing.Point(113, 31);
            this.textBox_Nombre.Name = "textBox_Nombre";
            this.textBox_Nombre.Size = new System.Drawing.Size(151, 20);
            this.textBox_Nombre.TabIndex = 4;
            this.textBox_Nombre.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Descripcion";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Nombre";
            // 
            // frmCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(879, 476);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label_Titulo);
            this.Name = "frmCategoria";
            this.Load += new System.EventHandler(this.frmCategoria_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_Listado)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Titulo;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView data_Listado;
        private System.Windows.Forms.Label lbl_Total_Registro;
        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.Button btn_Buscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_Buscar;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox_Descripcion;
        private System.Windows.Forms.TextBox textBox_Nombre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_Guardar;
        private System.Windows.Forms.Button btn_Editar;
        private System.Windows.Forms.TextBox textBox_Descripp;
        private System.Windows.Forms.TextBox textBox_Nombrep;
        private System.Windows.Forms.TextBox textBox_ID;
        private System.Windows.Forms.Label lbl_Descrippp;
        private System.Windows.Forms.Label lbl_Nombrep;
        private System.Windows.Forms.Label lbl_IDp;
    }
}