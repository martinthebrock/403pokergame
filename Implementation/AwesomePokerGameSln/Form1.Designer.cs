namespace AwesomePokerGameSln {
  partial class Form1 {
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
      this.label2 = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.BackColor = System.Drawing.Color.Transparent;
      this.label1.Font = new System.Drawing.Font("Marigold", 100F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.ForeColor = System.Drawing.Color.Yellow;
      this.label1.Location = new System.Drawing.Point(84, -56);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(368, 158);
      this.label1.TabIndex = 0;
      this.label1.Text = "Awesome";
      // 
      // btnNewGame
      // 
      this.btnNewGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.btnNewGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnNewGame.Location = new System.Drawing.Point(101, 617);
      this.btnNewGame.Name = "btnNewGame";
      this.btnNewGame.Size = new System.Drawing.Size(211, 87);
      this.btnNewGame.TabIndex = 1;
      this.btnNewGame.Text = "New Game";
      this.btnNewGame.UseVisualStyleBackColor = false;
      // 
      // btnViewRuleBook
      // 
      this.btnViewRuleBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.btnViewRuleBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnViewRuleBook.Location = new System.Drawing.Point(455, 617);
      this.btnViewRuleBook.Name = "btnViewRuleBook";
      this.btnViewRuleBook.Size = new System.Drawing.Size(238, 87);
      this.btnViewRuleBook.TabIndex = 2;
      this.btnViewRuleBook.Text = "View Rule Book";
      this.btnViewRuleBook.UseVisualStyleBackColor = false;
      // 
      // btnQuit
      // 
      this.btnQuit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
      this.btnQuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnQuit.Location = new System.Drawing.Point(884, 617);
      this.btnQuit.Name = "btnQuit";
      this.btnQuit.Size = new System.Drawing.Size(211, 87);
      this.btnQuit.TabIndex = 3;
      this.btnQuit.Text = "Quit Game";
      this.btnQuit.UseVisualStyleBackColor = false;
      this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.BackColor = System.Drawing.Color.Transparent;
      this.label2.Font = new System.Drawing.Font("Marigold", 100F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.ForeColor = System.Drawing.Color.Yellow;
      this.label2.Location = new System.Drawing.Point(128, 269);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(264, 158);
      this.label2.TabIndex = 4;
      this.label2.Text = "Game";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      this.BackgroundImage = global::AwesomePokerGameSln.Properties.Resources.title_screen;
      this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.ClientSize = new System.Drawing.Size(1157, 746);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.btnQuit);
      this.Controls.Add(this.btnViewRuleBook);
      this.Controls.Add(this.btnNewGame);
      this.Controls.Add(this.label1);
      this.Name = "Form1";
      this.Text = "Awesome Poker Game";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button btnNewGame;
    private System.Windows.Forms.Button btnViewRuleBook;
    private System.Windows.Forms.Button btnQuit;
    private System.Windows.Forms.Label label2;
  }
}

