using System.Windows.Forms;

namespace Lassalle
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripPanel2;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_Insert;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_Insert_Rectangle;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_Insert_Ellipse;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_Add;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_Add_Rectangle;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_Add_Ellipse;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_Del;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_Copy;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.contextMenuStripPanel2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MenuItem_Insert = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_Insert_Rectangle = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_Insert_Ellipse = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_Add_Rectangle = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_Add_Ellipse = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_Add = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_Del = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_Copy = new System.Windows.Forms.ToolStripMenuItem();
            this.addFlow1 = new Lassalle.Flow.AddFlow();
            this.panel2.SuspendLayout();
            this.contextMenuStripPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 97);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.addFlow1);
            this.panel2.Location = new System.Drawing.Point(12, 115);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(707, 618);
            this.panel2.TabIndex = 1;
            // 
            // contextMenuStripPanel2
            // 
            this.contextMenuStripPanel2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStripPanel2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItem_Insert,
            this.MenuItem_Add,
            this.MenuItem_Del,
            this.MenuItem_Copy});
            this.contextMenuStripPanel2.Name = "contextMenuStripPanel2";
            this.contextMenuStripPanel2.Size = new System.Drawing.Size(109, 100);
            // 
            // MenuItem_Insert
            // 
            this.MenuItem_Insert.Name = "MenuItem_Insert";
            this.MenuItem_Insert.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItem_Insert_Rectangle,
            MenuItem_Insert_Ellipse
            });
            this.MenuItem_Insert.Size = new System.Drawing.Size(108, 24);
            this.MenuItem_Insert.Text = "插入";
            // 
            // MenuItem_Add
            // 
            this.MenuItem_Insert_Rectangle.Name = "MenuItem_Insert_Rectangle";
            this.MenuItem_Insert_Rectangle.Size = new System.Drawing.Size(108, 24);
            this.MenuItem_Insert_Rectangle.Text = "Rectangle";
            this.MenuItem_Insert_Rectangle.Click += new System.EventHandler(this.Insert_Rectangle_Click);

            this.MenuItem_Insert_Ellipse.Name = "MenuItem_Insert_Rectangle";
            this.MenuItem_Insert_Ellipse.Size = new System.Drawing.Size(108, 24);
            this.MenuItem_Insert_Ellipse.Text = "Ellipse";
            this.MenuItem_Insert_Ellipse.Click += new System.EventHandler(this.Insert_Ellipse_Click);
            
            this.MenuItem_Insert_Ellipse.Name = "MenuItem_Insert_Rectangle";
            this.MenuItem_Insert_Ellipse.Size = new System.Drawing.Size(108, 24);
            this.MenuItem_Insert_Ellipse.Text = "Ellipse";
            this.MenuItem_Insert_Ellipse.Click += new System.EventHandler(this.Insert_Ellipse_Click);
            // 
            // MenuItem_Add
            // 
            this.MenuItem_Add.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItem_Add_Rectangle,
            MenuItem_Add_Ellipse
            });
            this.MenuItem_Add.Name = "MenuItem_Add";
            this.MenuItem_Add.Size = new System.Drawing.Size(108, 24);
            this.MenuItem_Add.Text = "新增"; 
            
            this.MenuItem_Add_Rectangle.Name = "MenuItem_Add_Rectangle";
            this.MenuItem_Add_Rectangle.Size = new System.Drawing.Size(108, 24);
            this.MenuItem_Add_Rectangle.Text = "Rectangle";
            this.MenuItem_Add_Rectangle.Click += new System.EventHandler(this.Add_Rectangle_Click);

            this.MenuItem_Add_Ellipse.Name = "MenuItem_Insert_Rectangle";
            this.MenuItem_Add_Ellipse.Size = new System.Drawing.Size(108, 24);
            this.MenuItem_Add_Ellipse.Text = "Ellipse";
            this.MenuItem_Add_Ellipse.Click += new System.EventHandler(this.Add_Ellipse_Click);
            // 
            // MenuItem_Del
            // 
            this.MenuItem_Del.Name = "MenuItem_Del";
            this.MenuItem_Del.Size = new System.Drawing.Size(108, 24);
            this.MenuItem_Del.Text = "刪除";
            this.MenuItem_Del.Click += new System.EventHandler(this.Del_Click);
            // 
            // MenuItem_Copy
            // 
            this.MenuItem_Copy.Name = "MenuItem_Copy";
            this.MenuItem_Copy.Size = new System.Drawing.Size(108, 24);
            this.MenuItem_Copy.Text = "複製";
            this.MenuItem_Copy.Click += new System.EventHandler(this.Copy_Click);
            // 
            // addFlow1
            // 
            this.addFlow1.CaptionModel.Dock = System.Windows.Forms.DockStyle.None;
            this.addFlow1.CaptionModel.FillColor = System.Drawing.Color.Transparent;
            this.addFlow1.CaptionModel.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.addFlow1.CaptionModel.GradientColor = System.Drawing.Color.Transparent;
            this.addFlow1.CaptionModel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.addFlow1.CaptionModel.IsCaptionsHilighted = false;
            this.addFlow1.CaptionModel.Location = ((System.Drawing.PointF)(resources.GetObject("resource.Location")));
            this.addFlow1.CaptionModel.ShadowSize = new System.Drawing.Size(10, 10);
            this.addFlow1.CaptionModel.Size = new System.Drawing.SizeF(0F, 0F);
            this.addFlow1.CaptionModel.Tag = null;
            this.addFlow1.CaptionModel.Thickness = 1F;
            this.addFlow1.CaptionModel.ZOrder = -1;
            this.addFlow1.LinkSelectionAreaWidth = 6F;
            this.addFlow1.Location = new System.Drawing.Point(255, 242);
            this.addFlow1.Name = "addFlow1";
            this.addFlow1.NodeModel.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.addFlow1.NodeModel.GradientColor = System.Drawing.SystemColors.Window;
            this.addFlow1.NodeModel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.addFlow1.NodeModel.Location = ((System.Drawing.PointF)(resources.GetObject("resource.Location1")));
            this.addFlow1.NodeModel.ShadowSize = new System.Drawing.Size(10, 10);
            this.addFlow1.NodeModel.ShapeFamily = Lassalle.Flow.ShapeFamily.Ellipse;
            this.addFlow1.NodeModel.Size = new System.Drawing.SizeF(0F, 0F);
            this.addFlow1.NodeModel.Tag = null;
            this.addFlow1.NodeModel.Thickness = 1F;
            this.addFlow1.NodeModel.ZOrder = -1;
            this.addFlow1.RemovePointDistance = 6F;
            this.addFlow1.Size = new System.Drawing.Size(150, 150);
            this.addFlow1.TabIndex = 0; 
            this.addFlow1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.addFlow1_MouseDown);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 745);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel2.ResumeLayout(false);
            this.contextMenuStripPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private Flow.AddFlow addFlow1;
    }
}

