namespace PjBoleta
{
    partial class Boleta
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            lstProducto = new ComboBox();
            groupBox1 = new GroupBox();
            txtPrecio = new TextBox();
            txtCantidad = new TextBox();
            txtCliente = new TextBox();
            txtDireccion = new TextBox();
            txtFecha = new TextBox();
            txtCedula = new TextBox();
            lvDatosProducto = new ListView();
            btnAgregar = new Button();
            btnIngresarBoleta = new Button();
            label9 = new Label();
            label10 = new Label();
            lvResumenBoletas = new ListView();
            btnSalir = new Button();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            label11 = new Label();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(486, 67);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(486, 42);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 1;
            label2.Text = "label2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(486, 19);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 2;
            label3.Text = "label3";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(27, 104);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 3;
            label4.Text = "CLIENTE";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(10, 149);
            label5.Name = "label5";
            label5.Size = new Size(68, 15);
            label5.TabIndex = 4;
            label5.Text = "DIRECCION";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(330, 104);
            label6.Name = "label6";
            label6.Size = new Size(44, 15);
            label6.TabIndex = 5;
            label6.Text = "FECHA";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(323, 149);
            label7.Name = "label7";
            label7.Size = new Size(51, 15);
            label7.TabIndex = 6;
            label7.Text = "CEDULA";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(182, 19);
            label8.Name = "label8";
            label8.Size = new Size(206, 25);
            label8.TabIndex = 7;
            label8.Text = "CONTROL DE VENTAS";
            // 
            // lstProducto
            // 
            lstProducto.FormattingEnabled = true;
            lstProducto.Location = new Point(6, 45);
            lstProducto.Name = "lstProducto";
            lstProducto.Size = new Size(137, 23);
            lstProducto.TabIndex = 8;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label14);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(btnAgregar);
            groupBox1.Controls.Add(txtCantidad);
            groupBox1.Controls.Add(txtPrecio);
            groupBox1.Controls.Add(lstProducto);
            groupBox1.Location = new Point(25, 187);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(521, 81);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "DATOS DEL PRODUCTO";
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(169, 45);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(108, 23);
            txtPrecio.TabIndex = 9;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(299, 45);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(112, 23);
            txtCantidad.TabIndex = 10;
            // 
            // txtCliente
            // 
            txtCliente.Location = new Point(84, 101);
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new Size(233, 23);
            txtCliente.TabIndex = 10;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(84, 146);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(233, 23);
            txtDireccion.TabIndex = 11;
            // 
            // txtFecha
            // 
            txtFecha.Location = new Point(380, 101);
            txtFecha.Name = "txtFecha";
            txtFecha.Size = new Size(112, 23);
            txtFecha.TabIndex = 12;
            // 
            // txtCedula
            // 
            txtCedula.Location = new Point(380, 146);
            txtCedula.Name = "txtCedula";
            txtCedula.Size = new Size(112, 23);
            txtCedula.TabIndex = 13;
            // 
            // lvDatosProducto
            // 
            lvDatosProducto.Columns.AddRange(new ColumnHeader[] { columnHeader5, columnHeader6, columnHeader7, columnHeader8 });
            lvDatosProducto.GridLines = true;
            lvDatosProducto.Location = new Point(25, 274);
            lvDatosProducto.Name = "lvDatosProducto";
            lvDatosProducto.Size = new Size(521, 80);
            lvDatosProducto.TabIndex = 14;
            lvDatosProducto.UseCompatibleStateImageBehavior = false;
            lvDatosProducto.View = View.Details;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(434, 44);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 11;
            btnAgregar.Text = "AGREGAR";
            btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnIngresarBoleta
            // 
            btnIngresarBoleta.Location = new Point(25, 370);
            btnIngresarBoleta.Name = "btnIngresarBoleta";
            btnIngresarBoleta.Size = new Size(117, 23);
            btnIngresarBoleta.TabIndex = 15;
            btnIngresarBoleta.Text = "INGRESAR BOLETA";
            btnIngresarBoleta.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(368, 371);
            label9.Name = "label9";
            label9.Size = new Size(56, 21);
            label9.TabIndex = 16;
            label9.Text = "TOTAL";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(445, 376);
            label10.Name = "label10";
            label10.Size = new Size(44, 15);
            label10.TabIndex = 17;
            label10.Text = "label10";
            // 
            // lvResumenBoletas
            // 
            lvResumenBoletas.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            lvResumenBoletas.GridLines = true;
            lvResumenBoletas.Location = new Point(25, 424);
            lvResumenBoletas.Name = "lvResumenBoletas";
            lvResumenBoletas.Size = new Size(521, 79);
            lvResumenBoletas.TabIndex = 18;
            lvResumenBoletas.UseCompatibleStateImageBehavior = false;
            lvResumenBoletas.View = View.Details;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(25, 509);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 19;
            btnSalir.Text = "SALIR";
            btnSalir.UseVisualStyleBackColor = true;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "NUM. BOLETAS";
            columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "FECHA";
            columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "TOTAL PRODUCTOS";
            columnHeader3.Width = 120;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "MONTO TOTAL";
            columnHeader4.Width = 120;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(25, 406);
            label11.Name = "label11";
            label11.Size = new Size(199, 15);
            label11.TabIndex = 20;
            label11.Text = "RESUMEN DE REGISTRO DE BOLETAS";
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "CANTIDAD";
            columnHeader5.Width = 120;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "DESCRIPCION";
            columnHeader6.Width = 200;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "PREC. UNIT";
            columnHeader7.Width = 120;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "IMPORTE";
            columnHeader8.Width = 120;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(39, 25);
            label12.Name = "label12";
            label12.Size = new Size(68, 15);
            label12.TabIndex = 12;
            label12.Text = "PRODUCTO";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(202, 25);
            label13.Name = "label13";
            label13.Size = new Size(47, 15);
            label13.TabIndex = 13;
            label13.Text = "PRECIO";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(328, 25);
            label14.Name = "label14";
            label14.Size = new Size(65, 15);
            label14.TabIndex = 14;
            label14.Text = "CANTIDAD";
            // 
            // Boleta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(590, 543);
            Controls.Add(label11);
            Controls.Add(btnSalir);
            Controls.Add(lvResumenBoletas);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(btnIngresarBoleta);
            Controls.Add(lvDatosProducto);
            Controls.Add(txtCedula);
            Controls.Add(txtFecha);
            Controls.Add(txtDireccion);
            Controls.Add(txtCliente);
            Controls.Add(groupBox1);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Boleta";
            Text = "Boleta";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private ComboBox lstProducto;
        private GroupBox groupBox1;
        private TextBox txtCantidad;
        private TextBox txtPrecio;
        private TextBox txtCliente;
        private TextBox txtDireccion;
        private TextBox txtFecha;
        private TextBox txtCedula;
        private Button btnAgregar;
        private ListView lvDatosProducto;
        private Button btnIngresarBoleta;
        private Label label9;
        private Label label10;
        private ListView lvResumenBoletas;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private Button btnSalir;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private Label label11;
        private Label label14;
        private Label label13;
        private Label label12;
    }
}