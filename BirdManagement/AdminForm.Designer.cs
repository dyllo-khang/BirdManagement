namespace BirdManagement
{
    partial class AdminForm
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
            panelMeunu = new Panel();
            panelTitle = new Panel();
            panelChild = new Panel();
            SuspendLayout();
            // 
            // panelMeunu
            // 
            panelMeunu.Dock = DockStyle.Left;
            panelMeunu.Location = new Point(0, 0);
            panelMeunu.Name = "panelMeunu";
            panelMeunu.Size = new Size(297, 846);
            panelMeunu.TabIndex = 0;
            // 
            // panelTitle
            // 
            panelTitle.Dock = DockStyle.Top;
            panelTitle.Location = new Point(297, 0);
            panelTitle.Name = "panelTitle";
            panelTitle.Size = new Size(1012, 134);
            panelTitle.TabIndex = 1;
            // 
            // panelChild
            // 
            panelChild.Dock = DockStyle.Fill;
            panelChild.Location = new Point(297, 134);
            panelChild.Name = "panelChild";
            panelChild.Size = new Size(1012, 712);
            panelChild.TabIndex = 2;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1309, 846);
            Controls.Add(panelChild);
            Controls.Add(panelTitle);
            Controls.Add(panelMeunu);
            Name = "AdminForm";
            Text = "AdminForm";
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMeunu;
        private Panel panelTitle;
        private Panel panelChild;
    }
}