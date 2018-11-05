using System;

namespace AwesomePokerGameSln {
  partial class FrmTitle {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
            this.label1 = new System.Windows.Forms.Label();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.btnViewRuleBook = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.btnFullScreen = new System.Windows.Forms.Button();
            this.btnReportBug = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.picRulebook = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picRulebook)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 100F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(84, -56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(662, 153);
            this.label1.TabIndex = 0;
            this.label1.Text = "Awesome";
            // 
            // btnNewGame
            // 
            this.btnNewGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnNewGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewGame.Location = new System.Drawing.Point(57, 469);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(211, 87);
            this.btnNewGame.TabIndex = 1;
            this.btnNewGame.Text = "New Game";
            this.btnNewGame.UseVisualStyleBackColor = false;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // btnViewRuleBook
            // 
            this.btnViewRuleBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnViewRuleBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewRuleBook.Location = new System.Drawing.Point(374, 469);
            this.btnViewRuleBook.Name = "btnViewRuleBook";
            this.btnViewRuleBook.Size = new System.Drawing.Size(238, 87);
            this.btnViewRuleBook.TabIndex = 2;
            this.btnViewRuleBook.Text = "View Rule Book";
            this.btnViewRuleBook.UseVisualStyleBackColor = false;
            this.btnViewRuleBook.Click += new System.EventHandler(this.btnViewRuleBook_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnQuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuit.Location = new System.Drawing.Point(713, 469);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(211, 87);
            this.btnQuit.TabIndex = 3;
            this.btnQuit.Text = "Quit Game";
            this.btnQuit.UseVisualStyleBackColor = false;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // btnFullScreen
            // 
            this.btnFullScreen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnFullScreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFullScreen.Location = new System.Drawing.Point(745, -1);
            this.btnFullScreen.Name = "btnFullScreen";
            this.btnFullScreen.Size = new System.Drawing.Size(120, 57);
            this.btnFullScreen.TabIndex = 6;
            this.btnFullScreen.Text = "Toggle Full Screen";
            this.btnFullScreen.UseVisualStyleBackColor = false;
            this.btnFullScreen.Click += new System.EventHandler(this.btnFullScreen_Click);
            // 
            // btnReportBug
            // 
            this.btnReportBug.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnReportBug.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportBug.Location = new System.Drawing.Point(745, 58);
            this.btnReportBug.Name = "btnReportBug";
            this.btnReportBug.Size = new System.Drawing.Size(120, 57);
            this.btnReportBug.TabIndex = 7;
            this.btnReportBug.Text = "Report Bug";
            this.btnReportBug.UseVisualStyleBackColor = false;
            this.btnReportBug.Click += new System.EventHandler(this.btnReportBug_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 100F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(31, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(435, 153);
            this.label2.TabIndex = 4;
            this.label2.Text = "Game";
            // 
            // picRulebook
            // 
            this.picRulebook.BackgroundImage = global::AwesomePokerGameSln.Properties.Resources.rule_book;
            this.picRulebook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picRulebook.Location = new System.Drawing.Point(229, 114);
            this.picRulebook.Name = "picRulebook";
            this.picRulebook.Size = new System.Drawing.Size(505, 311);
            this.picRulebook.TabIndex = 5;
            this.picRulebook.TabStop = false;
            this.picRulebook.Visible = false;
            // 
            // FrmTitle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImage = global::AwesomePokerGameSln.Properties.Resources.title_screen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(950, 560);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.picRulebook);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnViewRuleBook);
            this.Controls.Add(this.btnNewGame);
            this.Controls.Add(this.btnFullScreen);
            this.Controls.Add(this.btnReportBug);
            this.Controls.Add(this.label1);
            this.Name = "FrmTitle";
            this.Text = "Awesome Poker Game";
            this.Load += new System.EventHandler(this.FrmTitle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picRulebook)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.Button btnViewRuleBook;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Button btnFullScreen;
        private System.Windows.Forms.Button btnReportBug;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox picRulebook;
  }
}

