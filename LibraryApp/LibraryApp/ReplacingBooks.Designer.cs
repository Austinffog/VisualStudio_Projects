
namespace LibraryApp
{
    partial class ReplacingBooks
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
            this.components = new System.ComponentModel.Container();
            this.BtnBegin = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCorrect = new System.Windows.Forms.Label();
            this.BtnDone = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.Button1 = new System.Windows.Forms.Button();
            this.Button2 = new System.Windows.Forms.Button();
            this.Button3 = new System.Windows.Forms.Button();
            this.Button4 = new System.Windows.Forms.Button();
            this.Button5 = new System.Windows.Forms.Button();
            this.Button6 = new System.Windows.Forms.Button();
            this.Button7 = new System.Windows.Forms.Button();
            this.Button8 = new System.Windows.Forms.Button();
            this.Button9 = new System.Windows.Forms.Button();
            this.Button10 = new System.Windows.Forms.Button();
            this.orderNumber1 = new System.Windows.Forms.Label();
            this.orderNumber2 = new System.Windows.Forms.Label();
            this.orderNumber3 = new System.Windows.Forms.Label();
            this.orderNumber4 = new System.Windows.Forms.Label();
            this.orderNumber5 = new System.Windows.Forms.Label();
            this.orderNumber6 = new System.Windows.Forms.Label();
            this.orderNumber7 = new System.Windows.Forms.Label();
            this.orderNumber8 = new System.Windows.Forms.Label();
            this.orderNumber9 = new System.Windows.Forms.Label();
            this.orderNumber10 = new System.Windows.Forms.Label();
            this.txtUserOrder = new System.Windows.Forms.Label();
            this.txtAnswer = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.txtTimeCounter = new System.Windows.Forms.Label();
            this.BtnBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnBegin
            // 
            this.BtnBegin.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnBegin.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBegin.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.BtnBegin.Location = new System.Drawing.Point(144, 537);
            this.BtnBegin.Name = "BtnBegin";
            this.BtnBegin.Size = new System.Drawing.Size(170, 52);
            this.BtnBegin.TabIndex = 1;
            this.BtnBegin.Text = "Begin";
            this.BtnBegin.UseVisualStyleBackColor = false;
            this.BtnBegin.Click += new System.EventHandler(this.BtnBegin_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 23);
            this.label2.TabIndex = 12;
            this.label2.Text = "Call Numbers";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(279, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 23);
            this.label3.TabIndex = 13;
            this.label3.Text = "Users Ordering";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(526, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 23);
            this.label4.TabIndex = 14;
            this.label4.Text = "Correct ordering";
            // 
            // txtCorrect
            // 
            this.txtCorrect.AutoSize = true;
            this.txtCorrect.Location = new System.Drawing.Point(526, 163);
            this.txtCorrect.Name = "txtCorrect";
            this.txtCorrect.Size = new System.Drawing.Size(0, 23);
            this.txtCorrect.TabIndex = 15;
            // 
            // BtnDone
            // 
            this.BtnDone.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnDone.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDone.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.BtnDone.Location = new System.Drawing.Point(356, 537);
            this.BtnDone.Name = "BtnDone";
            this.BtnDone.Size = new System.Drawing.Size(170, 52);
            this.BtnDone.TabIndex = 16;
            this.BtnDone.Text = "Done";
            this.BtnDone.UseVisualStyleBackColor = false;
            this.BtnDone.Click += new System.EventHandler(this.BtnDone_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(641, 23);
            this.label5.TabIndex = 17;
            this.label5.Text = "Instructions: Arrange the call numbers in ascending order before the time runs ou" +
    "t.";
            // 
            // Button1
            // 
            this.Button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Button1.Enabled = false;
            this.Button1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Button1.Location = new System.Drawing.Point(18, 163);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(63, 32);
            this.Button1.TabIndex = 18;
            this.Button1.Text = "000";
            this.Button1.UseVisualStyleBackColor = false;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Button2
            // 
            this.Button2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Button2.Enabled = false;
            this.Button2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Button2.Location = new System.Drawing.Point(18, 201);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(63, 32);
            this.Button2.TabIndex = 19;
            this.Button2.Text = "000";
            this.Button2.UseVisualStyleBackColor = false;
            this.Button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Button3
            // 
            this.Button3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Button3.Enabled = false;
            this.Button3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Button3.Location = new System.Drawing.Point(18, 239);
            this.Button3.Name = "Button3";
            this.Button3.Size = new System.Drawing.Size(63, 32);
            this.Button3.TabIndex = 20;
            this.Button3.Text = "000";
            this.Button3.UseVisualStyleBackColor = false;
            this.Button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // Button4
            // 
            this.Button4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Button4.Enabled = false;
            this.Button4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Button4.Location = new System.Drawing.Point(18, 277);
            this.Button4.Name = "Button4";
            this.Button4.Size = new System.Drawing.Size(63, 32);
            this.Button4.TabIndex = 21;
            this.Button4.Text = "000";
            this.Button4.UseVisualStyleBackColor = false;
            this.Button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // Button5
            // 
            this.Button5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Button5.Enabled = false;
            this.Button5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Button5.Location = new System.Drawing.Point(18, 315);
            this.Button5.Name = "Button5";
            this.Button5.Size = new System.Drawing.Size(63, 32);
            this.Button5.TabIndex = 22;
            this.Button5.Text = "000";
            this.Button5.UseVisualStyleBackColor = false;
            this.Button5.Click += new System.EventHandler(this.Button5_Click);
            // 
            // Button6
            // 
            this.Button6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Button6.Enabled = false;
            this.Button6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button6.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Button6.Location = new System.Drawing.Point(18, 353);
            this.Button6.Name = "Button6";
            this.Button6.Size = new System.Drawing.Size(63, 32);
            this.Button6.TabIndex = 23;
            this.Button6.Text = "000";
            this.Button6.UseVisualStyleBackColor = false;
            this.Button6.Click += new System.EventHandler(this.Button6_Click);
            // 
            // Button7
            // 
            this.Button7.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Button7.Enabled = false;
            this.Button7.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button7.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Button7.Location = new System.Drawing.Point(18, 391);
            this.Button7.Name = "Button7";
            this.Button7.Size = new System.Drawing.Size(63, 32);
            this.Button7.TabIndex = 24;
            this.Button7.Text = "000";
            this.Button7.UseVisualStyleBackColor = false;
            this.Button7.Click += new System.EventHandler(this.Button7_Click);
            // 
            // Button8
            // 
            this.Button8.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Button8.Enabled = false;
            this.Button8.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button8.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Button8.Location = new System.Drawing.Point(18, 429);
            this.Button8.Name = "Button8";
            this.Button8.Size = new System.Drawing.Size(63, 32);
            this.Button8.TabIndex = 25;
            this.Button8.Text = "000";
            this.Button8.UseVisualStyleBackColor = false;
            this.Button8.Click += new System.EventHandler(this.Button8_Click);
            // 
            // Button9
            // 
            this.Button9.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Button9.Enabled = false;
            this.Button9.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button9.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Button9.Location = new System.Drawing.Point(18, 467);
            this.Button9.Name = "Button9";
            this.Button9.Size = new System.Drawing.Size(63, 32);
            this.Button9.TabIndex = 26;
            this.Button9.Text = "000";
            this.Button9.UseVisualStyleBackColor = false;
            this.Button9.Click += new System.EventHandler(this.Button9_Click);
            // 
            // Button10
            // 
            this.Button10.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Button10.Enabled = false;
            this.Button10.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button10.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Button10.Location = new System.Drawing.Point(18, 505);
            this.Button10.Name = "Button10";
            this.Button10.Size = new System.Drawing.Size(63, 32);
            this.Button10.TabIndex = 27;
            this.Button10.Text = "000";
            this.Button10.UseVisualStyleBackColor = false;
            this.Button10.Click += new System.EventHandler(this.Button10_Click);
            // 
            // orderNumber1
            // 
            this.orderNumber1.AutoSize = true;
            this.orderNumber1.Location = new System.Drawing.Point(109, 172);
            this.orderNumber1.Name = "orderNumber1";
            this.orderNumber1.Size = new System.Drawing.Size(20, 23);
            this.orderNumber1.TabIndex = 28;
            this.orderNumber1.Text = "0";
            // 
            // orderNumber2
            // 
            this.orderNumber2.AutoSize = true;
            this.orderNumber2.Location = new System.Drawing.Point(109, 210);
            this.orderNumber2.Name = "orderNumber2";
            this.orderNumber2.Size = new System.Drawing.Size(20, 23);
            this.orderNumber2.TabIndex = 29;
            this.orderNumber2.Text = "0";
            // 
            // orderNumber3
            // 
            this.orderNumber3.AutoSize = true;
            this.orderNumber3.Location = new System.Drawing.Point(109, 248);
            this.orderNumber3.Name = "orderNumber3";
            this.orderNumber3.Size = new System.Drawing.Size(20, 23);
            this.orderNumber3.TabIndex = 30;
            this.orderNumber3.Text = "0";
            // 
            // orderNumber4
            // 
            this.orderNumber4.AutoSize = true;
            this.orderNumber4.Location = new System.Drawing.Point(109, 286);
            this.orderNumber4.Name = "orderNumber4";
            this.orderNumber4.Size = new System.Drawing.Size(20, 23);
            this.orderNumber4.TabIndex = 31;
            this.orderNumber4.Text = "0";
            // 
            // orderNumber5
            // 
            this.orderNumber5.AutoSize = true;
            this.orderNumber5.Location = new System.Drawing.Point(109, 324);
            this.orderNumber5.Name = "orderNumber5";
            this.orderNumber5.Size = new System.Drawing.Size(20, 23);
            this.orderNumber5.TabIndex = 32;
            this.orderNumber5.Text = "0";
            // 
            // orderNumber6
            // 
            this.orderNumber6.AutoSize = true;
            this.orderNumber6.Location = new System.Drawing.Point(109, 362);
            this.orderNumber6.Name = "orderNumber6";
            this.orderNumber6.Size = new System.Drawing.Size(20, 23);
            this.orderNumber6.TabIndex = 33;
            this.orderNumber6.Text = "0";
            // 
            // orderNumber7
            // 
            this.orderNumber7.AutoSize = true;
            this.orderNumber7.Location = new System.Drawing.Point(109, 400);
            this.orderNumber7.Name = "orderNumber7";
            this.orderNumber7.Size = new System.Drawing.Size(20, 23);
            this.orderNumber7.TabIndex = 34;
            this.orderNumber7.Text = "0";
            // 
            // orderNumber8
            // 
            this.orderNumber8.AutoSize = true;
            this.orderNumber8.Location = new System.Drawing.Point(109, 438);
            this.orderNumber8.Name = "orderNumber8";
            this.orderNumber8.Size = new System.Drawing.Size(20, 23);
            this.orderNumber8.TabIndex = 35;
            this.orderNumber8.Text = "0";
            // 
            // orderNumber9
            // 
            this.orderNumber9.AutoSize = true;
            this.orderNumber9.Location = new System.Drawing.Point(109, 476);
            this.orderNumber9.Name = "orderNumber9";
            this.orderNumber9.Size = new System.Drawing.Size(20, 23);
            this.orderNumber9.TabIndex = 36;
            this.orderNumber9.Text = "0";
            // 
            // orderNumber10
            // 
            this.orderNumber10.AutoSize = true;
            this.orderNumber10.Location = new System.Drawing.Point(109, 514);
            this.orderNumber10.Name = "orderNumber10";
            this.orderNumber10.Size = new System.Drawing.Size(20, 23);
            this.orderNumber10.TabIndex = 37;
            this.orderNumber10.Text = "0";
            // 
            // txtUserOrder
            // 
            this.txtUserOrder.AutoSize = true;
            this.txtUserOrder.Location = new System.Drawing.Point(288, 172);
            this.txtUserOrder.Name = "txtUserOrder";
            this.txtUserOrder.Size = new System.Drawing.Size(0, 23);
            this.txtUserOrder.TabIndex = 38;
            // 
            // txtAnswer
            // 
            this.txtAnswer.AutoSize = true;
            this.txtAnswer.Location = new System.Drawing.Point(279, 97);
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.Size = new System.Drawing.Size(0, 23);
            this.txtAnswer.TabIndex = 39;
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // txtTimeCounter
            // 
            this.txtTimeCounter.AutoSize = true;
            this.txtTimeCounter.Location = new System.Drawing.Point(526, 32);
            this.txtTimeCounter.Name = "txtTimeCounter";
            this.txtTimeCounter.Size = new System.Drawing.Size(29, 23);
            this.txtTimeCounter.TabIndex = 40;
            this.txtTimeCounter.Text = "20";
            // 
            // BtnBack
            // 
            this.BtnBack.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnBack.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBack.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.BtnBack.Location = new System.Drawing.Point(18, 13);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(170, 52);
            this.BtnBack.TabIndex = 41;
            this.BtnBack.Text = "Back";
            this.BtnBack.UseVisualStyleBackColor = false;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(243, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Replacing Books";
            // 
            // ReplacingBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(688, 614);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.txtTimeCounter);
            this.Controls.Add(this.txtAnswer);
            this.Controls.Add(this.txtUserOrder);
            this.Controls.Add(this.orderNumber10);
            this.Controls.Add(this.orderNumber9);
            this.Controls.Add(this.orderNumber8);
            this.Controls.Add(this.orderNumber7);
            this.Controls.Add(this.orderNumber6);
            this.Controls.Add(this.orderNumber5);
            this.Controls.Add(this.orderNumber4);
            this.Controls.Add(this.orderNumber3);
            this.Controls.Add(this.orderNumber2);
            this.Controls.Add(this.orderNumber1);
            this.Controls.Add(this.Button10);
            this.Controls.Add(this.Button9);
            this.Controls.Add(this.Button8);
            this.Controls.Add(this.Button7);
            this.Controls.Add(this.Button6);
            this.Controls.Add(this.Button5);
            this.Controls.Add(this.Button4);
            this.Controls.Add(this.Button3);
            this.Controls.Add(this.Button2);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BtnDone);
            this.Controls.Add(this.txtCorrect);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnBegin);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ReplacingBooks";
            this.Text = "ReplacingBooks";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnBegin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label txtCorrect;
        private System.Windows.Forms.Button BtnDone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Button1;
        private System.Windows.Forms.Button Button2;
        private System.Windows.Forms.Button Button3;
        private System.Windows.Forms.Button Button4;
        private System.Windows.Forms.Button Button5;
        private System.Windows.Forms.Button Button6;
        private System.Windows.Forms.Button Button7;
        private System.Windows.Forms.Button Button8;
        private System.Windows.Forms.Button Button9;
        private System.Windows.Forms.Button Button10;
        private System.Windows.Forms.Label orderNumber1;
        private System.Windows.Forms.Label orderNumber2;
        private System.Windows.Forms.Label orderNumber3;
        private System.Windows.Forms.Label orderNumber4;
        private System.Windows.Forms.Label orderNumber5;
        private System.Windows.Forms.Label orderNumber6;
        private System.Windows.Forms.Label orderNumber7;
        private System.Windows.Forms.Label orderNumber8;
        private System.Windows.Forms.Label orderNumber9;
        private System.Windows.Forms.Label orderNumber10;
        private System.Windows.Forms.Label txtUserOrder;
        private System.Windows.Forms.Label txtAnswer;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label txtTimeCounter;
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.Label label1;
    }
}