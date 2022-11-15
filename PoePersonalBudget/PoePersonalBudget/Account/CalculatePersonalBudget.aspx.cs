using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PoePersonalBudget.Account
{
    public partial class CalculatePersonalBudget : System.Web.UI.Page
    {
        //variable declaration
        public static double Income, Tax, Groceries, WaterandLights, Travel, CellphoneandTellphone, Expences, GrossIncome;
        public static double Rental;
        public static double Purchase, Deposit, Interest, Months, totAmount;
        public static string Model;
        public static double vPurchase, vDeposit, vInsurance, vInterest;
        public static string Reason;
        public static double Amount, Time, sInterest;

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                Income = double.Parse(TextBox1.Text);
                Tax = double.Parse(TextBox2.Text);
                Groceries = double.Parse(TextBox3.Text);
                WaterandLights = double.Parse(TextBox4.Text);
                Travel = double.Parse(TextBox5.Text);
                CellphoneandTellphone = double.Parse(TextBox6.Text);
                Expences = double.Parse(TextBox7.Text);

                GrossIncome = Income - (Tax + Groceries + WaterandLights + Travel + CellphoneandTellphone + Expences);
                Label6.Text = $"{GrossIncome}";
                //display the value in a label
            }
            catch (Exception ex)
            {
                Label6.Text = ex.ToString();
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                Purchase = double.Parse(TextBox9.Text);
                Deposit = double.Parse(TextBox10.Text);
                Interest = double.Parse(TextBox11.Text);
                Months = double.Parse(TextBox12.Text);

                totAmount = (Purchase - Deposit + (Interest / 100));
                double monthlyAmount = ((Purchase - Deposit) + (Interest / 100)) / Months;

                string approval;
                if (monthlyAmount > (GrossIncome / 3))
                {
                    approval = "Approval is unlikely.";
                }
                else
                {
                    approval = "Approval is likely.";
                }

                Label5.Text = $"{("Purchase: R" + Purchase + "\n" + "Deposit: R" + Deposit + "\n" + "Interest: " + Interest + "\n" + "Months: " + Months + "\n" + "Monthly Amount: R" + monthlyAmount + "\n" + "Available monthly money after deductions: R" + approval + "\n" + "Data saved successfully")}";
                //display the value in a label
            }
            catch (Exception exep)
            {
                Label5.Text = exep.ToString();
            }
        }
        protected void Button4_Click(object sender, EventArgs e)
        {
            try
            {
                Model = (TextBox13.Text);
                vPurchase = double.Parse(TextBox14.Text);
                vDeposit = double.Parse(TextBox15.Text);
                vInsurance = double.Parse(TextBox16.Text);
                vInterest = double.Parse(TextBox17.Text);

                double fullAmount = ((vPurchase - vDeposit) + (vInterest / 100) + vInsurance);
                double monthlyAmount = ((vPurchase - vDeposit) + (vInterest / 100) + vInsurance) / (5 * 12);

                double availableMonthly = GrossIncome - fullAmount - totAmount;

                Label7.Text = $"{("Model: " + Model + "\n" + "Purchase: R" + vPurchase + "\n" + "Deposit: R" + vDeposit + "\n" + "Interest: " + vInterest + "%" + "\n" + "Insurance: R" + vInsurance + "\n" + "Monthly Amount: R" + monthlyAmount + "\n" + "Available monthly money after deductions: R" + availableMonthly + "\n" + "Data saved successfully")}";
                //display the value in a label
            }
            catch (Exception exep)
            {
                Label7.Text = exep.ToString();
            }
        }
        protected void Button3_Click(object sender, EventArgs e)
        {
            Rental = double.Parse(TextBox8.Text);
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            try
            {
                Amount = double.Parse(TextBox18.Text);
                Time = double.Parse(TextBox19.Text);
                Reason = (TextBox20.Text);
                sInterest = double.Parse(TextBox21.Text);

                double monthlySaving = ((Amount + (sInterest / 100)) / (Time));

                Label9.Text = $"{("Amount: R" + Amount + "\n" + "Time: " + Time + "\n" + "Reason: " + Reason + "\n" + "Interest: " + sInterest + "%" + "\n" + "Monthly Saving: R" + monthlySaving + "\n" + "Data saved successfully")}";
                //display the value in a label
            }
            catch (Exception exeption)
            {
                Label9.Text = exeption.ToString();
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }


    }
}