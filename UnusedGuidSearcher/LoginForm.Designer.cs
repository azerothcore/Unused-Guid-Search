namespace UnusedGuidSearcher
{
    partial class LoginForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.DBBox = new System.Windows.Forms.TextBox();
            this.UserBox = new System.Windows.Forms.TextBox();
            this.HostBox = new System.Windows.Forms.TextBox();
            this.OkButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.PortBox = new System.Windows.Forms.TextBox();
            this.IsUsingNamedPipeCheckbox = new System.Windows.Forms.CheckBox();
            this.PipeBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            //
            // label1
            //
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(36, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "User:";
            //
            // label2
            //
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(36, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Host:";
            //
            // label4
            //
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(12, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Database:";
            //
            // label5
            //
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(12, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Password:";
            //
            // PasswordBox
            //
            this.PasswordBox.Location = new System.Drawing.Point(74, 32);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.Size = new System.Drawing.Size(100, 20);
            this.PasswordBox.TabIndex = 1;
            this.PasswordBox.UseSystemPasswordChar = true;
            //
            // DBBox
            //
            this.DBBox.Location = new System.Drawing.Point(74, 60);
            this.DBBox.Name = "DBBox";
            this.DBBox.Size = new System.Drawing.Size(100, 20);
            this.DBBox.TabIndex = 2;
            //
            // UserBox
            //
            this.UserBox.Location = new System.Drawing.Point(74, 6);
            this.UserBox.Name = "UserBox";
            this.UserBox.Size = new System.Drawing.Size(100, 20);
            this.UserBox.TabIndex = 0;
            //
            // HostBox
            //
            this.HostBox.Location = new System.Drawing.Point(74, 86);
            this.HostBox.Name = "HostBox";
            this.HostBox.Size = new System.Drawing.Size(100, 20);
            this.HostBox.TabIndex = 3;
            //
            // OkButton
            //
            this.OkButton.Location = new System.Drawing.Point(53, 181);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(75, 23);
            this.OkButton.TabIndex = 5;
            this.OkButton.Text = "Ok";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            //
            // label3
            //
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(36, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Port:";
            //
            // PortBox
            //
            this.PortBox.Location = new System.Drawing.Point(74, 138);
            this.PortBox.Name = "PortBox";
            this.PortBox.Size = new System.Drawing.Size(100, 20);
            this.PortBox.TabIndex = 7;
            this.PortBox.Text = "3306";
            //
            // IsUsingNamedPipeCheckbox
            //
            this.IsUsingNamedPipeCheckbox.AutoSize = true;
            this.IsUsingNamedPipeCheckbox.ForeColor = System.Drawing.Color.White;
            this.IsUsingNamedPipeCheckbox.Location = new System.Drawing.Point(21, 112);
            this.IsUsingNamedPipeCheckbox.Name = "IsUsingNamedPipeCheckbox";
            this.IsUsingNamedPipeCheckbox.Size = new System.Drawing.Size(47, 17);
            this.IsUsingNamedPipeCheckbox.TabIndex = 8;
            this.IsUsingNamedPipeCheckbox.Text = "Pipe";
            this.IsUsingNamedPipeCheckbox.UseVisualStyleBackColor = true;
            this.IsUsingNamedPipeCheckbox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            //
            // PipeBox
            //
            this.PipeBox.Location = new System.Drawing.Point(74, 112);
            this.PipeBox.Name = "PipeBox";
            this.PipeBox.Size = new System.Drawing.Size(100, 20);
            this.PipeBox.TabIndex = 9;
            //
            // LoginForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(185, 216);
            this.Controls.Add(this.PipeBox);
            this.Controls.Add(this.IsUsingNamedPipeCheckbox);
            this.Controls.Add(this.PortBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.HostBox);
            this.Controls.Add(this.UserBox);
            this.Controls.Add(this.DBBox);
            this.Controls.Add(this.PasswordBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "LoginForm";
            this.Text = "Unused Guid Search";
            this.Load += new System.EventHandler(this.LoginFormLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox PasswordBox;
        private System.Windows.Forms.TextBox DBBox;
        private System.Windows.Forms.TextBox UserBox;
        private System.Windows.Forms.TextBox HostBox;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PortBox;
        private System.Windows.Forms.CheckBox IsUsingNamedPipeCheckbox;
        private System.Windows.Forms.TextBox PipeBox;
    }
}