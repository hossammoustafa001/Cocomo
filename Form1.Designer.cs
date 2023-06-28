
namespace cocomo
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
            this.organic1 = new System.Windows.Forms.Button();
            this.semi2 = new System.Windows.Forms.Button();
            this.embedded1 = new System.Windows.Forms.Button();
            this.kloc1 = new System.Windows.Forms.TextBox();
            this.kloc_label = new System.Windows.Forms.Label();
            this.tdev_button = new System.Windows.Forms.Button();
            this.tdev_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.calculate_effort = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Box1 = new System.Windows.Forms.ComboBox();
            this.Box0 = new System.Windows.Forms.ComboBox();
            this.Box2 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.Box3 = new System.Windows.Forms.ComboBox();
            this.Box4 = new System.Windows.Forms.ComboBox();
            this.Box5 = new System.Windows.Forms.ComboBox();
            this.Box6 = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.Box7 = new System.Windows.Forms.ComboBox();
            this.Box8 = new System.Windows.Forms.ComboBox();
            this.Box9 = new System.Windows.Forms.ComboBox();
            this.Box10 = new System.Windows.Forms.ComboBox();
            this.Box11 = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.Box12 = new System.Windows.Forms.ComboBox();
            this.Box13 = new System.Windows.Forms.ComboBox();
            this.Box14 = new System.Windows.Forms.ComboBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.actual_effort = new System.Windows.Forms.Label();
            this.calculate_actual_effort = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // organic1
            // 
            this.organic1.Location = new System.Drawing.Point(187, 82);
            this.organic1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.organic1.Name = "organic1";
            this.organic1.Size = new System.Drawing.Size(92, 36);
            this.organic1.TabIndex = 0;
            this.organic1.Text = "organic";
            this.organic1.UseVisualStyleBackColor = true;
            this.organic1.Click += new System.EventHandler(this.organic1_Click);
            // 
            // semi2
            // 
            this.semi2.Location = new System.Drawing.Point(303, 81);
            this.semi2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.semi2.Name = "semi2";
            this.semi2.Size = new System.Drawing.Size(121, 37);
            this.semi2.TabIndex = 1;
            this.semi2.Text = "semi-detached";
            this.semi2.UseVisualStyleBackColor = true;
            this.semi2.Click += new System.EventHandler(this.semi2_Click);
            // 
            // embedded1
            // 
            this.embedded1.Location = new System.Drawing.Point(441, 80);
            this.embedded1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.embedded1.Name = "embedded1";
            this.embedded1.Size = new System.Drawing.Size(103, 38);
            this.embedded1.TabIndex = 2;
            this.embedded1.Text = "embedded";
            this.embedded1.UseVisualStyleBackColor = true;
            this.embedded1.Click += new System.EventHandler(this.embedded1_Click);
            // 
            // kloc1
            // 
            this.kloc1.Location = new System.Drawing.Point(139, 27);
            this.kloc1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kloc1.Name = "kloc1";
            this.kloc1.Size = new System.Drawing.Size(100, 22);
            this.kloc1.TabIndex = 3;
            this.kloc1.TextChanged += new System.EventHandler(this.kloc1_TextChanged);
            // 
            // kloc_label
            // 
            this.kloc_label.AutoSize = true;
            this.kloc_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kloc_label.Location = new System.Drawing.Point(1346, 173);
            this.kloc_label.Name = "kloc_label";
            this.kloc_label.Size = new System.Drawing.Size(106, 20);
            this.kloc_label.TabIndex = 4;
            this.kloc_label.Text = "Effort value";
            // 
            // tdev_button
            // 
            this.tdev_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tdev_button.Location = new System.Drawing.Point(1058, 231);
            this.tdev_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tdev_button.Name = "tdev_button";
            this.tdev_button.Size = new System.Drawing.Size(241, 44);
            this.tdev_button.TabIndex = 5;
            this.tdev_button.Text = "Calculate Tdev";
            this.tdev_button.UseVisualStyleBackColor = true;
            this.tdev_button.Click += new System.EventHandler(this.tdev_button_Click);
            // 
            // tdev_label
            // 
            this.tdev_label.AutoSize = true;
            this.tdev_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tdev_label.Location = new System.Drawing.Point(1346, 243);
            this.tdev_label.Name = "tdev_label";
            this.tdev_label.Size = new System.Drawing.Size(105, 20);
            this.tdev_label.TabIndex = 7;
            this.tdev_label.Text = "Tdev value ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Enter Kloc ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Choose Mode";
            // 
            // calculate_effort
            // 
            this.calculate_effort.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculate_effort.Location = new System.Drawing.Point(1058, 161);
            this.calculate_effort.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.calculate_effort.Name = "calculate_effort";
            this.calculate_effort.Size = new System.Drawing.Size(241, 44);
            this.calculate_effort.TabIndex = 10;
            this.calculate_effort.Text = "calculate effort";
            this.calculate_effort.UseVisualStyleBackColor = true;
            this.calculate_effort.Click += new System.EventHandler(this.calculate_effort_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 336F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 138F));
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.Box1, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.Box0, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.Box2, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label9, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label10, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.label11, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.label12, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.label13, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.Box3, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.Box4, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.Box5, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.Box6, 1, 9);
            this.tableLayoutPanel1.Controls.Add(this.label14, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label15, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.label16, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.label17, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.label18, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.label19, 2, 6);
            this.tableLayoutPanel1.Controls.Add(this.Box7, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.Box8, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.Box9, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.Box10, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.Box11, 3, 6);
            this.tableLayoutPanel1.Controls.Add(this.label20, 2, 7);
            this.tableLayoutPanel1.Controls.Add(this.label21, 2, 8);
            this.tableLayoutPanel1.Controls.Add(this.label22, 2, 9);
            this.tableLayoutPanel1.Controls.Add(this.label23, 2, 10);
            this.tableLayoutPanel1.Controls.Add(this.Box12, 3, 8);
            this.tableLayoutPanel1.Controls.Add(this.Box13, 3, 9);
            this.tableLayoutPanel1.Controls.Add(this.Box14, 3, 10);
            this.tableLayoutPanel1.Controls.Add(this.label24, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label25, 3, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(16, 161);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 11;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(977, 409);
            this.tableLayoutPanel1.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Cost Drivers";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(366, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Rating";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(162, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Product Attributes";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(211, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "Required software reliability";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(219, 17);
            this.label7.TabIndex = 5;
            this.label7.Text = "Size of application database ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 140);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(197, 17);
            this.label8.TabIndex = 6;
            this.label8.Text = "Complexity of the product ";
            // 
            // Box1
            // 
            this.Box1.FormattingEnabled = true;
            this.Box1.Items.AddRange(new object[] {
            "Low",
            "Nominal",
            "High",
            "Very High"});
            this.Box1.Location = new System.Drawing.Point(366, 108);
            this.Box1.Name = "Box1";
            this.Box1.Size = new System.Drawing.Size(121, 24);
            this.Box1.TabIndex = 8;
            // 
            // Box0
            // 
            this.Box0.FormattingEnabled = true;
            this.Box0.Items.AddRange(new object[] {
            "Very Low",
            "Low",
            "Nominal",
            "High",
            "Very High"});
            this.Box0.Location = new System.Drawing.Point(366, 73);
            this.Box0.Name = "Box0";
            this.Box0.Size = new System.Drawing.Size(121, 24);
            this.Box0.TabIndex = 7;
            // 
            // Box2
            // 
            this.Box2.FormattingEnabled = true;
            this.Box2.Items.AddRange(new object[] {
            "Very low",
            "Low",
            "Nominal",
            "High",
            "Very High",
            "Extra High"});
            this.Box2.Location = new System.Drawing.Point(366, 143);
            this.Box2.Name = "Box2";
            this.Box2.Size = new System.Drawing.Size(121, 24);
            this.Box2.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(3, 175);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(178, 20);
            this.label9.TabIndex = 10;
            this.label9.Text = "Hardware Attributes";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(3, 210);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(253, 17);
            this.label10.TabIndex = 11;
            this.label10.Text = "Run time performance constraints";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(3, 245);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(149, 17);
            this.label11.TabIndex = 12;
            this.label11.Text = "Memory constraints";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(3, 280);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(331, 17);
            this.label12.TabIndex = 13;
            this.label12.Text = "Volatility of the virtual machine environment ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(3, 315);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(189, 17);
            this.label13.TabIndex = 14;
            this.label13.Text = "Required turnabout time ";
            // 
            // Box3
            // 
            this.Box3.FormattingEnabled = true;
            this.Box3.Items.AddRange(new object[] {
            "Nominal",
            "High",
            "Very High",
            "Extra High"});
            this.Box3.Location = new System.Drawing.Point(366, 213);
            this.Box3.Name = "Box3";
            this.Box3.Size = new System.Drawing.Size(121, 24);
            this.Box3.TabIndex = 15;
            // 
            // Box4
            // 
            this.Box4.FormattingEnabled = true;
            this.Box4.Items.AddRange(new object[] {
            "Nominal",
            "High",
            "Very High",
            "Extra High"});
            this.Box4.Location = new System.Drawing.Point(366, 248);
            this.Box4.Name = "Box4";
            this.Box4.Size = new System.Drawing.Size(121, 24);
            this.Box4.TabIndex = 16;
            // 
            // Box5
            // 
            this.Box5.FormattingEnabled = true;
            this.Box5.Items.AddRange(new object[] {
            "Low",
            "Nominal",
            "High",
            "Very High"});
            this.Box5.Location = new System.Drawing.Point(366, 283);
            this.Box5.Name = "Box5";
            this.Box5.Size = new System.Drawing.Size(121, 24);
            this.Box5.TabIndex = 17;
            // 
            // Box6
            // 
            this.Box6.FormattingEnabled = true;
            this.Box6.Items.AddRange(new object[] {
            "Low",
            "Nominal",
            "High",
            "Very High"});
            this.Box6.Location = new System.Drawing.Point(366, 318);
            this.Box6.Name = "Box6";
            this.Box6.Size = new System.Drawing.Size(121, 24);
            this.Box6.TabIndex = 18;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label14.Location = new System.Drawing.Point(506, 35);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(171, 20);
            this.label14.TabIndex = 24;
            this.label14.Text = "Personal Attributes";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(506, 70);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(140, 17);
            this.label15.TabIndex = 25;
            this.label15.Text = "Analyst capability ";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(506, 105);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(172, 17);
            this.label16.TabIndex = 26;
            this.label16.Text = "Application experience";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(506, 140);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(219, 17);
            this.label17.TabIndex = 27;
            this.label17.Text = "Software engineer capability ";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(506, 175);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(204, 17);
            this.label18.TabIndex = 28;
            this.label18.Text = "Virtual machine experience";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(506, 210);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(259, 17);
            this.label19.TabIndex = 29;
            this.label19.Text = "Programming language experience";
            // 
            // Box7
            // 
            this.Box7.FormattingEnabled = true;
            this.Box7.Items.AddRange(new object[] {
            "Very Low ",
            "Low ",
            "Nominal ",
            "High ",
            "Very High "});
            this.Box7.Location = new System.Drawing.Point(842, 73);
            this.Box7.Name = "Box7";
            this.Box7.Size = new System.Drawing.Size(121, 24);
            this.Box7.TabIndex = 19;
            // 
            // Box8
            // 
            this.Box8.FormattingEnabled = true;
            this.Box8.Items.AddRange(new object[] {
            "Very Low",
            "Low",
            "Nominal",
            "High",
            "Very High",
            " "});
            this.Box8.Location = new System.Drawing.Point(842, 108);
            this.Box8.Name = "Box8";
            this.Box8.Size = new System.Drawing.Size(121, 24);
            this.Box8.TabIndex = 20;
            // 
            // Box9
            // 
            this.Box9.FormattingEnabled = true;
            this.Box9.Items.AddRange(new object[] {
            "Very Low",
            "Low",
            "Nominal",
            "High",
            "Very High",
            " "});
            this.Box9.Location = new System.Drawing.Point(842, 143);
            this.Box9.Name = "Box9";
            this.Box9.Size = new System.Drawing.Size(121, 24);
            this.Box9.TabIndex = 21;
            // 
            // Box10
            // 
            this.Box10.FormattingEnabled = true;
            this.Box10.Items.AddRange(new object[] {
            "Very Low",
            "Low",
            "Nominal",
            "High"});
            this.Box10.Location = new System.Drawing.Point(842, 178);
            this.Box10.Name = "Box10";
            this.Box10.Size = new System.Drawing.Size(121, 24);
            this.Box10.TabIndex = 22;
            // 
            // Box11
            // 
            this.Box11.FormattingEnabled = true;
            this.Box11.Items.AddRange(new object[] {
            "Very Low",
            "Low",
            "Nominal",
            "High"});
            this.Box11.Location = new System.Drawing.Point(842, 213);
            this.Box11.Name = "Box11";
            this.Box11.Size = new System.Drawing.Size(121, 24);
            this.Box11.TabIndex = 23;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(506, 245);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(163, 20);
            this.label20.TabIndex = 30;
            this.label20.Text = "Project Attributes ";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(506, 280);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(330, 17);
            this.label21.TabIndex = 31;
            this.label21.Text = "Application of software engineering methods ";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(506, 315);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(281, 17);
            this.label22.TabIndex = 32;
            this.label22.Text = "use of software engineering methods ";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(506, 350);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(246, 17);
            this.label23.TabIndex = 33;
            this.label23.Text = "Required development schedule ";
            // 
            // Box12
            // 
            this.Box12.FormattingEnabled = true;
            this.Box12.Items.AddRange(new object[] {
            "Very Low",
            "Low",
            "Nominal",
            "High",
            "Very High"});
            this.Box12.Location = new System.Drawing.Point(842, 283);
            this.Box12.Name = "Box12";
            this.Box12.Size = new System.Drawing.Size(121, 24);
            this.Box12.TabIndex = 34;
            // 
            // Box13
            // 
            this.Box13.FormattingEnabled = true;
            this.Box13.Items.AddRange(new object[] {
            "Very Low",
            "Low",
            "Nominal",
            "High",
            "Very High"});
            this.Box13.Location = new System.Drawing.Point(842, 318);
            this.Box13.Name = "Box13";
            this.Box13.Size = new System.Drawing.Size(121, 24);
            this.Box13.TabIndex = 35;
            // 
            // Box14
            // 
            this.Box14.FormattingEnabled = true;
            this.Box14.Items.AddRange(new object[] {
            "Very Low",
            "Low",
            "Nominal",
            "High",
            "Very High"});
            this.Box14.Location = new System.Drawing.Point(842, 353);
            this.Box14.Name = "Box14";
            this.Box14.Size = new System.Drawing.Size(121, 24);
            this.Box14.TabIndex = 36;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(506, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(116, 20);
            this.label24.TabIndex = 37;
            this.label24.Text = "Cost Drivers";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(842, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(63, 20);
            this.label25.TabIndex = 38;
            this.label25.Text = "Rating";
            // 
            // actual_effort
            // 
            this.actual_effort.AutoSize = true;
            this.actual_effort.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actual_effort.Location = new System.Drawing.Point(1346, 319);
            this.actual_effort.Name = "actual_effort";
            this.actual_effort.Size = new System.Drawing.Size(163, 20);
            this.actual_effort.TabIndex = 12;
            this.actual_effort.Text = "Actual effort value";
            // 
            // calculate_actual_effort
            // 
            this.calculate_actual_effort.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculate_actual_effort.Location = new System.Drawing.Point(1058, 305);
            this.calculate_actual_effort.Name = "calculate_actual_effort";
            this.calculate_actual_effort.Size = new System.Drawing.Size(241, 48);
            this.calculate_actual_effort.TabIndex = 13;
            this.calculate_actual_effort.Text = "Calculate actual effort ";
            this.calculate_actual_effort.UseVisualStyleBackColor = true;
            this.calculate_actual_effort.Click += new System.EventHandler(this.calculate_actual_effort_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1660, 677);
            this.Controls.Add(this.kloc1);
            this.Controls.Add(this.calculate_actual_effort);
            this.Controls.Add(this.actual_effort);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.calculate_effort);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tdev_label);
            this.Controls.Add(this.tdev_button);
            this.Controls.Add(this.kloc_label);
            this.Controls.Add(this.embedded1);
            this.Controls.Add(this.semi2);
            this.Controls.Add(this.organic1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button organic1;
        private System.Windows.Forms.Button semi2;
        private System.Windows.Forms.Button embedded1;
        private System.Windows.Forms.TextBox kloc1;
        private System.Windows.Forms.Label kloc_label;
        private System.Windows.Forms.Button tdev_button;
        private System.Windows.Forms.Label tdev_label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button calculate_effort;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox Box1;
        private System.Windows.Forms.ComboBox Box0;
        private System.Windows.Forms.ComboBox Box2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox Box3;
        private System.Windows.Forms.ComboBox Box4;
        private System.Windows.Forms.ComboBox Box5;
        private System.Windows.Forms.ComboBox Box6;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ComboBox Box7;
        private System.Windows.Forms.ComboBox Box8;
        private System.Windows.Forms.ComboBox Box9;
        private System.Windows.Forms.ComboBox Box10;
        private System.Windows.Forms.ComboBox Box11;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.ComboBox Box12;
        private System.Windows.Forms.ComboBox Box13;
        private System.Windows.Forms.ComboBox Box14;
        private System.Windows.Forms.Label actual_effort;
        private System.Windows.Forms.Button calculate_actual_effort;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
    }
}

