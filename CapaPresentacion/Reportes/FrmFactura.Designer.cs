
namespace CapaPresentacion
{
    partial class FrmFactura
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFactura));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_valorfecha = new System.Windows.Forms.Label();
            this.lbl_valorcliente = new System.Windows.Forms.Label();
            this.lbl_valortrabajador = new System.Windows.Forms.Label();
            this.lbl_fecha = new System.Windows.Forms.Label();
            this.lbl_cliente = new System.Windows.Forms.Label();
            this.lbl_trabajador = new System.Windows.Forms.Label();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.datos = new System.Windows.Forms.DataGridView();
            this.btn_imprimir = new System.Windows.Forms.Button();
            this.lbl_msefectivo = new System.Windows.Forms.Label();
            this.tb_efectivo = new System.Windows.Forms.TextBox();
            this.lbl_cambio = new System.Windows.Forms.Label();
            this.tb_cambio = new System.Windows.Forms.TextBox();
            this.lbl_total = new System.Windows.Forms.Label();
            this.tb_total = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Controls.Add(this.lbl_valorfecha);
            this.groupBox1.Controls.Add(this.lbl_valorcliente);
            this.groupBox1.Controls.Add(this.lbl_valortrabajador);
            this.groupBox1.Controls.Add(this.lbl_fecha);
            this.groupBox1.Controls.Add(this.lbl_cliente);
            this.groupBox1.Controls.Add(this.lbl_trabajador);
            this.groupBox1.Controls.Add(this.lbl_titulo);
            this.groupBox1.Location = new System.Drawing.Point(12, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(518, 210);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // lbl_valorfecha
            // 
            this.lbl_valorfecha.AutoSize = true;
            this.lbl_valorfecha.Location = new System.Drawing.Point(126, 161);
            this.lbl_valorfecha.Name = "lbl_valorfecha";
            this.lbl_valorfecha.Size = new System.Drawing.Size(35, 13);
            this.lbl_valorfecha.TabIndex = 7;
            this.lbl_valorfecha.Text = "label1";
            // 
            // lbl_valorcliente
            // 
            this.lbl_valorcliente.AutoSize = true;
            this.lbl_valorcliente.Location = new System.Drawing.Point(126, 112);
            this.lbl_valorcliente.Name = "lbl_valorcliente";
            this.lbl_valorcliente.Size = new System.Drawing.Size(35, 13);
            this.lbl_valorcliente.TabIndex = 6;
            this.lbl_valorcliente.Text = "label1";
            // 
            // lbl_valortrabajador
            // 
            this.lbl_valortrabajador.AutoSize = true;
            this.lbl_valortrabajador.Location = new System.Drawing.Point(126, 64);
            this.lbl_valortrabajador.Name = "lbl_valortrabajador";
            this.lbl_valortrabajador.Size = new System.Drawing.Size(35, 13);
            this.lbl_valortrabajador.TabIndex = 5;
            this.lbl_valortrabajador.Text = "label1";
            // 
            // lbl_fecha
            // 
            this.lbl_fecha.AutoSize = true;
            this.lbl_fecha.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_fecha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_fecha.Location = new System.Drawing.Point(38, 159);
            this.lbl_fecha.Name = "lbl_fecha";
            this.lbl_fecha.Size = new System.Drawing.Size(42, 15);
            this.lbl_fecha.TabIndex = 4;
            this.lbl_fecha.Text = "Fecha:";
            // 
            // lbl_cliente
            // 
            this.lbl_cliente.AutoSize = true;
            this.lbl_cliente.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_cliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_cliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_cliente.Location = new System.Drawing.Point(36, 112);
            this.lbl_cliente.Name = "lbl_cliente";
            this.lbl_cliente.Size = new System.Drawing.Size(44, 15);
            this.lbl_cliente.TabIndex = 2;
            this.lbl_cliente.Text = "Cliente:";
            // 
            // lbl_trabajador
            // 
            this.lbl_trabajador.AutoSize = true;
            this.lbl_trabajador.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_trabajador.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_trabajador.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_trabajador.Location = new System.Drawing.Point(31, 64);
            this.lbl_trabajador.Name = "lbl_trabajador";
            this.lbl_trabajador.Size = new System.Drawing.Size(63, 15);
            this.lbl_trabajador.TabIndex = 1;
            this.lbl_trabajador.Text = "Trabajador:";
            this.lbl_trabajador.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_titulo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_titulo.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lbl_titulo.Font = new System.Drawing.Font("Book Antiqua", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.ForeColor = System.Drawing.Color.Red;
            this.lbl_titulo.Location = new System.Drawing.Point(120, 0);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(286, 29);
            this.lbl_titulo.TabIndex = 0;
            this.lbl_titulo.Text = "Tienda de Conveniencia MERU";
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // datos
            // 
            this.datos.AllowUserToAddRows = false;
            this.datos.AllowUserToDeleteRows = false;
            this.datos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datos.BackgroundColor = System.Drawing.Color.PowderBlue;
            this.datos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.datos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.datos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datos.Location = new System.Drawing.Point(12, 267);
            this.datos.Name = "datos";
            this.datos.ReadOnly = true;
            this.datos.Size = new System.Drawing.Size(534, 150);
            this.datos.TabIndex = 1;
            // 
            // btn_imprimir
            // 
            this.btn_imprimir.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_imprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_imprimir.ForeColor = System.Drawing.Color.Maroon;
            this.btn_imprimir.Location = new System.Drawing.Point(471, 238);
            this.btn_imprimir.Name = "btn_imprimir";
            this.btn_imprimir.Size = new System.Drawing.Size(75, 23);
            this.btn_imprimir.TabIndex = 2;
            this.btn_imprimir.Text = "Imprimir";
            this.btn_imprimir.UseVisualStyleBackColor = true;
            this.btn_imprimir.Click += new System.EventHandler(this.btn_imprimir_Click);
            // 
            // lbl_msefectivo
            // 
            this.lbl_msefectivo.AutoSize = true;
            this.lbl_msefectivo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_msefectivo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_msefectivo.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lbl_msefectivo.Font = new System.Drawing.Font("Broadway", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_msefectivo.Location = new System.Drawing.Point(49, 440);
            this.lbl_msefectivo.Name = "lbl_msefectivo";
            this.lbl_msefectivo.Size = new System.Drawing.Size(58, 14);
            this.lbl_msefectivo.TabIndex = 8;
            this.lbl_msefectivo.Text = "Efectivo:";
            // 
            // tb_efectivo
            // 
            this.tb_efectivo.Location = new System.Drawing.Point(132, 440);
            this.tb_efectivo.Name = "tb_efectivo";
            this.tb_efectivo.Size = new System.Drawing.Size(73, 20);
            this.tb_efectivo.TabIndex = 9;
            this.tb_efectivo.TextChanged += new System.EventHandler(this.tb_efectivo_TextChanged);
            // 
            // lbl_cambio
            // 
            this.lbl_cambio.AutoSize = true;
            this.lbl_cambio.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_cambio.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_cambio.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lbl_cambio.Font = new System.Drawing.Font("Broadway", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cambio.Location = new System.Drawing.Point(48, 482);
            this.lbl_cambio.Name = "lbl_cambio";
            this.lbl_cambio.Size = new System.Drawing.Size(59, 14);
            this.lbl_cambio.TabIndex = 10;
            this.lbl_cambio.Text = "Cambio:";
            // 
            // tb_cambio
            // 
            this.tb_cambio.Location = new System.Drawing.Point(132, 478);
            this.tb_cambio.Name = "tb_cambio";
            this.tb_cambio.ReadOnly = true;
            this.tb_cambio.Size = new System.Drawing.Size(73, 20);
            this.tb_cambio.TabIndex = 11;
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_total.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_total.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lbl_total.Font = new System.Drawing.Font("Broadway", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total.Location = new System.Drawing.Point(255, 440);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(43, 14);
            this.lbl_total.TabIndex = 12;
            this.lbl_total.Text = "Total:";
            // 
            // tb_total
            // 
            this.tb_total.Location = new System.Drawing.Point(304, 436);
            this.tb_total.Name = "tb_total";
            this.tb_total.Size = new System.Drawing.Size(73, 20);
            this.tb_total.TabIndex = 13;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 526);
            this.Controls.Add(this.tb_total);
            this.Controls.Add(this.lbl_total);
            this.Controls.Add(this.tb_cambio);
            this.Controls.Add(this.lbl_cambio);
            this.Controls.Add(this.tb_efectivo);
            this.Controls.Add(this.lbl_msefectivo);
            this.Controls.Add(this.btn_imprimir);
            this.Controls.Add(this.datos);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FrmFactura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Visor Factura";
            this.Load += new System.EventHandler(this.FrmFactura_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_fecha;
        private System.Windows.Forms.Label lbl_cliente;
        private System.Windows.Forms.Label lbl_trabajador;
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Label lbl_valorfecha;
        private System.Windows.Forms.Label lbl_valorcliente;
        private System.Windows.Forms.Label lbl_valortrabajador;
        private System.Windows.Forms.DataGridView datos;
        private System.Windows.Forms.Button btn_imprimir;
        private System.Windows.Forms.Label lbl_msefectivo;
        private System.Windows.Forms.TextBox tb_efectivo;
        private System.Windows.Forms.Label lbl_cambio;
        private System.Windows.Forms.TextBox tb_cambio;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.TextBox tb_total;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}