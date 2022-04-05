namespace FormularioEncontrarNumero
{
    partial class Arreglos
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
            this.txtnumero = new System.Windows.Forms.TextBox();
            this.btnAgregarLista = new System.Windows.Forms.Button();
            this.lstLista = new System.Windows.Forms.ListView();
            this.lbloperacion = new System.Windows.Forms.Label();
            this.txtresultado = new System.Windows.Forms.TextBox();
            this.btnmostrar = new System.Windows.Forms.Button();
            this.lblNumMayor = new System.Windows.Forms.Label();
            this.lblNumMenor = new System.Windows.Forms.Label();
            this.txtMayorNumero = new System.Windows.Forms.TextBox();
            this.txtMenorNumero = new System.Windows.Forms.TextBox();
            this.btnMayorNumero = new System.Windows.Forms.Button();
            this.btnMenorNumero = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtnumero
            // 
            this.txtnumero.Location = new System.Drawing.Point(164, 33);
            this.txtnumero.Name = "txtnumero";
            this.txtnumero.Size = new System.Drawing.Size(100, 23);
            this.txtnumero.TabIndex = 0;
            // 
            // btnAgregarLista
            // 
            this.btnAgregarLista.Location = new System.Drawing.Point(284, 33);
            this.btnAgregarLista.Name = "btnAgregarLista";
            this.btnAgregarLista.Size = new System.Drawing.Size(118, 23);
            this.btnAgregarLista.TabIndex = 1;
            this.btnAgregarLista.Text = "Agregar a la Lista";
            this.btnAgregarLista.UseVisualStyleBackColor = true;
            this.btnAgregarLista.Click += new System.EventHandler(this.btnAgregarLista_Click);
            // 
            // lstLista
            // 
            this.lstLista.Location = new System.Drawing.Point(48, 68);
            this.lstLista.Name = "lstLista";
            this.lstLista.Size = new System.Drawing.Size(86, 228);
            this.lstLista.TabIndex = 2;
            this.lstLista.UseCompatibleStateImageBehavior = false;
            // 
            // lbloperacion
            // 
            this.lbloperacion.AutoSize = true;
            this.lbloperacion.Location = new System.Drawing.Point(141, 89);
            this.lbloperacion.Name = "lbloperacion";
            this.lbloperacion.Size = new System.Drawing.Size(137, 15);
            this.lbloperacion.TabIndex = 3;
            this.lbloperacion.Text = "Número mayor negativo";
            // 
            // txtresultado
            // 
            this.txtresultado.Location = new System.Drawing.Point(284, 86);
            this.txtresultado.Name = "txtresultado";
            this.txtresultado.ReadOnly = true;
            this.txtresultado.Size = new System.Drawing.Size(100, 23);
            this.txtresultado.TabIndex = 4;
            // 
            // btnmostrar
            // 
            this.btnmostrar.Location = new System.Drawing.Point(401, 85);
            this.btnmostrar.Name = "btnmostrar";
            this.btnmostrar.Size = new System.Drawing.Size(96, 23);
            this.btnmostrar.TabIndex = 5;
            this.btnmostrar.Text = "Mostrar dato";
            this.btnmostrar.UseVisualStyleBackColor = true;
            this.btnmostrar.Click += new System.EventHandler(this.btnmostrar_Click);
            // 
            // lblNumMayor
            // 
            this.lblNumMayor.AutoSize = true;
            this.lblNumMayor.Location = new System.Drawing.Point(164, 140);
            this.lblNumMayor.Name = "lblNumMayor";
            this.lblNumMayor.Size = new System.Drawing.Size(88, 15);
            this.lblNumMayor.TabIndex = 6;
            this.lblNumMayor.Text = "Numero Mayor";
            // 
            // lblNumMenor
            // 
            this.lblNumMenor.AutoSize = true;
            this.lblNumMenor.Location = new System.Drawing.Point(164, 184);
            this.lblNumMenor.Name = "lblNumMenor";
            this.lblNumMenor.Size = new System.Drawing.Size(89, 15);
            this.lblNumMenor.TabIndex = 7;
            this.lblNumMenor.Text = "Numero Menor";
            // 
            // txtMayorNumero
            // 
            this.txtMayorNumero.Location = new System.Drawing.Point(284, 137);
            this.txtMayorNumero.Name = "txtMayorNumero";
            this.txtMayorNumero.ReadOnly = true;
            this.txtMayorNumero.Size = new System.Drawing.Size(100, 23);
            this.txtMayorNumero.TabIndex = 8;
            // 
            // txtMenorNumero
            // 
            this.txtMenorNumero.Location = new System.Drawing.Point(284, 181);
            this.txtMenorNumero.Name = "txtMenorNumero";
            this.txtMenorNumero.ReadOnly = true;
            this.txtMenorNumero.Size = new System.Drawing.Size(100, 23);
            this.txtMenorNumero.TabIndex = 9;
            // 
            // btnMayorNumero
            // 
            this.btnMayorNumero.Location = new System.Drawing.Point(401, 138);
            this.btnMayorNumero.Name = "btnMayorNumero";
            this.btnMayorNumero.Size = new System.Drawing.Size(90, 23);
            this.btnMayorNumero.TabIndex = 10;
            this.btnMayorNumero.Text = "Mostrar dato";
            this.btnMayorNumero.UseVisualStyleBackColor = true;
            this.btnMayorNumero.Click += new System.EventHandler(this.btnMayorNumero_Click);
            // 
            // btnMenorNumero
            // 
            this.btnMenorNumero.Location = new System.Drawing.Point(401, 180);
            this.btnMenorNumero.Name = "btnMenorNumero";
            this.btnMenorNumero.Size = new System.Drawing.Size(90, 23);
            this.btnMenorNumero.TabIndex = 11;
            this.btnMenorNumero.Text = "Mostrar dato";
            this.btnMenorNumero.UseVisualStyleBackColor = true;
            this.btnMenorNumero.Click += new System.EventHandler(this.btnMenorNumero_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnSalir.Location = new System.Drawing.Point(259, 238);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 12;
            this.btnSalir.Text = "CERRAR";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Arreglos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(534, 380);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnMenorNumero);
            this.Controls.Add(this.btnMayorNumero);
            this.Controls.Add(this.txtMenorNumero);
            this.Controls.Add(this.txtMayorNumero);
            this.Controls.Add(this.lblNumMenor);
            this.Controls.Add(this.lblNumMayor);
            this.Controls.Add(this.btnmostrar);
            this.Controls.Add(this.txtresultado);
            this.Controls.Add(this.lbloperacion);
            this.Controls.Add(this.lstLista);
            this.Controls.Add(this.btnAgregarLista);
            this.Controls.Add(this.txtnumero);
            this.Name = "Arreglos";
            this.Text = "Ejemplo con arreglos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtnumero;
        private Button btnAgregarLista;
        private ListView lstLista;
        private Label lbloperacion;
        private TextBox txtresultado;
        private Button btnmostrar;
        private Label lblNumMayor;
        private Label lblNumMenor;
        private TextBox txtMayorNumero;
        private TextBox txtMenorNumero;
        private Button btnMayorNumero;
        private Button btnMenorNumero;
        private Button btnSalir;
    }
}