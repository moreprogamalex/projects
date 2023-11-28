namespace CapaPresentacion
{
    partial class frmProveedor
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
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.lbl_telf = new System.Windows.Forms.Label();
            this.lbl_direccion = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.textBox_sitioweb = new System.Windows.Forms.TextBox();
            this.lbl_url = new System.Windows.Forms.Label();
            this.textBox_empresa = new System.Windows.Forms.TextBox();
            this.lbl_gmail = new System.Windows.Forms.Label();
            this.comboBox_sectorcomercial = new System.Windows.Forms.ComboBox();
            this.textBox_telf = new System.Windows.Forms.TextBox();
            this.btn_editar = new System.Windows.Forms.Button();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.textBox_direccion = new System.Windows.Forms.TextBox();
            this.textBox_idproveedor = new System.Windows.Forms.TextBox();
            this.lbl_sectorcomercio = new System.Windows.Forms.Label();
            this.lbl_IDpre = new System.Windows.Forms.Label();
            this.Eliminar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.datos_proveedor = new System.Windows.Forms.DataGridView();
            this.tabControl_principal = new System.Windows.Forms.TabControl();
            this.tagpage1 = new System.Windows.Forms.TabPage();
            this.lbl_ayuda = new System.Windows.Forms.Label();
            this.textBox_opc = new System.Windows.Forms.TextBox();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.lbl_totalregistros = new System.Windows.Forms.Label();
            this.checkBox_eliminar = new System.Windows.Forms.CheckBox();
            this.btn_refrescar = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.textBox_buscar = new System.Windows.Forms.TextBox();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datos_proveedor)).BeginInit();
            this.tabControl_principal.SuspendLayout();
            this.tagpage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Bauhaus 93", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbl_titulo.Location = new System.Drawing.Point(96, 16);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(124, 24);
            this.lbl_titulo.TabIndex = 3;
            this.lbl_titulo.Text = "Proveedores";
            // 
            // lbl_telf
            // 
            this.lbl_telf.AutoSize = true;
            this.lbl_telf.Location = new System.Drawing.Point(329, 69);
            this.lbl_telf.Name = "lbl_telf";
            this.lbl_telf.Size = new System.Drawing.Size(52, 13);
            this.lbl_telf.TabIndex = 19;
            this.lbl_telf.Text = "Telefono:";
            // 
            // lbl_direccion
            // 
            this.lbl_direccion.AutoSize = true;
            this.lbl_direccion.Location = new System.Drawing.Point(310, 189);
            this.lbl_direccion.Name = "lbl_direccion";
            this.lbl_direccion.Size = new System.Drawing.Size(55, 13);
            this.lbl_direccion.TabIndex = 18;
            this.lbl_direccion.Text = "Direccion:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btn_limpiar);
            this.tabPage2.Controls.Add(this.textBox_sitioweb);
            this.tabPage2.Controls.Add(this.lbl_url);
            this.tabPage2.Controls.Add(this.textBox_empresa);
            this.tabPage2.Controls.Add(this.lbl_gmail);
            this.tabPage2.Controls.Add(this.comboBox_sectorcomercial);
            this.tabPage2.Controls.Add(this.lbl_telf);
            this.tabPage2.Controls.Add(this.lbl_direccion);
            this.tabPage2.Controls.Add(this.textBox_telf);
            this.tabPage2.Controls.Add(this.btn_editar);
            this.tabPage2.Controls.Add(this.btn_guardar);
            this.tabPage2.Controls.Add(this.textBox_direccion);
            this.tabPage2.Controls.Add(this.textBox_idproveedor);
            this.tabPage2.Controls.Add(this.lbl_sectorcomercio);
            this.tabPage2.Controls.Add(this.lbl_IDpre);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(682, 312);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Mantenimiento";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.Location = new System.Drawing.Point(447, 268);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(80, 26);
            this.btn_limpiar.TabIndex = 27;
            this.btn_limpiar.Text = "Limpiar";
            this.btn_limpiar.UseVisualStyleBackColor = true;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // textBox_sitioweb
            // 
            this.textBox_sitioweb.Location = new System.Drawing.Point(387, 13);
            this.textBox_sitioweb.Name = "textBox_sitioweb";
            this.textBox_sitioweb.Size = new System.Drawing.Size(117, 20);
            this.textBox_sitioweb.TabIndex = 26;
            // 
            // lbl_url
            // 
            this.lbl_url.AutoSize = true;
            this.lbl_url.Location = new System.Drawing.Point(329, 16);
            this.lbl_url.Name = "lbl_url";
            this.lbl_url.Size = new System.Drawing.Size(56, 13);
            this.lbl_url.TabIndex = 25;
            this.lbl_url.Text = "Sitio Web:";
            // 
            // textBox_empresa
            // 
            this.textBox_empresa.Location = new System.Drawing.Point(387, 116);
            this.textBox_empresa.Name = "textBox_empresa";
            this.textBox_empresa.Size = new System.Drawing.Size(117, 20);
            this.textBox_empresa.TabIndex = 24;
            // 
            // lbl_gmail
            // 
            this.lbl_gmail.AutoSize = true;
            this.lbl_gmail.Location = new System.Drawing.Point(329, 120);
            this.lbl_gmail.Name = "lbl_gmail";
            this.lbl_gmail.Size = new System.Drawing.Size(51, 13);
            this.lbl_gmail.TabIndex = 23;
            this.lbl_gmail.Text = "Empresa:";
            // 
            // comboBox_sectorcomercial
            // 
            this.comboBox_sectorcomercial.FormattingEnabled = true;
            this.comboBox_sectorcomercial.Items.AddRange(new object[] {
            "Tecnología",
            "Electronica",
            "Cervezeria",
            "Gaseosas",
            "Lacteos",
            "Pastelería"});
            this.comboBox_sectorcomercial.Location = new System.Drawing.Point(148, 120);
            this.comboBox_sectorcomercial.Name = "comboBox_sectorcomercial";
            this.comboBox_sectorcomercial.Size = new System.Drawing.Size(113, 21);
            this.comboBox_sectorcomercial.TabIndex = 21;
            this.comboBox_sectorcomercial.Text = "Opcion:";
            // 
            // textBox_telf
            // 
            this.textBox_telf.Location = new System.Drawing.Point(387, 66);
            this.textBox_telf.Name = "textBox_telf";
            this.textBox_telf.Size = new System.Drawing.Size(117, 20);
            this.textBox_telf.TabIndex = 15;
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
            // textBox_direccion
            // 
            this.textBox_direccion.Location = new System.Drawing.Point(387, 172);
            this.textBox_direccion.Multiline = true;
            this.textBox_direccion.Name = "textBox_direccion";
            this.textBox_direccion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_direccion.Size = new System.Drawing.Size(174, 64);
            this.textBox_direccion.TabIndex = 6;
            // 
            // textBox_idproveedor
            // 
            this.textBox_idproveedor.Location = new System.Drawing.Point(154, 34);
            this.textBox_idproveedor.Name = "textBox_idproveedor";
            this.textBox_idproveedor.ReadOnly = true;
            this.textBox_idproveedor.Size = new System.Drawing.Size(82, 20);
            this.textBox_idproveedor.TabIndex = 4;
            // 
            // lbl_sectorcomercio
            // 
            this.lbl_sectorcomercio.AutoSize = true;
            this.lbl_sectorcomercio.Location = new System.Drawing.Point(39, 123);
            this.lbl_sectorcomercio.Name = "lbl_sectorcomercio";
            this.lbl_sectorcomercio.Size = new System.Drawing.Size(90, 13);
            this.lbl_sectorcomercio.TabIndex = 2;
            this.lbl_sectorcomercio.Text = "Sector Comercial:";
            // 
            // lbl_IDpre
            // 
            this.lbl_IDpre.AutoSize = true;
            this.lbl_IDpre.Location = new System.Drawing.Point(99, 37);
            this.lbl_IDpre.Name = "lbl_IDpre";
            this.lbl_IDpre.Size = new System.Drawing.Size(21, 13);
            this.lbl_IDpre.TabIndex = 1;
            this.lbl_IDpre.Text = "ID:";
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            // 
            // datos_proveedor
            // 
            this.datos_proveedor.AllowUserToAddRows = false;
            this.datos_proveedor.AllowUserToDeleteRows = false;
            this.datos_proveedor.AllowUserToOrderColumns = true;
            this.datos_proveedor.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.datos_proveedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datos_proveedor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Eliminar});
            this.datos_proveedor.Location = new System.Drawing.Point(126, 138);
            this.datos_proveedor.Name = "datos_proveedor";
            this.datos_proveedor.ReadOnly = true;
            this.datos_proveedor.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.datos_proveedor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datos_proveedor.Size = new System.Drawing.Size(402, 135);
            this.datos_proveedor.TabIndex = 0;
            this.datos_proveedor.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datos_proveedor_CellClick);
            this.datos_proveedor.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datos_proveedor_CellContentClick);
            // 
            // tabControl_principal
            // 
            this.tabControl_principal.Controls.Add(this.tagpage1);
            this.tabControl_principal.Controls.Add(this.tabPage2);
            this.tabControl_principal.Location = new System.Drawing.Point(96, 65);
            this.tabControl_principal.Name = "tabControl_principal";
            this.tabControl_principal.SelectedIndex = 0;
            this.tabControl_principal.Size = new System.Drawing.Size(690, 338);
            this.tabControl_principal.TabIndex = 2;
            // 
            // tagpage1
            // 
            this.tagpage1.Controls.Add(this.lbl_ayuda);
            this.tagpage1.Controls.Add(this.textBox_opc);
            this.tagpage1.Controls.Add(this.btn_buscar);
            this.tagpage1.Controls.Add(this.lbl_totalregistros);
            this.tagpage1.Controls.Add(this.checkBox_eliminar);
            this.tagpage1.Controls.Add(this.btn_refrescar);
            this.tagpage1.Controls.Add(this.btn_eliminar);
            this.tagpage1.Controls.Add(this.textBox_buscar);
            this.tagpage1.Controls.Add(this.lbl_nombre);
            this.tagpage1.Controls.Add(this.datos_proveedor);
            this.tagpage1.Location = new System.Drawing.Point(4, 22);
            this.tagpage1.Name = "tagpage1";
            this.tagpage1.Padding = new System.Windows.Forms.Padding(3);
            this.tagpage1.Size = new System.Drawing.Size(682, 312);
            this.tagpage1.TabIndex = 0;
            this.tagpage1.Text = "Listado";
            this.tagpage1.UseVisualStyleBackColor = true;
            // 
            // lbl_ayuda
            // 
            this.lbl_ayuda.AutoSize = true;
            this.lbl_ayuda.Location = new System.Drawing.Point(96, 18);
            this.lbl_ayuda.Name = "lbl_ayuda";
            this.lbl_ayuda.Size = new System.Drawing.Size(58, 13);
            this.lbl_ayuda.TabIndex = 20;
            this.lbl_ayuda.Text = "Busca por:";
            // 
            // textBox_opc
            // 
            this.textBox_opc.Location = new System.Drawing.Point(160, 15);
            this.textBox_opc.Name = "textBox_opc";
            this.textBox_opc.Size = new System.Drawing.Size(96, 20);
            this.textBox_opc.TabIndex = 19;
            // 
            // btn_buscar
            // 
            this.btn_buscar.Location = new System.Drawing.Point(470, 15);
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
            // btn_refrescar
            // 
            this.btn_refrescar.Location = new System.Drawing.Point(608, 15);
            this.btn_refrescar.Name = "btn_refrescar";
            this.btn_refrescar.Size = new System.Drawing.Size(68, 20);
            this.btn_refrescar.TabIndex = 14;
            this.btn_refrescar.Text = "Refrescar";
            this.btn_refrescar.UseVisualStyleBackColor = true;
            this.btn_refrescar.Click += new System.EventHandler(this.btn_refrescar_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Location = new System.Drawing.Point(539, 15);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(63, 19);
            this.btn_eliminar.TabIndex = 13;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // textBox_buscar
            // 
            this.textBox_buscar.Location = new System.Drawing.Point(276, 15);
            this.textBox_buscar.Name = "textBox_buscar";
            this.textBox_buscar.Size = new System.Drawing.Size(165, 20);
            this.textBox_buscar.TabIndex = 11;
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Location = new System.Drawing.Point(51, 22);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(0, 13);
            this.lbl_nombre.TabIndex = 10;
            // 
            // frmProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 419);
            this.Controls.Add(this.lbl_titulo);
            this.Controls.Add(this.tabControl_principal);
            this.Name = "frmProveedor";
            this.Load += new System.EventHandler(this.frmProveedor_Load);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datos_proveedor)).EndInit();
            this.tabControl_principal.ResumeLayout(false);
            this.tagpage1.ResumeLayout(false);
            this.tagpage1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Label lbl_telf;
        private System.Windows.Forms.Label lbl_direccion;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox textBox_telf;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.TextBox textBox_direccion;
        private System.Windows.Forms.TextBox textBox_idproveedor;
        private System.Windows.Forms.Label lbl_sectorcomercio;
        private System.Windows.Forms.Label lbl_IDpre;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Eliminar;
        private System.Windows.Forms.DataGridView datos_proveedor;
        private System.Windows.Forms.TabControl tabControl_principal;
        private System.Windows.Forms.TabPage tagpage1;
        private System.Windows.Forms.Label lbl_totalregistros;
        private System.Windows.Forms.CheckBox checkBox_eliminar;
        private System.Windows.Forms.Button btn_refrescar;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.TextBox textBox_buscar;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.ComboBox comboBox_sectorcomercial;
        private System.Windows.Forms.TextBox textBox_sitioweb;
        private System.Windows.Forms.Label lbl_url;
        private System.Windows.Forms.TextBox textBox_empresa;
        private System.Windows.Forms.Label lbl_gmail;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Label lbl_ayuda;
        private System.Windows.Forms.TextBox textBox_opc;
        private System.Windows.Forms.Button btn_limpiar;
    }
}