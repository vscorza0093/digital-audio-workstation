namespace Digital_Audio_Workstation
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Record_btn = new Button();
            Stop_btn = new Button();
            SuspendLayout();
            // 
            // Record_btn
            // 
            Record_btn.BackColor = Color.LightGreen;
            Record_btn.Location = new Point(223, 371);
            Record_btn.Name = "Record_btn";
            Record_btn.Size = new Size(140, 61);
            Record_btn.TabIndex = 0;
            Record_btn.Text = "Record";
            Record_btn.UseVisualStyleBackColor = false;
            Record_btn.Click += Record_btn_Click;
            // 
            // Stop_btn
            // 
            Stop_btn.BackColor = Color.IndianRed;
            Stop_btn.Location = new Point(433, 371);
            Stop_btn.Name = "Stop_btn";
            Stop_btn.Size = new Size(147, 61);
            Stop_btn.TabIndex = 1;
            Stop_btn.Text = "Stop";
            Stop_btn.UseVisualStyleBackColor = false;
            Stop_btn.Click += Stop_btn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 561);
            Controls.Add(Stop_btn);
            Controls.Add(Record_btn);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button Record_btn;
        private Button Stop_btn;
    }
}