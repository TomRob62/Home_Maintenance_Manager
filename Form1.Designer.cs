namespace Home_Maintenance_Manager
{
    partial class Form1
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
            ButtonsPanel = new Panel();
            MainenanceButton = new Button();
            SuppliesButton = new Button();
            ReminderButton = new Button();
            HomeButton = new Button();
            HomePanel = new Panel();
            ButtonsPanel.SuspendLayout();
            SuspendLayout();
            // 
            // ButtonsPanel
            // 
            ButtonsPanel.AutoSize = true;
            ButtonsPanel.BackColor = SystemColors.ControlDark;
            ButtonsPanel.Controls.Add(MainenanceButton);
            ButtonsPanel.Controls.Add(SuppliesButton);
            ButtonsPanel.Controls.Add(ReminderButton);
            ButtonsPanel.Controls.Add(HomeButton);
            ButtonsPanel.Dock = DockStyle.Left;
            ButtonsPanel.Location = new Point(0, 0);
            ButtonsPanel.MinimumSize = new Size(200, 0);
            ButtonsPanel.Name = "ButtonsPanel";
            ButtonsPanel.Size = new Size(200, 507);
            ButtonsPanel.TabIndex = 0;
            ButtonsPanel.Paint += panel1_Paint;
            // 
            // MainenanceButton
            // 
            MainenanceButton.Dock = DockStyle.Top;
            MainenanceButton.Location = new Point(0, 87);
            MainenanceButton.Name = "MainenanceButton";
            MainenanceButton.Size = new Size(200, 29);
            MainenanceButton.TabIndex = 6;
            MainenanceButton.Text = "Manage Maintenances";
            MainenanceButton.TextAlign = ContentAlignment.MiddleLeft;
            MainenanceButton.UseVisualStyleBackColor = true;
            MainenanceButton.Click += MainenanceButton_Click;
            // 
            // SuppliesButton
            // 
            SuppliesButton.Dock = DockStyle.Top;
            SuppliesButton.Location = new Point(0, 58);
            SuppliesButton.Name = "SuppliesButton";
            SuppliesButton.Size = new Size(200, 29);
            SuppliesButton.TabIndex = 5;
            SuppliesButton.Text = "Manage Supplies";
            SuppliesButton.TextAlign = ContentAlignment.MiddleLeft;
            SuppliesButton.UseVisualStyleBackColor = true;
            // 
            // ReminderButton
            // 
            ReminderButton.Dock = DockStyle.Top;
            ReminderButton.Location = new Point(0, 29);
            ReminderButton.Name = "ReminderButton";
            ReminderButton.Size = new Size(200, 29);
            ReminderButton.TabIndex = 4;
            ReminderButton.Text = "Manage Reminders";
            ReminderButton.TextAlign = ContentAlignment.MiddleLeft;
            ReminderButton.UseVisualStyleBackColor = true;
            // 
            // HomeButton
            // 
            HomeButton.Dock = DockStyle.Top;
            HomeButton.Location = new Point(0, 0);
            HomeButton.Name = "HomeButton";
            HomeButton.Size = new Size(200, 29);
            HomeButton.TabIndex = 3;
            HomeButton.Text = "Home";
            HomeButton.TextAlign = ContentAlignment.MiddleLeft;
            HomeButton.UseVisualStyleBackColor = true;
            HomeButton.Click += HomeButton_Click;
            // 
            // HomePanel
            // 
            HomePanel.AutoSize = true;
            HomePanel.Dock = DockStyle.Fill;
            HomePanel.Location = new Point(200, 0);
            HomePanel.Name = "HomePanel";
            HomePanel.Size = new Size(616, 507);
            HomePanel.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(816, 507);
            Controls.Add(HomePanel);
            Controls.Add(ButtonsPanel);
            Name = "Form1";
            Text = "Home Maintenance Manager";
            Load += Form1_Load;
            ButtonsPanel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel ButtonsPanel;
        private Button HomeButton;
        private Button MainenanceButton;
        private Button SuppliesButton;
        private Button ReminderButton;
        private Panel HomePanel;
    }
}