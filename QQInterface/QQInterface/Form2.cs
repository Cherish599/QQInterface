using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QQInterface
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        

        private void Form2_Load(object sender, EventArgs e)
        {
            cn.com.webxml.www.WeatherWebService w = new cn.com.webxml.www.WeatherWebService();
            string[] r = w.getWeatherbyCityName(labCity.Text.Trim());
            /*for (int i = 0; i < 23; i++)
            {
                //textBox2.Text += r[i] + "\r\n";
            }*/

            labTem.Text = r[10].Substring(10, 3);
            string weather = r[6].Substring(7, 2);
            string windDirection = r[10].Substring(20, 3).Trim();

            labWeather.Text = weather + " " + windDirection;

            string humidity = "湿度" + r[10].Substring(r[10].Length-20, 3);
            string airQuality = "空气"+r[10].Substring(r[10].Length-2, 1);

            labAirQuality.Text = airQuality + " " + humidity;

            labTemperature1.Text = r[5].Trim();      //今天的温度区间
            labTemperature2.Text = r[12].Trim();    //明天的温度区间
            labTemperature3.Text = r[17].Trim();    //后天的温度区间

        }
    }
}
