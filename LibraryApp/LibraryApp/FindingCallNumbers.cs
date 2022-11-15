using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.IO;

namespace LibraryApp
{
    public partial class FindingCallNumbers : Form
    {
        #region Variables
        //create a random number 
        Random random = new Random();
        int rand1, rand2, rand3, rand4;

        private string no = null;  //gets the number with the description
        string str = null; //gets the random desription

        string no1;
        int num1, num2, num3, num4;

        public int time = 0;

        private string two = null, three = null, four = null;
        string str2 = null, str3 = null, str4 = null;
        #endregion

        public FindingCallNumbers()
        {
            InitializeComponent();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (time > 0)
            {
                //update time left
                time++;
                txtTimeCounter.Text = time + " seconds";
            }

        }

        private void txtQuestion_Click(object sender, EventArgs e)
        {
            rand1 = random.Next(0, 101);
            //print a random question, only the description from the xml file
            XmlDataDocument xmldoc = new XmlDataDocument();
            XmlNodeList xmlnode;
            int i = 0;

            FileStream fs = new FileStream("C:/Users/austi/source/repos/LibraryApp/XMLFile1.xml", FileMode.Open, FileAccess.Read);
            xmldoc.Load(fs);
            xmlnode = xmldoc.GetElementsByTagName("callNumber");
            for (i = rand1; i <= xmlnode.Count + 1; i++)
            {
                xmlnode[i].ChildNodes.Item(1).InnerText.Trim();
                no = xmlnode[i].ChildNodes.Item(0).InnerText.Trim();
                str = xmlnode[i].ChildNodes.Item(1).InnerText.Trim();

                if (str != null)
                {
                    txtQuestion.Text = "Question: Find the main category for " + str.ToString();
                    timer.Start();
                    txtAnswer1.Enabled = true; txtAnswer2.Enabled = true; txtAnswer3.Enabled = true; txtAnswer4.Enabled = true;
                    btnQ1.Enabled = true; btnQ2.Enabled = true; btnQ3.Enabled = true; btnQ4.Enabled = true;
                    break;
                }
            }           

        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            //go back to library menu form
            Hide();
            Form libraryMenu = new LibraryMenu();
            libraryMenu.FormClosed += (s, args) => Close();
            libraryMenu.ShowDialog();
        }

        private void txtAnswer1_Click(object sender, EventArgs e)
        {
            no1 = "";
            no1 = no.Substring(0, 1); //get the first digit of the number
            num1 = int.Parse(no1);

            Answer1();

            txtAnswer1.Enabled = false;
        }

        private void txtAnswer2_Click(object sender, EventArgs e)
        {
            no1 = "";
            no1 = no.Substring(0, 1); //get the first digit of the number
            num1 = int.Parse(no1);
            RandomNumbers();
            Answer2();

            txtAnswer2.Enabled = false;
        }

        private void txtAnswer3_Click(object sender, EventArgs e)
        {
            no1 = "";
            no1 = no.Substring(0, 1); //get the first digit of the number
            num1 = int.Parse(no1);
            RandomNumbers();
            Answer3();

            txtAnswer3.Enabled = false;
        }

        private void txtAnswer4_Click(object sender, EventArgs e)
        {
            no1 = "";
            no1 = no.Substring(0, 1); //get the first digit of the number
            num1 = int.Parse(no1);
            RandomNumbers();
            Answer4();

            txtAnswer4.Enabled = false;
        }

        #region Answer Buttons

        private void btnQ1_Click(object sender, EventArgs e)
        {
            txtValidation.Text = "Correct!";

            //user finished
            timer.Stop();
            txtTimeCounter.Text = "Your time is: " + time;

            btnQ1.Enabled = false; btnQ2.Enabled = false; btnQ3.Enabled = false; btnQ4.Enabled = false;
        }

        private void btnQ2_Click(object sender, EventArgs e)
        {
            txtValidation.Text = "Incorrect: Answer is " + txtAnswer1.Text;

            //user finished
            timer.Stop();
            txtTimeCounter.Text = "Your time is: " + time;

            btnQ1.Enabled = false; btnQ2.Enabled = false; btnQ3.Enabled = false; btnQ4.Enabled = false;
        }

