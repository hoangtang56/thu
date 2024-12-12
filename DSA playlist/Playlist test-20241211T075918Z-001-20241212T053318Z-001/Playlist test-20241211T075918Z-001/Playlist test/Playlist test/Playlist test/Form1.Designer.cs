namespace Playlist_test
{
    partial class Form
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Button btn_first;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form));
            this.listBoxPlaylist = new System.Windows.Forms.ListBox();
            this.labelNowPlaying = new System.Windows.Forms.Label();
            this.search = new System.Windows.Forms.TextBox();
            this.trackBarVolume = new System.Windows.Forms.TrackBar();
            this.trackBarProgress = new System.Windows.Forms.TrackBar();
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.labelCurrentTime = new System.Windows.Forms.Label();
            this.labelTotalTime = new System.Windows.Forms.Label();
            this.trackBarSpeed = new System.Windows.Forms.TrackBar();
            this.labelSpeed = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btn_add15 = new System.Windows.Forms.Button();
            this.btn_minus15 = new System.Windows.Forms.Button();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_sortDESC = new System.Windows.Forms.Button();
            this.btn_sort = new System.Windows.Forms.Button();
            this.btn_remove = new System.Windows.Forms.Button();
            this.btn_shuffle = new System.Windows.Forms.Button();
            this.btn_next = new System.Windows.Forms.Button();
            this.btn_play = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.image1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            btn_first = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVolume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarProgress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.image1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_first
            // 
            btn_first.BackColor = System.Drawing.Color.Black;
            btn_first.FlatAppearance.BorderSize = 0;
            btn_first.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_first.Image = ((System.Drawing.Image)(resources.GetObject("btn_first.Image")));
            btn_first.Location = new System.Drawing.Point(193, 638);
            btn_first.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btn_first.Name = "btn_first";
            btn_first.Size = new System.Drawing.Size(68, 58);
            btn_first.TabIndex = 5;
            btn_first.UseVisualStyleBackColor = false;
            btn_first.Click += new System.EventHandler(this.btn_first_Click);
            // 
            // listBoxPlaylist
            // 
            this.listBoxPlaylist.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxPlaylist.FormattingEnabled = true;
            this.listBoxPlaylist.ItemHeight = 22;
            this.listBoxPlaylist.Location = new System.Drawing.Point(613, 118);
            this.listBoxPlaylist.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxPlaylist.Name = "listBoxPlaylist";
            this.listBoxPlaylist.Size = new System.Drawing.Size(496, 400);
            this.listBoxPlaylist.TabIndex = 8;
            this.listBoxPlaylist.SelectedIndexChanged += new System.EventHandler(this.listBoxPlaylist_SelectedIndexChanged);
            // 
            // labelNowPlaying
            // 
            this.labelNowPlaying.AutoSize = true;
            this.labelNowPlaying.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelNowPlaying.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNowPlaying.ForeColor = System.Drawing.Color.White;
            this.labelNowPlaying.Location = new System.Drawing.Point(17, 88);
            this.labelNowPlaying.Name = "labelNowPlaying";
            this.labelNowPlaying.Size = new System.Drawing.Size(62, 22);
            this.labelNowPlaying.TabIndex = 9;
            this.labelNowPlaying.Text = "label1";
            // 
            // search
            // 
            this.search.BackColor = System.Drawing.Color.Black;
            this.search.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.search.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search.ForeColor = System.Drawing.Color.White;
            this.search.Location = new System.Drawing.Point(532, 30);
            this.search.Multiline = true;
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(526, 39);
            this.search.TabIndex = 15;
            this.search.TextChanged += new System.EventHandler(this.search_TextChanged);
            // 
            // trackBarVolume
            // 
            this.trackBarVolume.BackColor = System.Drawing.Color.Black;
            this.trackBarVolume.Location = new System.Drawing.Point(544, 397);
            this.trackBarVolume.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.trackBarVolume.Maximum = 100;
            this.trackBarVolume.Name = "trackBarVolume";
            this.trackBarVolume.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBarVolume.Size = new System.Drawing.Size(56, 131);
            this.trackBarVolume.TabIndex = 19;
            this.trackBarVolume.TickFrequency = 10;
            this.trackBarVolume.Value = 50;
            this.trackBarVolume.Scroll += new System.EventHandler(this.trackBarVolume_Scroll);
            // 
            // trackBarProgress
            // 
            this.trackBarProgress.BackColor = System.Drawing.Color.Black;
            this.trackBarProgress.Location = new System.Drawing.Point(18, 573);
            this.trackBarProgress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.trackBarProgress.Name = "trackBarProgress";
            this.trackBarProgress.Size = new System.Drawing.Size(1091, 56);
            this.trackBarProgress.SmallChange = 10;
            this.trackBarProgress.TabIndex = 21;
            this.trackBarProgress.Scroll += new System.EventHandler(this.trackBarProgress_Scroll);
            // 
            // Timer1
            // 
            this.Timer1.Enabled = true;
            this.Timer1.Interval = 1000;
            this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // labelCurrentTime
            // 
            this.labelCurrentTime.AutoSize = true;
            this.labelCurrentTime.BackColor = System.Drawing.Color.Black;
            this.labelCurrentTime.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCurrentTime.ForeColor = System.Drawing.Color.White;
            this.labelCurrentTime.Location = new System.Drawing.Point(24, 607);
            this.labelCurrentTime.Name = "labelCurrentTime";
            this.labelCurrentTime.Size = new System.Drawing.Size(62, 22);
            this.labelCurrentTime.TabIndex = 22;
            this.labelCurrentTime.Text = "00:00";
            // 
            // labelTotalTime
            // 
            this.labelTotalTime.AutoSize = true;
            this.labelTotalTime.BackColor = System.Drawing.Color.Black;
            this.labelTotalTime.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalTime.ForeColor = System.Drawing.Color.White;
            this.labelTotalTime.Location = new System.Drawing.Point(1044, 607);
            this.labelTotalTime.Name = "labelTotalTime";
            this.labelTotalTime.Size = new System.Drawing.Size(62, 22);
            this.labelTotalTime.TabIndex = 23;
            this.labelTotalTime.Text = "00:00";
            // 
            // trackBarSpeed
            // 
            this.trackBarSpeed.BackColor = System.Drawing.Color.Black;
            this.trackBarSpeed.LargeChange = 20;
            this.trackBarSpeed.Location = new System.Drawing.Point(950, 640);
            this.trackBarSpeed.Maximum = 200;
            this.trackBarSpeed.Minimum = 50;
            this.trackBarSpeed.Name = "trackBarSpeed";
            this.trackBarSpeed.Size = new System.Drawing.Size(158, 56);
            this.trackBarSpeed.SmallChange = 5;
            this.trackBarSpeed.TabIndex = 13;
            this.trackBarSpeed.TickFrequency = 50;
            this.trackBarSpeed.Value = 100;
            this.trackBarSpeed.Scroll += new System.EventHandler(this.trackBarSpeed_Scroll);
            // 
            // labelSpeed
            // 
            this.labelSpeed.AutoSize = true;
            this.labelSpeed.BackColor = System.Drawing.Color.Black;
            this.labelSpeed.Font = new System.Drawing.Font("MS Reference Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSpeed.ForeColor = System.Drawing.Color.White;
            this.labelSpeed.Location = new System.Drawing.Point(988, 679);
            this.labelSpeed.Name = "labelSpeed";
            this.labelSpeed.Size = new System.Drawing.Size(95, 18);
            this.labelSpeed.TabIndex = 14;
            this.labelSpeed.Text = "Speed: 1.0x";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Black;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(544, 367);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(32, 26);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 25;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Black;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1076, 37);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 26);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 24;
            this.pictureBox2.TabStop = false;
            // 
            // btn_add15
            // 
            this.btn_add15.BackColor = System.Drawing.Color.Black;
            this.btn_add15.FlatAppearance.BorderSize = 0;
            this.btn_add15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add15.Image = ((System.Drawing.Image)(resources.GetObject("btn_add15.Image")));
            this.btn_add15.Location = new System.Drawing.Point(634, 638);
            this.btn_add15.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_add15.Name = "btn_add15";
            this.btn_add15.Size = new System.Drawing.Size(68, 58);
            this.btn_add15.TabIndex = 18;
            this.btn_add15.UseVisualStyleBackColor = false;
            this.btn_add15.Click += new System.EventHandler(this.btn_add15_Click);
            // 
            // btn_minus15
            // 
            this.btn_minus15.BackColor = System.Drawing.Color.Black;
            this.btn_minus15.FlatAppearance.BorderSize = 0;
            this.btn_minus15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_minus15.Image = ((System.Drawing.Image)(resources.GetObject("btn_minus15.Image")));
            this.btn_minus15.Location = new System.Drawing.Point(420, 638);
            this.btn_minus15.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_minus15.Name = "btn_minus15";
            this.btn_minus15.Size = new System.Drawing.Size(68, 58);
            this.btn_minus15.TabIndex = 17;
            this.btn_minus15.UseVisualStyleBackColor = false;
            this.btn_minus15.Click += new System.EventHandler(this.btn_minus15_Click);
            // 
            // btn_Clear
            // 
            this.btn_Clear.BackColor = System.Drawing.Color.Black;
            this.btn_Clear.FlatAppearance.BorderSize = 0;
            this.btn_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Clear.Image = ((System.Drawing.Image)(resources.GetObject("btn_Clear.Image")));
            this.btn_Clear.Location = new System.Drawing.Point(556, 227);
            this.btn_Clear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(30, 27);
            this.btn_Clear.TabIndex = 16;
            this.btn_Clear.UseVisualStyleBackColor = false;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 118);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(508, 443);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // btn_sortDESC
            // 
            this.btn_sortDESC.BackColor = System.Drawing.Color.Black;
            this.btn_sortDESC.FlatAppearance.BorderSize = 0;
            this.btn_sortDESC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sortDESC.Image = ((System.Drawing.Image)(resources.GetObject("btn_sortDESC.Image")));
            this.btn_sortDESC.Location = new System.Drawing.Point(556, 170);
            this.btn_sortDESC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_sortDESC.Name = "btn_sortDESC";
            this.btn_sortDESC.Size = new System.Drawing.Size(30, 27);
            this.btn_sortDESC.TabIndex = 11;
            this.btn_sortDESC.UseVisualStyleBackColor = false;
            this.btn_sortDESC.Click += new System.EventHandler(this.btn_sortDESC_Click);
            // 
            // btn_sort
            // 
            this.btn_sort.BackColor = System.Drawing.Color.Black;
            this.btn_sort.FlatAppearance.BorderSize = 0;
            this.btn_sort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sort.Image = ((System.Drawing.Image)(resources.GetObject("btn_sort.Image")));
            this.btn_sort.Location = new System.Drawing.Point(556, 114);
            this.btn_sort.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_sort.Name = "btn_sort";
            this.btn_sort.Size = new System.Drawing.Size(30, 27);
            this.btn_sort.TabIndex = 10;
            this.btn_sort.UseVisualStyleBackColor = false;
            this.btn_sort.Click += new System.EventHandler(this.btn_sort_Click);
            // 
            // btn_remove
            // 
            this.btn_remove.BackColor = System.Drawing.Color.Black;
            this.btn_remove.FlatAppearance.BorderSize = 0;
            this.btn_remove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_remove.Image = ((System.Drawing.Image)(resources.GetObject("btn_remove.Image")));
            this.btn_remove.Location = new System.Drawing.Point(132, 638);
            this.btn_remove.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(68, 58);
            this.btn_remove.TabIndex = 7;
            this.btn_remove.UseVisualStyleBackColor = false;
            this.btn_remove.Click += new System.EventHandler(this.btn_remove_Click);
            // 
            // btn_shuffle
            // 
            this.btn_shuffle.BackColor = System.Drawing.Color.Black;
            this.btn_shuffle.FlatAppearance.BorderSize = 0;
            this.btn_shuffle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_shuffle.Image = ((System.Drawing.Image)(resources.GetObject("btn_shuffle.Image")));
            this.btn_shuffle.Location = new System.Drawing.Point(12, 638);
            this.btn_shuffle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_shuffle.Name = "btn_shuffle";
            this.btn_shuffle.Size = new System.Drawing.Size(68, 58);
            this.btn_shuffle.TabIndex = 6;
            this.btn_shuffle.UseVisualStyleBackColor = false;
            this.btn_shuffle.Click += new System.EventHandler(this.btn_shuffle_Click);
            // 
            // btn_next
            // 
            this.btn_next.BackColor = System.Drawing.Color.Black;
            this.btn_next.FlatAppearance.BorderSize = 0;
            this.btn_next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_next.Image = ((System.Drawing.Image)(resources.GetObject("btn_next.Image")));
            this.btn_next.Location = new System.Drawing.Point(580, 638);
            this.btn_next.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(68, 58);
            this.btn_next.TabIndex = 4;
            this.btn_next.UseVisualStyleBackColor = false;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // btn_play
            // 
            this.btn_play.BackColor = System.Drawing.Color.Black;
            this.btn_play.FlatAppearance.BorderSize = 0;
            this.btn_play.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_play.Image = ((System.Drawing.Image)(resources.GetObject("btn_play.Image")));
            this.btn_play.Location = new System.Drawing.Point(527, 638);
            this.btn_play.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_play.Name = "btn_play";
            this.btn_play.Size = new System.Drawing.Size(68, 58);
            this.btn_play.TabIndex = 3;
            this.btn_play.UseVisualStyleBackColor = false;
            this.btn_play.Click += new System.EventHandler(this.btn_play_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.BackColor = System.Drawing.Color.Black;
            this.btnPrevious.FlatAppearance.BorderSize = 0;
            this.btnPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrevious.Image = ((System.Drawing.Image)(resources.GetObject("btnPrevious.Image")));
            this.btnPrevious.Location = new System.Drawing.Point(474, 638);
            this.btnPrevious.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(68, 58);
            this.btnPrevious.TabIndex = 2;
            this.btnPrevious.UseVisualStyleBackColor = false;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.Black;
            this.btn_add.FlatAppearance.BorderSize = 0;
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.Image = ((System.Drawing.Image)(resources.GetObject("btn_add.Image")));
            this.btn_add.Location = new System.Drawing.Point(72, 638);
            this.btn_add.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(68, 58);
            this.btn_add.TabIndex = 1;
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // image1
            // 
            this.image1.Location = new System.Drawing.Point(18, 28);
            this.image1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.image1.Name = "image1";
            this.image1.Size = new System.Drawing.Size(44, 40);
            this.image1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.image1.TabIndex = 26;
            this.image1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("MS Reference Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Gainsboro;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(72, 28);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(293, 41);
            this.button1.TabIndex = 27;
            this.button1.Text = "change avatar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btnAvatar_Click);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(6, 16);
            this.axWindowsMediaPlayer1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(1260, 865);
            this.axWindowsMediaPlayer1.TabIndex = 0;
            this.axWindowsMediaPlayer1.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.axWindowsMediaPlayer1_PlayStateChange);
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 701);
            this.Controls.Add(this.listBoxPlaylist);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.image1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.labelNowPlaying);
            this.Controls.Add(this.labelTotalTime);
            this.Controls.Add(this.labelCurrentTime);
            this.Controls.Add(this.trackBarProgress);
            this.Controls.Add(this.btn_add15);
            this.Controls.Add(this.btn_minus15);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.search);
            this.Controls.Add(this.labelSpeed);
            this.Controls.Add(this.trackBarSpeed);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_sortDESC);
            this.Controls.Add(this.btn_sort);
            this.Controls.Add(this.btn_remove);
            this.Controls.Add(this.btn_shuffle);
            this.Controls.Add(btn_first);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.btn_play);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.trackBarVolume);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form";
            this.Text = "Music da Museum";
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVolume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarProgress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.image1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btn_play;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.Button btn_shuffle;
        private System.Windows.Forms.Button btn_remove;
        private System.Windows.Forms.ListBox listBoxPlaylist;
        private System.Windows.Forms.Button btn_sort;
        private System.Windows.Forms.Button btn_sortDESC;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelNowPlaying;
        private System.Windows.Forms.TextBox search;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Button btn_minus15;
        private System.Windows.Forms.Button btn_add15;
        private System.Windows.Forms.TrackBar trackBarVolume;
        private System.Windows.Forms.TrackBar trackBarProgress;
        private System.Windows.Forms.Timer Timer1;
        private System.Windows.Forms.Label labelCurrentTime;
        private System.Windows.Forms.Label labelTotalTime;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.TrackBar trackBarSpeed;
        private System.Windows.Forms.Label labelSpeed;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.PictureBox image1;
        private System.Windows.Forms.Button button1;
    }
}

