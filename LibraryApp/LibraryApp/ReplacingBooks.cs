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
    public partial class ReplacingBooks : Form
    {
        #region Variable declarations
        //numbers 
        public int btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8, btn9, btn10;

        public int min = 0, max = 999;

        //list to store numbers
        public List<int> numbers = new List<int>();

        public int order = 1;

        //list for users ordering
        public List<int> userOrder = new List<int>();

        public int orderIndex1, orderIndex2, orderIndex3, orderIndex4, orderIndex5, orderIndex6, orderIndex7, orderIndex8,
            orderIndex9, orderIndex10; 

        public int timeLeft = 20;
        #endregion
        
        private void BtnBack_Click(object sender, EventArgs e)
        {
            //go back to library menu form
            Hide();
            Form libraryMenu = new LibraryMenu();
            libraryMenu.FormClosed += (s, args) => Close();
            libraryMenu.ShowDialog();
        }

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

                //disable all call buttons 
                Button1.Enabled = false;
                Button2.Enabled = false;
                Button3.Enabled = false;
                Button4.Enabled = false;
                Button5.Enabled = false;
                Button6.Enabled = false;
                Button7.Enabled = false;
                Button8.Enabled = false;
                Button9.Enabled = false;
                Button10.Enabled = false;
            }
        }

        public ReplacingBooks()
        {
            InitializeComponent();

        }

        private void BtnBegin_Click(object sender, EventArgs e)
        {
            timer.Start();

            //disable button after clicking so new numbers arent generated
            BtnBegin.Enabled = false;

            //generate random numbers for each
            Random rnd = new Random();
            btn1 = rnd.Next(min, max);
            btn2 = rnd.Next(min, max);
            btn3 = rnd.Next(min, max);
            btn4 = rnd.Next(min, max);
            btn5 = rnd.Next(min, max);
            btn6 = rnd.Next(min, max);
            btn7 = rnd.Next(min, max);
            btn8 = rnd.Next(min, max);
            btn9 = rnd.Next(min, max);
            btn10 = rnd.Next(min, max);

            //add the numbers to the list
            numbers.Add(btn1);
            numbers.Add(btn2);
            numbers.Add(btn3);
            numbers.Add(btn4);
            numbers.Add(btn5);
            numbers.Add(btn6);
            numbers.Add(btn7);
            numbers.Add(btn8);
            numbers.Add(btn9);
            numbers.Add(btn10);

            //assign values to each
            string format = "000";
            Button1.Text = btn1.ToString(format);
            Button2.Text = btn2.ToString(format);
            Button3.Text = btn3.ToString(format);
            Button4.Text = btn4.ToString(format);
            Button5.Text = btn5.ToString(format);
            Button6.Text = btn6.ToString(format);
            Button7.Text = btn7.ToString(format);
            Button8.Text = btn8.ToString(format);
            Button9.Text = btn9.ToString(format);
            Button10.Text = btn10.ToString(format);

            //enable buttons
            Button1.Enabled = true;
            Button2.Enabled = true;
            Button3.Enabled = true;
            Button4.Enabled = true;
            Button5.Enabled = true;
            Button6.Enabled = true;
            Button7.Enabled = true;
            Button8.Enabled = true;
            Button9.Enabled = true;
            Button10.Enabled = true;
        }

        private void BtnDone_Click(object sender, EventArgs e)
        {
            timer.Stop();

            BtnDone.Enabled = false;

            //set the index value in the list to redorder by
            orderIndex1 = Convert.ToInt32(orderNumber1.Text);
            orderIndex2 = Convert.ToInt32(orderNumber2.Text);
            orderIndex3 = Convert.ToInt32(orderNumber3.Text);
            orderIndex4 = Convert.ToInt32(orderNumber4.Text);
            orderIndex5 = Convert.ToInt32(orderNumber5.Text);
            orderIndex6 = Convert.ToInt32(orderNumber6.Text);
            orderIndex7 = Convert.ToInt32(orderNumber7.Text);
            orderIndex8 = Convert.ToInt32(orderNumber8.Text);
            orderIndex9 = Convert.ToInt32(orderNumber9.Text);
            orderIndex10 = Convert.ToInt32(orderNumber10.Text);

            //add the values to the list
            userOrder.Add(orderIndex1);
            userOrder.Add(orderIndex2);
            userOrder.Add(orderIndex3);
            userOrder.Add(orderIndex4);
            userOrder.Add(orderIndex5);
            userOrder.Add(orderIndex6);
            userOrder.Add(orderIndex7);
            userOrder.Add(orderIndex8);
            userOrder.Add(orderIndex9);
            userOrder.Add(orderIndex10);

            //insert the values into the users order
             for (int i = 0; i < numbers.Count; i++)
            {
                for (int j = 0; j < userOrder.Count; j++)
                {
                    if (userOrder[i] > userOrder[j])
                    {
                        int no = userOrder[i];
                        userOrder[i] = userOrder[j];
                        userOrder[j] = no;

                        int x = numbers[i];
                        numbers[i] = numbers[j];
                        numbers[j] = x;
                    }
                }
            }
            numbers.Reverse();
            userOrder = numbers.ToList();

            txtUserOrder.Text = string.Join("\n ", userOrder);

            //insertion sort algorithm in ascending order
            for (int i = 0; i < numbers.Count(); i++)
            {
                var num = numbers[i];
                var index = i;

                while (index > 0 && numbers[index - 1] > num)
                {
                    numbers[index] = numbers[index - 1];
                    index--;
                }

                numbers[index] = num;
            }

            //display correct call number order
            txtCorrect.Text = string.Join("\n ", numbers);

            //compare user ordering and correct
            if (userOrder.SequenceEqual(numbers))
            {
                txtAnswer.Text = "Correct!";
                txtAnswer.ForeColor = Color.Green; 
            }
            else
            {
                txtAnswer.Text = "Wrong!";
                txtAnswer.ForeColor = Color.Red;
            }
        }

        #region Call number Buttons

        private void Button1_Click(object sender, EventArgs e)
        {
            orderNumber1.Text = order.ToString();
            order++;

            Button1.Enabled = false;
            Button1.BackColor = Color.Purple;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            orderNumber2.Text = order.ToString();
            order++;

            Button2.Enabled = false;
            Button2.BackColor = Color.Purple;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            orderNumber3.Text = order.ToString();
            order++;

            Button3.Enabled = false;
            Button3.BackColor = Color.Purple;
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            orderNumber4.Text = order.ToString();
            order++;

            Button4.Enabled = false;
            Button4.BackColor = Color.Purple;
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            orderNumber5.Text = order.ToString();
            order++;

            Button5.Enabled = false;
            Button5.BackColor = Color.Purple;
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            orderNumber6.Text = order.ToString();
            order++;

            Button6.Enabled = false;
            Button6.BackColor = Color.Purple;
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            orderNumber7.Text = order.ToString();
            order++;

            Button7.Enabled = false;
            Button7.BackColor = Color.Purple;
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            orderNumber8.Text = order.ToString();
            order++;

            Button8.Enabled = false;
            Button8.BackColor = Color.Purple;
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            orderNumber9.Text = order.ToString();
            order++;

            Button9.Enabled = false;
            Button9.BackColor = Color.Purple;
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            orderNumber10.Text = order.ToString();
            order++;

            Button10.Enabled = false;
            Button10.BackColor = Color.Purple;
        }
        #endregion

    }
}

