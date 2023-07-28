namespace Digital_Audio_Workstation
{
    partial class DigitalAudioWorkstation
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
            play_btn = new Button();
            pause_btn = new Button();
            select_btn = new Button();
            path_textbox = new TextBox();
            path_btn = new Button();
            stop_buttn = new Button();
            musicname_txt = new Label();
            mute_btn = new Button();
            unmute_btn = new Button();
            path_cancel_btn = new Button();
            settings_btn = new Button();
            SuspendLayout();
            // 
            // Record_btn
            // 
            Record_btn.BackColor = Color.ForestGreen;
            Record_btn.ForeColor = Color.Snow;
            Record_btn.Location = new Point(12, 450);
            Record_btn.Name = "Record_btn";
            Record_btn.Size = new Size(100, 34);
            Record_btn.TabIndex = 0;
            Record_btn.Text = "Start Recorging";
            Record_btn.UseVisualStyleBackColor = false;
            Record_btn.Click += Record_btn_Click;
            // 
            // Stop_btn
            // 
            Stop_btn.BackColor = Color.IndianRed;
            Stop_btn.ForeColor = Color.Snow;
            Stop_btn.Location = new Point(12, 490);
            Stop_btn.Name = "Stop_btn";
            Stop_btn.Size = new Size(100, 34);
            Stop_btn.TabIndex = 1;
            Stop_btn.Text = "Stop Recording";
            Stop_btn.UseVisualStyleBackColor = false;
            Stop_btn.Click += Stop_btn_Click;
            // 
            // play_btn
            // 
            play_btn.BackColor = Color.CornflowerBlue;
            play_btn.ForeColor = Color.Snow;
            play_btn.Location = new Point(242, 490);
            play_btn.Name = "play_btn";
            play_btn.Size = new Size(100, 34);
            play_btn.TabIndex = 2;
            play_btn.Text = "Play Audio";
            play_btn.UseVisualStyleBackColor = false;
            play_btn.Click += play_btn_Click;
            // 
            // pause_btn
            // 
            pause_btn.BackColor = Color.Coral;
            pause_btn.ForeColor = Color.Snow;
            pause_btn.Location = new Point(348, 491);
            pause_btn.Name = "pause_btn";
            pause_btn.Size = new Size(100, 34);
            pause_btn.TabIndex = 3;
            pause_btn.Text = "Pause Audio";
            pause_btn.UseVisualStyleBackColor = false;
            pause_btn.Click += pause_btn_Click;
            // 
            // select_btn
            // 
            select_btn.BackColor = Color.DarkCyan;
            select_btn.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            select_btn.Location = new Point(206, 32);
            select_btn.Name = "select_btn";
            select_btn.Size = new Size(380, 87);
            select_btn.TabIndex = 4;
            select_btn.Text = "Select Music To Play";
            select_btn.UseVisualStyleBackColor = false;
            select_btn.Click += select_btn_Click;
            // 
            // path_textbox
            // 
            path_textbox.Location = new Point(206, 146);
            path_textbox.Name = "path_textbox";
            path_textbox.Size = new Size(380, 23);
            path_textbox.TabIndex = 5;
            path_textbox.Visible = false;
            // 
            // path_btn
            // 
            path_btn.BackColor = Color.DarkSeaGreen;
            path_btn.Location = new Point(271, 189);
            path_btn.Name = "path_btn";
            path_btn.Size = new Size(112, 40);
            path_btn.TabIndex = 6;
            path_btn.Text = "OK";
            path_btn.UseVisualStyleBackColor = false;
            path_btn.Visible = false;
            path_btn.Click += path_btn_Click;
            // 
            // stop_buttn
            // 
            stop_buttn.BackColor = Color.Brown;
            stop_buttn.ForeColor = Color.Snow;
            stop_buttn.Location = new Point(454, 493);
            stop_buttn.Name = "stop_buttn";
            stop_buttn.Size = new Size(100, 34);
            stop_buttn.TabIndex = 7;
            stop_buttn.Text = "Stop Audio";
            stop_buttn.UseVisualStyleBackColor = false;
            stop_buttn.Click += stop_buttn_Click;
            // 
            // musicname_txt
            // 
            musicname_txt.AutoSize = true;
            musicname_txt.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            musicname_txt.Location = new Point(115, 271);
            musicname_txt.Name = "musicname_txt";
            musicname_txt.Size = new Size(34, 46);
            musicname_txt.TabIndex = 8;
            musicname_txt.Text = "-";
            musicname_txt.TextAlign = ContentAlignment.MiddleCenter;
            musicname_txt.Visible = false;
            // 
            // mute_btn
            // 
            mute_btn.BackColor = Color.BlueViolet;
            mute_btn.ForeColor = Color.Snow;
            mute_btn.Location = new Point(648, 453);
            mute_btn.Name = "mute_btn";
            mute_btn.Size = new Size(100, 34);
            mute_btn.TabIndex = 9;
            mute_btn.Text = "Mute";
            mute_btn.UseVisualStyleBackColor = false;
            mute_btn.Click += mute_btn_Click;
            // 
            // unmute_btn
            // 
            unmute_btn.BackColor = Color.MediumSeaGreen;
            unmute_btn.ForeColor = Color.Snow;
            unmute_btn.Location = new Point(648, 493);
            unmute_btn.Name = "unmute_btn";
            unmute_btn.Size = new Size(100, 34);
            unmute_btn.TabIndex = 10;
            unmute_btn.Text = "Unmute";
            unmute_btn.UseVisualStyleBackColor = false;
            unmute_btn.Click += unmute_btn_Click;
            // 
            // path_cancel_btn
            // 
            path_cancel_btn.BackColor = Color.DarkSeaGreen;
            path_cancel_btn.Location = new Point(417, 189);
            path_cancel_btn.Name = "path_cancel_btn";
            path_cancel_btn.Size = new Size(112, 40);
            path_cancel_btn.TabIndex = 11;
            path_cancel_btn.Text = "Cancel";
            path_cancel_btn.UseVisualStyleBackColor = false;
            path_cancel_btn.Visible = false;
            path_cancel_btn.Click += cancel_btn_Click;
            // 
            // settings_btn
            // 
            settings_btn.BackColor = Color.SteelBlue;
            settings_btn.Location = new Point(12, 32);
            settings_btn.Name = "settings_btn";
            settings_btn.Size = new Size(100, 34);
            settings_btn.TabIndex = 12;
            settings_btn.Text = "Settings";
            settings_btn.UseVisualStyleBackColor = false;
            settings_btn.Click += settings_btn_Click;
            // 
            // DigitalAudioWorkstation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaShell;
            ClientSize = new Size(784, 561);
            Controls.Add(settings_btn);
            Controls.Add(path_cancel_btn);
            Controls.Add(unmute_btn);
            Controls.Add(mute_btn);
            Controls.Add(musicname_txt);
            Controls.Add(stop_buttn);
            Controls.Add(path_btn);
            Controls.Add(path_textbox);
            Controls.Add(select_btn);
            Controls.Add(pause_btn);
            Controls.Add(play_btn);
            Controls.Add(Stop_btn);
            Controls.Add(Record_btn);
            Name = "DigitalAudioWorkstation";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Record_btn;
        private Button Stop_btn;
        private Button play_btn;
        private Button pause_btn;
        private Button select_btn;
        private TextBox path_textbox;
        private Button path_btn;
        private Button stop_buttn;
        private Label musicname_txt;
        private Button mute_btn;
        private Button unmute_btn;
        private Button path_cancel_btn;
        private Button settings_btn;
    }
}