namespace UnusedGuidSearcher
{
    partial class MainForm
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
            this.TableComboBox = new System.Windows.Forms.ComboBox();
            this.GuidCountUpDown = new System.Windows.Forms.NumericUpDown();
            this.GoButton = new System.Windows.Forms.Button();
            this.consecutiveCheckBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.minNumericUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.GuidCountUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minNumericUpDown)).BeginInit();
            this.SuspendLayout();
            //
            // TableComboBox
            //
            this.TableComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TableComboBox.FormattingEnabled = true;
            this.TableComboBox.Location = new System.Drawing.Point(12, 12);
            this.TableComboBox.Name = "TableComboBox";
            this.TableComboBox.Size = new System.Drawing.Size(187, 21);
            this.TableComboBox.TabIndex = 0;
            //
            // GuidCountUpDown
            //
            this.GuidCountUpDown.Location = new System.Drawing.Point(129, 50);
            this.GuidCountUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.GuidCountUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.GuidCountUpDown.Name = "GuidCountUpDown";
            this.GuidCountUpDown.Size = new System.Drawing.Size(70, 20);
            this.GuidCountUpDown.TabIndex = 3;
            this.GuidCountUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            //
            // GoButton
            //
            this.GoButton.Location = new System.Drawing.Point(112, 78);
            this.GoButton.Name = "GoButton";
            this.GoButton.Size = new System.Drawing.Size(87, 20);
            this.GoButton.TabIndex = 6;
            this.GoButton.Text = "Go";
            this.GoButton.UseVisualStyleBackColor = true;
            this.GoButton.Click += new System.EventHandler(this.GoButtonClick);
            //
            // consecutiveCheckBox
            //
            this.consecutiveCheckBox.AutoSize = true;
            this.consecutiveCheckBox.ForeColor = System.Drawing.Color.White;
            this.consecutiveCheckBox.Location = new System.Drawing.Point(12, 51);
            this.consecutiveCheckBox.Name = "consecutiveCheckBox";
            this.consecutiveCheckBox.Size = new System.Drawing.Size(85, 17);
            this.consecutiveCheckBox.TabIndex = 7;
            this.consecutiveCheckBox.Text = "Consecutive";
            this.consecutiveCheckBox.UseVisualStyleBackColor = true;
            //
            // label1
            //
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(109, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "#";
            //
            // label2
            //
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(9, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = ">";
            //
            // minNumericUpDown
            //
            this.minNumericUpDown.Location = new System.Drawing.Point(28, 78);
            this.minNumericUpDown.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.minNumericUpDown.Name = "minNumericUpDown";
            this.minNumericUpDown.Size = new System.Drawing.Size(69, 20);
            this.minNumericUpDown.TabIndex = 10;
            //
            // MainForm
            //
            this.AcceptButton = this.GoButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(211, 113);
            this.Controls.Add(this.minNumericUpDown);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.consecutiveCheckBox);
            this.Controls.Add(this.GoButton);
            this.Controls.Add(this.GuidCountUpDown);
            this.Controls.Add(this.TableComboBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainForm";
            this.Text = "Unused Guid Search";
            this.Load += new System.EventHandler(this.MainFormLoad);
            ((System.ComponentModel.ISupportInitialize)(this.GuidCountUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox TableComboBox;
        private System.Windows.Forms.NumericUpDown GuidCountUpDown;
        private System.Windows.Forms.Button GoButton;
        private System.Windows.Forms.CheckBox consecutiveCheckBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown minNumericUpDown;

    }
}

