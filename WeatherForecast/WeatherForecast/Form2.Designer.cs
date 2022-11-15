namespace WeatherForecast
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
            this.lstCity = new System.Windows.Forms.ListBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.startDate = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.endDate = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.btnRep = new System.Windows.Forms.Button();
            this.btnMore = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
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
            this.lstCity.Location = new System.Drawing.Point(200, 83);
            this.lstCity.Name = "lstCity";
            this.lstCity.Size = new System.Drawing.Size(100, 26);
            this.lstCity.TabIndex = 21;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(200, 140);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(100, 20);
            this.dateTimePicker1.TabIndex = 20;
            // 
            // startDate
            // 
            this.startDate.AutoSize = true;
            this.startDate.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.startDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startDate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.startDate.Location = new System.Drawing.Point(48, 136);
            this.startDate.Name = "startDate";
            this.startDate.Size = new System.Drawing.Size(99, 24);
            this.startDate.TabIndex = 19;
            this.startDate.Text = "Start Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(67, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(234, 72);
            this.label3.TabIndex = 22;
            this.label3.Text = "Enter a specific city and date range: \r\nTo view mulitple weather reports \r\nwithin" +
    " a single city.";
            // 
            // endDate
            // 
            this.endDate.AutoSize = true;
            this.endDate.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.endDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endDate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.endDate.Location = new System.Drawing.Point(48, 186);
            this.endDate.Name = "endDate";
            this.endDate.Size = new System.Drawing.Size(96, 24);
            this.endDate.TabIndex = 23;
            this.endDate.Text = "End Date";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(200, 190);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(100, 20);
            this.dateTimePicker2.TabIndex = 24;
            // 
            // btnRep
            // 
            this.btnRep.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRep.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRep.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRep.Location = new System.Drawing.Point(137, 273);
            this.btnRep.Name = "btnRep";
            this.btnRep.Size = new System.Drawing.Size(75, 34);
            this.btnRep.TabIndex = 25;
            this.btnRep.Text = "Report";
            this.btnRep.UseVisualStyleBackColor = false;
            this.btnRep.Click += new System.EventHandler(this.btnRep_Click);
            // 
            // btnMore
            // 
            this.btnMore.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnMore.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMore.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMore.Location = new System.Drawing.Point(250, 273);
            this.btnMore.Name = "btnMore";
            this.btnMore.Size = new System.Drawing.Size(75, 34);
            this.btnMore.TabIndex = 26;
            this.btnMore.Text = "More";
            this.btnMore.UseVisualStyleBackColor = false;
            this.btnMore.Click += new System.EventHandler(this.btnMore_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(48, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 24);
            this.label1.TabIndex = 27;
            this.label1.Text = "City";
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEdit.Location = new System.Drawing.Point(16, 273);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 34);
            this.btnEdit.TabIndex = 28;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Font = new System.Drawing.Font("Javanese Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 50);
            this.label2.TabIndex = 29;
            this.label2.Text = "Only Weatherforecasters \r\ncan edit.";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(361, 319);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMore);
            this.Controls.Add(this.btnRep);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.endDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lstCity);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.startDate);
            this.Name = "Form2";
            this.Text = "Weather Forecast Report";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListBox lstCity;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.Label startDate;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label endDate;
		private System.Windows.Forms.DateTimePicker dateTimePicker2;
		private System.Windows.Forms.Button btnRep;
		private System.Windows.Forms.Button btnMore;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label label2;
    }
}