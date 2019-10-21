namespace QQInterface
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labCity = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labTem = new System.Windows.Forms.Label();
            this.labWeather = new System.Windows.Forms.Label();
            this.labAirQuality = new System.Windows.Forms.Label();
            this.labToday = new System.Windows.Forms.Label();
            this.labTomorrow = new System.Windows.Forms.Label();
            this.labAfterTomorrow = new System.Windows.Forms.Label();
            this.labTemperature1 = new System.Windows.Forms.Label();
            this.labTemperature2 = new System.Windows.Forms.Label();
            this.labTemperature3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labCity
            // 
            this.labCity.BackColor = System.Drawing.Color.Transparent;
            this.labCity.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labCity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.labCity.Location = new System.Drawing.Point(47, 97);
            this.labCity.Name = "labCity";
            this.labCity.Size = new System.Drawing.Size(328, 43);
            this.labCity.TabIndex = 3;
            this.labCity.Text = "成都";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.panel1.Controls.Add(this.labTemperature3);
            this.panel1.Controls.Add(this.labTemperature2);
            this.panel1.Controls.Add(this.labTemperature1);
            this.panel1.Controls.Add(this.labAfterTomorrow);
            this.panel1.Controls.Add(this.labTomorrow);
            this.panel1.Controls.Add(this.labToday);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 236);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(507, 207);
            this.panel1.TabIndex = 4;
            // 
            // labTem
            // 
            this.labTem.BackColor = System.Drawing.Color.Transparent;
            this.labTem.Font = new System.Drawing.Font("微软雅黑", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labTem.ForeColor = System.Drawing.Color.White;
            this.labTem.Location = new System.Drawing.Point(47, 27);
            this.labTem.Name = "labTem";
            this.labTem.Size = new System.Drawing.Size(328, 59);
            this.labTem.TabIndex = 5;
            this.labTem.Text = "温度";
            // 
            // labWeather
            // 
            this.labWeather.BackColor = System.Drawing.Color.Transparent;
            this.labWeather.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labWeather.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.labWeather.Location = new System.Drawing.Point(47, 140);
            this.labWeather.Name = "labWeather";
            this.labWeather.Size = new System.Drawing.Size(328, 43);
            this.labWeather.TabIndex = 6;
            this.labWeather.Text = "天气";
            // 
            // labAirQuality
            // 
            this.labAirQuality.BackColor = System.Drawing.Color.Transparent;
            this.labAirQuality.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labAirQuality.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.labAirQuality.Location = new System.Drawing.Point(47, 183);
            this.labAirQuality.Name = "labAirQuality";
            this.labAirQuality.Size = new System.Drawing.Size(328, 43);
            this.labAirQuality.TabIndex = 7;
            this.labAirQuality.Text = "空气质量";
            // 
            // labToday
            // 
            this.labToday.BackColor = System.Drawing.Color.Transparent;
            this.labToday.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labToday.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.labToday.Location = new System.Drawing.Point(36, 21);
            this.labToday.Name = "labToday";
            this.labToday.Size = new System.Drawing.Size(129, 31);
            this.labToday.TabIndex = 8;
            this.labToday.Text = "今天";
            // 
            // labTomorrow
            // 
            this.labTomorrow.BackColor = System.Drawing.Color.Transparent;
            this.labTomorrow.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labTomorrow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.labTomorrow.Location = new System.Drawing.Point(196, 21);
            this.labTomorrow.Name = "labTomorrow";
            this.labTomorrow.Size = new System.Drawing.Size(74, 31);
            this.labTomorrow.TabIndex = 9;
            this.labTomorrow.Text = "明天";
            // 
            // labAfterTomorrow
            // 
            this.labAfterTomorrow.BackColor = System.Drawing.Color.Transparent;
            this.labAfterTomorrow.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labAfterTomorrow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.labAfterTomorrow.Location = new System.Drawing.Point(372, 21);
            this.labAfterTomorrow.Name = "labAfterTomorrow";
            this.labAfterTomorrow.Size = new System.Drawing.Size(71, 31);
            this.labAfterTomorrow.TabIndex = 10;
            this.labAfterTomorrow.Text = "后天";
            // 
            // labTemperature1
            // 
            this.labTemperature1.BackColor = System.Drawing.Color.Transparent;
            this.labTemperature1.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labTemperature1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.labTemperature1.Location = new System.Drawing.Point(36, 73);
            this.labTemperature1.Name = "labTemperature1";
            this.labTemperature1.Size = new System.Drawing.Size(129, 31);
            this.labTemperature1.TabIndex = 11;
            this.labTemperature1.Text = "气温";
            // 
            // labTemperature2
            // 
            this.labTemperature2.BackColor = System.Drawing.Color.Transparent;
            this.labTemperature2.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labTemperature2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.labTemperature2.Location = new System.Drawing.Point(196, 73);
            this.labTemperature2.Name = "labTemperature2";
            this.labTemperature2.Size = new System.Drawing.Size(141, 31);
            this.labTemperature2.TabIndex = 12;
            this.labTemperature2.Text = "气温";
            // 
            // labTemperature3
            // 
            this.labTemperature3.BackColor = System.Drawing.Color.Transparent;
            this.labTemperature3.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labTemperature3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.labTemperature3.Location = new System.Drawing.Point(356, 73);
            this.labTemperature3.Name = "labTemperature3";
            this.labTemperature3.Size = new System.Drawing.Size(139, 31);
            this.labTemperature3.TabIndex = 13;
            this.labTemperature3.Text = "气温";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QQInterface.Properties.Resources.多云1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(507, 443);
            this.Controls.Add(this.labAirQuality);
            this.Controls.Add(this.labWeather);
            this.Controls.Add(this.labTem);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labCity);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label labCity;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labTem;
        private System.Windows.Forms.Label labWeather;
        private System.Windows.Forms.Label labAirQuality;
        private System.Windows.Forms.Label labTemperature3;
        private System.Windows.Forms.Label labTemperature2;
        private System.Windows.Forms.Label labTemperature1;
        private System.Windows.Forms.Label labAfterTomorrow;
        private System.Windows.Forms.Label labTomorrow;
        private System.Windows.Forms.Label labToday;
    }
}