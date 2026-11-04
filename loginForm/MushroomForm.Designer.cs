namespace loginForm
{
    partial class MushroomForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            revealMushroomBtn = new Button();
            yesForest = new RadioButton();
            noForest = new RadioButton();
            forestBox = new GroupBox();
            convexBox = new GroupBox();
            noConvex = new RadioButton();
            yesConvex = new RadioButton();
            ringBox = new GroupBox();
            noRing = new RadioButton();
            yesRing = new RadioButton();
            gillsBox = new GroupBox();
            noGills = new RadioButton();
            yesGills = new RadioButton();
            closeBtn = new Button();
            backBtn = new Button();
            forestBox.SuspendLayout();
            convexBox.SuspendLayout();
            ringBox.SuspendLayout();
            gillsBox.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Imprint MT Shadow", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(171, 37);
            label1.Name = "label1";
            label1.Size = new Size(294, 25);
            label1.TabIndex = 0;
            label1.Text = "Mushroom Guessing System";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(47, 90);
            label2.Name = "label2";
            label2.Size = new Size(221, 15);
            label2.TabIndex = 1;
            label2.Text = "Does your mushroom grow in a forest?";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(47, 142);
            label3.Name = "label3";
            label3.Size = new Size(236, 15);
            label3.TabIndex = 2;
            label3.Text = "Does your mushroom have a convex cup?";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(47, 195);
            label4.Name = "label4";
            label4.Size = new Size(197, 15);
            label4.TabIndex = 3;
            label4.Text = "Does your mushroom have a ring?";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(47, 244);
            label5.Name = "label5";
            label5.Size = new Size(189, 15);
            label5.TabIndex = 4;
            label5.Text = "Does your mushroom have gills?";
            // 
            // revealMushroomBtn
            // 
            revealMushroomBtn.BackColor = SystemColors.ButtonShadow;
            revealMushroomBtn.Location = new Point(144, 290);
            revealMushroomBtn.Margin = new Padding(3, 2, 3, 2);
            revealMushroomBtn.Name = "revealMushroomBtn";
            revealMushroomBtn.Size = new Size(139, 37);
            revealMushroomBtn.TabIndex = 5;
            revealMushroomBtn.Text = "Reveal Mushroom";
            revealMushroomBtn.UseVisualStyleBackColor = false;
            revealMushroomBtn.Click += revealMushroomBtn_Click;
            // 
            // yesForest
            // 
            yesForest.AutoSize = true;
            yesForest.BackColor = SystemColors.ActiveCaption;
            yesForest.Location = new Point(15, 11);
            yesForest.Margin = new Padding(3, 2, 3, 2);
            yesForest.Name = "yesForest";
            yesForest.Size = new Size(45, 19);
            yesForest.TabIndex = 11;
            yesForest.TabStop = true;
            yesForest.Text = "Yes";
            yesForest.UseVisualStyleBackColor = false;
            // 
            // noForest
            // 
            noForest.AutoSize = true;
            noForest.Location = new Point(100, 11);
            noForest.Margin = new Padding(3, 2, 3, 2);
            noForest.Name = "noForest";
            noForest.Size = new Size(41, 19);
            noForest.TabIndex = 12;
            noForest.TabStop = true;
            noForest.Text = "No";
            noForest.UseVisualStyleBackColor = true;
            // 
            // forestBox
            // 
            forestBox.Controls.Add(noForest);
            forestBox.Controls.Add(yesForest);
            forestBox.Location = new Point(324, 77);
            forestBox.Margin = new Padding(3, 2, 3, 2);
            forestBox.Name = "forestBox";
            forestBox.Padding = new Padding(3, 2, 3, 2);
            forestBox.Size = new Size(186, 41);
            forestBox.TabIndex = 19;
            forestBox.TabStop = false;
            forestBox.Enter += groupBox1_Enter;
            // 
            // convexBox
            // 
            convexBox.Controls.Add(noConvex);
            convexBox.Controls.Add(yesConvex);
            convexBox.Location = new Point(324, 130);
            convexBox.Margin = new Padding(3, 2, 3, 2);
            convexBox.Name = "convexBox";
            convexBox.Padding = new Padding(3, 2, 3, 2);
            convexBox.Size = new Size(186, 41);
            convexBox.TabIndex = 20;
            convexBox.TabStop = false;
            // 
            // noConvex
            // 
            noConvex.AutoSize = true;
            noConvex.Location = new Point(100, 11);
            noConvex.Margin = new Padding(3, 2, 3, 2);
            noConvex.Name = "noConvex";
            noConvex.Size = new Size(41, 19);
            noConvex.TabIndex = 12;
            noConvex.TabStop = true;
            noConvex.Text = "No";
            noConvex.UseVisualStyleBackColor = true;
            // 
            // yesConvex
            // 
            yesConvex.AutoSize = true;
            yesConvex.Location = new Point(15, 11);
            yesConvex.Margin = new Padding(3, 2, 3, 2);
            yesConvex.Name = "yesConvex";
            yesConvex.Size = new Size(45, 19);
            yesConvex.TabIndex = 11;
            yesConvex.TabStop = true;
            yesConvex.Text = "Yes";
            yesConvex.UseVisualStyleBackColor = true;
            // 
            // ringBox
            // 
            ringBox.Controls.Add(noRing);
            ringBox.Controls.Add(yesRing);
            ringBox.Location = new Point(324, 182);
            ringBox.Margin = new Padding(3, 2, 3, 2);
            ringBox.Name = "ringBox";
            ringBox.Padding = new Padding(3, 2, 3, 2);
            ringBox.Size = new Size(186, 41);
            ringBox.TabIndex = 20;
            ringBox.TabStop = false;
            // 
            // noRing
            // 
            noRing.AutoSize = true;
            noRing.Location = new Point(100, 11);
            noRing.Margin = new Padding(3, 2, 3, 2);
            noRing.Name = "noRing";
            noRing.Size = new Size(41, 19);
            noRing.TabIndex = 12;
            noRing.TabStop = true;
            noRing.Text = "No";
            noRing.UseVisualStyleBackColor = true;
            // 
            // yesRing
            // 
            yesRing.AutoSize = true;
            yesRing.Location = new Point(15, 11);
            yesRing.Margin = new Padding(3, 2, 3, 2);
            yesRing.Name = "yesRing";
            yesRing.Size = new Size(45, 19);
            yesRing.TabIndex = 11;
            yesRing.TabStop = true;
            yesRing.Text = "Yes";
            yesRing.UseVisualStyleBackColor = true;
            // 
            // gillsBox
            // 
            gillsBox.Controls.Add(noGills);
            gillsBox.Controls.Add(yesGills);
            gillsBox.Location = new Point(324, 231);
            gillsBox.Margin = new Padding(3, 2, 3, 2);
            gillsBox.Name = "gillsBox";
            gillsBox.Padding = new Padding(3, 2, 3, 2);
            gillsBox.Size = new Size(186, 41);
            gillsBox.TabIndex = 20;
            gillsBox.TabStop = false;
            // 
            // noGills
            // 
            noGills.AutoSize = true;
            noGills.Location = new Point(100, 11);
            noGills.Margin = new Padding(3, 2, 3, 2);
            noGills.Name = "noGills";
            noGills.Size = new Size(41, 19);
            noGills.TabIndex = 12;
            noGills.TabStop = true;
            noGills.Text = "No";
            noGills.UseVisualStyleBackColor = true;
            // 
            // yesGills
            // 
            yesGills.AutoSize = true;
            yesGills.Location = new Point(15, 11);
            yesGills.Margin = new Padding(3, 2, 3, 2);
            yesGills.Name = "yesGills";
            yesGills.Size = new Size(45, 19);
            yesGills.TabIndex = 11;
            yesGills.TabStop = true;
            yesGills.Text = "Yes";
            yesGills.UseVisualStyleBackColor = true;
            // 
            // closeBtn
            // 
            closeBtn.BackColor = SystemColors.ButtonShadow;
            closeBtn.Location = new Point(339, 290);
            closeBtn.Margin = new Padding(3, 2, 3, 2);
            closeBtn.Name = "closeBtn";
            closeBtn.Size = new Size(106, 37);
            closeBtn.TabIndex = 21;
            closeBtn.Text = "Logout";
            closeBtn.UseVisualStyleBackColor = false;
            closeBtn.Click += closeBtn_Click;
            // 
            // backBtn
            // 
            backBtn.BackColor = SystemColors.ButtonShadow;
            backBtn.Location = new Point(485, 290);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(97, 36);
            backBtn.TabIndex = 22;
            backBtn.Text = "Back";
            backBtn.UseVisualStyleBackColor = false;
            backBtn.Click += backBtn_Click;
            // 
            // MushroomForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(700, 338);
            Controls.Add(backBtn);
            Controls.Add(closeBtn);
            Controls.Add(gillsBox);
            Controls.Add(ringBox);
            Controls.Add(convexBox);
            Controls.Add(forestBox);
            Controls.Add(revealMushroomBtn);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "MushroomForm";
            Text = "MushroomFormcs";
            Load += MushroomForm_Load;
            forestBox.ResumeLayout(false);
            forestBox.PerformLayout();
            convexBox.ResumeLayout(false);
            convexBox.PerformLayout();
            ringBox.ResumeLayout(false);
            ringBox.PerformLayout();
            gillsBox.ResumeLayout(false);
            gillsBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button revealMushroomBtn;
        private RadioButton yesForest;
        private RadioButton noForest;
        private GroupBox forestBox;
        private GroupBox convexBox;
        private RadioButton noConvex;
        private RadioButton yesConvex;
        private GroupBox ringBox;
        private RadioButton noRing;
        private RadioButton yesRing;
        private GroupBox gillsBox;
        private RadioButton noGills;
        private RadioButton yesGills;
        private Button closeBtn;
        private Button backBtn;
    }
}