using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryApp
{
    public partial class IdentifyingAreas : Form
    {
        #region Variable Declarations
        //declare label clicks
        Label firstClicked = null;
        Label secondClicked = null;

        //declare dictionary variables
        //question 1
        IDictionary<int, string> callNumbers1 = new Dictionary<int, string>();
        IDictionary<string, string> descriptions1 = new Dictionary<string, string>();
        //question2
        IDictionary<string, string> callNumbers2 = new Dictionary<string, string>();
        IDictionary<int, string> descriptions2 = new Dictionary<int, string>();
        //question 3
        IDictionary<int, string> callNumbers3 = new Dictionary<int, string>();
        IDictionary<string, string> descriptions3 = new Dictionary<string, string>();

        //create a random number 
        Random random = new Random();
        int num;

        int timeLeft = 30;
        #endregion

        public IdentifyingAreas()
        {
            InitializeComponent();
        }

        #region Storing into Dictionaries
        public void StoreCallNumbers()
        {
            //store the call numbers and their position in a dictionary question 1
            callNumbers1.Add(int.Parse(cn1.Text), cn01.Text.ToString());
            callNumbers1.Add(int.Parse(cn2.Text), cn02.Text.ToString());
            callNumbers1.Add(int.Parse(cn3.Text), cn03.Text.ToString());
            callNumbers1.Add(int.Parse(cn4.Text), cn04.Text.ToString());

            //store the call numbers and their position in a dictionary question 2
            callNumbers2.Add(cn_a.Text.ToString(), cnA.Text.ToString());
            callNumbers2.Add(cn_b.Text.ToString(), cnB.Text.ToString());
            callNumbers2.Add(cn_c.Text.ToString(), cnC.Text.ToString());
            callNumbers2.Add(cn_d.Text.ToString(), cnD.Text.ToString());
            callNumbers2.Add(cn_e.Text.ToString(), cnE.Text.ToString());
            callNumbers2.Add(cn_f.Text.ToString(), cnF.Text.ToString());
            callNumbers2.Add(cn_g.Text.ToString(), cnG.Text.ToString());

            //store the call numbers and their position in a dictionary question 3
            callNumbers3.Add(int.Parse(cn1_3.Text), cnum1.Text.ToString());
            callNumbers3.Add(int.Parse(cn2_3.Text), cnum2.Text.ToString());
            callNumbers3.Add(int.Parse(cn3_3.Text), cnum3.Text.ToString());
            callNumbers3.Add(int.Parse(cn4_3.Text), cnum4.Text.ToString());
        }

        public void StoreDescriptions()
        {
            //store the descriptions and their position in a dictionary question 1
            descriptions1.Add(desc_a.Text.ToString(), descA.Text.ToString());
            descriptions1.Add(desc_b.Text.ToString(), descB.Text.ToString());
            descriptions1.Add(desc_c.Text.ToString(), descC.Text.ToString());
            descriptions1.Add(desc_d.Text.ToString(), descD.Text.ToString());
            descriptions1.Add(desc_e.Text.ToString(), descE.Text.ToString());
            descriptions1.Add(desc_f.Text.ToString(), descF.Text.ToString());
            descriptions1.Add(desc_g.Text.ToString(), descG.Text.ToString());

            //store the descriptions and their position in a dictionary question 2
            descriptions2.Add(int.Parse(desc_1.Text), desc1.Text.ToString());
            descriptions2.Add(int.Parse(desc_2.Text), desc2.Text.ToString());
            descriptions2.Add(int.Parse(desc_3.Text), desc3.Text.ToString());
            descriptions2.Add(int.Parse(desc_4.Text), desc4.Text.ToString());

            //store the descriptions and their position in a dictionary question 3
            descriptions3.Add(desc3_a.Text.ToString(), desc3A.Text.ToString());
            descriptions3.Add(desc3_b.Text.ToString(), desc3B.Text.ToString());
            descriptions3.Add(desc3_c.Text.ToString(), desc3C.Text.ToString());
            descriptions3.Add(desc3_d.Text.ToString(), desc3D.Text.ToString());
            descriptions3.Add(desc3_e.Text.ToString(), desc3E.Text.ToString());
            descriptions3.Add(desc3_f.Text.ToString(), desc3F.Text.ToString());
            descriptions3.Add(desc3_g.Text.ToString(), desc3G.Text.ToString());
        }

        /* Answers Question 1
         * 1 = F callNumbers1[1] = descriptions1["F"]
         * 2 = A callNumbers1[2] = descriptions1["A"]
         * 3 = E callNumbers1[3] = descriptions1["E"]
         * 4 = D callNumbers1[4] = descriptions1["D"]
         * Answers Question 2
         * 1 = D descriptions2[1] = callNumbers2["D"]
         * 2 = E descriptions2[2] = callNumbers2["E"]
         * 3 = A descriptions2[3] = callNumbers2["A"]
         * 4 = G descriptions2[4] = callNumbers2["G"]
         * Answers Question 3
         * 1 = E callNumbers3[1] = descriptions3["E"]
         * 2 = F callNumbers3[2] = descriptions3["F"]
         * 3 = D callNumbers3[3] = descriptions3["D"]
         * 4 = B callNumbers3[4] = descriptions3["B"]
         */


        #endregion

        private void label_Click(object sender, EventArgs e)
        {
            Label clickedLabel = sender as Label;

            if (clickedLabel != null)
            {
                if (clickedLabel.ForeColor == Color.AliceBlue) //the option has already been clicked
                    return;

                if (firstClicked == null) //check if the label is clicked
                {
                    firstClicked = clickedLabel;
                    clickedLabel.ForeColor = Color.AliceBlue; //change the labels colour
                    return;
                }

                secondClicked = clickedLabel;
                secondClicked.ForeColor = Color.AliceBlue;

                //check if the user has selected the correct matching columns
                if (firstClicked.Text.Equals(callNumbers1[1]) && secondClicked.Text.Equals(descriptions1["F"]))
                {
                    ans1.Text = "Correct";
                }
                else
                {
                    ans1.Text = "Incorrect";
                }

                if (firstClicked.Text.Equals(callNumbers1[2]) && secondClicked.Text.Equals(descriptions1["A"]))
                {
                    ans2.Text = "Correct";
                }
                else
                {
                    ans2.Text = "Incorrect";
                }

                if (firstClicked.Text.Equals(callNumbers1[3]) && secondClicked.Text.Equals(descriptions1["E"]))
                {
                    ans3.Text = "Correct";
                }
                else
                {
                    ans3.Text = "Incorrect";
                }

                if (firstClicked.Text.Equals(callNumbers1[4]) && secondClicked.Text.Equals(descriptions1["D"]))
                {
                    ans4.Text = "Correct";
                }
                else
                {
                    ans4.Text = "Incorrect";
                }

                if (firstClicked.Text.Equals(descriptions2[1]) && secondClicked.Text.Equals(callNumbers2["D"]))
                {
                    ans1_2.Text = "Correct";
                }
                else
                {
                    ans1_2.Text = "Incorrect";
                }

                if (firstClicked.Text.Equals(descriptions2[2]) && secondClicked.Text.Equals(callNumbers2["E"]))
                {
                    ans2_2.Text = "Correct";
                }
                else
                {
                    ans2_2.Text = "Incorrect";
                }

                if (firstClicked.Text.Equals(descriptions2[3]) && secondClicked.Text.Equals(callNumbers2["A"]))
                {
                    ans3_2.Text = "Correct";
                }
                else
                {
                    ans3_2.Text = "Incorrect";
                }

                if (firstClicked.Text.Equals(descriptions2[4]) && secondClicked.Text.Equals(callNumbers2["G"]))
                {
                    ans4_2.Text = "Correct";
                }
                else
                {
                    ans4_2.Text = "Incorrect";
                }

                if (firstClicked.Text.Equals(callNumbers3[1]) && secondClicked.Text.Equals(descriptions3["E"]))
                {
                    ans1_3.Text = "Correct";
                }
                else
                {
                    ans1_3.Text = "Incorrect";
                }

                if (firstClicked.Text.Equals(callNumbers3[2]) && secondClicked.Text.Equals(descriptions3["F"]))
                {
                    ans2_3.Text = "Correct";
                }
                else
                {
                    ans2_3.Text = "Incorrect";
                }

                if (firstClicked.Text.Equals(callNumbers3[3]) && secondClicked.Text.Equals(descriptions3["D"]))
                {
                    ans3_3.Text = "Correct";
                }
                else
                {
                    ans3_3.Text = "Incorrect";
                }

                if (firstClicked.Text.Equals(callNumbers3[4]) && secondClicked.Text.Equals(descriptions3["B"]))
                {
                    ans4_3.Text = "Correct";
                }
                else
                {
                    ans4_3.Text = "Incorrect";
                }

                firstClicked = null;
                secondClicked = null;
            }
        }

        private void BtnBegin_Click(object sender, EventArgs e)
        {
            StoreCallNumbers();
            StoreDescriptions();

            timer.Start();

            //disable begin button as values have already been stored
            BtnBegin.Enabled = false;

            //select a random number to load a random question
            num = random.Next(1, 4);

            if (num == 1) //load question 1
            {
                VisableTrueQ1();
            }

            if (num == 2) //load question 2
            {
                VisableTrueQ2();
            }

            if (num == 3) //load question 3
            {
                VisableTrueQ3();
            }
        }

        private void BtnDone_Click(object sender, EventArgs e)
        {
            timer.Stop();

            VisableFalseQ1();
            VisableFalseQ2();
            VisableFalseQ3();

            Hide();
            Form identifyingAreas = new IdentifyingAreas();
            identifyingAreas.FormClosed += (s, args) => Close();
            identifyingAreas.ShowDialog();

            firstClicked = null;
            secondClicked = null;
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            //go back to library menu form
            Hide();
            Form libraryMenu = new LibraryMenu();
            libraryMenu.FormClosed += (s, args) => Close();
            libraryMenu.ShowDialog();
        }

        #region Visibilty
        private void VisableTrueQ1()
        {
            label4.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            tableCallNumbers.Visible = true;
            tableDescriptions.Visible = true;
            ans1.Visible = true;
            ans2.Visible = true;
            ans3.Visible = true;
            ans4.Visible = true;
        }

        private void VisableFalseQ1()
        {
            label4.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            tableCallNumbers.Visible = false;
            tableDescriptions.Visible = false;
            ans1.Visible = false;
            ans2.Visible = false;
            ans3.Visible = false;
            ans4.Visible = false;
        }

        private void VisableTrueQ2()
        {
            label6.Visible = true;
            label7.Visible = true;
            label8.Visible = true;
            tableDescriptions2.Visible = true;
            tableCallNumbers2.Visible = true;
            ans1_2.Visible = true;
            ans2_2.Visible = true;
            ans3_2.Visible = true;
            ans4_2.Visible = true;
        }

        private void VisableFalseQ2()
        {
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            tableDescriptions2.Visible = false;
            tableCallNumbers2.Visible = false;
            ans1_2.Visible = false;
            ans2_2.Visible = false;
            ans3_2.Visible = false;
            ans4_2.Visible = false;
        }

        private void VisableTrueQ3()
        {
            label9.Visible = true;
            label10.Visible = true;
            label11.Visible = true;
            tableDescriptions3.Visible = true;
            tableCallNumbers3.Visible = true;
            ans1_3.Visible = true;
            ans2_3.Visible = true;
            ans3_3.Visible = true;
            ans4_3.Visible = true;
        }

        private void VisableFalseQ3()
        {
            label9.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
            tableDescriptions3.Visible = false;
            tableCallNumbers3.Visible = false;
            ans1_3.Visible = false;
            ans2_3.Visible = false;
            ans3_3.Visible = false;
            ans4_3.Visible = false;
        }
        #endregion

        private void timer_Tick(object sender, EventArgs e)
        {
            if (timeLeft > 0)
            {
                //update time left
                timeLeft--;
                txtTimeCounter.Text = timeLeft + " seconds";
            }
            else
            {
                //user ran out of time
                timer.Stop();
                txtTimeCounter.Text = "Time Ended!";

                //disable tables when time runs out

                //Question 1
                tableCallNumbers.Enabled = false;
                tableDescriptions.Enabled = false;

                //Question 2
                tableCallNumbers2.Enabled = false;
                tableDescriptions2.Enabled = false;

                //Question 3
                tableCallNumbers3.Enabled = false;
                tableDescriptions3.Enabled = false;
            }
        }


    }
}

/* Reference List
 * IllinoisLibrary. 2020. Dewey decimal system - A guide to call numbers. [Online]. 
 * Available at: https://www.library.illinois.edu/infosci/research/guides/dewey/ [Accessed 10 November].
 * 
 * TutorialsTeacher. 2020. C# - Dictionary<TKey,TValue>. [Online]. 
 * Available at: https://www.tutorialsteacher.com/csharp/csharp-dictionary [Accessed 10 November].
 * 
 * MicrosoftDocs. 2021. Tutorial 3: Create a matching game. [Online]. 
 * Available at: https://docs.microsoft.com/en-us/visualstudio/ide/tutorial-3-create-a-matching-game?view=vs-2022 [Accessed 10 November].
 * 
 */
