namespace TypingChallenge
{
    partial class userProfile
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.salutation = new System.Windows.Forms.ComboBox();
            this.firstName = new System.Windows.Forms.TextBox();
            this.lastName = new System.Windows.Forms.TextBox();
            this.Play = new TypingChallenge.RoundButton();
            this.cancel = new TypingChallenge.RoundButton();
            this.firstNameMsg = new System.Windows.Forms.Label();
            this.lastNameMsg = new System.Windows.Forms.Label();
            this.reset = new TypingChallenge.RoundButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "salutation:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "First Name:*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(44, 265);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Last Name:*";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(249, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(224, 42);
            this.label4.TabIndex = 3;
            this.label4.Text = "User Profile";
            // 
            // salutation
            // 
            this.salutation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.salutation.BackColor = System.Drawing.Color.SteelBlue;
            this.salutation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salutation.ForeColor = System.Drawing.Color.White;
            this.salutation.FormattingEnabled = true;
            this.salutation.Items.AddRange(new object[] {
            "",
            "Mr:",
            "Mrs:",
            "Doc:",
            "Prog:",
            "PH:",
            "Eng:",
            ""});
            this.salutation.Location = new System.Drawing.Point(205, 123);
            this.salutation.Name = "salutation";
            this.salutation.Size = new System.Drawing.Size(232, 24);
            this.salutation.TabIndex = 4;
            // 
            // firstName
            // 
            this.firstName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.firstName.BackColor = System.Drawing.Color.SteelBlue;
            this.firstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstName.ForeColor = System.Drawing.Color.White;
            this.firstName.Location = new System.Drawing.Point(205, 192);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(232, 22);
            this.firstName.TabIndex = 5;
            // 
            // lastName
            // 
            this.lastName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lastName.BackColor = System.Drawing.Color.SteelBlue;
            this.lastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastName.ForeColor = System.Drawing.Color.White;
            this.lastName.Location = new System.Drawing.Point(205, 273);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(232, 22);
            this.lastName.TabIndex = 6;
            // 
            // Play
            // 
            this.Play.BackColor = System.Drawing.Color.Green;
            this.Play.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Play.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Play.Location = new System.Drawing.Point(286, 393);
            this.Play.Name = "Play";
            this.Play.Size = new System.Drawing.Size(75, 60);
            this.Play.TabIndex = 7;
            this.Play.Text = "Play";
            this.Play.UseVisualStyleBackColor = false;
            this.Play.Click += new System.EventHandler(this.Play_Click);
            // 
            // cancel
            // 
            this.cancel.BackColor = System.Drawing.Color.Red;
            this.cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cancel.Location = new System.Drawing.Point(205, 325);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(75, 60);
            this.cancel.TabIndex = 8;
            this.cancel.Text = "Exite";
            this.cancel.UseVisualStyleBackColor = false;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // firstNameMsg
            // 
            this.firstNameMsg.AutoSize = true;
            this.firstNameMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameMsg.Location = new System.Drawing.Point(443, 199);
            this.firstNameMsg.Name = "firstNameMsg";
            this.firstNameMsg.Size = new System.Drawing.Size(16, 20);
            this.firstNameMsg.TabIndex = 9;
            this.firstNameMsg.Text = "*";
            // 
            // lastNameMsg
            // 
            this.lastNameMsg.AutoSize = true;
            this.lastNameMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameMsg.Location = new System.Drawing.Point(443, 280);
            this.lastNameMsg.Name = "lastNameMsg";
            this.lastNameMsg.Size = new System.Drawing.Size(16, 20);
            this.lastNameMsg.TabIndex = 10;
            this.lastNameMsg.Text = "*";
            // 
            // reset
            // 
            this.reset.BackColor = System.Drawing.Color.Orange;
            this.reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reset.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.reset.Location = new System.Drawing.Point(362, 325);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(75, 60);
            this.reset.TabIndex = 11;
            this.reset.Text = "Reset";
            this.reset.UseVisualStyleBackColor = false;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // userProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(683, 458);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.lastNameMsg);
            this.Controls.Add(this.firstNameMsg);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.Play);
            this.Controls.Add(this.lastName);
            this.Controls.Add(this.firstName);
            this.Controls.Add(this.salutation);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimumSize = new System.Drawing.Size(699, 497);
            this.Name = "userProfile";
            this.Text = "User Profile";
            this.Load += new System.EventHandler(this.userProfile_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox salutation;
        private System.Windows.Forms.TextBox firstName;
        private System.Windows.Forms.TextBox lastName;
        private RoundButton Play;
        private RoundButton cancel;
        private System.Windows.Forms.Label firstNameMsg;
        private System.Windows.Forms.Label lastNameMsg;
        private RoundButton reset;
    }
}