
namespace HomeWorkDoubleImage
{
    partial class GameForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gamePanel = new System.Windows.Forms.Panel();
            this.infoPanel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.ballsLabel = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.wrongTimer = new System.Windows.Forms.Timer(this.components);
            this.infoPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // gamePanel
            // 
            this.gamePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.gamePanel.Location = new System.Drawing.Point(0, 0);
            this.gamePanel.Name = "gamePanel";
            this.gamePanel.Size = new System.Drawing.Size(607, 651);
            this.gamePanel.TabIndex = 0;
            // 
            // infoPanel
            // 
            this.infoPanel.Controls.Add(this.button1);
            this.infoPanel.Controls.Add(this.ballsLabel);
            this.infoPanel.Controls.Add(this.timeLabel);
            this.infoPanel.Controls.Add(this.statusLabel);
            this.infoPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.infoPanel.Location = new System.Drawing.Point(607, 0);
            this.infoPanel.Name = "infoPanel";
            this.infoPanel.Size = new System.Drawing.Size(337, 651);
            this.infoPanel.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button1.Location = new System.Drawing.Point(0, 608);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(337, 43);
            this.button1.TabIndex = 3;
            this.button1.Text = "Завершить игру";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // ballsLabel
            // 
            this.ballsLabel.BackColor = System.Drawing.Color.Gray;
            this.ballsLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ballsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ballsLabel.Location = new System.Drawing.Point(0, 140);
            this.ballsLabel.Name = "ballsLabel";
            this.ballsLabel.Size = new System.Drawing.Size(337, 70);
            this.ballsLabel.TabIndex = 2;
            this.ballsLabel.Text = "Очки: 0";
            this.ballsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timeLabel
            // 
            this.timeLabel.BackColor = System.Drawing.Color.Gray;
            this.timeLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.timeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.timeLabel.Location = new System.Drawing.Point(0, 70);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(337, 70);
            this.timeLabel.TabIndex = 1;
            this.timeLabel.Text = "Время:\r\n0.0 сек";
            this.timeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // statusLabel
            // 
            this.statusLabel.BackColor = System.Drawing.Color.Gray;
            this.statusLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.statusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.statusLabel.Location = new System.Drawing.Point(0, 0);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(337, 70);
            this.statusLabel.TabIndex = 0;
            this.statusLabel.Text = "Выберите картинку";
            this.statusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Tick += new System.EventHandler(this.OnTimerTick);
            // 
            // wrongTimer
            // 
            this.wrongTimer.Interval = 750;
            this.wrongTimer.Tick += new System.EventHandler(this.wrongTimer_Tick);
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 651);
            this.Controls.Add(this.infoPanel);
            this.Controls.Add(this.gamePanel);
            this.MaximumSize = new System.Drawing.Size(960, 690);
            this.MinimumSize = new System.Drawing.Size(798, 690);
            this.Name = "GameForm";
            this.Text = "Игра на память";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.infoPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel gamePanel;
        private System.Windows.Forms.Panel infoPanel;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label ballsLabel;
        private System.Windows.Forms.Timer wrongTimer;
        private System.Windows.Forms.Button button1;
    }
}

