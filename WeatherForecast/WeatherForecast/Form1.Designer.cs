namespace WeatherForecast
{
	partial class WeatherForecast
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMinTmp = new System.Windows.Forms.TextBox();
            this.txtMaxTmp = new System.Windows.Forms.TextBox();
            this.txtPre = new System.Windows.Forms.TextBox();
            this.txtHum = new System.Windows.Forms.TextBox();
            this.txtWindSpd = new System.Windows.Forms.TextBox();
            this.btnRep = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lstCity = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnUser = new System.Windows.Forms.Button();
            this.tempmin = new System.Windows.Forms.Label();
            this.tempmax = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(51, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "City";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(51, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(51, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(221, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Minimum Temperature";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(51, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(226, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Maximum Temperature";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(51, 267);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "Precipitation";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(51, 317);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 24);
            this.label6.TabIndex = 5;
            this.label6.Text = "Humidity";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(51, 365);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 24);
            this.label7.TabIndex = 6;
            this.label7.Text = "Wind Speed";
            // 
            // txtMinTmp
            // 
            this.txtMinTmp.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMinTmp.Location = new System.Drawing.Point(287, 166);
            this.txtMinTmp.Name = "txtMinTmp";
            this.txtMinTmp.Size = new System.Drawing.Size(100, 29);
            this.txtMinTmp.TabIndex = 9;
            this.txtMinTmp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMinTmp_KeyPress);
            // 
            // txtMaxTmp
            // 
            this.txtMaxTmp.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaxTmp.Location = new System.Drawing.Point(287, 214);
            this.txtMaxTmp.Name = "txtMaxTmp";
            this.txtMaxTmp.Size = new System.Drawing.Size(100, 29);
            this.txtMaxTmp.TabIndex = 10;
            this.txtMaxTmp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaxTmp_KeyPress);
            // 
            // txtPre
            // 
            this.txtPre.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPre.Location = new System.Drawing.Point(287, 262);
            this.txtPre.Name = "txtPre";
            this.txtPre.Size = new System.Drawing.Size(100, 29);
            this.txtPre.TabIndex = 11;
            this.txtPre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPre_KeyPress);
            // 
            // txtHum
            // 
            this.txtHum.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHum.Location = new System.Drawing.Point(287, 312);
            this.txtHum.Name = "txtHum";
            this.txtHum.Size = new System.Drawing.Size(100, 29);
            this.txtHum.TabIndex = 12;
            this.txtHum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHum_KeyPress);
            // 
            // txtWindSpd
            // 
            this.txtWindSpd.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWindSpd.Location = new System.Drawing.Point(287, 360);
            this.txtWindSpd.Name = "txtWindSpd";
            this.txtWindSpd.Size = new System.Drawing.Size(100, 29);
            this.txtWindSpd.TabIndex = 13;
            this.txtWindSpd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtWindSpd_KeyPress);
            // 
            // btnRep
            // 
            this.btnRep.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRep.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRep.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRep.Location = new System.Drawing.Point(177, 398);
            this.btnRep.Name = "btnRep";
            this.btnRep.Size = new System.Drawing.Size(75, 34);
            this.btnRep.TabIndex = 15;
            this.btnRep.Text = "Report";
            this.btnRep.UseVisualStyleBackColor = false;
            this.btnRep.Click += new System.EventHandler(this.btnRep_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(287, 124);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(100, 20);
            this.dateTimePicker1.TabIndex = 16;
            // 
            // lstCity
            // 
            this.lstCity.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstCity.FormattingEnabled = true;
            this.lstCity.ItemHeight = 22;
            this.lstCity.Items.AddRange(new object[] {
            "Sandton",
            "Pretoria",
            "Johannesburg",
            "Soweto",
            "Randburg",
            "Boksburg",
            "Edenvale",
            "Midrand"});
            this.lstCity.Location = new System.Drawing.Point(287, 69);
            this.lstCity.Name = "lstCity";
            this.lstCity.Size = new System.Drawing.Size(100, 26);
            this.lstCity.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(135, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(156, 20);
            this.label8.TabIndex = 18;
            this.label8.Text = "Weather Forecaster";
            // 
            // btnUser
            // 
            this.btnUser.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnUser.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUser.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUser.Location = new System.Drawing.Point(301, 398);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(75, 34);
            this.btnUser.TabIndex = 19;
            this.btnUser.Text = "View";
            this.btnUser.UseVisualStyleBackColor = false;
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // tempmin
            // 
            this.tempmin.AutoSize = true;
            this.tempmin.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tempmin.Location = new System.Drawing.Point(393, 172);
            this.tempmin.Name = "tempmin";
            this.tempmin.Size = new System.Drawing.Size(22, 17);
            this.tempmin.TabIndex = 20;
            this.tempmin.Text = "°C";
            // 
            // tempmax
            // 
            this.tempmax.AutoSize = true;
            this.tempmax.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tempmax.Location = new System.Drawing.Point(393, 220);
            this.tempmax.Name = "tempmax";
            this.tempmax.Size = new System.Drawing.Size(22, 17);
            this.tempmax.TabIndex = 21;
            this.tempmax.Text = "°C";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(393, 272);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(17, 17);
            this.label9.TabIndex = 22;
            this.label9.Text = "%";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(393, 318);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(17, 17);
            this.label10.TabIndex = 23;
            this.label10.Text = "%";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(393, 365);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(39, 17);
            this.label11.TabIndex = 24;
            this.label11.Text = "km/h";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(138, 46);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(139, 17);
            this.label12.TabIndex = 25;
            this.label12.Text = "Insert values and edit:";
            // 
            // login
            // 
            this.login.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.login.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.login.Location = new System.Drawing.Point(55, 398);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(75, 34);
            this.login.TabIndex = 26;
            this.login.Text = "Login";
            this.login.UseVisualStyleBackColor = false;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // WeatherForecast
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(449, 444);
            this.Controls.Add(this.login);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tempmax);
            this.Controls.Add(this.tempmin);
            this.Controls.Add(this.btnUser);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lstCity);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnRep);
            this.Controls.Add(this.txtWindSpd);
            this.Controls.Add(this.txtHum);
            this.Controls.Add(this.txtPre);
            this.Controls.Add(this.txtMaxTmp);
            this.Controls.Add(this.txtMinTmp);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "WeatherForecast";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Weather Forecast";
            this.Load += new System.EventHandler(this.WeatherForecast_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txtMinTmp;
		private System.Windows.Forms.TextBox txtMaxTmp;
		private System.Windows.Forms.TextBox txtPre;
		private System.Windows.Forms.TextBox txtHum;
		private System.Windows.Forms.TextBox txtWindSpd;
		private System.Windows.Forms.Button btnRep;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.ListBox lstCity;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Button btnUser;
        private System.Windows.Forms.Label tempmin;
        private System.Windows.Forms.Label tempmax;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button login;
    }
}

