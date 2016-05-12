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
    public partial class setplayername : Form
    {
        Form1 f;
        public setplayername()
        {
            InitializeComponent();
        }
        public setplayername(Form1 obj)
        {
            f = obj;
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string n1 = textBox1.Text;
            string n2 = textBox2.Text;
            f.set_name(n1, n2);
            Form2 NewGame = new Form2(n1, n2, f);
            NewGame.Show();
            this.Dispose();
        }
    }
}
