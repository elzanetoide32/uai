namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            progressBar2 = new ProgressBar();
            progressBar1 = new ProgressBar();
            panelBarraVerde = new Panel();
            panelBarraNegra = new Panel();
            btSalir = new Button();
            btVisualizar = new Button();
            btAgregar = new Button();
            lblSaldoTotal = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackgroundImageLayout = ImageLayout.None;
            groupBox1.Controls.Add(panelBarraVerde);
            groupBox1.Controls.Add(panelBarraNegra);
            groupBox1.Controls.Add(btSalir);
            groupBox1.Controls.Add(btVisualizar);
            groupBox1.Controls.Add(btAgregar);
            groupBox1.Controls.Add(lblSaldoTotal);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(progressBar1);
            groupBox1.Controls.Add(progressBar2);
            groupBox1.Location = new Point(14, 16);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(437, 347);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // progressBar2
            // 
            progressBar2.Location = new Point(220, 191);
            progressBar2.Name = "progressBar2";
            progressBar2.Size = new Size(217, 33);
            progressBar2.TabIndex = 11;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(0, 191);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(220, 33);
            progressBar1.TabIndex = 10;
            // 
            // panelBarraVerde
            // 
            panelBarraVerde.BackColor = SystemColors.ControlDark;
            panelBarraVerde.BorderStyle = BorderStyle.FixedSingle;
            panelBarraVerde.Cursor = Cursors.SizeAll;
            panelBarraVerde.Location = new Point(218, 191);
            panelBarraVerde.Name = "panelBarraVerde";
            panelBarraVerde.Size = new Size(219, 33);
            panelBarraVerde.TabIndex = 9;
            // 
            // panelBarraNegra
            // 
            panelBarraNegra.BackColor = SystemColors.ControlDark;
            panelBarraNegra.BorderStyle = BorderStyle.FixedSingle;
            panelBarraNegra.Location = new Point(0, 191);
            panelBarraNegra.Name = "panelBarraNegra";
            panelBarraNegra.Size = new Size(220, 33);
            panelBarraNegra.TabIndex = 8;
            // 
            // btSalir
            // 
            btSalir.Location = new Point(303, 264);
            btSalir.Margin = new Padding(3, 4, 3, 4);
            btSalir.Name = "btSalir";
            btSalir.Size = new Size(86, 31);
            btSalir.TabIndex = 7;
            btSalir.Text = "Salir";
            btSalir.UseVisualStyleBackColor = true;
            btSalir.Click += btSalir_Click;
            // 
            // btVisualizar
            // 
            btVisualizar.Location = new Point(173, 264);
            btVisualizar.Margin = new Padding(3, 4, 3, 4);
            btVisualizar.Name = "btVisualizar";
            btVisualizar.Size = new Size(86, 31);
            btVisualizar.TabIndex = 6;
            btVisualizar.Text = "Detalle";
            btVisualizar.UseVisualStyleBackColor = true;
            btVisualizar.Click += btVisualizar_Click;
            // 
            // btAgregar
            // 
            btAgregar.Location = new Point(42, 264);
            btAgregar.Margin = new Padding(3, 4, 3, 4);
            btAgregar.Name = "btAgregar";
            btAgregar.Size = new Size(86, 31);
            btAgregar.TabIndex = 5;
            btAgregar.Text = "Agregar";
            btAgregar.UseVisualStyleBackColor = true;
            btAgregar.Click += btAgregar_Click;
            // 
            // lblSaldoTotal
            // 
            lblSaldoTotal.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSaldoTotal.ForeColor = Color.Black;
            lblSaldoTotal.Location = new Point(193, 120);
            lblSaldoTotal.Name = "lblSaldoTotal";
            lblSaldoTotal.Size = new Size(195, 33);
            lblSaldoTotal.TabIndex = 2;
            lblSaldoTotal.Text = "$ 0";
            lblSaldoTotal.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(42, 120);
            label2.Name = "label2";
            label2.Size = new Size(166, 32);
            label2.TabIndex = 1;
            label2.Text = "SALDO TOTAL:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold);
            label1.Location = new Point(101, 25);
            label1.Name = "label1";
            label1.Size = new Size(252, 46);
            label1.TabIndex = 0;
            label1.Text = "Menú Principal";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(479, 409);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Presupuesto Personal";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private Button btAgregar;
        private Label label2;
        private Button btSalir;
        private Button btVisualizar;
        public Label lblSaldoTotal;
        private Panel panelBarraVerde;
        private Panel panelBarraNegra;
        private ProgressBar progressBar2;
        private ProgressBar progressBar1;
    }
}
