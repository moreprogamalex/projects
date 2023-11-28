namespace CapaPresentacion
{
    partial class frmVenta
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
            this.tb_idcliente = new System.Windows.Forms.TextBox();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.tb_idventa = new System.Windows.Forms.TextBox();
            this.lbl_IDpre = new System.Windows.Forms.Label();
            this.Eliminar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.datos_venta = new System.Windows.Forms.DataGridView();
            this.lbl_comprobante = new System.Windows.Forms.Label();
            this.tb_idarticulo_dingreso = new System.Windows.Forms.TextBox();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.dt_vencimiento = new System.Windows.Forms.DateTimePicker();
            this.lbl_fechavencimiento = new System.Windows.Forms.Label();
            this.lbl_fecha02 = new System.Windows.Forms.Label();
            this.dt_busqueda2 = new System.Windows.Forms.DateTimePicker();
            this.tb_precioventa = new System.Windows.Forms.TextBox();
            this.lbl_precioventa = new System.Windows.Forms.Label();
            this.tb_preciocompra = new System.Windows.Forms.TextBox();
            this.lbl_preciocompra = new System.Windows.Forms.Label();
            this.tb_cantidad = new System.Windows.Forms.TextBox();
            this.lbl_cantidad = new System.Windows.Forms.Label();
            this.dt_busqueda1 = new System.Windows.Forms.DateTimePicker();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.btn_buscararticulo = new System.Windows.Forms.Button();
            this.checkBox_eliminar = new System.Windows.Forms.CheckBox();
            this.tb_articulo = new System.Windows.Forms.TextBox();
            this.tabControl_principal = new System.Windows.Forms.TabControl();
            this.tagpage1 = new System.Windows.Forms.TabPage();
            this.lbl_total_filas = new System.Windows.Forms.Label();
            this.btn_comprobante = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btn_cancelar2 = new System.Windows.Forms.Button();
            this.btn_nuevo = new System.Windows.Forms.Button();
            this.lbl_pago = new System.Windows.Forms.Label();
            this.lbl_totalpagado = new System.Windows.Forms.Label();
            this.data_detalle = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_porcentaje = new System.Windows.Forms.Label();
            this.lbl_stock = new System.Windows.Forms.Label();
            this.tb_descuento = new System.Windows.Forms.TextBox();
            this.lbl_descuento = new System.Windows.Forms.Label();
            this.tb_stockactual = new System.Windows.Forms.TextBox();
            this.lbl_articulo = new System.Windows.Forms.Label();
            this.cb_comprobante = new System.Windows.Forms.ComboBox();
            this.dt_fechamadre = new System.Windows.Forms.DateTimePicker();
            this.btn_buscarcliente = new System.Windows.Forms.Button();
            this.lbl_fechaproveedor = new System.Windows.Forms.Label();
            this.lbl_cliente = new System.Windows.Forms.Label();
            this.tb_cliente = new System.Windows.Forms.TextBox();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.lbl_fecha01 = new System.Windows.Forms.Label();
            this.MensajeAyuda = new System.Windows.Forms.ToolTip(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btn_refrescar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datos_venta)).BeginInit();
            this.tabControl_principal.SuspendLayout();
            this.tagpage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_detalle)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_idcliente
            // 
            this.tb_idcliente.Location = new System.Drawing.Point(320, 24);
            this.tb_idcliente.Name = "tb_idcliente";
            this.tb_idcliente.ReadOnly = true;
            this.tb_idcliente.Size = new System.Drawing.Size(49, 20);
            this.tb_idcliente.TabIndex = 14;
            // 
            // btn_guardar
            // 
            this.btn_guardar.Location = new System.Drawing.Point(573, 412);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(107, 26);
            this.btn_guardar.TabIndex = 7;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // tb_idventa
            // 
            this.tb_idventa.Location = new System.Drawing.Point(106, 28);
            this.tb_idventa.Name = "tb_idventa";
            this.tb_idventa.ReadOnly = true;
            this.tb_idventa.Size = new System.Drawing.Size(64, 20);
            this.tb_idventa.TabIndex = 4;
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
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            // 
            // datos_venta
            // 
            this.datos_venta.AllowUserToAddRows = false;
            this.datos_venta.AllowUserToDeleteRows = false;
            this.datos_venta.AllowUserToOrderColumns = true;
            this.datos_venta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datos_venta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Eliminar});
            this.datos_venta.Location = new System.Drawing.Point(40, 131);
            this.datos_venta.Name = "datos_venta";
            this.datos_venta.ReadOnly = true;
            this.datos_venta.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.datos_venta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datos_venta.Size = new System.Drawing.Size(728, 219);
            this.datos_venta.TabIndex = 0;
            this.datos_venta.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datos_venta_CellContentClick);
            this.datos_venta.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datos_venta_CellDoubleClick);
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
            // tb_idarticulo_dingreso
            // 
            this.tb_idarticulo_dingreso.Location = new System.Drawing.Point(58, 13);
            this.tb_idarticulo_dingreso.Name = "tb_idarticulo_dingreso";
            this.tb_idarticulo_dingreso.ReadOnly = true;
            this.tb_idarticulo_dingreso.Size = new System.Drawing.Size(36, 20);
            this.tb_idarticulo_dingreso.TabIndex = 38;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(636, 38);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(87, 26);
            this.btn_cancelar.TabIndex = 37;
            this.btn_cancelar.Text = "Quitar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_agregar
            // 
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
            this.dt_vencimiento.Location = new System.Drawing.Point(518, 28);
            this.dt_vencimiento.Name = "dt_vencimiento";
            this.dt_vencimiento.Size = new System.Drawing.Size(79, 20);
            this.dt_vencimiento.TabIndex = 36;
            // 
            // lbl_fechavencimiento
            // 
            this.lbl_fechavencimiento.AutoSize = true;
            this.lbl_fechavencimiento.Location = new System.Drawing.Point(442, 35);
            this.lbl_fechavencimiento.Name = "lbl_fechavencimiento";
            this.lbl_fechavencimiento.Size = new System.Drawing.Size(70, 13);
            this.lbl_fechavencimiento.TabIndex = 35;
            this.lbl_fechavencimiento.Text = "Fecha Venci:";
            // 
            // lbl_fecha02
            // 
            this.lbl_fecha02.AutoSize = true;
            this.lbl_fecha02.Location = new System.Drawing.Point(163, 16);
            this.lbl_fecha02.Name = "lbl_fecha02";
            this.lbl_fecha02.Size = new System.Drawing.Size(62, 13);
            this.lbl_fecha02.TabIndex = 20;
            this.lbl_fecha02.Text = "Fecha Final";
            // 
            // dt_busqueda2
            // 
            this.dt_busqueda2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_busqueda2.Location = new System.Drawing.Point(166, 42);
            this.dt_busqueda2.Name = "dt_busqueda2";
            this.dt_busqueda2.Size = new System.Drawing.Size(79, 20);
            this.dt_busqueda2.TabIndex = 18;
            // 
            // tb_precioventa
            // 
            this.tb_precioventa.Location = new System.Drawing.Point(377, 38);
            this.tb_precioventa.Name = "tb_precioventa";
            this.tb_precioventa.Size = new System.Drawing.Size(48, 20);
            this.tb_precioventa.TabIndex = 34;
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
            this.tb_preciocompra.Location = new System.Drawing.Point(377, 9);
            this.tb_preciocompra.Name = "tb_preciocompra";
            this.tb_preciocompra.ReadOnly = true;
            this.tb_preciocompra.Size = new System.Drawing.Size(48, 20);
            this.tb_preciocompra.TabIndex = 32;
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
            // tb_cantidad
            // 
            this.tb_cantidad.Location = new System.Drawing.Point(64, 72);
            this.tb_cantidad.Name = "tb_cantidad";
            this.tb_cantidad.Size = new System.Drawing.Size(60, 20);
            this.tb_cantidad.TabIndex = 29;
            // 
            // lbl_cantidad
            // 
            this.lbl_cantidad.AutoSize = true;
            this.lbl_cantidad.Location = new System.Drawing.Point(6, 75);
            this.lbl_cantidad.Name = "lbl_cantidad";
            this.lbl_cantidad.Size = new System.Drawing.Size(52, 13);
            this.lbl_cantidad.TabIndex = 28;
            this.lbl_cantidad.Text = "Cantidad:";
            // 
            // dt_busqueda1
            // 
            this.dt_busqueda1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_busqueda1.Location = new System.Drawing.Point(39, 42);
            this.dt_busqueda1.Name = "dt_busqueda1";
            this.dt_busqueda1.Size = new System.Drawing.Size(79, 20);
            this.dt_busqueda1.TabIndex = 17;
            // 
            // btn_buscar
            // 
            this.btn_buscar.Location = new System.Drawing.Point(262, 42);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(64, 20);
            this.btn_buscar.TabIndex = 21;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // btn_buscararticulo
            // 
            this.btn_buscararticulo.Location = new System.Drawing.Point(181, 34);
            this.btn_buscararticulo.Name = "btn_buscararticulo";
            this.btn_buscararticulo.Size = new System.Drawing.Size(69, 26);
            this.btn_buscararticulo.TabIndex = 27;
            this.btn_buscararticulo.Text = "Buscar";
            this.btn_buscararticulo.UseVisualStyleBackColor = true;
            this.btn_buscararticulo.Click += new System.EventHandler(this.btn_buscararticulo_Click);
            // 
            // checkBox_eliminar
            // 
            this.checkBox_eliminar.AutoSize = true;
            this.checkBox_eliminar.Location = new System.Drawing.Point(40, 52);
            this.checkBox_eliminar.Name = "checkBox_eliminar";
            this.checkBox_eliminar.Size = new System.Drawing.Size(62, 17);
            this.checkBox_eliminar.TabIndex = 15;
            this.checkBox_eliminar.Text = "Eliminar";
            this.checkBox_eliminar.UseVisualStyleBackColor = true;
            this.checkBox_eliminar.CheckedChanged += new System.EventHandler(this.checkBox_eliminar_CheckedChanged);
            // 
            // tb_articulo
            // 
            this.tb_articulo.Location = new System.Drawing.Point(58, 38);
            this.tb_articulo.Name = "tb_articulo";
            this.tb_articulo.ReadOnly = true;
            this.tb_articulo.Size = new System.Drawing.Size(117, 20);
            this.tb_articulo.TabIndex = 27;
            // 
            // tabControl_principal
            // 
            this.tabControl_principal.Controls.Add(this.tagpage1);
            this.tabControl_principal.Controls.Add(this.tabPage2);
            this.tabControl_principal.Location = new System.Drawing.Point(42, 77);
            this.tabControl_principal.Name = "tabControl_principal";
            this.tabControl_principal.SelectedIndex = 0;
            this.tabControl_principal.Size = new System.Drawing.Size(832, 501);
            this.tabControl_principal.TabIndex = 15;
            // 
            // tagpage1
            // 
            this.tagpage1.Controls.Add(this.lbl_total_filas);
            this.tagpage1.Controls.Add(this.btn_comprobante);
            this.tagpage1.Controls.Add(this.checkBox_eliminar);
            this.tagpage1.Controls.Add(this.btn_eliminar);
            this.tagpage1.Controls.Add(this.datos_venta);
            this.tagpage1.Location = new System.Drawing.Point(4, 22);
            this.tagpage1.Name = "tagpage1";
            this.tagpage1.Padding = new System.Windows.Forms.Padding(3);
            this.tagpage1.Size = new System.Drawing.Size(824, 475);
            this.tagpage1.TabIndex = 0;
            this.tagpage1.Text = "Listado";
            this.tagpage1.UseVisualStyleBackColor = true;
            // 
            // lbl_total_filas
            // 
            this.lbl_total_filas.AutoSize = true;
            this.lbl_total_filas.Location = new System.Drawing.Point(446, 101);
            this.lbl_total_filas.Name = "lbl_total_filas";
            this.lbl_total_filas.Size = new System.Drawing.Size(35, 13);
            this.lbl_total_filas.TabIndex = 16;
            this.lbl_total_filas.Text = "label1";
            // 
            // btn_comprobante
            // 
            this.btn_comprobante.Location = new System.Drawing.Point(701, 64);
            this.btn_comprobante.Name = "btn_comprobante";
            this.btn_comprobante.Size = new System.Drawing.Size(117, 30);
            this.btn_comprobante.TabIndex = 23;
            this.btn_comprobante.Text = "Generar Factura";
            this.btn_comprobante.UseVisualStyleBackColor = true;
            this.btn_comprobante.Click += new System.EventHandler(this.btn_comprobante_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Enabled = false;
            this.btn_eliminar.Location = new System.Drawing.Point(39, 84);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(63, 19);
            this.btn_eliminar.TabIndex = 13;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btn_cancelar2);
            this.tabPage2.Controls.Add(this.btn_nuevo);
            this.tabPage2.Controls.Add(this.lbl_pago);
            this.tabPage2.Controls.Add(this.lbl_totalpagado);
            this.tabPage2.Controls.Add(this.data_detalle);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.cb_comprobante);
            this.tabPage2.Controls.Add(this.dt_fechamadre);
            this.tabPage2.Controls.Add(this.btn_buscarcliente);
            this.tabPage2.Controls.Add(this.lbl_fechaproveedor);
            this.tabPage2.Controls.Add(this.lbl_cliente);
            this.tabPage2.Controls.Add(this.tb_cliente);
            this.tabPage2.Controls.Add(this.tb_idcliente);
            this.tabPage2.Controls.Add(this.lbl_comprobante);
            this.tabPage2.Controls.Add(this.btn_guardar);
            this.tabPage2.Controls.Add(this.tb_idventa);
            this.tabPage2.Controls.Add(this.lbl_IDpre);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(824, 475);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Realizar Venta";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btn_cancelar2
            // 
            this.btn_cancelar2.Location = new System.Drawing.Point(686, 412);
            this.btn_cancelar2.Name = "btn_cancelar2";
            this.btn_cancelar2.Size = new System.Drawing.Size(107, 26);
            this.btn_cancelar2.TabIndex = 31;
            this.btn_cancelar2.Text = "Cancelar";
            this.btn_cancelar2.UseVisualStyleBackColor = true;
            this.btn_cancelar2.Click += new System.EventHandler(this.btn_cancelar2_Click);
            // 
            // btn_nuevo
            // 
            this.btn_nuevo.Location = new System.Drawing.Point(460, 412);
            this.btn_nuevo.Name = "btn_nuevo";
            this.btn_nuevo.Size = new System.Drawing.Size(107, 26);
            this.btn_nuevo.TabIndex = 30;
            this.btn_nuevo.Text = "Nuevo";
            this.btn_nuevo.UseVisualStyleBackColor = true;
            this.btn_nuevo.Click += new System.EventHandler(this.btn_nuevo_Click);
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
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.Controls.Add(this.lbl_porcentaje);
            this.groupBox1.Controls.Add(this.lbl_stock);
            this.groupBox1.Controls.Add(this.tb_descuento);
            this.groupBox1.Controls.Add(this.lbl_descuento);
            this.groupBox1.Controls.Add(this.tb_stockactual);
            this.groupBox1.Controls.Add(this.tb_idarticulo_dingreso);
            this.groupBox1.Controls.Add(this.btn_cancelar);
            this.groupBox1.Controls.Add(this.btn_agregar);
            this.groupBox1.Controls.Add(this.dt_vencimiento);
            this.groupBox1.Controls.Add(this.lbl_fechavencimiento);
            this.groupBox1.Controls.Add(this.tb_precioventa);
            this.groupBox1.Controls.Add(this.lbl_precioventa);
            this.groupBox1.Controls.Add(this.tb_preciocompra);
            this.groupBox1.Controls.Add(this.lbl_preciocompra);
            this.groupBox1.Controls.Add(this.tb_cantidad);
            this.groupBox1.Controls.Add(this.lbl_cantidad);
            this.groupBox1.Controls.Add(this.btn_buscararticulo);
            this.groupBox1.Controls.Add(this.tb_articulo);
            this.groupBox1.Controls.Add(this.lbl_articulo);
            this.groupBox1.Location = new System.Drawing.Point(24, 116);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(780, 148);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            // 
            // lbl_porcentaje
            // 
            this.lbl_porcentaje.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_porcentaje.AutoSize = true;
            this.lbl_porcentaje.BackColor = System.Drawing.Color.Transparent;
            this.lbl_porcentaje.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_porcentaje.ForeColor = System.Drawing.Color.Red;
            this.lbl_porcentaje.Location = new System.Drawing.Point(396, 75);
            this.lbl_porcentaje.Name = "lbl_porcentaje";
            this.lbl_porcentaje.Size = new System.Drawing.Size(17, 15);
            this.lbl_porcentaje.TabIndex = 32;
            this.lbl_porcentaje.Text = "%";
            // 
            // lbl_stock
            // 
            this.lbl_stock.AutoSize = true;
            this.lbl_stock.Location = new System.Drawing.Point(13, 101);
            this.lbl_stock.Name = "lbl_stock";
            this.lbl_stock.Size = new System.Drawing.Size(38, 13);
            this.lbl_stock.TabIndex = 42;
            this.lbl_stock.Text = "Stock:";
            // 
            // tb_descuento
            // 
            this.tb_descuento.Location = new System.Drawing.Point(346, 72);
            this.tb_descuento.Name = "tb_descuento";
            this.tb_descuento.Size = new System.Drawing.Size(44, 20);
            this.tb_descuento.TabIndex = 41;
            this.tb_descuento.Text = "00.00";
            // 
            // lbl_descuento
            // 
            this.lbl_descuento.AutoSize = true;
            this.lbl_descuento.Location = new System.Drawing.Point(278, 75);
            this.lbl_descuento.Name = "lbl_descuento";
            this.lbl_descuento.Size = new System.Drawing.Size(62, 13);
            this.lbl_descuento.TabIndex = 40;
            this.lbl_descuento.Text = "Descuento:";
            // 
            // tb_stockactual
            // 
            this.tb_stockactual.Location = new System.Drawing.Point(64, 98);
            this.tb_stockactual.Name = "tb_stockactual";
            this.tb_stockactual.ReadOnly = true;
            this.tb_stockactual.Size = new System.Drawing.Size(62, 20);
            this.tb_stockactual.TabIndex = 39;
            // 
            // lbl_articulo
            // 
            this.lbl_articulo.AutoSize = true;
            this.lbl_articulo.Location = new System.Drawing.Point(6, 42);
            this.lbl_articulo.Name = "lbl_articulo";
            this.lbl_articulo.Size = new System.Drawing.Size(45, 13);
            this.lbl_articulo.TabIndex = 27;
            this.lbl_articulo.Text = "Articulo:";
            // 
            // cb_comprobante
            // 
            this.cb_comprobante.FormattingEnabled = true;
            this.cb_comprobante.Items.AddRange(new object[] {
            "Ticket",
            "Factura",
            "Papel",
            "Ninguno"});
            this.cb_comprobante.Location = new System.Drawing.Point(100, 82);
            this.cb_comprobante.Name = "cb_comprobante";
            this.cb_comprobante.Size = new System.Drawing.Size(126, 21);
            this.cb_comprobante.TabIndex = 21;
            this.cb_comprobante.Text = "Opcion:";
            // 
            // dt_fechamadre
            // 
            this.dt_fechamadre.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_fechamadre.Location = new System.Drawing.Point(564, 50);
            this.dt_fechamadre.Name = "dt_fechamadre";
            this.dt_fechamadre.Size = new System.Drawing.Size(79, 20);
            this.dt_fechamadre.TabIndex = 8;
            // 
            // btn_buscarcliente
            // 
            this.btn_buscarcliente.Location = new System.Drawing.Point(443, 46);
            this.btn_buscarcliente.Name = "btn_buscarcliente";
            this.btn_buscarcliente.Size = new System.Drawing.Size(69, 26);
            this.btn_buscarcliente.TabIndex = 20;
            this.btn_buscarcliente.Text = "Buscar";
            this.btn_buscarcliente.UseVisualStyleBackColor = true;
            this.btn_buscarcliente.Click += new System.EventHandler(this.btn_buscarcliente_Click);
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
            // lbl_cliente
            // 
            this.lbl_cliente.AutoSize = true;
            this.lbl_cliente.Location = new System.Drawing.Point(273, 53);
            this.lbl_cliente.Name = "lbl_cliente";
            this.lbl_cliente.Size = new System.Drawing.Size(42, 13);
            this.lbl_cliente.TabIndex = 18;
            this.lbl_cliente.Text = "Cliente:";
            // 
            // tb_cliente
            // 
            this.tb_cliente.Location = new System.Drawing.Point(320, 50);
            this.tb_cliente.Name = "tb_cliente";
            this.tb_cliente.ReadOnly = true;
            this.tb_cliente.Size = new System.Drawing.Size(117, 20);
            this.tb_cliente.TabIndex = 15;
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Bauhaus 93", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbl_titulo.Location = new System.Drawing.Point(501, 5);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(71, 24);
            this.lbl_titulo.TabIndex = 16;
            this.lbl_titulo.Text = "Ventas";
            // 
            // lbl_fecha01
            // 
            this.lbl_fecha01.AutoSize = true;
            this.lbl_fecha01.Location = new System.Drawing.Point(39, 16);
            this.lbl_fecha01.Name = "lbl_fecha01";
            this.lbl_fecha01.Size = new System.Drawing.Size(65, 13);
            this.lbl_fecha01.TabIndex = 19;
            this.lbl_fecha01.Text = "Fecha Inicio";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btn_refrescar
            // 
            this.btn_refrescar.Location = new System.Drawing.Point(332, 42);
            this.btn_refrescar.Name = "btn_refrescar";
            this.btn_refrescar.Size = new System.Drawing.Size(85, 20);
            this.btn_refrescar.TabIndex = 24;
            this.btn_refrescar.Text = "Refrescar";
            this.btn_refrescar.UseVisualStyleBackColor = true;
            this.btn_refrescar.Click += new System.EventHandler(this.btn_refrescar_Click);
            // 
            // frmVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 565);
            this.Controls.Add(this.btn_refrescar);
            this.Controls.Add(this.lbl_fecha02);
            this.Controls.Add(this.dt_busqueda2);
            this.Controls.Add(this.dt_busqueda1);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.tabControl_principal);
            this.Controls.Add(this.lbl_titulo);
            this.Controls.Add(this.lbl_fecha01);
            this.Name = "frmVenta";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmVenta_FormClosing);
            this.Load += new System.EventHandler(this.frmVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datos_venta)).EndInit();
            this.tabControl_principal.ResumeLayout(false);
            this.tagpage1.ResumeLayout(false);
            this.tagpage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_detalle)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_idcliente;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.TextBox tb_idventa;
        private System.Windows.Forms.Label lbl_IDpre;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Eliminar;
        private System.Windows.Forms.DataGridView datos_venta;
        private System.Windows.Forms.Label lbl_comprobante;
        private System.Windows.Forms.TextBox tb_idarticulo_dingreso;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.DateTimePicker dt_vencimiento;
        private System.Windows.Forms.Label lbl_fechavencimiento;
        private System.Windows.Forms.Label lbl_fecha02;
        private System.Windows.Forms.DateTimePicker dt_busqueda2;
        private System.Windows.Forms.TextBox tb_precioventa;
        private System.Windows.Forms.Label lbl_precioventa;
        private System.Windows.Forms.TextBox tb_preciocompra;
        private System.Windows.Forms.Label lbl_preciocompra;
        private System.Windows.Forms.TextBox tb_cantidad;
        private System.Windows.Forms.Label lbl_cantidad;
        private System.Windows.Forms.DateTimePicker dt_busqueda1;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Button btn_buscararticulo;
        private System.Windows.Forms.CheckBox checkBox_eliminar;
        private System.Windows.Forms.TextBox tb_articulo;
        private System.Windows.Forms.TabControl tabControl_principal;
        private System.Windows.Forms.TabPage tagpage1;
        private System.Windows.Forms.Label lbl_total_filas;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lbl_pago;
        private System.Windows.Forms.Label lbl_totalpagado;
        private System.Windows.Forms.DataGridView data_detalle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tb_descuento;
        private System.Windows.Forms.Label lbl_descuento;
        private System.Windows.Forms.TextBox tb_stockactual;
        private System.Windows.Forms.Label lbl_articulo;
        private System.Windows.Forms.ComboBox cb_comprobante;
        private System.Windows.Forms.DateTimePicker dt_fechamadre;
        private System.Windows.Forms.Button btn_buscarcliente;
        private System.Windows.Forms.Label lbl_fechaproveedor;
        private System.Windows.Forms.Label lbl_cliente;
        private System.Windows.Forms.TextBox tb_cliente;
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Label lbl_fecha01;
        private System.Windows.Forms.Button btn_comprobante;
        private System.Windows.Forms.ToolTip MensajeAyuda;
        private System.Windows.Forms.Label lbl_stock;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btn_nuevo;
        private System.Windows.Forms.Button btn_cancelar2;
        private System.Windows.Forms.Label lbl_porcentaje;
        private System.Windows.Forms.Button btn_refrescar;
    }
}