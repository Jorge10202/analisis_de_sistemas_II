﻿
namespace AdminRepartoApp
{
    partial class frmBodegasTransportes
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
            this.pnlMain = new System.Windows.Forms.Panel();
            this.lblRegister = new System.Windows.Forms.Label();
            this.gpbAsingarPedidos = new System.Windows.Forms.GroupBox();
            this.txtEnvio = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.dtpFechaSolicitud = new System.Windows.Forms.DateTimePicker();
            this.btnGuardarEnvio = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbEstadoEnvio = new System.Windows.Forms.ComboBox();
            this.txtDireccionRecoleccion = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDireccionEntrega = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCorreoCliente = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDireccionCliente = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtApellidosCliente = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvPedidos = new System.Windows.Forms.DataGridView();
            this.btnAsignarPiloto = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbBuscarPiloto = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbBuscarPedidoNoAsignado = new System.Windows.Forms.ComboBox();
            this.gpbOC = new System.Windows.Forms.GroupBox();
            this.btnGuardarOrden = new System.Windows.Forms.Button();
            this.txtMontoOrden = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtCantidadOrden = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbProductoOrden = new System.Windows.Forms.ComboBox();
            this.txtIDEnvio = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtIDVehiculo = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.pnlMain.SuspendLayout();
            this.gpbAsingarPedidos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).BeginInit();
            this.gpbOC.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(113)))), ((int)(((byte)(236)))));
            this.pnlMain.Controls.Add(this.lblRegister);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMain.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(4);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(778, 40);
            this.pnlMain.TabIndex = 3;
            // 
            // lblRegister
            // 
            this.lblRegister.AutoSize = true;
            this.lblRegister.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegister.ForeColor = System.Drawing.Color.White;
            this.lblRegister.Location = new System.Drawing.Point(4, 9);
            this.lblRegister.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRegister.Name = "lblRegister";
            this.lblRegister.Size = new System.Drawing.Size(169, 25);
            this.lblRegister.TabIndex = 0;
            this.lblRegister.Text = "Añadir Productos";
            // 
            // gpbAsingarPedidos
            // 
            this.gpbAsingarPedidos.Controls.Add(this.txtEnvio);
            this.gpbAsingarPedidos.Controls.Add(this.label16);
            this.gpbAsingarPedidos.Controls.Add(this.txtMonto);
            this.gpbAsingarPedidos.Controls.Add(this.label15);
            this.gpbAsingarPedidos.Controls.Add(this.txtCantidad);
            this.gpbAsingarPedidos.Controls.Add(this.label14);
            this.gpbAsingarPedidos.Controls.Add(this.label13);
            this.gpbAsingarPedidos.Controls.Add(this.dtpFechaSolicitud);
            this.gpbAsingarPedidos.Controls.Add(this.btnGuardarEnvio);
            this.gpbAsingarPedidos.Controls.Add(this.label9);
            this.gpbAsingarPedidos.Controls.Add(this.cmbEstadoEnvio);
            this.gpbAsingarPedidos.Controls.Add(this.txtDireccionRecoleccion);
            this.gpbAsingarPedidos.Controls.Add(this.label8);
            this.gpbAsingarPedidos.Controls.Add(this.txtDireccionEntrega);
            this.gpbAsingarPedidos.Controls.Add(this.label7);
            this.gpbAsingarPedidos.Controls.Add(this.txtCorreoCliente);
            this.gpbAsingarPedidos.Controls.Add(this.label6);
            this.gpbAsingarPedidos.Controls.Add(this.txtDireccionCliente);
            this.gpbAsingarPedidos.Controls.Add(this.label5);
            this.gpbAsingarPedidos.Controls.Add(this.txtApellidosCliente);
            this.gpbAsingarPedidos.Controls.Add(this.label4);
            this.gpbAsingarPedidos.Controls.Add(this.txtNombreCliente);
            this.gpbAsingarPedidos.Controls.Add(this.label3);
            this.gpbAsingarPedidos.Controls.Add(this.dgvPedidos);
            this.gpbAsingarPedidos.Controls.Add(this.btnAsignarPiloto);
            this.gpbAsingarPedidos.Controls.Add(this.label2);
            this.gpbAsingarPedidos.Controls.Add(this.cmbBuscarPiloto);
            this.gpbAsingarPedidos.Controls.Add(this.label1);
            this.gpbAsingarPedidos.Controls.Add(this.cmbBuscarPedidoNoAsignado);
            this.gpbAsingarPedidos.Location = new System.Drawing.Point(7, 47);
            this.gpbAsingarPedidos.Name = "gpbAsingarPedidos";
            this.gpbAsingarPedidos.Size = new System.Drawing.Size(377, 607);
            this.gpbAsingarPedidos.TabIndex = 4;
            this.gpbAsingarPedidos.TabStop = false;
            this.gpbAsingarPedidos.Text = "Asignación de Pedidos";
            // 
            // txtEnvio
            // 
            this.txtEnvio.Location = new System.Drawing.Point(177, 544);
            this.txtEnvio.Name = "txtEnvio";
            this.txtEnvio.Size = new System.Drawing.Size(194, 20);
            this.txtEnvio.TabIndex = 28;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 544);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(36, 13);
            this.label16.TabIndex = 27;
            this.label16.Text = "Envío";
            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(177, 518);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(194, 20);
            this.txtMonto.TabIndex = 26;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 518);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(37, 13);
            this.label15.TabIndex = 25;
            this.label15.Text = "Monto";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(177, 492);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(194, 20);
            this.txtCantidad.TabIndex = 24;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 492);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(49, 13);
            this.label14.TabIndex = 23;
            this.label14.Text = "Cantidad";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 466);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(89, 13);
            this.label13.TabIndex = 22;
            this.label13.Text = "Fecha del pedido";
            // 
            // dtpFechaSolicitud
            // 
            this.dtpFechaSolicitud.Location = new System.Drawing.Point(176, 466);
            this.dtpFechaSolicitud.Name = "dtpFechaSolicitud";
            this.dtpFechaSolicitud.Size = new System.Drawing.Size(192, 20);
            this.dtpFechaSolicitud.TabIndex = 21;
            // 
            // btnGuardarEnvio
            // 
            this.btnGuardarEnvio.Location = new System.Drawing.Point(284, 570);
            this.btnGuardarEnvio.Name = "btnGuardarEnvio";
            this.btnGuardarEnvio.Size = new System.Drawing.Size(86, 28);
            this.btnGuardarEnvio.TabIndex = 20;
            this.btnGuardarEnvio.Text = "Guardar Envío";
            this.btnGuardarEnvio.UseVisualStyleBackColor = true;
            this.btnGuardarEnvio.Click += new System.EventHandler(this.btnGuardarEnvio_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(5, 439);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Estado Envío";
            // 
            // cmbEstadoEnvio
            // 
            this.cmbEstadoEnvio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstadoEnvio.FormattingEnabled = true;
            this.cmbEstadoEnvio.Location = new System.Drawing.Point(177, 439);
            this.cmbEstadoEnvio.Name = "cmbEstadoEnvio";
            this.cmbEstadoEnvio.Size = new System.Drawing.Size(193, 21);
            this.cmbEstadoEnvio.TabIndex = 18;
            // 
            // txtDireccionRecoleccion
            // 
            this.txtDireccionRecoleccion.Location = new System.Drawing.Point(176, 413);
            this.txtDireccionRecoleccion.Name = "txtDireccionRecoleccion";
            this.txtDireccionRecoleccion.Size = new System.Drawing.Size(194, 20);
            this.txtDireccionRecoleccion.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 413);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Dirección recolección";
            // 
            // txtDireccionEntrega
            // 
            this.txtDireccionEntrega.Location = new System.Drawing.Point(176, 387);
            this.txtDireccionEntrega.Name = "txtDireccionEntrega";
            this.txtDireccionEntrega.Size = new System.Drawing.Size(194, 20);
            this.txtDireccionEntrega.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 387);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Dirección entrega";
            // 
            // txtCorreoCliente
            // 
            this.txtCorreoCliente.Location = new System.Drawing.Point(176, 361);
            this.txtCorreoCliente.Name = "txtCorreoCliente";
            this.txtCorreoCliente.Size = new System.Drawing.Size(194, 20);
            this.txtCorreoCliente.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 361);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Correo Cliente";
            // 
            // txtDireccionCliente
            // 
            this.txtDireccionCliente.Location = new System.Drawing.Point(176, 335);
            this.txtDireccionCliente.Name = "txtDireccionCliente";
            this.txtDireccionCliente.Size = new System.Drawing.Size(194, 20);
            this.txtDireccionCliente.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 335);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Dirección Cliente";
            // 
            // txtApellidosCliente
            // 
            this.txtApellidosCliente.Location = new System.Drawing.Point(177, 309);
            this.txtApellidosCliente.Name = "txtApellidosCliente";
            this.txtApellidosCliente.Size = new System.Drawing.Size(194, 20);
            this.txtApellidosCliente.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 309);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Apellido Cliente";
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Location = new System.Drawing.Point(177, 283);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(194, 20);
            this.txtNombreCliente.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 283);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nombre Cliente";
            // 
            // dgvPedidos
            // 
            this.dgvPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedidos.Location = new System.Drawing.Point(5, 103);
            this.dgvPedidos.Name = "dgvPedidos";
            this.dgvPedidos.Size = new System.Drawing.Size(365, 177);
            this.dgvPedidos.TabIndex = 5;
            // 
            // btnAsignarPiloto
            // 
            this.btnAsignarPiloto.Location = new System.Drawing.Point(230, 73);
            this.btnAsignarPiloto.Name = "btnAsignarPiloto";
            this.btnAsignarPiloto.Size = new System.Drawing.Size(141, 23);
            this.btnAsignarPiloto.TabIndex = 4;
            this.btnAsignarPiloto.Text = "Asginar pedido";
            this.btnAsignarPiloto.UseVisualStyleBackColor = true;
            this.btnAsignarPiloto.Click += new System.EventHandler(this.btnAsignarPiloto_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Asignar Piloto";
            // 
            // cmbBuscarPiloto
            // 
            this.cmbBuscarPiloto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBuscarPiloto.FormattingEnabled = true;
            this.cmbBuscarPiloto.Location = new System.Drawing.Point(230, 46);
            this.cmbBuscarPiloto.Name = "cmbBuscarPiloto";
            this.cmbBuscarPiloto.Size = new System.Drawing.Size(141, 21);
            this.cmbBuscarPiloto.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pedidos No Asignados";
            // 
            // cmbBuscarPedidoNoAsignado
            // 
            this.cmbBuscarPedidoNoAsignado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBuscarPedidoNoAsignado.FormattingEnabled = true;
            this.cmbBuscarPedidoNoAsignado.Location = new System.Drawing.Point(230, 19);
            this.cmbBuscarPedidoNoAsignado.Name = "cmbBuscarPedidoNoAsignado";
            this.cmbBuscarPedidoNoAsignado.Size = new System.Drawing.Size(141, 21);
            this.cmbBuscarPedidoNoAsignado.TabIndex = 0;
            this.cmbBuscarPedidoNoAsignado.SelectedIndexChanged += new System.EventHandler(this.cmbBuscarPedidoNoAsignado_SelectedIndexChanged);
            // 
            // gpbOC
            // 
            this.gpbOC.Controls.Add(this.btnGuardarOrden);
            this.gpbOC.Controls.Add(this.txtMontoOrden);
            this.gpbOC.Controls.Add(this.label12);
            this.gpbOC.Controls.Add(this.txtCantidadOrden);
            this.gpbOC.Controls.Add(this.label11);
            this.gpbOC.Controls.Add(this.label10);
            this.gpbOC.Controls.Add(this.cmbProductoOrden);
            this.gpbOC.Location = new System.Drawing.Point(396, 54);
            this.gpbOC.Name = "gpbOC";
            this.gpbOC.Size = new System.Drawing.Size(377, 137);
            this.gpbOC.TabIndex = 5;
            this.gpbOC.TabStop = false;
            this.gpbOC.Text = "Órden de Compra";
            // 
            // btnGuardarOrden
            // 
            this.btnGuardarOrden.Location = new System.Drawing.Point(230, 98);
            this.btnGuardarOrden.Name = "btnGuardarOrden";
            this.btnGuardarOrden.Size = new System.Drawing.Size(141, 28);
            this.btnGuardarOrden.TabIndex = 21;
            this.btnGuardarOrden.Text = "Guardar Órden de Compra";
            this.btnGuardarOrden.UseVisualStyleBackColor = true;
            this.btnGuardarOrden.Click += new System.EventHandler(this.btnGuardarOrden_Click);
            // 
            // txtMontoOrden
            // 
            this.txtMontoOrden.Location = new System.Drawing.Point(230, 72);
            this.txtMontoOrden.Name = "txtMontoOrden";
            this.txtMontoOrden.Size = new System.Drawing.Size(141, 20);
            this.txtMontoOrden.TabIndex = 24;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 72);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 13);
            this.label12.TabIndex = 23;
            this.label12.Text = "Monto Total";
            // 
            // txtCantidadOrden
            // 
            this.txtCantidadOrden.Location = new System.Drawing.Point(230, 46);
            this.txtCantidadOrden.Name = "txtCantidadOrden";
            this.txtCantidadOrden.Size = new System.Drawing.Size(141, 20);
            this.txtCantidadOrden.TabIndex = 22;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 46);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(158, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "Cantidad del producto a solicitar";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 19);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(159, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Producto de la órden de compra";
            // 
            // cmbProductoOrden
            // 
            this.cmbProductoOrden.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProductoOrden.FormattingEnabled = true;
            this.cmbProductoOrden.Location = new System.Drawing.Point(230, 19);
            this.cmbProductoOrden.Name = "cmbProductoOrden";
            this.cmbProductoOrden.Size = new System.Drawing.Size(141, 21);
            this.cmbProductoOrden.TabIndex = 21;
            this.cmbProductoOrden.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtIDEnvio
            // 
            this.txtIDEnvio.Location = new System.Drawing.Point(579, 197);
            this.txtIDEnvio.Name = "txtIDEnvio";
            this.txtIDEnvio.Size = new System.Drawing.Size(194, 20);
            this.txtIDEnvio.TabIndex = 30;
            this.txtIDEnvio.Visible = false;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(408, 197);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(50, 13);
            this.label17.TabIndex = 29;
            this.label17.Text = "ID Envío";
            this.label17.Visible = false;
            // 
            // txtIDVehiculo
            // 
            this.txtIDVehiculo.Location = new System.Drawing.Point(579, 223);
            this.txtIDVehiculo.Name = "txtIDVehiculo";
            this.txtIDVehiculo.Size = new System.Drawing.Size(194, 20);
            this.txtIDVehiculo.TabIndex = 32;
            this.txtIDVehiculo.Visible = false;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(408, 223);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(64, 13);
            this.label18.TabIndex = 31;
            this.label18.Text = "ID Vehículo";
            this.label18.Visible = false;
            // 
            // frmBodegasTransportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 659);
            this.Controls.Add(this.txtIDVehiculo);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.txtIDEnvio);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.gpbOC);
            this.Controls.Add(this.gpbAsingarPedidos);
            this.Controls.Add(this.pnlMain);
            this.Name = "frmBodegasTransportes";
            this.Text = "frmBodegasTransportes";
            this.Load += new System.EventHandler(this.frmBodegasTransportes_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.gpbAsingarPedidos.ResumeLayout(false);
            this.gpbAsingarPedidos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).EndInit();
            this.gpbOC.ResumeLayout(false);
            this.gpbOC.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Label lblRegister;
        private System.Windows.Forms.GroupBox gpbAsingarPedidos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbBuscarPedidoNoAsignado;
        private System.Windows.Forms.DataGridView dgvPedidos;
        private System.Windows.Forms.Button btnAsignarPiloto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbBuscarPiloto;
        private System.Windows.Forms.Button btnGuardarEnvio;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbEstadoEnvio;
        private System.Windows.Forms.TextBox txtDireccionRecoleccion;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDireccionEntrega;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCorreoCliente;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDireccionCliente;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtApellidosCliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gpbOC;
        private System.Windows.Forms.Button btnGuardarOrden;
        private System.Windows.Forms.TextBox txtMontoOrden;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtCantidadOrden;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbProductoOrden;
        private System.Windows.Forms.TextBox txtEnvio;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker dtpFechaSolicitud;
        private System.Windows.Forms.TextBox txtIDEnvio;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtIDVehiculo;
        private System.Windows.Forms.Label label18;
    }
}