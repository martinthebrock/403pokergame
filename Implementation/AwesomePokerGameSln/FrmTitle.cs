using AwesomePokerGameSln.Properties;
using System;
using System.Windows.Forms;

namespace AwesomePokerGameSln {
  public partial class FrmTitle : Form {
    public FrmTitle() {
      InitializeComponent();
    }

    private void btnQuit_Click(object sender, EventArgs e) {
      Application.Exit();
    }

    private void btnViewRuleBook_Click(object sender, EventArgs e) {
      if (btnViewRuleBook.Text.StartsWith("View", true, null)) {
        picRulebook.Visible = true;
        btnViewRuleBook.Text = "Close Rule Book";
      }
      else {
        picRulebook.Visible = false;
        btnViewRuleBook.Text = "View Rule Book";
      }
    }

    private void btnNewGame_Click(object sender, EventArgs e) {
      FrmPlaygame frmPlaygame = new FrmPlaygame();
      frmPlaygame.Show();
      Hide();
    }

    private void btnFullScreen_Click(object sender, EventArgs e)
    {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Normal;
                this.FormBorderStyle = FormBorderStyle.None;
                this.WindowState = FormWindowState.Maximized;
            }

            else if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
                this.FormBorderStyle = FormBorderStyle.FixedSingle;
            }
    }

    private void FrmTitle_Load(object sender, EventArgs e){
    }
  }
}
