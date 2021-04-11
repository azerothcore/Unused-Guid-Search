namespace UnusedGuidSearcher
{
    partial class ResultForm
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
            this.ResultBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ResultBox
            // 
            this.ResultBox.AcceptsReturn = true;
            this.ResultBox.AcceptsTab = true;
            this.ResultBox.Location = new System.Drawing.Point(13, 13);
            this.ResultBox.MaxLength = 1073741823;
            this.ResultBox.Multiline = true;
            this.ResultBox.Name = "ResultBox";
            this.ResultBox.ReadOnly = true;
            this.ResultBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ResultBox.Size = new System.Drawing.Size(186, 237);
            this.ResultBox.TabIndex = 0;
            // 
            // ResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(215, 262);
            this.Controls.Add(this.ResultBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ResultForm";
            this.Text = "Unused Guid Search";
            this.Load += new System.EventHandler(this.ResultFormLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ResultBox;
    }
}