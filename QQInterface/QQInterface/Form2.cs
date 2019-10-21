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



            //今天的天气图标变化
            if (r[6].Substring(r[6].Length - 1, 1) == "雨")
            {
                pictureBox1.BackgroundImage = Image.FromFile("weatherPic\\weather-forecast-16.png");
                BackgroundImage = Image.FromFile("weatherBg\\雷电1.jpeg");
            }
            else if (r[6].Substring(r[6].Length - 2, 2) == "多云")
            {
                pictureBox1.BackgroundImage = Image.FromFile("weatherPic\\weather-forecast-09.png");
            }
            else if (r[6].Substring(r[6].Length - 1, 1) == "晴")
            {
                pictureBox1.BackgroundImage = Image.FromFile("weatherPic\\weather-forecast-08.png");
            }
            else if (r[6].Substring(r[6].Length - 1, 1) == "阴")
            {
                pictureBox1.BackgroundImage = Image.FromFile("weatherPic\\weather-forecast-03.png");
            }
            

            //明天的天气图标变化
            if (r[13].Substring(r[13].Length - 1, 1) == "雨")
            {
                pictureBox2.BackgroundImage = Image.FromFile("weatherPic\\weather-forecast-16.png");
            }
            else if (r[13].Substring(r[13].Length - 2, 2) == "多云")
            {
                pictureBox2.BackgroundImage = Image.FromFile("weatherPic\\weather-forecast-09.png");
            }
            else if (r[13].Substring(r[13].Length - 1, 1) == "晴")
            {
                pictureBox2.BackgroundImage = Image.FromFile("weatherPic\\weather-forecast-08.png");
            }
            else if (r[13].Substring(r[13].Length - 1, 1) == "阴")
            {
                pictureBox2.BackgroundImage = Image.FromFile("weatherPic\\weather-forecast-03.png");
            }


            //后天的天气图标变化
            if (r[18].Substring(r[18].Length - 1, 1) == "雨")
            {
                pictureBox3.BackgroundImage = Image.FromFile("weatherPic\\weather-forecast-16.png");
            }
            else if (r[18].Substring(r[18].Length - 2, 2) == "多云")
            {
                pictureBox3.BackgroundImage = Image.FromFile("weatherPic\\weather-forecast-09.png");
            }
            else if (r[18].Substring(r[18].Length - 1, 1) == "晴")
            {
                pictureBox3.BackgroundImage = Image.FromFile("weatherPic\\weather-forecast-08.png");
            }
            else if (r[18].Substring(r[18].Length - 1, 1) == "阴")
            {
                pictureBox3.BackgroundImage = Image.FromFile("weatherPic\\weather-forecast-03.png");
            }

        }

        private void labTemperature2_Click(object sender, EventArgs e)
        {

        }
    }
}
