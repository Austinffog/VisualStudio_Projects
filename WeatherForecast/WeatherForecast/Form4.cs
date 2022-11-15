using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeatherForecast
{
    public partial class Form4 : Form
    {
        public string name, surname;
        public static bool wf = false;

        public Form4()
        {
            InitializeComponent();
        }

        public void user_details()
        {
            name = txtName.Text;
            surname = txtSurname.Text;
        }

        private void saveWF_Click(object sender, EventArgs e)
        {
            //checks to see if the textboxs are empty
            if (String.IsNullOrEmpty(txtName.Text) || String.IsNullOrEmpty(txtSurname.Text) || String.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Please include your details."); //displays a message if details are not given
            }
            else
            {
                user_details();

                TextWriter txt = new StreamWriter(@"C:\Users\austi\Desktop\WF.txt");
                txt.Write("WeatherForecaster name: " + name + "\n" + "WeatherForecaster surname: " + surname);
                txt.Close();

                wf = true;

                this.Hide();
            }
        }

        private void saveUser_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtName.Text) || String.IsNullOrEmpty(txtSurname.Text) || String.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Please include your details."); 
            }
            else
            {
                user_details();

                TextWriter txt = new StreamWriter(@"C:\Users\austi\Desktop\User.txt");
                txt.Write("User name: " + name + "\n" + "User surname: " + surname);
                txt.Close();

                Form2 f2 = new Form2();
                f2.ShowDialog();
            }
        }

        //if you log in as a weather forecaster then switch to a user within the same online environment it will
        //still have you as a weather forecaster. Exit the application then log in as a new user to experience a user environment

        private void showPass_CheckedChanged(object sender, EventArgs e)
        {
            if (showPass.Checked)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }
    }
}
