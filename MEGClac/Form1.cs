using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MEGClac
{
    public partial class Form1 : Form
    {
        int player1 = 0;
        int player2 = 0;
        int player2Distance = 0;
        double totalDistance = 0;
        double procentDone = 0;
        public Form1()
        {
            InitializeComponent();
            Procent.Text = Convert.ToString(procentDone) + "%";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try // Couldn't be bothered to check if the input is a number or text, so i just added a try catch
            {
                player1 = Convert.ToInt32(tbPlayer1.Text); // Takes the input and makes it a variable
                if (player2 != 0 && player2 > 0 && player1 > 0) // Starts the calculating process if both fields has an input
                {
                    player2Distance = 3750000 - player2; // player2 is on the NE corner, so it's finding the distance from the wb to player2's position
                    totalDistance = player2Distance + player1;
                    if (totalDistance > 0 && totalDistance < 3750000)  // Checks if the distance is valid
                    { 
                    Distance.Text = Convert.ToString(totalDistance);
                        Netherrack.Text = Convert.ToString(totalDistance * 24);
                        procentDone = totalDistance / 3750000 * 100; // I had some trouble calculating procent in the field below, so i just split it in 2.
                        Procent.Text = Convert.ToString(Math.Round(procentDone,2)) + "%"; 
                        Procent.Text = String.Format("{0:#,##0.00}", double.Parse(Procent.Text)); 
                         Netherrack.Text = String.Format("{0:n0}", double.Parse(Procent.Text));     //I tried to split up the 1000's like 1,000,000 instead of 1000000 but
                        Distance.Text = String.Format("{0:n0}", double.Parse(Procent.Text));        // i just couldn't get it to work for the life of me. It still outputs the number here though
                    }
                    else
                    {
                        Distance.Text = "";
                        Netherrack.Text = ""; // Clears fields if the distance isn't valid
                        Procent.Text = "";
                    }
                }
            }
            catch(Exception)
            {
            }
        }

        private void tbPlayer2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                player2 = Convert.ToInt32(tbPlayer2.Text);
                if (player2 != 0 && player2 > 0 && player1 > 0)
                {
                    player2Distance = 3750000 - player2;                    // Basically the same as player1.
                    totalDistance = player2Distance + player1;             // I duplicated the code to player2 as well so no matter what order 
                    if (totalDistance > 0 && totalDistance < 3750000)     // you typed the coords in, it'd calculate it.
                    {
                        Distance.Text = Convert.ToString(totalDistance);
                        Netherrack.Text = Convert.ToString(totalDistance * 24);
                        procentDone = totalDistance / 3750000 * 100;
                        Procent.Text = Convert.ToString(Math.Round(procentDone, 2)) + "%";
                        Netherrack.Text = String.Format("{0:n0}", double.Parse(Procent.Text));
                        Distance.Text = String.Format("{0:n0}", double.Parse(Procent.Text));
                    }
                    else
                    {
                        Distance.Text = "";
                        Netherrack.Text = "";
                        Procent.Text = "";
                    }
                }
                }
            catch (Exception)
            {
            }
        }

        private void button1_Click(object sender, EventArgs e)    // This is for the copy paste field. The textbox's name tbPasta refers to Copy Pasta
        {                             
            tbPasta.Text = "";
            tbPasta.Text = "Leg 1 current progress: **" + Convert.ToString(Math.Round(procentDone, 2)) + "% done**";
            tbPasta.Text = tbPasta.Text + "\r\n";
            tbPasta.Text = tbPasta.Text + "\r\n";
            tbPasta.Text = tbPasta.Text + "Total distance dug: " + Distance.Text + "/3750000";
            tbPasta.Text = tbPasta.Text + "\r\n";
            tbPasta.Text = tbPasta.Text + "Netherrack dug: " + Netherrack.Text + "/90000000";
            tbPasta.Text = tbPasta.Text + "\r\n";
            tbPasta.Text = tbPasta.Text + "\r\n";
            tbPasta.Text = tbPasta.Text + "Digger 1 position: " + tbPlayer1.Text + ", -3750000";
            tbPasta.Text = tbPasta.Text + "\r\n";
            tbPasta.Text = tbPasta.Text + "Digger 2 position: " + tbPlayer2.Text + ", -3750000"; // It could probably be more efficient, but idgaf it works

        }
    }
}
