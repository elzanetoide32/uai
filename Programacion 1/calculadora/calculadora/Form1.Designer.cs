namespace calculadora
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
            components = new System.ComponentModel.Container();
            btnSuma = new Button();
            btnResta = new Button();
            btnMultiplicacion = new Button();
            btnDivicion = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtNum2 = new TextBox();
            txtNum1 = new TextBox();
            lblResult = new TextBox();
            toolTip1 = new ToolTip(components);
            SuspendLayout();
            // 
            // btnSuma
            // 
            btnSuma.BackColor = Color.Purple;
            btnSuma.FlatAppearance.BorderColor = Color.Red;
            btnSuma.FlatAppearance.BorderSize = 10;
            btnSuma.ForeColor = SystemColors.ControlLightLight;
            btnSuma.Location = new Point(61, 71);
            btnSuma.Name = "btnSuma";
            btnSuma.Size = new Size(137, 48);
            btnSuma.TabIndex = 0;
            btnSuma.Text = "SUMA";
            btnSuma.UseVisualStyleBackColor = false;
            btnSuma.Click += btnSuma_Click;
            // 
            // btnResta
            // 
            btnResta.BackColor = Color.Purple;
            btnResta.ForeColor = SystemColors.ControlLightLight;
            btnResta.Location = new Point(61, 135);
            btnResta.Name = "btnResta";
            btnResta.Size = new Size(137, 48);
            btnResta.TabIndex = 1;
            btnResta.Text = "RESTA";
            btnResta.UseVisualStyleBackColor = false;
            btnResta.Click += btnResta_Click;
            // 
            // btnMultiplicacion
            // 
            btnMultiplicacion.BackColor = Color.Purple;
            btnMultiplicacion.ForeColor = SystemColors.ControlLightLight;
            btnMultiplicacion.Location = new Point(228, 135);
            btnMultiplicacion.Name = "btnMultiplicacion";
            btnMultiplicacion.Size = new Size(137, 48);
            btnMultiplicacion.TabIndex = 2;
            btnMultiplicacion.Text = "MULTIPLICACION";
            btnMultiplicacion.UseVisualStyleBackColor = false;
            btnMultiplicacion.Click += btnMultiplicacion_Click;
            // 
            // btnDivicion
            // 
            btnDivicion.BackColor = Color.Purple;
            btnDivicion.ForeColor = SystemColors.ControlLightLight;
            btnDivicion.Location = new Point(228, 71);
            btnDivicion.Name = "btnDivicion";
            btnDivicion.Size = new Size(137, 48);
            btnDivicion.TabIndex = 3;
            btnDivicion.Text = "DIVICION";
            btnDivicion.UseVisualStyleBackColor = false;
            btnDivicion.Click += btnDivicion_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(76, 6);
            label1.Name = "label1";
            label1.Size = new Size(83, 20);
            label1.TabIndex = 4;
            label1.Text = "NUMERO 1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(315, 6);
            label2.Name = "label2";
            label2.Size = new Size(83, 20);
            label2.TabIndex = 5;
            label2.Text = "NUMERO 2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(171, 237);
            label3.Name = "label3";
            label3.Size = new Size(89, 20);
            label3.TabIndex = 6;
            label3.Text = "RESULTADO";
            // 
            // txtNum2
            // 
            txtNum2.BorderStyle = BorderStyle.FixedSingle;
            txtNum2.Location = new Point(267, 29);
            txtNum2.Name = "txtNum2";
            txtNum2.PlaceholderText = "INGRESE EÑ NUMERO 2";
            txtNum2.Size = new Size(172, 27);
            txtNum2.TabIndex = 7;
            // 
            // txtNum1
            // 
            txtNum1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtNum1.BorderStyle = BorderStyle.FixedSingle;
            txtNum1.ForeColor = SystemColors.WindowText;
            txtNum1.Location = new Point(25, 29);
            txtNum1.Name = "txtNum1";
            txtNum1.PlaceholderText = "INGRESE EL NUMERO 1";
            txtNum1.Size = new Size(173, 27);
            txtNum1.TabIndex = 8;
            // 
            // lblResult
            // 
            lblResult.BorderStyle = BorderStyle.FixedSingle;
            lblResult.Location = new Point(153, 207);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(125, 27);
            lblResult.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(451, 297);
            Controls.Add(lblResult);
            Controls.Add(txtNum1);
            Controls.Add(txtNum2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnDivicion);
            Controls.Add(btnMultiplicacion);
            Controls.Add(btnResta);
            Controls.Add(btnSuma);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSuma;
        private Button btnResta;
        private Button btnMultiplicacion;
        private Button btnDivicion;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtNum2;
        private TextBox txtNum1;
        private TextBox lblResult;
        private ToolTip toolTip1;
    }
}
