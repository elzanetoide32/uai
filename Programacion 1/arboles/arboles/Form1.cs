using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace arboles
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnCreateTree_Click(object sender, EventArgs e)
        {
            ///crear con el tree view manejo como list box
            tvCrarArbol.Nodes.Clear();
            ///CREO LOS NODOS
            TreeNode AA = new TreeNode("A");
            TreeNode BB = new TreeNode("B");
            TreeNode CC = new TreeNode("C");
            TreeNode DD = new TreeNode("D");
            TreeNode EE = new TreeNode("E");
            TreeNode FF = new TreeNode("F");
            TreeNode GG = new TreeNode("G");
            ////ARMADO DE LA RELACION
            AA.Nodes.Add(BB);
            AA.Nodes.Add(CC);
            BB.Nodes.Add(DD);
            BB.Nodes.Add(EE);
            CC.Nodes.Add(FF);
            CC.Nodes.Add(GG);
            //QUE ME IMPRIMA EN EL TREE
            tvCrarArbol.Nodes.Add(AA);//solo la raiz pq el resto depende d ella
            AA.ExpandAll();//muestra el arbol ya expandido
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ///verifico si hay algo antes o no
            if (tvAgregarNodo.SelectedNode != null)
            {
                ///agrego dsp del seleccionado
                tvAgregarNodo.SelectedNode.Nodes.Add(Microsoft.VisualBasic.Interaction.InputBox("ingrese el nombre del nodo"));///es como un mesage input 
            }
            else
            {
                //lo agrego al principio sin el seleccionado
                tvAgregarNodo.Nodes.Add(Microsoft.VisualBasic.Interaction.InputBox("ingrese el nombre del nodo"));
            }
            tvAgregarNodo.ExpandAll();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (tvAgregarNodo.SelectedNode != null)
            {
                tvAgregarNodo.SelectedNode.Remove();
            }
        }
        //creo el arbol y le paso izquierdos y derechos
        Nodo Raiz = new Nodo("A",
                                new Nodo("B", new Nodo("D", null, null),
                                             new Nodo("E", null, null)),
                                new Nodo("C",
                                        new Nodo("F", null, null),
                                        new Nodo("G", null, null)));
        public void RecorridoPre(Nodo pNodo)
        {
            if (pNodo != null)
            {
                txtPre.Text += pNodo.Nombre+" - ";//acumulo para que lo pueda ver todo lindo
                RecorridoPre(pNodo.Izquierdo);
                RecorridoPre(pNodo.Derecho);
            }
        }
        public void RecorridoInOrder(Nodo pNodo)
        {
            if (pNodo != null)
            {
                RecorridoInOrder(pNodo.Izquierdo);
                txtPre.Text += pNodo.Nombre + " - ";//acumulo para que lo pueda ver to
                RecorridoInOrder(pNodo.Derecho);
            }
        }
        public void RecorridoPostOrder(Nodo pNodo)
        {
            if (pNodo != null)
            {
                RecorridoPostOrder(pNodo.Izquierdo);                
                RecorridoPostOrder(pNodo.Derecho);
                txtPre.Text += pNodo.Nombre + " - ";//acumulo para que lo pueda ver to
            }
        }

        public void MostrarTree(Nodo pNodo, TreeNode pTreeNode,TreeView pTreeeView)
        {
            if(pNodo!=null)
            {
                var NodoTemp = new TreeNode(pNodo.Nombre);
                if (pTreeNode == null)
                {
                    pTreeeView.Nodes.Add(NodoTemp);
                }
                else
                {
                    pTreeNode.Nodes.Add(NodoTemp);
                }
                MostrarTree(pNodo.Izquierdo, NodoTemp, pTreeeView);
                MostrarTree(pNodo.Derecho, NodoTemp, pTreeeView);
            }
        }

        private void btnPre_Click(object sender, EventArgs e)
        {
            txtPre.Clear();
            tvPre.Nodes.Clear();
            RecorridoPre(Raiz);
            MostrarTree(Raiz, null, tvPre);
            txtPre.Text = txtPre.Text.Substring(0, txtPre.TextLength - 2);//saco el -
            tvPre.ExpandAll();
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            txtIn.Clear();
            tvIn.Nodes.Clear();
            RecorridoInOrder(Raiz);
            MostrarTree(Raiz, null, tvIn);
            txtIn.Text = txtPre.Text.Substring(0, txtIn.TextLength - 2);//saco el -
            tvIn.ExpandAll();
        }

        private void btnPos_Click(object sender, EventArgs e)
        {
            txtPOs.Clear();
            tvPos.Nodes.Clear();
            RecorridoPre(Raiz);
            MostrarTree(Raiz, null, tvPos);
            txtPOs.Text = txtPre.Text.Substring(0, txtPOs.TextLength - 2);//saco el -
            tvPos.ExpandAll();
        }
    }
}
