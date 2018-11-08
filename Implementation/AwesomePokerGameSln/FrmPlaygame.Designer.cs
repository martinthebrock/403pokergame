using System;
using System.Windows.Forms;

namespace AwesomePokerGameSln {
  partial class FrmPlaygame {
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
            this.picCard1 = new System.Windows.Forms.PictureBox();
            this.picCard3 = new System.Windows.Forms.PictureBox();
            this.picCard4 = new System.Windows.Forms.PictureBox();
            this.picCard5 = new System.Windows.Forms.PictureBox();
            this.picCard2 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnFullScreen = new System.Windows.Forms.Button();
            this.btnReportBug = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.lblHandType = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.btnViewRuleBook = new System.Windows.Forms.Button();
            this.picRulebook = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblHandTypeDealer = new System.Windows.Forms.Label();
            this.lblWin = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picCard1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCard3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCard4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCard5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCard2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRulebook)).BeginInit();
            this.SuspendLayout();
            // 
            // picCard1
            // 
            this.picCard1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picCard1.Location = new System.Drawing.Point(110, 386);
            this.picCard1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picCard1.Name = "picCard1";
            this.picCard1.Size = new System.Drawing.Size(168, 185);
            this.picCard1.TabIndex = 0;
            this.picCard1.TabStop = false;
            // 
            // picCard3
            // 
            this.picCard3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picCard3.Location = new System.Drawing.Point(513, 386);
            this.picCard3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picCard3.Name = "picCard3";
            this.picCard3.Size = new System.Drawing.Size(168, 185);
            this.picCard3.TabIndex = 1;
            this.picCard3.TabStop = false;
            // 
            // picCard4
            // 
            this.picCard4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picCard4.Location = new System.Drawing.Point(716, 386);
            this.picCard4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picCard4.Name = "picCard4";
            this.picCard4.Size = new System.Drawing.Size(168, 185);
            this.picCard4.TabIndex = 2;
            this.picCard4.TabStop = false;
            // 
            // picCard5
            // 
            this.picCard5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picCard5.Location = new System.Drawing.Point(924, 386);
            this.picCard5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picCard5.Name = "picCard5";
            this.picCard5.Size = new System.Drawing.Size(168, 185);
            this.picCard5.TabIndex = 3;
            this.picCard5.TabStop = false;
            // 
            // picCard2
            // 
            this.picCard2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picCard2.Location = new System.Drawing.Point(312, 386);
            this.picCard2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picCard2.Name = "picCard2";
            this.picCard2.Size = new System.Drawing.Size(168, 185);
            this.picCard2.TabIndex = 4;
            this.picCard2.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(464, 580);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(268, 132);
            this.button1.TabIndex = 6;
            this.button1.Text = "Redeal";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnFullScreen
            // 
            this.btnFullScreen.Location = new System.Drawing.Point(1044, 580);
            this.btnFullScreen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnFullScreen.Name = "btnFullScreen";
            this.btnFullScreen.Size = new System.Drawing.Size(135, 57);
            this.btnFullScreen.TabIndex = 3;
            this.btnFullScreen.Text = "Toggle Full Screen";
            this.btnFullScreen.UseVisualStyleBackColor = true;
            this.btnFullScreen.Click += new System.EventHandler(this.btnFullScreen_Click);
            // 
            // btnReportBug
            // 
            this.btnReportBug.Location = new System.Drawing.Point(1044, 647);
            this.btnReportBug.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnReportBug.Name = "btnReportBug";
            this.btnReportBug.Size = new System.Drawing.Size(135, 57);
            this.btnReportBug.TabIndex = 18;
            this.btnReportBug.Text = "Report Bug";
            this.btnReportBug.UseVisualStyleBackColor = true;
            this.btnReportBug.Click += new System.EventHandler(this.btnReportBug_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(900, 580);
            this.btnQuit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(135, 57);
            this.btnQuit.TabIndex = 3;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // lblHandType
            // 
            this.lblHandType.AutoSize = true;
            this.lblHandType.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHandType.Location = new System.Drawing.Point(747, 337);
            this.lblHandType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHandType.Name = "lblHandType";
            this.lblHandType.Size = new System.Drawing.Size(261, 52);
            this.lblHandType.TabIndex = 7;
            this.lblHandType.Text = "player hand";
            this.lblHandType.Click += new System.EventHandler(this.lblHandType_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(110, 123);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(168, 185);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(312, 123);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(168, 185);
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(513, 123);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(168, 185);
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Location = new System.Drawing.Point(716, 123);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(168, 185);
            this.pictureBox4.TabIndex = 9;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox5.Location = new System.Drawing.Point(924, 123);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(168, 185);
            this.pictureBox5.TabIndex = 8;
            this.pictureBox5.TabStop = false;
            // 
            // btnViewRuleBook
            // 
            this.btnViewRuleBook.Location = new System.Drawing.Point(756, 580);
            this.btnViewRuleBook.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnViewRuleBook.Name = "btnViewRuleBook";
            this.btnViewRuleBook.Size = new System.Drawing.Size(135, 57);
            this.btnViewRuleBook.TabIndex = 2;
            this.btnViewRuleBook.Text = "View Rule Book";
            this.btnViewRuleBook.UseVisualStyleBackColor = false;
            this.btnViewRuleBook.Click += new System.EventHandler(this.btnViewRuleBook_Click);
            // 
            // picRulebook
            // 
            this.picRulebook.BackgroundImage = global::AwesomePokerGameSln.Properties.Resources.rule_book;
            this.picRulebook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picRulebook.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picRulebook.Location = new System.Drawing.Point(222, 92);
            this.picRulebook.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picRulebook.Name = "picRulebook";
            this.picRulebook.Size = new System.Drawing.Size(756, 477);
            this.picRulebook.TabIndex = 5;
            this.picRulebook.TabStop = false;
            this.picRulebook.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(105, 98);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Dealer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(105, 362);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "You";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblHandTypeDealer
            // 
            this.lblHandTypeDealer.AutoSize = true;
            this.lblHandTypeDealer.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHandTypeDealer.Location = new System.Drawing.Point(747, 74);
            this.lblHandTypeDealer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHandTypeDealer.Name = "lblHandTypeDealer";
            this.lblHandTypeDealer.Size = new System.Drawing.Size(263, 52);
            this.lblHandTypeDealer.TabIndex = 15;
            this.lblHandTypeDealer.Text = "dealer hand";
            // 
            // lblWin
            // 
            this.lblWin.AutoSize = true;
            this.lblWin.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWin.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblWin.Location = new System.Drawing.Point(303, 337);
            this.lblWin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWin.Name = "lblWin";
            this.lblWin.Size = new System.Drawing.Size(92, 52);
            this.lblWin.TabIndex = 16;
            this.lblWin.Text = "win";
            this.lblWin.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FrmPlaygame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 754);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picRulebook);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnFullScreen);
            this.Controls.Add(this.btnReportBug);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.picCard2);
            this.Controls.Add(this.picCard5);
            this.Controls.Add(this.picCard4);
            this.Controls.Add(this.picCard3);
            this.Controls.Add(this.picCard1);
            this.Controls.Add(this.btnViewRuleBook);
            this.Controls.Add(this.lblHandTypeDealer);
            this.Controls.Add(this.lblHandType);
            this.Controls.Add(this.lblWin);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmPlaygame";
            this.Text = "FrmPlaygame";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmPlaygame_FormClosed);
            this.Load += new System.EventHandler(this.FrmPlaygame_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picCard1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCard3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCard4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCard5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCard2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRulebook)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

    }
        #endregion

    private System.Windows.Forms.PictureBox picCard1;
    private System.Windows.Forms.PictureBox picCard3;
    private System.Windows.Forms.PictureBox picCard4;
    private System.Windows.Forms.PictureBox picCard5;
    private System.Windows.Forms.PictureBox picCard2;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Button btnFullScreen;
    private System.Windows.Forms.Button btnReportBug;
    private System.Windows.Forms.Button btnQuit;
    private System.Windows.Forms.Label lblHandType;
    private System.Windows.Forms.PictureBox pictureBox1;
    private System.Windows.Forms.PictureBox pictureBox2;
    private System.Windows.Forms.PictureBox pictureBox3;
    private System.Windows.Forms.PictureBox pictureBox4;
    private System.Windows.Forms.PictureBox pictureBox5;
    private System.Windows.Forms.Button btnViewRuleBook;    //rulebook
    private System.Windows.Forms.PictureBox picRulebook;    //rulebook
        private Label label1;
        private Label label2;
        private Label lblHandTypeDealer;
        private Label lblWin;
    }
}