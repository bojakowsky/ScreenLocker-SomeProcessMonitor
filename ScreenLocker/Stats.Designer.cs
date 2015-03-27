namespace ScreenLocker
{
    partial class Stats
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
            this.label1 = new System.Windows.Forms.Label();
            this.gamingLabel = new System.Windows.Forms.Label();
            this.codingLabel = new System.Windows.Forms.Label();
            this.othersLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Wide Latin", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(37, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(364, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Minutes spent on:";
            // 
            // gamingLabel
            // 
            this.gamingLabel.AutoSize = true;
            this.gamingLabel.Font = new System.Drawing.Font("Wide Latin", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gamingLabel.ForeColor = System.Drawing.SystemColors.InfoText;
            this.gamingLabel.Location = new System.Drawing.Point(238, 64);
            this.gamingLabel.Name = "gamingLabel";
            this.gamingLabel.Size = new System.Drawing.Size(186, 29);
            this.gamingLabel.TabIndex = 1;
            this.gamingLabel.Text = "Gaming:";
            // 
            // codingLabel
            // 
            this.codingLabel.AutoSize = true;
            this.codingLabel.Font = new System.Drawing.Font("Wide Latin", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codingLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.codingLabel.Location = new System.Drawing.Point(238, 111);
            this.codingLabel.Name = "codingLabel";
            this.codingLabel.Size = new System.Drawing.Size(168, 29);
            this.codingLabel.TabIndex = 2;
            this.codingLabel.Text = "Coding:";
            // 
            // othersLabel
            // 
            this.othersLabel.AutoSize = true;
            this.othersLabel.Font = new System.Drawing.Font("Wide Latin", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.othersLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.othersLabel.Location = new System.Drawing.Point(238, 157);
            this.othersLabel.Name = "othersLabel";
            this.othersLabel.Size = new System.Drawing.Size(161, 29);
            this.othersLabel.TabIndex = 3;
            this.othersLabel.Text = "Others:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Wide Latin", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(37, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 29);
            this.label2.TabIndex = 6;
            this.label2.Text = "Others:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Wide Latin", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(37, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "Coding:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Wide Latin", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label4.Location = new System.Drawing.Point(37, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(186, 29);
            this.label4.TabIndex = 4;
            this.label4.Text = "Gaming:";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Stats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(449, 206);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.othersLabel);
            this.Controls.Add(this.codingLabel);
            this.Controls.Add(this.gamingLabel);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(449, 206);
            this.MinimizeBox = false;
            this.Name = "Stats";
            this.Opacity = 0.75D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Stats";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label gamingLabel;
        private System.Windows.Forms.Label codingLabel;
        private System.Windows.Forms.Label othersLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer timer1;
    }
}