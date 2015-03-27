namespace ScreenLocker
{
    partial class Tray
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing && (components != null))
        //    {
        //        components.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.processesTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // processesTimer
            // 
            this.processesTimer.Enabled = true;
            this.processesTimer.Interval = 60000;
            this.processesTimer.Tick += new System.EventHandler(this.processesTimer_Tick);
            // 
            // Tray
            // 
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Name = "Tray";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Timer processesTimer;

    }
}

