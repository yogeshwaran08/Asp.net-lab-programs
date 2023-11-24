namespace Registration_Form
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
            label1 = new Label();
            label2 = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            label3 = new Label();
            resultLbl = new Label();
            label5 = new Label();
            uname = new TextBox();
            pword = new TextBox();
            cnfPword = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(254, 66);
            label1.Name = "label1";
            label1.Size = new Size(270, 35);
            label1.TabIndex = 0;
            label1.Text = "Register Your account";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(243, 176);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 1;
            label2.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(184, 285);
            label3.Name = "label3";
            label3.Size = new Size(129, 20);
            label3.TabIndex = 2;
            label3.Text = "Confirm password";
            // 
            // resultLbl
            // 
            resultLbl.AutoSize = true;
            resultLbl.Location = new Point(268, 397);
            resultLbl.Name = "resultLbl";
            resultLbl.Size = new Size(50, 20);
            resultLbl.TabIndex = 3;
            resultLbl.Text = "label4";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(243, 227);
            label5.Name = "label5";
            label5.Size = new Size(70, 20);
            label5.TabIndex = 4;
            label5.Text = "Password";
            // 
            // uname
            // 
            uname.Location = new Point(325, 176);
            uname.Name = "uname";
            uname.PlaceholderText = "Enter your username";
            uname.Size = new Size(199, 27);
            uname.TabIndex = 5;
            // 
            // pword
            // 
            pword.Location = new Point(325, 224);
            pword.Name = "pword";
            pword.PasswordChar = '*';
            pword.PlaceholderText = "Enter your password";
            pword.Size = new Size(199, 27);
            pword.TabIndex = 6;
            pword.Text = "s";
            pword.TextChanged += textBox2_TextChanged;
            // 
            // cnfPword
            // 
            cnfPword.Location = new Point(325, 278);
            cnfPword.Name = "cnfPword";
            cnfPword.PasswordChar = '*';
            cnfPword.PlaceholderText = "Confirm your password";
            cnfPword.Size = new Size(199, 27);
            cnfPword.TabIndex = 7;
            // 
            // button1
            // 
            button1.Location = new Point(126, 342);
            button1.Name = "button1";
            button1.Size = new Size(134, 29);
            button1.TabIndex = 8;
            button1.Text = "Register now";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(325, 342);
            button2.Name = "button2";
            button2.Size = new Size(108, 29);
            button2.TabIndex = 9;
            button2.Text = "Clear";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(484, 342);
            button3.Name = "button3";
            button3.Size = new Size(108, 29);
            button3.TabIndex = 10;
            button3.Text = "Exit";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(cnfPword);
            Controls.Add(pword);
            Controls.Add(uname);
            Controls.Add(label5);
            Controls.Add(resultLbl);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Registration form";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label label3;
        private Label resultLbl;
        private Label label5;
        private TextBox uname;
        private TextBox pword;
        private TextBox cnfPword;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}