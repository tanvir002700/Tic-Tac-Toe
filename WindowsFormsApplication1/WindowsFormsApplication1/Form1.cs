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
    public partial class Form1 : Form
    {
        string player1, player2;
        public Form1()
        {
            InitializeComponent();
        }
        public void set_name(string p1,string p2)
        {
            player1=p1;
            player2=p2;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("this option is under construction");   
        }

        private void button2_Click(object sender, EventArgs e)
        {

            setplayername s = new setplayername(this);
            s.Show();
            this.Hide();
        }
    }
}
