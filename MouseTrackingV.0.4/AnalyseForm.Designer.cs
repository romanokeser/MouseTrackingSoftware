namespace MouseTrackingV._0._4
{
    partial class AnalyseForm
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
            this.buttonCloseAnalyser = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBoxRightClick = new System.Windows.Forms.CheckBox();
            this.checkBoxLeftClick = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonCloseAnalyser
            // 
            this.buttonCloseAnalyser.Location = new System.Drawing.Point(539, 572);
            this.buttonCloseAnalyser.Name = "buttonCloseAnalyser";
            this.buttonCloseAnalyser.Size = new System.Drawing.Size(114, 23);
            this.buttonCloseAnalyser.TabIndex = 0;
            this.buttonCloseAnalyser.Text = "Close Analyser";
            this.buttonCloseAnalyser.UseVisualStyleBackColor = true;
            this.buttonCloseAnalyser.Click += new System.EventHandler(this.buttonCloseAnalyser_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(946, 508);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // checkBoxRightClick
            // 
            this.checkBoxRightClick.AutoSize = true;
            this.checkBoxRightClick.Checked = true;
            this.checkBoxRightClick.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxRightClick.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxRightClick.Location = new System.Drawing.Point(-1, 3);
            this.checkBoxRightClick.Name = "checkBoxRightClick";
            this.checkBoxRightClick.Size = new System.Drawing.Size(91, 21);
            this.checkBoxRightClick.TabIndex = 2;
            this.checkBoxRightClick.Text = "Right click";
            this.checkBoxRightClick.UseVisualStyleBackColor = true;
            // 
            // checkBoxLeftClick
            // 
            this.checkBoxLeftClick.AutoSize = true;
            this.checkBoxLeftClick.Checked = true;
            this.checkBoxLeftClick.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxLeftClick.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxLeftClick.Location = new System.Drawing.Point(-1, 31);
            this.checkBoxLeftClick.Name = "checkBoxLeftClick";
            this.checkBoxLeftClick.Size = new System.Drawing.Size(82, 21);
            this.checkBoxLeftClick.TabIndex = 3;
            this.checkBoxLeftClick.Text = "Left click";
            this.checkBoxLeftClick.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(51)))), ((int)(((byte)(69)))));
            this.panel2.Controls.Add(this.checkBoxRightClick);
            this.panel2.Controls.Add(this.checkBoxLeftClick);
            this.panel2.Location = new System.Drawing.Point(973, 37);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(93, 60);
            this.panel2.TabIndex = 4;
            // 
            // AnalyseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(27)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(1102, 607);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonCloseAnalyser);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AnalyseForm";
            this.Opacity = 0.98D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AnalyseForm";
            this.Load += new System.EventHandler(this.AnalyseForm_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCloseAnalyser;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox checkBoxRightClick;
        private System.Windows.Forms.CheckBox checkBoxLeftClick;
        private System.Windows.Forms.Panel panel2;
    }
}