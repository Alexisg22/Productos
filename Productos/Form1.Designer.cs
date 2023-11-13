namespace Productos
{
    partial class frmClientes
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
            this.dgvFactura = new System.Windows.Forms.DataGridView();
            this.clmNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmAntiguedad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDescuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSubtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmRetencion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btmIngresar = new System.Windows.Forms.Button();
            this.btmCalcular = new System.Windows.Forms.Button();
            this.btmSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFactura)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFactura
            // 
            this.dgvFactura.AllowUserToAddRows = false;
            this.dgvFactura.AllowUserToDeleteRows = false;
            this.dgvFactura.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFactura.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmNombre,
            this.clmCodigo,
            this.clmAntiguedad,
            this.clmValor,
            this.clmDescuento,
            this.clmSubtotal,
            this.clmRetencion,
            this.clmTotal});
            this.dgvFactura.Location = new System.Drawing.Point(16, 15);
            this.dgvFactura.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvFactura.Name = "dgvFactura";
            this.dgvFactura.ReadOnly = true;
            this.dgvFactura.RowHeadersWidth = 51;
            this.dgvFactura.Size = new System.Drawing.Size(1476, 448);
            this.dgvFactura.TabIndex = 0;
            this.dgvFactura.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFactura_CellContentClick);
            // 
            // clmNombre
            // 
            this.clmNombre.HeaderText = "Nombre";
            this.clmNombre.MinimumWidth = 6;
            this.clmNombre.Name = "clmNombre";
            this.clmNombre.ReadOnly = true;
            // 
            // clmCodigo
            // 
            this.clmCodigo.HeaderText = "Codigo";
            this.clmCodigo.MinimumWidth = 6;
            this.clmCodigo.Name = "clmCodigo";
            this.clmCodigo.ReadOnly = true;
            // 
            // clmAntiguedad
            // 
            this.clmAntiguedad.HeaderText = "Antiguedad";
            this.clmAntiguedad.MinimumWidth = 6;
            this.clmAntiguedad.Name = "clmAntiguedad";
            this.clmAntiguedad.ReadOnly = true;
            // 
            // clmValor
            // 
            this.clmValor.HeaderText = "Valor";
            this.clmValor.MinimumWidth = 6;
            this.clmValor.Name = "clmValor";
            this.clmValor.ReadOnly = true;
            // 
            // clmDescuento
            // 
            this.clmDescuento.HeaderText = "Descuento";
            this.clmDescuento.MinimumWidth = 6;
            this.clmDescuento.Name = "clmDescuento";
            this.clmDescuento.ReadOnly = true;
            // 
            // clmSubtotal
            // 
            this.clmSubtotal.HeaderText = "Subtotal";
            this.clmSubtotal.MinimumWidth = 6;
            this.clmSubtotal.Name = "clmSubtotal";
            this.clmSubtotal.ReadOnly = true;
            // 
            // clmRetencion
            // 
            this.clmRetencion.HeaderText = "Retención";
            this.clmRetencion.MinimumWidth = 6;
            this.clmRetencion.Name = "clmRetencion";
            this.clmRetencion.ReadOnly = true;
            // 
            // clmTotal
            // 
            this.clmTotal.HeaderText = "Total";
            this.clmTotal.MinimumWidth = 6;
            this.clmTotal.Name = "clmTotal";
            this.clmTotal.ReadOnly = true;
            // 
            // btmIngresar
            // 
            this.btmIngresar.Location = new System.Drawing.Point(193, 516);
            this.btmIngresar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btmIngresar.Name = "btmIngresar";
            this.btmIngresar.Size = new System.Drawing.Size(100, 28);
            this.btmIngresar.TabIndex = 1;
            this.btmIngresar.Text = "Ingresar";
            this.btmIngresar.UseVisualStyleBackColor = true;
            this.btmIngresar.Click += new System.EventHandler(this.btmIngresar_Click);
            // 
            // btmCalcular
            // 
            this.btmCalcular.Location = new System.Drawing.Point(725, 516);
            this.btmCalcular.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btmCalcular.Name = "btmCalcular";
            this.btmCalcular.Size = new System.Drawing.Size(100, 28);
            this.btmCalcular.TabIndex = 2;
            this.btmCalcular.Text = "Calcular";
            this.btmCalcular.UseVisualStyleBackColor = true;
            this.btmCalcular.Click += new System.EventHandler(this.btmCalcular_Click);
            // 
            // btmSalir
            // 
            this.btmSalir.Location = new System.Drawing.Point(1296, 516);
            this.btmSalir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btmSalir.Name = "btmSalir";
            this.btmSalir.Size = new System.Drawing.Size(100, 28);
            this.btmSalir.TabIndex = 3;
            this.btmSalir.Text = "Salir";
            this.btmSalir.UseVisualStyleBackColor = true;
            this.btmSalir.Click += new System.EventHandler(this.btmSalir_Click);
            // 
            // frmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1508, 609);
            this.ControlBox = false;
            this.Controls.Add(this.btmSalir);
            this.Controls.Add(this.btmCalcular);
            this.Controls.Add(this.btmIngresar);
            this.Controls.Add(this.dgvFactura);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clientes";
            ((System.ComponentModel.ISupportInitialize)(this.dgvFactura)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFactura;
        private System.Windows.Forms.Button btmIngresar;
        private System.Windows.Forms.Button btmCalcular;
        private System.Windows.Forms.Button btmSalir;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmAntiguedad;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmValor;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDescuento;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSubtotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmRetencion;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTotal;
    }
}

