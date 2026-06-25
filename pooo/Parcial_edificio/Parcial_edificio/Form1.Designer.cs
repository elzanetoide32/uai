namespace Parcial_edificio
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCalle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAgregarEdificio = new System.Windows.Forms.Button();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.btnAgregarUnidad = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUnidadNombre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNombreBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtApellidoBuscar = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(26, 49);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(221, 244);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1256, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Edificio";
            // 
            // txtCalle
            // 
            this.txtCalle.Location = new System.Drawing.Point(1275, 85);
            this.txtCalle.Name = "txtCalle";
            this.txtCalle.Size = new System.Drawing.Size(100, 22);
            this.txtCalle.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1180, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Calle";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1180, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Numero";
            // 
            // txtAgregarEdificio
            // 
            this.txtAgregarEdificio.Location = new System.Drawing.Point(1238, 200);
            this.txtAgregarEdificio.Name = "txtAgregarEdificio";
            this.txtAgregarEdificio.Size = new System.Drawing.Size(137, 30);
            this.txtAgregarEdificio.TabIndex = 7;
            this.txtAgregarEdificio.Text = "Agregar Edificio";
            this.txtAgregarEdificio.UseVisualStyleBackColor = true;
            this.txtAgregarEdificio.Click += new System.EventHandler(this.txtAgregarEdificio_Click);
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(1275, 129);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(100, 22);
            this.txtNumero.TabIndex = 8;
            // 
            // btnAgregarUnidad
            // 
            this.btnAgregarUnidad.Location = new System.Drawing.Point(936, 136);
            this.btnAgregarUnidad.Name = "btnAgregarUnidad";
            this.btnAgregarUnidad.Size = new System.Drawing.Size(163, 24);
            this.btnAgregarUnidad.TabIndex = 9;
            this.btnAgregarUnidad.Text = "Agregar Unidad";
            this.btnAgregarUnidad.UseVisualStyleBackColor = true;
            this.btnAgregarUnidad.Click += new System.EventHandler(this.btnAgregarUnidad_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(960, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Nombre Unidad";
            // 
            // txtUnidadNombre
            // 
            this.txtUnidadNombre.Location = new System.Drawing.Point(963, 92);
            this.txtUnidadNombre.Name = "txtUnidadNombre";
            this.txtUnidadNombre.Size = new System.Drawing.Size(100, 22);
            this.txtUnidadNombre.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(647, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "Buscar";
            // 
            // txtNombreBuscar
            // 
            this.txtNombreBuscar.Location = new System.Drawing.Point(650, 88);
            this.txtNombreBuscar.Name = "txtNombreBuscar";
            this.txtNombreBuscar.Size = new System.Drawing.Size(100, 22);
            this.txtNombreBuscar.TabIndex = 13;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(623, 135);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(163, 24);
            this.btnBuscar.TabIndex = 12;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtApellidoBuscar
            // 
            this.txtApellidoBuscar.Location = new System.Drawing.Point(790, 88);
            this.txtApellidoBuscar.Name = "txtApellidoBuscar";
            this.txtApellidoBuscar.Size = new System.Drawing.Size(100, 22);
            this.txtApellidoBuscar.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1415, 450);
            this.Controls.Add(this.txtApellidoBuscar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNombreBuscar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtUnidadNombre);
            this.Controls.Add(this.btnAgregarUnidad);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.txtAgregarEdificio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCalle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCalle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button txtAgregarEdificio;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Button btnAgregarUnidad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUnidadNombre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNombreBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtApellidoBuscar;
    }
}

