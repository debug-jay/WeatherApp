using IronPython.Hosting;
using System;
using System.IO;
using System.Diagnostics;
using System.Threading.Tasks;

namespace WinApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Main = new System.Windows.Forms.Button();
            this.txt_ZipCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_CountryCode = new System.Windows.Forms.TextBox();
            this.txt_Temp = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Longitude = new System.Windows.Forms.TextBox();
            this.txt_Latitude = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Description = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_UTC_TIME = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_CURRENT_DATE = new System.Windows.Forms.TextBox();
            this.txt_State = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_Country = new System.Windows.Forms.TextBox();
            this.txt_TimeZone = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_CityName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_Main
            // 
            this.btn_Main.BackColor = System.Drawing.Color.LightBlue;
            this.btn_Main.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Main.ForeColor = System.Drawing.Color.Black;
            this.btn_Main.Location = new System.Drawing.Point(327, 77);
            this.btn_Main.Name = "btn_Main";
            this.btn_Main.Size = new System.Drawing.Size(115, 46);
            this.btn_Main.TabIndex = 0;
            this.btn_Main.Text = "RESULTS";
            this.btn_Main.UseVisualStyleBackColor = false;
            this.btn_Main.Click += new System.EventHandler(this.btn_Main_Click);
            // 
            // txt_ZipCode
            // 
            this.txt_ZipCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txt_ZipCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_ZipCode.Location = new System.Drawing.Point(327, 12);
            this.txt_ZipCode.Name = "txt_ZipCode";
            this.txt_ZipCode.Size = new System.Drawing.Size(53, 23);
            this.txt_ZipCode.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(251, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Zip Code";
            // 
            // txt_CountryCode
            // 
            this.txt_CountryCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txt_CountryCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_CountryCode.Location = new System.Drawing.Point(327, 46);
            this.txt_CountryCode.Name = "txt_CountryCode";
            this.txt_CountryCode.Size = new System.Drawing.Size(22, 23);
            this.txt_CountryCode.TabIndex = 3;
            // 
            // txt_Temp
            // 
            this.txt_Temp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txt_Temp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Temp.Location = new System.Drawing.Point(119, 100);
            this.txt_Temp.Name = "txt_Temp";
            this.txt_Temp.ReadOnly = true;
            this.txt_Temp.Size = new System.Drawing.Size(35, 23);
            this.txt_Temp.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(9, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Temperature :";
            // 
            // txt_Longitude
            // 
            this.txt_Longitude.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txt_Longitude.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Longitude.Location = new System.Drawing.Point(119, 15);
            this.txt_Longitude.Name = "txt_Longitude";
            this.txt_Longitude.Size = new System.Drawing.Size(63, 23);
            this.txt_Longitude.TabIndex = 6;
            // 
            // txt_Latitude
            // 
            this.txt_Latitude.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txt_Latitude.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Latitude.Location = new System.Drawing.Point(119, 59);
            this.txt_Latitude.Name = "txt_Latitude";
            this.txt_Latitude.Size = new System.Drawing.Size(63, 23);
            this.txt_Latitude.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(41, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Latitude :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(27, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Longitude :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(256, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Country";
            // 
            // txt_Description
            // 
            this.txt_Description.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txt_Description.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Description.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_Description.Location = new System.Drawing.Point(119, 142);
            this.txt_Description.Name = "txt_Description";
            this.txt_Description.ReadOnly = true;
            this.txt_Description.Size = new System.Drawing.Size(188, 27);
            this.txt_Description.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(18, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Description :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(355, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 15);
            this.label7.TabIndex = 15;
            this.label7.Text = "US by Default";
            // 
            // txt_UTC_TIME
            // 
            this.txt_UTC_TIME.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txt_UTC_TIME.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_UTC_TIME.Location = new System.Drawing.Point(608, 10);
            this.txt_UTC_TIME.Name = "txt_UTC_TIME";
            this.txt_UTC_TIME.Size = new System.Drawing.Size(100, 23);
            this.txt_UTC_TIME.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(496, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 20);
            this.label8.TabIndex = 17;
            this.label8.Text = "Current Time :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(497, 51);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 20);
            this.label9.TabIndex = 18;
            this.label9.Text = "Current Date :";
            // 
            // txt_CURRENT_DATE
            // 
            this.txt_CURRENT_DATE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txt_CURRENT_DATE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_CURRENT_DATE.Location = new System.Drawing.Point(608, 51);
            this.txt_CURRENT_DATE.Name = "txt_CURRENT_DATE";
            this.txt_CURRENT_DATE.Size = new System.Drawing.Size(100, 23);
            this.txt_CURRENT_DATE.TabIndex = 19;
            // 
            // txt_State
            // 
            this.txt_State.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txt_State.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_State.Location = new System.Drawing.Point(608, 128);
            this.txt_State.Name = "txt_State";
            this.txt_State.Size = new System.Drawing.Size(25, 23);
            this.txt_State.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(551, 131);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 20);
            this.label10.TabIndex = 21;
            this.label10.Text = "State :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(529, 91);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 20);
            this.label11.TabIndex = 22;
            this.label11.Text = "Country :";
            // 
            // txt_Country
            // 
            this.txt_Country.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txt_Country.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Country.Location = new System.Drawing.Point(609, 91);
            this.txt_Country.Name = "txt_Country";
            this.txt_Country.Size = new System.Drawing.Size(24, 23);
            this.txt_Country.TabIndex = 23;
            // 
            // txt_TimeZone
            // 
            this.txt_TimeZone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txt_TimeZone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_TimeZone.Location = new System.Drawing.Point(608, 166);
            this.txt_TimeZone.Name = "txt_TimeZone";
            this.txt_TimeZone.Size = new System.Drawing.Size(100, 23);
            this.txt_TimeZone.TabIndex = 24;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(513, 169);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(89, 20);
            this.label12.TabIndex = 25;
            this.label12.Text = "Time Zone :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(521, 208);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(44, 15);
            this.label13.TabIndex = 26;
            this.label13.Text = "label13";
            // 
            // txt_CityName
            // 
            this.txt_CityName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txt_CityName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_CityName.Location = new System.Drawing.Point(618, 206);
            this.txt_CityName.Name = "txt_CityName";
            this.txt_CityName.Size = new System.Drawing.Size(100, 23);
            this.txt_CityName.TabIndex = 27;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WinApp.Properties.Resources.mainImage;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_CityName);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txt_TimeZone);
            this.Controls.Add(this.txt_Country);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txt_State);
            this.Controls.Add(this.txt_CURRENT_DATE);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_UTC_TIME);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_Description);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_Latitude);
            this.Controls.Add(this.txt_Longitude);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Temp);
            this.Controls.Add(this.txt_CountryCode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_ZipCode);
            this.Controls.Add(this.btn_Main);
            this.Name = "Form1";
            this.Text = "WeatherApp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


        #region My Functinos For This Form Design


        /*  SetCoordinates      ->   Sets Coordinates from Python Script.  
         *  StartScript         ->   Starts Python File Script for Getting Lon / Lat Coordinates of Entered ZipCode
         *  GetBackround        ->   Gets the Backround and Changes it to the Corresponding Weather In That Area.
            DeleteFiles         ->   Deletes Uneeded / Unused Files From Explorer.                                */



        private async void SetCoordinates(string zipCode, string countryCode)
        {
            StartScript(zipCode, countryCode);
            Thread.Sleep(475);

            string lat_text = System.IO.File.ReadAllText("pythonLat.txt");
            string lon_text = System.IO.File.ReadAllText("pythonLon.txt");

            txt_Longitude.Text = lon_text;
            txt_Latitude.Text = lat_text;

        }


        private async void StartScript(string zip, string cc)
        {

            string fileName = "newFile.py";

            using StreamWriter zip_code = new("ZipCode.txt", append: false);
            await zip_code.WriteAsync(zip);
            zip_code.Close();

            using StreamWriter country_code = new("CountryCode.txt", append: false);
            await country_code.WriteAsync(cc);
            country_code.Close();

            Process p = new Process();
            p.StartInfo = new ProcessStartInfo("python.exe", fileName)
            {
                RedirectStandardOutput = false,
                UseShellExecute = false,
                CreateNoWindow = true
            };
            p.Start();

        }


        private void getBackround()
        {
            if (txt_Description.Text == "overcast clouds")
            {
                this.BackgroundImage = Properties.Resources.overcastClouds;
                this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            }
            else if (txt_Description.Text.Contains("clear"))
            {
                this.BackgroundImage = Properties.Resources.clearSky;
                this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            }
            else if (txt_Description.Text.Contains("rain"))
            {
                this.BackgroundImage = Properties.Resources.heavy_rain;
                this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            }
        }


        private void DeleteFiles()
        {
            File.Delete("pythonLat.txt");
            File.Delete("pythonLon.txt");
            File.Delete("ZipCode.txt");
            File.Delete("CountryCode.txt");
        }

        #endregion


        private Button btn_Main;
        private TextBox txt_ZipCode;
        private Label label1;
        private TextBox txt_CountryCode;
        private TextBox txt_Temp;
        private Label label2;
        private TextBox txt_Longitude;
        private TextBox txt_Latitude;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txt_Description;
        private Label label6;
        private Label label7;
        private TextBox txt_UTC_TIME;
        private Label label8;
        private Label label9;
        private TextBox txt_CURRENT_DATE;
        private TextBox txt_State;
        private Label label10;
        private Label label11;
        private TextBox txt_Country;
        private TextBox txt_TimeZone;
        private Label label12;
        private Label label13;
        private TextBox txt_CityName;
    }
}