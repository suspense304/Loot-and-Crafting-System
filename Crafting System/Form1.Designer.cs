namespace Crafting_System
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            lblItem1_Level = new Label();
            lblItem1_Armor_Damage = new Label();
            lblItem1_baseAffix_2 = new Label();
            lblItem1_baseAffix_1 = new Label();
            lblItem1_affixes = new Label();
            lblItem1 = new Label();
            btnCreate_Item_1 = new Button();
            btn_Create_Inventory = new Button();
            label1 = new Label();
            txtInventoryMax = new TextBox();
            btn_Combine_Items = new Button();
            lstInventory = new ListBox();
            txtLevel = new TextBox();
            label2 = new Label();
            button1 = new Button();
            lblInventoryCount = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(lblItem1_Level);
            panel1.Controls.Add(lblItem1_Armor_Damage);
            panel1.Controls.Add(lblItem1_baseAffix_2);
            panel1.Controls.Add(lblItem1_baseAffix_1);
            panel1.Controls.Add(lblItem1_affixes);
            panel1.Controls.Add(lblItem1);
            panel1.Location = new Point(29, 22);
            panel1.Name = "panel1";
            panel1.Size = new Size(338, 492);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // lblItem1_Level
            // 
            lblItem1_Level.BackColor = Color.Transparent;
            lblItem1_Level.Location = new Point(10, 444);
            lblItem1_Level.Name = "lblItem1_Level";
            lblItem1_Level.Size = new Size(303, 38);
            lblItem1_Level.TabIndex = 10;
            lblItem1_Level.Text = "label3";
            lblItem1_Level.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblItem1_Armor_Damage
            // 
            lblItem1_Armor_Damage.AutoSize = true;
            lblItem1_Armor_Damage.Location = new Point(24, 62);
            lblItem1_Armor_Damage.Name = "lblItem1_Armor_Damage";
            lblItem1_Armor_Damage.Size = new Size(0, 25);
            lblItem1_Armor_Damage.TabIndex = 9;
            lblItem1_Armor_Damage.Click += label3_Click;
            // 
            // lblItem1_baseAffix_2
            // 
            lblItem1_baseAffix_2.AutoSize = true;
            lblItem1_baseAffix_2.Location = new Point(24, 138);
            lblItem1_baseAffix_2.Name = "lblItem1_baseAffix_2";
            lblItem1_baseAffix_2.Size = new Size(36, 25);
            lblItem1_baseAffix_2.TabIndex = 8;
            lblItem1_baseAffix_2.Text = "sss";
            // 
            // lblItem1_baseAffix_1
            // 
            lblItem1_baseAffix_1.AutoSize = true;
            lblItem1_baseAffix_1.Location = new Point(24, 105);
            lblItem1_baseAffix_1.Name = "lblItem1_baseAffix_1";
            lblItem1_baseAffix_1.Size = new Size(36, 25);
            lblItem1_baseAffix_1.TabIndex = 7;
            lblItem1_baseAffix_1.Text = "sss";
            // 
            // lblItem1_affixes
            // 
            lblItem1_affixes.AutoSize = true;
            lblItem1_affixes.Location = new Point(24, 213);
            lblItem1_affixes.Name = "lblItem1_affixes";
            lblItem1_affixes.Size = new Size(0, 25);
            lblItem1_affixes.TabIndex = 1;
            // 
            // lblItem1
            // 
            lblItem1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblItem1.Location = new Point(24, 20);
            lblItem1.Name = "lblItem1";
            lblItem1.Size = new Size(289, 30);
            lblItem1.TabIndex = 0;
            lblItem1.Text = "Item 1";
            lblItem1.TextAlign = ContentAlignment.MiddleCenter;
            lblItem1.Click += lblItem1_Click;
            // 
            // btnCreate_Item_1
            // 
            btnCreate_Item_1.Location = new Point(39, 706);
            btnCreate_Item_1.Name = "btnCreate_Item_1";
            btnCreate_Item_1.Size = new Size(148, 34);
            btnCreate_Item_1.TabIndex = 9;
            btnCreate_Item_1.Text = "Create Item 1";
            btnCreate_Item_1.UseVisualStyleBackColor = true;
            btnCreate_Item_1.Click += btnCreate_Item_1_Click;
            // 
            // btn_Create_Inventory
            // 
            btn_Create_Inventory.Location = new Point(524, 607);
            btn_Create_Inventory.Name = "btn_Create_Inventory";
            btn_Create_Inventory.Size = new Size(173, 34);
            btn_Create_Inventory.TabIndex = 11;
            btn_Create_Inventory.Text = "Create Inventory";
            btn_Create_Inventory.UseVisualStyleBackColor = true;
            btn_Create_Inventory.Click += btn_Create_Inventory_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(383, 751);
            label1.Name = "label1";
            label1.Size = new Size(140, 25);
            label1.TabIndex = 12;
            label1.Text = "Inventory Items:";
            // 
            // txtInventoryMax
            // 
            txtInventoryMax.Location = new Point(524, 751);
            txtInventoryMax.Name = "txtInventoryMax";
            txtInventoryMax.Size = new Size(173, 31);
            txtInventoryMax.TabIndex = 13;
            // 
            // btn_Combine_Items
            // 
            btn_Combine_Items.Location = new Point(39, 786);
            btn_Combine_Items.Name = "btn_Combine_Items";
            btn_Combine_Items.Size = new Size(148, 34);
            btn_Combine_Items.TabIndex = 14;
            btn_Combine_Items.Text = "Combine";
            btn_Combine_Items.UseVisualStyleBackColor = true;
            // 
            // lstInventory
            // 
            lstInventory.FormattingEnabled = true;
            lstInventory.ItemHeight = 25;
            lstInventory.Location = new Point(717, 22);
            lstInventory.Name = "lstInventory";
            lstInventory.Size = new Size(516, 754);
            lstInventory.TabIndex = 15;
            // 
            // txtLevel
            // 
            txtLevel.Location = new Point(524, 789);
            txtLevel.Name = "txtLevel";
            txtLevel.Size = new Size(173, 31);
            txtLevel.TabIndex = 16;
            txtLevel.Text = "10";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(459, 791);
            label2.Name = "label2";
            label2.Size = new Size(51, 25);
            label2.TabIndex = 17;
            label2.Text = "Level";
            // 
            // button1
            // 
            button1.Location = new Point(524, 659);
            button1.Name = "button1";
            button1.Size = new Size(173, 34);
            button1.TabIndex = 18;
            button1.Text = "Clear Inventory";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lblInventoryCount
            // 
            lblInventoryCount.AutoSize = true;
            lblInventoryCount.Location = new Point(717, 795);
            lblInventoryCount.Name = "lblInventoryCount";
            lblInventoryCount.Size = new Size(0, 25);
            lblInventoryCount.TabIndex = 19;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1258, 1004);
            Controls.Add(lblInventoryCount);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(txtLevel);
            Controls.Add(lstInventory);
            Controls.Add(btn_Combine_Items);
            Controls.Add(txtInventoryMax);
            Controls.Add(label1);
            Controls.Add(btn_Create_Inventory);
            Controls.Add(btnCreate_Item_1);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label lblItem1_prefix_3;
        private Label lblItem1_prefix_2;
        private Label lblItem1_affixes;
        private Label lblItem1;
        private Label lblItem1_suffix_3;
        private Label lblItem1_suffix_2;
        private Label lblItem1_suffix_1;
        private Panel panel3;
        private Label lblItem3_suffix_3;
        private Label lblItem3_suffix_2;
        private Label lblItem3_suffix_1;
        private Label lblItem3_prefix_3;
        private Label lblItem3_prefix_2;
        private Label lblItem3_prefix_1;
        private Label lblItem3;
        private Button btnCreate_Item_1;
        private Button btn_Create_Inventory;
        private Label label1;
        private TextBox txtInventoryMax;
        private Button btn_Combine_Items;
        private ListBox lstInventory;
        private TextBox txtLevel;
        private Label label2;
        private Label lblItem1_baseAffix_2;
        private Label lblItem1_baseAffix_1;
        private Label lblItem1_Armor_Damage;
        private Label lblItem1_Level;
        private Button button1;
        private Label lblInventoryCount;
    }
}