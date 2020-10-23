namespace parcial2lab2_GeronimoSchmidt_TomasCannatella
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitulo = new System.Windows.Forms.Label();
            this.groupBoxTipoPrenda = new System.Windows.Forms.GroupBox();
            this.groupBoxCalidadPrenda = new System.Windows.Forms.GroupBox();
            this.groupBoxPrecio = new System.Windows.Forms.GroupBox();
            this.groupBoxCantidad = new System.Windows.Forms.GroupBox();
            this.rbtnCamisa = new System.Windows.Forms.RadioButton();
            this.rbtnPantalon = new System.Windows.Forms.RadioButton();
            this.checkBoxMangaCorta = new System.Windows.Forms.CheckBox();
            this.checkBoxBermuda = new System.Windows.Forms.CheckBox();
            this.rbtnStandard = new System.Windows.Forms.RadioButton();
            this.rbtnPremium = new System.Windows.Forms.RadioButton();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.btnCalcularPrecioFInal = new System.Windows.Forms.Button();
            this.groupBoxTipoPrenda.SuspendLayout();
            this.groupBoxCalidadPrenda.SuspendLayout();
            this.groupBoxPrecio.SuspendLayout();
            this.groupBoxCantidad.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.Green;
            this.lblTitulo.Location = new System.Drawing.Point(23, 23);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(241, 16);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "VETNAS AL POR MAYOR-PradBit";
            // 
            // groupBoxTipoPrenda
            // 
            this.groupBoxTipoPrenda.Controls.Add(this.checkBoxBermuda);
            this.groupBoxTipoPrenda.Controls.Add(this.checkBoxMangaCorta);
            this.groupBoxTipoPrenda.Controls.Add(this.rbtnPantalon);
            this.groupBoxTipoPrenda.Controls.Add(this.rbtnCamisa);
            this.groupBoxTipoPrenda.Location = new System.Drawing.Point(34, 62);
            this.groupBoxTipoPrenda.Name = "groupBoxTipoPrenda";
            this.groupBoxTipoPrenda.Size = new System.Drawing.Size(200, 82);
            this.groupBoxTipoPrenda.TabIndex = 1;
            this.groupBoxTipoPrenda.TabStop = false;
            this.groupBoxTipoPrenda.Text = "Tipo de Prenda";
            // 
            // groupBoxCalidadPrenda
            // 
            this.groupBoxCalidadPrenda.Controls.Add(this.rbtnStandard);
            this.groupBoxCalidadPrenda.Controls.Add(this.rbtnPremium);
            this.groupBoxCalidadPrenda.Location = new System.Drawing.Point(34, 161);
            this.groupBoxCalidadPrenda.Name = "groupBoxCalidadPrenda";
            this.groupBoxCalidadPrenda.Size = new System.Drawing.Size(200, 57);
            this.groupBoxCalidadPrenda.TabIndex = 2;
            this.groupBoxCalidadPrenda.TabStop = false;
            this.groupBoxCalidadPrenda.Text = "Calidad de prenda";
            // 
            // groupBoxPrecio
            // 
            this.groupBoxPrecio.Controls.Add(this.txtPrecio);
            this.groupBoxPrecio.Location = new System.Drawing.Point(34, 229);
            this.groupBoxPrecio.Name = "groupBoxPrecio";
            this.groupBoxPrecio.Size = new System.Drawing.Size(89, 49);
            this.groupBoxPrecio.TabIndex = 2;
            this.groupBoxPrecio.TabStop = false;
            this.groupBoxPrecio.Text = "Precio";
            // 
            // groupBoxCantidad
            // 
            this.groupBoxCantidad.Controls.Add(this.txtCantidad);
            this.groupBoxCantidad.Location = new System.Drawing.Point(150, 229);
            this.groupBoxCantidad.Name = "groupBoxCantidad";
            this.groupBoxCantidad.Size = new System.Drawing.Size(84, 49);
            this.groupBoxCantidad.TabIndex = 2;
            this.groupBoxCantidad.TabStop = false;
            this.groupBoxCantidad.Text = "Cantidad";
            // 
            // rbtnCamisa
            // 
            this.rbtnCamisa.AutoSize = true;
            this.rbtnCamisa.Location = new System.Drawing.Point(6, 19);
            this.rbtnCamisa.Name = "rbtnCamisa";
            this.rbtnCamisa.Size = new System.Drawing.Size(59, 17);
            this.rbtnCamisa.TabIndex = 0;
            this.rbtnCamisa.TabStop = true;
            this.rbtnCamisa.Text = "Camisa";
            this.rbtnCamisa.UseVisualStyleBackColor = true;
            this.rbtnCamisa.CheckedChanged += new System.EventHandler(this.rbtnCamisa_CheckedChanged);
            // 
            // rbtnPantalon
            // 
            this.rbtnPantalon.AutoSize = true;
            this.rbtnPantalon.Location = new System.Drawing.Point(6, 56);
            this.rbtnPantalon.Name = "rbtnPantalon";
            this.rbtnPantalon.Size = new System.Drawing.Size(67, 17);
            this.rbtnPantalon.TabIndex = 1;
            this.rbtnPantalon.TabStop = true;
            this.rbtnPantalon.Text = "Pantalon";
            this.rbtnPantalon.UseVisualStyleBackColor = true;
            this.rbtnPantalon.CheckedChanged += new System.EventHandler(this.rbtnPantalon_CheckedChanged);
            // 
            // checkBoxMangaCorta
            // 
            this.checkBoxMangaCorta.AutoSize = true;
            this.checkBoxMangaCorta.Location = new System.Drawing.Point(93, 20);
            this.checkBoxMangaCorta.Name = "checkBoxMangaCorta";
            this.checkBoxMangaCorta.Size = new System.Drawing.Size(87, 17);
            this.checkBoxMangaCorta.TabIndex = 2;
            this.checkBoxMangaCorta.Text = "Manga Corta";
            this.checkBoxMangaCorta.UseVisualStyleBackColor = true;
            // 
            // checkBoxBermuda
            // 
            this.checkBoxBermuda.AutoSize = true;
            this.checkBoxBermuda.Location = new System.Drawing.Point(93, 57);
            this.checkBoxBermuda.Name = "checkBoxBermuda";
            this.checkBoxBermuda.Size = new System.Drawing.Size(68, 17);
            this.checkBoxBermuda.TabIndex = 3;
            this.checkBoxBermuda.Text = "Bermuda";
            this.checkBoxBermuda.UseVisualStyleBackColor = true;
            // 
            // rbtnStandard
            // 
            this.rbtnStandard.AutoSize = true;
            this.rbtnStandard.Location = new System.Drawing.Point(21, 19);
            this.rbtnStandard.Name = "rbtnStandard";
            this.rbtnStandard.Size = new System.Drawing.Size(68, 17);
            this.rbtnStandard.TabIndex = 4;
            this.rbtnStandard.TabStop = true;
            this.rbtnStandard.Text = "Standard";
            this.rbtnStandard.UseVisualStyleBackColor = true;
            // 
            // rbtnPremium
            // 
            this.rbtnPremium.AutoSize = true;
            this.rbtnPremium.Location = new System.Drawing.Point(106, 19);
            this.rbtnPremium.Name = "rbtnPremium";
            this.rbtnPremium.Size = new System.Drawing.Size(65, 17);
            this.rbtnPremium.TabIndex = 5;
            this.rbtnPremium.TabStop = true;
            this.rbtnPremium.Text = "Premium";
            this.rbtnPremium.UseVisualStyleBackColor = true;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(6, 19);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(77, 20);
            this.txtPrecio.TabIndex = 0;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(5, 19);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(70, 20);
            this.txtCantidad.TabIndex = 1;
            // 
            // btnCalcularPrecioFInal
            // 
            this.btnCalcularPrecioFInal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnCalcularPrecioFInal.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCalcularPrecioFInal.Location = new System.Drawing.Point(34, 284);
            this.btnCalcularPrecioFInal.Name = "btnCalcularPrecioFInal";
            this.btnCalcularPrecioFInal.Size = new System.Drawing.Size(200, 49);
            this.btnCalcularPrecioFInal.TabIndex = 3;
            this.btnCalcularPrecioFInal.Text = "Calcular Precio Final";
            this.btnCalcularPrecioFInal.UseVisualStyleBackColor = false;
            this.btnCalcularPrecioFInal.Click += new System.EventHandler(this.btnCalcularPrecioFInal_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 345);
            this.Controls.Add(this.btnCalcularPrecioFInal);
            this.Controls.Add(this.groupBoxCalidadPrenda);
            this.Controls.Add(this.groupBoxPrecio);
            this.Controls.Add(this.groupBoxCantidad);
            this.Controls.Add(this.groupBoxTipoPrenda);
            this.Controls.Add(this.lblTitulo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxTipoPrenda.ResumeLayout(false);
            this.groupBoxTipoPrenda.PerformLayout();
            this.groupBoxCalidadPrenda.ResumeLayout(false);
            this.groupBoxCalidadPrenda.PerformLayout();
            this.groupBoxPrecio.ResumeLayout(false);
            this.groupBoxPrecio.PerformLayout();
            this.groupBoxCantidad.ResumeLayout(false);
            this.groupBoxCantidad.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox groupBoxTipoPrenda;
        private System.Windows.Forms.CheckBox checkBoxBermuda;
        private System.Windows.Forms.CheckBox checkBoxMangaCorta;
        private System.Windows.Forms.RadioButton rbtnPantalon;
        private System.Windows.Forms.RadioButton rbtnCamisa;
        private System.Windows.Forms.GroupBox groupBoxCalidadPrenda;
        private System.Windows.Forms.RadioButton rbtnStandard;
        private System.Windows.Forms.RadioButton rbtnPremium;
        private System.Windows.Forms.GroupBox groupBoxPrecio;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.GroupBox groupBoxCantidad;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Button btnCalcularPrecioFInal;
    }
}

