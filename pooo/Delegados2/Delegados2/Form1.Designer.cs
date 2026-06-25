
namespace Delegados2
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
            this.txtMinutos = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.grdEstudiantes = new System.Windows.Forms.DataGridView();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdEstudiantes)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMinutos
            // 
            this.txtMinutos.Location = new System.Drawing.Point(124, 474);
            this.txtMinutos.Name = "txtMinutos";
            this.txtMinutos.Size = new System.Drawing.Size(229, 26);
            this.txtMinutos.TabIndex = 11;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(359, 466);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(154, 42);
            this.button3.TabIndex = 10;
            this.button3.Text = "Informar tiempo";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(216, 400);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(161, 46);
            this.button2.TabIndex = 9;
            this.button2.Text = "Iniciar examen";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // grdEstudiantes
            // 
            this.grdEstudiantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdEstudiantes.Location = new System.Drawing.Point(124, 102);
            this.grdEstudiantes.Name = "grdEstudiantes";
            this.grdEstudiantes.RowHeadersWidth = 62;
            this.grdEstudiantes.RowTemplate.Height = 28;
            this.grdEstudiantes.Size = new System.Drawing.Size(374, 261);
            this.grdEstudiantes.TabIndex = 8;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(664, 130);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(229, 26);
            this.txtNombre.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(913, 130);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 42);
            this.button1.TabIndex = 6;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1131, 611);
            this.Controls.Add(this.txtMinutos);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.grdEstudiantes);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdEstudiantes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMinutos;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView grdEstudiantes;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button button1;
    }
}

