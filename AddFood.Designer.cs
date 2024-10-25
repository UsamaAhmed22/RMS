﻿namespace RMS
{
    partial class AddFood
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
            lbl_phone = new Label();
            txt_description = new TextBox();
            lbl_firstname = new Label();
            txt_food = new TextBox();
            label1 = new Label();
            txt_price = new TextBox();
            cb_foodcategory = new ComboBox();
            lbl_category = new Label();
            btn_add_food = new Button();
            panel1 = new Panel();
            label2 = new Label();
            panel2 = new Panel();
            pictureBox7 = new PictureBox();
            btn_order = new Button();
            btn_staff = new Button();
            btn_menu = new Button();
            btn_tables = new Button();
            btn_signout = new Button();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox6 = new PictureBox();
            label6 = new Label();
            pictureBox1 = new PictureBox();
            btn_update = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lbl_phone
            // 
            lbl_phone.AutoSize = true;
            lbl_phone.Location = new Point(565, 205);
            lbl_phone.Name = "lbl_phone";
            lbl_phone.Size = new Size(116, 15);
            lbl_phone.TabIndex = 222;
            lbl_phone.Text = "Food Description";
            // 
            // txt_description
            // 
            txt_description.Location = new Point(562, 224);
            txt_description.Name = "txt_description";
            txt_description.Size = new Size(275, 21);
            txt_description.TabIndex = 221;
            // 
            // lbl_firstname
            // 
            lbl_firstname.AutoSize = true;
            lbl_firstname.Location = new Point(255, 206);
            lbl_firstname.Name = "lbl_firstname";
            lbl_firstname.Size = new Size(81, 15);
            lbl_firstname.TabIndex = 220;
            lbl_firstname.Text = "Food Name";
            // 
            // txt_food
            // 
            txt_food.Location = new Point(250, 226);
            txt_food.Name = "txt_food";
            txt_food.Size = new Size(275, 21);
            txt_food.TabIndex = 219;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(253, 256);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 224;
            label1.Text = "Price";
            // 
            // txt_price
            // 
            txt_price.Location = new Point(250, 275);
            txt_price.Name = "txt_price";
            txt_price.Size = new Size(275, 21);
            txt_price.TabIndex = 223;
            // 
            // cb_foodcategory
            // 
            cb_foodcategory.FormattingEnabled = true;
            cb_foodcategory.Location = new Point(563, 272);
            cb_foodcategory.Name = "cb_foodcategory";
            cb_foodcategory.Size = new Size(241, 23);
            cb_foodcategory.TabIndex = 226;
            // 
            // lbl_category
            // 
            lbl_category.AutoSize = true;
            lbl_category.Location = new Point(565, 254);
            lbl_category.Name = "lbl_category";
            lbl_category.Size = new Size(99, 15);
            lbl_category.TabIndex = 225;
            lbl_category.Text = "Food Category";
            // 
            // btn_add_food
            // 
            btn_add_food.BackColor = SystemColors.GradientActiveCaption;
            btn_add_food.Cursor = Cursors.Hand;
            btn_add_food.FlatStyle = FlatStyle.Popup;
            btn_add_food.Location = new Point(467, 322);
            btn_add_food.Name = "btn_add_food";
            btn_add_food.Size = new Size(167, 28);
            btn_add_food.TabIndex = 227;
            btn_add_food.Text = "Add Food";
            btn_add_food.UseVisualStyleBackColor = false;
            btn_add_food.Click += btn_add_food_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.GradientInactiveCaption;
            panel1.Controls.Add(label2);
            panel1.Location = new Point(200, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(715, 51);
            panel1.TabIndex = 228;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft YaHei UI", 11.25F, FontStyle.Bold);
            label2.ImageAlign = ContentAlignment.MiddleRight;
            label2.Location = new Point(16, 18);
            label2.Name = "label2";
            label2.Size = new Size(52, 19);
            label2.TabIndex = 172;
            label2.Text = "Order";
            // 
            // panel2
            // 
            panel2.BackColor = Color.SlateGray;
            panel2.Controls.Add(pictureBox7);
            panel2.Controls.Add(btn_order);
            panel2.Controls.Add(btn_staff);
            panel2.Controls.Add(btn_menu);
            panel2.Controls.Add(btn_tables);
            panel2.Controls.Add(btn_signout);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(pictureBox3);
            panel2.Controls.Add(pictureBox4);
            panel2.Controls.Add(pictureBox5);
            panel2.Controls.Add(pictureBox6);
            panel2.Controls.Add(label6);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 455);
            panel2.TabIndex = 229;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = Properties.Resources._65434;
            pictureBox7.Location = new Point(44, 18);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(106, 72);
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox7.TabIndex = 194;
            pictureBox7.TabStop = false;
            // 
            // btn_order
            // 
            btn_order.BackgroundImageLayout = ImageLayout.Stretch;
            btn_order.Cursor = Cursors.Hand;
            btn_order.FlatStyle = FlatStyle.Popup;
            btn_order.ForeColor = SystemColors.ActiveCaptionText;
            btn_order.ImageAlign = ContentAlignment.TopLeft;
            btn_order.Location = new Point(75, 206);
            btn_order.Name = "btn_order";
            btn_order.RightToLeft = RightToLeft.No;
            btn_order.Size = new Size(81, 27);
            btn_order.TabIndex = 183;
            btn_order.Text = "Add Food";
            btn_order.TextAlign = ContentAlignment.MiddleLeft;
            btn_order.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_order.UseVisualStyleBackColor = true;
            btn_order.Click += btn_order_Click;
            // 
            // btn_staff
            // 
            btn_staff.BackgroundImageLayout = ImageLayout.Stretch;
            btn_staff.Cursor = Cursors.Hand;
            btn_staff.FlatStyle = FlatStyle.Popup;
            btn_staff.ForeColor = SystemColors.ActiveCaptionText;
            btn_staff.ImageAlign = ContentAlignment.TopLeft;
            btn_staff.Location = new Point(75, 275);
            btn_staff.Name = "btn_staff";
            btn_staff.RightToLeft = RightToLeft.No;
            btn_staff.Size = new Size(81, 26);
            btn_staff.TabIndex = 184;
            btn_staff.Text = "Staff";
            btn_staff.TextAlign = ContentAlignment.MiddleLeft;
            btn_staff.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_staff.UseVisualStyleBackColor = true;
            btn_staff.Click += btn_staff_Click;
            // 
            // btn_menu
            // 
            btn_menu.BackgroundImageLayout = ImageLayout.Stretch;
            btn_menu.Cursor = Cursors.Hand;
            btn_menu.FlatStyle = FlatStyle.Popup;
            btn_menu.ForeColor = SystemColors.ActiveCaptionText;
            btn_menu.ImageAlign = ContentAlignment.TopLeft;
            btn_menu.Location = new Point(75, 239);
            btn_menu.Name = "btn_menu";
            btn_menu.RightToLeft = RightToLeft.No;
            btn_menu.Size = new Size(81, 30);
            btn_menu.TabIndex = 186;
            btn_menu.Text = "Menu";
            btn_menu.TextAlign = ContentAlignment.MiddleLeft;
            btn_menu.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_menu.UseVisualStyleBackColor = true;
            btn_menu.Click += btn_menu_Click;
            // 
            // btn_tables
            // 
            btn_tables.BackgroundImageLayout = ImageLayout.Stretch;
            btn_tables.Cursor = Cursors.Hand;
            btn_tables.FlatStyle = FlatStyle.Popup;
            btn_tables.ForeColor = SystemColors.ActiveCaptionText;
            btn_tables.ImageAlign = ContentAlignment.TopLeft;
            btn_tables.Location = new Point(76, 309);
            btn_tables.Name = "btn_tables";
            btn_tables.RightToLeft = RightToLeft.No;
            btn_tables.Size = new Size(80, 26);
            btn_tables.TabIndex = 185;
            btn_tables.Text = "Tables";
            btn_tables.TextAlign = ContentAlignment.MiddleLeft;
            btn_tables.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_tables.UseVisualStyleBackColor = true;
            btn_tables.Click += btn_tables_Click;
            // 
            // btn_signout
            // 
            btn_signout.BackgroundImageLayout = ImageLayout.Stretch;
            btn_signout.Cursor = Cursors.Hand;
            btn_signout.FlatStyle = FlatStyle.Popup;
            btn_signout.ForeColor = SystemColors.ActiveCaptionText;
            btn_signout.ImageAlign = ContentAlignment.TopLeft;
            btn_signout.Location = new Point(76, 344);
            btn_signout.Name = "btn_signout";
            btn_signout.RightToLeft = RightToLeft.No;
            btn_signout.Size = new Size(80, 28);
            btn_signout.TabIndex = 187;
            btn_signout.Text = "Signout";
            btn_signout.TextAlign = ContentAlignment.MiddleLeft;
            btn_signout.UseVisualStyleBackColor = true;
            btn_signout.Click += btn_signout_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Image = Properties.Resources._1046772;
            pictureBox2.Location = new Point(30, 206);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(39, 23);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 188;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.Image = Properties.Resources._1094675;
            pictureBox3.Location = new Point(30, 241);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(39, 23);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 189;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox4.Image = Properties.Resources._3081310;
            pictureBox4.Location = new Point(30, 279);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(39, 23);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 190;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox5.Image = Properties.Resources.pngtree_restaurant_icon_with_table_and_chairs_in_the_center_vector_png_image_12284888;
            pictureBox5.Location = new Point(30, 310);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(39, 25);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 191;
            pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox6.Image = Properties.Resources.sign_out_icon_7;
            pictureBox6.Location = new Point(30, 349);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(39, 23);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 192;
            pictureBox6.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft YaHei UI", 9.75F, FontStyle.Bold);
            label6.ImageAlign = ContentAlignment.MiddleRight;
            label6.Location = new Point(47, 97);
            label6.Name = "label6";
            label6.Size = new Size(97, 76);
            label6.TabIndex = 193;
            label6.Text = "Welcome to \r\nRestaurant \r\nManagement\r\nSystem";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._3765461;
            pictureBox1.Location = new Point(476, 61);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(154, 88);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 230;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // btn_update
            // 
            btn_update.BackColor = SystemColors.GradientActiveCaption;
            btn_update.Cursor = Cursors.Hand;
            btn_update.FlatStyle = FlatStyle.Popup;
            btn_update.Location = new Point(511, 160);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(84, 29);
            btn_update.TabIndex = 231;
            btn_update.Text = "Upload";
            btn_update.UseVisualStyleBackColor = false;
            btn_update.Click += btn_update_Click;
            // 
            // AddFood
            // 
            AutoScaleDimensions = new SizeF(8F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 450);
            Controls.Add(btn_update);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(btn_add_food);
            Controls.Add(cb_foodcategory);
            Controls.Add(lbl_category);
            Controls.Add(label1);
            Controls.Add(txt_price);
            Controls.Add(lbl_phone);
            Controls.Add(txt_description);
            Controls.Add(lbl_firstname);
            Controls.Add(txt_food);
            Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Name = "AddFood";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddFood";
            Load += AddFood_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_phone;
        private TextBox txt_description;
        private Label lbl_firstname;
        private TextBox txt_food;
        private Label label1;
        private TextBox txt_price;
        private ComboBox cb_foodcategory;
        private Label lbl_category;
        private Button btn_add_food;
        private Panel panel1;
        private Label label2;
        private Panel panel2;
        private PictureBox pictureBox7;
        private Button btn_order;
        private Button btn_staff;
        private Button btn_menu;
        private Button btn_tables;
        private Button btn_signout;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private Label label6;
        private PictureBox pictureBox1;
        private Button btn_update;
    }
}