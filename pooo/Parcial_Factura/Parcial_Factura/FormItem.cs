using Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial_Factura
{
    public partial class FormItem : Form
    {
        private NumericUpDown nudCantidad;
        private TextBox txtProducto;
        private NumericUpDown nudPrecio;
        private Label label1;
        private Label label2;
        private Label label3;
        #region Atributos
        private ItemFactura mItem;
        public ItemFactura Item => mItem; // para recuperarlo desde el form principal
        #endregion

        #region Eventos
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                mItem = new ItemFactura(txtProducto.Text, (int)nudCantidad.Value);
                mItem.PrecioUnitario = (Single)nudPrecio.Value;
                this.DialogResult = DialogResult.OK; // cierra el form
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        private void InitializeComponent()
        {
            this.nudCantidad = new System.Windows.Forms.NumericUpDown();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.nudPrecio = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecio)).BeginInit();
            this.SuspendLayout();
            // 
            // nudCantidad
            // 
            this.nudCantidad.Location = new System.Drawing.Point(444, 104);
            this.nudCantidad.Name = "nudCantidad";
            this.nudCantidad.Size = new System.Drawing.Size(120, 22);
            this.nudCantidad.TabIndex = 16;
            // 
            // txtProducto
            // 
            this.txtProducto.Location = new System.Drawing.Point(444, 62);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(100, 22);
            this.txtProducto.TabIndex = 15;
            // 
            // nudPrecio
            // 
            this.nudPrecio.Location = new System.Drawing.Point(444, 150);
            this.nudPrecio.Name = "nudPrecio";
            this.nudPrecio.Size = new System.Drawing.Size(120, 22);
            this.nudPrecio.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(372, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 18;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(372, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 19;
            this.label2.Text = "Cantidad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(372, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 16);
            this.label3.TabIndex = 20;
            this.label3.Text = "Precio";
            // 
            // FormItem
            // 
            this.ClientSize = new System.Drawing.Size(829, 389);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudPrecio);
            this.Controls.Add(this.nudCantidad);
            this.Controls.Add(this.txtProducto);
            this.Name = "FormItem";
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
