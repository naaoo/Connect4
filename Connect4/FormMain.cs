using Data;
using Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Connect4
{
    public partial class MainForm : Form
    {
        MainController controller = MainController.GetInstance();
        public MainForm()
        {
            InitializeComponent();
            controller.update = UpdatePlayers;
            UpdatePlayers();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Player player1 = cbPlayer1.SelectedItem as Player;
            Player player2 = cbPlayer2.SelectedItem as Player;
            if (player1 == player2)
            {
                MessageBox.Show("You can't play against yourself...");
            }
            else
            {
                FormGame game = new FormGame(Show, player1, player2);
                game.Show();
                Hide();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            controller.AddPlayer(tbPlayer.Text);
            tbPlayer.Text = null;
        }

        private void tbPlayer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                controller.AddPlayer(tbPlayer.Text);
                tbPlayer.Text = null;
            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {

        }

        private void UpdatePlayers()
        {
            cbPlayer1.DataSource = controller.GetPlayers(false);
            cbPlayer2.DataSource = controller.GetPlayers(true);
        }
    }
}
