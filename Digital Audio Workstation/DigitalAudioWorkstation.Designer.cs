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
            start_record_btn = new Button();
            stop_record_btn = new Button();
            play_audio_btn = new Button();
            pause_audio_btn = new Button();
            select_btn = new Button();
            path_textbox = new TextBox();
            path_btn = new Button();
            stop_audio_btn = new Button();
            musicname_txt = new Label();
            mute_btn = new Button();
            unmute_btn = new Button();
            path_cancel_btn = new Button();
            settings_btn = new Button();
            pause_record_btn = new Button();
            rec_text = new Label();
            volume_bar = new TrackBar();
            label1 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)volume_bar).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // start_record_btn
            // 
            start_record_btn.BackColor = Color.DarkGray;
            start_record_btn.ForeColor = Color.Snow;
            start_record_btn.Location = new Point(15, 18);
            start_record_btn.Name = "start_record_btn";
            start_record_btn.Size = new Size(150, 34);
            start_record_btn.TabIndex = 0;
            start_record_btn.Text = "Start Recorging";
            start_record_btn.UseVisualStyleBackColor = false;
            start_record_btn.Click += start_record_btn_Click;
            // 
            // stop_record_btn
            // 
            stop_record_btn.BackColor = Color.DarkGray;
            stop_record_btn.ForeColor = Color.Snow;
            stop_record_btn.Location = new Point(15, 58);
            stop_record_btn.Name = "stop_record_btn";
            stop_record_btn.Size = new Size(150, 34);
            stop_record_btn.TabIndex = 1;
            stop_record_btn.Text = "Stop Recording";
            stop_record_btn.UseVisualStyleBackColor = false;
            stop_record_btn.Click += stop_record_btn_Click;
            // 
            // play_audio_btn
            // 
            play_audio_btn.BackColor = Color.DarkGray;
            play_audio_btn.ForeColor = Color.Snow;
            play_audio_btn.Location = new Point(177, 276);
            play_audio_btn.Name = "play_audio_btn";
            play_audio_btn.Size = new Size(100, 34);
            play_audio_btn.TabIndex = 2;
            play_audio_btn.Text = "Play Audio";
            play_audio_btn.UseVisualStyleBackColor = false;
            play_audio_btn.Click += play_audio_btn_Click;
            // 
            // pause_audio_btn
            // 
            pause_audio_btn.BackColor = Color.DarkGray;
            pause_audio_btn.ForeColor = Color.Snow;
            pause_audio_btn.Location = new Point(283, 276);
            pause_audio_btn.Name = "pause_audio_btn";
            pause_audio_btn.Size = new Size(100, 34);
            pause_audio_btn.TabIndex = 3;
            pause_audio_btn.Text = "Pause Audio";
            pause_audio_btn.UseVisualStyleBackColor = false;
            pause_audio_btn.Click += pause_audio_btn_Click;
            // 
            // select_btn
            // 
            select_btn.BackColor = Color.DarkGray;
            select_btn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            select_btn.Location = new Point(314, 23);
            select_btn.Name = "select_btn";
            select_btn.Size = new Size(167, 49);
            select_btn.TabIndex = 4;
            select_btn.Text = "Select Music To Play";
            select_btn.UseVisualStyleBackColor = false;
            select_btn.Click += select_btn_Click;
            // 
            // path_textbox
            // 
            path_textbox.Location = new Point(199, 92);
            path_textbox.Name = "path_textbox";
            path_textbox.Size = new Size(380, 23);
            path_textbox.TabIndex = 5;
            path_textbox.Visible = false;
            // 
            // path_btn
            // 
            path_btn.BackColor = Color.DarkGray;
            path_btn.Location = new Point(264, 135);
            path_btn.Name = "path_btn";
            path_btn.Size = new Size(112, 40);
            path_btn.TabIndex = 6;
            path_btn.Text = "OK";
            path_btn.UseVisualStyleBackColor = false;
            path_btn.Visible = false;
            path_btn.Click += path_btn_Click;
            // 
            // stop_audio_btn
            // 
            stop_audio_btn.BackColor = Color.DarkGray;
            stop_audio_btn.ForeColor = Color.Snow;
            stop_audio_btn.Location = new Point(389, 276);
            stop_audio_btn.Name = "stop_audio_btn";
            stop_audio_btn.Size = new Size(100, 34);
            stop_audio_btn.TabIndex = 7;
            stop_audio_btn.Text = "Stop Audio";
            stop_audio_btn.UseVisualStyleBackColor = false;
            stop_audio_btn.Click += stop_audio_btn_Click;
            // 
            // musicname_txt
            // 
            musicname_txt.AutoSize = true;
            musicname_txt.BackColor = Color.FromArgb(0, 0, 0, 1);
            musicname_txt.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            musicname_txt.Location = new Point(177, 211);
            musicname_txt.Name = "musicname_txt";
            musicname_txt.Size = new Size(20, 28);
            musicname_txt.TabIndex = 8;
            musicname_txt.Text = "-";
            musicname_txt.TextAlign = ContentAlignment.MiddleCenter;
            musicname_txt.Visible = false;
            // 
            // mute_btn
            // 
            mute_btn.BackColor = Color.DarkGray;
            mute_btn.ForeColor = Color.Snow;
            mute_btn.Location = new Point(558, 236);
            mute_btn.Name = "mute_btn";
            mute_btn.Size = new Size(100, 34);
            mute_btn.TabIndex = 9;
            mute_btn.Text = "Mute";
            mute_btn.UseVisualStyleBackColor = false;
            mute_btn.Click += mute_btn_Click;
            // 
            // unmute_btn
            // 
            unmute_btn.BackColor = Color.DarkGray;
            unmute_btn.ForeColor = Color.Snow;
            unmute_btn.Location = new Point(558, 276);
            unmute_btn.Name = "unmute_btn";
            unmute_btn.Size = new Size(100, 34);
            unmute_btn.TabIndex = 10;
            unmute_btn.Text = "Unmute";
            unmute_btn.UseVisualStyleBackColor = false;
            unmute_btn.Click += unmute_btn_Click;
            // 
            // path_cancel_btn
            // 
            path_cancel_btn.BackColor = Color.DarkGray;
            path_cancel_btn.Location = new Point(410, 135);
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
            // pause_record_btn
            // 
            pause_record_btn.BackColor = Color.DarkGray;
            pause_record_btn.ForeColor = Color.Snow;
            pause_record_btn.Location = new Point(15, 98);
            pause_record_btn.Name = "pause_record_btn";
            pause_record_btn.Size = new Size(150, 34);
            pause_record_btn.TabIndex = 13;
            pause_record_btn.Text = "Pause Recording";
            pause_record_btn.UseVisualStyleBackColor = false;
            pause_record_btn.Click += pause_record_btn_Click;
            // 
            // rec_text
            // 
            rec_text.AutoSize = true;
            rec_text.Location = new Point(388, 399);
            rec_text.Name = "rec_text";
            rec_text.Size = new Size(38, 15);
            rec_text.TabIndex = 14;
            rec_text.Text = "label1";
            // 
            // volume_bar
            // 
            volume_bar.Location = new Point(101, 135);
            volume_bar.Maximum = 100;
            volume_bar.Name = "volume_bar";
            volume_bar.Orientation = Orientation.Vertical;
            volume_bar.RightToLeft = RightToLeft.No;
            volume_bar.Size = new Size(45, 175);
            volume_bar.TabIndex = 15;
            volume_bar.Scroll += volume_bar_Scroll;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(133, 285);
            label1.Name = "label1";
            label1.Size = new Size(13, 15);
            label1.TabIndex = 16;
            label1.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(126, 139);
            label2.Name = "label2";
            label2.Size = new Size(25, 15);
            label2.TabIndex = 17;
            label2.Text = "100";
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightSlateGray;
            panel1.Controls.Add(stop_record_btn);
            panel1.Controls.Add(start_record_btn);
            panel1.Controls.Add(pause_record_btn);
            panel1.Location = new Point(30, 331);
            panel1.Name = "panel1";
            panel1.Size = new Size(729, 148);
            panel1.TabIndex = 18;
            // 
            // DigitalAudioWorkstation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaShell;
            ClientSize = new Size(784, 500);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(volume_bar);
            Controls.Add(rec_text);
            Controls.Add(settings_btn);
            Controls.Add(path_cancel_btn);
            Controls.Add(unmute_btn);
            Controls.Add(mute_btn);
            Controls.Add(musicname_txt);
            Controls.Add(stop_audio_btn);
            Controls.Add(path_btn);
            Controls.Add(path_textbox);
            Controls.Add(select_btn);
            Controls.Add(pause_audio_btn);
            Controls.Add(play_audio_btn);
            Controls.Add(panel1);
            Name = "DigitalAudioWorkstation";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)volume_bar).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button start_record_btn;
        private Button stop_record_btn;
        private Button play_audio_btn;
        private Button pause_audio_btn;
        private Button select_btn;
        private TextBox path_textbox;
        private Button path_btn;
        private Button stop_audio_btn;
        private Label musicname_txt;
        private Button mute_btn;
        private Button unmute_btn;
        private Button path_cancel_btn;
        private Button settings_btn;
        private Button pause_record_btn;
        private Label rec_text;
        private TrackBar volume_bar;
        private Label label1;
        private Label label2;
        private Panel panel1;
    }
}