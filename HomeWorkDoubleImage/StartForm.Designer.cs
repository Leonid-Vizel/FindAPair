namespace HomeWorkDoubleImage
{
    partial class StartForm
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
            this.playBtn = new System.Windows.Forms.Button();
            this.ratingBtn = new System.Windows.Forms.Button();
            this.nicknameTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // playBtn
            // 
            this.playBtn.Location = new System.Drawing.Point(12, 38);
            this.playBtn.Name = "playBtn";
            this.playBtn.Size = new System.Drawing.Size(340, 43);
            this.playBtn.TabIndex = 0;
            this.playBtn.Text = "Играть!";
            this.playBtn.UseVisualStyleBackColor = true;
            this.playBtn.Click += new System.EventHandler(this.playBtn_Click);
            // 
            // ratingBtn
            // 
            this.ratingBtn.Location = new System.Drawing.Point(12, 87);
            this.ratingBtn.Name = "ratingBtn";
            this.ratingBtn.Size = new System.Drawing.Size(340, 43);
            this.ratingBtn.TabIndex = 1;
            this.ratingBtn.Text = "Рейтинг";
            this.ratingBtn.UseVisualStyleBackColor = true;
            this.ratingBtn.Click += new System.EventHandler(this.ratingBtn_Click);
            // 
            // nicknameTextBox
            // 
            this.nicknameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nicknameTextBox.Location = new System.Drawing.Point(12, 12);
            this.nicknameTextBox.Name = "nicknameTextBox";
            this.nicknameTextBox.Size = new System.Drawing.Size(340, 20);
            this.nicknameTextBox.TabIndex = 2;
            this.nicknameTextBox.Text = "Ваш никнейм";
            this.nicknameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nicknameTextBox.Enter += new System.EventHandler(this.nicknameTextBox_Enter);
            this.nicknameTextBox.Leave += new System.EventHandler(this.nicknameTextBox_Leave);
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 137);
            this.Controls.Add(this.nicknameTextBox);
            this.Controls.Add(this.ratingBtn);
            this.Controls.Add(this.playBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "StartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Игра на память";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button playBtn;
        private System.Windows.Forms.Button ratingBtn;
        private System.Windows.Forms.TextBox nicknameTextBox;
    }
}