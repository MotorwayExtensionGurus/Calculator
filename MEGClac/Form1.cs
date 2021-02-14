using System;
using System.Globalization;
using System.Windows.Forms;

namespace MEGCalc
{
    public partial class Form1 : Form
    {
        private double DaysLeft;
        private double DistancePerDay;
        private bool EtaCalc = true;
        private double NetherrackMinedPerDay;
        private int OldCoordsN;
        private int OldCoordsNe;
        private int OldCoordsNeDistance;
        private double OldNetherrack;
        private double OldTotalDistance;
        private int Player1;
        private int Player2;
        private int Player2Distance;
        private double PercentDone;
        private double TotalDistance;
        private int X;

        public Form1()
        {
            InitializeComponent();
            Procent.Text = Convert.ToString(PercentDone, CultureInfo.InvariantCulture) + @"%";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try // Couldn't be bothered to check if the input is a number or text, so i just added a try catch
            {
                Player1 = Convert.ToInt32(tbPlayer1.Text); // Takes the input and makes it a variable
                if (Player2 != 0 && Player2 > 0 && Player1 > 0) // Starts the calculating process if both fields has an input
                {
                    Player2Distance = 3750000 - Player2; // player2 is on the NE corner, so it's finding the distance from the wb to player2's position
                    TotalDistance = Player2Distance + Player1;
                    if (TotalDistance > 0 && TotalDistance < 3750000) // Checks if the distance is valid
                    {
                        Distance.Text = Convert.ToString(TotalDistance, CultureInfo.InvariantCulture);
                        Netherrack.Text = Convert.ToString(TotalDistance * 24, CultureInfo.InvariantCulture);
                        PercentDone = TotalDistance / 3750000 * 100; // I had some trouble calculating percent in the field below, so i just split it in 2.
                        Procent.Text = Convert.ToString(Math.Round(PercentDone, 2), CultureInfo.InvariantCulture) + @"%";
                        Procent.Text = $@"{double.Parse(Procent.Text):#,##0.00}";
                        Netherrack.Text =
                            $@"{double.Parse(Netherrack.Text):n0}"; //I tried to split up the 1000's like 1,000,000 instead of 1000000 but
                        Distance.Text = $@"{double.Parse(Distance.Text):n0}"; // i just couldn't get it to work for the life of me. It still outputs the number here though
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
            } catch (Exception)
            {
                // ignored
            }
        }

        private void tbPlayer2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Player2 = Convert.ToInt32(tbPlayer2.Text);
                if (Player2 != 0 && Player2 > 0 && Player1 > 0)
                {
                    Player2Distance = 3750000 - Player2; // Basically the same as player1.
                    TotalDistance = Player2Distance + Player1; // I duplicated the code to player2 as well so no matter what order 
                    if (TotalDistance > 0 && TotalDistance < 3750000) // you typed the coords in, it'd calculate it.
                    {
                        Distance.Text = Convert.ToString(TotalDistance, CultureInfo.InvariantCulture);
                        Netherrack.Text = Convert.ToString(TotalDistance * 24, CultureInfo.InvariantCulture);
                        PercentDone = TotalDistance / 3750000 * 100;
                        Procent.Text = Convert.ToString(Math.Round(PercentDone, 2), CultureInfo.InvariantCulture) + @"%";
                        Netherrack.Text = $@"{double.Parse(Netherrack.Text):n0}";
                        Distance.Text = $@"{double.Parse(Distance.Text):n0}";
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
            } catch (Exception)
            {
                // ignored
            }
        }

        private void button1_Click(object sender, EventArgs e) // This is for the copy paste field. The text box's name tbPasta refers to Copy Pasta
        {
            tbPasta.Text = "";
            tbPasta.Text = @"Leg 1 current progress: **" + Convert.ToString(Math.Round(PercentDone, 2), CultureInfo.InvariantCulture) + @"% done**";
            if (EtaCalc)
            {
                tbPasta.Text += @"\r\n";
                tbPasta.Text = tbPasta.Text + @"ETA: **" + daysLeft.Text + @" days**";
            }
            tbPasta.Text += @"\r\n";
            tbPasta.Text += @"\r\n";
            tbPasta.Text = tbPasta.Text + @"Total distance dug: " + Distance.Text + @"/3750000";
            tbPasta.Text += @"\r\n";
            tbPasta.Text = tbPasta.Text + @"Netherrack dug: " + Netherrack.Text + @"/90000000";
            if (EtaCalc)
            {
                tbPasta.Text += @"\r\n";
                tbPasta.Text = tbPasta.Text + @"Distance per day currently: " + distancePerDay.Text;
                tbPasta.Text += @"\r\n";
                tbPasta.Text = tbPasta.Text + @"Netherrack per day currently: " + NetherrackPerDay.Text;
            }
            tbPasta.Text += @"\r\n";
            tbPasta.Text += @"\r\n";
            tbPasta.Text = tbPasta.Text + @"Digger 1 position: " + tbPlayer1.Text + @", -3750000";
            tbPasta.Text += @"\r\n";
            tbPasta.Text = tbPasta.Text + @"Digger 2 position: " + tbPlayer2.Text + @", -3750000"; // It could probably be more efficient, but idgaf it works
        }

        private void Netherrack_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (EtaCalc)
            {
                EtaCalc = false;
                tbOldN.Enabled = false;
                tbOldNE.Enabled = false;
                tbDays.Enabled = false;
                button2.Text = @"Activate";
            }
            else
            {
                EtaCalc = true;
                tbOldN.Enabled = true;
                tbOldNE.Enabled = true;
                tbDays.Enabled = true;
                button2.Text = @"Deactivate";
            }
        }

        private void tbOldN_TextChanged(object sender, EventArgs e)
        {
            OldCoordsN = Convert.ToInt32(tbOldN.Text); // Takes the input and makes it a variable

            try // Couldn't be bothered to check if the input is a number or text, so i just added a try catch
            {
                if (OldCoordsNe > 0 && OldCoordsNe > 0 && OldCoordsN > 0 && Player1 > 0 && Player2 > 0 && Convert.ToInt32(tbDays.Text) > 0
                ) // Starts the calculating process if all fields has an input
                {
                    OldCoordsNeDistance =
                        3750000 - OldCoordsNe; // oldCoordsNE is on the NE corner, so it's finding the distance from the wb to oldCoordsNE's position
                    OldTotalDistance = OldCoordsNeDistance + OldCoordsN;
                    if (OldTotalDistance > 0 && OldTotalDistance < 3750000) // Checks if the distance is valid
                    {
                        // Distance per day
                        X = Convert.ToInt32(tbDays.Text);
                        DistancePerDay = Math.Round((TotalDistance - OldTotalDistance) / X);
                        if (DistancePerDay < 0)
                            DistancePerDay *= -1;
                        distancePerDay.Text = Convert.ToString(DistancePerDay, CultureInfo.InvariantCulture);

                        // Netherrack per Day
                        OldNetherrack = OldTotalDistance * 24;
                        NetherrackMinedPerDay = (TotalDistance * 24 - OldNetherrack) / Convert.ToDouble(tbDays.Text);
                        if (NetherrackMinedPerDay < 0)
                            NetherrackMinedPerDay *= -1;
                        NetherrackPerDay.Text = Convert.ToString(NetherrackMinedPerDay, CultureInfo.InvariantCulture);
                        NetherrackPerDay.Text = $@"{double.Parse(NetherrackPerDay.Text):n0}";

                        // Days left
                        DaysLeft = Math.Round((3750000 - TotalDistance) / DistancePerDay, 2);
                        daysLeft.Text = Convert.ToString(DaysLeft, CultureInfo.InvariantCulture);
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
            } catch (Exception)
            {
                // ignored
            }
        }

        private void tbOldNE_TextChanged(object sender, EventArgs e)
        {
            OldCoordsNe = Convert.ToInt32(tbOldNE.Text); // Takes the input and makes it a variable

            try // Couldn't be bothered to check if the input is a number or text, so i just added a try catch
            {
                if (OldCoordsNe > 0 && OldCoordsNe > 0 && OldCoordsN > 0 && Player1 > 0 && Player2 > 0 && Convert.ToInt32(tbDays.Text) > 0
                ) // Starts the calculating process if all fields has an input
                {
                    OldCoordsNeDistance =
                        3750000 - OldCoordsNe; // oldCoordsNE is on the NE corner, so it's finding the distance from the wb to oldCoordsNE's position
                    OldTotalDistance = OldCoordsNeDistance + OldCoordsN;
                    if (OldTotalDistance > 0 && OldTotalDistance < 3750000) // Checks if the distance is valid
                    {
                        // Distance per day
                        X = Convert.ToInt32(tbDays.Text);
                        DistancePerDay = Math.Round((TotalDistance - OldTotalDistance) / X);
                        if (DistancePerDay < 0)
                            DistancePerDay *= -1;
                        distancePerDay.Text = Convert.ToString(DistancePerDay, CultureInfo.InvariantCulture);

                        // Netherrack per Day
                        OldNetherrack = OldTotalDistance * 24;
                        NetherrackMinedPerDay = (TotalDistance * 24 - OldNetherrack) / Convert.ToDouble(tbDays.Text);
                        if (NetherrackMinedPerDay < 0)
                            NetherrackMinedPerDay *= -1;
                        NetherrackPerDay.Text = Convert.ToString(NetherrackMinedPerDay, CultureInfo.InvariantCulture);
                        NetherrackPerDay.Text = $@"{double.Parse(NetherrackPerDay.Text):n0}";

                        // Days left
                        DaysLeft = Math.Round((3750000 - TotalDistance) / DistancePerDay, 2);
                        daysLeft.Text = Convert.ToString(DaysLeft, CultureInfo.InvariantCulture);
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
            } catch (Exception)
            {
                // ignored
            }
        }

        private void tbDays_TextChanged(object sender, EventArgs e)
        {
            try // Couldn't be bothered to check if the input is a number or text, so i just added a try catch
            {
                if (OldCoordsNe > 0 && OldCoordsNe > 0 && OldCoordsN > 0 && Player1 > 0 && Player2 > 0 && Convert.ToInt32(tbDays.Text) > 0
                ) // Starts the calculating process if all fields has an input
                {
                    OldCoordsNeDistance =
                        3750000 - OldCoordsNe; // oldCoordsNE is on the NE corner, so it's finding the distance from the wb to oldCoordsNE's position
                    OldTotalDistance = OldCoordsNeDistance + OldCoordsN;
                    if (OldTotalDistance > 0 && OldTotalDistance < 3750000) // Checks if the distance is valid
                    {
                        // Distance per day
                        X = Convert.ToInt32(tbDays.Text);
                        DistancePerDay = Math.Round((TotalDistance - OldTotalDistance) / X);
                        if (DistancePerDay < 0)
                            DistancePerDay *= -1;
                        distancePerDay.Text = Convert.ToString(DistancePerDay, CultureInfo.InvariantCulture);

                        // Netherrack per Day
                        OldNetherrack = OldTotalDistance * 24;
                        NetherrackMinedPerDay = (TotalDistance * 24 - OldNetherrack) / Convert.ToDouble(tbDays.Text);
                        if (NetherrackMinedPerDay < 0)
                            NetherrackMinedPerDay *= -1;
                        NetherrackPerDay.Text = Convert.ToString(NetherrackMinedPerDay, CultureInfo.InvariantCulture);
                        NetherrackPerDay.Text = $@"{double.Parse(NetherrackPerDay.Text):n0}";

                        // Days left
                        DaysLeft = Math.Round((3750000 - TotalDistance) / DistancePerDay, 2);
                        daysLeft.Text = Convert.ToString(DaysLeft, CultureInfo.InvariantCulture);
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
            } catch (Exception)
            {
                // ignored
            }
        }
    }
}