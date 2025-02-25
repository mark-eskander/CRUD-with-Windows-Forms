namespace ADO_1
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
            ShowData = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            Update_btn = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button5 = new Button();
            ((System.ComponentModel.ISupportInitialize)ShowData).BeginInit();
            SuspendLayout();
            // 
            // ShowData
            // 
            ShowData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ShowData.Location = new Point(508, 21);
            ShowData.Name = "ShowData";
            ShowData.RowHeadersWidth = 51;
            ShowData.Size = new Size(715, 378);
            ShowData.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Location = new Point(983, 446);
            button1.Name = "button1";
            button1.Size = new Size(134, 60);
            button1.TabIndex = 1;
            button1.Text = "Refresh";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Red;
            button2.Location = new Point(983, 582);
            button2.Name = "button2";
            button2.Size = new Size(134, 60);
            button2.TabIndex = 2;
            button2.Text = "Delete";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.Highlight;
            button3.Location = new Point(630, 437);
            button3.Name = "button3";
            button3.Size = new Size(134, 60);
            button3.TabIndex = 3;
            button3.Text = "Insert";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // Update_btn
            // 
            Update_btn.BackColor = Color.YellowGreen;
            Update_btn.Location = new Point(630, 582);
            Update_btn.Name = "Update_btn";
            Update_btn.Size = new Size(134, 60);
            Update_btn.TabIndex = 4;
            Update_btn.Text = "Update";
            Update_btn.UseVisualStyleBackColor = false;
            Update_btn.Click += Update_btn_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(77, 50);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(170, 27);
            textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(15, 204);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(323, 27);
            textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(12, 317);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(323, 27);
            textBox3.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 50);
            label1.Name = "label1";
            label1.Size = new Size(56, 20);
            label1.TabIndex = 8;
            label1.Text = "Dep ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 166);
            label2.Name = "label2";
            label2.Size = new Size(80, 20);
            label2.TabIndex = 9;
            label2.Text = "DEP Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 285);
            label3.Name = "label3";
            label3.Size = new Size(117, 20);
            label3.TabIndex = 10;
            label3.Text = "Dep Describtion";
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(0, 192, 192);
            button5.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button5.Location = new Point(771, 516);
            button5.Name = "button5";
            button5.Size = new Size(196, 49);
            button5.TabIndex = 11;
            button5.Text = "Save To DataBase";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1235, 654);
            Controls.Add(button5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(Update_btn);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(ShowData);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)ShowData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView ShowData;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button Update_btn;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button5;
    }
}
