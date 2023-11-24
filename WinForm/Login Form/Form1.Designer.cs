namespace Login_Form
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
            label3 = new Label();
            resultLbl = new Label();
            uname = new TextBox();
            pword = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(310, 75);
            label1.Name = "label1";
            label1.Size = new Size(133, 31);
            label1.TabIndex = 0;
            label1.Text = "Login Form";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(231, 161);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 1;
            label2.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(231, 227);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 2;
            label3.Text = "Password";
            // 
            // resultLbl
            // 
            resultLbl.AutoSize = true;
            resultLbl.Location = new Point(268, 354);
            resultLbl.Name = "resultLbl";
            resultLbl.RightToLeft = RightToLeft.No;
            resultLbl.Size = new Size(50, 20);
            resultLbl.TabIndex = 3;
            resultLbl.Text = "label4";
            resultLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // uname
            // 
            uname.Location = new Point(310, 161);
            uname.Name = "uname";
            uname.PlaceholderText = "enter your username";
            uname.Size = new Size(231, 27);
            uname.TabIndex = 4;
            // 
            // pword
            // 
            pword.Location = new Point(310, 220);
            pword.Name = "pword";
            pword.PasswordChar = '*';
            pword.PlaceholderText = "enter your password";
            pword.Size = new Size(231, 27);
            pword.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(333, 291);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 6;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(pword);
            Controls.Add(uname);
            Controls.Add(resultLbl);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Login Form";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label resultLbl;
        private TextBox uname;
        private TextBox pword;
        private Button button1;
    }
}