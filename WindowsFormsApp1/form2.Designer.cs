namespace WindowsFormsApp1
{
    partial class Form2
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
            this.cmbDestinos = new System.Windows.Forms.ComboBox();
            this.lblDestino = new System.Windows.Forms.Label();
            this.lblmaleta = new System.Windows.Forms.Label();
            this.rbtNo = new System.Windows.Forms.RadioButton();
            this.rbtSi = new System.Windows.Forms.RadioButton();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.btnComprar = new System.Windows.Forms.Button();
            this.lstLugares = new System.Windows.Forms.ListView();
            this.opciones = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Precio = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Horario = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoletos = new System.Windows.Forms.TextBox();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbDestinos
            // 
            this.cmbDestinos.FormattingEnabled = true;
            this.cmbDestinos.Location = new System.Drawing.Point(163, 202);
            this.cmbDestinos.Name = "cmbDestinos";
            this.cmbDestinos.Size = new System.Drawing.Size(121, 21);
            this.cmbDestinos.TabIndex = 0;
            // 
            // lblDestino
            // 
            this.lblDestino.AutoSize = true;
            this.lblDestino.Location = new System.Drawing.Point(74, 210);
            this.lblDestino.Name = "lblDestino";
            this.lblDestino.Size = new System.Drawing.Size(51, 13);
            this.lblDestino.TabIndex = 1;
            this.lblDestino.Text = "Provincia";
            // 
            // lblmaleta
            // 
            this.lblmaleta.AutoSize = true;
            this.lblmaleta.Location = new System.Drawing.Point(362, 202);
            this.lblmaleta.Name = "lblmaleta";
            this.lblmaleta.Size = new System.Drawing.Size(44, 13);
            this.lblmaleta.TabIndex = 2;
            this.lblmaleta.Text = "Maletas";
            // 
            // rbtNo
            // 
            this.rbtNo.AutoSize = true;
            this.rbtNo.Location = new System.Drawing.Point(521, 198);
            this.rbtNo.Name = "rbtNo";
            this.rbtNo.Size = new System.Drawing.Size(39, 17);
            this.rbtNo.TabIndex = 4;
            this.rbtNo.TabStop = true;
            this.rbtNo.Text = "No";
            this.rbtNo.UseVisualStyleBackColor = true;
            // 
            // rbtSi
            // 
            this.rbtSi.AutoSize = true;
            this.rbtSi.Location = new System.Drawing.Point(462, 198);
            this.rbtSi.Name = "rbtSi";
            this.rbtSi.Size = new System.Drawing.Size(34, 17);
            this.rbtSi.TabIndex = 5;
            this.rbtSi.TabStop = true;
            this.rbtSi.Text = "Si";
            this.rbtSi.UseVisualStyleBackColor = true;
            this.rbtSi.CheckedChanged += new System.EventHandler(this.rbtSi_CheckedChanged);
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(353, 235);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(101, 13);
            this.lblCantidad.TabIndex = 6;
            this.lblCantidad.Text = "Numero De Maletas";
            this.lblCantidad.Visible = false;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(460, 235);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(100, 20);
            this.txtCantidad.TabIndex = 7;
            this.txtCantidad.Visible = false;
            // 
            // btnComprar
            // 
            this.btnComprar.Location = new System.Drawing.Point(348, 269);
            this.btnComprar.Name = "btnComprar";
            this.btnComprar.Size = new System.Drawing.Size(75, 23);
            this.btnComprar.TabIndex = 9;
            this.btnComprar.Text = "Comprar";
            this.btnComprar.UseVisualStyleBackColor = true;
            this.btnComprar.Click += new System.EventHandler(this.btnComprar_Click);
            // 
            // lstLugares
            // 
            this.lstLugares.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.opciones,
            this.Precio,
            this.Horario});
            this.lstLugares.HideSelection = false;
            this.lstLugares.Location = new System.Drawing.Point(186, 12);
            this.lstLugares.Name = "lstLugares";
            this.lstLugares.Size = new System.Drawing.Size(386, 155);
            this.lstLugares.TabIndex = 11;
            this.lstLugares.UseCompatibleStateImageBehavior = false;
            this.lstLugares.View = System.Windows.Forms.View.Details;
            // 
            // opciones
            // 
            this.opciones.Text = "Provincias";
            this.opciones.Width = 150;
            // 
            // Precio
            // 
            this.Precio.Text = "Precio $";
            this.Precio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Precio.Width = 120;
            // 
            // Horario
            // 
            this.Horario.Text = "Horarios de salida";
            this.Horario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Horario.Width = 110;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 238);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Nº Boletos";
            // 
            // txtBoletos
            // 
            this.txtBoletos.Location = new System.Drawing.Point(163, 232);
            this.txtBoletos.Name = "txtBoletos";
            this.txtBoletos.Size = new System.Drawing.Size(100, 20);
            this.txtBoletos.TabIndex = 13;
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.ForeColor = System.Drawing.Color.Red;
            this.lblMensaje.Location = new System.Drawing.Point(269, 235);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(97, 13);
            this.lblMensaje.TabIndex = 14;
            this.lblMensaje.Text = "*Campo Obligatorio";
            this.lblMensaje.Visible = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 472);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.txtBoletos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstLugares);
            this.Controls.Add(this.btnComprar);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.rbtSi);
            this.Controls.Add(this.rbtNo);
            this.Controls.Add(this.lblmaleta);
            this.Controls.Add(this.lblDestino);
            this.Controls.Add(this.cmbDestinos);
            this.Name = "Form2";
            this.Text = "euaf";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbDestinos;
        private System.Windows.Forms.Label lblDestino;
        private System.Windows.Forms.Label lblmaleta;
        private System.Windows.Forms.RadioButton rbtNo;
        private System.Windows.Forms.RadioButton rbtSi;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Button btnComprar;
        private System.Windows.Forms.ListView lstLugares;
        private System.Windows.Forms.ColumnHeader opciones;
        private System.Windows.Forms.ColumnHeader Precio;
        private System.Windows.Forms.ColumnHeader Horario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoletos;
        private System.Windows.Forms.Label lblMensaje;
    }
}

