namespace ScreenLocker
{
    partial class Locker
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
            this.components = new System.ComponentModel.Container();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.ProcessesChecker = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.passwordUnlocker = new System.Windows.Forms.Button();
            this.passwordMismatch = new System.Windows.Forms.Label();
            this.ClockTextBox = new System.Windows.Forms.Label();
            this.DayLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // passwordBox
            // 
            this.passwordBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passwordBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.passwordBox.Location = new System.Drawing.Point(361, 266);
            this.passwordBox.Margin = new System.Windows.Forms.Padding(30);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.PasswordChar = '*';
            this.passwordBox.Size = new System.Drawing.Size(216, 29);
            this.passwordBox.TabIndex = 0;
            // 
            // ProcessesChecker
            // 
            this.ProcessesChecker.Enabled = true;
            this.ProcessesChecker.Tick += new System.EventHandler(this.ProcessesChecker_Tick);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(357, 237);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Type password to unlock";
            // 
            // passwordUnlocker
            // 
            this.passwordUnlocker.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passwordUnlocker.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.passwordUnlocker.Location = new System.Drawing.Point(583, 237);
            this.passwordUnlocker.Name = "passwordUnlocker";
            this.passwordUnlocker.Size = new System.Drawing.Size(86, 58);
            this.passwordUnlocker.TabIndex = 2;
            this.passwordUnlocker.Text = "Unlock";
            this.passwordUnlocker.UseVisualStyleBackColor = true;
            this.passwordUnlocker.Click += new System.EventHandler(this.passwordUnlocker_Click);
            // 
            // passwordMismatch
            // 
            this.passwordMismatch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passwordMismatch.AutoSize = true;
            this.passwordMismatch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.passwordMismatch.Location = new System.Drawing.Point(361, 296);
            this.passwordMismatch.Name = "passwordMismatch";
            this.passwordMismatch.Size = new System.Drawing.Size(60, 24);
            this.passwordMismatch.TabIndex = 3;
            this.passwordMismatch.Text = "label2";
            this.passwordMismatch.Visible = false;
            // 
            // ClockTextBox
            // 
            this.ClockTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ClockTextBox.AutoSize = true;
            this.ClockTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.ClockTextBox.Location = new System.Drawing.Point(820, 50);
            this.ClockTextBox.Name = "ClockTextBox";
            this.ClockTextBox.Size = new System.Drawing.Size(79, 29);
            this.ClockTextBox.TabIndex = 4;
            this.ClockTextBox.Text = "label2";
            // 
            // DayLabel
            // 
            this.DayLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DayLabel.AutoSize = true;
            this.DayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.DayLabel.Location = new System.Drawing.Point(820, 21);
            this.DayLabel.Name = "DayLabel";
            this.DayLabel.Size = new System.Drawing.Size(79, 29);
            this.DayLabel.TabIndex = 5;
            this.DayLabel.Text = "label3";
            // 
            // Locker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 559);
            this.ControlBox = false;
            this.Controls.Add(this.DayLabel);
            this.Controls.Add(this.ClockTextBox);
            this.Controls.Add(this.passwordMismatch);
            this.Controls.Add(this.passwordUnlocker);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passwordBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimizeBox = false;
            this.Name = "Locker";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Locker";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Locker_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button passwordUnlocker;
        private System.Windows.Forms.Label passwordMismatch;
        public System.Windows.Forms.Timer ProcessesChecker;
        private System.Windows.Forms.Label ClockTextBox;
        private System.Windows.Forms.Label DayLabel;

    }
}