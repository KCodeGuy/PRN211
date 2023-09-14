namespace CoffeeShopSorfware
{
    partial class MainLayout
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
            this.containerPanel = new System.Windows.Forms.Panel();
            this.payingPanel = new System.Windows.Forms.Panel();
            this.changeTableBox = new System.Windows.Forms.ComboBox();
            this.btnChangeTable = new System.Windows.Forms.Button();
            this.btnPaying = new System.Windows.Forms.Button();
            this.orderPanel = new System.Windows.Forms.Panel();
            this.addFoodPanel = new System.Windows.Forms.Panel();
            this.btnAddFood = new System.Windows.Forms.Button();
            this.quantity = new System.Windows.Forms.NumericUpDown();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.foodBox = new System.Windows.Forms.ComboBox();
            this.foodLabel = new System.Windows.Forms.Label();
            this.cateloryBox = new System.Windows.Forms.ComboBox();
            this.foodCateLabel = new System.Windows.Forms.Label();
            this.tableListPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.admindToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.persionalInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yourProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logouToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.containerPanel.SuspendLayout();
            this.payingPanel.SuspendLayout();
            this.addFoodPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quantity)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // containerPanel
            // 
            this.containerPanel.Controls.Add(this.payingPanel);
            this.containerPanel.Controls.Add(this.orderPanel);
            this.containerPanel.Controls.Add(this.addFoodPanel);
            this.containerPanel.Controls.Add(this.tableListPanel);
            this.containerPanel.Controls.Add(this.menuStrip1);
            this.containerPanel.Location = new System.Drawing.Point(27, 12);
            this.containerPanel.Name = "containerPanel";
            this.containerPanel.Size = new System.Drawing.Size(924, 614);
            this.containerPanel.TabIndex = 0;
            // 
            // payingPanel
            // 
            this.payingPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.payingPanel.Controls.Add(this.changeTableBox);
            this.payingPanel.Controls.Add(this.btnChangeTable);
            this.payingPanel.Controls.Add(this.btnPaying);
            this.payingPanel.Location = new System.Drawing.Point(596, 513);
            this.payingPanel.Name = "payingPanel";
            this.payingPanel.Size = new System.Drawing.Size(328, 88);
            this.payingPanel.TabIndex = 4;
            // 
            // changeTableBox
            // 
            this.changeTableBox.FormattingEnabled = true;
            this.changeTableBox.Location = new System.Drawing.Point(11, 49);
            this.changeTableBox.Name = "changeTableBox";
            this.changeTableBox.Size = new System.Drawing.Size(151, 28);
            this.changeTableBox.TabIndex = 8;
            // 
            // btnChangeTable
            // 
            this.btnChangeTable.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnChangeTable.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnChangeTable.Location = new System.Drawing.Point(11, 14);
            this.btnChangeTable.Name = "btnChangeTable";
            this.btnChangeTable.Size = new System.Drawing.Size(151, 30);
            this.btnChangeTable.TabIndex = 7;
            this.btnChangeTable.Text = "Change Table";
            this.btnChangeTable.UseVisualStyleBackColor = true;
            // 
            // btnPaying
            // 
            this.btnPaying.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPaying.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPaying.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnPaying.Location = new System.Drawing.Point(172, 14);
            this.btnPaying.Name = "btnPaying";
            this.btnPaying.Size = new System.Drawing.Size(135, 63);
            this.btnPaying.TabIndex = 6;
            this.btnPaying.Text = "Paying";
            this.btnPaying.UseVisualStyleBackColor = true;
            // 
            // orderPanel
            // 
            this.orderPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.orderPanel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.orderPanel.Location = new System.Drawing.Point(592, 222);
            this.orderPanel.Name = "orderPanel";
            this.orderPanel.Size = new System.Drawing.Size(329, 274);
            this.orderPanel.TabIndex = 3;
            // 
            // addFoodPanel
            // 
            this.addFoodPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addFoodPanel.Controls.Add(this.btnAddFood);
            this.addFoodPanel.Controls.Add(this.quantity);
            this.addFoodPanel.Controls.Add(this.quantityLabel);
            this.addFoodPanel.Controls.Add(this.foodBox);
            this.addFoodPanel.Controls.Add(this.foodLabel);
            this.addFoodPanel.Controls.Add(this.cateloryBox);
            this.addFoodPanel.Controls.Add(this.foodCateLabel);
            this.addFoodPanel.Location = new System.Drawing.Point(592, 43);
            this.addFoodPanel.Name = "addFoodPanel";
            this.addFoodPanel.Size = new System.Drawing.Size(329, 163);
            this.addFoodPanel.TabIndex = 2;
            // 
            // btnAddFood
            // 
            this.btnAddFood.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddFood.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddFood.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnAddFood.Location = new System.Drawing.Point(176, 89);
            this.btnAddFood.Name = "btnAddFood";
            this.btnAddFood.Size = new System.Drawing.Size(135, 63);
            this.btnAddFood.TabIndex = 0;
            this.btnAddFood.Text = "Add food";
            this.btnAddFood.UseVisualStyleBackColor = true;
            // 
            // quantity
            // 
            this.quantity.Location = new System.Drawing.Point(96, 104);
            this.quantity.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.quantity.Name = "quantity";
            this.quantity.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.quantity.Size = new System.Drawing.Size(58, 27);
            this.quantity.TabIndex = 5;
            this.quantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.quantityLabel.Location = new System.Drawing.Point(14, 106);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(74, 20);
            this.quantityLabel.TabIndex = 4;
            this.quantityLabel.Text = "Quantity:";
            // 
            // foodBox
            // 
            this.foodBox.FormattingEnabled = true;
            this.foodBox.Location = new System.Drawing.Point(96, 49);
            this.foodBox.Name = "foodBox";
            this.foodBox.Size = new System.Drawing.Size(215, 28);
            this.foodBox.TabIndex = 3;
            // 
            // foodLabel
            // 
            this.foodLabel.AutoSize = true;
            this.foodLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.foodLabel.Location = new System.Drawing.Point(14, 57);
            this.foodLabel.Name = "foodLabel";
            this.foodLabel.Size = new System.Drawing.Size(48, 20);
            this.foodLabel.TabIndex = 2;
            this.foodLabel.Text = "Food:";
            // 
            // cateloryBox
            // 
            this.cateloryBox.FormattingEnabled = true;
            this.cateloryBox.Location = new System.Drawing.Point(96, 15);
            this.cateloryBox.Name = "cateloryBox";
            this.cateloryBox.Size = new System.Drawing.Size(215, 28);
            this.cateloryBox.TabIndex = 1;
            // 
            // foodCateLabel
            // 
            this.foodCateLabel.AutoSize = true;
            this.foodCateLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.foodCateLabel.Location = new System.Drawing.Point(14, 17);
            this.foodCateLabel.Name = "foodCateLabel";
            this.foodCateLabel.Size = new System.Drawing.Size(81, 20);
            this.foodCateLabel.TabIndex = 0;
            this.foodCateLabel.Text = "Catelogry:";
            // 
            // tableListPanel
            // 
            this.tableListPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tableListPanel.Location = new System.Drawing.Point(3, 45);
            this.tableListPanel.Name = "tableListPanel";
            this.tableListPanel.Size = new System.Drawing.Size(571, 556);
            this.tableListPanel.TabIndex = 0;
            this.tableListPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.tableListPanel_Paint);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.admindToolStripMenuItem,
            this.persionalInformationToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(924, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // admindToolStripMenuItem
            // 
            this.admindToolStripMenuItem.Name = "admindToolStripMenuItem";
            this.admindToolStripMenuItem.Size = new System.Drawing.Size(14, 24);
            // 
            // persionalInformationToolStripMenuItem
            // 
            this.persionalInformationToolStripMenuItem.Name = "persionalInformationToolStripMenuItem";
            this.persionalInformationToolStripMenuItem.Size = new System.Drawing.Size(14, 24);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // yourProfileToolStripMenuItem
            // 
            this.yourProfileToolStripMenuItem.Name = "yourProfileToolStripMenuItem";
            this.yourProfileToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // logouToolStripMenuItem
            // 
            this.logouToolStripMenuItem.Name = "logouToolStripMenuItem";
            this.logouToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
            this.logouToolStripMenuItem.Text = "Logout";
            this.logouToolStripMenuItem.Click += new System.EventHandler(this.logouToolStripMenuItem_Click);
            // 
            // MainLayout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 638);
            this.Controls.Add(this.containerPanel);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainLayout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main_Layout";
            this.containerPanel.ResumeLayout(false);
            this.containerPanel.PerformLayout();
            this.payingPanel.ResumeLayout(false);
            this.addFoodPanel.ResumeLayout(false);
            this.addFoodPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quantity)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel containerPanel;
        private System.Windows.Forms.FlowLayoutPanel tableListPanel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem admindToolStripMenuItem;
        private System.Windows.Forms.Panel addFoodPanel;
        private System.Windows.Forms.ToolStripMenuItem persionalInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yourProfileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logouToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Panel payingPanel;
        private System.Windows.Forms.Panel orderPanel;
        private System.Windows.Forms.Label foodCateLabel;
        private System.Windows.Forms.Label foodLabel;
        private System.Windows.Forms.ComboBox cateloryBox;
        private System.Windows.Forms.ComboBox changeTableBox;
        private System.Windows.Forms.Button btnChangeTable;
        private System.Windows.Forms.Button btnPaying;
        private System.Windows.Forms.Button btnAddFood;
        private System.Windows.Forms.NumericUpDown quantity;
        private System.Windows.Forms.Label quantityLabel;
        private System.Windows.Forms.ComboBox foodBox;
    }
}