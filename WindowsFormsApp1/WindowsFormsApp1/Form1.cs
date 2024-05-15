using Lassalle.Flow;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Printing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using QSACTIVEXLib;
namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private QSECS QS = new QSECS();
        private Node draggedNode;
        private QSWrapper comQSWrapper = new QSWrapper();

        public Form1()
        {
            InitializeComponent();
            InitializeContextMenu();

            CreateDiagram(this.addFlow1);
            CreateDiagram(this.addFlow2,false);
            NodeToolBoxInit(this.addFlow2);

            propertyGrid1.SelectedObject = this.addFlow1;
            propertyGrid1.CommandsVisibleIfAvailable = true;
        }
        private void NodeToolBoxInit(AddFlow addflow)
        {
            uint width = 90;
            uint height = 70;
            uint margin = 30;
            uint locationX = 5;
            AddNode(addflow, locationX, 10, width, height, ShapeFamily.Rectangle, "Tool 1");
            AddNode(addflow, locationX += margin + width, 10, width, height, ShapeFamily.Ellipse, "Tool 2");
        }
        
        private void InitializeContextMenu()
        {
            ToolStripMenuItem Btn_Copy = new ToolStripMenuItem("Copy");
            Btn_Copy.Click += Btn_Copy_Click;
            contextMenuStrip1.Items.Add(Btn_Copy);

            ToolStripMenuItem Btn_Delete = new ToolStripMenuItem("Delete");
            Btn_Delete.Click += Btn_Delete_Click;
            contextMenuStrip1.Items.Add(Btn_Delete);

            this.ContextMenuStrip = contextMenuStrip1;
        }
        private void Btn_Copy_Click(object sender, EventArgs e)
        {
            List<Item> nodes = this.addFlow1.SelectedItems;
            
            if (nodes != null)
            {
                foreach (Node node in nodes)
                {
                    AddNode(this.addFlow1, node.Location.X+10, node.Location.Y+10, node.Size.Width, node.Size.Height, node.ShapeFamily);
                }
            }
        }
        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            addFlow1.DeleteSel();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Node[] nodes = this.addFlow1.Items.OfType<Node>().ToArray();
        }

        private void CreateDiagram(AddFlow addflow,Boolean flag = true)
        {
            addflow.Dock = DockStyle.Fill;
            addflow.NodeModel.Font = new System.Drawing.Font("Arial", (float)7.0, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, (Byte)0);
            addflow.NodeModel.FillColor = Color.LightYellow;
            addflow.NodeModel.ShadowColor = Color.Silver;
            addflow.CaptionModel.DrawColor = Color.Blue;
            addflow.BackColor = SystemColors.Window;

            if (flag)
            {
                addflow.AutoScroll = true;
                addflow.PageUnit = GraphicsUnit.Point;
                addflow.GridDraw = true;
                addflow.GridSnap = true;
                addflow.GridStyle = GridStyle.DottedLines;
                addflow.GridColor = Color.Silver;
                //addflow.GridSize = new Size(10, 10);
                addflow.DragEnter += AddFlow2_DragEnter;
            }
            else
            {
                addflow.AutoScroll = true;
                addflow.CanShowJumps = true;
                addflow.CanMoveItems = false;
                addflow.CanDrawLink = false;
                addflow.CanDrawNode = false;
                addflow.CanSizeItems = false;
                addflow.CanMultiSelect = false;
                addflow.CanEditContentItem = false;

                addflow.IsSelectionHandleDisplayed = false;
                addflow.NodeModel.ShadowStyle = ShadowStyle.RightBottom;
                addflow.SelectionChange += addflow_SelectionChange;
                addflow.MouseDown += AddFlow2_MouseDown;
            }
        }
        Node AddNode(AddFlow addflow, float left, float top, float width, float height, ShapeFamily shape = ShapeFamily.Rectangle,string text=null)
        {
            Node node = new Node(left, top, width, height, text, addflow);
            node.ShapeFamily = shape;
            addflow.AddNode(node);
            return node;
        }
        Link AddLink(AddFlow addflow, Node org, Node dst)
        {
            Link link = new Link(org, dst, null, addflow);
            addflow.AddLink(link);
            return link;
        }
        private void toolsListBox2_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }
        private void AddFlow2_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Node)))
            {
                e.Effect = DragDropEffects.Move;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }
        private void toolsListBox_DragDrop(object sender, DragEventArgs e)
        {
            Point ptClient = this.addFlow1.PointToClient(new Point(e.X, e.Y));
            Point ptAddFlow = this.addFlow1.PointToAddFlow(ptClient);

            Node node = (Node)e.Data.GetData(typeof(Node));
            if (node != null)
            {
                Point clientPoint = addFlow2.PointToClient(new Point(e.X, e.Y));
                AddNode(this.addFlow1, ptAddFlow.X, ptAddFlow.Y, 50, 50, node.ShapeFamily);
            }
        }
        private void AddFlow2_MouseDown(object sender, MouseEventArgs e)
        {
            if(addFlow2.SelectedItems.Count > 0)
            {
                Item item = addFlow2.SelectedItems[0];
                if (item != null)
                {
                    if (item is Node)
                    {
                        Node node = (Node)item;
                        draggedNode = node;
                        addFlow2.DoDragDrop(node, DragDropEffects.Move);
                    }
                }
            }
        }
        //----------------------
        //KeyControl
        //----------------------
        private void Delete_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                addFlow1.DeleteSel();
            }
        }

        void addflow_SelectionChange(object sender, SelectionChangeArgs e)
        {

            var nodes = this.addFlow2.Items.OfType<Node>().ToArray();
            foreach (Node node in nodes)
            {
                if (node.IsSelected)
                {
                    node.DrawColor = Color.Red;
                    node.Thickness = 3;
                }
                else
                {
                    node.DrawColor = this.addFlow2.NodeModel.DrawColor;
                    node.Thickness = this.addFlow2.NodeModel.Thickness;
                }
            }
        }
        
        private void connentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QS.Connection();
        }
        private void sFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QS.sendS1F1();
        }

        private void disconnectToolStripMenuItem_Click(object sender, EventArgs e)
        {
           QS.Disconnection();
        }

        private void s1F3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QS.sendS1F3();
        }
    }
}
