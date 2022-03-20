
namespace Hamburger_Restaurant
{
    partial class Form1
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
            this.orderManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orderInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addHamburgerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addHamburgerToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.addExtraMaterialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.orderManagementToolStripMenuItem,
            this.addHamburgerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // orderManagementToolStripMenuItem
            // 
            this.orderManagementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createOrderToolStripMenuItem,
            this.orderInformationToolStripMenuItem});
            this.orderManagementToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.orderManagementToolStripMenuItem.Name = "orderManagementToolStripMenuItem";
            this.orderManagementToolStripMenuItem.Size = new System.Drawing.Size(158, 24);
            this.orderManagementToolStripMenuItem.Text = "Order Management";
            // 
            // createOrderToolStripMenuItem
            // 
            this.createOrderToolStripMenuItem.Name = "createOrderToolStripMenuItem";
            this.createOrderToolStripMenuItem.Size = new System.Drawing.Size(207, 24);
            this.createOrderToolStripMenuItem.Text = "Create Order";
            this.createOrderToolStripMenuItem.Click += new System.EventHandler(this.createOrderToolStripMenuItem_Click);
            // 
            // orderInformationToolStripMenuItem
            // 
            this.orderInformationToolStripMenuItem.Name = "orderInformationToolStripMenuItem";
            this.orderInformationToolStripMenuItem.Size = new System.Drawing.Size(207, 24);
            this.orderInformationToolStripMenuItem.Text = "Order Information";
            this.orderInformationToolStripMenuItem.Click += new System.EventHandler(this.orderInformationToolStripMenuItem_Click);
            // 
            // addHamburgerToolStripMenuItem
            // 
            this.addHamburgerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addHamburgerToolStripMenuItem1,
            this.addExtraMaterialToolStripMenuItem});
            this.addHamburgerToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.addHamburgerToolStripMenuItem.Name = "addHamburgerToolStripMenuItem";
            this.addHamburgerToolStripMenuItem.Size = new System.Drawing.Size(173, 24);
            this.addHamburgerToolStripMenuItem.Text = "Product management";
            // 
            // addHamburgerToolStripMenuItem1
            // 
            this.addHamburgerToolStripMenuItem1.Name = "addHamburgerToolStripMenuItem1";
            this.addHamburgerToolStripMenuItem1.Size = new System.Drawing.Size(209, 24);
            this.addHamburgerToolStripMenuItem1.Text = "Add Hamburger";
            this.addHamburgerToolStripMenuItem1.Click += new System.EventHandler(this.addHamburgerToolStripMenuItem1_Click);
            // 
            // addExtraMaterialToolStripMenuItem
            // 
            this.addExtraMaterialToolStripMenuItem.Name = "addExtraMaterialToolStripMenuItem";
            this.addExtraMaterialToolStripMenuItem.Size = new System.Drawing.Size(209, 24);
            this.addExtraMaterialToolStripMenuItem.Text = "Add Extra Material";
            this.addExtraMaterialToolStripMenuItem.Click += new System.EventHandler(this.addExtraMaterialToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem orderManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orderInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addHamburgerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addHamburgerToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem addExtraMaterialToolStripMenuItem;
    }
}

