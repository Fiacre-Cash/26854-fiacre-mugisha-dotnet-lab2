namespace loginForm
{
    partial class MenuForm
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
            bicycleBtn = new Button();
            mushroomBtn = new Button();
            titleMenu = new Label();
            SuspendLayout();
            // 
            // bicycleBtn
            // 
            bicycleBtn.BackColor = SystemColors.ButtonShadow;
            bicycleBtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bicycleBtn.Location = new Point(211, 172);
            bicycleBtn.Margin = new Padding(3, 2, 3, 2);
            bicycleBtn.Name = "bicycleBtn";
            bicycleBtn.Size = new Size(94, 35);
            bicycleBtn.TabIndex = 0;
            bicycleBtn.Text = "Bicycle";
            bicycleBtn.UseVisualStyleBackColor = false;
            bicycleBtn.Click += bicycleBtn_Click;
            // 
            // mushroomBtn
            // 
            mushroomBtn.BackColor = SystemColors.ButtonShadow;
            mushroomBtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mushroomBtn.Location = new Point(448, 172);
            mushroomBtn.Margin = new Padding(3, 2, 3, 2);
            mushroomBtn.Name = "mushroomBtn";
            mushroomBtn.Size = new Size(118, 35);
            mushroomBtn.TabIndex = 1;
            mushroomBtn.Text = "Mushroom";
            mushroomBtn.UseVisualStyleBackColor = false;
            mushroomBtn.Click += mushroomBtn_Click;
            // 
            // titleMenu
            // 
            titleMenu.AutoSize = true;
            titleMenu.Font = new Font("Imprint MT Shadow", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            titleMenu.Location = new Point(121, 62);
            titleMenu.Name = "titleMenu";
            titleMenu.Size = new Size(538, 25);
            titleMenu.TabIndex = 2;
            titleMenu.Text = "Welcome to the menu. Select the lab you want to use.";
            // 
            // MenuForm
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 383);
            Controls.Add(titleMenu);
            Controls.Add(mushroomBtn);
            Controls.Add(bicycleBtn);
            Font = new Font("Arial Black", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 2, 3, 2);
            Name = "MenuForm";
            Text = "Menu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button bicycleBtn;
        private Button mushroomBtn;
        private Label titleMenu;
    }
}