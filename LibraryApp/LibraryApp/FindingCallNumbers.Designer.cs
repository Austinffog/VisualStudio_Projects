
namespace LibraryApp
{
    partial class FindingCallNumbers
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
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtQuestion = new System.Windows.Forms.Label();
            this.BtnBack = new System.Windows.Forms.Button();
            this.txtAnswer1 = new System.Windows.Forms.Label();
            this.txtAnswer2 = new System.Windows.Forms.Label();
            this.txtAnswer3 = new System.Windows.Forms.Label();
            this.txtAnswer4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnQ1 = new System.Windows.Forms.Button();
            this.btnQ2 = new System.Windows.Forms.Button();
            this.btnQ3 = new System.Windows.Forms.Button();
            this.btnQ4 = new System.Windows.Forms.Button();
            this.txtValidation = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.txtTimeCounter = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(251, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "Finding Call Numbers";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Sitka Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(70, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(598, 21);
            this.label5.TabIndex = 19;
            this.label5.Text = "Instructions: Choose the correct option for the question, and see how long you ta" +
    "ke.";
            // 
            // txtQuestion
            // 
            this.txtQuestion.AutoSize = true;
            this.txtQuestion.Font = new System.Drawing.Font("Sitka Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuestion.ForeColor = System.Drawing.Color.DarkGreen;
            this.txtQuestion.Location = new System.Drawing.Point(157, 143);
            this.txtQuestion.Name = "txtQuestion";
            this.txtQuestion.Size = new System.Drawing.Size(276, 21);
            this.txtQuestion.TabIndex = 20;
            this.txtQuestion.Text = "Click to Start: Will generate question.";
            this.txtQuestion.Click += new System.EventHandler(this.txtQuestion_Click);
            // 
            // BtnBack
            // 
            this.BtnBack.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnBack.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBack.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.BtnBack.Location = new System.Drawing.Point(21, 36);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(170, 52);
            this.BtnBack.TabIndex = 72;
            this.BtnBack.Text = "Back";
            this.BtnBack.UseVisualStyleBackColor = false;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // txtAnswer1
            // 
            this.txtAnswer1.AutoSize = true;
            this.txtAnswer1.Enabled = false;
            this.txtAnswer1.Font = new System.Drawing.Font("Sitka Text", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnswer1.Location = new System.Drawing.Point(85, 226);
            this.txtAnswer1.Name = "txtAnswer1";
            this.txtAnswer1.Size = new System.Drawing.Size(150, 39);
            this.txtAnswer1.TabIndex = 73;
            this.txtAnswer1.Text = "Answer 1: ";
            this.txtAnswer1.Click += new System.EventHandler(this.txtAnswer1_Click);
            // 
            // txtAnswer2
            // 
            this.txtAnswer2.AutoSize = true;
            this.txtAnswer2.Enabled = false;
            this.txtAnswer2.Font = new System.Drawing.Font("Sitka Text", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnswer2.Location = new System.Drawing.Point(85, 285);
            this.txtAnswer2.Name = "txtAnswer2";
            this.txtAnswer2.Size = new System.Drawing.Size(153, 39);
            this.txtAnswer2.TabIndex = 74;
            this.txtAnswer2.Text = "Answer 2: ";
            this.txtAnswer2.Click += new System.EventHandler(this.txtAnswer2_Click);
            // 
            // txtAnswer3
            // 
            this.txtAnswer3.AutoSize = true;
            this.txtAnswer3.Enabled = false;
            this.txtAnswer3.Font = new System.Drawing.Font("Sitka Text", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnswer3.Location = new System.Drawing.Point(85, 342);
            this.txtAnswer3.Name = "txtAnswer3";
            this.txtAnswer3.Size = new System.Drawing.Size(153, 39);
            this.txtAnswer3.TabIndex = 75;
            this.txtAnswer3.Text = "Answer 3: ";
            this.txtAnswer3.Click += new System.EventHandler(this.txtAnswer3_Click);
            // 
            // txtAnswer4
            // 
            this.txtAnswer4.AutoSize = true;
            this.txtAnswer4.Enabled = false;
            this.txtAnswer4.Font = new System.Drawing.Font("Sitka Text", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnswer4.Location = new System.Drawing.Point(85, 396);
            this.txtAnswer4.Name = "txtAnswer4";
            this.txtAnswer4.Size = new System.Drawing.Size(154, 39);
            this.txtAnswer4.TabIndex = 76;
            this.txtAnswer4.Text = "Answer 4: ";
            this.txtAnswer4.Click += new System.EventHandler(this.txtAnswer4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(157, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(445, 21);
            this.label2.TabIndex = 77;
            this.label2.Text = "Click each answer (black text) after the question is displayed.";
            // 
            // btnQ1
            // 
            this.btnQ1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnQ1.Enabled = false;
            this.btnQ1.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQ1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnQ1.Location = new System.Drawing.Point(550, 226);
            this.btnQ1.Name = "btnQ1";
            this.btnQ1.Size = new System.Drawing.Size(170, 39);
            this.btnQ1.TabIndex = 78;
            this.btnQ1.Text = "Q1";
            this.btnQ1.UseVisualStyleBackColor = false;
            this.btnQ1.Click += new System.EventHandler(this.btnQ1_Click);
            // 
            // btnQ2
            // 
            this.btnQ2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnQ2.Enabled = false;
            this.btnQ2.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQ2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnQ2.Location = new System.Drawing.Point(550, 285);
            this.btnQ2.Name = "btnQ2";
            this.btnQ2.Size = new System.Drawing.Size(170, 39);
            this.btnQ2.TabIndex = 79;
            this.btnQ2.Text = "Q2";
            this.btnQ2.UseVisualStyleBackColor = false;
            this.btnQ2.Click += new System.EventHandler(this.btnQ2_Click);
            // 
            // btnQ3
            // 
            this.btnQ3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnQ3.Enabled = false;
            this.btnQ3.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQ3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnQ3.Location = new System.Drawing.Point(550, 342);
            this.btnQ3.Name = "btnQ3";
            this.btnQ3.Size = new System.Drawing.Size(170, 39);
            this.btnQ3.TabIndex = 80;
            this.btnQ3.Text = "Q3";
            this.btnQ3.UseVisualStyleBackColor = false;
            this.btnQ3.Click += new System.EventHandler(this.btnQ3_Click);
            // 
            // btnQ4
            // 
            this.btnQ4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnQ4.Enabled = false;
            this.btnQ4.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQ4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnQ4.Location = new System.Drawing.Point(550, 396);
            this.btnQ4.Name = "btnQ4";
            this.btnQ4.Size = new System.Drawing.Size(170, 39);
            this.btnQ4.TabIndex = 81;
            this.btnQ4.Text = "Q4";
            this.btnQ4.UseVisualStyleBackColor = false;
            this.btnQ4.Click += new System.EventHandler(this.btnQ4_Click);
            // 
            // txtValidation
            // 
            this.txtValidation.AutoSize = true;
            this.txtValidation.Font = new System.Drawing.Font("Sitka Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValidation.Location = new System.Drawing.Point(147, 469);
            this.txtValidation.Name = "txtValidation";
            this.txtValidation.Size = new System.Drawing.Size(0, 21);
            this.txtValidation.TabIndex = 82;
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            // 
            // txtTimeCounter
            // 
            this.txtTimeCounter.AutoSize = true;
            this.txtTimeCounter.Location = new System.Drawing.Point(567, 55);
            this.txtTimeCounter.Name = "txtTimeCounter";
            this.txtTimeCounter.Size = new System.Drawing.Size(20, 23);
            this.txtTimeCounter.TabIndex = 83;
            this.txtTimeCounter.Text = "0";
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNext.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnNext.Location = new System.Drawing.Point(498, 509);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(170, 52);
            this.btnNext.TabIndex = 84;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // FindingCallNumbers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(732, 586);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.txtTimeCounter);
            this.Controls.Add(this.txtValidation);
            this.Controls.Add(this.btnQ4);
            this.Controls.Add(this.btnQ3);
            this.Controls.Add(this.btnQ2);
            this.Controls.Add(this.btnQ1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAnswer4);
            this.Controls.Add(this.txtAnswer3);
            this.Controls.Add(this.txtAnswer2);
            this.Controls.Add(this.txtAnswer1);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.txtQuestion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FindingCallNumbers";
            this.Text = "FindingCallNumbers";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label txtQuestion;
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.Label txtAnswer1;
        private System.Windows.Forms.Label txtAnswer2;
        private System.Windows.Forms.Label txtAnswer3;
        private System.Windows.Forms.Label txtAnswer4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnQ1;
        private System.Windows.Forms.Button btnQ2;
        private System.Windows.Forms.Button btnQ3;
        private System.Windows.Forms.Button btnQ4;
        private System.Windows.Forms.Label txtValidation;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label txtTimeCounter;
        private System.Windows.Forms.Button btnNext;
    }
}