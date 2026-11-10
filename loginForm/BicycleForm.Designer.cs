namespace loginForm
{
    partial class BicycleForm
    {
       
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            startTimeTxt = new TextBox();
            endTimeTxt = new TextBox();
            calculateRentBtn = new Button();
            closeBtn = new Button();
            totalTxt = new Label();
            textBox1 = new TextBox();
            backBtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Imprint MT Shadow", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(262, 32);
            label1.Name = "label1";
            label1.Size = new Size(248, 25);
            label1.TabIndex = 0;
            label1.Text = "Bicycle Renting System";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(172, 94);
            label2.Name = "label2";
            label2.Size = new Size(107, 15);
            label2.TabIndex = 1;
            label2.Text = "Enter starting time";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(172, 141);
            label3.Name = "label3";
            label3.Size = new Size(98, 15);
            label3.TabIndex = 2;
            label3.Text = "Enter return time";
            // 
            // startTimeTxt
            // 
            startTimeTxt.BackColor = SystemColors.ButtonShadow;
            startTimeTxt.Location = new Point(324, 88);
            startTimeTxt.Margin = new Padding(3, 2, 3, 2);
            startTimeTxt.MaxLength = 5;
            startTimeTxt.Name = "startTimeTxt";
            startTimeTxt.Size = new Size(146, 21);
            startTimeTxt.TabIndex = 3;
            // 
            // endTimeTxt
            // 
            endTimeTxt.BackColor = SystemColors.ButtonShadow;
            endTimeTxt.Location = new Point(324, 138);
            endTimeTxt.Margin = new Padding(3, 2, 3, 2);
            endTimeTxt.MaxLength = 5;
            endTimeTxt.Name = "endTimeTxt";
            endTimeTxt.Size = new Size(146, 21);
            endTimeTxt.TabIndex = 4;
            // 
            // calculateRentBtn
            // 
            calculateRentBtn.BackColor = SystemColors.AppWorkspace;
            calculateRentBtn.Location = new Point(150, 223);
            calculateRentBtn.Margin = new Padding(3, 2, 3, 2);
            calculateRentBtn.Name = "calculateRentBtn";
            calculateRentBtn.Size = new Size(162, 34);
            calculateRentBtn.TabIndex = 5;
            calculateRentBtn.Text = "Calculate rent amount";
            calculateRentBtn.UseVisualStyleBackColor = false;
            calculateRentBtn.Click += calculateRentBtn_Click;
            // 
            // closeBtn
            // 
            closeBtn.BackColor = SystemColors.AppWorkspace;
            closeBtn.Location = new Point(356, 223);
            closeBtn.Margin = new Padding(3, 2, 3, 2);
            closeBtn.Name = "closeBtn";
            closeBtn.Size = new Size(82, 34);
            closeBtn.TabIndex = 7;
            closeBtn.Text = "Logout";
            closeBtn.UseVisualStyleBackColor = false;
            closeBtn.Click += closeBtn_Click;
            // 
            // totalTxt
            // 
            totalTxt.AutoSize = true;
            totalTxt.Location = new Point(172, 186);
            totalTxt.Name = "totalTxt";
            totalTxt.Size = new Size(33, 15);
            totalTxt.TabIndex = 8;
            totalTxt.Text = "Total";
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.ButtonShadow;
            textBox1.ReadOnly = true;
            textBox1.Location = new Point(324, 180);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(146, 21);
            textBox1.TabIndex = 9;
            // 
            // backBtn
            // 
            backBtn.BackColor = SystemColors.ButtonShadow;
            backBtn.Location = new Point(493, 223);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(105, 34);
            backBtn.TabIndex = 10;
            backBtn.Text = "Back";
            backBtn.UseVisualStyleBackColor = false;
            backBtn.Click += backBtn_Click;
            // 
            // BicycleForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(700, 338);
            Controls.Add(backBtn);
            Controls.Add(textBox1);
            Controls.Add(totalTxt);
            Controls.Add(closeBtn);
            Controls.Add(calculateRentBtn);
            Controls.Add(endTimeTxt);
            Controls.Add(startTimeTxt);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "BicycleForm";
            Text = "BicycleForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox startTimeTxt;
        private TextBox endTimeTxt;
        private Button calculateRentBtn;
        private Button closeBtn;
        private Label totalTxt;
        private TextBox textBox1;
        private Button backBtn;
    }
}