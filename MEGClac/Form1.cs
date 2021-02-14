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
        int x = 0;
        int player1 = 0;
        int player2 = 0;
        int oldCoordsN = 0;
        int oldCoordsNE = 0;
        int player2Distance = 0;
        int oldCoordsNEDistance = 0;
        double netherrackPerDay = 0;
        double DaysLeft = 0;
        double oldNetherrack = 0;
        double DistancePerDay = 0;
        double totalDistance = 0;
        double oldtotalDistance;
        double procentDone = 0;
        bool ETACalc = true;
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
                         Netherrack.Text = String.Format("{0:n0}", double.Parse(Netherrack.Text));     //I tried to split up the 1000's like 1,000,000 instead of 1000000 but
                        Distance.Text = String.Format("{0:n0}", double.Parse(Distance.Text));        // i just couldn't get it to work for the life of me. It still outputs the number here though
                    }
                    else
                    {
                        Distance.Text = "";
                        Netherrack.Text = ""; // Clears fields if the distance isn't valid
                        Procent.Text = "";
                    }
                }
                else
                {
                    Distance.Text = "";
                    Netherrack.Text = "";
                    Procent.Text = "";
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
                        Netherrack.Text = String.Format("{0:n0}", double.Parse(Netherrack.Text));
                        Distance.Text = String.Format("{0:n0}", double.Parse(Distance.Text));
                    }
                    else
                    {
                        Distance.Text = "";
                        Netherrack.Text = "";
                        Procent.Text = "";
                    }
                }
                else
                {
                    Distance.Text = "";
                    Netherrack.Text = "";
                    Procent.Text = "";
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
            if (ETACalc == true)
            {
                tbPasta.Text = tbPasta.Text + "\r\n";
                tbPasta.Text = tbPasta.Text + "ETA: **" + daysLeft.Text + " days**";
            }
            tbPasta.Text = tbPasta.Text + "\r\n";
            tbPasta.Text = tbPasta.Text + "\r\n";
            tbPasta.Text = tbPasta.Text + "Total distance dug: " + Distance.Text + "/3750000";
            tbPasta.Text = tbPasta.Text + "\r\n";
            tbPasta.Text = tbPasta.Text + "Netherrack dug: " + Netherrack.Text + "/90000000";
            if (ETACalc == true)
            {
            tbPasta.Text = tbPasta.Text + "\r\n";
                tbPasta.Text = tbPasta.Text + "Distance per day currently: " + distancePerDay.Text;
                tbPasta.Text = tbPasta.Text + "\r\n";
                tbPasta.Text = tbPasta.Text + "Netherrack per day currently: " + NetherrackPerDay.Text;
            }
            tbPasta.Text = tbPasta.Text + "\r\n";
            tbPasta.Text = tbPasta.Text + "\r\n";
            tbPasta.Text = tbPasta.Text + "Digger 1 position: " + tbPlayer1.Text + ", -3750000";
            tbPasta.Text = tbPasta.Text + "\r\n";
            tbPasta.Text = tbPasta.Text + "Digger 2 position: " + tbPlayer2.Text + ", -3750000"; // It could probably be more efficient, but idgaf it works


        }

        private void Netherrack_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(ETACalc == true)
            {
                ETACalc = false;
                tbOldN.Enabled = false;
                tbOldNE.Enabled = false;
                tbDays.Enabled = false;
                button2.Text = "Activate";
            }
            else
            {
                ETACalc = true;
                tbOldN.Enabled = true;
                tbOldNE.Enabled = true;
                tbDays.Enabled = true;
                button2.Text = "Deactivate";
            }
        }

        private void tbOldN_TextChanged(object sender, EventArgs e)
        {
                    oldCoordsN = Convert.ToInt32(tbOldN.Text); // Takes the input and makes it a variable

                try // Couldn't be bothered to check if the input is a number or text, so i just added a try catch
                {
                if (oldCoordsNE > 0 && oldCoordsNE > 0 && oldCoordsN > 0 && player1 > 0 && player2 > 0 && Convert.ToInt32(tbDays.Text) > 0) // Starts the calculating process if all fields has an input
                {
                    oldCoordsNEDistance = 3750000 - oldCoordsNE; // oldCoordsNE is on the NE corner, so it's finding the distance from the wb to oldCoordsNE's position
                    oldtotalDistance = oldCoordsNEDistance + oldCoordsN;
                    if (oldtotalDistance > 0 && oldtotalDistance < 3750000)  // Checks if the distance is valid
                    {
                        // Distance per day
                        x = Convert.ToInt32(tbDays.Text);
                        DistancePerDay = Math.Round((totalDistance - oldtotalDistance) / x);
                        if (DistancePerDay < 0) { DistancePerDay = DistancePerDay * -1; } // I have absolutely no idea why it sometimes returns a negative value
                        distancePerDay.Text = Convert.ToString(DistancePerDay);

                        // Netherrack per Day
                        oldNetherrack = oldtotalDistance * 24;
                        netherrackPerDay = (totalDistance * 24 - oldNetherrack) / Convert.ToDouble(tbDays.Text);
                        if (netherrackPerDay < 0) { netherrackPerDay = netherrackPerDay * -1; }
                        NetherrackPerDay.Text = Convert.ToString(netherrackPerDay);
                        NetherrackPerDay.Text = String.Format("{0:n0}", double.Parse(NetherrackPerDay.Text));

                        // Days left
                        DaysLeft = Math.Round((3750000 - totalDistance) / DistancePerDay, 2);
                        daysLeft.Text = Convert.ToString(DaysLeft);
                    }
                    else
                    {
                        NetherrackPerDay.Text = "";
                        distancePerDay.Text = "";
                        daysLeft.Text = "";
                    }
                }
                else
                {
                    NetherrackPerDay.Text = "";
                    distancePerDay.Text = "";
                    daysLeft.Text = "";
                }
            }
                catch (Exception)
                {
                }
        }

        private void tbOldNE_TextChanged(object sender, EventArgs e)
        {
                oldCoordsNE = Convert.ToInt32(tbOldNE.Text); // Takes the input and makes it a variable

            try // Couldn't be bothered to check if the input is a number or text, so i just added a try catch
            {
                if (oldCoordsNE > 0 && oldCoordsNE > 0 && oldCoordsN > 0 && player1 > 0 && player2 > 0 && Convert.ToInt32(tbDays.Text) > 0) // Starts the calculating process if all fields has an input
                {
                    oldCoordsNEDistance = 3750000 - oldCoordsNE; // oldCoordsNE is on the NE corner, so it's finding the distance from the wb to oldCoordsNE's position
                    oldtotalDistance = oldCoordsNEDistance + oldCoordsN;
                    if (oldtotalDistance > 0 && oldtotalDistance < 3750000)  // Checks if the distance is valid
                    {
                        // Distance per day
                        x = Convert.ToInt32(tbDays.Text);
                        DistancePerDay = Math.Round((totalDistance - oldtotalDistance) / x);
                        if (DistancePerDay < 0) { DistancePerDay = DistancePerDay * -1; } // I have absolutely no idea why it sometimes returns a negative value
                        distancePerDay.Text = Convert.ToString(DistancePerDay);

                        // Netherrack per Day
                        oldNetherrack = oldtotalDistance * 24;
                        netherrackPerDay = (totalDistance * 24 - oldNetherrack) / Convert.ToDouble(tbDays.Text);
                        if (netherrackPerDay < 0) { netherrackPerDay = netherrackPerDay * -1; }
                        NetherrackPerDay.Text = Convert.ToString(netherrackPerDay);
                        NetherrackPerDay.Text = String.Format("{0:n0}", double.Parse(NetherrackPerDay.Text));

                        // Days left
                        DaysLeft = Math.Round((3750000 - totalDistance) / DistancePerDay, 2);
                        daysLeft.Text = Convert.ToString(DaysLeft);
                    }
                    else
                    {
                        NetherrackPerDay.Text = "";
                        distancePerDay.Text = "";
                        daysLeft.Text = "";
                    }
                }
                else
                {
                    NetherrackPerDay.Text = "";
                    distancePerDay.Text = "";
                    daysLeft.Text = "";
                }
            }
            catch (Exception)
            {
            }
        }

        private void tbDays_TextChanged(object sender, EventArgs e)
        {

            try // Couldn't be bothered to check if the input is a number or text, so i just added a try catch
            {
                if (oldCoordsNE > 0 && oldCoordsNE > 0 && oldCoordsN > 0 && player1 > 0 && player2 > 0 && Convert.ToInt32(tbDays.Text) > 0) // Starts the calculating process if all fields has an input
                {
                    oldCoordsNEDistance = 3750000 - oldCoordsNE; // oldCoordsNE is on the NE corner, so it's finding the distance from the wb to oldCoordsNE's position
                    oldtotalDistance = oldCoordsNEDistance + oldCoordsN;
                    if (oldtotalDistance > 0 && oldtotalDistance < 3750000)  // Checks if the distance is valid
                    {
                        // Distance per day
                        x = Convert.ToInt32(tbDays.Text);
                        DistancePerDay = Math.Round((totalDistance - oldtotalDistance) / x);
                        if (DistancePerDay < 0) { DistancePerDay = DistancePerDay * -1; } // I have absolutely no idea why it sometimes returns a negative value
                        distancePerDay.Text = Convert.ToString(DistancePerDay);

                        // Netherrack per Day
                        oldNetherrack = oldtotalDistance * 24;
                        netherrackPerDay = (totalDistance * 24 - oldNetherrack) / Convert.ToDouble(tbDays.Text);
                            if (netherrackPerDay < 0) { netherrackPerDay = netherrackPerDay * -1; }
                        NetherrackPerDay.Text = Convert.ToString(netherrackPerDay);
                        NetherrackPerDay.Text = String.Format("{0:n0}", double.Parse(NetherrackPerDay.Text));

                        // Days left
                        DaysLeft = Math.Round((3750000 - totalDistance) / DistancePerDay,2);
                        daysLeft.Text = Convert.ToString(DaysLeft);
                    }
                    else
                    {
                        NetherrackPerDay.Text = "";
                        distancePerDay.Text = "";
                        daysLeft.Text = "";
                    }
                }
                else
                {
                    NetherrackPerDay.Text = "";
                    distancePerDay.Text = "";
                    daysLeft.Text = "";
                }
            }
            catch (Exception)
            {
            }
        }
    }
}
