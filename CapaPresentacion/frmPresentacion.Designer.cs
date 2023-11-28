namespace CapaPresentacion
{
    partial class frmPresentacion
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
            this.tabcontrol_principal = new System.Windows.Forms.TabControl();
            this.tabp_listado = new System.Windows.Forms.TabPage();
            this.lbl_total = new System.Windows.Forms.Label();
            this.checkBox_eliminar = new System.Windows.Forms.CheckBox();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.btn_imprimir = new System.Windows.Forms.Button();
            this.textBox_buscar = new System.Windows.Forms.TextBox();
            this.dataGridView_tabla_presentacion = new System.Windows.Forms.DataGridView();
            this.Eliminar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tabPage_mantenimiento = new System.Windows.Forms.TabPage();
            this.btn_editar = new System.Windows.Forms.Button();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.textBox_decripcionpre = new System.Windows.Forms.TextBox();
            this.textBox_nombrepre = new System.Windows.Forms.TextBox();
            this.textBox_idpre = new System.Windows.Forms.TextBox();
            this.lbl_descripcionpre = new System.Windows.Forms.Label();
            this.lbl_nombrepre = new System.Windows.Forms.Label();
            this.lbl_IDpre = new System.Windows.Forms.Label();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.tabcontrol_principal.SuspendLayout();
            this.tabp_listado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_tabla_presentacion)).BeginInit();
            this.tabPage_mantenimiento.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabcontrol_principal
            // 
            this.tabcontrol_principal.Controls.Add(this.tabp_listado);
            this.tabcontrol_principal.Controls.Add(this.tabPage_mantenimiento);
            this.tabcontrol_principal.Location = new System.Drawing.Point(36, 54);
            this.tabcontrol_principal.Name = "tabcontrol_principal";
            this.tabcontrol_principal.SelectedIndex = 0;
            this.tabcontrol_principal.Size = new System.Drawing.Size(726, 325);
            this.tabcontrol_principal.TabIndex = 0;
            // 
            // tabp_listado
            // 
            this.tabp_listado.Controls.Add(this.lbl_total);
            this.tabp_listado.Controls.Add(this.checkBox_eliminar);
            this.tabp_listado.Controls.Add(this.lbl_nombre);
            this.tabp_listado.Controls.Add(this.btn_eliminar);
            this.tabp_listado.Controls.Add(this.btn_buscar);
            this.tabp_listado.Controls.Add(this.btn_imprimir);
            this.tabp_listado.Controls.Add(this.textBox_buscar);
            this.tabp_listado.Controls.Add(this.dataGridView_tabla_presentacion);
            this.tabp_listado.Location = new System.Drawing.Point(4, 22);
            this.tabp_listado.Name = "tabp_listado";
            this.tabp_listado.Padding = new System.Windows.Forms.Padding(3);
            this.tabp_listado.Size = new System.Drawing.Size(718, 299);
            this.tabp_listado.TabIndex = 0;
            this.tabp_listado.Text = "Listado";
            this.tabp_listado.UseVisualStyleBackColor = true;
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.Location = new System.Drawing.Point(344, 81);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(35, 13);
            this.lbl_total.TabIndex = 11;
            this.lbl_total.Text = "label1";
            // 
            // checkBox_eliminar
            // 
            this.checkBox_eliminar.AutoSize = true;
            this.checkBox_eliminar.Location = new System.Drawing.Point(123, 83);
            this.checkBox_eliminar.Name = "checkBox_eliminar";
            this.checkBox_eliminar.Size = new System.Drawing.Size(62, 17);
            this.checkBox_eliminar.TabIndex = 10;
            this.checkBox_eliminar.Text = "Eliminar";
            this.checkBox_eliminar.UseVisualStyleBackColor = true;
            this.checkBox_eliminar.CheckedChanged += new System.EventHandler(this.checkBox_eliminar_CheckedChanged);
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Location = new System.Drawing.Point(70, 18);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(47, 13);
            this.lbl_nombre.TabIndex = 9;
            this.lbl_nombre.Text = "Nombre:";
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Location = new System.Drawing.Point(386, 15);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(63, 19);
            this.btn_eliminar.TabIndex = 8;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // btn_buscar
            // 
            this.btn_buscar.Location = new System.Drawing.Point(316, 14);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(64, 20);
            this.btn_buscar.TabIndex = 7;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // btn_imprimir
            // 
            this.btn_imprimir.Location = new System.Drawing.Point(455, 14);
            this.btn_imprimir.Name = "btn_imprimir";
            this.btn_imprimir.Size = new System.Drawing.Size(52, 20);
            this.btn_imprimir.TabIndex = 5;
            this.btn_imprimir.Text = "Imprimir";
            this.btn_imprimir.UseVisualStyleBackColor = true;
            // 
            // textBox_buscar
            // 
            this.textBox_buscar.Location = new System.Drawing.Point(123, 15);
            this.textBox_buscar.Name = "textBox_buscar";
            this.textBox_buscar.Size = new System.Drawing.Size(165, 20);
            this.textBox_buscar.TabIndex = 1;
            // 
            // dataGridView_tabla_presentacion
            // 
            this.dataGridView_tabla_presentacion.AllowUserToAddRows = false;
            this.dataGridView_tabla_presentacion.AllowUserToDeleteRows = false;
            this.dataGridView_tabla_presentacion.AllowUserToOrderColumns = true;
            this.dataGridView_tabla_presentacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_tabla_presentacion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Eliminar});
            this.dataGridView_tabla_presentacion.Location = new System.Drawing.Point(123, 122);
            this.dataGridView_tabla_presentacion.MultiSelect = false;
            this.dataGridView_tabla_presentacion.Name = "dataGridView_tabla_presentacion";
            this.dataGridView_tabla_presentacion.ReadOnly = true;
            this.dataGridView_tabla_presentacion.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dataGridView_tabla_presentacion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_tabla_presentacion.Size = new System.Drawing.Size(312, 109);
            this.dataGridView_tabla_presentacion.TabIndex = 0;
            this.dataGridView_tabla_presentacion.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_tabla_presentacion_CellClick);
            this.dataGridView_tabla_presentacion.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_tabla_presentacion_CellContentClick);
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            // 
            // tabPage_mantenimiento
            // 
            this.tabPage_mantenimiento.Controls.Add(this.btn_editar);
            this.tabPage_mantenimiento.Controls.Add(this.btn_guardar);
            this.tabPage_mantenimiento.Controls.Add(this.textBox_decripcionpre);
            this.tabPage_mantenimiento.Controls.Add(this.textBox_nombrepre);
            this.tabPage_mantenimiento.Controls.Add(this.textBox_idpre);
            this.tabPage_mantenimiento.Controls.Add(this.lbl_descripcionpre);
            this.tabPage_mantenimiento.Controls.Add(this.lbl_nombrepre);
            this.tabPage_mantenimiento.Controls.Add(this.lbl_IDpre);
            this.tabPage_mantenimiento.Location = new System.Drawing.Point(4, 22);
            this.tabPage_mantenimiento.Name = "tabPage_mantenimiento";
            this.tabPage_mantenimiento.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_mantenimiento.Size = new System.Drawing.Size(718, 299);
            this.tabPage_mantenimiento.TabIndex = 1;
            this.tabPage_mantenimiento.Text = "Mantenimiento";
            this.tabPage_mantenimiento.UseVisualStyleBackColor = true;
            // 
            // btn_editar
            // 
            this.btn_editar.Location = new System.Drawing.Point(274, 229);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(80, 26);
            this.btn_editar.TabIndex = 7;
            this.btn_editar.Text = "Editar";
            this.btn_editar.UseVisualStyleBackColor = true;
            this.btn_editar.Click += new System.EventHandler(this.btn_editar_Click);
            // 
            // btn_guardar
            // 
            this.btn_guardar.Location = new System.Drawing.Point(127, 229);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(107, 26);
            this.btn_guardar.TabIndex = 6;
            this.btn_guardar.Text = "Guardar Nuevo";
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // textBox_decripcionpre
            // 
            this.textBox_decripcionpre.Location = new System.Drawing.Point(146, 133);
            this.textBox_decripcionpre.Multiline = true;
            this.textBox_decripcionpre.Name = "textBox_decripcionpre";
            this.textBox_decripcionpre.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_decripcionpre.Size = new System.Drawing.Size(174, 64);
            this.textBox_decripcionpre.TabIndex = 5;
            // 
            // textBox_nombrepre
            // 
            this.textBox_nombrepre.Location = new System.Drawing.Point(146, 83);
            this.textBox_nombrepre.Name = "textBox_nombrepre";
            this.textBox_nombrepre.Size = new System.Drawing.Size(126, 20);
            this.textBox_nombrepre.TabIndex = 4;
            // 
            // textBox_idpre
            // 
            this.textBox_idpre.Location = new System.Drawing.Point(145, 27);
            this.textBox_idpre.Name = "textBox_idpre";
            this.textBox_idpre.Size = new System.Drawing.Size(127, 20);
            this.textBox_idpre.TabIndex = 3;
            // 
            // lbl_descripcionpre
            // 
            this.lbl_descripcionpre.AutoSize = true;
            this.lbl_descripcionpre.Location = new System.Drawing.Point(73, 140);
            this.lbl_descripcionpre.Name = "lbl_descripcionpre";
            this.lbl_descripcionpre.Size = new System.Drawing.Size(66, 13);
            this.lbl_descripcionpre.TabIndex = 2;
            this.lbl_descripcionpre.Text = "Descripcion:";
            // 
            // lbl_nombrepre
            // 
            this.lbl_nombrepre.AutoSize = true;
            this.lbl_nombrepre.Location = new System.Drawing.Point(73, 86);
            this.lbl_nombrepre.Name = "lbl_nombrepre";
            this.lbl_nombrepre.Size = new System.Drawing.Size(47, 13);
            this.lbl_nombrepre.TabIndex = 1;
            this.lbl_nombrepre.Text = "Nombre:";
            // 
            // lbl_IDpre
            // 
            this.lbl_IDpre.AutoSize = true;
            this.lbl_IDpre.Location = new System.Drawing.Point(82, 30);
            this.lbl_IDpre.Name = "lbl_IDpre";
            this.lbl_IDpre.Size = new System.Drawing.Size(21, 13);
            this.lbl_IDpre.TabIndex = 0;
            this.lbl_IDpre.Text = "ID:";
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbl_titulo.Location = new System.Drawing.Point(39, 17);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(166, 21);
            this.lbl_titulo.TabIndex = 1;
            this.lbl_titulo.Text = "Presentacion";
            // 
            // frmPresentacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 391);
            this.Controls.Add(this.lbl_titulo);
            this.Controls.Add(this.tabcontrol_principal);
            this.Name = "frmPresentacion";
            this.Load += new System.EventHandler(this.frmPresentacion_Load);
            this.tabcontrol_principal.ResumeLayout(false);
            this.tabp_listado.ResumeLayout(false);
            this.tabp_listado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_tabla_presentacion)).EndInit();
            this.tabPage_mantenimiento.ResumeLayout(false);
            this.tabPage_mantenimiento.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabcontrol_principal;
        private System.Windows.Forms.TabPage tabp_listado;
        private System.Windows.Forms.TabPage tabPage_mantenimiento;
        private System.Windows.Forms.DataGridView dataGridView_tabla_presentacion;
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.TextBox textBox_buscar;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Button btn_imprimir;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.CheckBox checkBox_eliminar;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.TextBox textBox_decripcionpre;
        private System.Windows.Forms.TextBox textBox_nombrepre;
        private System.Windows.Forms.TextBox textBox_idpre;
        private System.Windows.Forms.Label lbl_descripcionpre;
        private System.Windows.Forms.Label lbl_nombrepre;
        private System.Windows.Forms.Label lbl_IDpre;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Eliminar;
    }
}