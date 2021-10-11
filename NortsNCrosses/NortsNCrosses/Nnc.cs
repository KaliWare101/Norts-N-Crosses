using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NortsNCrosses
{
    public partial class Nnc : Form
    {
        public Nnc()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        void Clear()
        {
            tl.Text = "";
            tm.Text = "";
            tr.Text = "";
            ml.Text = "";
            mr.Text = "";
            mm.Text = "";
            bl.Text = "";
            bm.Text = "";
            br.Text = "";
            checkwin.Stop();
            button1.Text = "Play";
            panel1.Show();
        }
        public void button1_Click(object sender, EventArgs e)
        {
            var button = (Button)sender;
            if (button.Text == "")
            {
                if (groupBox1.Text == "Player ( X )")
                {
                    button.Text = "X";
                    groupBox1.Text = "Player ( O )";
                }
                else
                {
                    button.Text = "O";
                    groupBox1.Text = "Player ( X )";
                }
            }
            else
            {
                MessageBox.Show("Move already taken!");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
       
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var button = (Button)sender;
            if (button.Text == "")
            {
                if (groupBox1.Text == "Player ( X )")
                {
                    button.Text = "X";
                    groupBox1.Text = "Player ( O )";
                }
                else
                {
                    button.Text = "O";
                    groupBox1.Text = "Player ( X )";
                }
            }
            else
            {
                MessageBox.Show("Move already taken!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var button = (Button)sender;
            if (button.Text == "")
            {
                if (groupBox1.Text == "Player ( X )")
                {
                    button.Text = "X";
                    groupBox1.Text = "Player ( O )";
                }
                else
                {
                    button.Text = "O";
                    groupBox1.Text = "Player ( X )";
                }
            }
            else
            {
                MessageBox.Show("Move already taken!");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var button = (Button)sender;
            if (button.Text == "")
            {
                if (groupBox1.Text == "Player ( X )")
                {
                    button.Text = "X";
                    groupBox1.Text = "Player ( O )";
                }
                else
                {
                    button.Text = "O";
                    groupBox1.Text = "Player ( X )";
                }
            }
            else
            {
                MessageBox.Show("Move already taken!");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var button = (Button)sender;
            if (button.Text == "")
            {
                if (groupBox1.Text == "Player ( X )")
                {
                    button.Text = "X";
                    groupBox1.Text = "Player ( O )";
                }
                else
                {
                    button.Text = "O";
                    groupBox1.Text = "Player ( X )";
                }
            }
            else
            {
                MessageBox.Show("Move already taken!");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var button = (Button)sender;
            if (button.Text == "")
            {
                if (groupBox1.Text == "Player ( X )")
                {
                    button.Text = "X";
                    groupBox1.Text = "Player ( O )";
                }
                else
                {
                    button.Text = "O";
                    groupBox1.Text = "Player ( X )";
                }
            }
            else
            {
                MessageBox.Show("Move already taken!");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            var button = (Button)sender;
            if (button.Text == "")
            {
                if (groupBox1.Text == "Player ( X )")
                {
                    button.Text = "X";
                    groupBox1.Text = "Player ( O )";
                }
                else
                {
                    button.Text = "O";
                    groupBox1.Text = "Player ( X )";
                }
            }
            else
            {
                MessageBox.Show("Move already taken!");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            var button = (Button)sender;
            if (button.Text == "")
            {
                if (groupBox1.Text == "Player ( X )")
                {
                    button.Text = "X";
                    groupBox1.Text = "Player ( O )";
                }
                else
                {
                    button.Text = "O";
                    groupBox1.Text = "Player ( X )";
                }
            }
            else
            {
                MessageBox.Show("Move already taken!");
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            var button = (Button)sender;
            if (button.Text == "")
            {
                if (groupBox1.Text == "Player ( X )")
                {
                    button.Text = "X";
                    groupBox1.Text = "Player ( O )";
                }
                else
                {
                    button.Text = "O";
                    groupBox1.Text = "Player ( X )";
                }
            }
            else
            {
                MessageBox.Show("Move already taken!");
            }
        }

        private void checkwin_Tick(object sender, EventArgs e)
        {
            if(tr.Text == "X" & mr.Text == "X" & br.Text == "X" || tm.Text == "X" & mm.Text == "X" & bm.Text == "X" 
                || tl.Text == "X" & ml.Text == "X" & bl.Text == "X" || tl.Text == "X" & tm.Text == "X" & tr.Text == "X" 
                || ml.Text == "X" & mm.Text == "X" & mr.Text == "X" || bl.Text == "X" & bm.Text == "X" & br.Text == "X"
                || tl.Text == "X" & mm.Text == "X" & br.Text == "X" || bl.Text == "X" & mm.Text == "X" & tr.Text == "X")
            {
                checkwin.Stop();
                MessageBox.Show("Player ( X )\nis the winner", "Hooray", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Clear();
            }
            else if(tr.Text == "O" & mr.Text == "O" & br.Text == "O" || tm.Text == "O" & mm.Text == "O" & bm.Text == "O"
                || tl.Text == "O" & ml.Text == "O" & bl.Text == "O" || tl.Text == "O" & tm.Text == "O" & tr.Text == "O"
                || ml.Text == "O" & mm.Text == "O" & mr.Text == "O" || bl.Text == "O" & bm.Text == "O" & br.Text == "O"
                || tl.Text == "O" & mm.Text == "O" & br.Text == "O" || bl.Text == "O" & mm.Text == "O" & tr.Text == "O")
            {
                checkwin.Stop();
                MessageBox.Show("Player ( O )\nis the winner", "Hooray", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Clear();
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (button1.Text == "Play")
            {
                panel1.Hide();
                checkwin.Start();
                button1.Text = "Stop";
            }
            else
            {
                Clear();
            }
        }
    }
}
