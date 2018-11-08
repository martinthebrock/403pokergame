using AwesomePokerGameSln.Code;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net;
using System.Net.Mail;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CardType = System.Tuple<int, int>;
using WMPLib;

namespace AwesomePokerGameSln
{
    public partial class FrmPlaygame : Form
    {
        private Deck deck;
        private PictureBox[] playerCardPics;
        private PictureBox[] dealerCardPics;
        private Hand playerHand;
        private Hand dealerHand;
        WindowsMediaPlayer player = new WindowsMediaPlayer();

        public FrmPlaygame()
        {
            InitializeComponent();
            player.settings.setMode("loop", true);
            player.URL = "g1g2_jump.mp3";
            playerCardPics = new PictureBox[5];
            for (int c = 1; c <= 5; c++)
            {
                playerCardPics[c - 1] = this.Controls.Find("picCard" + c.ToString(), true)[0] as PictureBox;
            }
            dealerCardPics = new PictureBox[5];
            for (int c = 1; c <= 5; c++)
            {
                dealerCardPics[c - 1] = this.Controls.Find("pictureBox" + c.ToString(), true)[0] as PictureBox;
            }
        }

        private void dealCards()
        {
            deck.shuffleDeck();
            Tuple<int, int>[] cards = new Tuple<int, int>[5];
            int index = 0;
            foreach (PictureBox playerCardPic in playerCardPics)
            {
                CardType card = deck.nextCard();
                //CardType card = new CardType(index, inde);
                cards[index++] = card;
                playerCardPic.BackgroundImage = CardImageHelper.cardToBitmap(card);
            }
            playerHand = new Hand(cards);
            lblHandType.Text = playerHand.getHandType().ToString();

            cards = new CardType[5];
            index = 0;
            foreach (PictureBox dealerCardPic in dealerCardPics)
            {
                CardType card = deck.nextCard();
                //CardType card = new CardType(index, inde);
                cards[index++] = card;
                dealerCardPic.BackgroundImage = CardImageHelper.cardToBitmap(card);
            }
            dealerHand = new Hand(cards);
            lblHandTypeDealer.Text = dealerHand.getHandType().ToString();

            if (playerHand.getHandType() == dealerHand.getHandType())
            {
                lblWin.Text = "Draw";
            }
            else if (playerHand.getHandType() < dealerHand.getHandType())
            {
                lblWin.Text = "You Win!";
            }
            else
            {
                lblWin.Text = "You Lose";
            }
        }

        private void FrmPlaygame_FormClosed(object sender, FormClosedEventArgs e)
        {
            foreach (Form f in Application.OpenForms)
                f.Close();
        }

        private void FrmPlaygame_Load(object sender, EventArgs e)
        {
            deck = new Deck();
            dealCards();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dealCards();
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

        public static DialogResult InputBox(string title, string promptText, ref string defaultInput)
        {
            Form form = new Form();
            Label label = new Label();
            TextBox textBox = new TextBox();
            Button buttonOk = new Button();
            Button buttonCancel = new Button();

            form.Text = title;
            label.Text = promptText;
            textBox.Text = defaultInput;

            buttonOk.Text = "OK";
            buttonCancel.Text = "Cancel";
            buttonOk.DialogResult = DialogResult.OK;
            buttonCancel.DialogResult = DialogResult.Cancel;

            label.SetBounds(9, 20, 372, 13);
            textBox.SetBounds(12, 36, 372, 20);
            buttonOk.SetBounds(228, 72, 75, 23);
            buttonCancel.SetBounds(309, 72, 75, 23);

            label.AutoSize = true;
            textBox.Anchor = textBox.Anchor | AnchorStyles.Right;
            buttonOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;

            form.ClientSize = new Size(396, 107);
            form.Controls.AddRange(new Control[] { label, textBox, buttonOk, buttonCancel });
            form.ClientSize = new Size(Math.Max(300, label.Right + 10), form.ClientSize.Height);
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MinimizeBox = false;
            form.MaximizeBox = false;
            form.AcceptButton = buttonOk;
            form.CancelButton = buttonCancel;

            DialogResult dialogResult = form.ShowDialog();
            defaultInput = textBox.Text;
            return dialogResult;
        }

        private void btnReportBug_Click(object sender, EventArgs e)
        {
            string defaultInput = "Enter here";
            if (InputBox("Report Bug", "Enter the bug encountered:", ref defaultInput) == DialogResult.OK)
            {
                string bugReport = defaultInput;

                var fromAddress = new MailAddress("403pokergame@gmail.com", "Poker Game");
                var toAddress = new MailAddress("403pokergame@gmail.com", "Poker Game");
                const string fromPassword = "br0wnteam";
                const string subject = "Bug Report of 403 poker game";
                string body = bugReport;

                var smtp = new SmtpClient
                {
                    Host = "smtp.gmail.com",
                    Port = 587,
                    EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
                };
                using (var message = new MailMessage(fromAddress, toAddress)
                {
                    Subject = subject,
                    Body = body
                })
                {
                    smtp.Send(message);
                }
            }
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnViewRuleBook_Click(object sender, EventArgs e)
        {
            if (btnViewRuleBook.Text.StartsWith("View", true, null))
            {
                picRulebook.Visible = true;
                btnViewRuleBook.Text = "Close Rule Book";
            }
            else
            {
                picRulebook.Visible = false;
                btnViewRuleBook.Text = "View Rule Book";
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblHandType_Click(object sender, EventArgs e)
        {

        }
    }
}
