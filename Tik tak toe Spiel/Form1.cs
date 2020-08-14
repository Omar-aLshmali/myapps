using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tik_tak_toe_Spiel
{
    public partial class Form1 : Form
    {

        int spieler ;
        int s1 = 0;
        int s2 = 0;
        int unentschieden = 0;
        int zug = 0;
        String[] btnId;

       
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RandomPlay();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void ButtonAll(object sender, EventArgs e)
        {
            Button button = (Button) sender;
           
            if (button.Text == "")
            {




                if (spieler % 2 == 1)
                {
                    button.Text = "X";
                    spieler++;
                    zug++;
                    
                }
                else
                {
                    PcEingabe();
                }
                    

                if (Unentschieden()==true)
                {
                    MessageBox.Show("Es ist Unentschieden");
                    unentschieden++;
                    NeuesSpiel();
                }
                if (IsGewinnt())
                {
                   if (button.Text=="X")
                    {
                        MessageBox.Show("X hat gewonnen");
                        s1++;
                        NeuesSpiel();
                    }
                    else
                    {
                        MessageBox.Show("Y hat gewonnen");
                        s2++;
                        NeuesSpiel();
                    }
                }
            }
           

        }

        private void button10_Click(object sender, EventArgs e)
        {
            NeuesSpiel();
        }

        public void NeuesSpiel()
        {
            A00.Text = A01.Text = A02.Text = A10.Text = A11.Text = A12.Text = A20.Text = A21.Text = A22.Text = "";
            sp1.Text = "Spieler 1 : " + s1.ToString();
            sp2.Text = "Spieler 2 : " + s2.ToString();
            unent.Text = unentschieden.ToString();
            zug = 0;
            RandomPlay();
            
        }
        bool IsGewinnt()
        {

            /*
          String [] btnId= {A00.Text.ToString(),A12.Text.ToString(),A02.Text.ToString(),A10.Text.ToString(), A11.Text.ToString(),A12.Text.ToString(),
                            A20.Text.ToString(),A21.Text.ToString(),A22.Text.ToString() };
            */


            // Horizental
            if (A00.Text== A01.Text && A00.Text==A02.Text && A00.Text!="")
            {
                return true;   
            }
            if (A10.Text == A11.Text && A10.Text == A12.Text && A10.Text != "")
            {
                return true;
            }
            if (A20.Text == A21.Text && A20.Text == A22.Text && A20.Text != "")
            {
                return true;
            }


            //Vertikal
            if (A00.Text == A10.Text && A00.Text == A20.Text && A00.Text != "")
            {
                return true;
            }
            if (A01.Text == A11.Text && A01.Text == A21.Text && A01.Text != "")
            {
                return true;
            }
            if (A02.Text == A12.Text && A02.Text == A22.Text && A02.Text != "")
            {
                return true;
            } 


            //Mitte
            if (A00.Text == A11.Text && A00.Text == A22.Text && A00.Text != "")
            {
                return true;
            }
            if (A20.Text == A11.Text && A20.Text == A12.Text && A20.Text != "")
            {
                return true;
            }

            else
                return false;
        }
        bool Unentschieden()
        {

            if (zug == 9 && IsGewinnt()==false)
            {
                
                return true;

            }


            else { 
                return false; 
            }
                
        }
        public void RandomPlay()
        {

            Random spielerAn = new Random();
         int   spRandom = spielerAn.Next(4,6);
             
            if (spRandom ==5)
            {
                spieler = spRandom;
                istdran.Text = "Du bist Dran";
                
            }
            else if (spRandom==4)
            {
                spieler = spRandom;
                istdran.Text = "PC ist dran";


            }

            

        }
        public void rest()
        {
            s2 = 0;
            s1 = 0;
            unentschieden = 0;
            NeuesSpiel();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            rest();
        }

        public void PcEingabe()
        {
            Random eingane = new Random();

            int a = eingane.Next(9);
            switch(a)
            {
                case 1:
                    if ( A00.Text=="" )
                    {
                        A00.Text = "Y";
                        zug++;
                        spieler++;
                        break;
                    }
                    else
                    
                        break;
                    
                case 2:
                    if ( A01.Text == "")
                    {
                        A01.Text = "Y";
                    zug++;
                    spieler++;
                    break;
                    }
                    else

                        break;
                case 3:
                    if ( A02.Text == "")
                    {
                        A02.Text = "Y";
                    zug++;
                    spieler++;
                    break;
                    }
                    else

                        break;
                case 4:

                    if (  A10.Text == "")
                    {
                        A10.Text = "Y";
                    zug++;
                    spieler++;
                    break;
                    }
                    else

                        break;
                case 5:
                    if ( A11.Text == "")
                    {
                        A11.Text = "Y";
                    zug++;
                    spieler++;
                    break;
                    }
                    else

                        break;
                case 6:
                    if ( A12.Text == "")
                    {
                        A12.Text = "Y";
                        zug++;
                        spieler++;
                        break;
                    }
                    else

                        break;
                case 7:
                    if ( A20.Text == "")
                    {
                        A20.Text = "Y";
                        zug++;
                        spieler++;
                        break;
                    }
                    else

                        break;
                case 8:
                    if (  A21.Text == "")
                    {
                        A21.Text = "Y";
                        zug++;
                        spieler++;
                        break;
                    }
                    else

                        break;
                case 9:
                    if (  A22.Text == "")
                    {
                        A22.Text = "Y";
                        zug++;
                        spieler++;
                        break;
                    }
                    else

                        break;




            }



        }
    }
}
