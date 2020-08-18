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
            

            if (spieler % 2 == 1)
            {
                SpielerEingabe(button);
            }
            else if (spieler % 2 == 0)
            { 
                if (checkBox1.Checked)
                {
                    
                    SchwierSp();
                   
                }
                else
                   
                PcEingabe();

            }
        
                
                 
            
            if (Unentschieden() == true)
            {
                MessageBox.Show("Es ist Unentschieden");
                unentschieden++;
                NeuesSpiel();
            }
            else if (Gewinnt())
            {
                if (button.Text == "X")
                {
                    MessageBox.Show("Du hast gewonnen");
                    s1++;
                    NeuesSpiel();
                }
                else 
                {
                    MessageBox.Show("Gegner hat gewonnen");
                    s2++;
                    NeuesSpiel();
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
            sp1.Text = "Du : " + s1.ToString();
            sp2.Text = "Gegner : " + s2.ToString();
            unent.Text = "Unentschieden : "+unentschieden.ToString();
            zug = 0;
            RandomPlay();
            
        }
        bool Gewinnt()
        {

            /*
          String [] btnId= {A00.Text.ToString(),A12.Text.ToString(),A02.Text.ToString(),A10.Text.ToString(), A11.Text.ToString(),A12.Text.ToString(),
                            A20.Text.ToString(),A21.Text.ToString(),A22.Text.ToString() };
            */


            // Horizental
            if (A00.Text == A01.Text && A00.Text == A02.Text && A00.Text != "")
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
            if (A20.Text == A11.Text && A20.Text == A02.Text && A20.Text != "")
            {
                return true;
            }

            else
                return false;
        }
        bool Unentschieden()
        {

            if (zug == 9 && Gewinnt()==false)
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
         int   spRandom = spielerAn.Next(0,2);
             
            if (spRandom ==1)
            {
                spieler = spRandom;
                istdran.Text = "Du fängst an";
                
            }
            else if (spRandom==0)
            {
                spieler = spRandom;
                istdran.Text = "PC fängt an";


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

        public void PcEingabe( )
        {
            Random eingane = new Random();
            
            int a = eingane.Next(9);
            switch(a)
            {
                case 1:
                    if ( A00.Text==""  )
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
        public void SchwierSp( )
        {
            if (spieler == 0|| spieler == 2 && A20.Text=="")
            {
                A20.Text = "Y";
                A20.PerformClick();
                zug++;
                spieler++;
            }
           

            else if (A20.Text=="Y"&&A11.Text=="Y" && A02.Text==""  || A22.Text == "Y" && A12.Text == "Y" && A02.Text == "" || A00.Text == "Y" && A01.Text == "Y" && A02.Text == "" )
            {
                A02.Text = "Y";
                spieler++;
                zug++;
            }
            else if (A00.Text == "Y" && A11.Text == "Y" && A22.Text == "" || A02.Text == "Y" && A12.Text == "Y" && A22.Text == ""|| A20.Text=="Y"&& A21.Text=="Y" && A22.Text=="")
            {
                A22.Text = "Y";
                spieler++;
                zug++;
            }

            else if (A12.Text == "Y" && A11.Text == "Y" && A10.Text == "" || A00.Text == "Y" && A20.Text == "Y" && A10.Text == "" )
            {
                A10.Text = "Y";
                spieler++;
                zug++;
            }
            else if (A10.Text == "Y" && A11.Text == "Y" && A12.Text == "" || A02.Text == "Y" && A22.Text == "Y" && A12.Text == "")
            {
                A12.Text = "Y";
                spieler++;
                zug++;
            }
            else if (A21.Text == "Y" && A11.Text == "Y" && A01.Text == "" || A00.Text == "Y" && A02.Text == "Y" && A01.Text == "")
            {
                A01.Text = "Y";
                spieler++;
                zug++;
            }
            else if (A01.Text == "Y" && A11.Text == "Y" && A21.Text == ""  || A20.Text == "Y" && A22.Text == "Y" && A21.Text == "" )
            {
                A21.Text = "Y";
                spieler++;
                zug++;
            }
            else if (A01.Text == "X" && A11.Text == "X" && A21.Text == "" || A20.Text == "X" && A22.Text == "X" && A21.Text == "")
            {
                A21.Text = "Y";
                spieler++;
                zug++;
            }
            else if (A20.Text == "X" && A11.Text == "X" && A02.Text == "" || A22.Text == "X" && A12.Text == "X" && A02.Text == "" || A00.Text == "X" && A01.Text == "X" && A02.Text == "")
            {
                A02.Text = "Y";
                spieler++;
                zug++;
            }
            else if (A12.Text == "X" && A11.Text == "X" && A10.Text == "" || A00.Text == "X" && A20.Text == "X" && A10.Text == "")
            {
                A10.Text = "Y";
                spieler++;
                zug++;
            }
            else if (A21.Text == "X" && A11.Text == "X" && A01.Text == "" || A00.Text == "X" && A02.Text == "X" && A01.Text == "")
                {
                    A01.Text = "Y";
                    spieler++;
                    zug++;
                }
            else if (A00.Text == "X" && A11.Text == "X" && A22.Text == "" || A02.Text == "X" && A12.Text == "X" && A22.Text == "" || A20.Text == "X" && A21.Text == "X" && A22.Text == "")
            {
                A22.Text = "Y";
                spieler++;
                zug++;
            }

            else if ((A10.Text == "X" && A11.Text == "X" && A12.Text == "") || (A02.Text == "X" && A22.Text == "X" && A12.Text == ""))
            {
                A12.Text = "Y";
                spieler++;
                zug++;
            }
            else if (A22.Text == "Y" && A11.Text == "Y" && A00.Text == "" || A22.Text == "X" && A11.Text == "X" && A00.Text == "" || A20.Text == "Y" && A10.Text == "Y" && A00.Text == "" || A20.Text == "X" && A10.Text == "X" && A00.Text == "" || A02.Text == "Y" && A10.Text == "Y" && A00.Text == "" || A02.Text == "X" && A01.Text == "X" && A00.Text == "")
            {
                A00.Text = "Y";
                spieler++;
                zug++;
            }
            
            else if ( (A11.Text == "" ) &&  (spieler == 2 ||spieler==4 ))
            {
                A11.Text = "Y";
                zug++;
                spieler++;
            }
            else if (( A12.Text == "") && (spieler == 0 || spieler == 2 || spieler == 4|| spieler == 6 || spieler == 8 || spieler == 10))
            {
                A12.Text = "Y";
                zug++;
                spieler++;
            }
            else if ((A02.Text == "") && (spieler == 2 || spieler == 4 || spieler == 6 || spieler == 8))
            {
                A02.Text = "Y";
                zug++;
                spieler++;
            }
            else if ((A21.Text == "") && (spieler ==10 || spieler == 6 || spieler == 8))
            {
                A21.Text = "Y";
                zug++;
                spieler++;
            }
            else if ((A22.Text == "") && (spieler == 10 ||  spieler == 8))
            {
                A22.Text = "Y";
                zug++;
                spieler++;
            }
            else if ((A00.Text == "") && (spieler == 6 || spieler == 4))
            {
                A00.Text = "Y";
                zug++;
                spieler++;
            }
        }
        public void SpielerEingabe(Button b)
        {
            if (b.Text == "")
            {
                   
                        b.Text = "X";
                        spieler++;
                        zug++;
                    
                }
            }
        }
    }

