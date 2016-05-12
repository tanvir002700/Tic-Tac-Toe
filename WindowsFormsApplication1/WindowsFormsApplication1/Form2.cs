using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {
        Form1 f;
        string player1,player2;
        game g;
        public Form2()
        {
            InitializeComponent();
        }
        private void Show_result(string name)
        {
            MessageBox.Show(name+" win","Result",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
        }
        private void show_drow()
        {
            MessageBox.Show("Game drow","Result",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
        }
        public Form2(string n1, string n2,Form1 F)
        {
            f = F;
            g = new game();
            player1 = n1;
            player2 = n2;
            InitializeComponent();
            string msg = n1 + " Vs " + n2;
            this.Text = msg;
        }
        void set(int x, int y,Button b)
        {
            if (g.Set_move(x, y) == true)
            {
                int n = g.which_player();
                if (n == 0) b.BackgroundImage=global::WindowsFormsApplication1.Properties.Resources.zero;
                else b.BackgroundImage=global::WindowsFormsApplication1.Properties.Resources.cross1;
            }
            else
            {
                MessageBox.Show("Invalid move","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }
        void result()
        {
            if (g.is_win() ==1||g.is_win()==2)
            {
                if (g.is_win() == 1) Show_result(player1);
                else Show_result(player2);
                this.Dispose();
                f.Show();
            }
            else if (g.is_drow())
            {
                show_drow();
                this.Dispose();
                f.Show();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            set(0, 0, button1);
            result();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            set(0, 1, button2);
            result();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            set(0, 2, button3);
            result();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            set(1, 0, button4);
            result();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            set(1, 1, button5);
            result();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            set(1, 2, button6);
            result();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            set(2, 0, button7);
            result();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            set(2, 1, button8);
            result();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            set(2, 2, button9);
            result();
        }


    }
}
