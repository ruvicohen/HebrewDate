namespace HebrewDate
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
            comboBoxMonth = new ComboBox();
            comboBoxDay = new ComboBox();
            comboBoxDayInMonth = new ComboBox();
            comboBoxYear = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // comboBoxMonth
            // 
            comboBoxMonth.FormattingEnabled = true;
            comboBoxMonth.Location = new Point(213, 95);
            comboBoxMonth.Name = "comboBoxMonth";
            comboBoxMonth.Size = new Size(151, 28);
            comboBoxMonth.TabIndex = 0;
            // 
            // comboBoxDay
            // 
            comboBoxDay.FormattingEnabled = true;
            comboBoxDay.Location = new Point(527, 95);
            comboBoxDay.Name = "comboBoxDay";
            comboBoxDay.Size = new Size(151, 28);
            comboBoxDay.TabIndex = 1;
            // 
            // comboBoxDayInMonth
            // 
            comboBoxDayInMonth.FormattingEnabled = true;
            comboBoxDayInMonth.Location = new Point(370, 95);
            comboBoxDayInMonth.Name = "comboBoxDayInMonth";
            comboBoxDayInMonth.Size = new Size(151, 28);
            comboBoxDayInMonth.TabIndex = 2;
            // 
            // comboBoxYear
            // 
            comboBoxYear.FormattingEnabled = true;
            comboBoxYear.Location = new Point(56, 95);
            comboBoxYear.Name = "comboBoxYear";
            comboBoxYear.Size = new Size(151, 28);
            comboBoxYear.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(607, 64);
            label1.Name = "label1";
            label1.Size = new Size(74, 20);
            label1.TabIndex = 4;
            label1.Text = "יום בשבוע";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(430, 64);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 5;
            label2.Text = "יום בחודש";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(300, 64);
            label3.Name = "label3";
            label3.Size = new Size(42, 20);
            label3.TabIndex = 6;
            label3.Text = "חודש";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(141, 64);
            label4.Name = "label4";
            label4.Size = new Size(37, 20);
            label4.TabIndex = 7;
            label4.Text = "שנה";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(325, 20);
            label5.Name = "label5";
            label5.Size = new Size(97, 20);
            label5.TabIndex = 8;
            label5.Text = "כתיבת תאריך";
            // 
            // button1
            // 
            button1.Location = new Point(314, 373);
            button1.Name = "button1";
            button1.Size = new Size(132, 29);
            button1.TabIndex = 9;
            button1.Text = "קבלת תאריך";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBoxYear);
            Controls.Add(comboBoxDayInMonth);
            Controls.Add(comboBoxDay);
            Controls.Add(comboBoxMonth);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxMonth;
        private ComboBox comboBoxDay;
        private ComboBox comboBoxDayInMonth;
        private ComboBox comboBoxYear;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button button1;
    }
}
