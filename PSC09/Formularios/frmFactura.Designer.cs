namespace PSC09
{
    partial class frmFactura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFactura));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblNombrePaga = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblArticulo = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblImpuestoLn = new System.Windows.Forms.Label();
            this.lblTotalLn = new System.Windows.Forms.Label();
            this.txtArticulo = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblImpuesto = new System.Windows.Forms.Label();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.lblFactura = new System.Windows.Forms.Label();
            this.lblPagaImpuesto = new System.Windows.Forms.Label();
            this.lblFechaFactura = new System.Windows.Forms.Label();
            this.btnCliente = new System.Windows.Forms.Button();
            this.btnFactura = new System.Windows.Forms.Button();
            this.btnArticulo = new System.Windows.Forms.Button();
            this.btnLimpiarDet = new System.Windows.Forms.Button();
            this.btnBorrarLn = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnInsertarLn = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Crimson;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(-1, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(460, 72);
            this.label1.TabIndex = 56;
            this.label1.Text = "Facturación";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Crimson;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 61;
            this.label2.Text = "Numero Factura";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Crimson;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 62;
            this.label3.Text = "Clientes";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Crimson;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 63;
            this.label4.Text = "Paga Impuesto";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Crimson;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(12, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 64;
            this.label5.Text = "Fecha Factura";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(118, 143);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(119, 20);
            this.txtCliente.TabIndex = 66;
            this.txtCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCliente.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCliente_KeyDown);
            this.txtCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCliente_KeyPress);
            this.txtCliente.Leave += new System.EventHandler(this.txtCliente_Leave);
            // 
            // lblNombre
            // 
            this.lblNombre.BackColor = System.Drawing.SystemColors.Window;
            this.lblNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNombre.Location = new System.Drawing.Point(285, 140);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(285, 23);
            this.lblNombre.TabIndex = 69;
            this.lblNombre.Text = ".";
            // 
            // lblNombrePaga
            // 
            this.lblNombrePaga.BackColor = System.Drawing.SystemColors.Window;
            this.lblNombrePaga.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNombrePaga.Location = new System.Drawing.Point(285, 176);
            this.lblNombrePaga.Name = "lblNombrePaga";
            this.lblNombrePaga.Size = new System.Drawing.Size(137, 23);
            this.lblNombrePaga.TabIndex = 70;
            this.lblNombrePaga.Text = ".";
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Crimson;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(15, 263);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(136, 23);
            this.label8.TabIndex = 71;
            this.label8.Text = "Articulo";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Crimson;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(149, 263);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(421, 22);
            this.label9.TabIndex = 72;
            this.label9.Text = "Descripcion";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Crimson;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(565, 263);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 22);
            this.label10.TabIndex = 73;
            this.label10.Text = "Cantidad";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.Crimson;
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(658, 263);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 22);
            this.label11.TabIndex = 74;
            this.label11.Text = "Precio";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.Crimson;
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(755, 263);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(100, 22);
            this.label12.TabIndex = 75;
            this.label12.Text = "Impuesto";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.Crimson;
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(851, 263);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(97, 22);
            this.label13.TabIndex = 76;
            this.label13.Text = "Total Ln";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblArticulo
            // 
            this.lblArticulo.BackColor = System.Drawing.SystemColors.Window;
            this.lblArticulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblArticulo.Location = new System.Drawing.Point(149, 284);
            this.lblArticulo.Name = "lblArticulo";
            this.lblArticulo.Size = new System.Drawing.Size(421, 20);
            this.lblArticulo.TabIndex = 77;
            this.lblArticulo.Text = ".";
            // 
            // lblPrecio
            // 
            this.lblPrecio.BackColor = System.Drawing.SystemColors.Window;
            this.lblPrecio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPrecio.Location = new System.Drawing.Point(658, 284);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(100, 22);
            this.lblPrecio.TabIndex = 78;
            this.lblPrecio.Text = ".";
            // 
            // lblImpuestoLn
            // 
            this.lblImpuestoLn.BackColor = System.Drawing.SystemColors.Window;
            this.lblImpuestoLn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblImpuestoLn.Location = new System.Drawing.Point(752, 284);
            this.lblImpuestoLn.Name = "lblImpuestoLn";
            this.lblImpuestoLn.Size = new System.Drawing.Size(100, 22);
            this.lblImpuestoLn.TabIndex = 79;
            this.lblImpuestoLn.Text = ".";
            this.lblImpuestoLn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalLn
            // 
            this.lblTotalLn.BackColor = System.Drawing.SystemColors.Window;
            this.lblTotalLn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotalLn.Location = new System.Drawing.Point(848, 284);
            this.lblTotalLn.Name = "lblTotalLn";
            this.lblTotalLn.Size = new System.Drawing.Size(100, 22);
            this.lblTotalLn.TabIndex = 80;
            this.lblTotalLn.Text = ".";
            this.lblTotalLn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtArticulo
            // 
            this.txtArticulo.Location = new System.Drawing.Point(15, 284);
            this.txtArticulo.Name = "txtArticulo";
            this.txtArticulo.Size = new System.Drawing.Size(94, 20);
            this.txtArticulo.TabIndex = 81;
            this.txtArticulo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtArticulo_KeyDown);
            this.txtArticulo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtArticulo_KeyPress);
            this.txtArticulo.Leave += new System.EventHandler(this.txtArticulo_Leave);
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(565, 285);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(97, 20);
            this.txtCantidad.TabIndex = 82;
            this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidad_KeyPress);
            this.txtCantidad.Leave += new System.EventHandler(this.txtCantidad_Leave);
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(18, 311);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(930, 162);
            this.dgv.TabIndex = 84;
            // 
            // label18
            // 
            this.label18.BackColor = System.Drawing.Color.Crimson;
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(604, 554);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(154, 23);
            this.label18.TabIndex = 87;
            this.label18.Text = "Total";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label19
            // 
            this.label19.BackColor = System.Drawing.Color.Crimson;
            this.label19.ForeColor = System.Drawing.Color.White;
            this.label19.Location = new System.Drawing.Point(604, 521);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(154, 23);
            this.label19.TabIndex = 86;
            this.label19.Text = "Impuesto";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label20
            // 
            this.label20.BackColor = System.Drawing.Color.Crimson;
            this.label20.ForeColor = System.Drawing.Color.White;
            this.label20.Location = new System.Drawing.Point(604, 489);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(154, 23);
            this.label20.TabIndex = 85;
            this.label20.Text = "Subtotal";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotal
            // 
            this.lblTotal.BackColor = System.Drawing.SystemColors.Window;
            this.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotal.Location = new System.Drawing.Point(764, 554);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(184, 23);
            this.lblTotal.TabIndex = 90;
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblImpuesto
            // 
            this.lblImpuesto.BackColor = System.Drawing.SystemColors.Window;
            this.lblImpuesto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblImpuesto.Location = new System.Drawing.Point(764, 521);
            this.lblImpuesto.Name = "lblImpuesto";
            this.lblImpuesto.Size = new System.Drawing.Size(184, 23);
            this.lblImpuesto.TabIndex = 89;
            this.lblImpuesto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.BackColor = System.Drawing.SystemColors.Window;
            this.lblSubTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSubTotal.Location = new System.Drawing.Point(764, 489);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(184, 23);
            this.lblSubTotal.TabIndex = 88;
            this.lblSubTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFactura
            // 
            this.lblFactura.BackColor = System.Drawing.SystemColors.Window;
            this.lblFactura.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFactura.Location = new System.Drawing.Point(118, 106);
            this.lblFactura.Name = "lblFactura";
            this.lblFactura.Size = new System.Drawing.Size(119, 23);
            this.lblFactura.TabIndex = 95;
            this.lblFactura.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPagaImpuesto
            // 
            this.lblPagaImpuesto.BackColor = System.Drawing.SystemColors.Window;
            this.lblPagaImpuesto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPagaImpuesto.Location = new System.Drawing.Point(118, 176);
            this.lblPagaImpuesto.Name = "lblPagaImpuesto";
            this.lblPagaImpuesto.Size = new System.Drawing.Size(119, 23);
            this.lblPagaImpuesto.TabIndex = 96;
            this.lblPagaImpuesto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFechaFactura
            // 
            this.lblFechaFactura.BackColor = System.Drawing.SystemColors.Window;
            this.lblFechaFactura.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFechaFactura.Location = new System.Drawing.Point(118, 209);
            this.lblFechaFactura.Name = "lblFechaFactura";
            this.lblFechaFactura.Size = new System.Drawing.Size(119, 23);
            this.lblFechaFactura.TabIndex = 97;
            this.lblFechaFactura.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCliente
            // 
            this.btnCliente.Image = ((System.Drawing.Image)(resources.GetObject("btnCliente.Image")));
            this.btnCliente.Location = new System.Drawing.Point(234, 142);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(45, 21);
            this.btnCliente.TabIndex = 100;
            this.btnCliente.UseVisualStyleBackColor = true;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // btnFactura
            // 
            this.btnFactura.Image = ((System.Drawing.Image)(resources.GetObject("btnFactura.Image")));
            this.btnFactura.Location = new System.Drawing.Point(234, 106);
            this.btnFactura.Name = "btnFactura";
            this.btnFactura.Size = new System.Drawing.Size(45, 23);
            this.btnFactura.TabIndex = 99;
            this.btnFactura.UseVisualStyleBackColor = true;
            this.btnFactura.Click += new System.EventHandler(this.btnFactura_Click);
            // 
            // btnArticulo
            // 
            this.btnArticulo.Image = ((System.Drawing.Image)(resources.GetObject("btnArticulo.Image")));
            this.btnArticulo.Location = new System.Drawing.Point(106, 284);
            this.btnArticulo.Name = "btnArticulo";
            this.btnArticulo.Size = new System.Drawing.Size(45, 20);
            this.btnArticulo.TabIndex = 98;
            this.btnArticulo.UseVisualStyleBackColor = true;
            this.btnArticulo.Click += new System.EventHandler(this.btnArticulo_Click);
            // 
            // btnLimpiarDet
            // 
            this.btnLimpiarDet.Image = global::PSC09.Properties.Resources.filenew1;
            this.btnLimpiarDet.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnLimpiarDet.Location = new System.Drawing.Point(307, 488);
            this.btnLimpiarDet.Name = "btnLimpiarDet";
            this.btnLimpiarDet.Size = new System.Drawing.Size(91, 87);
            this.btnLimpiarDet.TabIndex = 94;
            this.btnLimpiarDet.Text = "Limpiar Detalle";
            this.btnLimpiarDet.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnLimpiarDet.UseVisualStyleBackColor = true;
            this.btnLimpiarDet.Click += new System.EventHandler(this.btnLimpiarDet_Click);
            // 
            // btnBorrarLn
            // 
            this.btnBorrarLn.Image = global::PSC09.Properties.Resources.delete_table_row;
            this.btnBorrarLn.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnBorrarLn.Location = new System.Drawing.Point(212, 488);
            this.btnBorrarLn.Name = "btnBorrarLn";
            this.btnBorrarLn.Size = new System.Drawing.Size(91, 87);
            this.btnBorrarLn.TabIndex = 93;
            this.btnBorrarLn.Text = "Borrar Linea";
            this.btnBorrarLn.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnBorrarLn.UseVisualStyleBackColor = true;
            this.btnBorrarLn.Click += new System.EventHandler(this.btnBorrarLn_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Image = global::PSC09.Properties.Resources.edit;
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnEditar.Location = new System.Drawing.Point(115, 489);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(91, 87);
            this.btnEditar.TabIndex = 92;
            this.btnEditar.Text = "Editar Linea";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnInsertarLn
            // 
            this.btnInsertarLn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnInsertarLn.Image = global::PSC09.Properties.Resources.insert_table_row;
            this.btnInsertarLn.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnInsertarLn.Location = new System.Drawing.Point(18, 488);
            this.btnInsertarLn.Name = "btnInsertarLn";
            this.btnInsertarLn.Size = new System.Drawing.Size(91, 87);
            this.btnInsertarLn.TabIndex = 91;
            this.btnInsertarLn.Text = "Insertar Linea";
            this.btnInsertarLn.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnInsertarLn.UseVisualStyleBackColor = true;
            this.btnInsertarLn.Click += new System.EventHandler(this.btnInsertarLn_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Image = ((System.Drawing.Image)(resources.GetObject("btnImprimir.Image")));
            this.btnImprimir.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnImprimir.Location = new System.Drawing.Point(745, 0);
            this.btnImprimir.Margin = new System.Windows.Forms.Padding(2);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(93, 72);
            this.btnImprimir.TabIndex = 83;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Image = global::PSC09.Properties.Resources.exit;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnSalir.Location = new System.Drawing.Point(842, 0);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(93, 72);
            this.btnSalir.TabIndex = 60;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Image = global::PSC09.Properties.Resources.editdelete;
            this.btnBorrar.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnBorrar.Location = new System.Drawing.Point(648, 0);
            this.btnBorrar.Margin = new System.Windows.Forms.Padding(2);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(93, 72);
            this.btnBorrar.TabIndex = 59;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Image = global::PSC09.Properties.Resources.filenew;
            this.btnLimpiar.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnLimpiar.Location = new System.Drawing.Point(551, 0);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(2);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(93, 72);
            this.btnLimpiar.TabIndex = 58;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Image = global::PSC09.Properties.Resources.filesave;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnGuardar.Location = new System.Drawing.Point(454, 0);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(93, 72);
            this.btnGuardar.TabIndex = 57;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // frmFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 599);
            this.Controls.Add(this.btnCliente);
            this.Controls.Add(this.btnFactura);
            this.Controls.Add(this.btnArticulo);
            this.Controls.Add(this.lblFechaFactura);
            this.Controls.Add(this.lblPagaImpuesto);
            this.Controls.Add(this.lblFactura);
            this.Controls.Add(this.btnLimpiarDet);
            this.Controls.Add(this.btnBorrarLn);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnInsertarLn);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblImpuesto);
            this.Controls.Add(this.lblSubTotal);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.txtArticulo);
            this.Controls.Add(this.lblTotalLn);
            this.Controls.Add(this.lblImpuestoLn);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblArticulo);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblNombrePaga);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.label1);
            this.Name = "frmFactura";
            this.Text = "frmFactura";
            this.Load += new System.EventHandler(this.frmFactura_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmFactura_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblNombrePaga;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblArticulo;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblImpuestoLn;
        private System.Windows.Forms.Label lblTotalLn;
        private System.Windows.Forms.TextBox txtArticulo;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblImpuesto;
        private System.Windows.Forms.Label lblSubTotal;
        private System.Windows.Forms.Button btnInsertarLn;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnBorrarLn;
        private System.Windows.Forms.Button btnLimpiarDet;
        private System.Windows.Forms.Label lblFactura;
        private System.Windows.Forms.Label lblPagaImpuesto;
        private System.Windows.Forms.Label lblFechaFactura;
        private System.Windows.Forms.Button btnArticulo;
        private System.Windows.Forms.Button btnFactura;
        private System.Windows.Forms.Button btnCliente;
    }
}