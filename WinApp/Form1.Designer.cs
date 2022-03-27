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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txt_Sunrise = new System.Windows.Forms.TextBox();
            this.txt_Description = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Main
            // 
            this.btn_Main.Location = new System.Drawing.Point(320, 72);
            this.btn_Main.Name = "btn_Main";
            this.btn_Main.Size = new System.Drawing.Size(115, 46);
            this.btn_Main.TabIndex = 0;
            this.btn_Main.Text = "RESULTS";
            this.btn_Main.UseVisualStyleBackColor = true;
            this.btn_Main.Click += new System.EventHandler(this.btn_Main_Click);
            // 
            // txt_ZipCode
            // 
            this.txt_ZipCode.Location = new System.Drawing.Point(327, 12);
            this.txt_ZipCode.Name = "txt_ZipCode";
            this.txt_ZipCode.Size = new System.Drawing.Size(100, 23);
            this.txt_ZipCode.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(266, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Zip Code";
            // 
            // txt_CountryCode
            // 
            this.txt_CountryCode.Location = new System.Drawing.Point(327, 43);
            this.txt_CountryCode.Name = "txt_CountryCode";
            this.txt_CountryCode.Size = new System.Drawing.Size(22, 23);
            this.txt_CountryCode.TabIndex = 3;
            // 
            // txt_Temp
            // 
            this.txt_Temp.Location = new System.Drawing.Point(119, 100);
            this.txt_Temp.Name = "txt_Temp";
            this.txt_Temp.ReadOnly = true;
            this.txt_Temp.Size = new System.Drawing.Size(35, 23);
            this.txt_Temp.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Temperature :";
            // 
            // txt_Longitude
            // 
            this.txt_Longitude.Location = new System.Drawing.Point(119, 15);
            this.txt_Longitude.Name = "txt_Longitude";
            this.txt_Longitude.Size = new System.Drawing.Size(63, 23);
            this.txt_Longitude.TabIndex = 6;
            // 
            // txt_Latitude
            // 
            this.txt_Latitude.Location = new System.Drawing.Point(119, 59);
            this.txt_Latitude.Name = "txt_Latitude";
            this.txt_Latitude.Size = new System.Drawing.Size(63, 23);
            this.txt_Latitude.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Latitude :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Longitude :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(266, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Country";
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.No;
            this.textBox1.Location = new System.Drawing.Point(355, 46);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(100, 16);
            this.textBox1.TabIndex = 11;
            this.textBox1.Text = "US by Default";
            // 
            // txt_Sunrise
            // 
            this.txt_Sunrise.Location = new System.Drawing.Point(84, 146);
            this.txt_Sunrise.Name = "txt_Sunrise";
            this.txt_Sunrise.ReadOnly = true;
            this.txt_Sunrise.Size = new System.Drawing.Size(100, 23);
            this.txt_Sunrise.TabIndex = 12;
            // 
            // txt_Description
            // 
            this.txt_Description.Location = new System.Drawing.Point(119, 205);
            this.txt_Description.Name = "txt_Description";
            this.txt_Description.ReadOnly = true;
            this.txt_Description.Size = new System.Drawing.Size(117, 23);
            this.txt_Description.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 208);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 15);
            this.label6.TabIndex = 14;
            this.label6.Text = "Description :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WinApp.Properties.Resources.mainImage;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_Description);
            this.Controls.Add(this.txt_Sunrise);
            this.Controls.Add(this.textBox1);
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
        
        private void SetBackroundOvercast()
        {
            this.BackgroundImage = Properties.Resources.overcastClouds;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
        }

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
        private TextBox textBox1;
        private TextBox txt_Sunrise;
        private TextBox txt_Description;
        private Label label6;
    }
}