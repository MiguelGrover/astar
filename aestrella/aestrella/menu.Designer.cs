namespace aestrella
{
    partial class menu
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
            this.filas = new System.Windows.Forms.NumericUpDown();
            this.columnas = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pesocruz = new System.Windows.Forms.TextBox();
            this.pesodiag = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.aceptar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.filas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.columnas)).BeginInit();
            this.SuspendLayout();
            // 
            // filas
            // 
            this.filas.Location = new System.Drawing.Point(115, 30);
            this.filas.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.filas.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.filas.Name = "filas";
            this.filas.Size = new System.Drawing.Size(81, 22);
            this.filas.TabIndex = 0;
            this.filas.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // columnas
            // 
            this.columnas.Location = new System.Drawing.Point(115, 72);
            this.columnas.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.columnas.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.columnas.Name = "columnas";
            this.columnas.Size = new System.Drawing.Size(81, 22);
            this.columnas.TabIndex = 1;
            this.columnas.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Filas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Columnas";
            // 
            // pesocruz
            // 
            this.pesocruz.Location = new System.Drawing.Point(115, 114);
            this.pesocruz.Name = "pesocruz";
            this.pesocruz.Size = new System.Drawing.Size(81, 22);
            this.pesocruz.TabIndex = 4;
            this.pesocruz.Text = "1";
            // 
            // pesodiag
            // 
            this.pesodiag.Location = new System.Drawing.Point(115, 159);
            this.pesodiag.Name = "pesodiag";
            this.pesodiag.Size = new System.Drawing.Size(81, 22);
            this.pesodiag.TabIndex = 5;
            this.pesodiag.Text = "1.4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Peso cruz";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Peso diagonal";
            // 
            // aceptar
            // 
            this.aceptar.Location = new System.Drawing.Point(115, 198);
            this.aceptar.Name = "aceptar";
            this.aceptar.Size = new System.Drawing.Size(75, 23);
            this.aceptar.TabIndex = 8;
            this.aceptar.Text = "Aceptar";
            this.aceptar.UseVisualStyleBackColor = true;
            this.aceptar.Click += new System.EventHandler(this.aceptar_Click);
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(221, 253);
            this.Controls.Add(this.aceptar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pesodiag);
            this.Controls.Add(this.pesocruz);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.columnas);
            this.Controls.Add(this.filas);
            this.Name = "menu";
            this.Text = "Menu";
            ((System.ComponentModel.ISupportInitialize)(this.filas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.columnas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown filas;
        private System.Windows.Forms.NumericUpDown columnas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox pesocruz;
        private System.Windows.Forms.TextBox pesodiag;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button aceptar;
    }
}