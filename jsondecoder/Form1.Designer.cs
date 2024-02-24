namespace jsondecoder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button1 = new Button();
            txt_email = new TextBox();
            txt_password = new TextBox();
            txt_json = new TextBox();
            button2 = new Button();
            label1 = new Label();
            button3 = new Button();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            groupBox1 = new GroupBox();
            label5 = new Label();
            label4 = new Label();
            numericUpDown2 = new NumericUpDown();
            numericUpDown1 = new NumericUpDown();
            button5 = new Button();
            button4 = new Button();
            label3 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            groupBox2 = new GroupBox();
            button6 = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(109, 112);
            button1.Name = "button1";
            button1.Size = new Size(123, 36);
            button1.TabIndex = 0;
            button1.Text = "Login";
            button1.TextAlign = ContentAlignment.TopCenter;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_ClickAsync;
            // 
            // txt_email
            // 
            txt_email.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_email.Location = new Point(15, 32);
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(315, 34);
            txt_email.TabIndex = 1;
            txt_email.Text = "yigevo8665@laymro.com";
            // 
            // txt_password
            // 
            txt_password.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_password.Location = new Point(15, 72);
            txt_password.Name = "txt_password";
            txt_password.Size = new Size(315, 34);
            txt_password.TabIndex = 2;
            txt_password.Text = "Aa123456@";
            // 
            // txt_json
            // 
            txt_json.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            txt_json.Location = new Point(12, 44);
            txt_json.Multiline = true;
            txt_json.Name = "txt_json";
            txt_json.ScrollBars = ScrollBars.Vertical;
            txt_json.Size = new Size(638, 562);
            txt_json.TabIndex = 3;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(12, 612);
            button2.Name = "button2";
            button2.Size = new Size(244, 41);
            button2.TabIndex = 4;
            button2.Text = "Generate Time Request";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_ClickAsync;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Chocolate;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(1092, 38);
            label1.TabIndex = 5;
            label1.Text = "User : firstName";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(494, 612);
            button3.Name = "button3";
            button3.Size = new Size(158, 41);
            button3.TabIndex = 6;
            button3.Text = "Send Request";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(85, 37);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(164, 27);
            dateTimePicker1.TabIndex = 7;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.Location = new Point(85, 70);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(164, 27);
            dateTimePicker2.TabIndex = 8;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(numericUpDown2);
            groupBox1.Controls.Add(numericUpDown1);
            groupBox1.Controls.Add(button5);
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(dateTimePicker2);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Location = new Point(673, 174);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(340, 145);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Times";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(166, 109);
            label5.Name = "label5";
            label5.Size = new Size(61, 20);
            label5.TabIndex = 17;
            label5.Text = "Minutes";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(10, 109);
            label4.Name = "label4";
            label4.Size = new Size(41, 20);
            label4.TabIndex = 16;
            label4.Text = "Days";
            // 
            // numericUpDown2
            // 
            numericUpDown2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            numericUpDown2.Increment = new decimal(new int[] { 61, 0, 0, 0 });
            numericUpDown2.Location = new Point(233, 105);
            numericUpDown2.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            numericUpDown2.Minimum = new decimal(new int[] { 9999, 0, 0, int.MinValue });
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(85, 30);
            numericUpDown2.TabIndex = 15;
            numericUpDown2.TextAlign = HorizontalAlignment.Center;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            numericUpDown1.Location = new Point(57, 103);
            numericUpDown1.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            numericUpDown1.Minimum = new decimal(new int[] { 9999, 0, 0, int.MinValue });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(101, 30);
            numericUpDown1.TabIndex = 14;
            numericUpDown1.TextAlign = HorizontalAlignment.Center;
            // 
            // button5
            // 
            button5.Location = new Point(255, 68);
            button5.Name = "button5";
            button5.Size = new Size(77, 29);
            button5.TabIndex = 12;
            button5.Text = "Set Now";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.Location = new Point(255, 37);
            button4.Name = "button4";
            button4.Size = new Size(77, 29);
            button4.TabIndex = 11;
            button4.Text = "Set Now";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(4, 75);
            label3.Name = "label3";
            label3.Size = new Size(71, 20);
            label3.TabIndex = 10;
            label3.Text = "End Time";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(4, 42);
            label2.Name = "label2";
            label2.Size = new Size(77, 20);
            label2.TabIndex = 9;
            label2.Text = "Start Time";
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Location = new Point(656, 325);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ScrollBars = ScrollBars.Vertical;
            textBox1.Size = new Size(426, 281);
            textBox1.TabIndex = 10;
            textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txt_password);
            groupBox2.Controls.Add(txt_email);
            groupBox2.Controls.Add(button1);
            groupBox2.Location = new Point(673, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(340, 156);
            groupBox2.TabIndex = 11;
            groupBox2.TabStop = false;
            groupBox2.Text = "Login";
            // 
            // button6
            // 
            button6.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button6.Location = new Point(924, 612);
            button6.Name = "button6";
            button6.Size = new Size(158, 41);
            button6.TabIndex = 12;
            button6.Text = "Upload";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1092, 665);
            Controls.Add(button6);
            Controls.Add(groupBox2);
            Controls.Add(textBox1);
            Controls.Add(groupBox1);
            Controls.Add(button3);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(txt_json);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox txt_email;
        private TextBox txt_password;
        private TextBox txt_json;
        private Button button2;
        private Label label1;
        private Button button3;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private GroupBox groupBox1;
        private Button button5;
        private Button button4;
        private Label label3;
        private Label label2;
        private NumericUpDown numericUpDown1;
        private TextBox textBox1;
        private GroupBox groupBox2;
        private Label label5;
        private Label label4;
        private NumericUpDown numericUpDown2;
        private Button button6;
    }
}