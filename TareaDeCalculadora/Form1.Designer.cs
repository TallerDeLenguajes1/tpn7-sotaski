namespace TareaDeCalculadora
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
            this.tbCampoText = new System.Windows.Forms.TextBox();
            this.bt7 = new System.Windows.Forms.Button();
            this.bt8 = new System.Windows.Forms.Button();
            this.bt9 = new System.Windows.Forms.Button();
            this.btSuma = new System.Windows.Forms.Button();
            this.bt4 = new System.Windows.Forms.Button();
            this.bt5 = new System.Windows.Forms.Button();
            this.bt6 = new System.Windows.Forms.Button();
            this.btResta = new System.Windows.Forms.Button();
            this.bt1 = new System.Windows.Forms.Button();
            this.bt2 = new System.Windows.Forms.Button();
            this.bt3 = new System.Windows.Forms.Button();
            this.btMultiplicacion = new System.Windows.Forms.Button();
            this.bt0 = new System.Windows.Forms.Button();
            this.btPuntp = new System.Windows.Forms.Button();
            this.btIgual = new System.Windows.Forms.Button();
            this.btDivicion = new System.Windows.Forms.Button();
            this.btC = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbCampoText
            // 
            this.tbCampoText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCampoText.Location = new System.Drawing.Point(28, 25);
            this.tbCampoText.Name = "tbCampoText";
            this.tbCampoText.Size = new System.Drawing.Size(278, 30);
            this.tbCampoText.TabIndex = 0;
            this.tbCampoText.TextChanged += new System.EventHandler(this.TbCampoText_TextChanged);
            // 
            // bt7
            // 
            this.bt7.Location = new System.Drawing.Point(28, 67);
            this.bt7.Name = "bt7";
            this.bt7.Size = new System.Drawing.Size(75, 61);
            this.bt7.TabIndex = 1;
            this.bt7.Text = "7";
            this.bt7.UseVisualStyleBackColor = true;
            this.bt7.Click += new System.EventHandler(this.Bt7_Click);
            // 
            // bt8
            // 
            this.bt8.Location = new System.Drawing.Point(131, 67);
            this.bt8.Name = "bt8";
            this.bt8.Size = new System.Drawing.Size(75, 61);
            this.bt8.TabIndex = 2;
            this.bt8.Text = "8";
            this.bt8.UseVisualStyleBackColor = true;
            this.bt8.Click += new System.EventHandler(this.Bt8_Click);
            // 
            // bt9
            // 
            this.bt9.Location = new System.Drawing.Point(231, 67);
            this.bt9.Name = "bt9";
            this.bt9.Size = new System.Drawing.Size(75, 61);
            this.bt9.TabIndex = 3;
            this.bt9.Text = "9";
            this.bt9.UseVisualStyleBackColor = true;
            this.bt9.Click += new System.EventHandler(this.Bt9_Click);
            // 
            // btSuma
            // 
            this.btSuma.Location = new System.Drawing.Point(330, 67);
            this.btSuma.Name = "btSuma";
            this.btSuma.Size = new System.Drawing.Size(75, 61);
            this.btSuma.TabIndex = 4;
            this.btSuma.Text = "+";
            this.btSuma.UseVisualStyleBackColor = true;
            this.btSuma.Click += new System.EventHandler(this.BtSuma_Click);
            // 
            // bt4
            // 
            this.bt4.Location = new System.Drawing.Point(28, 143);
            this.bt4.Name = "bt4";
            this.bt4.Size = new System.Drawing.Size(75, 60);
            this.bt4.TabIndex = 5;
            this.bt4.Text = "4";
            this.bt4.UseVisualStyleBackColor = true;
            this.bt4.Click += new System.EventHandler(this.Bt4_Click);
            // 
            // bt5
            // 
            this.bt5.Location = new System.Drawing.Point(131, 143);
            this.bt5.Name = "bt5";
            this.bt5.Size = new System.Drawing.Size(75, 60);
            this.bt5.TabIndex = 6;
            this.bt5.Text = "5";
            this.bt5.UseVisualStyleBackColor = true;
            this.bt5.Click += new System.EventHandler(this.Bt5_Click);
            // 
            // bt6
            // 
            this.bt6.Location = new System.Drawing.Point(231, 143);
            this.bt6.Name = "bt6";
            this.bt6.Size = new System.Drawing.Size(75, 60);
            this.bt6.TabIndex = 7;
            this.bt6.Text = "6";
            this.bt6.UseVisualStyleBackColor = true;
            this.bt6.Click += new System.EventHandler(this.Bt6_Click);
            // 
            // btResta
            // 
            this.btResta.Location = new System.Drawing.Point(330, 143);
            this.btResta.Name = "btResta";
            this.btResta.Size = new System.Drawing.Size(75, 60);
            this.btResta.TabIndex = 8;
            this.btResta.Text = "-";
            this.btResta.UseVisualStyleBackColor = true;
            this.btResta.Click += new System.EventHandler(this.BtResta_Click);
            // 
            // bt1
            // 
            this.bt1.Location = new System.Drawing.Point(28, 222);
            this.bt1.Name = "bt1";
            this.bt1.Size = new System.Drawing.Size(75, 60);
            this.bt1.TabIndex = 9;
            this.bt1.Text = "1";
            this.bt1.UseVisualStyleBackColor = true;
            this.bt1.Click += new System.EventHandler(this.Bt1_Click);
            // 
            // bt2
            // 
            this.bt2.Location = new System.Drawing.Point(131, 222);
            this.bt2.Name = "bt2";
            this.bt2.Size = new System.Drawing.Size(75, 60);
            this.bt2.TabIndex = 10;
            this.bt2.Text = "2";
            this.bt2.UseVisualStyleBackColor = true;
            this.bt2.Click += new System.EventHandler(this.Bt2_Click);
            // 
            // bt3
            // 
            this.bt3.Location = new System.Drawing.Point(231, 222);
            this.bt3.Name = "bt3";
            this.bt3.Size = new System.Drawing.Size(75, 60);
            this.bt3.TabIndex = 11;
            this.bt3.Text = "3";
            this.bt3.UseVisualStyleBackColor = true;
            this.bt3.Click += new System.EventHandler(this.Bt3_Click);
            // 
            // btMultiplicacion
            // 
            this.btMultiplicacion.Location = new System.Drawing.Point(330, 222);
            this.btMultiplicacion.Name = "btMultiplicacion";
            this.btMultiplicacion.Size = new System.Drawing.Size(75, 60);
            this.btMultiplicacion.TabIndex = 12;
            this.btMultiplicacion.Text = "*";
            this.btMultiplicacion.UseVisualStyleBackColor = true;
            this.btMultiplicacion.Click += new System.EventHandler(this.BtMultiplicacion_Click);
            // 
            // bt0
            // 
            this.bt0.Location = new System.Drawing.Point(28, 301);
            this.bt0.Name = "bt0";
            this.bt0.Size = new System.Drawing.Size(75, 60);
            this.bt0.TabIndex = 13;
            this.bt0.Text = "0";
            this.bt0.UseVisualStyleBackColor = true;
            this.bt0.Click += new System.EventHandler(this.Bt0_Click);
            // 
            // btPuntp
            // 
            this.btPuntp.Location = new System.Drawing.Point(131, 301);
            this.btPuntp.Name = "btPuntp";
            this.btPuntp.Size = new System.Drawing.Size(75, 60);
            this.btPuntp.TabIndex = 14;
            this.btPuntp.Text = ".";
            this.btPuntp.UseVisualStyleBackColor = true;
            this.btPuntp.Click += new System.EventHandler(this.BtPuntp_Click);
            // 
            // btIgual
            // 
            this.btIgual.Location = new System.Drawing.Point(231, 301);
            this.btIgual.Name = "btIgual";
            this.btIgual.Size = new System.Drawing.Size(75, 60);
            this.btIgual.TabIndex = 15;
            this.btIgual.Text = "=";
            this.btIgual.UseVisualStyleBackColor = true;
            this.btIgual.Click += new System.EventHandler(this.BtIgual_Click);
            // 
            // btDivicion
            // 
            this.btDivicion.Location = new System.Drawing.Point(330, 301);
            this.btDivicion.Name = "btDivicion";
            this.btDivicion.Size = new System.Drawing.Size(75, 60);
            this.btDivicion.TabIndex = 16;
            this.btDivicion.Text = "/";
            this.btDivicion.UseVisualStyleBackColor = true;
            this.btDivicion.Click += new System.EventHandler(this.BtDivicion_Click);
            // 
            // btC
            // 
            this.btC.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btC.Location = new System.Drawing.Point(330, 25);
            this.btC.Name = "btC";
            this.btC.Size = new System.Drawing.Size(75, 30);
            this.btC.TabIndex = 17;
            this.btC.Text = "C";
            this.btC.UseVisualStyleBackColor = false;
            this.btC.Click += new System.EventHandler(this.BtC_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 389);
            this.Controls.Add(this.btC);
            this.Controls.Add(this.btDivicion);
            this.Controls.Add(this.btIgual);
            this.Controls.Add(this.btPuntp);
            this.Controls.Add(this.bt0);
            this.Controls.Add(this.btMultiplicacion);
            this.Controls.Add(this.bt3);
            this.Controls.Add(this.bt2);
            this.Controls.Add(this.bt1);
            this.Controls.Add(this.btResta);
            this.Controls.Add(this.bt6);
            this.Controls.Add(this.bt5);
            this.Controls.Add(this.bt4);
            this.Controls.Add(this.btSuma);
            this.Controls.Add(this.bt9);
            this.Controls.Add(this.bt8);
            this.Controls.Add(this.bt7);
            this.Controls.Add(this.tbCampoText);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbCampoText;
        private System.Windows.Forms.Button bt7;
        private System.Windows.Forms.Button bt8;
        private System.Windows.Forms.Button bt9;
        private System.Windows.Forms.Button btSuma;
        private System.Windows.Forms.Button bt4;
        private System.Windows.Forms.Button bt5;
        private System.Windows.Forms.Button bt6;
        private System.Windows.Forms.Button btResta;
        private System.Windows.Forms.Button bt1;
        private System.Windows.Forms.Button bt2;
        private System.Windows.Forms.Button bt3;
        private System.Windows.Forms.Button btMultiplicacion;
        private System.Windows.Forms.Button bt0;
        private System.Windows.Forms.Button btPuntp;
        private System.Windows.Forms.Button btIgual;
        private System.Windows.Forms.Button btDivicion;
        private System.Windows.Forms.Button btC;
    }
}

