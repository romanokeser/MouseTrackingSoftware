namespace MouseTrackingV._0._4
{
    partial class MyRecordsForm
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
            this.buttonCloseForm3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.listBoxAllRecords = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // buttonCloseForm3
            // 
            this.buttonCloseForm3.Location = new System.Drawing.Point(85, 12);
            this.buttonCloseForm3.Name = "buttonCloseForm3";
            this.buttonCloseForm3.Size = new System.Drawing.Size(75, 23);
            this.buttonCloseForm3.TabIndex = 0;
            this.buttonCloseForm3.Text = "Close";
            this.buttonCloseForm3.UseVisualStyleBackColor = true;
            this.buttonCloseForm3.Click += new System.EventHandler(this.buttonCloseForm3_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(328, 65);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(205, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Open Analyse Form";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBoxAllRecords
            // 
            this.listBoxAllRecords.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(80)))), ((int)(((byte)(102)))));
            this.listBoxAllRecords.FormattingEnabled = true;
            this.listBoxAllRecords.Location = new System.Drawing.Point(85, 95);
            this.listBoxAllRecords.Name = "listBoxAllRecords";
            this.listBoxAllRecords.Size = new System.Drawing.Size(1103, 290);
            this.listBoxAllRecords.TabIndex = 2;
            this.listBoxAllRecords.SelectedIndexChanged += new System.EventHandler(this.listBoxAllRecords_SelectedIndexChanged);
            // 
            // MyRecordsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(17)))), ((int)(((byte)(23)))));
            this.ClientSize = new System.Drawing.Size(1325, 435);
            this.Controls.Add(this.listBoxAllRecords);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonCloseForm3);
            this.Name = "MyRecordsForm";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.MyRecordsForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCloseForm3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBoxAllRecords;
    }
}