namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.systemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disconnectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sECSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.addFlow2 = new Lassalle.Flow.AddFlow();
            this.addFlow1 = new Lassalle.Flow.AddFlow();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.s1F3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.systemToolStripMenuItem,
            this.sECSToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(760, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(47, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(130, 26);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(50, 24);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(128, 26);
            this.copyToolStripMenuItem.Text = "Copy";
            // 
            // systemToolStripMenuItem
            // 
            this.systemToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connentToolStripMenuItem,
            this.disconnectToolStripMenuItem});
            this.systemToolStripMenuItem.Name = "systemToolStripMenuItem";
            this.systemToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.systemToolStripMenuItem.Text = "System";
            // 
            // connentToolStripMenuItem
            // 
            this.connentToolStripMenuItem.Name = "connentToolStripMenuItem";
            this.connentToolStripMenuItem.Size = new System.Drawing.Size(168, 26);
            this.connentToolStripMenuItem.Text = "Start";
            this.connentToolStripMenuItem.Click += new System.EventHandler(this.connentToolStripMenuItem_Click);
            // 
            // disconnectToolStripMenuItem
            // 
            this.disconnectToolStripMenuItem.Name = "disconnectToolStripMenuItem";
            this.disconnectToolStripMenuItem.Size = new System.Drawing.Size(168, 26);
            this.disconnectToolStripMenuItem.Text = "Disconnect";
            this.disconnectToolStripMenuItem.Click += new System.EventHandler(this.disconnectToolStripMenuItem_Click);
            // 
            // sECSToolStripMenuItem
            // 
            this.sECSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sFToolStripMenuItem,
            this.s1F3ToolStripMenuItem});
            this.sECSToolStripMenuItem.Name = "sECSToolStripMenuItem";
            this.sECSToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.sECSToolStripMenuItem.Text = "SECS";
            // 
            // sFToolStripMenuItem
            // 
            this.sFToolStripMenuItem.Name = "sFToolStripMenuItem";
            this.sFToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.sFToolStripMenuItem.Text = "S1F1";
            this.sFToolStripMenuItem.Click += new System.EventHandler(this.sFToolStripMenuItem_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 28);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.propertyGrid1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(760, 408);
            this.splitContainer1.SplitterDistance = 259;
            this.splitContainer1.TabIndex = 1;
            // 
            // propertyGrid1
            // 
            this.propertyGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propertyGrid1.Location = new System.Drawing.Point(0, 0);
            this.propertyGrid1.Name = "propertyGrid1";
            this.propertyGrid1.Size = new System.Drawing.Size(259, 408);
            this.propertyGrid1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.addFlow2);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.addFlow1);
            this.splitContainer2.Size = new System.Drawing.Size(497, 408);
            this.splitContainer2.SplitterDistance = 90;
            this.splitContainer2.TabIndex = 1;
            // 
            // addFlow2
            // 
            this.addFlow2.CaptionModel.Dock = System.Windows.Forms.DockStyle.None;
            this.addFlow2.CaptionModel.FillColor = System.Drawing.Color.Transparent;
            this.addFlow2.CaptionModel.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.addFlow2.CaptionModel.GradientColor = System.Drawing.Color.Transparent;
            this.addFlow2.CaptionModel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.addFlow2.CaptionModel.IsCaptionsHilighted = false;
            this.addFlow2.CaptionModel.Location = ((System.Drawing.PointF)(resources.GetObject("resource.Location")));
            this.addFlow2.CaptionModel.ShadowSize = new System.Drawing.Size(10, 10);
            this.addFlow2.CaptionModel.Size = new System.Drawing.SizeF(0F, 0F);
            this.addFlow2.CaptionModel.Tag = null;
            this.addFlow2.CaptionModel.Thickness = 1F;
            this.addFlow2.CaptionModel.ZOrder = -1;
            this.addFlow2.LinkSelectionAreaWidth = 6F;
            this.addFlow2.Location = new System.Drawing.Point(3, 3);
            this.addFlow2.Name = "addFlow2";
            this.addFlow2.NodeModel.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.addFlow2.NodeModel.GradientColor = System.Drawing.SystemColors.Window;
            this.addFlow2.NodeModel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.addFlow2.NodeModel.Location = ((System.Drawing.PointF)(resources.GetObject("resource.Location1")));
            this.addFlow2.NodeModel.ShadowSize = new System.Drawing.Size(10, 10);
            this.addFlow2.NodeModel.ShapeFamily = Lassalle.Flow.ShapeFamily.Ellipse;
            this.addFlow2.NodeModel.Size = new System.Drawing.SizeF(0F, 0F);
            this.addFlow2.NodeModel.Tag = null;
            this.addFlow2.NodeModel.Thickness = 1F;
            this.addFlow2.NodeModel.ZOrder = -1;
            this.addFlow2.RemovePointDistance = 6F;
            this.addFlow2.Size = new System.Drawing.Size(601, 99);
            this.addFlow2.TabIndex = 0;
            // 
            // addFlow1
            // 
            this.addFlow1.AllowDrop = true;
            this.addFlow1.CaptionModel.Dock = System.Windows.Forms.DockStyle.None;
            this.addFlow1.CaptionModel.FillColor = System.Drawing.Color.Transparent;
            this.addFlow1.CaptionModel.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.addFlow1.CaptionModel.GradientColor = System.Drawing.Color.Transparent;
            this.addFlow1.CaptionModel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.addFlow1.CaptionModel.IsCaptionsHilighted = false;
            this.addFlow1.CaptionModel.Location = ((System.Drawing.PointF)(resources.GetObject("resource.Location2")));
            this.addFlow1.CaptionModel.ShadowSize = new System.Drawing.Size(10, 10);
            this.addFlow1.CaptionModel.Size = new System.Drawing.SizeF(0F, 0F);
            this.addFlow1.CaptionModel.Tag = null;
            this.addFlow1.CaptionModel.Thickness = 1F;
            this.addFlow1.CaptionModel.ZOrder = -1;
            this.addFlow1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addFlow1.LinkSelectionAreaWidth = 6F;
            this.addFlow1.Location = new System.Drawing.Point(0, 0);
            this.addFlow1.Margin = new System.Windows.Forms.Padding(10);
            this.addFlow1.Name = "addFlow1";
            this.addFlow1.NodeModel.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.addFlow1.NodeModel.GradientColor = System.Drawing.SystemColors.Window;
            this.addFlow1.NodeModel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.addFlow1.NodeModel.Location = ((System.Drawing.PointF)(resources.GetObject("resource.Location3")));
            this.addFlow1.NodeModel.ShadowSize = new System.Drawing.Size(10, 10);
            this.addFlow1.NodeModel.ShapeFamily = Lassalle.Flow.ShapeFamily.Ellipse;
            this.addFlow1.NodeModel.Size = new System.Drawing.SizeF(0F, 0F);
            this.addFlow1.NodeModel.Tag = null;
            this.addFlow1.NodeModel.Thickness = 1F;
            this.addFlow1.NodeModel.ZOrder = -1;
            this.addFlow1.RemovePointDistance = 6F;
            this.addFlow1.Size = new System.Drawing.Size(497, 314);
            this.addFlow1.TabIndex = 0;
            this.addFlow1.DragDrop += new System.Windows.Forms.DragEventHandler(this.toolsListBox_DragDrop);
            this.addFlow1.DragEnter += new System.Windows.Forms.DragEventHandler(this.toolsListBox2_DragEnter);
            this.addFlow1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Delete_KeyDown);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // s1F3ToolStripMenuItem
            // 
            this.s1F3ToolStripMenuItem.Name = "s1F3ToolStripMenuItem";
            this.s1F3ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.s1F3ToolStripMenuItem.Text = "S1F3";
            this.s1F3ToolStripMenuItem.Click += new System.EventHandler(this.s1F3ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 436);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private Lassalle.Flow.AddFlow addFlow1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private Lassalle.Flow.AddFlow addFlow2;
        private System.Windows.Forms.PropertyGrid propertyGrid1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem systemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sECSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disconnectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem s1F3ToolStripMenuItem;
    }
}

