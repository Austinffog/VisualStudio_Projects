using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherForecast
{
	public class Forecast
	{
		//declare variables
		public string Cities;
		public DateTime Date;
		public string TmpMin, TmpMax, Pre, Hum, WindSpd;

		//public constructors
		public Forecast()
		{

		}

		public Forecast(string city, DateTime date, string tmpmin, string tmpmax, string pre, string hum, string windspd)
		{
			Cities = city;
			Date = date;
			TmpMin = tmpmin;
			TmpMax = tmpmax;
			Pre = pre;
			Hum = hum;
			WindSpd = windspd;
		}

		//get and set methods for each input
		//public properties
		public string City
		{
			get
			{
				return Cities;
			}
			set
			{
				Cities = value;
			}
		}

		public DateTime Dates
		{
			get
			{
				return Date;
			}
			set
			{
				Date = value;
			}
		}

		public string MinTemp
		{
			get
			{
				return TmpMin;
			}
			set
			{
				TmpMin = value;
			}
		}

		public string MaxTemp
		{
			get
			{
				return TmpMax;
			}
			set
			{
				TmpMax = value;
			}
		}

		public string Precipitation
		{
			get
			{
				return Pre;
			}
			set
			{
				Pre = value;
			}
		}

		public string Humidity
		{
			get
			{
				return Hum;
			}
			set
			{
				Hum = value;
			}
		}

		public string WindSpeed
		{
			get
			{
				return WindSpd;
			}
			set
			{
				WindSpd = value;
			}
		}
	}
}