        private void btnQ3_Click(object sender, EventArgs e)
        {
            txtValidation.Text = "Incorrect: Answer is " + txtAnswer1.Text;

            //user finished
            timer.Stop();
            txtTimeCounter.Text = "Your time is: " + time;

            btnQ1.Enabled = false; btnQ2.Enabled = false; btnQ3.Enabled = false; btnQ4.Enabled = false;
        }

        private void btnQ4_Click(object sender, EventArgs e)
        {
            txtValidation.Text = "Incorrect: Answer is " + txtAnswer1.Text;

            //user finished
            timer.Stop();
            txtTimeCounter.Text = "Your time is: " + time;

            btnQ1.Enabled = false; btnQ2.Enabled = false; btnQ3.Enabled = false; btnQ4.Enabled = false;
        }

        #endregion
        
        private void btnNext_Click(object sender, EventArgs e)
        {
            txtAnswer1.Text = no + " " + str;
            Answer2Next(); Answer3Next(); Answer4Next();


            txtValidation.Text = "";
            btnQ1.Enabled = true; btnQ2.Enabled = true; btnQ3.Enabled = true; btnQ4.Enabled = true;
            btnNext.Enabled = false;
        }

        private void RandomNumbers()
        {
            //random numbers for wrong answers
            if (num1 == 0)
            {
                num2 = random.Next(1, 3);
                num3 = random.Next(3, 6);
                num4 = random.Next(6, 10);
            }
            else if (num1 == 9)
            {
                num2 = random.Next(0, 3);
                num3 = random.Next(3, 5);
                num4 = random.Next(5, 9);
            }
            else
            {
                num2 = num1 - random.Next(0, num1);
                num3 = num1 - random.Next(0, num1);
                num4 = num1 - random.Next(0, num1);
            }
        }

        #region Switch Statements
        private void Answer1()
        {
            //switch statement for answer1
            switch (num1)
            {
                case 0:
                    txtAnswer1.Text = "000 Generalities";
                    break;
                case 1:
                    txtAnswer1.Text = "100 Philosophy & psychology";
                    break;
                case 2:
                    txtAnswer1.Text = "200 Religion";
                    break;
                case 3:
                    txtAnswer1.Text = "300 Social sciences ";
                    break;
                case 4:
                    txtAnswer1.Text = "400 Language";
                    break;
                case 5:
                    txtAnswer1.Text = "500 Natural sciences & mathematics";
                    break;
                case 6:
                    txtAnswer1.Text = "600 Technology (Applied sciences)";
                    break;
                case 7:
                    txtAnswer1.Text = "700 The arts";
                    break;
                case 8:
                    txtAnswer1.Text = "800 Literature & rhetoric";
                    break;
                case 9:
                    txtAnswer1.Text = "900 Geography & history";
                    break;
            }
        }

        private void Answer2()
        {
            //switch statement for answer2
            switch (num2)
            {
                case 0:
                    txtAnswer2.Text = "000 Generalities";
                    break;
                case 1:
                    txtAnswer2.Text = "100 Philosophy & psychology";
                    break;
                case 2:
                    txtAnswer2.Text = "200 Religion";
                    break;
                case 3:
                    txtAnswer2.Text = "300 Social sciences ";
                    break;
                case 4:
                    txtAnswer2.Text = "400 Language";
                    break;
                case 5:
                    txtAnswer2.Text = "500 Natural sciences & mathematics";
                    break;
                case 6:
                    txtAnswer2.Text = "600 Technology (Applied sciences)";
                    break;
                case 7:
                    txtAnswer2.Text = "700 The arts";
                    break;
                case 8:
                    txtAnswer2.Text = "800 Literature & rhetoric";
                    break;
                case 9:
                    txtAnswer2.Text = "900 Geography & history";
                    break;
            }
        }

        private void Answer3()
        {
            //switch statement for answer3
            switch (num3)
            {
                case 0:
                    txtAnswer3.Text = "000 Generalities";
                    break;
                case 1:
                    txtAnswer3.Text = "100 Philosophy & psychology";
                    break;
                case 2:
                    txtAnswer3.Text = "200 Religion";
                    break;
                case 3:
                    txtAnswer3.Text = "300 Social sciences ";
                    break;
                case 4:
                    txtAnswer3.Text = "400 Language";
                    break;
                case 5:
                    txtAnswer3.Text = "500 Natural sciences & mathematics";
                    break;
                case 6:
                    txtAnswer3.Text = "600 Technology (Applied sciences)";
                    break;
                case 7:
                    txtAnswer3.Text = "700 The arts";
                    break;
                case 8:
                    txtAnswer3.Text = "800 Literature & rhetoric";
                    break;
                case 9:
                    txtAnswer3.Text = "900 Geography & history";
                    break;
            }
        }

