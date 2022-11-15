using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeatherForecast
{
    public partial class Form3 : Form
    {
        //declare variables
        public string StartDate, EndDate;
        public string Date, MinTmp, MaxTmp, Pre, Hum, WindSpd;

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        public string[] City = { "Sandton", "Johannesburg", "Pretoria", "Soweto", "Randburg", "Boksburg", "Edenvale", "Midrand" };

        public Form3()
        {
            InitializeComponent();
        }

        private void btnRep_Click(object sender, EventArgs e)
        {
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
                //picks a city
                Random rand = new Random();
                int index = rand.Next(City.Length);

                dates.Add(dt);
                Random numb = new Random();
                int Mintemp = numb.Next(0, 20);
                int Maxtemp = numb.Next(20, 50);
                int Prec = numb.Next(0, 100);
                int Humid = numb.Next(0, 100);
                int WindSpeed = numb.Next(0, 100);

                //design of message box for report
                MessageBox.Show("City: " + City[index] + "\n" + "Start Date: " + StartDate + "\n" + "End Date: " + EndDate + "\n" +
                    "Date: " + dt + "\n" +
                "Minimum Temperature: " + Mintemp + "°C" + "\n" + "Maximum Temperature: " + Maxtemp + "°C" + "\n" +
                "Precipitation: " + Prec + "%" + "\n" + "Humidity: " + Humid + "%" + "\n" +
                "WInd Speed: " + WindSpeed + "Km/h" + "\n", Title);
            }

        }
    }
}
//			//assigns list values to variable
//			City1 = lstCity.GetItemText(lstCity.SelectedItem);
//			City2 = lstCity2.GetItemText(lstCity2.SelectedItem);
//			City3 = lstCity3.GetItemText(lstCity3.SelectedItem);
//			City4 = lstCity4.GetItemText(lstCity4.SelectedItem);
//			City5 = lstCity5.GetItemText(lstCity5.SelectedItem);
//			City6 = lstCity6.GetItemText(lstCity6.SelectedItem);
//			City7 = lstCity7.GetItemText(lstCity7.SelectedItem);
//			City8 = lstCity8.GetItemText(lstCity8.SelectedItem);
//			StartDate = dateTimePicker1.Text;
//			EndDate = dateTimePicker2.Text;

//			Forecast frm = new Forecast();
//			frm.MinTemp = MinTmp;
//			frm.MaxTemp = MaxTmp;
//			frm.Precipitation = Pre;
//			frm.Humidity = Hum;
//			frm.WindSpeed = WindSpd;

//			string Title = "Report";

//			//picks each day in range through a list
//			DateTime Start = new DateTime();
//			Start = dateTimePicker1.Value;
//			DateTime end = new DateTime();
//			end = dateTimePicker2.Value;

//			Enumerable.Range(0, 1 + end.Subtract(Start).Days).Select(offset => Start.AddDays(offset)).ToArray();

//			var dates = new List<DateTime>();
//			for (var dt = Start; dt <= end; dt = dt.AddDays(1))
//			{
//				dates.Add(dt);

//				Random numb = new Random();
//				int Mintemp = numb.Next(0, 20);
//				int Maxtemp = numb.Next(20, 50);
//				int Prec = numb.Next(0, 100);
//				int Humid = numb.Next(0, 100);
//				int WindSpeed = numb.Next(0, 100);
//				int Mintemp2 = numb.Next(0, 20);
//				int Maxtemp2 = numb.Next(20, 50);
//				int Prec2 = numb.Next(0, 100);
//				int Humid2 = numb.Next(0, 100);
//				int WindSpeed2 = numb.Next(0, 100);
//				int Mintemp3 = numb.Next(0, 20);
//				int Maxtemp3 = numb.Next(20, 50);
//				int Prec3 = numb.Next(0, 100);
//				int Humid3 = numb.Next(0, 100);
//				int WindSpeed3 = numb.Next(0, 100);
//				int Mintemp4 = numb.Next(0, 20);
//				int Maxtemp4 = numb.Next(20, 50);
//				int Prec4 = numb.Next(0, 100);
//				int Humid4 = numb.Next(0, 100);
//				int WindSpeed4 = numb.Next(0, 100);
//				int Mintemp5 = numb.Next(0, 20);
//				int Maxtemp5 = numb.Next(20, 50);
//				int Prec5 = numb.Next(0, 100);
//				int Humid5 = numb.Next(0, 100);
//				int WindSpeed5 = numb.Next(0, 100);
//				int Mintemp6 = numb.Next(0, 20);
//				int Maxtemp6 = numb.Next(20, 50);
//				int Prec6 = numb.Next(0, 100);
//				int Humid6 = numb.Next(0, 100);
//				int WindSpeed6 = numb.Next(0, 100);
//				int Mintemp7 = numb.Next(0, 20);
//				int Maxtemp7 = numb.Next(20, 50);
//				int Prec7 = numb.Next(0, 100);
//				int Humid7 = numb.Next(0, 100);
//				int WindSpeed7 = numb.Next(0, 100);
//				int Mintemp8 = numb.Next(0, 20);
//				int Maxtemp8 = numb.Next(20, 50);
//				int Prec8 = numb.Next(0, 100);
//				int Humid8 = numb.Next(0, 100);
//				int WindSpeed8 = numb.Next(0, 100);

