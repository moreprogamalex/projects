namespace CapaPresentacion
{
    partial class frmVistaArticulo_venta
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
            this.btn_buscar = new System.Windows.Forms.Button();
            this.textBox_buscar = new System.Windows.Forms.TextBox();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.datos_articulos = new System.Windows.Forms.DataGridView();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.tabControl_principal.SuspendLayout();
            this.tagpage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datos_articulos)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl_principal
            // 
            this.tabControl_principal.Controls.Add(this.tagpage1);
            this.tabControl_principal.Location = new System.Drawing.Point(82, 95);
            this.tabControl_principal.Name = "tabControl_principal";
            this.tabControl_principal.SelectedIndex = 0;
            this.tabControl_principal.Size = new System.Drawing.Size(690, 338);
            this.tabControl_principal.TabIndex = 8;
            // 
            // tagpage1
            // 
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
            // btn_buscar
            // 
            this.btn_buscar.Location = new System.Drawing.Point(378, 54);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(63, 19);
            this.btn_buscar.TabIndex = 18;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // textBox_buscar
            // 
            this.textBox_buscar.Location = new System.Drawing.Point(192, 53);
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
            this.lbl_nombre.Size = new System.Drawing.Size(0, 13);
            this.lbl_nombre.TabIndex = 10;
            // 
            // datos_articulos
            // 
            this.datos_articulos.AllowUserToAddRows = false;
            this.datos_articulos.AllowUserToDeleteRows = false;
            this.datos_articulos.AllowUserToOrderColumns = true;
            this.datos_articulos.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.datos_articulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datos_articulos.Location = new System.Drawing.Point(126, 138);
            this.datos_articulos.Name = "datos_articulos";
            this.datos_articulos.ReadOnly = true;
            this.datos_articulos.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.datos_articulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datos_articulos.Size = new System.Drawing.Size(402, 135);
            this.datos_articulos.TabIndex = 0;
            this.datos_articulos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datos_articulos_CellDoubleClick);
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Bauhaus 93", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbl_titulo.Location = new System.Drawing.Point(82, 46);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(103, 24);
            this.lbl_titulo.TabIndex = 9;
            this.lbl_titulo.Text = "Productos";
            // 
            // frmVistaArticulo_venta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 479);
            this.Controls.Add(this.tabControl_principal);
            this.Controls.Add(this.lbl_titulo);
            this.Name = "frmVistaArticulo_venta";
            this.Text = "Seleciona un Producto";
            this.Load += new System.EventHandler(this.frmVistaArticulo_venta_Load);
            this.tabControl_principal.ResumeLayout(false);
            this.tagpage1.ResumeLayout(false);
            this.tagpage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datos_articulos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl_principal;
        private System.Windows.Forms.TabPage tagpage1;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.TextBox textBox_buscar;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.DataGridView datos_articulos;
        private System.Windows.Forms.Label lbl_titulo;
    }
}