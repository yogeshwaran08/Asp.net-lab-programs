namespace CalenderMonth
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
            resultLbl = new Label();
            label2 = new Label();
            caseTxt = new TextBox();
            lowerRad = new RadioButton();
            upperRad = new RadioButton();
            button1 = new Button();
            button2 = new Button();
            dateTimePicker1 = new DateTimePicker();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            dayLbl = new Label();
            monthLbl = new Label();
            yearLbl = new Label();
            SuspendLayout();
            // 
            // resultLbl
            // 
            resultLbl.AutoSize = true;
            resultLbl.Location = new Point(529, 347);
            resultLbl.Name = "resultLbl";
            resultLbl.Size = new Size(65, 20);
            resultLbl.TabIndex = 0;
            resultLbl.Text = "resultLbl";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(371, 47);
            label2.Name = "label2";
            label2.Size = new Size(97, 20);
            label2.TabIndex = 1;
            label2.Text = "Enter the text";
            // 
            // caseTxt
            // 
            caseTxt.Location = new Point(489, 44);
            caseTxt.Name = "caseTxt";
            caseTxt.Size = new Size(200, 27);
            caseTxt.TabIndex = 2;
            // 
            // lowerRad
            // 
            lowerRad.AutoSize = true;
            lowerRad.Location = new Point(414, 119);
            lowerRad.Name = "lowerRad";
            lowerRad.Size = new Size(90, 24);
            lowerRad.TabIndex = 3;
            lowerRad.TabStop = true;
            lowerRad.Text = "To Lower";
            lowerRad.UseVisualStyleBackColor = true;
            // 
            // upperRad
            // 
            upperRad.AutoSize = true;
            upperRad.Location = new Point(545, 119);
            upperRad.Name = "upperRad";
            upperRad.Size = new Size(89, 24);
            upperRad.TabIndex = 4;
            upperRad.TabStop = true;
            upperRad.Text = "To upper";
            upperRad.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(429, 257);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 5;
            button1.Text = "Convert";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(579, 257);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 6;
            button2.Text = "Clear";
            button2.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(39, 42);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 7;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(39, 136);
            label3.Name = "label3";
            label3.Size = new Size(35, 20);
            label3.TabIndex = 8;
            label3.Text = "Day";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(39, 196);
            label4.Name = "label4";
            label4.Size = new Size(52, 20);
            label4.TabIndex = 9;
            label4.Text = "Month";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(39, 266);
            label5.Name = "label5";
            label5.Size = new Size(37, 20);
            label5.TabIndex = 10;
            label5.Text = "Year";
            // 
            // dayLbl
            // 
            dayLbl.AutoSize = true;
            dayLbl.Location = new Point(148, 136);
            dayLbl.Name = "dayLbl";
            dayLbl.Size = new Size(53, 20);
            dayLbl.TabIndex = 11;
            dayLbl.Text = "dayLbl";
            // 
            // monthLbl
            // 
            monthLbl.AutoSize = true;
            monthLbl.Location = new Point(148, 196);
            monthLbl.Name = "monthLbl";
            monthLbl.Size = new Size(72, 20);
            monthLbl.TabIndex = 12;
            monthLbl.Text = "monthLbl";
            // 
            // yearLbl
            // 
            yearLbl.AutoSize = true;
            yearLbl.Location = new Point(148, 266);
            yearLbl.Name = "yearLbl";
            yearLbl.Size = new Size(57, 20);
            yearLbl.TabIndex = 13;
            yearLbl.Text = "yearLbl";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(yearLbl);
            Controls.Add(monthLbl);
            Controls.Add(dayLbl);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(dateTimePicker1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(upperRad);
            Controls.Add(lowerRad);
            Controls.Add(caseTxt);
            Controls.Add(label2);
            Controls.Add(resultLbl);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label resultLbl;
        private Label label2;
        private TextBox caseTxt;
        private RadioButton lowerRad;
        private RadioButton upperRad;
        private Button button1;
        private Button button2;
        private DateTimePicker dateTimePicker1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label dayLbl;
        private Label monthLbl;
        private Label yearLbl;
    }
}