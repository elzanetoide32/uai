namespace Encuesta
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numEdad = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.btnMasculino = new System.Windows.Forms.RadioButton();
            this.btnFemenino = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbProv = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.chb1 = new System.Windows.Forms.CheckBox();
            this.chb2 = new System.Windows.Forms.CheckBox();
            this.chb3 = new System.Windows.Forms.CheckBox();
            this.chb4 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.numEdad)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(221, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Apellido";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(114, 20);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 22);
            this.txtName.TabIndex = 2;
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(285, 19);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(100, 22);
            this.txtSurname.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Edad";
            // 
            // numEdad
            // 
            this.numEdad.Location = new System.Drawing.Point(114, 63);
            this.numEdad.Name = "numEdad";
            this.numEdad.Size = new System.Drawing.Size(120, 22);
            this.numEdad.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Genero";
            // 
            // btnMasculino
            // 
            this.btnMasculino.AutoSize = true;
            this.btnMasculino.Location = new System.Drawing.Point(114, 112);
            this.btnMasculino.Name = "btnMasculino";
            this.btnMasculino.Size = new System.Drawing.Size(89, 20);
            this.btnMasculino.TabIndex = 7;
            this.btnMasculino.TabStop = true;
            this.btnMasculino.Text = "Masculino";
            this.btnMasculino.UseVisualStyleBackColor = true;
            // 
            // btnFemenino
            // 
            this.btnFemenino.AutoSize = true;
            this.btnFemenino.Location = new System.Drawing.Point(238, 111);
            this.btnFemenino.Name = "btnFemenino";
            this.btnFemenino.Size = new System.Drawing.Size(88, 20);
            this.btnFemenino.TabIndex = 8;
            this.btnFemenino.TabStop = true;
            this.btnFemenino.Text = "Femenino";
            this.btnFemenino.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(54, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Provincia";
            // 
            // cmbProv
            // 
            this.cmbProv.FormattingEnabled = true;
            this.cmbProv.Items.AddRange(new object[] {
            "Buenos aires",
            "rio negro",
            "chubut",
            "cordoba",
            "jujy",
            "neuquen"});
            this.cmbProv.Location = new System.Drawing.Point(137, 187);
            this.cmbProv.Name = "cmbProv";
            this.cmbProv.Size = new System.Drawing.Size(121, 24);
            this.cmbProv.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(159, 275);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(226, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Mostrar Datos";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(54, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "intereses";
            // 
            // chb1
            // 
            this.chb1.AutoSize = true;
            this.chb1.Location = new System.Drawing.Point(137, 145);
            this.chb1.Name = "chb1";
            this.chb1.Size = new System.Drawing.Size(85, 20);
            this.chb1.TabIndex = 13;
            this.chb1.Text = "Deportes";
            this.chb1.UseVisualStyleBackColor = true;
            // 
            // chb2
            // 
            this.chb2.AutoSize = true;
            this.chb2.Location = new System.Drawing.Point(238, 144);
            this.chb2.Name = "chb2";
            this.chb2.Size = new System.Drawing.Size(72, 20);
            this.chb2.TabIndex = 14;
            this.chb2.Text = "Musica";
            this.chb2.UseVisualStyleBackColor = true;
            // 
            // chb3
            // 
            this.chb3.AutoSize = true;
            this.chb3.Location = new System.Drawing.Point(340, 145);
            this.chb3.Name = "chb3";
            this.chb3.Size = new System.Drawing.Size(56, 20);
            this.chb3.TabIndex = 15;
            this.chb3.Text = "Cine";
            this.chb3.UseVisualStyleBackColor = true;
            // 
            // chb4
            // 
            this.chb4.AutoSize = true;
            this.chb4.Location = new System.Drawing.Point(418, 145);
            this.chb4.Name = "chb4";
            this.chb4.Size = new System.Drawing.Size(98, 20);
            this.chb4.TabIndex = 16;
            this.chb4.Text = "Tecnologia";
            this.chb4.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 450);
            this.Controls.Add(this.chb4);
            this.Controls.Add(this.chb3);
            this.Controls.Add(this.chb2);
            this.Controls.Add(this.chb1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmbProv);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnFemenino);
            this.Controls.Add(this.btnMasculino);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numEdad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numEdad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numEdad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton btnMasculino;
        private System.Windows.Forms.RadioButton btnFemenino;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbProv;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chb1;
        private System.Windows.Forms.CheckBox chb2;
        private System.Windows.Forms.CheckBox chb3;
        private System.Windows.Forms.CheckBox chb4;
    }
}

