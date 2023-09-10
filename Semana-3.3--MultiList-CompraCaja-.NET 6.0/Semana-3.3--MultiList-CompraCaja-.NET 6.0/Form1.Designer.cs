namespace Semana_3._3__MultiList_CompraCaja_.NET_6._0
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox4 = new GroupBox();
            lblMontoTotal = new Label();
            lblMenorMonto = new Label();
            label9 = new Label();
            label12 = new Label();
            listViewCompra = new ListView();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            listViewCaja = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            groupBox2 = new GroupBox();
            dateTimePickerFecha = new DateTimePicker();
            label8 = new Label();
            btnRegistrarHeroe = new Button();
            btnLimpiarHeroe = new Button();
            label6 = new Label();
            tbMonto = new TextBox();
            tbDNICliente = new TextBox();
            label4 = new Label();
            label3 = new Label();
            groupBox1 = new GroupBox();
            label7 = new Label();
            btnLimpiarAlbum = new Button();
            btnRegistrarCaja = new Button();
            tbNombreCajero = new TextBox();
            tbCodigo = new TextBox();
            label2 = new Label();
            label1 = new Label();
            groupBox4.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(lblMontoTotal);
            groupBox4.Controls.Add(lblMenorMonto);
            groupBox4.Controls.Add(label9);
            groupBox4.Controls.Add(label12);
            groupBox4.FlatStyle = FlatStyle.System;
            groupBox4.Location = new Point(384, 417);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(506, 82);
            groupBox4.TabIndex = 24;
            groupBox4.TabStop = false;
            // 
            // lblMontoTotal
            // 
            lblMontoTotal.AutoSize = true;
            lblMontoTotal.Location = new Point(284, 50);
            lblMontoTotal.Name = "lblMontoTotal";
            lblMontoTotal.Size = new Size(12, 15);
            lblMontoTotal.TabIndex = 3;
            lblMontoTotal.Text = "-";
            // 
            // lblMenorMonto
            // 
            lblMenorMonto.AutoSize = true;
            lblMenorMonto.Location = new Point(258, 23);
            lblMenorMonto.Name = "lblMenorMonto";
            lblMenorMonto.Size = new Size(12, 15);
            lblMenorMonto.TabIndex = 2;
            lblMenorMonto.Text = "-";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(33, 50);
            label9.Name = "label9";
            label9.Size = new Size(235, 15);
            label9.TabIndex = 1;
            label9.Text = "Monto total de compras de todas las cajas :";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(33, 23);
            label12.Name = "label12";
            label12.Size = new Size(210, 15);
            label12.TabIndex = 0;
            label12.Text = "Cliente con menor monto de compra :";
            // 
            // listViewCompra
            // 
            listViewCompra.Columns.AddRange(new ColumnHeader[] { columnHeader3, columnHeader4, columnHeader5 });
            listViewCompra.Location = new Point(384, 198);
            listViewCompra.Name = "listViewCompra";
            listViewCompra.Size = new Size(506, 215);
            listViewCompra.TabIndex = 22;
            listViewCompra.UseCompatibleStateImageBehavior = false;
            listViewCompra.View = View.Details;
            listViewCompra.SelectedIndexChanged += listViewCompra_SelectedIndexChanged;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "DNI del cliente";
            columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Monto";
            columnHeader4.Width = 120;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Fecha de la compra";
            columnHeader5.Width = 230;
            // 
            // listViewCaja
            // 
            listViewCaja.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2 });
            listViewCaja.Location = new Point(12, 198);
            listViewCaja.Name = "listViewCaja";
            listViewCaja.Size = new Size(366, 301);
            listViewCaja.TabIndex = 21;
            listViewCaja.UseCompatibleStateImageBehavior = false;
            listViewCaja.View = View.Details;
            listViewCaja.SelectedIndexChanged += listViewCaja_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Código";
            columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Nombre del cajero";
            columnHeader2.Width = 210;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dateTimePickerFecha);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(btnRegistrarHeroe);
            groupBox2.Controls.Add(btnLimpiarHeroe);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(tbMonto);
            groupBox2.Controls.Add(tbDNICliente);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.FlatStyle = FlatStyle.System;
            groupBox2.Location = new Point(384, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(506, 176);
            groupBox2.TabIndex = 20;
            groupBox2.TabStop = false;
            // 
            // dateTimePickerFecha
            // 
            dateTimePickerFecha.Location = new Point(74, 87);
            dateTimePickerFecha.Name = "dateTimePickerFecha";
            dateTimePickerFecha.Size = new Size(253, 23);
            dateTimePickerFecha.TabIndex = 12;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(230, 23);
            label8.Name = "label8";
            label8.Size = new Size(63, 17);
            label8.TabIndex = 11;
            label8.Text = "COMPRA";
            // 
            // btnRegistrarHeroe
            // 
            btnRegistrarHeroe.FlatStyle = FlatStyle.Flat;
            btnRegistrarHeroe.Location = new Point(151, 130);
            btnRegistrarHeroe.Name = "btnRegistrarHeroe";
            btnRegistrarHeroe.Size = new Size(87, 28);
            btnRegistrarHeroe.TabIndex = 7;
            btnRegistrarHeroe.Text = "Registrar";
            btnRegistrarHeroe.UseVisualStyleBackColor = true;
            btnRegistrarHeroe.Click += btnRegistrarCompra_Click;
            // 
            // btnLimpiarHeroe
            // 
            btnLimpiarHeroe.FlatStyle = FlatStyle.Flat;
            btnLimpiarHeroe.Location = new Point(276, 130);
            btnLimpiarHeroe.Name = "btnLimpiarHeroe";
            btnLimpiarHeroe.Size = new Size(87, 28);
            btnLimpiarHeroe.TabIndex = 10;
            btnLimpiarHeroe.Text = "Limpiar";
            btnLimpiarHeroe.UseVisualStyleBackColor = true;
            btnLimpiarHeroe.Click += btnLimpiarCompra_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(18, 91);
            label6.Name = "label6";
            label6.Size = new Size(50, 15);
            label6.TabIndex = 6;
            label6.Text = "FECHA :";
            // 
            // tbMonto
            // 
            tbMonto.Location = new Point(389, 53);
            tbMonto.Name = "tbMonto";
            tbMonto.Size = new Size(99, 23);
            tbMonto.TabIndex = 4;
            // 
            // tbDNICliente
            // 
            tbDNICliente.Location = new Point(128, 53);
            tbDNICliente.Name = "tbDNICliente";
            tbDNICliente.Size = new Size(158, 23);
            tbDNICliente.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(327, 57);
            label4.Name = "label4";
            label4.Size = new Size(56, 15);
            label4.TabIndex = 2;
            label4.Text = "MONTO :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 57);
            label3.Name = "label3";
            label3.Size = new Size(103, 15);
            label3.TabIndex = 2;
            label3.Text = "DNI DEL CLIENTE :";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(btnLimpiarAlbum);
            groupBox1.Controls.Add(btnRegistrarCaja);
            groupBox1.Controls.Add(tbNombreCajero);
            groupBox1.Controls.Add(tbCodigo);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.FlatStyle = FlatStyle.System;
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(366, 176);
            groupBox1.TabIndex = 19;
            groupBox1.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(171, 23);
            label7.Name = "label7";
            label7.Size = new Size(40, 17);
            label7.TabIndex = 10;
            label7.Text = "CAJA";
            // 
            // btnLimpiarAlbum
            // 
            btnLimpiarAlbum.FlatStyle = FlatStyle.Flat;
            btnLimpiarAlbum.Location = new Point(203, 130);
            btnLimpiarAlbum.Name = "btnLimpiarAlbum";
            btnLimpiarAlbum.Size = new Size(87, 28);
            btnLimpiarAlbum.TabIndex = 9;
            btnLimpiarAlbum.Text = "Limpiar";
            btnLimpiarAlbum.UseVisualStyleBackColor = true;
            btnLimpiarAlbum.Click += btnLimpiarCaja_Click;
            // 
            // btnRegistrarCaja
            // 
            btnRegistrarCaja.FlatStyle = FlatStyle.Flat;
            btnRegistrarCaja.Location = new Point(79, 130);
            btnRegistrarCaja.Name = "btnRegistrarCaja";
            btnRegistrarCaja.Size = new Size(87, 28);
            btnRegistrarCaja.TabIndex = 6;
            btnRegistrarCaja.Text = "Registrar";
            btnRegistrarCaja.UseVisualStyleBackColor = true;
            btnRegistrarCaja.Click += btnRegistrarCaja_Click;
            // 
            // tbNombreCajero
            // 
            tbNombreCajero.Location = new Point(157, 87);
            tbNombreCajero.Name = "tbNombreCajero";
            tbNombreCajero.Size = new Size(187, 23);
            tbNombreCajero.TabIndex = 5;
            // 
            // tbCodigo
            // 
            tbCodigo.Location = new Point(89, 53);
            tbCodigo.Name = "tbCodigo";
            tbCodigo.Size = new Size(108, 23);
            tbCodigo.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 90);
            label2.Name = "label2";
            label2.Size = new Size(131, 15);
            label2.TabIndex = 1;
            label2.Text = "NOMBRE DEL CAJERO :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 57);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 0;
            label1.Text = "CÓDIGO :";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(902, 512);
            Controls.Add(groupBox4);
            Controls.Add(listViewCompra);
            Controls.Add(listViewCaja);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox4;
        private Label lblMontoTotal;
        private Label lblMenorMonto;
        private Label label9;
        private Label label12;
        private ListView listViewCompra;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ListView listViewCaja;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private GroupBox groupBox2;
        private Label label8;
        private Button btnRegistrarHeroe;
        private Button btnLimpiarHeroe;
        private Label label6;
        private TextBox tbMonto;
        private TextBox tbDNICliente;
        private Label label4;
        private Label label3;
        private GroupBox groupBox1;
        private Label label7;
        private Button btnLimpiarAlbum;
        private Button btnRegistrarCaja;
        private TextBox tbNombreCajero;
        private TextBox tbCodigo;
        private Label label2;
        private Label label1;
        private DateTimePicker dateTimePickerFecha;
    }
}