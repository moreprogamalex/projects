namespace CapaPresentacion
{
    partial class frmIngreso
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
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.btn_buscarproveedor = new System.Windows.Forms.Button();
            this.lbl_fechaproveedor = new System.Windows.Forms.Label();
            this.lbl_proveedor = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.cb_estado = new System.Windows.Forms.ComboBox();
            this.btn_nuevo = new System.Windows.Forms.Button();
            this.lbl_estado = new System.Windows.Forms.Label();
            this.lbl_pago = new System.Windows.Forms.Label();
            this.lbl_totalpagado = new System.Windows.Forms.Label();
            this.data_detalle = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tb_idarticulo = new System.Windows.Forms.TextBox();
            this.btn_quitar = new System.Windows.Forms.Button();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.dt_vencimiento = new System.Windows.Forms.DateTimePicker();
            this.lbl_fechavencimiento = new System.Windows.Forms.Label();
            this.dt_fechaproduc = new System.Windows.Forms.DateTimePicker();
            this.lbl_fechaproducion = new System.Windows.Forms.Label();
            this.tb_precioventa = new System.Windows.Forms.TextBox();
            this.lbl_precioventa = new System.Windows.Forms.Label();
            this.tb_preciocompra = new System.Windows.Forms.TextBox();
            this.lbl_preciocompra = new System.Windows.Forms.Label();
            this.tb_stockinicial = new System.Windows.Forms.TextBox();
            this.lbl_stockinicio = new System.Windows.Forms.Label();
            this.btn_buscararticulo = new System.Windows.Forms.Button();
            this.tb_articulo = new System.Windows.Forms.TextBox();
            this.lbl_articulo = new System.Windows.Forms.Label();
            this.cb_comprobante = new System.Windows.Forms.ComboBox();
            this.dt_fechamadre = new System.Windows.Forms.DateTimePicker();
            this.textBox_proveedor = new System.Windows.Forms.TextBox();
            this.textBox_idproveedor = new System.Windows.Forms.TextBox();
            this.lbl_comprobante = new System.Windows.Forms.Label();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.textBox_idingreso = new System.Windows.Forms.TextBox();
            this.lbl_IDpre = new System.Windows.Forms.Label();
            this.datos_ingresos = new System.Windows.Forms.DataGridView();
            this.Anular = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tabControl_principal = new System.Windows.Forms.TabControl();
            this.tagpage1 = new System.Windows.Forms.TabPage();
            this.lbl_total = new System.Windows.Forms.Label();
            this.checkBox_eliminar = new System.Windows.Forms.CheckBox();
            this.btn_anular = new System.Windows.Forms.Button();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.dt_busqueda1 = new System.Windows.Forms.DateTimePicker();
            this.dt_busqueda2 = new System.Windows.Forms.DateTimePicker();
            this.lbl_fecha01 = new System.Windows.Forms.Label();
            this.lbl_fecha02 = new System.Windows.Forms.Label();
            this.refrescar = new System.Windows.Forms.Button();
            this.ayuda = new System.Windows.Forms.ToolTip(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_detalle)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datos_ingresos)).BeginInit();
            this.tabControl_principal.SuspendLayout();
            this.tagpage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Bauhaus 93", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbl_titulo.Location = new System.Drawing.Point(84, 9);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(220, 24);
            this.lbl_titulo.TabIndex = 3;
            this.lbl_titulo.Text = "Compras de productos";
            // 
            // btn_buscarproveedor
            // 
            this.btn_buscarproveedor.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_buscarproveedor.Location = new System.Drawing.Point(443, 46);
            this.btn_buscarproveedor.Name = "btn_buscarproveedor";
            this.btn_buscarproveedor.Size = new System.Drawing.Size(69, 26);
            this.btn_buscarproveedor.TabIndex = 20;
            this.btn_buscarproveedor.Text = "Buscar";
            this.btn_buscarproveedor.UseVisualStyleBackColor = true;
            this.btn_buscarproveedor.Click += new System.EventHandler(this.btn_buscarproveedor_Click);
            // 
            // lbl_fechaproveedor
            // 
            this.lbl_fechaproveedor.AutoSize = true;
            this.lbl_fechaproveedor.Location = new System.Drawing.Point(518, 53);
            this.lbl_fechaproveedor.Name = "lbl_fechaproveedor";
            this.lbl_fechaproveedor.Size = new System.Drawing.Size(40, 13);
            this.lbl_fechaproveedor.TabIndex = 19;
            this.lbl_fechaproveedor.Text = "Fecha:";
            // 
            // lbl_proveedor
            // 
            this.lbl_proveedor.AutoSize = true;
            this.lbl_proveedor.Location = new System.Drawing.Point(256, 53);
            this.lbl_proveedor.Name = "lbl_proveedor";
            this.lbl_proveedor.Size = new System.Drawing.Size(59, 13);
            this.lbl_proveedor.TabIndex = 18;
            this.lbl_proveedor.Text = "Proveedor:";
            // 
            // tabPage2
            // 
            this.tabPage2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage2.Controls.Add(this.btn_cancelar);
            this.tabPage2.Controls.Add(this.cb_estado);
            this.tabPage2.Controls.Add(this.btn_nuevo);
            this.tabPage2.Controls.Add(this.lbl_estado);
            this.tabPage2.Controls.Add(this.lbl_pago);
            this.tabPage2.Controls.Add(this.lbl_totalpagado);
            this.tabPage2.Controls.Add(this.data_detalle);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.cb_comprobante);
            this.tabPage2.Controls.Add(this.dt_fechamadre);
            this.tabPage2.Controls.Add(this.btn_buscarproveedor);
            this.tabPage2.Controls.Add(this.lbl_fechaproveedor);
            this.tabPage2.Controls.Add(this.lbl_proveedor);
            this.tabPage2.Controls.Add(this.textBox_proveedor);
            this.tabPage2.Controls.Add(this.textBox_idproveedor);
            this.tabPage2.Controls.Add(this.lbl_comprobante);
            this.tabPage2.Controls.Add(this.btn_guardar);
            this.tabPage2.Controls.Add(this.textBox_idingreso);
            this.tabPage2.Controls.Add(this.lbl_IDpre);
            this.tabPage2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(824, 475);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Realizar Compra";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_cancelar.Location = new System.Drawing.Point(697, 412);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(107, 26);
            this.btn_cancelar.TabIndex = 34;
            this.btn_cancelar.Text = "Cancelar";
            this.ayuda.SetToolTip(this.btn_cancelar, "Clic para guardar la informacion");
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click_1);
            // 
            // cb_estado
            // 
            this.cb_estado.FormattingEnabled = true;
            this.cb_estado.Items.AddRange(new object[] {
            "Aceptado",
            "Anulado"});
            this.cb_estado.Location = new System.Drawing.Point(336, 87);
            this.cb_estado.Name = "cb_estado";
            this.cb_estado.Size = new System.Drawing.Size(121, 21);
            this.cb_estado.TabIndex = 33;
            this.cb_estado.Text = "Opcion:";
            // 
            // btn_nuevo
            // 
            this.btn_nuevo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_nuevo.Location = new System.Drawing.Point(420, 412);
            this.btn_nuevo.Name = "btn_nuevo";
            this.btn_nuevo.Size = new System.Drawing.Size(107, 26);
            this.btn_nuevo.TabIndex = 32;
            this.btn_nuevo.Text = "Nuevo";
            this.ayuda.SetToolTip(this.btn_nuevo, "Clic para habilitar los campos");
            this.btn_nuevo.UseVisualStyleBackColor = true;
            this.btn_nuevo.Click += new System.EventHandler(this.btn_nuevo_Click);
            // 
            // lbl_estado
            // 
            this.lbl_estado.AutoSize = true;
            this.lbl_estado.Location = new System.Drawing.Point(287, 90);
            this.lbl_estado.Name = "lbl_estado";
            this.lbl_estado.Size = new System.Drawing.Size(43, 13);
            this.lbl_estado.TabIndex = 30;
            this.lbl_estado.Text = "Estado:";
            // 
            // lbl_pago
            // 
            this.lbl_pago.AutoSize = true;
            this.lbl_pago.Location = new System.Drawing.Point(86, 419);
            this.lbl_pago.Name = "lbl_pago";
            this.lbl_pago.Size = new System.Drawing.Size(41, 13);
            this.lbl_pago.TabIndex = 29;
            this.lbl_pago.Text = "C$0.00";
            // 
            // lbl_totalpagado
            // 
            this.lbl_totalpagado.AutoSize = true;
            this.lbl_totalpagado.Location = new System.Drawing.Point(6, 419);
            this.lbl_totalpagado.Name = "lbl_totalpagado";
            this.lbl_totalpagado.Size = new System.Drawing.Size(74, 13);
            this.lbl_totalpagado.TabIndex = 28;
            this.lbl_totalpagado.Text = "Total Pagado:";
            // 
            // data_detalle
            // 
            this.data_detalle.AllowUserToAddRows = false;
            this.data_detalle.AllowUserToDeleteRows = false;
            this.data_detalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_detalle.Location = new System.Drawing.Point(17, 270);
            this.data_detalle.Name = "data_detalle";
            this.data_detalle.Size = new System.Drawing.Size(787, 106);
            this.data_detalle.TabIndex = 27;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tb_idarticulo);
            this.groupBox1.Controls.Add(this.btn_quitar);
            this.groupBox1.Controls.Add(this.btn_agregar);
            this.groupBox1.Controls.Add(this.dt_vencimiento);
            this.groupBox1.Controls.Add(this.lbl_fechavencimiento);
            this.groupBox1.Controls.Add(this.dt_fechaproduc);
            this.groupBox1.Controls.Add(this.lbl_fechaproducion);
            this.groupBox1.Controls.Add(this.tb_precioventa);
            this.groupBox1.Controls.Add(this.lbl_precioventa);
            this.groupBox1.Controls.Add(this.tb_preciocompra);
            this.groupBox1.Controls.Add(this.lbl_preciocompra);
            this.groupBox1.Controls.Add(this.tb_stockinicial);
            this.groupBox1.Controls.Add(this.lbl_stockinicio);
            this.groupBox1.Controls.Add(this.btn_buscararticulo);
            this.groupBox1.Controls.Add(this.tb_articulo);
            this.groupBox1.Controls.Add(this.lbl_articulo);
            this.groupBox1.Location = new System.Drawing.Point(24, 116);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(780, 148);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            // 
            // tb_idarticulo
            // 
            this.tb_idarticulo.Location = new System.Drawing.Point(58, 13);
            this.tb_idarticulo.Name = "tb_idarticulo";
            this.tb_idarticulo.ReadOnly = true;
            this.tb_idarticulo.Size = new System.Drawing.Size(36, 20);
            this.tb_idarticulo.TabIndex = 38;
            // 
            // btn_quitar
            // 
            this.btn_quitar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_quitar.Location = new System.Drawing.Point(636, 38);
            this.btn_quitar.Name = "btn_quitar";
            this.btn_quitar.Size = new System.Drawing.Size(87, 26);
            this.btn_quitar.TabIndex = 37;
            this.btn_quitar.Text = "Quitar";
            this.btn_quitar.UseVisualStyleBackColor = true;
            this.btn_quitar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_agregar
            // 
            this.btn_agregar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_agregar.Location = new System.Drawing.Point(636, 8);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(87, 26);
            this.btn_agregar.TabIndex = 27;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // dt_vencimiento
            // 
            this.dt_vencimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_vencimiento.Location = new System.Drawing.Point(540, 35);
            this.dt_vencimiento.Name = "dt_vencimiento";
            this.dt_vencimiento.Size = new System.Drawing.Size(79, 20);
            this.dt_vencimiento.TabIndex = 36;
            // 
            // lbl_fechavencimiento
            // 
            this.lbl_fechavencimiento.AutoSize = true;
            this.lbl_fechavencimiento.Location = new System.Drawing.Point(457, 38);
            this.lbl_fechavencimiento.Name = "lbl_fechavencimiento";
            this.lbl_fechavencimiento.Size = new System.Drawing.Size(70, 13);
            this.lbl_fechavencimiento.TabIndex = 35;
            this.lbl_fechavencimiento.Text = "Fecha Venci:";
            // 
            // dt_fechaproduc
            // 
            this.dt_fechaproduc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_fechaproduc.Location = new System.Drawing.Point(540, 9);
            this.dt_fechaproduc.Name = "dt_fechaproduc";
            this.dt_fechaproduc.Size = new System.Drawing.Size(79, 20);
            this.dt_fechaproduc.TabIndex = 27;
            // 
            // lbl_fechaproducion
            // 
            this.lbl_fechaproducion.AutoSize = true;
            this.lbl_fechaproducion.Location = new System.Drawing.Point(462, 13);
            this.lbl_fechaproducion.Name = "lbl_fechaproducion";
            this.lbl_fechaproducion.Size = new System.Drawing.Size(77, 13);
            this.lbl_fechaproducion.TabIndex = 27;
            this.lbl_fechaproducion.Text = "Fecha Produc:";
            // 
            // tb_precioventa
            // 
            this.tb_precioventa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.tb_precioventa.Location = new System.Drawing.Point(377, 38);
            this.tb_precioventa.Name = "tb_precioventa";
            this.tb_precioventa.Size = new System.Drawing.Size(48, 20);
            this.tb_precioventa.TabIndex = 34;
            this.tb_precioventa.Text = "00.00";
            // 
            // lbl_precioventa
            // 
            this.lbl_precioventa.AutoSize = true;
            this.lbl_precioventa.Location = new System.Drawing.Point(278, 45);
            this.lbl_precioventa.Name = "lbl_precioventa";
            this.lbl_precioventa.Size = new System.Drawing.Size(85, 13);
            this.lbl_precioventa.TabIndex = 33;
            this.lbl_precioventa.Text = "Precio de venta:";
            // 
            // tb_preciocompra
            // 
            this.tb_preciocompra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.tb_preciocompra.Location = new System.Drawing.Point(377, 9);
            this.tb_preciocompra.Name = "tb_preciocompra";
            this.tb_preciocompra.Size = new System.Drawing.Size(48, 20);
            this.tb_preciocompra.TabIndex = 32;
            this.tb_preciocompra.Text = "00.00";
            // 
            // lbl_preciocompra
            // 
            this.lbl_preciocompra.AutoSize = true;
            this.lbl_preciocompra.Location = new System.Drawing.Point(278, 13);
            this.lbl_preciocompra.Name = "lbl_preciocompra";
            this.lbl_preciocompra.Size = new System.Drawing.Size(93, 13);
            this.lbl_preciocompra.TabIndex = 30;
            this.lbl_preciocompra.Text = "Precio de compra:";
            // 
            // tb_stockinicial
            // 
            this.tb_stockinicial.Location = new System.Drawing.Point(80, 72);
            this.tb_stockinicial.Name = "tb_stockinicial";
            this.tb_stockinicial.Size = new System.Drawing.Size(36, 20);
            this.tb_stockinicial.TabIndex = 29;
            // 
            // lbl_stockinicio
            // 
            this.lbl_stockinicio.AutoSize = true;
            this.lbl_stockinicio.Location = new System.Drawing.Point(6, 75);
            this.lbl_stockinicio.Name = "lbl_stockinicio";
            this.lbl_stockinicio.Size = new System.Drawing.Size(68, 13);
            this.lbl_stockinicio.TabIndex = 28;
            this.lbl_stockinicio.Text = "Stock Inicial:";
            // 
            // btn_buscararticulo
            // 
            this.btn_buscararticulo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_buscararticulo.Location = new System.Drawing.Point(181, 34);
            this.btn_buscararticulo.Name = "btn_buscararticulo";
            this.btn_buscararticulo.Size = new System.Drawing.Size(69, 26);
            this.btn_buscararticulo.TabIndex = 27;
            this.btn_buscararticulo.Text = "Buscar";
            this.btn_buscararticulo.UseVisualStyleBackColor = true;
            this.btn_buscararticulo.Click += new System.EventHandler(this.btn_buscararticulo_Click);
            // 
            // tb_articulo
            // 
            this.tb_articulo.Location = new System.Drawing.Point(58, 38);
            this.tb_articulo.Name = "tb_articulo";
            this.tb_articulo.Size = new System.Drawing.Size(117, 20);
            this.tb_articulo.TabIndex = 27;
            // 
            // lbl_articulo
            // 
            this.lbl_articulo.AutoSize = true;
            this.lbl_articulo.Location = new System.Drawing.Point(6, 42);
            this.lbl_articulo.Name = "lbl_articulo";
            this.lbl_articulo.Size = new System.Drawing.Size(53, 13);
            this.lbl_articulo.TabIndex = 27;
            this.lbl_articulo.Text = "Producto:";
            // 
            // cb_comprobante
            // 
            this.cb_comprobante.FormattingEnabled = true;
            this.cb_comprobante.Items.AddRange(new object[] {
            "Ticket",
            "Factura",
            "Papel"});
            this.cb_comprobante.Location = new System.Drawing.Point(100, 82);
            this.cb_comprobante.Name = "cb_comprobante";
            this.cb_comprobante.Size = new System.Drawing.Size(126, 21);
            this.cb_comprobante.TabIndex = 21;
            this.cb_comprobante.Text = "Opcion:";
            // 
            // dt_fechamadre
            // 
            this.dt_fechamadre.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_fechamadre.Location = new System.Drawing.Point(564, 52);
            this.dt_fechamadre.Name = "dt_fechamadre";
            this.dt_fechamadre.Size = new System.Drawing.Size(79, 20);
            this.dt_fechamadre.TabIndex = 8;
            // 
            // textBox_proveedor
            // 
            this.textBox_proveedor.Location = new System.Drawing.Point(320, 50);
            this.textBox_proveedor.Name = "textBox_proveedor";
            this.textBox_proveedor.Size = new System.Drawing.Size(117, 20);
            this.textBox_proveedor.TabIndex = 15;
            // 
            // textBox_idproveedor
            // 
            this.textBox_idproveedor.Location = new System.Drawing.Point(320, 24);
            this.textBox_idproveedor.Name = "textBox_idproveedor";
            this.textBox_idproveedor.ReadOnly = true;
            this.textBox_idproveedor.Size = new System.Drawing.Size(49, 20);
            this.textBox_idproveedor.TabIndex = 14;
            // 
            // lbl_comprobante
            // 
            this.lbl_comprobante.AutoSize = true;
            this.lbl_comprobante.Location = new System.Drawing.Point(21, 90);
            this.lbl_comprobante.Name = "lbl_comprobante";
            this.lbl_comprobante.Size = new System.Drawing.Size(73, 13);
            this.lbl_comprobante.TabIndex = 9;
            this.lbl_comprobante.Text = "Comprobante:";
            // 
            // btn_guardar
            // 
            this.btn_guardar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_guardar.Location = new System.Drawing.Point(564, 412);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(107, 26);
            this.btn_guardar.TabIndex = 7;
            this.btn_guardar.Text = "Guardar";
            this.ayuda.SetToolTip(this.btn_guardar, "Clic para guardar la informacion");
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // textBox_idingreso
            // 
            this.textBox_idingreso.Location = new System.Drawing.Point(106, 28);
            this.textBox_idingreso.Name = "textBox_idingreso";
            this.textBox_idingreso.ReadOnly = true;
            this.textBox_idingreso.Size = new System.Drawing.Size(34, 20);
            this.textBox_idingreso.TabIndex = 4;
            // 
            // lbl_IDpre
            // 
            this.lbl_IDpre.AutoSize = true;
            this.lbl_IDpre.Location = new System.Drawing.Point(53, 31);
            this.lbl_IDpre.Name = "lbl_IDpre";
            this.lbl_IDpre.Size = new System.Drawing.Size(21, 13);
            this.lbl_IDpre.TabIndex = 1;
            this.lbl_IDpre.Text = "ID:";
            // 
            // datos_ingresos
            // 
            this.datos_ingresos.AllowUserToAddRows = false;
            this.datos_ingresos.AllowUserToDeleteRows = false;
            this.datos_ingresos.AllowUserToOrderColumns = true;
            this.datos_ingresos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datos_ingresos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Anular});
            this.datos_ingresos.Location = new System.Drawing.Point(18, 138);
            this.datos_ingresos.Name = "datos_ingresos";
            this.datos_ingresos.ReadOnly = true;
            this.datos_ingresos.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.datos_ingresos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datos_ingresos.Size = new System.Drawing.Size(728, 219);
            this.datos_ingresos.TabIndex = 0;
            this.datos_ingresos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datos_ingresos_CellContentClick);
            this.datos_ingresos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datos_ingresos_CellDoubleClick);
            // 
            // Anular
            // 
            this.Anular.HeaderText = "Anular";
            this.Anular.Name = "Anular";
            this.Anular.ReadOnly = true;
            // 
            // tabControl_principal
            // 
            this.tabControl_principal.Controls.Add(this.tagpage1);
            this.tabControl_principal.Controls.Add(this.tabPage2);
            this.tabControl_principal.Location = new System.Drawing.Point(15, 107);
            this.tabControl_principal.Name = "tabControl_principal";
            this.tabControl_principal.SelectedIndex = 0;
            this.tabControl_principal.Size = new System.Drawing.Size(832, 501);
            this.tabControl_principal.TabIndex = 2;
            // 
            // tagpage1
            // 
            this.tagpage1.Controls.Add(this.lbl_total);
            this.tagpage1.Controls.Add(this.checkBox_eliminar);
            this.tagpage1.Controls.Add(this.btn_anular);
            this.tagpage1.Controls.Add(this.datos_ingresos);
            this.tagpage1.Location = new System.Drawing.Point(4, 22);
            this.tagpage1.Name = "tagpage1";
            this.tagpage1.Padding = new System.Windows.Forms.Padding(3);
            this.tagpage1.Size = new System.Drawing.Size(824, 475);
            this.tagpage1.TabIndex = 0;
            this.tagpage1.Text = "Listado";
            this.tagpage1.UseVisualStyleBackColor = true;
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.Location = new System.Drawing.Point(711, 376);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(35, 13);
            this.lbl_total.TabIndex = 16;
            this.lbl_total.Text = "label1";
            // 
            // checkBox_eliminar
            // 
            this.checkBox_eliminar.AutoSize = true;
            this.checkBox_eliminar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.checkBox_eliminar.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.checkBox_eliminar.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.checkBox_eliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.checkBox_eliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.checkBox_eliminar.ForeColor = System.Drawing.SystemColors.Highlight;
            this.checkBox_eliminar.Location = new System.Drawing.Point(18, 75);
            this.checkBox_eliminar.Name = "checkBox_eliminar";
            this.checkBox_eliminar.Size = new System.Drawing.Size(56, 17);
            this.checkBox_eliminar.TabIndex = 15;
            this.checkBox_eliminar.Text = "Anular";
            this.ayuda.SetToolTip(this.checkBox_eliminar, "Clic para habilitar la anulacion");
            this.checkBox_eliminar.UseVisualStyleBackColor = false;
            this.checkBox_eliminar.CheckedChanged += new System.EventHandler(this.checkBox_eliminar_CheckedChanged);
            // 
            // btn_anular
            // 
            this.btn_anular.Enabled = false;
            this.btn_anular.Location = new System.Drawing.Point(18, 106);
            this.btn_anular.Name = "btn_anular";
            this.btn_anular.Size = new System.Drawing.Size(63, 26);
            this.btn_anular.TabIndex = 13;
            this.btn_anular.Text = "Anular";
            this.ayuda.SetToolTip(this.btn_anular, "Clic para anular");
            this.btn_anular.UseVisualStyleBackColor = true;
            this.btn_anular.Click += new System.EventHandler(this.btn_anular_Click);
            // 
            // btn_buscar
            // 
            this.btn_buscar.Location = new System.Drawing.Point(264, 72);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(64, 29);
            this.btn_buscar.TabIndex = 12;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // dt_busqueda1
            // 
            this.dt_busqueda1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_busqueda1.Location = new System.Drawing.Point(12, 72);
            this.dt_busqueda1.Name = "dt_busqueda1";
            this.dt_busqueda1.Size = new System.Drawing.Size(79, 20);
            this.dt_busqueda1.TabIndex = 4;
            // 
            // dt_busqueda2
            // 
            this.dt_busqueda2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_busqueda2.Location = new System.Drawing.Point(139, 72);
            this.dt_busqueda2.Name = "dt_busqueda2";
            this.dt_busqueda2.Size = new System.Drawing.Size(79, 20);
            this.dt_busqueda2.TabIndex = 5;
            // 
            // lbl_fecha01
            // 
            this.lbl_fecha01.AutoSize = true;
            this.lbl_fecha01.Location = new System.Drawing.Point(12, 46);
            this.lbl_fecha01.Name = "lbl_fecha01";
            this.lbl_fecha01.Size = new System.Drawing.Size(68, 13);
            this.lbl_fecha01.TabIndex = 6;
            this.lbl_fecha01.Text = "Fecha Inicio:";
            // 
            // lbl_fecha02
            // 
            this.lbl_fecha02.AutoSize = true;
            this.lbl_fecha02.Location = new System.Drawing.Point(136, 46);
            this.lbl_fecha02.Name = "lbl_fecha02";
            this.lbl_fecha02.Size = new System.Drawing.Size(57, 13);
            this.lbl_fecha02.TabIndex = 7;
            this.lbl_fecha02.Text = "Fecha Fin:";
            // 
            // refrescar
            // 
            this.refrescar.Location = new System.Drawing.Point(334, 72);
            this.refrescar.Name = "refrescar";
            this.refrescar.Size = new System.Drawing.Size(64, 29);
            this.refrescar.TabIndex = 15;
            this.refrescar.Text = "Refrescar";
            this.refrescar.UseVisualStyleBackColor = true;
            this.refrescar.Click += new System.EventHandler(this.refrescar_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmIngreso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 635);
            this.Controls.Add(this.refrescar);
            this.Controls.Add(this.lbl_fecha02);
            this.Controls.Add(this.lbl_fecha01);
            this.Controls.Add(this.dt_busqueda2);
            this.Controls.Add(this.dt_busqueda1);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.lbl_titulo);
            this.Controls.Add(this.tabControl_principal);
            this.Name = "frmIngreso";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmIngreso_FormClosing);
            this.Load += new System.EventHandler(this.frmIngreso_Load);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_detalle)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datos_ingresos)).EndInit();
            this.tabControl_principal.ResumeLayout(false);
            this.tagpage1.ResumeLayout(false);
            this.tagpage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Button btn_buscarproveedor;
        private System.Windows.Forms.Label lbl_fechaproveedor;
        private System.Windows.Forms.Label lbl_proveedor;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox textBox_proveedor;
        private System.Windows.Forms.TextBox textBox_idproveedor;
        private System.Windows.Forms.Label lbl_comprobante;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.TextBox textBox_idingreso;
        private System.Windows.Forms.Label lbl_IDpre;
        private System.Windows.Forms.DataGridView datos_ingresos;
        private System.Windows.Forms.TabControl tabControl_principal;
        private System.Windows.Forms.TabPage tagpage1;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.CheckBox checkBox_eliminar;
        private System.Windows.Forms.Button btn_anular;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.DateTimePicker dt_busqueda1;
        private System.Windows.Forms.DateTimePicker dt_busqueda2;
        private System.Windows.Forms.Label lbl_fecha01;
        private System.Windows.Forms.Label lbl_fecha02;
        private System.Windows.Forms.DateTimePicker dt_fechamadre;
        private System.Windows.Forms.ComboBox cb_comprobante;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tb_precioventa;
        private System.Windows.Forms.Label lbl_precioventa;
        private System.Windows.Forms.TextBox tb_preciocompra;
        private System.Windows.Forms.Label lbl_preciocompra;
        private System.Windows.Forms.TextBox tb_stockinicial;
        private System.Windows.Forms.Label lbl_stockinicio;
        private System.Windows.Forms.Button btn_buscararticulo;
        private System.Windows.Forms.TextBox tb_articulo;
        private System.Windows.Forms.Label lbl_articulo;
        private System.Windows.Forms.Label lbl_pago;
        private System.Windows.Forms.Label lbl_totalpagado;
        private System.Windows.Forms.DataGridView data_detalle;
        private System.Windows.Forms.Button btn_quitar;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.DateTimePicker dt_vencimiento;
        private System.Windows.Forms.Label lbl_fechavencimiento;
        private System.Windows.Forms.DateTimePicker dt_fechaproduc;
        private System.Windows.Forms.Label lbl_fechaproducion;
        private System.Windows.Forms.TextBox tb_idarticulo;
        private System.Windows.Forms.Label lbl_estado;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Anular;
        private System.Windows.Forms.Button refrescar;
        private System.Windows.Forms.ToolTip ayuda;
        private System.Windows.Forms.Button btn_nuevo;
        private System.Windows.Forms.ComboBox cb_estado;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}