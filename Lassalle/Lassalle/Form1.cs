using Lassalle.Flow;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using QSACTIVEXLib;

namespace Lassalle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent(); Form1_test();

            this.KeyDown += new KeyEventHandler(Form1_KeyDown);
            this.addFlow1.Dock = DockStyle.Fill;
            this.addFlow1.AutoScroll = true;
            this.addFlow1.BackColor = SystemColors.Window;
            this.addFlow1.PageUnit = GraphicsUnit.Pixel;
            Node node1 = new Node(50, 50, 80, 80, "", this.addFlow1);
            Node node2 = new Node(160, 160, 80, 80, "", this.addFlow1);
            this.addFlow1.AddNode(node1);
            this.addFlow1.AddNode(node2);
            AddLink(this.addFlow1, node1, node2); 
            this.KeyPress += new KeyPressEventHandler(MainForm_KeyPress);
        }
        private void Form1_test()
        {
            if ((SECSII_DATA_TYPE)165 == SECSII_DATA_TYPE.UINT_1_TYPE)
            {
                MessageBox.Show("TEST");
            }
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.C && ModifierKeys == Keys.Control)
            {
                MessageBox.Show("You pressed Ctrl+C");
                // 在這裡執行你想要的動作
            }
            // 在這裡處理按鍵事件
        }
        private void MainForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            // 按下 Ctrl + C
            if (e.KeyChar == (char)3 && ModifierKeys == Keys.Control)
            {
                MessageBox.Show("You pressed Ctrl+C");
                // 在這裡執行你想要的動作
            }
            // 按下 Delete
            else if (e.KeyChar == (char)8)
            {
                MessageBox.Show("You pressed Delete");
                // 在這裡執行你想要的動作
            }
        }
        private void addFlow1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                this.contextMenuStripPanel2.Show(this.addFlow1, e.Location);
            }
        }
        private void Insert_Rectangle_Click(object sender, EventArgs e)
        {
            Node node1 = new Node(50, 50, 80, 80, "", addFlow1);
            node1.ShapeFamily = ShapeFamily.Rectangle;
            CreateNode(this.addFlow1,node1);
        }
        private void Insert_Ellipse_Click(object sender, EventArgs e)
        {
            Node node1 = new Node(50, 50, 80, 80, "", addFlow1);
            node1.ShapeFamily = ShapeFamily.Ellipse;
            CreateNode(this.addFlow1, node1);
        }
        private void Insert_Link_Click(object sender, EventArgs e)
        {
            AddLink(this.addFlow1, null, null);
        }
        private void Add_Rectangle_Click(object sender, EventArgs e)
        {
            Node node1 = new Node(50, 50, 80, 80, "", addFlow1);
            node1.ShapeFamily = ShapeFamily.Rectangle;
            CreateNode(this.addFlow1,node1);
        }
        private void Add_Ellipse_Click(object sender, EventArgs e)
        {
            Node node1 = new Node(50, 50, 80, 80, "", addFlow1);
            node1.ShapeFamily = ShapeFamily.Ellipse;
            CreateNode(this.addFlow1, node1);
        }
        private void MenuItemEditDelete_Click(object sender, EventArgs e)
        {
            addFlow1.IsSelectionChangeEventFired = false;
            addFlow1.DeleteSel();
            addFlow1.IsSelectionChangeEventFired = true;
        }
        private void MenuItemEditCut_Click(object sender, EventArgs e)
        {
            MenuItemEditCopy_Click(sender, e);
            MenuItemEditDelete_Click(sender, e);
        }
        private void MenuItemEditCopy_Click(object sender, EventArgs e)
        {
            Copy_Click( sender,  e);
        }
        private void Del_Click(object sender, EventArgs e)
        {
            var selnodes = this.addFlow1.SelectedItems.OfType<Node>().ToArray();
            if (selnodes.Length > 0)
                addFlow1.DeleteSel();
            else
                MessageBox.Show("Please Select Object!");
        }
        private void Copy_Click(object sender, EventArgs e)
        {
            var selnodes = this.addFlow1.SelectedItems.OfType<Node>().ToArray();
            if(selnodes.Length > 0)
                for(int i=0;i<selnodes.Count();i++)
                {
                    CopyNode(addFlow1, selnodes[i]);   
                }
            else
                MessageBox.Show("Please Select Object!");
        }
        private void CreateNode(AddFlow addflow,Node node)
        {
            addflow.AddNode(node);
        }
        private void AddLink(AddFlow addflow, Node org, Node dst)
        {
            Link link = new Link(org, dst, null, addflow);
            addflow.AddLink(link);
        }
        
        private void CopyNode(AddFlow addflow,Node node)
        {
            Node node1 = new Node(node.Location.X+10, node.Location.Y+10, node.Size.Width, node.Size.Height, node.Text, addflow);
            node1.ShapeFamily = node.ShapeFamily;
            addflow.AddNode(node1);
        }
    }
}
