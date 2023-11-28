namespace CapaPresentacion
{
    partial class frmVistaProveedor
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
            this.lbl_ayuda = new System.Windows.Forms.Label();
            this.textBox_opc = new System.Windows.Forms.TextBox();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.lbl_totalregistros = new System.Windows.Forms.Label();
            this.checkBox_eliminar = new System.Windows.Forms.CheckBox();
            this.textBox_buscar = new System.Windows.Forms.TextBox();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.datos_proveedor = new System.Windows.Forms.DataGridView();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.tabControl_principal = new System.Windows.Forms.TabControl();
            this.tagpage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datos_proveedor)).BeginInit();
            this.tabControl_principal.SuspendLayout();
            this.SuspendLayout();
            // 
            // tagpage1
            // 
            this.tagpage1.Controls.Add(this.lbl_ayuda);
            this.tagpage1.Controls.Add(this.textBox_opc);
            this.tagpage1.Controls.Add(this.btn_buscar);
            this.tagpage1.Controls.Add(this.lbl_totalregistros);
            this.tagpage1.Controls.Add(this.checkBox_eliminar);
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
            this.lbl_ayuda.Location = new System.Drawing.Point(98, 50);
            this.lbl_ayuda.Name = "lbl_ayuda";
            this.lbl_ayuda.Size = new System.Drawing.Size(58, 13);
            this.lbl_ayuda.TabIndex = 20;
            this.lbl_ayuda.Text = "Busca por:";
            // 
            // textBox_opc
            // 
            this.textBox_opc.Location = new System.Drawing.Point(171, 47);
            this.textBox_opc.Name = "textBox_opc";
            this.textBox_opc.Size = new System.Drawing.Size(96, 20);
            this.textBox_opc.TabIndex = 19;
            // 
            // btn_buscar
            // 
            this.btn_buscar.Location = new System.Drawing.Point(449, 47);
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
            // 
            // textBox_buscar
            // 
            this.textBox_buscar.Location = new System.Drawing.Point(273, 47);
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
            // datos_proveedor
            // 
            this.datos_proveedor.AllowUserToAddRows = false;
            this.datos_proveedor.AllowUserToDeleteRows = false;
            this.datos_proveedor.AllowUserToOrderColumns = true;
            this.datos_proveedor.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.datos_proveedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datos_proveedor.Location = new System.Drawing.Point(126, 138);
            this.datos_proveedor.Name = "datos_proveedor";
            this.datos_proveedor.ReadOnly = true;
            this.datos_proveedor.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.datos_proveedor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datos_proveedor.Size = new System.Drawing.Size(402, 135);
            this.datos_proveedor.TabIndex = 0;
            this.datos_proveedor.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datos_proveedor_CellDoubleClick);
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Bauhaus 93", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbl_titulo.Location = new System.Drawing.Point(82, 37);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(124, 24);
            this.lbl_titulo.TabIndex = 5;
            this.lbl_titulo.Text = "Proveedores";
            // 
            // tabControl_principal
            // 
            this.tabControl_principal.Controls.Add(this.tagpage1);
            this.tabControl_principal.Location = new System.Drawing.Point(86, 86);
            this.tabControl_principal.Name = "tabControl_principal";
            this.tabControl_principal.SelectedIndex = 0;
            this.tabControl_principal.Size = new System.Drawing.Size(690, 338);
            this.tabControl_principal.TabIndex = 4;
            // 
            // frmVistaProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 460);
            this.Controls.Add(this.lbl_titulo);
            this.Controls.Add(this.tabControl_principal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmVistaProveedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Selecciona un Proveedor";
            this.Load += new System.EventHandler(this.frmVistaProveedor_Load);
            this.tagpage1.ResumeLayout(false);
            this.tagpage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datos_proveedor)).EndInit();
            this.tabControl_principal.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabPage tagpage1;
        private System.Windows.Forms.Label lbl_ayuda;
        private System.Windows.Forms.TextBox textBox_opc;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Label lbl_totalregistros;
        private System.Windows.Forms.CheckBox checkBox_eliminar;
        private System.Windows.Forms.TextBox textBox_buscar;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.DataGridView datos_proveedor;
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.TabControl tabControl_principal;
    }
}