/*Reference List
 * 
 * DocsMicrosoft. 2021. Step 3: Add a countdown timer, 11 April 2016. [Online]. 
 * Available at: https://docs.microsoft.com/en-us/visualstudio/ide/step-3-add-a-countdown-timer?view=vs-2019 [Accessed 30 September 2021].
 * 
 * DotNetPerls. 2021. C# List Examples. [Online]. 
 * Available at: https://www.dotnetperls.com/list [Accessed 30 September 2021].  
 * 
 * Karlsen, V, L. 2021. HOw do i copy items from list to list without foreach?, 23 July 2021. [Online].
 * Available at: https://stackoverflow.com/questions/1952185/how-do-i-copy-items-from-list-to-list-without-foreach [Accessed 30 September 2021].
 * 
 * Nihique. 2021. C# open a new form then close the current form?, StackOverflow, 19 November 2021. [Online]. 
 * Available at: https://stackoverflow.com/questions/5548746/c-sharp-open-a-new-form-then-close-the-current-form [Accessed 30 September 2021].
 * 
 * TechieDelight. 2021. Reverse a list in c#. [Online].
 * Available at: https://www.techiedelight.com/reverse-a-list-csharp/#:~:text=To%20reverse%20the%20Order%20of,uses%20an%20in%2Dplace%20algorithm. [Accessed 30 September 2021].
 * 
 * Toshniwal, R. 2021. Sorting list based on values from another list, 22 July 2021. [Online].
 * Available at: https://stackoverflow.com/questions/6618515/sorting-list-based-on-values-from-another-list [Accessed 30 September 2021].
 * 
 * Wade. 2021. Basic Sorting Algorithms in C# .Net, DotNetCoreTutorials, 10 May 2020. [Online]. 
 * Available at: https://dotnetcoretutorials.com/2020/05/10/basic-sorting-algorithms-in-c/  [Accessed 30 September 2021].
 */
