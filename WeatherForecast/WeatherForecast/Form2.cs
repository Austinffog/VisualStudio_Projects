using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeatherForecast
{
    public partial class Form2 : Form
    {
        //declare variables
        public string City = WeatherForecast.City;
        public string StartDate, EndDate;
        public string Date = WeatherForecast.Date;
        public string MinTmp = WeatherForecast.MinTmp;
        public string MaxTmp = WeatherForecast.MaxTmp;
        public string Pre = WeatherForecast.Pre;
        public string Hum = WeatherForecast.Hum;
        public string WindSpd = WeatherForecast.WindSpd;

        private void btnMore_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.ShowDialog();
        }

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (Form4.wf == true)
            {
                this.Hide();
            }
            else
            {
                MessageBox.Show("Your are not a Weather Forecaster!");
            }
        }

        public void SaveToFile()
        {
            TextWriter txt = new StreamWriter(@"C:\Users\austi\Desktop\Report.txt");
            txt.Write("Report" + "\n" + "City: " + City + "\n" + "Date: " + Date + "\n" +
                "Minimum Temperature: " + MinTmp + "°C" + "\n" + "Maximum Temperature: " + MaxTmp + "°C" + "\n" +
                "Precipitation: " + Pre + "%" + "\n" + "Humidity: " + Hum + "%" + "\n" +
                "WInd Speed: " + WindSpd + "Km/h");
            txt.Close();
        }

        private void btnRep_Click(object sender, EventArgs e)
        {
            string cities;
            cities = lstCity.GetItemText(lstCity.SelectedItem);
            StartDate = dateTimePicker1.Text;
            EndDate = dateTimePicker2.Text;

            //Forecast frm = new Forecast();
            //frm.MinTemp = MinTmp;
            //frm.MaxTemp = MaxTmp;
            //frm.Precipitation = Pre;
            //frm.Humidity = Hum;
            //frm.WindSpeed = WindSpd;

            string Title = "Report";

            //picks each day in range through a list

            DateTime Start = new DateTime();
            Start = dateTimePicker1.Value;
            DateTime end = new DateTime();
            end = dateTimePicker2.Value;

            Enumerable.Range(0, 1 + end.Subtract(Start).Days).Select(offset => Start.AddDays(offset)).ToArray();

            var dates = new List<DateTime>();
            for (var dt = Start; dt <= end; dt = dt.AddDays(1))
            {
                if (StartDate == Date)
                {

                    //design of message box for report
                    MessageBox.Show("City: " + City + "\n" + "Start Date: " + StartDate + "\n" + "End Date: " + EndDate + "\n" +
                        "Date: " + Date + "\n" +
                "Minimum Temperature: " + MinTmp + "°C" + "\n" + "Maximum Temperature: " + MaxTmp + "°C" + "\n" +
                "Precipitation: " + Pre + "%" + "\n" + "Humidity: " + Hum + "%" + "\n" +
                "WInd Speed: " + WindSpd + "Km/h" + "\n", Title);

                    SaveToFile();
                }
                else

                    dates.Add(dt);
                Random numb = new Random();
                int Mintemp = numb.Next(0, 20);
                int Maxtemp = numb.Next(20, 50);
                int Prec = numb.Next(0, 100);
                int Humid = numb.Next(0, 100);
                int WindSpeed = numb.Next(0, 100);

                //design of message box for report
                MessageBox.Show("City: " + cities + "\n" + "Start Date: " + StartDate + "\n" + "End Date: " + EndDate + "\n" +
                    "Date: " + dt + "\n" +
                "Minimum Temperature: " + Mintemp + "°C" + "\n" + "Maximum Temperature: " + Maxtemp + "°C" + "\n" +
                "Precipitation: " + Prec + "%" + "\n" + "Humidity: " + Humid + "%" + "\n" +
                "WInd Speed: " + WindSpeed + "Km/h" + "\n", Title);

                //save to report
                TextWriter txt = new StreamWriter(@"C:\Users\austi\Desktop\Report.txt");
                txt.Write("Report" + "\n" + "City: " + cities + "\n" + "Start Date: " + StartDate + "\n" + "End Date: " + EndDate + "\n" +
                        "Date: " + dt + "\n" +
                    "Minimum Temperature: " + Mintemp + "°C" + "\n" + "Maximum Temperature: " + Maxtemp + "°C" + "\n" +
                    "Precipitation: " + Prec + "%" + "\n" + "Humidity: " + Humid + "%" + "\n" +
                    "WInd Speed: " + WindSpeed + "Km/h");
                txt.Close();
            }

        }
    }
}

//_________________________code attribution_______________________
// The following code was taken from StackOverFlow:
//Author : user8110171
//Link: https://stackoverflow.com/questions/44353706/cant-pickup-all-dates-between-two-datetimepicker-c-sharp-win-forms
//DateTime start = new DateTime();
//start = dateTimePicker1.Value;
//        DateTime end = new DateTime();
//end = dateTimePicker2.Value;


//        Enumerable.Range(0, 1 + end.Subtract(start).Days)
//        .Select(offset => start.AddDays(offset))
//        .ToArray();

//var dates = new List<DateTime>();

//        for (var dt = start; dt <= end; dt = dt.AddDays(1))
//        {
//            dates.Add(dt);
//            richTextBox1.Text = dt.ToString();

//        }
//_______________________end_______________________________________
