namespace cocineros
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
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblMesa1 = new System.Windows.Forms.Label();
            this.lblMesa2 = new System.Windows.Forms.Label();
            this.lblMesa3 = new System.Windows.Forms.Label();
            this.btnSacarPlato = new System.Windows.Forms.Button();
            this.cmbPlatos = new System.Windows.Forms.ComboBox();
            this.cmbMesa = new System.Windows.Forms.ComboBox();
            this.btnAddMesa = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(54, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(221, 296);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(435, 32);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(221, 296);
            this.dataGridView2.TabIndex = 1;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(818, 32);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(221, 296);
            this.dataGridView3.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(120, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mesa 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(519, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mesa 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(902, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Mesa 3";
            // 
            // lblMesa1
            // 
            this.lblMesa1.AutoSize = true;
            this.lblMesa1.Location = new System.Drawing.Point(127, 362);
            this.lblMesa1.Name = "lblMesa1";
            this.lblMesa1.Size = new System.Drawing.Size(44, 16);
            this.lblMesa1.TabIndex = 6;
            this.lblMesa1.Text = "label4";
            // 
            // lblMesa2
            // 
            this.lblMesa2.AutoSize = true;
            this.lblMesa2.Location = new System.Drawing.Point(509, 362);
            this.lblMesa2.Name = "lblMesa2";
            this.lblMesa2.Size = new System.Drawing.Size(44, 16);
            this.lblMesa2.TabIndex = 7;
            this.lblMesa2.Text = "label5";
            // 
            // lblMesa3
            // 
            this.lblMesa3.AutoSize = true;
            this.lblMesa3.Location = new System.Drawing.Point(902, 362);
            this.lblMesa3.Name = "lblMesa3";
            this.lblMesa3.Size = new System.Drawing.Size(44, 16);
            this.lblMesa3.TabIndex = 8;
            this.lblMesa3.Text = "label6";
            // 
            // btnSacarPlato
            // 
            this.btnSacarPlato.Location = new System.Drawing.Point(1188, 55);
            this.btnSacarPlato.Name = "btnSacarPlato";
            this.btnSacarPlato.Size = new System.Drawing.Size(131, 42);
            this.btnSacarPlato.TabIndex = 9;
            this.btnSacarPlato.Text = "Sacar Plato";
            this.btnSacarPlato.UseVisualStyleBackColor = true;
            this.btnSacarPlato.Click += new System.EventHandler(this.btnSacarPlato_Click);
            // 
            // cmbPlatos
            // 
            this.cmbPlatos.FormattingEnabled = true;
            this.cmbPlatos.Location = new System.Drawing.Point(1198, 123);
            this.cmbPlatos.Name = "cmbPlatos";
            this.cmbPlatos.Size = new System.Drawing.Size(121, 24);
            this.cmbPlatos.TabIndex = 10;
            // 
            // cmbMesa
            // 
            this.cmbMesa.FormattingEnabled = true;
            this.cmbMesa.Location = new System.Drawing.Point(1198, 174);
            this.cmbMesa.Name = "cmbMesa";
            this.cmbMesa.Size = new System.Drawing.Size(121, 24);
            this.cmbMesa.TabIndex = 11;
            // 
            // btnAddMesa
            // 
            this.btnAddMesa.Location = new System.Drawing.Point(1198, 245);
            this.btnAddMesa.Name = "btnAddMesa";
            this.btnAddMesa.Size = new System.Drawing.Size(114, 44);
            this.btnAddMesa.TabIndex = 12;
            this.btnAddMesa.Text = "Agregar Mesa";
            this.btnAddMesa.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1113, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Plato";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1113, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "N° Mesa";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1356, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnAddMesa);
            this.Controls.Add(this.cmbMesa);
            this.Controls.Add(this.cmbPlatos);
            this.Controls.Add(this.btnSacarPlato);
            this.Controls.Add(this.lblMesa3);
            this.Controls.Add(this.lblMesa2);
            this.Controls.Add(this.lblMesa1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblMesa1;
        private System.Windows.Forms.Label lblMesa2;
        private System.Windows.Forms.Label lblMesa3;
        private System.Windows.Forms.Button btnSacarPlato;
        private System.Windows.Forms.ComboBox cmbPlatos;
        private System.Windows.Forms.ComboBox cmbMesa;
        private System.Windows.Forms.Button btnAddMesa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