        private void Answer4()
        {
            //switch statement for answer4
            switch (num4)
            {
                case 0:
                    txtAnswer4.Text = "000 Generalities";
                    break;
                case 1:
                    txtAnswer4.Text = "100 Philosophy & psychology";
                    break;
                case 2:
                    txtAnswer4.Text = "200 Religion";
                    break;
                case 3:
                    txtAnswer4.Text = "300 Social sciences ";
                    break;
                case 4:
                    txtAnswer4.Text = "400 Language";
                    break;
                case 5:
                    txtAnswer4.Text = "500 Natural sciences & mathematics";
                    break;
                case 6:
                    txtAnswer4.Text = "600 Technology (Applied sciences)";
                    break;
                case 7:
                    txtAnswer4.Text = "700 The arts";
                    break;
                case 8:
                    txtAnswer4.Text = "800 Literature & rhetoric";
                    break;
                case 9:
                    txtAnswer4.Text = "900 Geography & history";
                    break;
            }
        }

        #endregion

        #region Next Answers

        private void Answer2Next()
        {
            rand2 = random.Next(0, 101);
            //print a random answer
            XmlDataDocument xmldoc = new XmlDataDocument();
            XmlNodeList xmlnode;
            int i = 0;

            FileStream fs = new FileStream("C:/Users/austi/source/repos/LibraryApp/XMLFile1.xml", FileMode.Open, FileAccess.Read);
            xmldoc.Load(fs);
            xmlnode = xmldoc.GetElementsByTagName("callNumber");
            for (i = rand2; i <= xmlnode.Count + 1; i++)
            {
                xmlnode[i].ChildNodes.Item(1).InnerText.Trim();
                two = xmlnode[i].ChildNodes.Item(0).InnerText.Trim();
                str2 = xmlnode[i].ChildNodes.Item(1).InnerText.Trim();

                if (str2 != null)
                {
                    txtAnswer2.Text = two + " " + str2;
                    break;
                }
            }
        }

        private void Answer3Next()
        {
            rand3 = random.Next(0, 101);
            //print a random answer
            XmlDataDocument xmldoc = new XmlDataDocument();
            XmlNodeList xmlnode;
            int i = 0;

            FileStream fs = new FileStream("C:/Users/austi/source/repos/LibraryApp/XMLFile1.xml", FileMode.Open, FileAccess.Read);
            xmldoc.Load(fs);
            xmlnode = xmldoc.GetElementsByTagName("callNumber");
            for (i = rand3; i <= xmlnode.Count + 1; i++)
            {
                xmlnode[i].ChildNodes.Item(1).InnerText.Trim();
                three = xmlnode[i].ChildNodes.Item(0).InnerText.Trim();
                str3 = xmlnode[i].ChildNodes.Item(1).InnerText.Trim();

                if (str3 != null)
                {
                    txtAnswer3.Text = three + " " + str3;
                    break;
                }
            }
        }

        private void Answer4Next()
        {
            rand4 = random.Next(0, 101);
            //print a random answer
            XmlDataDocument xmldoc = new XmlDataDocument();
            XmlNodeList xmlnode;
            int i = 0;

            FileStream fs = new FileStream("C:/Users/austi/source/repos/LibraryApp/XMLFile1.xml", FileMode.Open, FileAccess.Read);
            xmldoc.Load(fs);
            xmlnode = xmldoc.GetElementsByTagName("callNumber");
            for (i = rand4; i <= xmlnode.Count + 1; i++)
            {
                xmlnode[i].ChildNodes.Item(1).InnerText.Trim();
                four = xmlnode[i].ChildNodes.Item(0).InnerText.Trim();
                str4 = xmlnode[i].ChildNodes.Item(1).InnerText.Trim();

                if (str4 != null)
                {
                    txtAnswer4.Text = four + " " + str4;
                    break;
                }
            }
        }

        #endregion

    }
}
/*Reference List
 * Net-Informations.com. 2021. How to open and read xml file in c#. [Online].
 * Available at: http://csharp.net-informations.com/xml/how-to-read-xml.htm [Accessed 6 December 2021]. */