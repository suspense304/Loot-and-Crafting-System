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
            lblItem1_suffix_3 = new Label();
            lblItem1_suffix_2 = new Label();
            lblItem1_suffix_1 = new Label();
            lblItem1_prefix_3 = new Label();
            lblItem1_prefix_2 = new Label();
            lblItem1_prefix_1 = new Label();
            lblItem1 = new Label();
            panel2 = new Panel();
            lblItem2_Level = new Label();
            lblItem2_Armor_Damage = new Label();
            lblItem2_baseAffix_2 = new Label();
            lblItem2_suffix_3 = new Label();
            lblItem2_baseAffix_1 = new Label();
            lblItem2_suffix_2 = new Label();
            lblItem2_suffix_1 = new Label();
            lblItem2_prefix_3 = new Label();
            lblItem2_prefix_2 = new Label();
            lblItem2_prefix_1 = new Label();
            lblItem2 = new Label();
            btnCreate_Item_1 = new Button();
            btnCreate_Item_2 = new Button();
            btn_Create_Inventory = new Button();
            label1 = new Label();
            txtInventoryMax = new TextBox();
            btn_Combine_Items = new Button();
            lstInventory = new ListBox();
            txtLevel = new TextBox();
            label2 = new Label();
            button1 = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(lblItem1_Level);
            panel1.Controls.Add(lblItem1_Armor_Damage);
            panel1.Controls.Add(lblItem1_baseAffix_2);
            panel1.Controls.Add(lblItem1_baseAffix_1);
            panel1.Controls.Add(lblItem1_suffix_3);
            panel1.Controls.Add(lblItem1_suffix_2);
            panel1.Controls.Add(lblItem1_suffix_1);
            panel1.Controls.Add(lblItem1_prefix_3);
            panel1.Controls.Add(lblItem1_prefix_2);
            panel1.Controls.Add(lblItem1_prefix_1);
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
            // lblItem1_suffix_3
            // 
            lblItem1_suffix_3.AutoSize = true;
            lblItem1_suffix_3.Location = new Point(24, 389);
            lblItem1_suffix_3.Name = "lblItem1_suffix_3";
            lblItem1_suffix_3.Size = new Size(71, 25);
            lblItem1_suffix_3.TabIndex = 6;
            lblItem1_suffix_3.Text = "Suffix 3";
            // 
            // lblItem1_suffix_2
            // 
            lblItem1_suffix_2.AutoSize = true;
            lblItem1_suffix_2.Location = new Point(24, 354);
            lblItem1_suffix_2.Name = "lblItem1_suffix_2";
            lblItem1_suffix_2.Size = new Size(71, 25);
            lblItem1_suffix_2.TabIndex = 5;
            lblItem1_suffix_2.Text = "Suffix 2";
            // 
            // lblItem1_suffix_1
            // 
            lblItem1_suffix_1.AutoSize = true;
            lblItem1_suffix_1.Location = new Point(24, 319);
            lblItem1_suffix_1.Name = "lblItem1_suffix_1";
            lblItem1_suffix_1.Size = new Size(71, 25);
            lblItem1_suffix_1.TabIndex = 4;
            lblItem1_suffix_1.Text = "Suffix 1";
            // 
            // lblItem1_prefix_3
            // 
            lblItem1_prefix_3.AutoSize = true;
            lblItem1_prefix_3.Location = new Point(24, 283);
            lblItem1_prefix_3.Name = "lblItem1_prefix_3";
            lblItem1_prefix_3.Size = new Size(70, 25);
            lblItem1_prefix_3.TabIndex = 3;
            lblItem1_prefix_3.Text = "Prefix 3";
            // 
            // lblItem1_prefix_2
            // 
            lblItem1_prefix_2.AutoSize = true;
            lblItem1_prefix_2.Location = new Point(24, 248);
            lblItem1_prefix_2.Name = "lblItem1_prefix_2";
            lblItem1_prefix_2.Size = new Size(70, 25);
            lblItem1_prefix_2.TabIndex = 2;
            lblItem1_prefix_2.Text = "Prefix 2";
            // 
            // lblItem1_prefix_1
            // 
            lblItem1_prefix_1.AutoSize = true;
            lblItem1_prefix_1.Location = new Point(24, 213);
            lblItem1_prefix_1.Name = "lblItem1_prefix_1";
            lblItem1_prefix_1.Size = new Size(70, 25);
            lblItem1_prefix_1.TabIndex = 1;
            lblItem1_prefix_1.Text = "Prefix 1";
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
            // panel2
            // 
            panel2.Controls.Add(lblItem2_Level);
            panel2.Controls.Add(lblItem2_Armor_Damage);
            panel2.Controls.Add(lblItem2_baseAffix_2);
            panel2.Controls.Add(lblItem2_suffix_3);
            panel2.Controls.Add(lblItem2_baseAffix_1);
            panel2.Controls.Add(lblItem2_suffix_2);
            panel2.Controls.Add(lblItem2_suffix_1);
            panel2.Controls.Add(lblItem2_prefix_3);
            panel2.Controls.Add(lblItem2_prefix_2);
            panel2.Controls.Add(lblItem2_prefix_1);
            panel2.Controls.Add(lblItem2);
            panel2.Location = new Point(373, 22);
            panel2.Name = "panel2";
            panel2.Size = new Size(338, 492);
            panel2.TabIndex = 7;
            // 
            // lblItem2_Level
            // 
            lblItem2_Level.BackColor = Color.Transparent;
            lblItem2_Level.Location = new Point(10, 444);
            lblItem2_Level.Name = "lblItem2_Level";
            lblItem2_Level.Size = new Size(314, 38);
            lblItem2_Level.TabIndex = 11;
            lblItem2_Level.Text = "label4";
            lblItem2_Level.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblItem2_Armor_Damage
            // 
            lblItem2_Armor_Damage.AutoSize = true;
            lblItem2_Armor_Damage.Location = new Point(24, 62);
            lblItem2_Armor_Damage.Name = "lblItem2_Armor_Damage";
            lblItem2_Armor_Damage.Size = new Size(0, 25);
            lblItem2_Armor_Damage.TabIndex = 10;
            // 
            // lblItem2_baseAffix_2
            // 
            lblItem2_baseAffix_2.AutoSize = true;
            lblItem2_baseAffix_2.Location = new Point(24, 138);
            lblItem2_baseAffix_2.Name = "lblItem2_baseAffix_2";
            lblItem2_baseAffix_2.Size = new Size(36, 25);
            lblItem2_baseAffix_2.TabIndex = 10;
            lblItem2_baseAffix_2.Text = "sss";
            // 
            // lblItem2_suffix_3
            // 
            lblItem2_suffix_3.AutoSize = true;
            lblItem2_suffix_3.Location = new Point(24, 389);
            lblItem2_suffix_3.Name = "lblItem2_suffix_3";
            lblItem2_suffix_3.Size = new Size(71, 25);
            lblItem2_suffix_3.TabIndex = 6;
            lblItem2_suffix_3.Text = "Suffix 3";
            // 
            // lblItem2_baseAffix_1
            // 
            lblItem2_baseAffix_1.AutoSize = true;
            lblItem2_baseAffix_1.Location = new Point(24, 105);
            lblItem2_baseAffix_1.Name = "lblItem2_baseAffix_1";
            lblItem2_baseAffix_1.Size = new Size(36, 25);
            lblItem2_baseAffix_1.TabIndex = 9;
            lblItem2_baseAffix_1.Text = "sss";
            // 
            // lblItem2_suffix_2
            // 
            lblItem2_suffix_2.AutoSize = true;
            lblItem2_suffix_2.Location = new Point(24, 354);
            lblItem2_suffix_2.Name = "lblItem2_suffix_2";
            lblItem2_suffix_2.Size = new Size(71, 25);
            lblItem2_suffix_2.TabIndex = 5;
            lblItem2_suffix_2.Text = "Suffix 2";
            // 
            // lblItem2_suffix_1
            // 
            lblItem2_suffix_1.AutoSize = true;
            lblItem2_suffix_1.Location = new Point(24, 319);
            lblItem2_suffix_1.Name = "lblItem2_suffix_1";
            lblItem2_suffix_1.Size = new Size(71, 25);
            lblItem2_suffix_1.TabIndex = 4;
            lblItem2_suffix_1.Text = "Suffix 1";
            // 
            // lblItem2_prefix_3
            // 
            lblItem2_prefix_3.AutoSize = true;
            lblItem2_prefix_3.Location = new Point(24, 283);
            lblItem2_prefix_3.Name = "lblItem2_prefix_3";
            lblItem2_prefix_3.Size = new Size(70, 25);
            lblItem2_prefix_3.TabIndex = 3;
            lblItem2_prefix_3.Text = "Prefix 3";
            // 
            // lblItem2_prefix_2
            // 
            lblItem2_prefix_2.AutoSize = true;
            lblItem2_prefix_2.Location = new Point(24, 248);
            lblItem2_prefix_2.Name = "lblItem2_prefix_2";
            lblItem2_prefix_2.Size = new Size(70, 25);
            lblItem2_prefix_2.TabIndex = 2;
            lblItem2_prefix_2.Text = "Prefix 2";
            // 
            // lblItem2_prefix_1
            // 
            lblItem2_prefix_1.AutoSize = true;
            lblItem2_prefix_1.Location = new Point(24, 213);
            lblItem2_prefix_1.Name = "lblItem2_prefix_1";
            lblItem2_prefix_1.Size = new Size(70, 25);
            lblItem2_prefix_1.TabIndex = 1;
            lblItem2_prefix_1.Text = "Prefix 1";
            // 
            // lblItem2
            // 
            lblItem2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblItem2.Location = new Point(24, 20);
            lblItem2.Name = "lblItem2";
            lblItem2.Size = new Size(289, 30);
            lblItem2.TabIndex = 0;
            lblItem2.Text = "Item 2";
            lblItem2.TextAlign = ContentAlignment.MiddleCenter;
            lblItem2.Click += label7_Click;
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
            // btnCreate_Item_2
            // 
            btnCreate_Item_2.Location = new Point(39, 746);
            btnCreate_Item_2.Name = "btnCreate_Item_2";
            btnCreate_Item_2.Size = new Size(148, 34);
            btnCreate_Item_2.TabIndex = 10;
            btnCreate_Item_2.Text = "Create Item 2";
            btnCreate_Item_2.UseVisualStyleBackColor = true;
            btnCreate_Item_2.Click += btnCreate_Item_2_Click;
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1258, 1004);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(txtLevel);
            Controls.Add(lstInventory);
            Controls.Add(btn_Combine_Items);
            Controls.Add(txtInventoryMax);
            Controls.Add(label1);
            Controls.Add(btn_Create_Inventory);
            Controls.Add(btnCreate_Item_2);
            Controls.Add(btnCreate_Item_1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label lblItem1_prefix_3;
        private Label lblItem1_prefix_2;
        private Label lblItem1_prefix_1;
        private Label lblItem1;
        private Label lblItem1_suffix_3;
        private Label lblItem1_suffix_2;
        private Label lblItem1_suffix_1;
        private Panel panel2;
        private Label lblItem2_suffix_3;
        private Label lblItem2_suffix_2;
        private Label lblItem2_suffix_1;
        private Label lblItem2_prefix_3;
        private Label lblItem2_prefix_2;
        private Label lblItem2_prefix_1;
        private Label lblItem2;
        private Panel panel3;
        private Label lblItem3_suffix_3;
        private Label lblItem3_suffix_2;
        private Label lblItem3_suffix_1;
        private Label lblItem3_prefix_3;
        private Label lblItem3_prefix_2;
        private Label lblItem3_prefix_1;
        private Label lblItem3;
        private Button btnCreate_Item_1;
        private Button btnCreate_Item_2;
        private Button btn_Create_Inventory;
        private Label label1;
        private TextBox txtInventoryMax;
        private Button btn_Combine_Items;
        private ListBox lstInventory;
        private TextBox txtLevel;
        private Label label2;
        private Label lblItem1_baseAffix_2;
        private Label lblItem1_baseAffix_1;
        private Label lblItem2_baseAffix_2;
        private Label lblItem2_baseAffix_1;
        private Label lblItem1_Armor_Damage;
        private Label lblItem2_Armor_Damage;
        private Label lblItem2_Level;
        private Label lblItem1_Level;
        private Button button1;
    }
}