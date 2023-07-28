namespace Digital_Audio_Workstation
{
    partial class IOSettings
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
            input_cbox = new ComboBox();
            label1 = new Label();
            output_cbox = new ComboBox();
            label2 = new Label();
            lbl3 = new Label();
            confirm_btn = new Button();
            SuspendLayout();
            // 
            // input_cbox
            // 
            input_cbox.FormattingEnabled = true;
            input_cbox.Location = new Point(93, 182);
            input_cbox.Name = "input_cbox";
            input_cbox.Size = new Size(121, 23);
            input_cbox.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(135, 51);
            label1.Name = "label1";
            label1.Size = new Size(313, 46);
            label1.TabIndex = 1;
            label1.Text = "Select Audio device";
            // 
            // output_cbox
            // 
            output_cbox.FormattingEnabled = true;
            output_cbox.Location = new Point(356, 182);
            output_cbox.Name = "output_cbox";
            output_cbox.Size = new Size(121, 23);
            output_cbox.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(117, 148);
            label2.Name = "label2";
            label2.Size = new Size(73, 15);
            label2.TabIndex = 3;
            label2.Text = "Input Device";
            // 
            // lbl3
            // 
            lbl3.AutoSize = true;
            lbl3.Location = new Point(375, 148);
            lbl3.Name = "lbl3";
            lbl3.Size = new Size(83, 15);
            lbl3.TabIndex = 4;
            lbl3.Text = "Output Device";
            // 
            // confirm_btn
            // 
            confirm_btn.Location = new Point(254, 266);
            confirm_btn.Name = "confirm_btn";
            confirm_btn.Size = new Size(75, 23);
            confirm_btn.TabIndex = 5;
            confirm_btn.Text = "OK";
            confirm_btn.UseVisualStyleBackColor = true;
            confirm_btn.Click += confirm_btn_Click;
            // 
            // IOSettings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaShell;
            ClientSize = new Size(584, 361);
            Controls.Add(confirm_btn);
            Controls.Add(lbl3);
            Controls.Add(label2);
            Controls.Add(output_cbox);
            Controls.Add(label1);
            Controls.Add(input_cbox);
            Name = "IOSettings";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "IOSettings";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox input_cbox;
        private Label label1;
        private ComboBox output_cbox;
        private Label label2;
        private Label lbl3;
        private Button confirm_btn;
    }
}