namespace holaaa
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
            this.Nodo = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnAgregarAdelante = new System.Windows.Forms.Button();
            this.btnAgregarAtras = new System.Windows.Forms.Button();
            this.btnEditarActual = new System.Windows.Forms.Button();
            this.btnEliminarActual = new System.Windows.Forms.Button();
            this.btnQuitarPrimero = new System.Windows.Forms.Button();
            this.btnQuitarUltimo = new System.Windows.Forms.Button();
            this.lstLista = new System.Windows.Forms.ListBox();
            this.Nodo.SuspendLayout();
            this.SuspendLayout();
            // 
            // Nodo
            // 
            this.Nodo.Controls.Add(this.txtNombre);
            this.Nodo.Controls.Add(this.txtApellido);
            this.Nodo.Controls.Add(this.label2);
            this.Nodo.Controls.Add(this.label1);
            this.Nodo.Location = new System.Drawing.Point(237, 38);
            this.Nodo.Name = "Nodo";
            this.Nodo.Size = new System.Drawing.Size(214, 94);
            this.Nodo.TabIndex = 0;
            this.Nodo.TabStop = false;
            this.Nodo.Text = "Nodo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Apellido";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(73, 51);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(100, 20);
            this.txtApellido.TabIndex = 2;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(73, 20);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 3;
            // 
            // btnAgregarAdelante
            // 
            this.btnAgregarAdelante.Location = new System.Drawing.Point(266, 148);
            this.btnAgregarAdelante.Name = "btnAgregarAdelante";
            this.btnAgregarAdelante.Size = new System.Drawing.Size(126, 23);
            this.btnAgregarAdelante.TabIndex = 1;
            this.btnAgregarAdelante.Text = "Agregar Adelante";
            this.btnAgregarAdelante.UseVisualStyleBackColor = true;
            this.btnAgregarAdelante.Click += new System.EventHandler(this.btnAgregarAdelante_Click);
            // 
            // btnAgregarAtras
            // 
            this.btnAgregarAtras.Location = new System.Drawing.Point(266, 177);
            this.btnAgregarAtras.Name = "btnAgregarAtras";
            this.btnAgregarAtras.Size = new System.Drawing.Size(126, 23);
            this.btnAgregarAtras.TabIndex = 2;
            this.btnAgregarAtras.Text = "Agregar Atras";
            this.btnAgregarAtras.UseVisualStyleBackColor = true;
            this.btnAgregarAtras.Click += new System.EventHandler(this.btnAgregarAtras_Click);
            // 
            // btnEditarActual
            // 
            this.btnEditarActual.Location = new System.Drawing.Point(266, 206);
            this.btnEditarActual.Name = "btnEditarActual";
            this.btnEditarActual.Size = new System.Drawing.Size(126, 23);
            this.btnEditarActual.TabIndex = 3;
            this.btnEditarActual.Text = "Editar Actual";
            this.btnEditarActual.UseVisualStyleBackColor = true;
            this.btnEditarActual.Click += new System.EventHandler(this.btnEditarActual_Click);
            // 
            // btnEliminarActual
            // 
            this.btnEliminarActual.Location = new System.Drawing.Point(266, 234);
            this.btnEliminarActual.Name = "btnEliminarActual";
            this.btnEliminarActual.Size = new System.Drawing.Size(126, 23);
            this.btnEliminarActual.TabIndex = 4;
            this.btnEliminarActual.Text = "Eliminar Actual";
            this.btnEliminarActual.UseVisualStyleBackColor = true;
            this.btnEliminarActual.Click += new System.EventHandler(this.btnEliminarActual_Click);
            // 
            // btnQuitarPrimero
            // 
            this.btnQuitarPrimero.Location = new System.Drawing.Point(266, 263);
            this.btnQuitarPrimero.Name = "btnQuitarPrimero";
            this.btnQuitarPrimero.Size = new System.Drawing.Size(126, 23);
            this.btnQuitarPrimero.TabIndex = 5;
            this.btnQuitarPrimero.Text = "Quitar Primero";
            this.btnQuitarPrimero.UseVisualStyleBackColor = true;
            this.btnQuitarPrimero.Click += new System.EventHandler(this.btnQuitarPrimero_Click);
            // 
            // btnQuitarUltimo
            // 
            this.btnQuitarUltimo.Location = new System.Drawing.Point(266, 292);
            this.btnQuitarUltimo.Name = "btnQuitarUltimo";
            this.btnQuitarUltimo.Size = new System.Drawing.Size(126, 23);
            this.btnQuitarUltimo.TabIndex = 6;
            this.btnQuitarUltimo.Text = "Quitar Ultimo";
            this.btnQuitarUltimo.UseVisualStyleBackColor = true;
            this.btnQuitarUltimo.Click += new System.EventHandler(this.btnQuitarUltimo_Click);
            // 
            // lstLista
            // 
            this.lstLista.FormattingEnabled = true;
            this.lstLista.Location = new System.Drawing.Point(13, 13);
            this.lstLista.Name = "lstLista";
            this.lstLista.Size = new System.Drawing.Size(198, 329);
            this.lstLista.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 397);
            this.Controls.Add(this.lstLista);
            this.Controls.Add(this.btnQuitarUltimo);
            this.Controls.Add(this.btnQuitarPrimero);
            this.Controls.Add(this.btnEliminarActual);
            this.Controls.Add(this.btnEditarActual);
            this.Controls.Add(this.btnAgregarAtras);
            this.Controls.Add(this.btnAgregarAdelante);
            this.Controls.Add(this.Nodo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Nodo.ResumeLayout(false);
            this.Nodo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Nodo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAgregarAdelante;
        private System.Windows.Forms.Button btnAgregarAtras;
        private System.Windows.Forms.Button btnEditarActual;
        private System.Windows.Forms.Button btnEliminarActual;
        private System.Windows.Forms.Button btnQuitarPrimero;
        private System.Windows.Forms.Button btnQuitarUltimo;
        private System.Windows.Forms.ListBox lstLista;
    }
}

