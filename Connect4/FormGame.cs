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
    public partial class FormGame : Form
    {
        GameController gameController = new GameController();
        Action parentFormShow;

        List<List<PictureBox>> boxes = new List<List<PictureBox>>();
        
       
        public FormGame()
        {
            InitializeComponent();
        }

        public FormGame(Action action, Player player1, Player player2)
        {
            InitializeComponent();
            gameController.GetControllerParams(UpdateBoxes, UpdateTurnBox, player1, player2);
            parentFormShow = action;
            boxes = AssignBoxes();
            UpdateTurnBox();
        }

        

        private List<List<PictureBox>> AssignBoxes()
        {
            List<PictureBox> boxes1 = new List<PictureBox>() { pb1, pb2, pb3, pb4, pb5, pb6, pb7, pb8 };
            List<PictureBox> boxes2 = new List<PictureBox>() { pb9, pb10, pb11, pb12, pb13, pb14, pb15, pb16 };
            List<PictureBox> boxes3 = new List<PictureBox>() { pb17, pb18, pb19, pb20, pb21, pb22, pb23, pb24 };
            List<PictureBox> boxes4 = new List<PictureBox>() { pb25, pb26, pb27, pb28, pb29, pb30, pb31, pb32 };
            List<PictureBox> boxes5 = new List<PictureBox>() { pb33, pb34, pb35, pb36, pb37, pb38, pb39, pb40 };
            List<PictureBox> boxes6 = new List<PictureBox>() { pb41, pb42, pb43, pb44, pb45, pb46, pb47, pb48 };
            List<PictureBox> boxes7 = new List<PictureBox>() { pb49, pb50, pb51, pb52, pb53, pb54, pb55, pb56 };
            return new List<List<PictureBox>>() { boxes1, boxes2, boxes3, boxes4, boxes5, boxes6, boxes7 };
        }

        private void UpdateBoxes(int[,] comp)
        {
            ColorBoxes(comp);
        }

        private void UpdateTurnBox()
        {
            pbTurn.BackColor = gameController.turnPlayer.color;
            
        }

        private void ColorBoxes(int[,] comp)
        {
            // rows
            for (int i = 0; i < 7; i++)
            {
                // cols
                for (int j = 0; j < 8; j++)
                {
                    if (comp[i,j] == 1)
                    {
                        boxes[i][j].BackColor = gameController.player1.color;
                    } 
                    else if (comp[i,j] == 2)
                    {
                        boxes[i][j].BackColor = gameController.player2.color;
                    }
                }
            }
        }

        private void btnCol0_Click(object sender, EventArgs e)
        {
            DropStone(0);
        }

        private void btnCol1_Click(object sender, EventArgs e)
        {
            DropStone(1);
        }

        private void btnCol2_Click(object sender, EventArgs e)
        {
            DropStone(2);
        }

        private void btnCol3_Click(object sender, EventArgs e)
        {
            DropStone(3);
        }

        private void btnCol4_Click(object sender, EventArgs e)
        {
            DropStone(4);
        }

        private void btnCol5_Click(object sender, EventArgs e)
        {
            DropStone(5);
        }

        private void btnCol6_Click(object sender, EventArgs e)
        {
            DropStone(6);
        }

        private void btnCol7_Click(object sender, EventArgs e)
        {
            DropStone(7);
        }

        private void DropStone(int col)
        {
            gameController.DropStone(col);
        }
    }
}
