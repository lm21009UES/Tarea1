namespace WinFormsApp2
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
            this.btncalcular = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.txtn1 = new System.Windows.Forms.TextBox();
            this.lblalerta = new System.Windows.Forms.Label();
            this.LBLN2 = new System.Windows.Forms.Label();
            this.LBLN1 = new System.Windows.Forms.Label();
            this.txtn2 = new System.Windows.Forms.TextBox();
            this.CMBOP = new System.Windows.Forms.ComboBox();
            this.LISTADVANCE = new System.Windows.Forms.ListBox();
            this.RBTN1 = new System.Windows.Forms.RadioButton();
            this.RBTN2 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // btncalcular
            // 
            this.btncalcular.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btncalcular.Location = new System.Drawing.Point(214, 146);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(96, 33);
            this.btncalcular.TabIndex = 0;
            this.btncalcular.Text = "CALCULAR";
            this.btncalcular.UseVisualStyleBackColor = false;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnSalir.Location = new System.Drawing.Point(346, 146);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(96, 33);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // txtn1
            // 
            this.txtn1.Location = new System.Drawing.Point(227, 57);
            this.txtn1.Name = "txtn1";
            this.txtn1.Size = new System.Drawing.Size(226, 23);
            this.txtn1.TabIndex = 3;
            // 
            // lblalerta
            // 
            this.lblalerta.AutoSize = true;
            this.lblalerta.Location = new System.Drawing.Point(108, 187);
            this.lblalerta.Name = "lblalerta";
            this.lblalerta.Size = new System.Drawing.Size(0, 15);
            this.lblalerta.TabIndex = 4;
            // 
            // LBLN2
            // 
            this.LBLN2.AutoSize = true;
            this.LBLN2.Location = new System.Drawing.Point(162, 112);
            this.LBLN2.Name = "LBLN2";
            this.LBLN2.Size = new System.Drawing.Size(22, 15);
            this.LBLN2.TabIndex = 5;
            this.LBLN2.Text = "N2";
            // 
            // LBLN1
            // 
            this.LBLN1.AutoSize = true;
            this.LBLN1.Location = new System.Drawing.Point(161, 61);
            this.LBLN1.Name = "LBLN1";
            this.LBLN1.Size = new System.Drawing.Size(22, 15);
            this.LBLN1.TabIndex = 6;
            this.LBLN1.Text = "N1";
            // 
            // txtn2
            // 
            this.txtn2.Location = new System.Drawing.Point(227, 107);
            this.txtn2.Name = "txtn2";
            this.txtn2.Size = new System.Drawing.Size(226, 23);
            this.txtn2.TabIndex = 7;
            // 
            // CMBOP
            // 
            this.CMBOP.FormattingEnabled = true;
            this.CMBOP.Location = new System.Drawing.Point(505, 62);
            this.CMBOP.Name = "CMBOP";
            this.CMBOP.Size = new System.Drawing.Size(121, 23);
            this.CMBOP.TabIndex = 8;
            // 
            // LISTADVANCE
            // 
            this.LISTADVANCE.FormattingEnabled = true;
            this.LISTADVANCE.ItemHeight = 15;
            this.LISTADVANCE.Location = new System.Drawing.Point(508, 133);
            this.LISTADVANCE.Name = "LISTADVANCE";
            this.LISTADVANCE.Size = new System.Drawing.Size(120, 94);
            this.LISTADVANCE.TabIndex = 9;
            // 
            // RBTN1
            // 
            this.RBTN1.AutoSize = true;
            this.RBTN1.Location = new System.Drawing.Point(348, 22);
            this.RBTN1.Name = "RBTN1";
            this.RBTN1.Size = new System.Drawing.Size(63, 19);
            this.RBTN1.TabIndex = 10;
            this.RBTN1.TabStop = true;
            this.RBTN1.Text = "Basicas";
            this.RBTN1.UseVisualStyleBackColor = true;
            this.RBTN1.CheckedChanged += new System.EventHandler(this.RBTN1_CheckedChanged);
            // 
            // RBTN2
            // 
            this.RBTN2.AutoSize = true;
            this.RBTN2.Location = new System.Drawing.Point(505, 22);
            this.RBTN2.Name = "RBTN2";
            this.RBTN2.Size = new System.Drawing.Size(81, 19);
            this.RBTN2.TabIndex = 11;
            this.RBTN2.TabStop = true;
            this.RBTN2.Text = "Avanzadas";
            this.RBTN2.UseVisualStyleBackColor = true;
            this.RBTN2.CheckedChanged += new System.EventHandler(this.RBTN2_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RBTN2);
            this.Controls.Add(this.RBTN1);
            this.Controls.Add(this.LISTADVANCE);
            this.Controls.Add(this.CMBOP);
            this.Controls.Add(this.txtn2);
            this.Controls.Add(this.LBLN1);
            this.Controls.Add(this.LBLN2);
            this.Controls.Add(this.lblalerta);
            this.Controls.Add(this.txtn1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btncalcular);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btncalcular;
        private Button btnSalir;
        private TextBox txtn1;
        private Label lblalerta;
        private Label LBLN2;
        private Label LBLN1;
        private TextBox txtn2;
        private ComboBox CMBOP;
        private ListBox LISTADVANCE;
        private RadioButton RBTN1;
        private RadioButton RBTN2;
    }
}