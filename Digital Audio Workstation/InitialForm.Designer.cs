namespace Digital_Audio_Workstation
{
    partial class InitialForm
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
            label1 = new Label();
            fileName_textBox = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(316, 188);
            label1.Name = "label1";
            label1.Size = new Size(176, 32);
            label1.TabIndex = 0;
            label1.Text = "Enter file name";
            // 
            // fileName_textBox
            // 
            fileName_textBox.Location = new Point(278, 232);
            fileName_textBox.Name = "fileName_textBox";
            fileName_textBox.Size = new Size(251, 23);
            fileName_textBox.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(345, 291);
            button1.Name = "button1";
            button1.Size = new Size(115, 42);
            button1.TabIndex = 2;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // InitialForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaShell;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(fileName_textBox);
            Controls.Add(label1);
            Name = "InitialForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "InitialForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox fileName_textBox;
        private Button button1;
    }
}