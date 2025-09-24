namespace WindowsFormsApp1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lstCamion = new System.Windows.Forms.ListBox();
            this.txtCarga = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnProx = new System.Windows.Forms.Button();
            this.lblProx = new System.Windows.Forms.Label();
            this.btnExist = new System.Windows.Forms.Button();
            this.txtExist = new System.Windows.Forms.TextBox();
            this.lblExist = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lstCamion
            // 
            this.lstCamion.FormattingEnabled = true;
            this.lstCamion.Location = new System.Drawing.Point(638, 62);
            this.lstCamion.Name = "lstCamion";
            this.lstCamion.Size = new System.Drawing.Size(247, 134);
            this.lstCamion.TabIndex = 0;
            // 
            // txtCarga
            // 
            this.txtCarga.Location = new System.Drawing.Point(441, 62);
            this.txtCarga.Name = "txtCarga";
            this.txtCarga.Size = new System.Drawing.Size(100, 20);
            this.txtCarga.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(635, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Orden de los elementos del camion";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(390, 106);
            this.progressBar1.Maximum = 5;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(151, 24);
            this.progressBar1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(387, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Carga";
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(507, 172);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(74, 61);
            this.button1.TabIndex = 5;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Location = new System.Drawing.Point(376, 170);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(77, 63);
            this.button2.TabIndex = 6;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 49);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(320, 147);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(398, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Carga";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(516, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Descarga";
            // 
            // btnProx
            // 
            this.btnProx.Location = new System.Drawing.Point(12, 257);
            this.btnProx.Name = "btnProx";
            this.btnProx.Size = new System.Drawing.Size(115, 23);
            this.btnProx.TabIndex = 10;
            this.btnProx.Text = "¿cual es el proximo?";
            this.btnProx.UseVisualStyleBackColor = true;
            this.btnProx.Click += new System.EventHandler(this.btnProx_Click);
            // 
            // lblProx
            // 
            this.lblProx.AutoSize = true;
            this.lblProx.Location = new System.Drawing.Point(143, 262);
            this.lblProx.Name = "lblProx";
            this.lblProx.Size = new System.Drawing.Size(35, 13);
            this.lblProx.TabIndex = 11;
            this.lblProx.Text = "label5";
            // 
            // btnExist
            // 
            this.btnExist.Location = new System.Drawing.Point(296, 287);
            this.btnExist.Name = "btnExist";
            this.btnExist.Size = new System.Drawing.Size(116, 23);
            this.btnExist.TabIndex = 12;
            this.btnExist.Text = "¿esta adentro?";
            this.btnExist.UseVisualStyleBackColor = true;
            this.btnExist.Click += new System.EventHandler(this.btnExist_Click);
            // 
            // txtExist
            // 
            this.txtExist.Location = new System.Drawing.Point(441, 287);
            this.txtExist.Name = "txtExist";
            this.txtExist.Size = new System.Drawing.Size(100, 20);
            this.txtExist.TabIndex = 13;
            // 
            // lblExist
            // 
            this.lblExist.AutoSize = true;
            this.lblExist.Location = new System.Drawing.Point(576, 292);
            this.lblExist.Name = "lblExist";
            this.lblExist.Size = new System.Drawing.Size(35, 13);
            this.lblExist.TabIndex = 14;
            this.lblExist.Text = "label6";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 355);
            this.Controls.Add(this.lblExist);
            this.Controls.Add(this.txtExist);
            this.Controls.Add(this.btnExist);
            this.Controls.Add(this.lblProx);
            this.Controls.Add(this.btnProx);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCarga);
            this.Controls.Add(this.lstCamion);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstCamion;
        private System.Windows.Forms.TextBox txtCarga;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnProx;
        private System.Windows.Forms.Label lblProx;
        private System.Windows.Forms.Button btnExist;
        private System.Windows.Forms.TextBox txtExist;
        private System.Windows.Forms.Label lblExist;
    }
}

