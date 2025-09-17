namespace proyectoUno
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
            this.btnAdelante = new System.Windows.Forms.Button();
            this.btnAtras = new System.Windows.Forms.Button();
            this.lstLista = new System.Windows.Forms.ListBox();
            this.Nodo = new System.Windows.Forms.GroupBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Nodo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAdelante
            // 
            this.btnAdelante.Location = new System.Drawing.Point(280, 142);
            this.btnAdelante.Name = "btnAdelante";
            this.btnAdelante.Size = new System.Drawing.Size(167, 25);
            this.btnAdelante.TabIndex = 0;
            this.btnAdelante.Text = "Agregar Adelente";
            this.btnAdelante.UseVisualStyleBackColor = true;
            this.btnAdelante.Click += new System.EventHandler(this.btnAdelante_Click);
            // 
            // btnAtras
            // 
            this.btnAtras.Location = new System.Drawing.Point(280, 184);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(167, 24);
            this.btnAtras.TabIndex = 1;
            this.btnAtras.Text = "Agregar Atras";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // lstLista
            // 
            this.lstLista.FormattingEnabled = true;
            this.lstLista.Location = new System.Drawing.Point(13, 13);
            this.lstLista.Name = "lstLista";
            this.lstLista.Size = new System.Drawing.Size(210, 277);
            this.lstLista.TabIndex = 2;
            // 
            // Nodo
            // 
            this.Nodo.Controls.Add(this.txtNombre);
            this.Nodo.Controls.Add(this.label1);
            this.Nodo.Location = new System.Drawing.Point(280, 22);
            this.Nodo.Name = "Nodo";
            this.Nodo.Size = new System.Drawing.Size(200, 91);
            this.Nodo.TabIndex = 3;
            this.Nodo.TabStop = false;
            this.Nodo.Text = "Nodo";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(67, 30);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(492, 313);
            this.Controls.Add(this.Nodo);
            this.Controls.Add(this.lstLista);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.btnAdelante);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Nodo.ResumeLayout(false);
            this.Nodo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAdelante;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.ListBox lstLista;
        private System.Windows.Forms.GroupBox Nodo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label1;
    }
}

