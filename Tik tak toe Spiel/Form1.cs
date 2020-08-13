using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tik_tak_toe_Spiel
{
    public partial class Form1 : Form
    {

        int spieler;
        int s1 = 0;
        int s2 = 0;
        int unentschieden = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            NeuesSpiel();
        }

        public void NeuesSpiel()
        {

            sp1.Text = "Spieler 1 : " + s1.ToString();
            sp2.Text = "Spieler 2 : " + s2.ToString();
            unent.Text = unentschieden.ToString();

            
        }
    }
}
