namespace sa
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
            groupBox1 = new GroupBox();
            button1 = new Button();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            checkBox1 = new CheckBox();
            groupBox2 = new GroupBox();
            button2 = new Button();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            checkBox2 = new CheckBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(checkBox1);
            groupBox1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = SystemColors.ButtonHighlight;
            groupBox1.Location = new Point(27, 58);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(524, 396);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Sign in";
            // 
            // button1
            // 
            button1.BackColor = Color.Navy;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(131, 321);
            button1.Name = "button1";
            button1.Size = new Size(222, 37);
            button1.TabIndex = 5;
            button1.Text = "Sign in";
            button1.UseVisualStyleBackColor = false;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(22, 195);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(449, 33);
            textBox2.TabIndex = 4;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(22, 103);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(449, 33);
            textBox1.TabIndex = 3;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(22, 162);
            label2.Name = "label2";
            label2.Size = new Size(105, 30);
            label2.TabIndex = 2;
            label2.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(22, 70);
            label1.Name = "label1";
            label1.Size = new Size(110, 30);
            label1.TabIndex = 1;
            label1.Text = "Username";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(22, 271);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(202, 29);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "Show me password";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(textBox3);
            groupBox2.Controls.Add(textBox4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(checkBox2);
            groupBox2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.ForeColor = SystemColors.ButtonHighlight;
            groupBox2.Location = new Point(664, 58);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(524, 396);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Sign up";
            // 
            // button2
            // 
            button2.BackColor = Color.Navy;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(131, 321);
            button2.Name = "button2";
            button2.Size = new Size(222, 37);
            button2.TabIndex = 5;
            button2.Text = "Sign up";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click_1;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(22, 195);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(449, 33);
            textBox3.TabIndex = 4;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(22, 103);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(449, 33);
            textBox4.TabIndex = 3;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(22, 162);
            label3.Name = "label3";
            label3.Size = new Size(105, 30);
            label3.TabIndex = 2;
            label3.Text = "Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(22, 70);
            label4.Name = "label4";
            label4.Size = new Size(110, 30);
            label4.TabIndex = 1;
            label4.Text = "Username";
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(22, 271);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(202, 29);
            checkBox2.TabIndex = 0;
            checkBox2.Text = "Show me password";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            ClientSize = new Size(1257, 535);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5);
            Name = "Form1";
            Text = "Sign in";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox textBox1;
        private Label label2;
        private Label label1;
        private CheckBox checkBox1;
        private Button button1;
        private TextBox textBox2;
        private GroupBox groupBox2;
        private Button button2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label3;
        private Label label4;
        private CheckBox checkBox2;
    }
}
