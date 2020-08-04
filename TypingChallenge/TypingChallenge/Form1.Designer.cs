namespace TypingChallenge
{
    partial class Form1
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
            this.LivesLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ScoreLabel = new System.Windows.Forms.Label();
            this.InputText = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.userName = new System.Windows.Forms.TextBox();
            this.controlPanel = new System.Windows.Forms.Panel();
            this.LifeHeartPanel = new System.Windows.Forms.Panel();
            this.MovingButton3 = new TypingChallenge.RoundButton();
            this.MovingButton2 = new TypingChallenge.RoundButton();
            this.MovingButton = new TypingChallenge.RoundButton();
            this.StartButton = new TypingChallenge.RoundButton();
            this.Life1 = new TypingChallenge.RoundButton();
            this.Life2 = new TypingChallenge.RoundButton();
            this.Life3 = new TypingChallenge.RoundButton();
            this.Life4 = new TypingChallenge.RoundButton();
            this.Life5 = new TypingChallenge.RoundButton();
            this.Mute = new TypingChallenge.RoundButton();
            this.pause = new TypingChallenge.RoundButton();
            this.resume = new TypingChallenge.RoundButton();
            this.controlPanel.SuspendLayout();
            this.LifeHeartPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // LivesLabel
            // 
            this.LivesLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LivesLabel.AutoSize = true;
            this.LivesLabel.BackColor = System.Drawing.Color.SkyBlue;
            this.LivesLabel.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LivesLabel.Location = new System.Drawing.Point(1045, 8);
            this.LivesLabel.Name = "LivesLabel";
            this.LivesLabel.Size = new System.Drawing.Size(29, 29);
            this.LivesLabel.TabIndex = 0;
            this.LivesLabel.Text = "5";
            this.LivesLabel.Visible = false;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.SkyBlue;
            this.label2.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(954, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Lives";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.SkyBlue;
            this.label3.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(396, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Score";
            this.label3.Visible = false;
            // 
            // ScoreLabel
            // 
            this.ScoreLabel.AutoSize = true;
            this.ScoreLabel.BackColor = System.Drawing.Color.SkyBlue;
            this.ScoreLabel.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreLabel.Location = new System.Drawing.Point(485, 11);
            this.ScoreLabel.Name = "ScoreLabel";
            this.ScoreLabel.Size = new System.Drawing.Size(29, 29);
            this.ScoreLabel.TabIndex = 3;
            this.ScoreLabel.Text = "0";
            this.ScoreLabel.Visible = false;
            // 
            // InputText
            // 
            this.InputText.BackColor = System.Drawing.Color.CornflowerBlue;
            this.InputText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputText.ForeColor = System.Drawing.Color.White;
            this.InputText.Location = new System.Drawing.Point(531, 5);
            this.InputText.Multiline = true;
            this.InputText.Name = "InputText";
            this.InputText.Size = new System.Drawing.Size(423, 40);
            this.InputText.TabIndex = 7;
            this.InputText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.InputText.Visible = false;
            this.InputText.TextChanged += new System.EventHandler(this.InputText_TextChanged);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // userName
            // 
            this.userName.BackColor = System.Drawing.Color.CornflowerBlue;
            this.userName.Location = new System.Drawing.Point(5, 10);
            this.userName.Multiline = true;
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(269, 34);
            this.userName.TabIndex = 23;
            this.userName.Visible = false;
            // 
            // controlPanel
            // 
            this.controlPanel.BackColor = System.Drawing.Color.CornflowerBlue;
            this.controlPanel.Controls.Add(this.Mute);
            this.controlPanel.Controls.Add(this.pause);
            this.controlPanel.Controls.Add(this.resume);
            this.controlPanel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.controlPanel.Location = new System.Drawing.Point(275, 9);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Size = new System.Drawing.Size(126, 36);
            this.controlPanel.TabIndex = 24;
            this.controlPanel.Visible = false;
            // 
            // LifeHeartPanel
            // 
            this.LifeHeartPanel.BackColor = System.Drawing.Color.CornflowerBlue;
            this.LifeHeartPanel.Controls.Add(this.Life1);
            this.LifeHeartPanel.Controls.Add(this.Life2);
            this.LifeHeartPanel.Controls.Add(this.Life3);
            this.LifeHeartPanel.Controls.Add(this.Life4);
            this.LifeHeartPanel.Controls.Add(this.Life5);
            this.LifeHeartPanel.Location = new System.Drawing.Point(1073, 8);
            this.LifeHeartPanel.Name = "LifeHeartPanel";
            this.LifeHeartPanel.Size = new System.Drawing.Size(295, 63);
            this.LifeHeartPanel.TabIndex = 25;
            this.LifeHeartPanel.Visible = false;
            // 
            // MovingButton3
            // 
            this.MovingButton3.BackColor = System.Drawing.Color.Wheat;
            this.MovingButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MovingButton3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MovingButton3.Location = new System.Drawing.Point(748, 130);
            this.MovingButton3.Name = "MovingButton3";
            this.MovingButton3.Size = new System.Drawing.Size(90, 85);
            this.MovingButton3.TabIndex = 20;
            this.MovingButton3.Text = "3";
            this.MovingButton3.UseVisualStyleBackColor = false;
            this.MovingButton3.Visible = false;
            // 
            // MovingButton2
            // 
            this.MovingButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.MovingButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MovingButton2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MovingButton2.Location = new System.Drawing.Point(629, 130);
            this.MovingButton2.Name = "MovingButton2";
            this.MovingButton2.Size = new System.Drawing.Size(90, 85);
            this.MovingButton2.TabIndex = 19;
            this.MovingButton2.Text = "2";
            this.MovingButton2.UseVisualStyleBackColor = false;
            this.MovingButton2.Visible = false;
            // 
            // MovingButton
            // 
            this.MovingButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.MovingButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MovingButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MovingButton.Location = new System.Drawing.Point(518, 130);
            this.MovingButton.Name = "MovingButton";
            this.MovingButton.Size = new System.Drawing.Size(90, 85);
            this.MovingButton.TabIndex = 18;
            this.MovingButton.Text = "1";
            this.MovingButton.UseVisualStyleBackColor = false;
            this.MovingButton.Visible = false;
            // 
            // StartButton
            // 
            this.StartButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StartButton.BackColor = System.Drawing.Color.DarkOrange;
            this.StartButton.Location = new System.Drawing.Point(1250, 600);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(100, 100);
            this.StartButton.TabIndex = 10;
            this.StartButton.Text = "START";
            this.StartButton.UseVisualStyleBackColor = false;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // Life1
            // 
            this.Life1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Life1.BackgroundImage = global::TypingChallenge.Properties.Resources.Life1;
            this.Life1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Life1.Location = new System.Drawing.Point(0, 0);
            this.Life1.Name = "Life1";
            this.Life1.Size = new System.Drawing.Size(59, 61);
            this.Life1.TabIndex = 13;
            this.Life1.UseVisualStyleBackColor = false;
            this.Life1.Visible = false;
            // 
            // Life2
            // 
            this.Life2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Life2.BackgroundImage = global::TypingChallenge.Properties.Resources.Life1;
            this.Life2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Life2.Location = new System.Drawing.Point(57, 0);
            this.Life2.Name = "Life2";
            this.Life2.Size = new System.Drawing.Size(59, 61);
            this.Life2.TabIndex = 14;
            this.Life2.UseVisualStyleBackColor = false;
            this.Life2.Visible = false;
            // 
            // Life3
            // 
            this.Life3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Life3.BackgroundImage = global::TypingChallenge.Properties.Resources.Life1;
            this.Life3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Life3.Location = new System.Drawing.Point(114, 0);
            this.Life3.Name = "Life3";
            this.Life3.Size = new System.Drawing.Size(59, 63);
            this.Life3.TabIndex = 15;
            this.Life3.UseVisualStyleBackColor = false;
            this.Life3.Visible = false;
            // 
            // Life4
            // 
            this.Life4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Life4.BackgroundImage = global::TypingChallenge.Properties.Resources.Life1;
            this.Life4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Life4.Location = new System.Drawing.Point(174, 1);
            this.Life4.Name = "Life4";
            this.Life4.Size = new System.Drawing.Size(59, 61);
            this.Life4.TabIndex = 16;
            this.Life4.UseVisualStyleBackColor = false;
            this.Life4.Visible = false;
            // 
            // Life5
            // 
            this.Life5.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Life5.BackgroundImage = global::TypingChallenge.Properties.Resources.Life1;
            this.Life5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Life5.Location = new System.Drawing.Point(234, 1);
            this.Life5.Name = "Life5";
            this.Life5.Size = new System.Drawing.Size(60, 61);
            this.Life5.TabIndex = 17;
            this.Life5.UseVisualStyleBackColor = false;
            this.Life5.Visible = false;
            // 
            // Mute
            // 
            this.Mute.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Mute.BackgroundImage = global::TypingChallenge.Properties.Resources.mute1;
            this.Mute.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Mute.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mute.Location = new System.Drawing.Point(3, 1);
            this.Mute.Name = "Mute";
            this.Mute.Size = new System.Drawing.Size(40, 33);
            this.Mute.TabIndex = 22;
            this.Mute.UseVisualStyleBackColor = false;
            this.Mute.Visible = false;
            this.Mute.Click += new System.EventHandler(this.Mute_Click);
            // 
            // pause
            // 
            this.pause.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pause.BackgroundImage = global::TypingChallenge.Properties.Resources.pause1;
            this.pause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pause.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pause.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pause.Location = new System.Drawing.Point(43, 1);
            this.pause.Name = "pause";
            this.pause.Size = new System.Drawing.Size(40, 33);
            this.pause.TabIndex = 11;
            this.pause.UseVisualStyleBackColor = false;
            this.pause.Visible = false;
            this.pause.Click += new System.EventHandler(this.pause_Click);
            // 
            // resume
            // 
            this.resume.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.resume.BackgroundImage = global::TypingChallenge.Properties.Resources.resume2;
            this.resume.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.resume.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resume.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.resume.Location = new System.Drawing.Point(82, 1);
            this.resume.Name = "resume";
            this.resume.Size = new System.Drawing.Size(40, 33);
            this.resume.TabIndex = 12;
            this.resume.UseVisualStyleBackColor = false;
            this.resume.Visible = false;
            this.resume.Click += new System.EventHandler(this.resume_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1370, 707);
            this.Controls.Add(this.LifeHeartPanel);
            this.Controls.Add(this.controlPanel);
            this.Controls.Add(this.userName);
            this.Controls.Add(this.MovingButton3);
            this.Controls.Add(this.MovingButton2);
            this.Controls.Add(this.MovingButton);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.InputText);
            this.Controls.Add(this.ScoreLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LivesLabel);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Be Fast";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.controlPanel.ResumeLayout(false);
            this.LifeHeartPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LivesLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label ScoreLabel;
        private System.Windows.Forms.TextBox InputText;
        private System.Windows.Forms.Timer timer1;
        private RoundButton StartButton;
        private RoundButton pause;
        private RoundButton resume;
        private RoundButton Life1;
        private RoundButton Life2;
        private RoundButton Life3;
        private RoundButton Life4;
        private RoundButton Life5;
        private RoundButton MovingButton;
        private RoundButton MovingButton2;
        private RoundButton MovingButton3;
        private RoundButton Mute;
        private System.Windows.Forms.TextBox userName;
        private System.Windows.Forms.Panel controlPanel;
        private System.Windows.Forms.Panel LifeHeartPanel;
    }
}

