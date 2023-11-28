namespace CapaPresentacion
{
    partial class frmCliente
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
            this.tagpage1 = new System.Windows.Forms.TabPage();
            this.btn_refrescar = new System.Windows.Forms.Button();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.lbl_totalregistros = new System.Windows.Forms.Label();
            this.checkBox_eliminar = new System.Windows.Forms.CheckBox();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.textBox_buscar = new System.Windows.Forms.TextBox();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.datos_clientes = new System.Windows.Forms.DataGridView();
            this.Eliminar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.lbl_direccion = new System.Windows.Forms.Label();
            this.textBox_nombre = new System.Windows.Forms.TextBox();
            this.lbl_nombrc = new System.Windows.Forms.Label();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.btn_editar = new System.Windows.Forms.Button();
            this.textBox_direccion = new System.Windows.Forms.TextBox();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.lbl_sapellidos = new System.Windows.Forms.Label();
            this.lbl_IDpre = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textBox_sexo = new System.Windows.Forms.TextBox();
            this.lbl_sexo = new System.Windows.Forms.Label();
            this.textBox_apellidos = new System.Windows.Forms.TextBox();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.tabControl_principal = new System.Windows.Forms.TabControl();
            this.tagpage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datos_clientes)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabControl_principal.SuspendLayout();
            this.SuspendLayout();
            // 
            // tagpage1
            // 
            this.tagpage1.Controls.Add(this.btn_refrescar);
            this.tagpage1.Controls.Add(this.btn_buscar);
            this.tagpage1.Controls.Add(this.lbl_totalregistros);
            this.tagpage1.Controls.Add(this.checkBox_eliminar);
            this.tagpage1.Controls.Add(this.btn_eliminar);
            this.tagpage1.Controls.Add(this.textBox_buscar);
            this.tagpage1.Controls.Add(this.lbl_nombre);
            this.tagpage1.Controls.Add(this.datos_clientes);
            this.tagpage1.Location = new System.Drawing.Point(4, 22);
            this.tagpage1.Name = "tagpage1";
            this.tagpage1.Padding = new System.Windows.Forms.Padding(3);
            this.tagpage1.Size = new System.Drawing.Size(682, 312);
            this.tagpage1.TabIndex = 0;
            this.tagpage1.Text = "Listado";
            this.tagpage1.UseVisualStyleBackColor = true;
            // 
            // btn_refrescar
            // 
            this.btn_refrescar.Location = new System.Drawing.Point(471, 16);
            this.btn_refrescar.Name = "btn_refrescar";
            this.btn_refrescar.Size = new System.Drawing.Size(63, 19);
            this.btn_refrescar.TabIndex = 19;
            this.btn_refrescar.Text = "Refrescar";
            this.btn_refrescar.UseVisualStyleBackColor = true;
            this.btn_refrescar.Click += new System.EventHandler(this.btn_refrescar_Click);
            // 
            // btn_buscar
            // 
            this.btn_buscar.Location = new System.Drawing.Point(333, 14);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(63, 19);
            this.btn_buscar.TabIndex = 18;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // lbl_totalregistros
            // 
            this.lbl_totalregistros.AutoSize = true;
            this.lbl_totalregistros.Location = new System.Drawing.Point(477, 101);
            this.lbl_totalregistros.Name = "lbl_totalregistros";
            this.lbl_totalregistros.Size = new System.Drawing.Size(35, 13);
            this.lbl_totalregistros.TabIndex = 16;
            this.lbl_totalregistros.Text = "label1";
            // 
            // checkBox_eliminar
            // 
            this.checkBox_eliminar.AutoSize = true;
            this.checkBox_eliminar.Location = new System.Drawing.Point(126, 97);
            this.checkBox_eliminar.Name = "checkBox_eliminar";
            this.checkBox_eliminar.Size = new System.Drawing.Size(62, 17);
            this.checkBox_eliminar.TabIndex = 15;
            this.checkBox_eliminar.Text = "Eliminar";
            this.checkBox_eliminar.UseVisualStyleBackColor = true;
            this.checkBox_eliminar.CheckedChanged += new System.EventHandler(this.checkBox_eliminar_CheckedChanged);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Location = new System.Drawing.Point(402, 14);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(63, 19);
            this.btn_eliminar.TabIndex = 13;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // textBox_buscar
            // 
            this.textBox_buscar.Location = new System.Drawing.Point(162, 14);
            this.textBox_buscar.Name = "textBox_buscar";
            this.textBox_buscar.Size = new System.Drawing.Size(165, 20);
            this.textBox_buscar.TabIndex = 11;
            this.textBox_buscar.TextChanged += new System.EventHandler(this.textBox_buscar_TextChanged_1);
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Location = new System.Drawing.Point(51, 22);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(0, 13);
            this.lbl_nombre.TabIndex = 10;
            // 
            // datos_clientes
            // 
            this.datos_clientes.AllowUserToAddRows = false;
            this.datos_clientes.AllowUserToDeleteRows = false;
            this.datos_clientes.AllowUserToOrderColumns = true;
            this.datos_clientes.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.datos_clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datos_clientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Eliminar});
            this.datos_clientes.Location = new System.Drawing.Point(126, 138);
            this.datos_clientes.Name = "datos_clientes";
            this.datos_clientes.ReadOnly = true;
            this.datos_clientes.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.datos_clientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datos_clientes.Size = new System.Drawing.Size(402, 135);
            this.datos_clientes.TabIndex = 0;
            this.datos_clientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datos_clientes_CellClick);
            this.datos_clientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datos_clientes_CellContentClick);
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            // 
            // lbl_direccion
            // 
            this.lbl_direccion.AutoSize = true;
            this.lbl_direccion.Location = new System.Drawing.Point(338, 129);
            this.lbl_direccion.Name = "lbl_direccion";
            this.lbl_direccion.Size = new System.Drawing.Size(55, 13);
            this.lbl_direccion.TabIndex = 18;
            this.lbl_direccion.Text = "Direccion:";
            // 
            // textBox_nombre
            // 
            this.textBox_nombre.Location = new System.Drawing.Point(154, 102);
            this.textBox_nombre.Multiline = true;
            this.textBox_nombre.Name = "textBox_nombre";
            this.textBox_nombre.Size = new System.Drawing.Size(120, 19);
            this.textBox_nombre.TabIndex = 10;
            // 
            // lbl_nombrc
            // 
            this.lbl_nombrc.AutoSize = true;
            this.lbl_nombrc.Location = new System.Drawing.Point(96, 102);
            this.lbl_nombrc.Name = "lbl_nombrc";
            this.lbl_nombrc.Size = new System.Drawing.Size(52, 13);
            this.lbl_nombrc.TabIndex = 9;
            this.lbl_nombrc.Text = "Nombres:";
            // 
            // btn_guardar
            // 
            this.btn_guardar.Location = new System.Drawing.Point(154, 268);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(107, 26);
            this.btn_guardar.TabIndex = 7;
            this.btn_guardar.Text = "Guardar Nuevo";
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // btn_editar
            // 
            this.btn_editar.Location = new System.Drawing.Point(313, 268);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(80, 26);
            this.btn_editar.TabIndex = 8;
            this.btn_editar.Text = "Editar";
            this.btn_editar.UseVisualStyleBackColor = true;
            this.btn_editar.Click += new System.EventHandler(this.btn_editar_Click);
            // 
            // textBox_direccion
            // 
            this.textBox_direccion.Location = new System.Drawing.Point(399, 102);
            this.textBox_direccion.Multiline = true;
            this.textBox_direccion.Name = "textBox_direccion";
            this.textBox_direccion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_direccion.Size = new System.Drawing.Size(174, 64);
            this.textBox_direccion.TabIndex = 6;
            // 
            // textBox_id
            // 
            this.textBox_id.Location = new System.Drawing.Point(154, 53);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.ReadOnly = true;
            this.textBox_id.Size = new System.Drawing.Size(51, 20);
            this.textBox_id.TabIndex = 4;
            // 
            // lbl_sapellidos
            // 
            this.lbl_sapellidos.AutoSize = true;
            this.lbl_sapellidos.Location = new System.Drawing.Point(96, 150);
            this.lbl_sapellidos.Name = "lbl_sapellidos";
            this.lbl_sapellidos.Size = new System.Drawing.Size(52, 13);
            this.lbl_sapellidos.TabIndex = 2;
            this.lbl_sapellidos.Text = "Apellidos:";
            // 
            // lbl_IDpre
            // 
            this.lbl_IDpre.AutoSize = true;
            this.lbl_IDpre.Location = new System.Drawing.Point(117, 56);
            this.lbl_IDpre.Name = "lbl_IDpre";
            this.lbl_IDpre.Size = new System.Drawing.Size(21, 13);
            this.lbl_IDpre.TabIndex = 1;
            this.lbl_IDpre.Text = "ID:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.textBox_sexo);
            this.tabPage2.Controls.Add(this.lbl_sexo);
            this.tabPage2.Controls.Add(this.textBox_apellidos);
            this.tabPage2.Controls.Add(this.textBox_direccion);
            this.tabPage2.Controls.Add(this.lbl_direccion);
            this.tabPage2.Controls.Add(this.textBox_nombre);
            this.tabPage2.Controls.Add(this.lbl_nombrc);
            this.tabPage2.Controls.Add(this.btn_editar);
            this.tabPage2.Controls.Add(this.btn_guardar);
            this.tabPage2.Controls.Add(this.textBox_id);
            this.tabPage2.Controls.Add(this.lbl_sapellidos);
            this.tabPage2.Controls.Add(this.lbl_IDpre);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(682, 312);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Mantenimiento";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // textBox_sexo
            // 
            this.textBox_sexo.Location = new System.Drawing.Point(154, 187);
            this.textBox_sexo.Multiline = true;
            this.textBox_sexo.Name = "textBox_sexo";
            this.textBox_sexo.Size = new System.Drawing.Size(120, 19);
            this.textBox_sexo.TabIndex = 29;
            // 
            // lbl_sexo
            // 
            this.lbl_sexo.AutoSize = true;
            this.lbl_sexo.Location = new System.Drawing.Point(104, 190);
            this.lbl_sexo.Name = "lbl_sexo";
            this.lbl_sexo.Size = new System.Drawing.Size(34, 13);
            this.lbl_sexo.TabIndex = 28;
            this.lbl_sexo.Text = "Sexo:";
            // 
            // textBox_apellidos
            // 
            this.textBox_apellidos.Location = new System.Drawing.Point(154, 147);
            this.textBox_apellidos.Multiline = true;
            this.textBox_apellidos.Name = "textBox_apellidos";
            this.textBox_apellidos.Size = new System.Drawing.Size(120, 19);
            this.textBox_apellidos.TabIndex = 27;
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Bauhaus 93", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbl_titulo.Location = new System.Drawing.Point(93, 37);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(88, 24);
            this.lbl_titulo.TabIndex = 5;
            this.lbl_titulo.Text = "Clientes";
            // 
            // tabControl_principal
            // 
            this.tabControl_principal.Controls.Add(this.tagpage1);
            this.tabControl_principal.Controls.Add(this.tabPage2);
            this.tabControl_principal.Location = new System.Drawing.Point(93, 86);
            this.tabControl_principal.Name = "tabControl_principal";
            this.tabControl_principal.SelectedIndex = 0;
            this.tabControl_principal.Size = new System.Drawing.Size(690, 338);
            this.tabControl_principal.TabIndex = 4;
            // 
            // frmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 460);
            this.Controls.Add(this.lbl_titulo);
            this.Controls.Add(this.tabControl_principal);
            this.Name = "frmCliente";
            this.Load += new System.EventHandler(this.frmCliente_Load);
            this.tagpage1.ResumeLayout(false);
            this.tagpage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datos_clientes)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabControl_principal.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabPage tagpage1;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Label lbl_totalregistros;
        private System.Windows.Forms.CheckBox checkBox_eliminar;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.TextBox textBox_buscar;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.DataGridView datos_clientes;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Eliminar;
        private System.Windows.Forms.Label lbl_direccion;
        private System.Windows.Forms.TextBox textBox_nombre;
        private System.Windows.Forms.Label lbl_nombrc;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.TextBox textBox_direccion;
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.Label lbl_sapellidos;
        private System.Windows.Forms.Label lbl_IDpre;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.TabControl tabControl_principal;
        private System.Windows.Forms.TextBox textBox_apellidos;
        private System.Windows.Forms.TextBox textBox_sexo;
        private System.Windows.Forms.Label lbl_sexo;
        private System.Windows.Forms.Button btn_refrescar;
    }
}