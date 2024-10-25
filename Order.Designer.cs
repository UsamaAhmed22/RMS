﻿namespace RMS
{
    partial class Order
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
            panel1 = new Panel();
            label1 = new Label();
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
            label2 = new Label();
            dataGridView1 = new DataGridView();
            label4 = new Label();
            txt_total = new TextBox();
            label3 = new Label();
            dt_date = new DateTimePicker();
            txt_quantity = new TextBox();
            rb_female = new RadioButton();
            rb_male = new RadioButton();
            lbl_Gender = new Label();
            lbl_address = new Label();
            txt_address = new TextBox();
            cb_province = new ComboBox();
            lbl_province = new Label();
            cb_City = new ComboBox();
            cb_country = new ComboBox();
            cb_food = new ComboBox();
            cb_foodcategory = new ComboBox();
            lbl_food = new Label();
            lbl_emailaddress = new Label();
            txt_emailaddress = new TextBox();
            lbl_phone = new Label();
            txt_phone = new TextBox();
            lbl_category = new Label();
            btn_place_order = new Button();
            lbl_firstname = new Label();
            txt_firstname = new TextBox();
            lbl_country = new Label();
            lbl_city = new Label();
            label5 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.GradientInactiveCaption;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(200, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(857, 55);
            panel1.TabIndex = 211;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei UI", 11.25F, FontStyle.Bold);
            label1.ImageAlign = ContentAlignment.MiddleRight;
            label1.Location = new Point(16, 18);
            label1.Name = "label1";
            label1.Size = new Size(52, 19);
            label1.TabIndex = 172;
            label1.Text = "Order";
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
            panel2.Size = new Size(200, 509);
            panel2.TabIndex = 212;
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
            btn_order.Size = new Size(96, 27);
            btn_order.TabIndex = 183;
            btn_order.Text = "Order";
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
            btn_staff.Size = new Size(96, 26);
            btn_staff.TabIndex = 184;
            btn_staff.Text = "Your Details";
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
            btn_menu.Size = new Size(96, 30);
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
            btn_tables.Size = new Size(95, 26);
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
            btn_signout.Size = new Size(95, 28);
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(765, 88);
            label2.Name = "label2";
            label2.Size = new Size(83, 15);
            label2.TabIndex = 240;
            label2.Text = "Your Orders";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ActiveCaption;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(757, 110);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(280, 366);
            dataGridView1.TabIndex = 239;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(497, 371);
            label4.Name = "label4";
            label4.Size = new Size(91, 15);
            label4.TabIndex = 238;
            label4.Text = "Total Amount";
            // 
            // txt_total
            // 
            txt_total.Location = new Point(490, 391);
            txt_total.Name = "txt_total";
            txt_total.Size = new Size(241, 21);
            txt_total.TabIndex = 237;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(494, 143);
            label3.Name = "label3";
            label3.Size = new Size(37, 15);
            label3.TabIndex = 236;
            label3.Text = "Date";
            // 
            // dt_date
            // 
            dt_date.Location = new Point(490, 162);
            dt_date.Name = "dt_date";
            dt_date.Size = new Size(230, 21);
            dt_date.TabIndex = 235;
            // 
            // txt_quantity
            // 
            txt_quantity.Location = new Point(225, 391);
            txt_quantity.Name = "txt_quantity";
            txt_quantity.Size = new Size(241, 21);
            txt_quantity.TabIndex = 234;
            txt_quantity.TextChanged += txt_quantity_TextChanged;
            // 
            // rb_female
            // 
            rb_female.AutoSize = true;
            rb_female.Font = new Font("Mongolian Baiti", 9.75F);
            rb_female.Location = new Point(331, 303);
            rb_female.Name = "rb_female";
            rb_female.Size = new Size(64, 18);
            rb_female.TabIndex = 233;
            rb_female.TabStop = true;
            rb_female.Text = "Female";
            rb_female.UseVisualStyleBackColor = true;
            // 
            // rb_male
            // 
            rb_male.AutoSize = true;
            rb_male.Font = new Font("Mongolian Baiti", 9.75F);
            rb_male.Location = new Point(236, 301);
            rb_male.Name = "rb_male";
            rb_male.Size = new Size(53, 18);
            rb_male.TabIndex = 232;
            rb_male.TabStop = true;
            rb_male.Text = "Male";
            rb_male.UseVisualStyleBackColor = true;
            // 
            // lbl_Gender
            // 
            lbl_Gender.AutoSize = true;
            lbl_Gender.Location = new Point(225, 285);
            lbl_Gender.Name = "lbl_Gender";
            lbl_Gender.Size = new Size(62, 15);
            lbl_Gender.TabIndex = 231;
            lbl_Gender.Text = "Gender: ";
            // 
            // lbl_address
            // 
            lbl_address.AutoSize = true;
            lbl_address.Location = new Point(491, 239);
            lbl_address.Name = "lbl_address";
            lbl_address.Size = new Size(58, 15);
            lbl_address.TabIndex = 230;
            lbl_address.Text = "Address";
            // 
            // txt_address
            // 
            txt_address.Location = new Point(490, 258);
            txt_address.Name = "txt_address";
            txt_address.Size = new Size(241, 21);
            txt_address.TabIndex = 229;
            // 
            // cb_province
            // 
            cb_province.FormattingEnabled = true;
            cb_province.Location = new Point(490, 208);
            cb_province.Name = "cb_province";
            cb_province.Size = new Size(241, 23);
            cb_province.TabIndex = 228;
            cb_province.SelectedIndexChanged += cb_province_SelectedIndexChanged;
            // 
            // lbl_province
            // 
            lbl_province.AutoSize = true;
            lbl_province.Location = new Point(496, 190);
            lbl_province.Name = "lbl_province";
            lbl_province.Size = new Size(62, 15);
            lbl_province.TabIndex = 227;
            lbl_province.Text = "Province";
            // 
            // cb_City
            // 
            cb_City.FormattingEnabled = true;
            cb_City.Location = new Point(218, 257);
            cb_City.Name = "cb_City";
            cb_City.Size = new Size(241, 23);
            cb_City.TabIndex = 226;
            // 
            // cb_country
            // 
            cb_country.FormattingEnabled = true;
            cb_country.Location = new Point(218, 208);
            cb_country.Name = "cb_country";
            cb_country.Size = new Size(241, 23);
            cb_country.TabIndex = 225;
            cb_country.SelectedIndexChanged += cb_country_SelectedIndexChanged;
            // 
            // cb_food
            // 
            cb_food.FormattingEnabled = true;
            cb_food.Location = new Point(490, 343);
            cb_food.Name = "cb_food";
            cb_food.Size = new Size(241, 23);
            cb_food.TabIndex = 224;
            // 
            // cb_foodcategory
            // 
            cb_foodcategory.FormattingEnabled = true;
            cb_foodcategory.Location = new Point(223, 343);
            cb_foodcategory.Name = "cb_foodcategory";
            cb_foodcategory.Size = new Size(241, 23);
            cb_foodcategory.TabIndex = 223;
            cb_foodcategory.SelectedIndexChanged += cb_foodcategory_SelectedIndexChanged;
            // 
            // lbl_food
            // 
            lbl_food.AutoSize = true;
            lbl_food.Location = new Point(498, 325);
            lbl_food.Name = "lbl_food";
            lbl_food.Size = new Size(39, 15);
            lbl_food.TabIndex = 222;
            lbl_food.Text = "Food";
            // 
            // lbl_emailaddress
            // 
            lbl_emailaddress.AutoSize = true;
            lbl_emailaddress.Location = new Point(218, 144);
            lbl_emailaddress.Name = "lbl_emailaddress";
            lbl_emailaddress.Size = new Size(99, 15);
            lbl_emailaddress.TabIndex = 220;
            lbl_emailaddress.Text = "Email Address";
            // 
            // txt_emailaddress
            // 
            txt_emailaddress.Location = new Point(218, 163);
            txt_emailaddress.Name = "txt_emailaddress";
            txt_emailaddress.Size = new Size(241, 21);
            txt_emailaddress.TabIndex = 219;
            // 
            // lbl_phone
            // 
            lbl_phone.AutoSize = true;
            lbl_phone.Location = new Point(492, 96);
            lbl_phone.Name = "lbl_phone";
            lbl_phone.Size = new Size(48, 15);
            lbl_phone.TabIndex = 218;
            lbl_phone.Text = "Phone";
            // 
            // txt_phone
            // 
            txt_phone.Location = new Point(490, 115);
            txt_phone.Name = "txt_phone";
            txt_phone.Size = new Size(241, 21);
            txt_phone.TabIndex = 217;
            // 
            // lbl_category
            // 
            lbl_category.AutoSize = true;
            lbl_category.Location = new Point(225, 325);
            lbl_category.Name = "lbl_category";
            lbl_category.Size = new Size(99, 15);
            lbl_category.TabIndex = 216;
            lbl_category.Text = "Food Category";
            // 
            // btn_place_order
            // 
            btn_place_order.BackColor = SystemColors.GradientActiveCaption;
            btn_place_order.Cursor = Cursors.Hand;
            btn_place_order.FlatStyle = FlatStyle.Popup;
            btn_place_order.Location = new Point(287, 448);
            btn_place_order.Name = "btn_place_order";
            btn_place_order.Size = new Size(167, 28);
            btn_place_order.TabIndex = 215;
            btn_place_order.Text = "Place Order";
            btn_place_order.UseVisualStyleBackColor = false;
            btn_place_order.Click += btn_place_order_Click;
            // 
            // lbl_firstname
            // 
            lbl_firstname.AutoSize = true;
            lbl_firstname.Location = new Point(221, 97);
            lbl_firstname.Name = "lbl_firstname";
            lbl_firstname.Size = new Size(110, 15);
            lbl_firstname.TabIndex = 214;
            lbl_firstname.Text = "Customer Name";
            // 
            // txt_firstname
            // 
            txt_firstname.Location = new Point(217, 117);
            txt_firstname.Name = "txt_firstname";
            txt_firstname.Size = new Size(241, 21);
            txt_firstname.TabIndex = 213;
            // 
            // lbl_country
            // 
            lbl_country.AutoSize = true;
            lbl_country.Location = new Point(222, 188);
            lbl_country.Name = "lbl_country";
            lbl_country.Size = new Size(55, 15);
            lbl_country.TabIndex = 241;
            lbl_country.Text = "Country";
            // 
            // lbl_city
            // 
            lbl_city.AutoSize = true;
            lbl_city.Location = new Point(223, 237);
            lbl_city.Name = "lbl_city";
            lbl_city.Size = new Size(30, 15);
            lbl_city.TabIndex = 242;
            lbl_city.Text = "City";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(229, 372);
            label5.Name = "label5";
            label5.Size = new Size(59, 15);
            label5.TabIndex = 243;
            label5.Text = "Quantity";
            // 
            // Order
            // 
            AutoScaleDimensions = new SizeF(8F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1057, 509);
            Controls.Add(label5);
            Controls.Add(lbl_city);
            Controls.Add(lbl_country);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(label4);
            Controls.Add(txt_total);
            Controls.Add(label3);
            Controls.Add(dt_date);
            Controls.Add(txt_quantity);
            Controls.Add(rb_female);
            Controls.Add(rb_male);
            Controls.Add(lbl_Gender);
            Controls.Add(lbl_address);
            Controls.Add(txt_address);
            Controls.Add(cb_province);
            Controls.Add(lbl_province);
            Controls.Add(cb_City);
            Controls.Add(cb_country);
            Controls.Add(cb_food);
            Controls.Add(cb_foodcategory);
            Controls.Add(lbl_food);
            Controls.Add(lbl_emailaddress);
            Controls.Add(txt_emailaddress);
            Controls.Add(lbl_phone);
            Controls.Add(txt_phone);
            Controls.Add(lbl_category);
            Controls.Add(btn_place_order);
            Controls.Add(lbl_firstname);
            Controls.Add(txt_firstname);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Name = "Order";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Order";
            Load += Order_Load;
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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
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
        private Label label2;
        private DataGridView dataGridView1;
        private Label label4;
        private TextBox txt_total;
        private Label label3;
        private DateTimePicker dt_date;
        private TextBox txt_quantity;
        private RadioButton rb_female;
        private RadioButton rb_male;
        private Label lbl_Gender;
        private Label lbl_address;
        private TextBox txt_address;
        private ComboBox cb_province;
        private Label lbl_province;
        private ComboBox cb_City;
        private ComboBox cb_country;
        private ComboBox cb_food;
        private ComboBox cb_foodcategory;
        private Label lbl_food;
        private Label lbl_emailaddress;
        private TextBox txt_emailaddress;
        private Label lbl_phone;
        private TextBox txt_phone;
        private Label lbl_category;
        private Button btn_place_order;
        private Label lbl_firstname;
        private TextBox txt_firstname;
        private Label lbl_country;
        private Label lbl_city;
        private Label label5;
    }
}