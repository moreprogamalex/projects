namespace CapaPresentacion
{
    partial class frmArticulo
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
            this.tabControl_principal = new System.Windows.Forms.TabControl();
            this.tagpage1 = new System.Windows.Forms.TabPage();
            this.lbl_total = new System.Windows.Forms.Label();
            this.checkBox_eliminar = new System.Windows.Forms.CheckBox();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.textBox_buscar = new System.Windows.Forms.TextBox();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.datos_articulos = new System.Windows.Forms.DataGridView();
            this.Eliminar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btn_buscarcategoria = new System.Windows.Forms.Button();
            this.lbl_nombrecategoria = new System.Windows.Forms.Label();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.lbl_idcategoria = new System.Windows.Forms.Label();
            this.textBox_categoria = new System.Windows.Forms.TextBox();
            this.textBox_idcategoria = new System.Windows.Forms.TextBox();
            this.lbl_codigoventa = new System.Windows.Forms.Label();
            this.btn_editar = new System.Windows.Forms.Button();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.textBox_nombrearti = new System.Windows.Forms.TextBox();
            this.textBox_idarticulo = new System.Windows.Forms.TextBox();
            this.lbl_descripcionpre = new System.Windows.Forms.Label();
            this.lbl_nombrepre = new System.Windows.Forms.Label();
            this.lbl_IDpre = new System.Windows.Forms.Label();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.tabControl_principal.SuspendLayout();
            this.tagpage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datos_articulos)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl_principal
            // 
            this.tabControl_principal.Controls.Add(this.tagpage1);
            this.tabControl_principal.Controls.Add(this.tabPage2);
            this.tabControl_principal.Location = new System.Drawing.Point(101, 71);
            this.tabControl_principal.Name = "tabControl_principal";
            this.tabControl_principal.SelectedIndex = 0;
            this.tabControl_principal.Size = new System.Drawing.Size(690, 338);
            this.tabControl_principal.TabIndex = 0;
            // 
            // tagpage1
            // 
            this.tagpage1.Controls.Add(this.lbl_total);
            this.tagpage1.Controls.Add(this.checkBox_eliminar);
            this.tagpage1.Controls.Add(this.btn_buscar);
            this.tagpage1.Controls.Add(this.textBox_buscar);
            this.tagpage1.Controls.Add(this.lbl_nombre);
            this.tagpage1.Controls.Add(this.datos_articulos);
            this.tagpage1.Location = new System.Drawing.Point(4, 22);
            this.tagpage1.Name = "tagpage1";
            this.tagpage1.Padding = new System.Windows.Forms.Padding(3);
            this.tagpage1.Size = new System.Drawing.Size(682, 312);
            this.tagpage1.TabIndex = 0;
            this.tagpage1.Text = "Listado";
            this.tagpage1.UseVisualStyleBackColor = true;
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.Location = new System.Drawing.Point(446, 101);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(35, 13);
            this.lbl_total.TabIndex = 16;
            this.lbl_total.Text = "label1";
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
            // btn_buscar
            // 
            this.btn_buscar.Location = new System.Drawing.Point(290, 19);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(64, 20);
            this.btn_buscar.TabIndex = 12;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // textBox_buscar
            // 
            this.textBox_buscar.Location = new System.Drawing.Point(104, 19);
            this.textBox_buscar.Name = "textBox_buscar";
            this.textBox_buscar.Size = new System.Drawing.Size(165, 20);
            this.textBox_buscar.TabIndex = 11;
            this.textBox_buscar.TextChanged += new System.EventHandler(this.textBox_buscar_TextChanged);
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Location = new System.Drawing.Point(51, 22);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(47, 13);
            this.lbl_nombre.TabIndex = 10;
            this.lbl_nombre.Text = "Nombre:";
            // 
            // datos_articulos
            // 
            this.datos_articulos.AllowUserToAddRows = false;
            this.datos_articulos.AllowUserToDeleteRows = false;
            this.datos_articulos.AllowUserToOrderColumns = true;
            this.datos_articulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datos_articulos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Eliminar});
            this.datos_articulos.Location = new System.Drawing.Point(126, 138);
            this.datos_articulos.Name = "datos_articulos";
            this.datos_articulos.ReadOnly = true;
            this.datos_articulos.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.datos_articulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datos_articulos.Size = new System.Drawing.Size(402, 135);
            this.datos_articulos.TabIndex = 0;
            this.datos_articulos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datos_articulos_CellClick);
            this.datos_articulos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datos_articulos_CellContentClick);
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btn_buscarcategoria);
            this.tabPage2.Controls.Add(this.lbl_nombrecategoria);
            this.tabPage2.Controls.Add(this.btn_eliminar);
            this.tabPage2.Controls.Add(this.lbl_idcategoria);
            this.tabPage2.Controls.Add(this.textBox_categoria);
            this.tabPage2.Controls.Add(this.textBox_idcategoria);
            this.tabPage2.Controls.Add(this.lbl_codigoventa);
            this.tabPage2.Controls.Add(this.btn_editar);
            this.tabPage2.Controls.Add(this.btn_guardar);
            this.tabPage2.Controls.Add(this.textBox_nombrearti);
            this.tabPage2.Controls.Add(this.textBox_idarticulo);
            this.tabPage2.Controls.Add(this.lbl_descripcionpre);
            this.tabPage2.Controls.Add(this.lbl_nombrepre);
            this.tabPage2.Controls.Add(this.lbl_IDpre);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(682, 312);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Mantenimiento";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btn_buscarcategoria
            // 
            this.btn_buscarcategoria.Location = new System.Drawing.Point(579, 120);
            this.btn_buscarcategoria.Name = "btn_buscarcategoria";
            this.btn_buscarcategoria.Size = new System.Drawing.Size(69, 26);
            this.btn_buscarcategoria.TabIndex = 20;
            this.btn_buscarcategoria.Text = "Buscar";
            this.btn_buscarcategoria.UseVisualStyleBackColor = true;
            this.btn_buscarcategoria.Click += new System.EventHandler(this.btn_buscarcategoria_Click);
            // 
            // lbl_nombrecategoria
            // 
            this.lbl_nombrecategoria.AutoSize = true;
            this.lbl_nombrecategoria.Location = new System.Drawing.Point(380, 124);
            this.lbl_nombrecategoria.Name = "lbl_nombrecategoria";
            this.lbl_nombrecategoria.Size = new System.Drawing.Size(55, 13);
            this.lbl_nombrecategoria.TabIndex = 18;
            this.lbl_nombrecategoria.Text = "Categoria:";
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Location = new System.Drawing.Point(466, 209);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(93, 28);
            this.btn_eliminar.TabIndex = 13;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // lbl_idcategoria
            // 
            this.lbl_idcategoria.AutoSize = true;
            this.lbl_idcategoria.Location = new System.Drawing.Point(366, 86);
            this.lbl_idcategoria.Name = "lbl_idcategoria";
            this.lbl_idcategoria.Size = new System.Drawing.Size(69, 13);
            this.lbl_idcategoria.TabIndex = 17;
            this.lbl_idcategoria.Text = "ID Categoria:";
            // 
            // textBox_categoria
            // 
            this.textBox_categoria.Location = new System.Drawing.Point(456, 121);
            this.textBox_categoria.Name = "textBox_categoria";
            this.textBox_categoria.Size = new System.Drawing.Size(117, 20);
            this.textBox_categoria.TabIndex = 15;
            // 
            // textBox_idcategoria
            // 
            this.textBox_idcategoria.Location = new System.Drawing.Point(456, 79);
            this.textBox_idcategoria.Name = "textBox_idcategoria";
            this.textBox_idcategoria.Size = new System.Drawing.Size(49, 20);
            this.textBox_idcategoria.TabIndex = 14;
            // 
            // lbl_codigoventa
            // 
            this.lbl_codigoventa.AutoSize = true;
            this.lbl_codigoventa.Location = new System.Drawing.Point(21, 90);
            this.lbl_codigoventa.Name = "lbl_codigoventa";
            this.lbl_codigoventa.Size = new System.Drawing.Size(0, 13);
            this.lbl_codigoventa.TabIndex = 9;
            // 
            // btn_editar
            // 
            this.btn_editar.Location = new System.Drawing.Point(342, 211);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(93, 26);
            this.btn_editar.TabIndex = 8;
            this.btn_editar.Text = "Editar";
            this.btn_editar.UseVisualStyleBackColor = true;
            this.btn_editar.Click += new System.EventHandler(this.btn_editar_Click);
            // 
            // btn_guardar
            // 
            this.btn_guardar.Location = new System.Drawing.Point(211, 211);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(107, 26);
            this.btn_guardar.TabIndex = 7;
            this.btn_guardar.Text = "Guardar Nuevo";
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // textBox_nombrearti
            // 
            this.textBox_nombrearti.Location = new System.Drawing.Point(166, 117);
            this.textBox_nombrearti.Name = "textBox_nombrearti";
            this.textBox_nombrearti.Size = new System.Drawing.Size(126, 20);
            this.textBox_nombrearti.TabIndex = 5;
            // 
            // textBox_idarticulo
            // 
            this.textBox_idarticulo.Location = new System.Drawing.Point(166, 83);
            this.textBox_idarticulo.Name = "textBox_idarticulo";
            this.textBox_idarticulo.Size = new System.Drawing.Size(62, 20);
            this.textBox_idarticulo.TabIndex = 4;
            // 
            // lbl_descripcionpre
            // 
            this.lbl_descripcionpre.AutoSize = true;
            this.lbl_descripcionpre.Location = new System.Drawing.Point(34, 211);
            this.lbl_descripcionpre.Name = "lbl_descripcionpre";
            this.lbl_descripcionpre.Size = new System.Drawing.Size(0, 13);
            this.lbl_descripcionpre.TabIndex = 3;
            // 
            // lbl_nombrepre
            // 
            this.lbl_nombrepre.AutoSize = true;
            this.lbl_nombrepre.Location = new System.Drawing.Point(91, 120);
            this.lbl_nombrepre.Name = "lbl_nombrepre";
            this.lbl_nombrepre.Size = new System.Drawing.Size(47, 13);
            this.lbl_nombrepre.TabIndex = 2;
            this.lbl_nombrepre.Text = "Nombre:";
            // 
            // lbl_IDpre
            // 
            this.lbl_IDpre.AutoSize = true;
            this.lbl_IDpre.Location = new System.Drawing.Point(79, 86);
            this.lbl_IDpre.Name = "lbl_IDpre";
            this.lbl_IDpre.Size = new System.Drawing.Size(59, 13);
            this.lbl_IDpre.TabIndex = 1;
            this.lbl_IDpre.Text = "ID Articulo:";
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Bauhaus 93", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbl_titulo.Location = new System.Drawing.Point(101, 22);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(103, 24);
            this.lbl_titulo.TabIndex = 1;
            this.lbl_titulo.Text = "Productos";
            // 
            // frmArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 450);
            this.Controls.Add(this.lbl_titulo);
            this.Controls.Add(this.tabControl_principal);
            this.Name = "frmArticulo";
            this.Load += new System.EventHandler(this.frmArticulo_Load);
            this.tabControl_principal.ResumeLayout(false);
            this.tagpage1.ResumeLayout(false);
            this.tagpage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datos_articulos)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl_principal;
        private System.Windows.Forms.TabPage tagpage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.DataGridView datos_articulos;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Eliminar;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.TextBox textBox_buscar;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.CheckBox checkBox_eliminar;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.Label lbl_IDpre;
        private System.Windows.Forms.Label lbl_nombrepre;
        private System.Windows.Forms.Label lbl_descripcionpre;
        private System.Windows.Forms.TextBox textBox_idarticulo;
        private System.Windows.Forms.TextBox textBox_nombrearti;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.Label lbl_idcategoria;
        private System.Windows.Forms.TextBox textBox_categoria;
        private System.Windows.Forms.TextBox textBox_idcategoria;
        private System.Windows.Forms.Label lbl_codigoventa;
        private System.Windows.Forms.Label lbl_nombrecategoria;
        private System.Windows.Forms.Button btn_buscarcategoria;
    }
}