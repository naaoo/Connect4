using Data;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logic
{
    public class GameController
    {
        public Action<int[,]> updateBoxes;
        public Action updateTurnBox;
        public Player player1;
        public Player player2;
        public int turns = 0;
        public Player turnPlayer;
        public int[,] comp = new int[7,8];

        public void GetControllerParams(Action<int[,]> action, Action action1, Player p1, Player p2)
        {
            updateBoxes = action;
            updateTurnBox = action1;
            p1.color = Color.FromArgb(255, 128, 128);
            p2.color = Color.FromArgb(255, 255, 128);
            
            p1.sign = 1;
            p2.sign = 2;
            player1 = p1;
            player2 = p2;
            turnPlayer = player1;
        }

        /// <summary>
        /// a full players turn
        /// </summary>
        /// <param name="col"></param>
        public void DropStone(int col)
        {
            if (!CheckColFull(col))
            {
                SetMark(col);
                updateBoxes.Invoke(comp);
                if (CheckWin())
                {
                    MessageBox.Show("Congratulations!\nWinner: " + turnPlayer.name);
                }
                if (CheckAllFilled())
                {
                    MessageBox.Show("All fields are taken!\nUndecided...");
                }
                turns++;
                ChangePlayer();
                updateTurnBox.Invoke();
            }
            else
            {
                MessageBox.Show("That column is completely filled\nPlease choose another");
                // Todo: EndProcess
            }
        }

        public void SetMark(int col)
        {
            for (int i = 6; i > -1; i--)
            {
                if (comp[i,col] == 0)
                {
                    comp[i, col] = turnPlayer.sign;
                    break;
                }
            }
        }

        private bool CheckColFull(int col)
        {
            bool full = true;
            for (int i = 0; i < 7; i++)
            {
                if (comp[i,col] == 0)
                {
                    full = false;
                    break;
                }
            }
            return full;
        }

        private bool CheckAllFilled()
        {
            bool full = true;
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (comp[i,j] == 0)
                    {
                        full = false;
                        break;
                    }
                }
            }
            return full;
        }

        private bool CheckWin()
        {
            
            if (VerticalWin() || HorizontalWin() || DiagonalAscWin() || DiagonalDescWin())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool VerticalWin()
        {
            bool win = false;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (comp[i,j] != 0 && 
                        (comp[i,j] == comp[i + 1, j] && comp[i, j] == comp[i + 2, j] && comp[i, j] == comp[i + 3, j]))
                    {
                        win = true;
                    }
                }
            }
            return win;
        }

        private bool HorizontalWin()
        {
            bool win = false;
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (comp[i,j] != 0 &&
                        (comp[i,j] == comp[i ,j + 1] && comp[i, j] == comp[i, j + 2] && comp[i, j] == comp[i, j + 3]))
                    {
                        win = true;
                    }
                }
            }
            return win;
        }

        private bool DiagonalAscWin()
        {
            bool win = false;
            for (int i = 3; i < 7; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (comp[i,j] != 0 &&
                        comp[i,j] == comp[i - 1,j + 1] && comp[i, j] == comp[i - 2, j + 2] && comp[i, j] == comp[i - 3, j + 3])
                    {
                        win = true;
                    }
                }
            }
            return win;
        }

        private bool DiagonalDescWin()
        {
            bool win = false;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (comp[i, j] != 0
                        && comp[i, j] == comp[i + 1, j + 1] && comp[i, j] == comp[i + 2, j + 2] && comp[i, j] == comp[i + 3, j + 3])
                    {
                        win = true;
                    }
                }
            }
            return win;
        }

        public void ChangePlayer()
        {
            if (turns % 2 == 0)
            {
                turnPlayer = player1;
            }
            else
            {
                turnPlayer = player2;
            }
        }
    }
}
