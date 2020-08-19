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
        List<Button> btnList = new List<Button>();

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
            button2_Click(sender, e);
       }

        private void button10_Click(object sender, EventArgs e)
        {
            NeuesSpiel();
            OnShown(e);
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
            String[] btnId = { A00.Text, A01.Text, A02.Text, A10.Text, A11.Text, A12.Text, A20.Text, A21.Text, A22.Text };


            // Horizental
            for (int i = 0; i < 9; i = i + 3)
            {
                if (btnId[i] == btnId[i + 1] && btnId[i] == btnId[i + 2] && btnId[i] != "")
                {
                    return true;
                }
                
            }
            //Vertikal

            for (int n = 0; n < 3; n++)
            {


                if (btnId[n] == btnId[n + 3] && btnId[n] == btnId[n + 6] && btnId[n] != "")
                {
                    return true;
                }
                
            }


            //Mitte
            for (int m = 0; m < 3; m = m + 2)
            {
                if (btnId[m] == btnId[m + 4 - m] && btnId[m] == btnId[10 - m - 2] && btnId[m] != "")
                {
                    return true;
                }
              
            }
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
            OnShown(e);
        }

        public void PcEingabe( )
        {
           
            Random eingane = new Random();
            btnList.Add(A00);
            btnList.Add(A01);
            btnList.Add(A02);
            btnList.Add(A10);
            btnList.Add(A11);
            btnList.Add(A12);
            btnList.Add(A20);
            btnList.Add(A21);
            btnList.Add(A22);

            for (int j = 0; j < 9; j++)
            {
                List<int> list = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8 };
                int a = eingane.Next(list.Count);
                for (int i = 0; i < 9; i++)
                {

                    if (a == i && btnList[i].Text != "")
                    {

                        list.Remove(a);
                      

                    }
                    else if (a == i && btnList[i].Text == "")
                    {
                        ptnWert(btnList[i]);
                        list.Remove(a);
                        break;

                    }

                }
                if (spieler%2==1)
                break;
            }
        }
      
        public void ptnWert(Button btn)
        {
            btn.Text = "Y";
            zug++;
            spieler++;
        }


        public void SchwierSp( )
        {

            if (spieler == 0|| spieler == 2 && A20.Text=="")
            {
                ptnWert(A20);
            }
           

            else if (A20.Text=="Y"&&A11.Text=="Y" && A02.Text==""  || A22.Text == "Y" && A12.Text == "Y" && A02.Text == "" || A00.Text == "Y" && A01.Text == "Y" && A02.Text == "" )
            {
                
                ptnWert(A02);
            }
            else if (A00.Text == "Y" && A11.Text == "Y" && A22.Text == "" || A02.Text == "Y" && A12.Text == "Y" && A22.Text == ""|| A20.Text=="Y"&& A21.Text=="Y" && A22.Text=="")
            {
                ptnWert(A22);
            }

            else if (A12.Text == "Y" && A11.Text == "Y" && A10.Text == "" || A00.Text == "Y" && A20.Text == "Y" && A10.Text == "" )
            {
                ptnWert(A10);
            }
            else if (A10.Text == "Y" && A11.Text == "Y" && A12.Text == "" || A02.Text == "Y" && A22.Text == "Y" && A12.Text == "")
            {
                ptnWert(A12);
            }
            else if (A21.Text == "Y" && A11.Text == "Y" && A01.Text == "" || A00.Text == "Y" && A02.Text == "Y" && A01.Text == "")
            {
                ptnWert(A01);
            }
            else if (A01.Text == "Y" && A11.Text == "Y" && A21.Text == ""  || A20.Text == "Y" && A22.Text == "Y" && A21.Text == "" )
            {
                ptnWert(A21);
            }
            else if (A22.Text == "Y" && A11.Text == "Y" && A00.Text == "" || A22.Text == "X" && A11.Text == "X" && A00.Text == "" || A20.Text == "Y" && A10.Text == "Y" && A00.Text == "" || A20.Text == "X" && A10.Text == "X" && A00.Text == "" || A02.Text == "Y" && A10.Text == "Y" && A00.Text == "" || A02.Text == "X" && A01.Text == "X" && A00.Text == "")
            {
                ptnWert(A00);
            }
            else if (A01.Text == "X" && A11.Text == "X" && A21.Text == "" || A20.Text == "X" && A22.Text == "X" && A21.Text == "")
            {
                ptnWert(A21);
            }
            else if (A20.Text == "X" && A11.Text == "X" && A02.Text == "" || A22.Text == "X" && A12.Text == "X" && A02.Text == "" || A00.Text == "X" && A01.Text == "X" && A02.Text == "")
            {
                ptnWert(A02);
            }
            else if (A12.Text == "X" && A11.Text == "X" && A10.Text == "" || A00.Text == "X" && A20.Text == "X" && A10.Text == "")
            {
                ptnWert(A10);
            }
            else if (A21.Text == "X" && A11.Text == "X" && A01.Text == "" || A00.Text == "X" && A02.Text == "X" && A01.Text == "")
                {
                ptnWert(A01);
            }
            else if (A00.Text == "X" && A11.Text == "X" && A22.Text == "" || A02.Text == "X" && A12.Text == "X" && A22.Text == "" || A20.Text == "X" && A21.Text == "X" && A22.Text == "")
            {
                ptnWert(A22);
            }

            else if ((A10.Text == "X" && A11.Text == "X" && A12.Text == "") || (A02.Text == "X" && A22.Text == "X" && A12.Text == ""))
            {
                ptnWert(A12);
            }
            
            else if ( (A11.Text == "" ) &&  (spieler == 2 ||spieler==4 ))
            {
                ptnWert(A11);
            }
            else if (( A12.Text == "") && (spieler == 0 || spieler == 2 || spieler == 4|| spieler == 6 || spieler == 8 || spieler == 10))
            {
                ptnWert(A12);
            }
            else if ((A02.Text == "") && (spieler == 2 || spieler == 4 || spieler == 6 || spieler == 8))
            {
                ptnWert(A02);
            }
            else if ((A21.Text == "") && (spieler ==10 || spieler == 6 || spieler == 8))
            {
                ptnWert(A21);
            }
            else if ((A22.Text == "") && (spieler == 10 ||  spieler == 8))
            {
                ptnWert(A22);
            }
            else if ((A00.Text == "") && (spieler == 6 || spieler == 4))
            {
                ptnWert(A00);
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

        private void button2_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
           

            for (int i = 0; i <= 8; i++)
            {
                
                if (spieler % 2 == 0)
                {
                    if (checkBox1.Checked)
                    {

                        SchwierSp();

                    }
                    else

                        PcEingabe();

                }
            }

            if (Unentschieden() == true)
            {
                MessageBox.Show("Es ist Unentschieden");
                unentschieden++;
                NeuesSpiel();
            }
            else if (Gewinnt())
            {
                    MessageBox.Show("Gegner hat gewonnen");
                    s2++;
                    NeuesSpiel();
                
            }
        }
        
        protected override void OnShown(EventArgs e)
        {
            
                base.OnShown(e);
                this.button2_Click(null, null);  
        }
        
    }
    }

