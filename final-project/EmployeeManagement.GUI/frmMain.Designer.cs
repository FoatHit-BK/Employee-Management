namespace EmployeeManagement.GUI
{
    partial class frmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.categoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.positionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.departmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageRecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.declareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sysToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configSystemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageFunctionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.categoryToolStripMenuItem,
            this.manageRecordToolStripMenuItem,
            this.sysToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 29);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // categoryToolStripMenuItem
            // 
            this.categoryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.positionToolStripMenuItem,
            this.departmentToolStripMenuItem});
            this.categoryToolStripMenuItem.Name = "categoryToolStripMenuItem";
            this.categoryToolStripMenuItem.Size = new System.Drawing.Size(85, 25);
            this.categoryToolStripMenuItem.Text = "Category";
            // 
            // positionToolStripMenuItem
            // 
            this.positionToolStripMenuItem.Name = "positionToolStripMenuItem";
            this.positionToolStripMenuItem.Size = new System.Drawing.Size(163, 26);
            this.positionToolStripMenuItem.Text = "Position";
            // 
            // departmentToolStripMenuItem
            // 
            this.departmentToolStripMenuItem.Name = "departmentToolStripMenuItem";
            this.departmentToolStripMenuItem.Size = new System.Drawing.Size(163, 26);
            this.departmentToolStripMenuItem.Text = "Department";
            // 
            // manageRecordToolStripMenuItem
            // 
            this.manageRecordToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.declareToolStripMenuItem});
            this.manageRecordToolStripMenuItem.Name = "manageRecordToolStripMenuItem";
            this.manageRecordToolStripMenuItem.Size = new System.Drawing.Size(131, 25);
            this.manageRecordToolStripMenuItem.Text = "Manage Record";
            // 
            // declareToolStripMenuItem
            // 
            this.declareToolStripMenuItem.Name = "declareToolStripMenuItem";
            this.declareToolStripMenuItem.Size = new System.Drawing.Size(132, 26);
            this.declareToolStripMenuItem.Text = "Declare";
            // 
            // sysToolStripMenuItem
            // 
            this.sysToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configSystemToolStripMenuItem,
            this.manageAccountToolStripMenuItem,
            this.manageFunctionToolStripMenuItem});
            this.sysToolStripMenuItem.Name = "sysToolStripMenuItem";
            this.sysToolStripMenuItem.Size = new System.Drawing.Size(133, 25);
            this.sysToolStripMenuItem.Text = "Manage System";
            // 
            // configSystemToolStripMenuItem
            // 
            this.configSystemToolStripMenuItem.Name = "configSystemToolStripMenuItem";
            this.configSystemToolStripMenuItem.Size = new System.Drawing.Size(197, 26);
            this.configSystemToolStripMenuItem.Text = "Config System";
            // 
            // manageAccountToolStripMenuItem
            // 
            this.manageAccountToolStripMenuItem.Name = "manageAccountToolStripMenuItem";
            this.manageAccountToolStripMenuItem.Size = new System.Drawing.Size(197, 26);
            this.manageAccountToolStripMenuItem.Text = "Manage Account";
            // 
            // manageFunctionToolStripMenuItem
            // 
            this.manageFunctionToolStripMenuItem.Name = "manageFunctionToolStripMenuItem";
            this.manageFunctionToolStripMenuItem.Size = new System.Drawing.Size(197, 26);
            this.manageFunctionToolStripMenuItem.Text = "Manage function";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMain";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem categoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem positionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem departmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageRecordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem declareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sysToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configSystemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageFunctionToolStripMenuItem;
    }
}