//				//design of message box for report
//				MessageBox.Show("City: " + City1 + "\n" + "Start Date: " + Start + "\n" + "End Date: " + end + "\n" +
//				"Date: " + dt + "\n" +
//				"Minimum Temperature: " + Mintemp + "°C" + "\t" + "Maximum Temperature: " + Maxtemp + "°C" + "\t" +
//				"Precipitation: " + Prec + "%" + "\t" + "Humidity: " + Humid + "%" + "\t" +
//				"WInd Speed: " + WindSpeed + "Km/h" + "\n" +
//				"City: " + City2 + "\t" +
//				"Minimum Temperature: " + Mintemp2 + "°C" + "\t" + "Maximum Temperature: " + Maxtemp2 + "°C" + "\t" +
//				"Precipitation: " + Prec2 + "%" + "\t" + "Humidity: " + Humid2 + "%" + "\t" +
//				"WInd Speed: " + WindSpeed2 + "Km/h" + "\n" +
//				"City: " + City3 + "\t" +
//				"Minimum Temperature: " + Mintemp3 + "°C" + "\t" + "Maximum Temperature: " + Maxtemp3 + "°C" + "\t" +
//				"Precipitation: " + Prec3 + "%" + "\t" + "Humidity: " + Humid3 + "%" + "\t" +
//				"WInd Speed: " + WindSpeed3 + "Km/h" + "\n" +
//				"City: " + City4 + "\t" +
//				"Minimum Temperature: " + Mintemp4 + "°C" + "\t" + "Maximum Temperature: " + Maxtemp4 + "°C" + "\t" +
//				"Precipitation: " + Prec4 + "%" + "\t" + "Humidity: " + Humid4 + "%" + "\t" +
//				"WInd Speed: " + WindSpeed4 + "Km/h" + "\n" +
//				"City: " + City5 + "\t" +
//				"Minimum Temperature: " + Mintemp5 + "°C" + "\t" + "Maximum Temperature: " + Maxtemp5 + "°C" + "\t" +
//				"Precipitation: " + Prec5 + "%" + "\t" + "Humidity: " + Humid5 + "%" + "\t" +
//				"WInd Speed: " + WindSpeed5 + "Km/h" + "\n" +
//				"City: " + City6 + "\t" +
//				"Minimum Temperature: " + Mintemp6 + "°C" + "\t" + "Maximum Temperature: " + Maxtemp6 + "°C" + "\t" +
//				"Precipitation: " + Prec6 + "%" + "\t" + "Humidity: " + Humid6 + "%" + "\t" +
//				"WInd Speed: " + WindSpeed6 + "Km/h" + "\n" +
//				"City: " + City7 + "\t" +
//				"Minimum Temperature: " + Mintemp7 + "°C" + "\t" + "Maximum Temperature: " + Maxtemp7 + "°C" + "\t" +
//				"Precipitation: " + Prec7 + "%" + "\t" + "Humidity: " + Humid7 + "%" + "\t" +
//				"WInd Speed: " + WindSpeed7 + "Km/h" + "\n" +
//				"City: " + City8 + "\t" +
//				"Minimum Temperature: " + Mintemp8 + "°C" + "\t" + "Maximum Temperature: " + Maxtemp8 + "°C" + "\t" +
//				"Precipitation: " + Prec8 + "%" + "\t" + "Humidity: " + Humid8 + "%" + "\t" +
//				"WInd Speed: " + WindSpeed8 + "Km/h" + "\n", Title);
//			}

//		}
//	}
//}
