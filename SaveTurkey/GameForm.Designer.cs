
namespace SaveTurkey
{
    partial class GameForm
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
            this.skyPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.soldierLbl = new System.Windows.Forms.Label();
            this.VestScore = new System.Windows.Forms.Label();
            this.bulletScore = new System.Windows.Forms.Label();
            this.GunScore = new System.Windows.Forms.Label();
            this.vestScoreLbl = new System.Windows.Forms.Label();
            this.gunScoreLbl = new System.Windows.Forms.Label();
            this.bulletScoreLbl = new System.Windows.Forms.Label();
            this.ScoreText = new System.Windows.Forms.Label();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.catcherPanel = new System.Windows.Forms.Panel();
            this.arenaPanel = new System.Windows.Forms.Panel();
            this.skyPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // skyPanel
            // 
            this.skyPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.skyPanel.Controls.Add(this.label2);
            this.skyPanel.Controls.Add(this.soldierLbl);
            this.skyPanel.Controls.Add(this.VestScore);
            this.skyPanel.Controls.Add(this.bulletScore);
            this.skyPanel.Controls.Add(this.GunScore);
            this.skyPanel.Controls.Add(this.vestScoreLbl);
            this.skyPanel.Controls.Add(this.gunScoreLbl);
            this.skyPanel.Controls.Add(this.bulletScoreLbl);
            this.skyPanel.Controls.Add(this.ScoreText);
            this.skyPanel.Controls.Add(this.scoreLabel);
            this.skyPanel.Controls.Add(this.label1);
            this.skyPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.skyPanel.Location = new System.Drawing.Point(0, 0);
            this.skyPanel.Name = "skyPanel";
            this.skyPanel.Size = new System.Drawing.Size(800, 100);
            this.skyPanel.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(351, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 51);
            this.label2.TabIndex = 7;
            this.label2.Text = "Soldier :";
            // 
            // soldierLbl
            // 
            this.soldierLbl.AutoSize = true;
            this.soldierLbl.Font = new System.Drawing.Font("Microsoft Tai Le", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.soldierLbl.Location = new System.Drawing.Point(532, 23);
            this.soldierLbl.Name = "soldierLbl";
            this.soldierLbl.Size = new System.Drawing.Size(57, 65);
            this.soldierLbl.TabIndex = 6;
            this.soldierLbl.Text = "0";
            // 
            // VestScore
            // 
            this.VestScore.AutoSize = true;
            this.VestScore.Enabled = false;
            this.VestScore.Location = new System.Drawing.Point(224, 63);
            this.VestScore.Name = "VestScore";
            this.VestScore.Size = new System.Drawing.Size(60, 17);
            this.VestScore.TabIndex = 5;
            this.VestScore.Text = "YELEK :";
            // 
            // bulletScore
            // 
            this.bulletScore.AutoSize = true;
            this.bulletScore.Enabled = false;
            this.bulletScore.Location = new System.Drawing.Point(224, 36);
            this.bulletScore.Name = "bulletScore";
            this.bulletScore.Size = new System.Drawing.Size(60, 17);
            this.bulletScore.TabIndex = 4;
            this.bulletScore.Text = "MERMİ :";
            // 
            // GunScore
            // 
            this.GunScore.AutoSize = true;
            this.GunScore.Enabled = false;
            this.GunScore.Location = new System.Drawing.Point(224, 9);
            this.GunScore.Name = "GunScore";
            this.GunScore.Size = new System.Drawing.Size(55, 17);
            this.GunScore.TabIndex = 3;
            this.GunScore.Text = "SİLAH :";
            // 
            // vestScoreLbl
            // 
            this.vestScoreLbl.AutoSize = true;
            this.vestScoreLbl.Location = new System.Drawing.Point(294, 63);
            this.vestScoreLbl.Name = "vestScoreLbl";
            this.vestScoreLbl.Size = new System.Drawing.Size(16, 17);
            this.vestScoreLbl.TabIndex = 1;
            this.vestScoreLbl.Text = "0";
            // 
            // gunScoreLbl
            // 
            this.gunScoreLbl.AutoSize = true;
            this.gunScoreLbl.Location = new System.Drawing.Point(294, 9);
            this.gunScoreLbl.Name = "gunScoreLbl";
            this.gunScoreLbl.Size = new System.Drawing.Size(16, 17);
            this.gunScoreLbl.TabIndex = 2;
            this.gunScoreLbl.Text = "0";
            // 
            // bulletScoreLbl
            // 
            this.bulletScoreLbl.AutoSize = true;
            this.bulletScoreLbl.Location = new System.Drawing.Point(294, 36);
            this.bulletScoreLbl.Name = "bulletScoreLbl";
            this.bulletScoreLbl.Size = new System.Drawing.Size(16, 17);
            this.bulletScoreLbl.TabIndex = 0;
            this.bulletScoreLbl.Text = "0";
            // 
            // ScoreText
            // 
            this.ScoreText.AutoSize = true;
            this.ScoreText.Enabled = false;
            this.ScoreText.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreText.Location = new System.Drawing.Point(12, 36);
            this.ScoreText.Name = "ScoreText";
            this.ScoreText.Size = new System.Drawing.Size(65, 31);
            this.ScoreText.TabIndex = 0;
            this.ScoreText.Text = "SCR:";
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreLabel.Location = new System.Drawing.Point(83, 23);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(57, 65);
            this.scoreLabel.TabIndex = 1;
            this.scoreLabel.Text = "0";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Sitka Small", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(645, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 49);
            this.label1.TabIndex = 0;
            this.label1.Text = "0:00";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // catcherPanel
            // 
            this.catcherPanel.BackColor = System.Drawing.SystemColors.GrayText;
            this.catcherPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.catcherPanel.Location = new System.Drawing.Point(0, 381);
            this.catcherPanel.Name = "catcherPanel";
            this.catcherPanel.Size = new System.Drawing.Size(800, 69);
            this.catcherPanel.TabIndex = 5;
            // 
            // arenaPanel
            // 
            this.arenaPanel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.arenaPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.arenaPanel.Location = new System.Drawing.Point(0, 100);
            this.arenaPanel.Name = "arenaPanel";
            this.arenaPanel.Size = new System.Drawing.Size(800, 281);
            this.arenaPanel.TabIndex = 6;
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.arenaPanel);
            this.Controls.Add(this.catcherPanel);
            this.Controls.Add(this.skyPanel);
            this.Name = "GameForm";
            this.Text = "GameForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GameForm_KeyDown);
            this.skyPanel.ResumeLayout(false);
            this.skyPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel skyPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label soldierLbl;
        private System.Windows.Forms.Label VestScore;
        private System.Windows.Forms.Label bulletScore;
        private System.Windows.Forms.Label GunScore;
        private System.Windows.Forms.Label vestScoreLbl;
        private System.Windows.Forms.Label gunScoreLbl;
        private System.Windows.Forms.Label bulletScoreLbl;
        private System.Windows.Forms.Label ScoreText;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel catcherPanel;
        private System.Windows.Forms.Panel arenaPanel;
    }
}