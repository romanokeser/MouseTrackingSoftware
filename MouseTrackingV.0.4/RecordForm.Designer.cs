namespace MouseTrackingV._0._4
{
    partial class RecordForm
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
            this.buttonRecord = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.scrResLabel = new System.Windows.Forms.Label();
            this.labelRecName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButtonRightHand = new System.Windows.Forms.RadioButton();
            this.radioButtonLeftHand = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // buttonRecord
            // 
            this.buttonRecord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.buttonRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRecord.Font = new System.Drawing.Font("Yu Gothic Light", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRecord.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRecord.Location = new System.Drawing.Point(300, 186);
            this.buttonRecord.Name = "buttonRecord";
            this.buttonRecord.Size = new System.Drawing.Size(140, 33);
            this.buttonRecord.TabIndex = 0;
            this.buttonRecord.Text = "Record";
            this.buttonRecord.UseVisualStyleBackColor = false;
            this.buttonRecord.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.Enabled = false;
            this.buttonStop.Font = new System.Drawing.Font("Yu Gothic Light", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStop.Location = new System.Drawing.Point(300, 256);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(140, 33);
            this.buttonStop.TabIndex = 1;
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.button2_Click);
            // 
            // scrResLabel
            // 
            this.scrResLabel.AutoSize = true;
            this.scrResLabel.BackColor = System.Drawing.Color.White;
            this.scrResLabel.Location = new System.Drawing.Point(521, 425);
            this.scrResLabel.Name = "scrResLabel";
            this.scrResLabel.Size = new System.Drawing.Size(60, 13);
            this.scrResLabel.TabIndex = 2;
            this.scrResLabel.Text = "Resolution:";
            this.scrResLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelRecName
            // 
            this.labelRecName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRecName.Location = new System.Drawing.Point(92, 123);
            this.labelRecName.Name = "labelRecName";
            this.labelRecName.Size = new System.Drawing.Size(348, 26);
            this.labelRecName.TabIndex = 3;
            this.labelRecName.TextChanged += new System.EventHandler(this.labelRecName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Yu Gothic Light", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(93, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Record name";
            // 
            // radioButtonRightHand
            // 
            this.radioButtonRightHand.AutoSize = true;
            this.radioButtonRightHand.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(51)))), ((int)(((byte)(69)))));
            this.radioButtonRightHand.Checked = true;
            this.radioButtonRightHand.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonRightHand.Location = new System.Drawing.Point(92, 201);
            this.radioButtonRightHand.Name = "radioButtonRightHand";
            this.radioButtonRightHand.Size = new System.Drawing.Size(107, 21);
            this.radioButtonRightHand.TabIndex = 5;
            this.radioButtonRightHand.TabStop = true;
            this.radioButtonRightHand.Text = "Right Hand";
            this.radioButtonRightHand.UseVisualStyleBackColor = false;
            // 
            // radioButtonLeftHand
            // 
            this.radioButtonLeftHand.AutoSize = true;
            this.radioButtonLeftHand.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(51)))), ((int)(((byte)(69)))));
            this.radioButtonLeftHand.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonLeftHand.Location = new System.Drawing.Point(92, 256);
            this.radioButtonLeftHand.Name = "radioButtonLeftHand";
            this.radioButtonLeftHand.Size = new System.Drawing.Size(95, 21);
            this.radioButtonLeftHand.TabIndex = 6;
            this.radioButtonLeftHand.Text = "Left hand";
            this.radioButtonLeftHand.UseVisualStyleBackColor = false;
            this.radioButtonLeftHand.CheckedChanged += new System.EventHandler(this.radioButtonLeftHand_CheckedChanged);
            // 
            // RecordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(27)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(684, 527);
            this.Controls.Add(this.radioButtonLeftHand);
            this.Controls.Add(this.radioButtonRightHand);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelRecName);
            this.Controls.Add(this.scrResLabel);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.buttonRecord);
            this.Name = "RecordForm";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonRecord;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Label scrResLabel;
        private System.Windows.Forms.TextBox labelRecName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButtonRightHand;
        private System.Windows.Forms.RadioButton radioButtonLeftHand;
    }
}