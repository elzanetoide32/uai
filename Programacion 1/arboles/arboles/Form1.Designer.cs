namespace arboles
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
            this.tvCrarArbol = new System.Windows.Forms.TreeView();
            this.tvAgregarNodo = new System.Windows.Forms.TreeView();
            this.tvPre = new System.Windows.Forms.TreeView();
            this.tvIn = new System.Windows.Forms.TreeView();
            this.tvPos = new System.Windows.Forms.TreeView();
            this.btnCreateTree = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnPre = new System.Windows.Forms.Button();
            this.btnIn = new System.Windows.Forms.Button();
            this.btnPos = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPre = new System.Windows.Forms.TextBox();
            this.txtIn = new System.Windows.Forms.TextBox();
            this.txtPOs = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tvCrarArbol
            // 
            this.tvCrarArbol.Location = new System.Drawing.Point(39, 32);
            this.tvCrarArbol.Name = "tvCrarArbol";
            this.tvCrarArbol.Size = new System.Drawing.Size(205, 125);
            this.tvCrarArbol.TabIndex = 0;
            // 
            // tvAgregarNodo
            // 
            this.tvAgregarNodo.Location = new System.Drawing.Point(364, 32);
            this.tvAgregarNodo.Name = "tvAgregarNodo";
            this.tvAgregarNodo.Size = new System.Drawing.Size(207, 125);
            this.tvAgregarNodo.TabIndex = 1;
            // 
            // tvPre
            // 
            this.tvPre.Location = new System.Drawing.Point(26, 268);
            this.tvPre.Name = "tvPre";
            this.tvPre.Size = new System.Drawing.Size(188, 102);
            this.tvPre.TabIndex = 2;
            // 
            // tvIn
            // 
            this.tvIn.Location = new System.Drawing.Point(251, 268);
            this.tvIn.Name = "tvIn";
            this.tvIn.Size = new System.Drawing.Size(167, 102);
            this.tvIn.TabIndex = 3;
            // 
            // tvPos
            // 
            this.tvPos.Location = new System.Drawing.Point(476, 268);
            this.tvPos.Name = "tvPos";
            this.tvPos.Size = new System.Drawing.Size(175, 102);
            this.tvPos.TabIndex = 4;
            // 
            // btnCreateTree
            // 
            this.btnCreateTree.Location = new System.Drawing.Point(39, 174);
            this.btnCreateTree.Name = "btnCreateTree";
            this.btnCreateTree.Size = new System.Drawing.Size(175, 23);
            this.btnCreateTree.TabIndex = 5;
            this.btnCreateTree.Text = "Crear un arbol con el control tree";
            this.btnCreateTree.UseVisualStyleBackColor = true;
            this.btnCreateTree.Click += new System.EventHandler(this.btnCreateTree_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(364, 174);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(207, 23);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "crear un arbol agregando nodos al tree view";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(364, 203);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(207, 23);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "borrado de nodos del tree view";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnPre
            // 
            this.btnPre.Location = new System.Drawing.Point(26, 376);
            this.btnPre.Name = "btnPre";
            this.btnPre.Size = new System.Drawing.Size(188, 23);
            this.btnPre.TabIndex = 8;
            this.btnPre.Text = "Recorrido PreOrden";
            this.btnPre.UseVisualStyleBackColor = true;
            this.btnPre.Click += new System.EventHandler(this.btnPre_Click);
            // 
            // btnIn
            // 
            this.btnIn.Location = new System.Drawing.Point(251, 376);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(167, 23);
            this.btnIn.TabIndex = 9;
            this.btnIn.Text = "recorrido InOrder";
            this.btnIn.UseVisualStyleBackColor = true;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // btnPos
            // 
            this.btnPos.Location = new System.Drawing.Point(476, 376);
            this.btnPos.Name = "btnPos";
            this.btnPos.Size = new System.Drawing.Size(175, 23);
            this.btnPos.TabIndex = 10;
            this.btnPos.Text = "Recorrido PosOrden";
            this.btnPos.UseVisualStyleBackColor = true;
            this.btnPos.Click += new System.EventHandler(this.btnPos_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "para practicar y conocer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(164, 243);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "recorridos PreOrden-InOrder-PosOrden";
            // 
            // txtPre
            // 
            this.txtPre.Location = new System.Drawing.Point(26, 405);
            this.txtPre.Name = "txtPre";
            this.txtPre.Size = new System.Drawing.Size(188, 20);
            this.txtPre.TabIndex = 13;
            // 
            // txtIn
            // 
            this.txtIn.Location = new System.Drawing.Point(251, 405);
            this.txtIn.Name = "txtIn";
            this.txtIn.Size = new System.Drawing.Size(167, 20);
            this.txtIn.TabIndex = 14;
            // 
            // txtPOs
            // 
            this.txtPOs.Location = new System.Drawing.Point(476, 405);
            this.txtPOs.Name = "txtPOs";
            this.txtPOs.Size = new System.Drawing.Size(175, 20);
            this.txtPOs.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 462);
            this.Controls.Add(this.txtPOs);
            this.Controls.Add(this.txtIn);
            this.Controls.Add(this.txtPre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPos);
            this.Controls.Add(this.btnIn);
            this.Controls.Add(this.btnPre);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnCreateTree);
            this.Controls.Add(this.tvPos);
            this.Controls.Add(this.tvIn);
            this.Controls.Add(this.tvPre);
            this.Controls.Add(this.tvAgregarNodo);
            this.Controls.Add(this.tvCrarArbol);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView tvCrarArbol;
        private System.Windows.Forms.TreeView tvAgregarNodo;
        private System.Windows.Forms.TreeView tvPre;
        private System.Windows.Forms.TreeView tvIn;
        private System.Windows.Forms.TreeView tvPos;
        private System.Windows.Forms.Button btnCreateTree;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnPre;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.Button btnPos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPre;
        private System.Windows.Forms.TextBox txtIn;
        private System.Windows.Forms.TextBox txtPOs;
    }
}

