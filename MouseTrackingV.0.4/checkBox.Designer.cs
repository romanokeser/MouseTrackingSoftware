namespace MouseTrackingV._0._4
{
    partial class checkBox
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
            this.checkBox1_CheckedChanged = new System.Windows.Forms.CheckBox();
            this.buttonOKNeverShowAgain = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(114, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please use this option only if you\'re left-handed!";
            // 
            // checkBox1_CheckedChanged
            // 
            this.checkBox1_CheckedChanged.AutoSize = true;
            this.checkBox1_CheckedChanged.Location = new System.Drawing.Point(117, 94);
            this.checkBox1_CheckedChanged.Name = "checkBox1_CheckedChanged";
            this.checkBox1_CheckedChanged.Size = new System.Drawing.Size(175, 17);
            this.checkBox1_CheckedChanged.TabIndex = 1;
            this.checkBox1_CheckedChanged.Text = "Don\'t show this message again.";
            this.checkBox1_CheckedChanged.UseVisualStyleBackColor = true;
            this.checkBox1_CheckedChanged.CheckedChanged += new System.EventHandler(this.checkBox_Load);
            // 
            // buttonOKNeverShowAgain
            // 
            this.buttonOKNeverShowAgain.Location = new System.Drawing.Point(163, 134);
            this.buttonOKNeverShowAgain.Name = "buttonOKNeverShowAgain";
            this.buttonOKNeverShowAgain.Size = new System.Drawing.Size(75, 23);
            this.buttonOKNeverShowAgain.TabIndex = 2;
            this.buttonOKNeverShowAgain.Text = "OK";
            this.buttonOKNeverShowAgain.UseVisualStyleBackColor = true;
            // 
            // checkBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 186);
            this.Controls.Add(this.buttonOKNeverShowAgain);
            this.Controls.Add(this.checkBox1_CheckedChanged);
            this.Controls.Add(this.label1);
            this.Name = "checkBox";
            this.Text = "checkBox";
            this.Load += new System.EventHandler(this.checkBox_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox1_CheckedChanged;
        private System.Windows.Forms.Button buttonOKNeverShowAgain;
    }
}