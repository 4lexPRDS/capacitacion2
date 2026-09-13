namespace CapaVista_PaqueteCRUD.Formas
{
    partial class FrmPaquetes
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblEncabezado = new System.Windows.Forms.Label();
            this.panelDatos = new System.Windows.Forms.Panel();
            this.lblPedido = new System.Windows.Forms.Label();
            this.cajaPedido = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblPeso = new System.Windows.Forms.Label();
            this.inputPeso = new System.Windows.Forms.TextBox();
            this.lblAlto = new System.Windows.Forms.Label();
            this.txtAltoPaquete = new System.Windows.Forms.TextBox();
            this.lblAncho = new System.Windows.Forms.Label();
            this.txtAnchoPaquete = new System.Windows.Forms.TextBox();
            this.lblLargo = new System.Windows.Forms.Label();
            this.txtLargoPaquete = new System.Windows.Forms.TextBox();
            this.lblDescrip = new System.Windows.Forms.Label();
            this.txtDescrip = new System.Windows.Forms.TextBox();
            this.lblEsFragil = new System.Windows.Forms.Label();
            this.cboFragil = new System.Windows.Forms.ComboBox();
            this.lblValor = new System.Windows.Forms.Label();
            this.txtValorDeclarado = new System.Windows.Forms.TextBox();
            this.lblTipoPaquete = new System.Windows.Forms.Label();
            this.txtTipoPaq = new System.Windows.Forms.TextBox();
            this.lblEstadoPaq = new System.Windows.Forms.Label();
            this.txtEstadoPaq = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblBusqueda = new System.Windows.Forms.Label();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.lblBusquedaCombo = new System.Windows.Forms.Label();
            this.cmbBusquedaPaquete = new Capa_Vista_ComboI.ComboI();
            this.gridPaquetes = new System.Windows.Forms.DataGridView();
            this.panelDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPaquetes)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEncabezado
            // 
            this.lblEncabezado.AutoSize = true;
            this.lblEncabezado.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEncabezado.Location = new System.Drawing.Point(567, 21);
            this.lblEncabezado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEncabezado.Name = "lblEncabezado";
            this.lblEncabezado.Size = new System.Drawing.Size(196, 46);
            this.lblEncabezado.TabIndex = 0;
            this.lblEncabezado.Text = "Paquetes";
            // 
            // panelDatos
            // 
            this.panelDatos.Controls.Add(this.lblPedido);
            this.panelDatos.Controls.Add(this.cajaPedido);
            this.panelDatos.Controls.Add(this.lblCodigo);
            this.panelDatos.Controls.Add(this.lblBusqueda);
            this.panelDatos.Controls.Add(this.txtFiltro);
            this.panelDatos.Controls.Add(this.txtCodigo);
            this.panelDatos.Controls.Add(this.lblPeso);
            this.panelDatos.Controls.Add(this.inputPeso);
            this.panelDatos.Controls.Add(this.lblAlto);
            this.panelDatos.Controls.Add(this.txtAltoPaquete);
            this.panelDatos.Controls.Add(this.lblAncho);
            this.panelDatos.Controls.Add(this.txtAnchoPaquete);
            this.panelDatos.Controls.Add(this.lblLargo);
            this.panelDatos.Controls.Add(this.txtLargoPaquete);
            this.panelDatos.Controls.Add(this.lblDescrip);
            this.panelDatos.Controls.Add(this.txtDescrip);
            this.panelDatos.Controls.Add(this.lblEsFragil);
            this.panelDatos.Controls.Add(this.cboFragil);
            this.panelDatos.Controls.Add(this.lblValor);
            this.panelDatos.Controls.Add(this.txtValorDeclarado);
            this.panelDatos.Controls.Add(this.lblTipoPaquete);
            this.panelDatos.Controls.Add(this.txtTipoPaq);
            this.panelDatos.Controls.Add(this.lblEstadoPaq);
            this.panelDatos.Controls.Add(this.txtEstadoPaq);
            this.panelDatos.Controls.Add(this.btnGuardar);
            this.panelDatos.Location = new System.Drawing.Point(30, 85);
            this.panelDatos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelDatos.Name = "panelDatos";
            this.panelDatos.Size = new System.Drawing.Size(1350, 400);
            this.panelDatos.TabIndex = 1;
            // 
            // lblPedido
            // 
            this.lblPedido.AutoSize = true;
            this.lblPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPedido.Location = new System.Drawing.Point(15, 23);
            this.lblPedido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPedido.Name = "lblPedido";
            this.lblPedido.Size = new System.Drawing.Size(116, 25);
            this.lblPedido.TabIndex = 0;
            this.lblPedido.Text = "Id. Pedido:";
            // 
            // cajaPedido
            // 
            this.cajaPedido.Location = new System.Drawing.Point(210, 18);
            this.cajaPedido.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cajaPedido.Name = "cajaPedido";
            this.cajaPedido.Size = new System.Drawing.Size(238, 26);
            this.cajaPedido.TabIndex = 1;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(15, 85);
            this.lblCodigo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(191, 25);
            this.lblCodigo.TabIndex = 2;
            this.lblCodigo.Text = "Codigo de rastreo:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(210, 80);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(238, 26);
            this.txtCodigo.TabIndex = 3;
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeso.Location = new System.Drawing.Point(15, 146);
            this.lblPeso.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(113, 25);
            this.lblPeso.TabIndex = 4;
            this.lblPeso.Text = "Peso (kg):";
            // 
            // inputPeso
            // 
            this.inputPeso.Location = new System.Drawing.Point(210, 142);
            this.inputPeso.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.inputPeso.Name = "inputPeso";
            this.inputPeso.Size = new System.Drawing.Size(238, 26);
            this.inputPeso.TabIndex = 5;
            // 
            // lblAlto
            // 
            this.lblAlto.AutoSize = true;
            this.lblAlto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlto.Location = new System.Drawing.Point(15, 208);
            this.lblAlto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAlto.Name = "lblAlto";
            this.lblAlto.Size = new System.Drawing.Size(107, 25);
            this.lblAlto.TabIndex = 6;
            this.lblAlto.Text = "Alto (cm):";
            // 
            // txtAltoPaquete
            // 
            this.txtAltoPaquete.Location = new System.Drawing.Point(210, 203);
            this.txtAltoPaquete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAltoPaquete.Name = "txtAltoPaquete";
            this.txtAltoPaquete.Size = new System.Drawing.Size(238, 26);
            this.txtAltoPaquete.TabIndex = 7;
            // 
            // lblAncho
            // 
            this.lblAncho.AutoSize = true;
            this.lblAncho.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAncho.Location = new System.Drawing.Point(15, 269);
            this.lblAncho.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAncho.Name = "lblAncho";
            this.lblAncho.Size = new System.Drawing.Size(131, 25);
            this.lblAncho.TabIndex = 8;
            this.lblAncho.Text = "Ancho (cm):";
            // 
            // txtAnchoPaquete
            // 
            this.txtAnchoPaquete.Location = new System.Drawing.Point(210, 265);
            this.txtAnchoPaquete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAnchoPaquete.Name = "txtAnchoPaquete";
            this.txtAnchoPaquete.Size = new System.Drawing.Size(238, 26);
            this.txtAnchoPaquete.TabIndex = 9;
            // 
            // lblLargo
            // 
            this.lblLargo.AutoSize = true;
            this.lblLargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLargo.Location = new System.Drawing.Point(15, 331);
            this.lblLargo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLargo.Name = "lblLargo";
            this.lblLargo.Size = new System.Drawing.Size(124, 25);
            this.lblLargo.TabIndex = 10;
            this.lblLargo.Text = "Largo (cm):";
            // 
            // txtLargoPaquete
            // 
            this.txtLargoPaquete.Location = new System.Drawing.Point(210, 326);
            this.txtLargoPaquete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtLargoPaquete.Name = "txtLargoPaquete";
            this.txtLargoPaquete.Size = new System.Drawing.Size(238, 26);
            this.txtLargoPaquete.TabIndex = 11;
            // 
            // lblDescrip
            // 
            this.lblDescrip.AutoSize = true;
            this.lblDescrip.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescrip.Location = new System.Drawing.Point(510, 23);
            this.lblDescrip.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescrip.Name = "lblDescrip";
            this.lblDescrip.Size = new System.Drawing.Size(132, 25);
            this.lblDescrip.TabIndex = 12;
            this.lblDescrip.Text = "Descripcion:";
            // 
            // txtDescrip
            // 
            this.txtDescrip.Location = new System.Drawing.Point(705, 18);
            this.txtDescrip.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDescrip.Name = "txtDescrip";
            this.txtDescrip.Size = new System.Drawing.Size(253, 26);
            this.txtDescrip.TabIndex = 13;
            // 
            // lblEsFragil
            // 
            this.lblEsFragil.AutoSize = true;
            this.lblEsFragil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEsFragil.Location = new System.Drawing.Point(510, 85);
            this.lblEsFragil.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEsFragil.Name = "lblEsFragil";
            this.lblEsFragil.Size = new System.Drawing.Size(73, 25);
            this.lblEsFragil.TabIndex = 14;
            this.lblEsFragil.Text = "Fragil:";
            // 
            // cboFragil
            // 
            this.cboFragil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFragil.FormattingEnabled = true;
            this.cboFragil.Items.AddRange(new object[] {
            "SI",
            "NO"});
            this.cboFragil.Location = new System.Drawing.Point(705, 80);
            this.cboFragil.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboFragil.Name = "cboFragil";
            this.cboFragil.Size = new System.Drawing.Size(253, 28);
            this.cboFragil.TabIndex = 15;
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor.Location = new System.Drawing.Point(510, 146);
            this.lblValor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(171, 25);
            this.lblValor.TabIndex = 16;
            this.lblValor.Text = "Valor declarado:";
            // 
            // txtValorDeclarado
            // 
            this.txtValorDeclarado.Location = new System.Drawing.Point(705, 142);
            this.txtValorDeclarado.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtValorDeclarado.Name = "txtValorDeclarado";
            this.txtValorDeclarado.Size = new System.Drawing.Size(253, 26);
            this.txtValorDeclarado.TabIndex = 17;
            // 
            // lblTipoPaquete
            // 
            this.lblTipoPaquete.AutoSize = true;
            this.lblTipoPaquete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoPaquete.Location = new System.Drawing.Point(510, 208);
            this.lblTipoPaquete.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTipoPaquete.Name = "lblTipoPaquete";
            this.lblTipoPaquete.Size = new System.Drawing.Size(62, 25);
            this.lblTipoPaquete.TabIndex = 18;
            this.lblTipoPaquete.Text = "Tipo:";
            // 
            // txtTipoPaq
            // 
            this.txtTipoPaq.Location = new System.Drawing.Point(705, 203);
            this.txtTipoPaq.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTipoPaq.Name = "txtTipoPaq";
            this.txtTipoPaq.Size = new System.Drawing.Size(253, 26);
            this.txtTipoPaq.TabIndex = 19;
            // 
            // lblEstadoPaq
            // 
            this.lblEstadoPaq.AutoSize = true;
            this.lblEstadoPaq.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadoPaq.Location = new System.Drawing.Point(510, 269);
            this.lblEstadoPaq.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEstadoPaq.Name = "lblEstadoPaq";
            this.lblEstadoPaq.Size = new System.Drawing.Size(86, 25);
            this.lblEstadoPaq.TabIndex = 20;
            this.lblEstadoPaq.Text = "Estado:";
            // 
            // txtEstadoPaq
            // 
            this.txtEstadoPaq.Location = new System.Drawing.Point(705, 265);
            this.txtEstadoPaq.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEstadoPaq.Name = "txtEstadoPaq";
            this.txtEstadoPaq.Size = new System.Drawing.Size(253, 26);
            this.txtEstadoPaq.TabIndex = 21;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(1103, 203);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(180, 46);
            this.btnGuardar.TabIndex = 22;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(30, 500);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(120, 46);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Nuevo";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(165, 500);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(120, 46);
            this.btnModificar.TabIndex = 3;
            this.btnModificar.Text = "Editar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(300, 500);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(120, 46);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Text = "Borrar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // lblBusqueda
            // 
            this.lblBusqueda.AutoSize = true;
            this.lblBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBusqueda.Location = new System.Drawing.Point(1160, 81);
            this.lblBusqueda.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBusqueda.Name = "lblBusqueda";
            this.lblBusqueda.Size = new System.Drawing.Size(86, 25);
            this.lblBusqueda.TabIndex = 5;
            this.lblBusqueda.Text = "Buscar:";
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(1089, 106);
            this.txtFiltro.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(204, 26);
            this.txtFiltro.TabIndex = 6;
            this.txtFiltro.TextChanged += new System.EventHandler(this.txtFiltro_TextChanged);
            // 
            // lblBusquedaCombo
            // 
            this.lblBusquedaCombo.AutoSize = true;
            this.lblBusquedaCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBusquedaCombo.Location = new System.Drawing.Point(510, 505);
            this.lblBusquedaCombo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBusquedaCombo.Name = "lblBusquedaCombo";
            this.lblBusquedaCombo.Size = new System.Drawing.Size(309, 25);
            this.lblBusquedaCombo.TabIndex = 7;
            this.lblBusquedaCombo.Text = "Ir a paquete por codigo de rastreo:";
            // 
            // cmbBusquedaPaquete
            // 
            this.cmbBusquedaPaquete.Location = new System.Drawing.Point(827, 500);
            this.cmbBusquedaPaquete.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.cmbBusquedaPaquete.Name = "cmbBusquedaPaquete";
            this.cmbBusquedaPaquete.Size = new System.Drawing.Size(450, 37);
            this.cmbBusquedaPaquete.TabIndex = 8;
            // 
            // gridPaquetes
            // 
            this.gridPaquetes.AllowUserToAddRows = false;
            this.gridPaquetes.AllowUserToDeleteRows = false;
            this.gridPaquetes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPaquetes.Location = new System.Drawing.Point(30, 608);
            this.gridPaquetes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gridPaquetes.Name = "gridPaquetes";
            this.gridPaquetes.ReadOnly = true;
            this.gridPaquetes.RowHeadersWidth = 30;
            this.gridPaquetes.Size = new System.Drawing.Size(1350, 280);
            this.gridPaquetes.TabIndex = 9;
            // 
            // FrmPaquetes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OliveDrab;
            this.ClientSize = new System.Drawing.Size(1441, 937);
            this.Controls.Add(this.gridPaquetes);
            this.Controls.Add(this.cmbBusquedaPaquete);
            this.Controls.Add(this.lblBusquedaCombo);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.panelDatos);
            this.Controls.Add(this.lblEncabezado);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmPaquetes";
            this.Text = "FrmPaquetes - Mantenimiento de Paquetes";
            this.Load += new System.EventHandler(this.FrmPaquetes_Load);
            this.panelDatos.ResumeLayout(false);
            this.panelDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPaquetes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEncabezado;
        private System.Windows.Forms.Panel panelDatos;
        private System.Windows.Forms.Label lblPedido;
        private System.Windows.Forms.TextBox cajaPedido;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.TextBox inputPeso;
        private System.Windows.Forms.Label lblAlto;
        private System.Windows.Forms.TextBox txtAltoPaquete;
        private System.Windows.Forms.Label lblAncho;
        private System.Windows.Forms.TextBox txtAnchoPaquete;
        private System.Windows.Forms.Label lblLargo;
        private System.Windows.Forms.TextBox txtLargoPaquete;
        private System.Windows.Forms.Label lblDescrip;
        private System.Windows.Forms.TextBox txtDescrip;
        private System.Windows.Forms.Label lblEsFragil;
        private System.Windows.Forms.ComboBox cboFragil;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.TextBox txtValorDeclarado;
        private System.Windows.Forms.Label lblTipoPaquete;
        private System.Windows.Forms.TextBox txtTipoPaq;
        private System.Windows.Forms.Label lblEstadoPaq;
        private System.Windows.Forms.TextBox txtEstadoPaq;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblBusqueda;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.Label lblBusquedaCombo;
        private Capa_Vista_ComboI.ComboI cmbBusquedaPaquete;
        private System.Windows.Forms.DataGridView gridPaquetes;
    }
}
