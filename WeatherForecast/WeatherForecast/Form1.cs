using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeatherForecast
{
    public partial class WeatherForecast : Form
    {
        //declare variables
        //public string City;
        //public string Date, MinTmp, MaxTmp, Pre, Hum, WindSpd;

        public static string City { get; set; }
        public static string Date { get; set; }
        public static string MinTmp { get; set; }
        public static string MaxTmp { get; set; }
        public static string Pre { get; set; }
        public static string Hum { get; set; }
        public static string WindSpd { get; set; }

        ////constructor
        //public WeatherForecast(string city, string date, string mintmp, string maxtmp, string pre, string hum, string windspd)
        //      {
        //	this.City = city;
        //	this.Date = date;
        //	this.MinTmp = mintmp;
        //	this.MaxTmp = maxtmp;
        //	this.Pre = pre;
        //	this.Hum = hum;
        //	this.WindSpd = windspd;
        //      }

        private void txtPre_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void txtHum_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void txtWindSpd_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }

        private void txtMaxTmp_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void txtMinTmp_KeyPress(object sender, KeyPressEventArgs e) //only numbers can be used in textbox
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void WeatherForecast_Load(object sender, EventArgs e)
        {

        }

        public WeatherForecast()
        {
            InitializeComponent();
        }

        public void SaveToFile() //saves input text to an indidual file
        {
            //var path = @"C:\Users\austi\Desktop\City.txt";
            //string[] city = { City };
            //File.WriteAllLines(path, city);
            //File.WriteAllLines(@"C: \Users\austi\Desktop\City.txt", city);
            //System.IO.File.WriteAllText(@"C: \Users\austi\Desktop\Date.txt", Date);
            //System.IO.File.WriteAllText(@"C: \Users\austi\Desktop\MinTmp.txt", MinTmp);
            //System.IO.File.WriteAllText(@"C: \Users\austi\Desktop\MaxTmp.txt", MaxTmp);
            //System.IO.File.WriteAllText(@"C: \Users\austi\Desktop\Pre.txt", Pre);
            //System.IO.File.WriteAllText(@"C: \Users\austi\Desktop\Hum.txt", Hum);
            //System.IO.File.WriteAllText(@"C: \Users\austi\Desktop\WindSpd.txt", WindSpd);

            TextWriter txt = new StreamWriter(@"C:\Users\austi\Desktop\City.txt");
            txt.Write("City: " + City);
            txt.Close();
            txt = new StreamWriter(@"C:\Users\austi\Desktop\Date.txt");
            txt.Write("Date: " + Date);
            txt.Close();
            txt = new StreamWriter(@"C:\Users\austi\Desktop\MinTmp.txt");
            txt.Write("Minimum temperature: " + MinTmp);
            txt.Close();
            txt = new StreamWriter(@"C:\Users\austi\Desktop\MaxTmp.txt");
            txt.Write("Maximuum temperature: " + MaxTmp);
            txt.Close();
            txt = new StreamWriter(@"C:\Users\austi\Desktop\Pre.txt");
            txt.Write("Precipitation: " + Pre);
            txt.Close();
            txt = new StreamWriter(@"C:\Users\austi\Desktop\Hum.txt");
            txt.Write("Humidity: " + Hum);
            txt.Close();
            txt = new StreamWriter(@"C:\Users\austi\Desktop\WindSpd.txt");
            txt.Write("Wind speed: " + WindSpd);
            txt.Close();

            txt = new StreamWriter(@"C:\Users\austi\Desktop\Report.txt");
            txt.Write("Report" + "\n" + "City: " + City + "\n" + "Date: " + Date + "\n" +
                "Minimum Temperature: " + MinTmp + "°C" + "\n" + "Maximum Temperature: " + MaxTmp + "°C" + "\n" +
                "Precipitation: " + Pre + "%" + "\n" + "Humidity: " + Hum + "%" + "\n" +
                "WInd Speed: " + WindSpd + "Km/h");
            txt.Close();
        }

        private void btnRep_Click(object sender, EventArgs e) //report button
        {

            //Forecast frm = new Forecast
            //{
            //    Cities = lstCity.GetItemText(lstCity.SelectedItem),
            //    MinTemp = txtMinTmp.Text,
            //    MaxTemp = txtMaxTmp.Text,
            //    Precipitation = txtPre.Text,
            //    Humidity = txtHum.Text,
            //    WindSpeed = txtWindSpd.Text
            //};

            City = lstCity.GetItemText(lstCity.SelectedItem);
            Date = dateTimePicker1.Text;
            MinTmp = txtMinTmp.Text;
            MaxTmp = txtMaxTmp.Text;
            Pre = txtPre.Text;
            Hum = txtHum.Text;
            WindSpd = txtWindSpd.Text;

            //calls the savetofile method
            SaveToFile();

            //var path = @"C:\Users\austi\Desktop\City.txt";
            //string[] city = { City };
            //File.WriteAllLines(path, city);
            //File.WriteAllText("City.txt", City);

            string Title = "Report";

            //design of message box for report
            MessageBox.Show("City: " + City + "\n" + "Date: " + Date + "\n" +
                "Minimum Temperature: " + MinTmp + "°C" + "\n" + "Maximum Temperature: " + MaxTmp + "°C" + "\n" +
                "Precipitation: " + Pre + "%" + "\n" + "Humidity: " + Hum + "%" + "\n" +
                "WInd Speed: " + WindSpd + "Km/h" + "\n", Title);
        }

        private void login_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.ShowDialog();
        }
    }
}
