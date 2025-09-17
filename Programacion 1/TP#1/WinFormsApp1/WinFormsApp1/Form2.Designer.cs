namespace WinFormsApp1
{
    partial class FormABM
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
            groupBox1 = new GroupBox();
            txtFecha = new MaskedTextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            txtImporte = new TextBox();
            cbCategoria = new ComboBox();
            label2 = new Label();
            groupBox2 = new GroupBox();
            rbGasto = new RadioButton();
            rbIngreso = new RadioButton();
            btVolver = new Button();
            btGuardar = new Button();
            label1 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            groupBox1.Controls.Add(txtFecha);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtImporte);
            groupBox1.Controls.Add(cbCategoria);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(btVolver);
            groupBox1.Controls.Add(btGuardar);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(252, 321);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            // 
            // txtFecha
            // 
            txtFecha.Location = new Point(118, 199);
            txtFecha.Mask = "00/00/0000";
            txtFecha.Name = "txtFecha";
            txtFecha.Size = new Size(121, 23);
            txtFecha.TabIndex = 3;
            txtFecha.TextAlign = HorizontalAlignment.Center;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12.75F, FontStyle.Bold);
            label5.Location = new Point(7, 198);
            label5.Name = "label5";
            label5.Size = new Size(67, 23);
            label5.TabIndex = 15;
            label5.Text = "FECHA:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12.75F, FontStyle.Bold);
            label4.Location = new Point(7, 238);
            label4.Name = "label4";
            label4.Size = new Size(87, 23);
            label4.TabIndex = 14;
            label4.Text = "IMPORTE:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12.75F, FontStyle.Bold);
            label3.Location = new Point(7, 159);
            label3.Name = "label3";
            label3.Size = new Size(105, 23);
            label3.TabIndex = 13;
            label3.Text = "CATEGORIA:";
            // 
            // txtImporte
            // 
            txtImporte.Location = new Point(117, 238);
            txtImporte.Name = "txtImporte";
            txtImporte.Size = new Size(122, 23);
            txtImporte.TabIndex = 4;
            txtImporte.KeyPress += tbImporte_KeyPress;
            // 
            // cbCategoria
            // 
            cbCategoria.FormattingEnabled = true;
            cbCategoria.Location = new Point(118, 159);
            cbCategoria.Name = "cbCategoria";
            cbCategoria.Size = new Size(121, 23);
            cbCategoria.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12.75F, FontStyle.Bold);
            label2.Location = new Point(7, 98);
            label2.Name = "label2";
            label2.Size = new Size(51, 23);
            label2.TabIndex = 9;
            label2.Text = "TIPO:";
            // 
            // groupBox2
            // 
            groupBox2.BackgroundImageLayout = ImageLayout.None;
            groupBox2.Controls.Add(rbGasto);
            groupBox2.Controls.Add(rbIngreso);
            groupBox2.Location = new Point(118, 71);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(122, 72);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            // 
            // rbGasto
            // 
            rbGasto.AutoSize = true;
            rbGasto.Location = new Point(13, 42);
            rbGasto.Name = "rbGasto";
            rbGasto.Size = new Size(61, 19);
            rbGasto.TabIndex = 1;
            rbGasto.TabStop = true;
            rbGasto.Text = "GASTO";
            rbGasto.UseVisualStyleBackColor = true;
            rbGasto.CheckedChanged += rbGasto_CheckedChanged;
            // 
            // rbIngreso
            // 
            rbIngreso.AutoSize = true;
            rbIngreso.Location = new Point(13, 17);
            rbIngreso.Name = "rbIngreso";
            rbIngreso.Size = new Size(73, 19);
            rbIngreso.TabIndex = 0;
            rbIngreso.TabStop = true;
            rbIngreso.Text = "INGRESO";
            rbIngreso.UseVisualStyleBackColor = true;
            rbIngreso.CheckedChanged += rbIngreso_CheckedChanged;
            // 
            // btVolver
            // 
            btVolver.Location = new Point(164, 289);
            btVolver.Name = "btVolver";
            btVolver.Size = new Size(75, 23);
            btVolver.TabIndex = 6;
            btVolver.Text = "Volver";
            btVolver.UseVisualStyleBackColor = true;
            btVolver.Click += btVolver_Click;
            // 
            // btGuardar
            // 
            btGuardar.Location = new Point(7, 289);
            btGuardar.Name = "btGuardar";
            btGuardar.Size = new Size(75, 23);
            btGuardar.TabIndex = 5;
            btGuardar.Text = "Guardar";
            btGuardar.UseVisualStyleBackColor = true;
            btGuardar.Click += btGuardar_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold);
            label1.Location = new Point(6, 19);
            label1.Name = "label1";
            label1.Size = new Size(240, 37);
            label1.TabIndex = 0;
            label1.Text = "AGREGAR";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // FormABM
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(289, 362);
            Controls.Add(groupBox1);
            Name = "FormABM";
            Text = "Form2";
            Load += FormABM_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btVolver;
        private Button btGuardar;
        private Label label1;
        private Label label2;
        private GroupBox groupBox2;
        private RadioButton rbGasto;
        private RadioButton rbIngreso;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox txtImporte;
        private ComboBox cbCategoria;
        private MaskedTextBox txtFecha;
    }
}