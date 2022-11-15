namespace WeatherForecast
{
	partial class Form3
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
            this.btnRep = new System.Windows.Forms.Button();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.endDate = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.startDate = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRep
            // 
            this.btnRep.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRep.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRep.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRep.Location = new System.Drawing.Point(106, 242);
            this.btnRep.Name = "btnRep";
            this.btnRep.Size = new System.Drawing.Size(75, 34);
            this.btnRep.TabIndex = 32;
            this.btnRep.Text = "Report";
            this.btnRep.UseVisualStyleBackColor = false;
            this.btnRep.Click += new System.EventHandler(this.btnRep_Click);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(146, 191);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(100, 20);
            this.dateTimePicker2.TabIndex = 31;
            // 
            // endDate
            // 
            this.endDate.AutoSize = true;
            this.endDate.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.endDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endDate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.endDate.Location = new System.Drawing.Point(27, 187);
            this.endDate.Name = "endDate";
            this.endDate.Size = new System.Drawing.Size(96, 24);
            this.endDate.TabIndex = 30;
            this.endDate.Text = "End Date";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(146, 136);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(100, 20);
            this.dateTimePicker1.TabIndex = 28;
            // 
            // startDate
            // 
            this.startDate.AutoSize = true;
            this.startDate.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.startDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startDate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.startDate.Location = new System.Drawing.Point(24, 132);
            this.startDate.Name = "startDate";
            this.startDate.Size = new System.Drawing.Size(99, 24);
            this.startDate.TabIndex = 27;
            this.startDate.Text = "Start Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(261, 57);
            this.label5.TabIndex = 61;
            this.label5.Text = "Choose a date range to receive a \r\nweathercast report between different \r\ncities " +
    "within this range:";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(297, 301);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnRep);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.endDate);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.startDate);
            this.Name = "Form3";
            this.Text = "Weather Forecast Report(Muliply Cities)";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnRep;
		private System.Windows.Forms.DateTimePicker dateTimePicker2;
		private System.Windows.Forms.Label endDate;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.Label startDate;
		private System.Windows.Forms.Label label5;
	}
}